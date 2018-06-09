using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicoFamiliar
{
    class ConsultaAgendada
    {
        public string Pessoa { get; set; }
        public string Medico { get; set; }

        public string Data { get; set; }

        public static List<ConsultaAgendada> listConsultasAgendadas = new List<ConsultaAgendada>();

        public void Adicionar(string familiar, string medico, string data)
        {
            listConsultasAgendadas.Add(new ConsultaAgendada { Medico = medico, Pessoa = familiar, Data =  data});
        }

        public List<ConsultaAgendada> Listar() => listConsultasAgendadas;
    }
}
