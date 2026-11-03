using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoFinal_POO
{
    public partial class FrmListagem : Form
    {
        public FrmListagem()
        {
            InitializeComponent();
        }

        private void FrmListagem_Load(object sender, EventArgs e)
        {
            CarregarDadosNaTabela();
        }

        // Método que busca os dados no XML e joga no DataGridView
        private void CarregarDadosNaTabela()
        {
            List<Aluno> listaAlunos = RepositorioAluno.Carregar();

            // Atribui a lista diretamente como fonte de dados da tabela
            dgvAlunos.DataSource = null;
            dgvAlunos.DataSource = listaAlunos;
        }

        private void btnAtualizar_Click_1(object sender, EventArgs e)
        {
            CarregarDadosNaTabela();
            MessageBox.Show("Lista atualizada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
