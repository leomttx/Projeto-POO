using System;
using System.Collections;

// Classe Monitor
namespace Modelo
{
    public class Monitor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Matricula { get; set; }
        public string Senha { get; set; }

        public Monitor() {}
        public Monitor(int id, string nome, string mat, string senha){
            Id = id;
            Nome = nome;
            Matricula = mat;
            Senha = senha;
        }
    }
}
