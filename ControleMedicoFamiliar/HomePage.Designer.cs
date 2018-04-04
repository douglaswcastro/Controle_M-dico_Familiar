namespace ControleMedicoFamiliar
{
    partial class HomePage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarMedico = new System.Windows.Forms.Button();
            this.btnCadastrarFamiliar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnregvacinas = new System.Windows.Forms.Button();
            this.btnregconsultas = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbPessoaConsulta = new System.Windows.Forms.ComboBox();
            this.btnCadatrarVacina = new System.Windows.Forms.Button();
            this.cbPessoasVacina = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cbMedicos = new System.Windows.Forms.ComboBox();
            this.cbVacinas = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bem vindo";
            // 
            // btnCadastrarMedico
            // 
            this.btnCadastrarMedico.Location = new System.Drawing.Point(208, 353);
            this.btnCadastrarMedico.Name = "btnCadastrarMedico";
            this.btnCadastrarMedico.Size = new System.Drawing.Size(134, 33);
            this.btnCadastrarMedico.TabIndex = 21;
            this.btnCadastrarMedico.Text = "Cadastrar Médico";
            this.btnCadastrarMedico.UseVisualStyleBackColor = true;
            this.btnCadastrarMedico.Click += new System.EventHandler(this.btnCadastrarMedico_Click);
            // 
            // btnCadastrarFamiliar
            // 
            this.btnCadastrarFamiliar.Location = new System.Drawing.Point(12, 353);
            this.btnCadastrarFamiliar.Name = "btnCadastrarFamiliar";
            this.btnCadastrarFamiliar.Size = new System.Drawing.Size(132, 33);
            this.btnCadastrarFamiliar.TabIndex = 23;
            this.btnCadastrarFamiliar.Text = "Cadastrar Familiar";
            this.btnCadastrarFamiliar.UseVisualStyleBackColor = true;
            this.btnCadastrarFamiliar.Click += new System.EventHandler(this.btnCadastrarFamiliar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(406, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Familiares";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(406, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Médicos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(406, 255);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Vacinas";
            // 
            // btnregvacinas
            // 
            this.btnregvacinas.Location = new System.Drawing.Point(577, 244);
            this.btnregvacinas.Name = "btnregvacinas";
            this.btnregvacinas.Size = new System.Drawing.Size(142, 44);
            this.btnregvacinas.TabIndex = 30;
            this.btnregvacinas.Text = "Registrar Vacinas";
            this.btnregvacinas.UseVisualStyleBackColor = true;
            this.btnregvacinas.Click += new System.EventHandler(this.btnregvacinas_Click);
            // 
            // btnregconsultas
            // 
            this.btnregconsultas.BackColor = System.Drawing.Color.Transparent;
            this.btnregconsultas.Location = new System.Drawing.Point(577, 97);
            this.btnregconsultas.Name = "btnregconsultas";
            this.btnregconsultas.Size = new System.Drawing.Size(142, 44);
            this.btnregconsultas.TabIndex = 31;
            this.btnregconsultas.Text = "Registrar Consultas";
            this.btnregconsultas.UseVisualStyleBackColor = false;
            this.btnregconsultas.Click += new System.EventHandler(this.btnregconsultas_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(12, 61);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(388, 109);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem3});
            this.listView2.Location = new System.Drawing.Point(12, 208);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(388, 114);
            this.listView2.TabIndex = 33;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(114, 38);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Consultas Registradas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(114, 185);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Vacinas Registradas";
            // 
            // cbPessoaConsulta
            // 
            this.cbPessoaConsulta.FormattingEnabled = true;
            this.cbPessoaConsulta.Location = new System.Drawing.Point(406, 84);
            this.cbPessoaConsulta.Name = "cbPessoaConsulta";
            this.cbPessoaConsulta.Size = new System.Drawing.Size(155, 21);
            this.cbPessoaConsulta.TabIndex = 36;
            // 
            // btnCadatrarVacina
            // 
            this.btnCadatrarVacina.Location = new System.Drawing.Point(397, 353);
            this.btnCadatrarVacina.Name = "btnCadatrarVacina";
            this.btnCadatrarVacina.Size = new System.Drawing.Size(134, 33);
            this.btnCadatrarVacina.TabIndex = 37;
            this.btnCadatrarVacina.Text = "Cadastrar Vacina";
            this.btnCadatrarVacina.UseVisualStyleBackColor = true;
            this.btnCadatrarVacina.Click += new System.EventHandler(this.btnCadatrarVacina_Click);
            // 
            // cbPessoasVacina
            // 
            this.cbPessoasVacina.FormattingEnabled = true;
            this.cbPessoasVacina.Location = new System.Drawing.Point(406, 231);
            this.cbPessoasVacina.Name = "cbPessoasVacina";
            this.cbPessoasVacina.Size = new System.Drawing.Size(155, 21);
            this.cbPessoasVacina.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label7.Location = new System.Drawing.Point(406, 208);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 20);
            this.label7.TabIndex = 38;
            this.label7.Text = "Familiares";
            // 
            // cbMedicos
            // 
            this.cbMedicos.FormattingEnabled = true;
            this.cbMedicos.Location = new System.Drawing.Point(406, 131);
            this.cbMedicos.Name = "cbMedicos";
            this.cbMedicos.Size = new System.Drawing.Size(155, 21);
            this.cbMedicos.TabIndex = 40;
            // 
            // cbVacinas
            // 
            this.cbVacinas.FormattingEnabled = true;
            this.cbVacinas.Location = new System.Drawing.Point(406, 278);
            this.cbVacinas.Name = "cbVacinas";
            this.cbVacinas.Size = new System.Drawing.Size(155, 21);
            this.cbVacinas.TabIndex = 41;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Adobe Fan Heiti Std B", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(589, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 33);
            this.button1.TabIndex = 42;
            this.button1.Text = "Fechar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControleMedicoFamiliar.Properties.Resources.HOME_1800x1200_c;
            this.ClientSize = new System.Drawing.Size(731, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cbVacinas);
            this.Controls.Add(this.cbMedicos);
            this.Controls.Add(this.cbPessoasVacina);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCadatrarVacina);
            this.Controls.Add(this.cbPessoaConsulta);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnregconsultas);
            this.Controls.Add(this.btnregvacinas);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastrarFamiliar);
            this.Controls.Add(this.btnCadastrarMedico);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCadastrarMedico;
        private System.Windows.Forms.Button btnCadastrarFamiliar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnregvacinas;
        private System.Windows.Forms.Button btnregconsultas;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbPessoaConsulta;
        private System.Windows.Forms.Button btnCadatrarVacina;
        private System.Windows.Forms.ComboBox cbPessoasVacina;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbMedicos;
        private System.Windows.Forms.ComboBox cbVacinas;
        private System.Windows.Forms.Button button1;
    }
}