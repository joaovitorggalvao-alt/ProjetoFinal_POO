namespace ProjetoFinal_POO
{
    partial class FrmCadastro
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
<<<<<<< HEAD
            lblCpf = new Label();
            lblNome = new Label();
            lblTelefone = new Label();
            txtCpf = new MaskedTextBox();
            txtTelefone = new MaskedTextBox();
            btnSalvar = new Button();
            btnBuscar = new Button();
            btnExcluir = new Button();
            txtNome = new TextBox();
            SuspendLayout();
            // 
            // lblCpf
            // 
            lblCpf.AutoSize = true;
            lblCpf.Location = new Point(178, 136);
            lblCpf.Name = "lblCpf";
            lblCpf.Size = new Size(107, 20);
            lblCpf.TabIndex = 0;
            lblCpf.Text = "Digite seu CPF:";
            // 
            // lblNome
            // 
            lblNome.AutoSize = true;
            lblNome.Location = new Point(178, 178);
            lblNome.Name = "lblNome";
            lblNome.Size = new Size(148, 20);
            lblNome.TabIndex = 1;
            lblNome.Text = "Nome para cadastro:";
            // 
            // lblTelefone
            // 
            lblTelefone.AutoSize = true;
            lblTelefone.Location = new Point(178, 220);
            lblTelefone.Name = "lblTelefone";
            lblTelefone.Size = new Size(158, 20);
            lblTelefone.TabIndex = 2;
            lblTelefone.Text = "Telefone para contato:";
            // 
            // txtCpf
            // 
            txtCpf.Location = new Point(380, 133);
            txtCpf.Name = "txtCpf";
            txtCpf.Size = new Size(231, 27);
            txtCpf.TabIndex = 3;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(380, 220);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.Size = new Size(231, 27);
            txtTelefone.TabIndex = 5;
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(199, 291);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(112, 43);
            btnSalvar.TabIndex = 6;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(317, 291);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(158, 43);
            btnBuscar.TabIndex = 7;
            btnBuscar.Text = "Buscar por CPF";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // btnExcluir
            // 
            btnExcluir.Location = new Point(481, 291);
            btnExcluir.Name = "btnExcluir";
            btnExcluir.Size = new Size(130, 43);
            btnExcluir.TabIndex = 8;
            btnExcluir.Text = "Excluir";
            btnExcluir.UseVisualStyleBackColor = true;
            btnExcluir.Click += btnExcluir_Click;
            // 
            // txtNome
            // 
            txtNome.Location = new Point(380, 178);
            txtNome.Name = "txtNome";
            txtNome.Size = new Size(231, 27);
            txtNome.TabIndex = 9;
=======
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
>>>>>>> a67aa7d4ecfe64bd0c87d9df05964658eddfd6e7
            // 
            // FrmCadastro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
<<<<<<< HEAD
            Controls.Add(txtNome);
            Controls.Add(btnExcluir);
            Controls.Add(btnBuscar);
            Controls.Add(btnSalvar);
            Controls.Add(txtTelefone);
            Controls.Add(txtCpf);
            Controls.Add(lblTelefone);
            Controls.Add(lblNome);
            Controls.Add(lblCpf);
            Name = "FrmCadastro";
            Text = "FrmCadastro";
=======
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
>>>>>>> a67aa7d4ecfe64bd0c87d9df05964658eddfd6e7
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

<<<<<<< HEAD
        private Label lblCpf;
        private Label lblNome;
        private Label lblTelefone;
        private MaskedTextBox txtCpf;
        private MaskedTextBox txtTelefone;
        private Button btnSalvar;
        private Button btnBuscar;
        private Button btnExcluir;
        private TextBox txtNome;
=======
        private Label NomeCad;
        private Label IdadeCad;
        private Label CPFCad;
        private Label TelefoneCad;
        private TextBox txtNome;
        private TextBox txtIdade;
        private TextBox txtCPF;
        private TextBox txtTelefone;
        private Button btnCad;
>>>>>>> a67aa7d4ecfe64bd0c87d9df05964658eddfd6e7
    }
}