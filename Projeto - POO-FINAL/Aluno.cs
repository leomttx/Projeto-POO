using System;
using System.Collections;

// Classe Aluno
namespace Modelo
{
    public class Aluno
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string NumContato { get; set; }
        public string Curso { get; set; }
        public Aluno() {}
        public Aluno(int id, string nome, string mat, string ctt, string curso){
            Id = id;
            Nome = nome;
            Matricula = mat;
            NumContato = ctt;
            Curso = curso;
        }
    }
}
