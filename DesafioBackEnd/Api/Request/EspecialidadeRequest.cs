using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBackEnd.Api.Request
{
    public class EspecialidadeRequest
    {
        [Required(ErrorMessage = "O nome é obrigatório!")]
        public string NomeEspecialidade { get; set; }
    }
}
