using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControleMedicoFamiliar
{
    public partial class CadastroVacinas : Form
    {
        List<Vacinas> vacinas = new List<Vacinas>();
        public CadastroVacinas()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string tipo = txtTipo.Text;
            Vacinas vacina = new Vacinas(nome, tipo);

            vacinas.Add(vacina);
        }
    }
}
