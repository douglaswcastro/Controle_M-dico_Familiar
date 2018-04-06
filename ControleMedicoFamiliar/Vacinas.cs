using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicoFamiliar
{
    class Vacinas
    {
        public string nome;
        public string tipo;

        List<Vacinas> listVacinas = new List<Vacinas>();

        public void Adicionar(string nomeVacina, string tipoVacina)
        {
            listVacinas.Add(new Vacinas() { nome = nomeVacina, tipo = tipoVacina });
        }

        public List<string> Listar()
        {
            List<string> result = listVacinas.Select(v => v.nome).ToList();
            return result;
               
        }
    }
}
