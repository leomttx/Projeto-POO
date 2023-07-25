using System;
using Modelo;
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
            return alunos;
        }

        public static void AlunoInserir(Aluno a)
        {
            alunos.Add(a);
        }

        public static void AlunoExcluir(Aluno a)
        {
            alunos.Remove(a);
        }
        
        public static Aluno AlunoListar(int id){
            // Percorrer o vetor dos alunos e retornar o aluno com o id informado.
            foreach (Aluno a in alunos)
            {
                if( a != null && a.Id == id) return a;
            }
            return null;
        }
        public static void AlunoAlterar(Aluno a)
        {   
            Aluno idAluno = AlunoListar(a.Id);
            if (idAluno != null){
                idAluno.Id = a.Id;
                idAluno.Matricula = a.Matricula;
                idAluno.Nome = a.Nome;
                idAluno.Curso = a.Curso;
                idAluno.NumContato = a.NumContato;
            }
        }
    }
}
    