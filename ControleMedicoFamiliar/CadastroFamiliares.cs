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
    public partial class CadastroFamiliares : Form
    {
        public CadastroFamiliares()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {


        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click_1(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string parentesco = cbParentesco.SelectedText;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
