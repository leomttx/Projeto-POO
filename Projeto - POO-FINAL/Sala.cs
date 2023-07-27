using System;
using System.Collections;

namespace Modelo
{
    // Enum para representar o status da sala
    public enum StatusSala
    {
        Disponivel,
        Ocupado,
        Interditado
    }

    // Classe Sala
    public class Sala
    {
        public int Id { get; set; }
        public StatusSala Status { get; set; }
        public string Nome { get; set; }
        public int Capacidade { get; set; }

        public Sala() {}
        public Sala(int id, StatusSala status, int capacidade, string nome){
            Id =id;
            Capacidade =capacidade;
            Status = status;
            Nome = nome;
        }
        public override string ToString()
        {
            return $"ID sala: {Id}\nStatus: {Status}\nNome: {Nome}\nCapacidade: {Capacidade}";
        }
    }   
}
