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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.btnCadastrarMedico = new System.Windows.Forms.Button();
            this.btnCadastrarVacina = new System.Windows.Forms.Button();
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(292, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bem vindo";
            // 
            // btnCadastrarMedico
            // 
            this.btnCadastrarMedico.Location = new System.Drawing.Point(119, 308);
            this.btnCadastrarMedico.Name = "btnCadastrarMedico";
            this.btnCadastrarMedico.Size = new System.Drawing.Size(102, 23);
            this.btnCadastrarMedico.TabIndex = 21;
            this.btnCadastrarMedico.Text = "Cadastrar Médico";
            this.btnCadastrarMedico.UseVisualStyleBackColor = true;
            this.btnCadastrarMedico.Click += new System.EventHandler(this.btnCadastrarMedico_Click);
            // 
            // btnCadastrarVacina
            // 
            this.btnCadastrarVacina.Location = new System.Drawing.Point(227, 308);
            this.btnCadastrarVacina.Name = "btnCadastrarVacina";
            this.btnCadastrarVacina.Size = new System.Drawing.Size(98, 23);
            this.btnCadastrarVacina.TabIndex = 22;
            this.btnCadastrarVacina.Text = "Cadastrar Vacina";
            this.btnCadastrarVacina.UseVisualStyleBackColor = true;
            this.btnCadastrarVacina.Click += new System.EventHandler(this.btnCadastrarVacina_Click);
            // 
            // btnCadastrarFamiliar
            // 
            this.btnCadastrarFamiliar.Location = new System.Drawing.Point(10, 308);
            this.btnCadastrarFamiliar.Name = "btnCadastrarFamiliar";
            this.btnCadastrarFamiliar.Size = new System.Drawing.Size(103, 23);
            this.btnCadastrarFamiliar.TabIndex = 23;
            this.btnCadastrarFamiliar.Text = "Cadastrar Familiar";
            this.btnCadastrarFamiliar.UseVisualStyleBackColor = true;
            this.btnCadastrarFamiliar.Click += new System.EventHandler(this.btnCadastrarFamiliar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(21, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Familiares";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(135, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Médicos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(242, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Vacinas";
            // 
            // btnregvacinas
            // 
            this.btnregvacinas.Location = new System.Drawing.Point(10, 338);
            this.btnregvacinas.Name = "btnregvacinas";
            this.btnregvacinas.Size = new System.Drawing.Size(142, 62);
            this.btnregvacinas.TabIndex = 30;
            this.btnregvacinas.Text = "Registrar Vacinas";
            this.btnregvacinas.UseVisualStyleBackColor = true;
            this.btnregvacinas.Click += new System.EventHandler(this.btnregvacinas_Click);
            // 
            // btnregconsultas
            // 
            this.btnregconsultas.Location = new System.Drawing.Point(183, 338);
            this.btnregconsultas.Name = "btnregconsultas";
            this.btnregconsultas.Size = new System.Drawing.Size(142, 62);
            this.btnregconsultas.TabIndex = 31;
            this.btnregconsultas.Text = "Registrar Consultas";
            this.btnregconsultas.UseVisualStyleBackColor = true;
            this.btnregconsultas.Click += new System.EventHandler(this.btnregconsultas_Click);
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(335, 69);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(388, 147);
            this.listView1.TabIndex = 32;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView2.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView2.Location = new System.Drawing.Point(335, 249);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(388, 151);
            this.listView2.TabIndex = 33;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.Location = new System.Drawing.Point(437, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(170, 20);
            this.label5.TabIndex = 34;
            this.label5.Text = "Consultas Registradas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(451, 226);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(156, 20);
            this.label6.TabIndex = 35;
            this.label6.Text = "Vacinas Registradas";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(25, 69);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(101, 21);
            this.comboBox1.TabIndex = 36;
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 412);
            this.Controls.Add(this.comboBox1);
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
            this.Controls.Add(this.btnCadastrarVacina);
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
        private System.Windows.Forms.Button btnCadastrarVacina;
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
        private System.Windows.Forms.ComboBox comboBox1;
    }
}