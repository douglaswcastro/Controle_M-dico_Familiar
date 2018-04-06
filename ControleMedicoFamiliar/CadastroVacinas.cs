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
        Vacinas vacinas = new Vacinas();
        public CadastroVacinas()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            string tipo = txtTipo.Text;

            vacinas.Adicionar(nome, tipo);
            MessageBox.Show("Vacina cadastrada com sucesso!");

        }

        private void btnCancelar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
