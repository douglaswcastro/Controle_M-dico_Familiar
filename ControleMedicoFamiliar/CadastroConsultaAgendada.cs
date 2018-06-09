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
    public partial class CadastroConsultaAgendada : Form
    {
        ConsultaAgendada consulta = new ConsultaAgendada();
        Familiares familiar = new Familiares();
        Medicos medico = new Medicos();
        public CadastroConsultaAgendada()
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
                cbFamiliar.Items.Add(item.Nome);
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (cbFamiliar.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Por favor selecione uma pessoa.");
            }
            else if (cbMedicos.SelectedItem.ToString() == "")
            {
                MessageBox.Show("Por favor selecione o médico");
            }
            else
            {
                string Pessoa = cbFamiliar.SelectedItem.ToString();
                string Medico = cbMedicos.SelectedItem.ToString();
                string Data = txtData.Text;
                consulta.Adicionar(Pessoa, Medico, Data);
                MessageBox.Show("Consulta Agendada");
                cbFamiliar.Text = "";
                cbMedicos.Text = "";
                txtData.Text = "";
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
            HomePage home = new HomePage();
            home.Show();
        }
    }
}
