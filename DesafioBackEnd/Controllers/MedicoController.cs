using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;
using DesafioBackEnd.Api.Request;
using DesafioBackEnd.Api.Response;
using DesafioBackEnd.Data.Context;
using DesafioBackEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioBackEnd.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly Contexto contexto;

        public MedicoController(Contexto contexto)
        {
            this.contexto = contexto;
        }

        [HttpGet]
        public List<Medico> Get() => contexto.Medico.ToList();

        [HttpGet("especialidade")]
        [ProducesResponseType(typeof(MedicoResponse), 200)]
        public IActionResult GetEspecialidade(string nomeEspecialidade)
        {
            var medico = contexto.Medico.FirstOrDefault(
                m => m.Especialidade == nomeEspecialidade);

            return StatusCode(medico == null
                ? 404 :
                200, new MedicoResponse
                {
                    IdMedico = medico == null ? -1
                    : medico.IdMedico,

                    NomeMedico = medico == null ? "Médico com esse nome não foi encontrado!"
                    : medico.NomeMedico,

                    CPF = medico == null ? "Médico com esse CPF não encontrado!" 
                    : medico.CPF,

                    CRM = medico == null ? "Médico com esse CRM não encontrado!"
                    : medico.CRM,

                    Especialidade = medico == null ? "Médico com essa especialidade não encontrado!"
                    : medico.Especialidade
                });
        }

        [HttpPost]
        [ProducesResponseType(typeof(MedicoResponse), 200)]
        [ProducesResponseType(400)]
        public IActionResult Post([FromBody] 
            MedicoRequest medicoRequest)
        {
            var medico = new Medico
            {
                NomeMedico = medicoRequest.NomeMedico,
                Especialidade = medicoRequest.Especialidade,
                CPF = medicoRequest.CPF,
                CRM = medicoRequest.CRM
            };

            contexto.Medico.Add(medico);
            contexto.SaveChanges();

            var medicoRetorno = contexto.Medico.Where
                (m => m.IdMedico == medico.IdMedico)
                .FirstOrDefault();

            MedicoResponse response = new MedicoResponse();

            if(medicoRetorno != null)
            {
                response.IdMedico = medicoRetorno.IdMedico;
                response.NomeMedico = medicoRetorno.NomeMedico;
                response.CPF = medicoRetorno.CPF;
                response.CRM = medicoRetorno.CRM;
                response.Especialidade = medicoRetorno.Especialidade;
            }

            return StatusCode(200, response);
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(400)]
        public IActionResult Delete(int id)
        {
            try
            {
                var medico = contexto.Medico.FirstOrDefault(
                    m => m.IdMedico == id);

                if (medico != null)
                {
                    contexto.Medico.Remove(medico);
                    contexto.SaveChanges();
                }

                return StatusCode(200, "Médico excluída com sucesso!");
            }
            catch (Exception ex)
            {
                return StatusCode(400, ex.InnerException.Message
                    .FirstOrDefault());
            }
        }

    }
}
