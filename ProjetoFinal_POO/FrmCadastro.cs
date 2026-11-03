using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ProjetoFinal_POO
{
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cpfBusca = txtCpf.Text.Trim();

            if (string.IsNullOrEmpty(cpfBusca))
            {
                MessageBox.Show("Digite um CPF para realizar a busca.", "Atenção",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Aluno> listaAlunos = RepositorioAluno.Carregar();

            // Procura o cliente na lista pelo CPF
            var alunoEncontrado = listaAlunos.Find(a => a.Cpf == cpfBusca);

            if (alunoEncontrado != null)
            {
                // Carrega os dados nos campos correspondentes
                txtNome.Text = alunoEncontrado.Nome;
                txtTelefone.Text = alunoEncontrado.Telefone;
                MessageBox.Show("Aluno encontrado com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            else
            {
                MessageBox.Show("Nenhum aluno encontrado com este CPF.", "Não encontrado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                LimparCamposExcetoCpf();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Valida se os campos foram preenchidos
            if (string.IsNullOrWhiteSpace(txtCpf.Text) ||
                string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtTelefone.Text))
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de salvar.", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Aluno> listaAlunos = RepositorioAluno.Carregar();
            string cpf = txtCpf.Text.Trim();

            // Verifica se o cliente já existe (se existir, atualiza; se não, adiciona um novo)
            var alunoExistente = listaAlunos.Find(a => a.Cpf == cpf);

            if (alunoExistente != null)
            {
                alunoExistente.Nome = txtNome.Text.Trim();
                alunoExistente.Telefone = txtTelefone.Text.Trim();
                MessageBox.Show("Dados do aluno atualizados com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                Aluno novoAluno = new Aluno(cpf, txtNome.Text.Trim(), txtTelefone.Text.Trim());
                listaAlunos.Add(novoAluno);
                MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            // Persiste os dados atualizados em disco (XML)
            RepositorioAluno.Salvar(listaAlunos);
            LimparCampos();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            string cpfBusca = txtCpf.Text.Trim();

            if (string.IsNullOrEmpty(cpfBusca))
            {
                MessageBox.Show("Digite o CPF do  que deseja excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<Aluno> listaAlunos = RepositorioAluno.Carregar();
            var alunoEncontrado = listaAlunos.Find(a => a.Cpf == cpfBusca);

            if (alunoEncontrado != null)
            {
                DialogResult resultado = MessageBox.Show($"Deseja realmente excluir o aluno {alunoEncontrado.Nome}?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (resultado == DialogResult.Yes)
                {
                    listaAlunos.Remove(alunoEncontrado);
                    RepositorioAluno.Salvar(listaAlunos); // Salva a lista modificada no disco
                    MessageBox.Show("Aluno excluído com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LimparCampos();
                }
            }
            else
            {
                MessageBox.Show("Aluno não encontrado para exclusão.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Métodos auxiliares para limpar a tela
        private void LimparCampos()
        {
            txtCpf.Clear();
            txtNome.Clear();
            txtTelefone.Clear();
            txtCpf.Focus();
        }

        private void LimparCamposExcetoCpf()
        {
            txtNome.Clear();
            txtTelefone.Clear();
            txtNome.Focus();
        }
    }
}
