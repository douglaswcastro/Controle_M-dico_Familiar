using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleMedicoFamiliar
{
    class RegistroVacina
    {
        string pessoa;
        string vacina;
        string tipo;

        public RegistroVacina(string pessoa, string vacina, string tipo)
        {
            this.pessoa = pessoa;
            this.vacina = vacina;
            this.tipo = tipo;

        }
    }
}
