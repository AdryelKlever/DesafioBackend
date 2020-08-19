using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBackEnd.Models
{
    public class Medico
    {
        public int IdMedico { get; set; }
        public string NomeMedico { get; set; }
        public int CPF { get; set; }
        public string CRM { get; set; }
    }
}
