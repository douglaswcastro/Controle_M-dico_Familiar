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
    public partial class RegistroVacinas : Form
    {
        HomePage home;

        public RegistroVacinas()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string pessoa = cbPessoas.SelectedText;
            string medico = cbVacina.SelectedText;

            MessageBox.Show("Vacina registrada com sucesso:");
            this.Hide();
            HomePage home = new HomePage();
            home.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
