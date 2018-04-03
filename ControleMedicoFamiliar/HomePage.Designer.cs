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
            this.label1 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.listView2 = new System.Windows.Forms.ListView();
            this.listView3 = new System.Windows.Forms.ListView();
            this.btnCadastrarMedico = new System.Windows.Forms.Button();
            this.btnCadastrarVacina = new System.Windows.Forms.Button();
            this.btnCadastrarFamiliar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(283, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 17;
            this.label1.Text = "Bem vindo";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(561, 86);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(142, 233);
            this.listView1.TabIndex = 18;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // listView2
            // 
            this.listView2.Location = new System.Drawing.Point(402, 86);
            this.listView2.Name = "listView2";
            this.listView2.Size = new System.Drawing.Size(142, 233);
            this.listView2.TabIndex = 19;
            this.listView2.UseCompatibleStateImageBehavior = false;
            // 
            // listView3
            // 
            this.listView3.Location = new System.Drawing.Point(241, 86);
            this.listView3.Name = "listView3";
            this.listView3.Size = new System.Drawing.Size(142, 233);
            this.listView3.TabIndex = 20;
            this.listView3.UseCompatibleStateImageBehavior = false;
            // 
            // btnCadastrarMedico
            // 
            this.btnCadastrarMedico.Location = new System.Drawing.Point(402, 325);
            this.btnCadastrarMedico.Name = "btnCadastrarMedico";
            this.btnCadastrarMedico.Size = new System.Drawing.Size(142, 23);
            this.btnCadastrarMedico.TabIndex = 21;
            this.btnCadastrarMedico.Text = "Cadastrar Médico";
            this.btnCadastrarMedico.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarVacina
            // 
            this.btnCadastrarVacina.Location = new System.Drawing.Point(561, 325);
            this.btnCadastrarVacina.Name = "btnCadastrarVacina";
            this.btnCadastrarVacina.Size = new System.Drawing.Size(142, 23);
            this.btnCadastrarVacina.TabIndex = 22;
            this.btnCadastrarVacina.Text = "Cadastrar Vacina";
            this.btnCadastrarVacina.UseVisualStyleBackColor = true;
            // 
            // btnCadastrarFamiliar
            // 
            this.btnCadastrarFamiliar.Location = new System.Drawing.Point(241, 325);
            this.btnCadastrarFamiliar.Name = "btnCadastrarFamiliar";
            this.btnCadastrarFamiliar.Size = new System.Drawing.Size(142, 23);
            this.btnCadastrarFamiliar.TabIndex = 23;
            this.btnCadastrarFamiliar.Text = "Cadastrar Familiar";
            this.btnCadastrarFamiliar.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(237, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 24;
            this.label2.Text = "Familiares";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(398, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 25;
            this.label3.Text = "Medicos";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.Location = new System.Drawing.Point(557, 63);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Vacinas";
            // 
            // HomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 412);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCadastrarFamiliar);
            this.Controls.Add(this.btnCadastrarVacina);
            this.Controls.Add(this.btnCadastrarMedico);
            this.Controls.Add(this.listView3);
            this.Controls.Add(this.listView2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label1);
            this.Name = "HomePage";
            this.Text = "HomePage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ListView listView2;
        private System.Windows.Forms.ListView listView3;
        private System.Windows.Forms.Button btnCadastrarMedico;
        private System.Windows.Forms.Button btnCadastrarVacina;
        private System.Windows.Forms.Button btnCadastrarFamiliar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}