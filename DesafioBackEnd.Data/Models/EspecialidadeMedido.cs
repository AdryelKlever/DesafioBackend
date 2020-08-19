using DesafioBackEnd.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesafioBackEnd.Data.Models
{
    public class EspecialidadeMedido
    {
        public int IdMedico { get; set; }
        public int IdEspecialidade { get; set; }
        public Medico Medico { get; set; }
        public Especialidade Especialidade { get; set; }
    }
}
