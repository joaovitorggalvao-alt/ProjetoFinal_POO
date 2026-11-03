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
            menuCadastro = new ToolStripMenuItem();
            sairToolStripMenuItem = new ToolStripMenuItem();
            listagemToolStripMenuItem = new ToolStripMenuItem();
            sairToolStripMenuItem1 = new ToolStripMenuItem();
            sairToolStripMenuItem2 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { menuCadastro, listagemToolStripMenuItem, sairToolStripMenuItem2 });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1099, 28);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuCadastro
            // 
            menuCadastro.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem });
            menuCadastro.Name = "menuCadastro";
            menuCadastro.Size = new Size(105, 24);
            menuCadastro.Text = "&Cadastra- se";
            menuCadastro.Click += menuCadastro_Click;
            // 
            // sairToolStripMenuItem
            // 
            sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            sairToolStripMenuItem.Size = new Size(224, 26);
            sairToolStripMenuItem.Text = "Sair";
            sairToolStripMenuItem.Click += sairToolStripMenuItem_Click;
            // 
            // listagemToolStripMenuItem
            // 
            listagemToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { sairToolStripMenuItem1 });
            listagemToolStripMenuItem.Name = "listagemToolStripMenuItem";
            listagemToolStripMenuItem.Size = new Size(83, 24);
            listagemToolStripMenuItem.Text = "&Listagem";
            listagemToolStripMenuItem.Click += listagemToolStripMenuItem_Click;
            // 
            // sairToolStripMenuItem1
            // 
            sairToolStripMenuItem1.Name = "sairToolStripMenuItem1";
            sairToolStripMenuItem1.Size = new Size(224, 26);
            sairToolStripMenuItem1.Text = "Sair";
            sairToolStripMenuItem1.Click += sairToolStripMenuItem1_Click;
            // 
            // sairToolStripMenuItem2
            // 
            sairToolStripMenuItem2.Name = "sairToolStripMenuItem2";
            sairToolStripMenuItem2.Size = new Size(48, 24);
            sairToolStripMenuItem2.Text = "&Sair";
            sairToolStripMenuItem2.Click += sairToolStripMenuItem2_Click;
            // 
            // FrmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1099, 503);
            Controls.Add(menuStrip1);
            Font = new Font("Segoe UI", 9F);
            ForeColor = SystemColors.ControlText;
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "FrmPrincipal";
            Text = "Academia NextFIT - CADASTRO";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem menuCadastro;
        private ToolStripMenuItem listagemToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem2;
        private ToolStripMenuItem sairToolStripMenuItem;
        private ToolStripMenuItem sairToolStripMenuItem1;
    }
}
