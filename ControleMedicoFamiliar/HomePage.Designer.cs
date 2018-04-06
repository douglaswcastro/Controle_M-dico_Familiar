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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtgConsultas = new System.Windows.Forms.DataGridView();
            this.ConsultaPessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NomeMedico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Especialidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dtgVacinas = new System.Windows.Forms.DataGridView();
            this.Pessoa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vacina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacinasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.familiaresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vacinasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFechar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVacinas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(267, 39);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(195, 23);
            this.label5.TabIndex = 34;
            this.label5.Text = "Consultas Registradas";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Berlin Sans FB", 15.75F);
            this.label6.Location = new System.Drawing.Point(279, 204);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 23);
            this.label6.TabIndex = 35;
            this.label6.Text = "Vacinas Registradas";
            // 
            // dtgConsultas
            // 
            this.dtgConsultas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ConsultaPessoa,
            this.NomeMedico,
            this.Especialidade});
            this.dtgConsultas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtgConsultas.Location = new System.Drawing.Point(12, 67);
            this.dtgConsultas.Name = "dtgConsultas";
            this.dtgConsultas.Size = new System.Drawing.Size(707, 121);
            this.dtgConsultas.TabIndex = 43;
            // 
            // ConsultaPessoa
            // 
            this.ConsultaPessoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ConsultaPessoa.HeaderText = "Pessoa";
            this.ConsultaPessoa.Name = "ConsultaPessoa";
            // 
            // NomeMedico
            // 
            this.NomeMedico.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.NomeMedico.HeaderText = "Médico";
            this.NomeMedico.Name = "NomeMedico";
            // 
            // Especialidade
            // 
            this.Especialidade.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Especialidade.HeaderText = "Especialidade";
            this.Especialidade.Name = "Especialidade";
            // 
            // dtgVacinas
            // 
            this.dtgVacinas.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtgVacinas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Pessoa,
            this.Vacina,
            this.Tipo});
            this.dtgVacinas.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.dtgVacinas.Location = new System.Drawing.Point(12, 232);
            this.dtgVacinas.Name = "dtgVacinas";
            this.dtgVacinas.Size = new System.Drawing.Size(707, 125);
            this.dtgVacinas.TabIndex = 100;
            // 
            // Pessoa
            // 
            this.Pessoa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Pessoa.FillWeight = 50F;
            this.Pessoa.HeaderText = "Pessoa";
            this.Pessoa.Name = "Pessoa";
            // 
            // Vacina
            // 
            this.Vacina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Vacina.HeaderText = "Vacina";
            this.Vacina.Name = "Vacina";
            // 
            // Tipo
            // 
            this.Tipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tipo.HeaderText = "Tipo";
            this.Tipo.Name = "Tipo";
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem,
            this.registrosToolStripMenuItem,
            this.ajudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(731, 24);
            this.menuStrip1.TabIndex = 45;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vacinasToolStripMenuItem,
            this.médicosToolStripMenuItem,
            this.familiaresToolStripMenuItem});
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            // 
            // vacinasToolStripMenuItem
            // 
            this.vacinasToolStripMenuItem.Name = "vacinasToolStripMenuItem";
            this.vacinasToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.vacinasToolStripMenuItem.Text = "Vacinas";
            this.vacinasToolStripMenuItem.Click += new System.EventHandler(this.vacinasToolStripMenuItem_Click);
            // 
            // médicosToolStripMenuItem
            // 
            this.médicosToolStripMenuItem.Name = "médicosToolStripMenuItem";
            this.médicosToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.médicosToolStripMenuItem.Text = "Médicos";
            this.médicosToolStripMenuItem.Click += new System.EventHandler(this.médicosToolStripMenuItem_Click);
            // 
            // familiaresToolStripMenuItem
            // 
            this.familiaresToolStripMenuItem.Name = "familiaresToolStripMenuItem";
            this.familiaresToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.familiaresToolStripMenuItem.Text = "Familiares";
            this.familiaresToolStripMenuItem.Click += new System.EventHandler(this.familiaresToolStripMenuItem_Click);
            // 
            // registrosToolStripMenuItem
            // 
            this.registrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vacinasToolStripMenuItem1,
            this.consultasToolStripMenuItem});
            this.registrosToolStripMenuItem.Name = "registrosToolStripMenuItem";
            this.registrosToolStripMenuItem.Size = new System.Drawing.Size(67, 20);
            this.registrosToolStripMenuItem.Text = "Registros";
            // 
            // vacinasToolStripMenuItem1
            // 
            this.vacinasToolStripMenuItem1.Name = "vacinasToolStripMenuItem1";
            this.vacinasToolStripMenuItem1.Size = new System.Drawing.Size(126, 22);
            this.vacinasToolStripMenuItem1.Text = "Vacinas";
            this.vacinasToolStripMenuItem1.Click += new System.EventHandler(this.vacinasToolStripMenuItem1_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(126, 22);
            this.consultasToolStripMenuItem.Text = "Consultas";
            this.consultasToolStripMenuItem.Click += new System.EventHandler(this.consultasToolStripMenuItem_Click);
            // 
            // ajudaToolStripMenuItem
            // 
            this.ajudaToolStripMenuItem.Name = "ajudaToolStripMenuItem";
            this.ajudaToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.ajudaToolStripMenuItem.Text = "Ajuda";
            this.ajudaToolStripMenuItem.Click += new System.EventHandler(this.ajudaToolStripMenuItem_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.BackColor = System.Drawing.Color.Transparent;
            this.btnFechar.BackgroundImage = global::ControleMedicoFamiliar.Properties.Resources.cancel_1294426_960_720;
            this.btnFechar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFechar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnFechar.Location = new System.Drawing.Point(674, 363);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(45, 37);
            this.btnFechar.TabIndex = 46;
            this.btnFechar.UseVisualStyleBackColor = false;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ControleMedicoFamiliar.Properties.Resources.medicinaescolar_620x330;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(731, 412);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.dtgVacinas);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dtgConsultas);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "HomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "HomePage";
            this.Load += new System.EventHandler(this.HomePage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgConsultas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgVacinas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dtgConsultas;
        private System.Windows.Forms.DataGridView dtgVacinas;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ajudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacinasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem familiaresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vacinasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.DataGridViewTextBoxColumn ConsultaPessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeMedico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Especialidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pessoa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vacina;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
    }
}