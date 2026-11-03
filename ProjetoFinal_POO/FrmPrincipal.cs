namespace ProjetoFinal_POO
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Saindo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair?", "Saindo", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void menuCadastro_Click(object sender, EventArgs e)
        {
            FrmCadastro telaCadastro = new FrmCadastro();
            telaCadastro.MdiParent = this; // Define que ele abre dentro do container principal
            telaCadastro.Show();
        }

        private void listagemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmListagem telaListagem = new FrmListagem();
            telaListagem.MdiParent = this;
            telaListagem.Show();
        }

        private void sairToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
