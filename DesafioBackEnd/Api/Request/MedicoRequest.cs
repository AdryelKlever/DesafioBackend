using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBackEnd.Api.Request
{
    public class MedicoRequest
    {
        public int IdMedico { get; set; }
        [Required(ErrorMessage = "O nome é obrigatório")]
        public string NomeMedico { get; set; }

        [Required(ErrorMessage = "O CPF é obrigatório")]
        public int CPF { get; set; }

        [Required(ErrorMessage = "O CRM é obrigatório")]
        public string CRM { get; set; }
    }
}
