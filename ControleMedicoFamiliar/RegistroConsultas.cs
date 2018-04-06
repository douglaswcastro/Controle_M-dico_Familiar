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
        RegistroConsulta regConsulta = new RegistroConsulta();
        Medicos medico = new Medicos();
        Familiares familiar = new Familiares();
        HomePage home = new HomePage();
        public RegistroConsultas()
        {
            InitializeComponent();
            List<Medicos> medicos = medico.Listar();

            foreach (var item in medicos)
            {
                cbMedicos.Items.Add(item.nome + " - " + item.especialidade);
            }

            List<Familiares> familiares = new List<Familiares>();
            familiares = familiar.Listar();
            foreach (var item in familiares)
            {
                cbPessoas.Items.Add(item.Nome);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string pessoa = cbPessoas.SelectedText;
            string medico = cbMedicos.SelectedText;

            if (pessoa != "" && medico != "")
            {
                MessageBox.Show("è preciso selecionar a pessoa e o médico!");
            }
            else
            {
                regConsulta.Adicionar(pessoa, medico);
                MessageBox.Show("Consulta registrada com sucesso:");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RegistroConsultas_Load(object sender, EventArgs e)
        {
            cbMedicos.SelectedIndex = 0;
            cbPessoas.SelectedIndex = 0;
        }
    }
}
