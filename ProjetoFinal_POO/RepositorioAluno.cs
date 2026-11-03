using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace ProjetoFinal_POO
{
    public class RepositorioAluno
    {
        private static readonly string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\alunos_academia.xml";

        // Método para Salvar (Escrita no XML)
        public static void Salvar(List<Aluno> listaAlunos)
        {
            // Prepara objeto serializador para a lista de clientes
            XmlSerializer writer = new XmlSerializer(typeof(List<Aluno>));

            // Prepara o arquivo XML para gravar no disco na pasta Meus Documentos
            FileStream arquivoXML = File.Create(path);

            // Realiza a serialização e gravação no disco
            writer.Serialize(arquivoXML, listaAlunos);
            arquivoXML.Close();
        }

        // Método para Carregar (Leitura do XML)
        public static List<Aluno> Carregar()
        {
            // Se o arquivo ainda não existir, retorna uma lista vazia
            if (!File.Exists(path))
            {
                return new List<Aluno>();
            }

            // Prepara objeto leitor
            XmlSerializer reader = new XmlSerializer(typeof(List<Aluno>));
            using (StreamReader arquivoXML = new StreamReader(path))
            {
                var lista = reader.Deserialize(arquivoXML) as List<Aluno>;
                return lista ?? new List<Aluno>();
            }
        }
    }
}
