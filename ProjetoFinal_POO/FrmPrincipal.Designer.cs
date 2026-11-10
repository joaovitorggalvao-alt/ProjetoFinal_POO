namespace ProjetoFinal_POO
{
    partial class FrmPrincipal
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
            menuStrip1 = new MenuStrip();
            mnuCadastro = new ToolStripMenuItem();
            mnuNovoCadastro = new ToolStripMenuItem();
            mnuListagem = new ToolStripMenuItem();
            mnuSair = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { mnuCadastro, mnuListagem, mnuSair });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1022, 28);
            menuStrip1.TabIndex = 5;
            menuStrip1.Text = "menuStrip1";
            // 
            // mnuCadastro
            // 
            mnuCadastro.DropDownItems.AddRange(new ToolStripItem[] { mnuNovoCadastro });
            mnuCadastro.Name = "mnuCadastro";
            mnuCadastro.Size = new Size(82, 24);
            mnuCadastro.Text = "&Cadastro";
            // 
            // mnuNovoCadastro
            // 
            mnuNovoCadastro.Name = "mnuNovoCadastro";
            mnuNovoCadastro.Size = new Size(224, 26);
            mnuNovoCadastro.Text = "&Novo Cadastro";
            mnuNovoCadastro.Click += mnuNovoCadastro_Click;
            // 
            // mnuListagem
            // 
            mnuListagem.Name = "mnuListagem";
            mnuListagem.Size = new Size(83, 24);
            mnuListagem.Text = "&Listagem";
            mnuListagem.Click += mnuListagem_Click;
            // 
            // mnuSair
            // 
            mnuSair.Name = "mnuSair";
            mnuSair.Size = new Size(48, 24);
            mnuSair.Text = "&Sair";
            mnuSair.Click += mnuSair_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1022, 453);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "Academia NEXTfit";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem mnuCadastro;
        private ToolStripMenuItem mnuListagem;
        private ToolStripMenuItem mnuSair;
        private ToolStripMenuItem mnuNovoCadastro;
    }
}
