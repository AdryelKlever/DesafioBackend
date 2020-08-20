using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBackEnd.Api.Request
{
    public class MedicoRequest
    {
        [Required(ErrorMessage = "O nome é obrigatório!")]
        public string NomeMedico { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório!")]
        public string CPF { get; set; }

        [Required(ErrorMessage = "O CRM é obrigatório!")]
        public string CRM { get; set; }

        [Required(ErrorMessage = "A especialidade é obrigatório!")]
        public string Especialidade { get; set; }
    }
}
