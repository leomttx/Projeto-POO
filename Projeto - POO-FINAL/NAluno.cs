using System;
using Modelo;
using System.Xml.Serialization;
using System.Linq;
using System.Collections.Generic;
// Classe de negócio para Aluno
namespace Negocio
{
    public static class NAluno
    {
        private static List<Aluno> alunos = new List<Aluno>();

        public static List<Aluno> AlunoListar()
        {
            AlunoAbrirArquivo();
            return alunos;
        }

        public static void AlunoInserir(Aluno a)
        {
            AlunoAbrirArquivo();
            int id;
            if (alunos.Count == 0){
                id = 1;
            }
            else{
                id = alunos.Max(x => x.Id);
                id++;
            }
            a.Id = id;
            alunos.Add(a);
            AlunoSalvarArquivo();
        }

        public static void AlunoExcluir(Aluno a)
        {
            AlunoAbrirArquivo();
            Aluno aluno = GetAluno(a.Id);
            if(aluno == null){
                throw new ArgumentOutOfRangeException("Aluno não existe.");
            }
            alunos.Remove(aluno);
            AlunoSalvarArquivo();
        }
        
        public static Aluno GetAluno(int id){
            // pegar o id específico do aluno.
            AlunoAbrirArquivo();
            return alunos.Where(x => x.Id == id).SingleOrDefault();
        }

        public static void AlunoAbrirArquivo(){
            XmlSerializer xml = new XmlSerializer(typeof(List<Modelo.Aluno>));
            StreamReader linha = null;
            try{
                linha = new StreamReader("./alunos.xml");
                alunos = (List<Modelo.Aluno>) xml.Deserialize(linha);
            }
            catch (FileNotFoundException){
                alunos = new List<Modelo.Aluno>();
            }
            if (linha != null){
                linha.Close();
            }
        }

        public static void AlunoSalvarArquivo(){
            XmlSerializer xml = new XmlSerializer(typeof(List<Modelo.Aluno>));
            StreamWriter linha = new StreamWriter("./alunos.xml", false);
            xml.Serialize(linha, alunos);
            linha.Close();
        }

        public static void AlunoAlterar(Aluno a)
        {   
            AlunoAbrirArquivo();
            Aluno aluno = GetAluno(a.Id);
            if(aluno == null){
                throw new ArgumentOutOfRangeException("Aluno não existe.");
            }
            aluno.Id = a.Id;
            aluno.Matricula = a.Matricula;
            aluno.Nome = a.Nome;
            aluno.Curso = a.Curso;
            aluno.NumContato = a.NumContato;
            AlunoSalvarArquivo();
        }
    }
}
    