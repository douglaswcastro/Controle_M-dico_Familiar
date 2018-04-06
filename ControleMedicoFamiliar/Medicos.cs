using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicoFamiliar
{
    public class Medicos
    {
        string nome;
        string especialidade;

        public static List<Medicos> listMedicos = new List<Medicos>();

        public void Adicionar(string nomemedico, string especialidademedico)
        {
            listMedicos.Add(new Medicos() { nome = nomemedico, especialidade = especialidademedico });
        }

        public List<Medicos> Listar() => listMedicos;
    }

}
