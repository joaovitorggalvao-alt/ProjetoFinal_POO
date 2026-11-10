namespace ProjetoFinal_POO
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void mnuSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Deseja realmente sair do sistema?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void mnuListagem_Click(object sender, EventArgs e)
        {
            FrmListagem telaListagem = new FrmListagem();

            // Define o MDI Parent
            telaListagem.MdiParent = this;

            // Exibe a tela
            telaListagem.Show();
        }

        private void mnuNovoCadastro_Click(object sender, EventArgs e)
        {
            Form? formExistente = Application.OpenForms["FrmCadastro"];

            if (formExistente != null)
            {
                // Se já estiver aberta, traz para o foco/frente
                formExistente.BringToFront();
                formExistente.Focus();
            }
            else
            {
                // Se não estiver aberta, cria, define o pai MDI e exibe
                FrmCadastro telaCadastro = new FrmCadastro();
                telaCadastro.MdiParent = this;
                telaCadastro.Show();
            }

        }
        
    }
    
}
