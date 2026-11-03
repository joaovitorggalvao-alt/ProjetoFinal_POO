using System;
using System.Collections.Generic;
using System.Text;

namespace ProjetoFinal_POO
{
    public class Aluno
    {
        public string? Cpf {  get; set; }
        public string? Nome { get; set; }
        public string? Telefone { get; set; }

        public Aluno() { }

        public Aluno (string cpf, string nome, string telefone)
        {
            Cpf = cpf;
            Nome = nome;
            Telefone = telefone;
        }
    }
}
