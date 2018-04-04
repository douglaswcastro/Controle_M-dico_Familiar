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
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void lvFamiliares_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnCadastrarVacina_Click(object sender, EventArgs e)
        {
            CadastroVacinas cadastroVacinas = new CadastroVacinas();
            cadastroVacinas.ShowDialog();
        }

        private void btnCadastrarFamiliar_Click(object sender, EventArgs e)
        {
            CadastroFamiliares cadastroFamiliares = new CadastroFamiliares();
            cadastroFamiliares.ShowDialog();
        }

        private void btnCadastrarMedico_Click(object sender, EventArgs e)
        {
            CadastroMedicos cadastroMedicos = new CadastroMedicos();
            cadastroMedicos.ShowDialog();
        }

        private void btnregvacinas_Click(object sender, EventArgs e)
        {
            RegistroVacinas registroVacinas = new RegistroVacinas();
            registroVacinas.ShowDialog();
        }

        private void btnregconsultas_Click(object sender, EventArgs e)
        {
            RegistroConsultas registroConsultas = new RegistroConsultas();
            registroConsultas.ShowDialog();
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }
    }
}
