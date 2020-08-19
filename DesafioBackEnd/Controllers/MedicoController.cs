using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DesafioBackEnd.Api.Request;
using DesafioBackEnd.Api.Response;
using DesafioBackEnd.Data.Context;
using DesafioBackEnd.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioBackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicoController : ControllerBase
    {
        private readonly Contexto contexto;

        public MedicoController(Contexto contexto)
        {
            this.contexto = contexto;
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
