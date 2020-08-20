using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioBackEnd.Api.Response
{
    public class MedicoResponse
    {
        public int IdMedico { get; set; }
        public string NomeMedico { get; set; }
        public string CPF { get; set; }
        public string CRM { get; set; }
        public string Especialidade { get; set; }

    }
}
