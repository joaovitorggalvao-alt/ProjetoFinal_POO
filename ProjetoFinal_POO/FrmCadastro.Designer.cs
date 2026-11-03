namespace ProjetoFinal_POO
{
    partial class FrmCadastro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NomeCad = new Label();
            IdadeCad = new Label();
            CPFCad = new Label();
            TelefoneCad = new Label();
            txtNome = new TextBox();
            txtIdade = new TextBox();
            txtCPF = new TextBox();
            txtTelefone = new TextBox();
            btnCad = new Button();
            SuspendLayout();
            // 
            // NomeCad
            // 
            NomeCad.AutoSize = true;
            NomeCad.Location = new Point(231, 70);
            NomeCad.Name = "NomeCad";
            NomeCad.Size = new Size(53, 20);
            NomeCad.TabIndex = 0;
            NomeCad.Text = "Nome:";
            NomeCad.Click += label1_Click;
            // 
            // IdadeCad
            // 
            IdadeCad.AutoSize = true;
            IdadeCad.Location = new Point(231, 115);
            IdadeCad.Name = "IdadeCad";
            IdadeCad.Size = new Size(50, 20);
            IdadeCad.TabIndex = 1;
            IdadeCad.Text = "Idade:";
            // 
            // CPFCad
            // 
            CPFCad.AutoSize = true;
            CPFCad.Location = new Point(245, 162);
            CPFCad.Name = "CPFCad";
            CPFCad.Size = new Size(36, 20);
            CPFCad.TabIndex = 2;
            CPFCad.Text = "CPF:";
            // 
            // TelefoneCad
            // 
            TelefoneCad.AutoSize = true;
            TelefoneCad.Location = new Point(215, 215);
            TelefoneCad.Name = "TelefoneCad";
            TelefoneCad.Size = new Size(69, 20);
            TelefoneCad.TabIndex = 3;
            TelefoneCad.Text = "Telefone:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(303, 67);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(155, 27);
            txtNome.TabIndex = 4;
            // 
            // txtIdade
            // 
            txtIdade.Location = new Point(303, 115);
            txtIdade.Name = "txtIdade";
            txtIdade.Size = new Size(155, 27);
            txtIdade.TabIndex = 5;
            txtIdade.TextChanged += textBox2_TextChanged;
            // 
            // textBox3
            // 
            txtCPF.Location = new Point(303, 162);
            txtCPF.Name = "txtCPF";
            txtCPF.Size = new Size(155, 27);
            txtCPF.TabIndex = 6;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(303, 212);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(155, 27);
            txtTelefone.TabIndex = 7;
            // 
            // btnCad
            // 
            btnCad.Location = new Point(364, 264);
            btnCad.Name = "btnCad";
            btnCad.Size = new Size(94, 35);
            btnCad.TabIndex = 8;
            btnCad.Text = "Cadastrar";
            btnCad.UseVisualStyleBackColor = true;
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnCad);
            Controls.Add(txtTelefone);
            Controls.Add(txtCPF);
            Controls.Add(txtIdade);
            Controls.Add(txtNome);
            Controls.Add(TelefoneCad);
            Controls.Add(CPFCad);
            Controls.Add(IdadeCad);
            Controls.Add(NomeCad);
            Name = "FrmCadastro";
            Text = "Cadastro Academia ";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NomeCad;
        private Label IdadeCad;
        private Label CPFCad;
        private Label TelefoneCad;
        private TextBox txtNome;
        private TextBox txtIdade;
        private TextBox txtCPF;
        private TextBox txtTelefone;
        private Button btnCad;
    }
}
