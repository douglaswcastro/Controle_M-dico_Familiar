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
            RegistroVacina regVacina = new RegistroVacina();
            RegistroConsulta regConsulta = new RegistroConsulta();
            List<RegistroVacina> listvacinas = regVacina.Listar();
            dtgVacinas.DataSource = listvacinas;

            List<RegistroConsulta> listconsultas = regConsulta.Listar();
            dtgConsultas.DataSource = listconsultas;
        }

        private void btnCadastrarFamiliar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCadastrarMedico_Click(object sender, EventArgs e)
        {
            
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnCadatrarVacina_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ajuda home = new Ajuda();
            home.Show();
        }

        private void vacinasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroVacinas cadastroVacinas = new CadastroVacinas();
            cadastroVacinas.ShowDialog();
        }

        private void médicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroMedicos cadastroMedicos = new CadastroMedicos();
            cadastroMedicos.Show();
        }

        private void familiaresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CadastroFamiliares cadastroFamiliares = new CadastroFamiliares();
            cadastroFamiliares.ShowDialog();
        }
        private void consultasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroConsultas view = new RegistroConsultas();
            view.Show();
        }

        private void vacinasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroVacinas view = new RegistroVacinas();
            view.Show();
        }


        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
