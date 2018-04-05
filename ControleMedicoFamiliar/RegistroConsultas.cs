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
    public partial class RegistroConsultas : Form
    {
        public RegistroConsultas()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string pessoa = cbPessoas.SelectedText;
            string medico = cbMedicos.SelectedText;

            MessageBox.Show("Consulta registrada com sucesso:");
            this.Hide();
            HomePage home = new HomePage();
            home.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomePage home = new HomePage();
            home.ShowDialog();
        }
    }
}
