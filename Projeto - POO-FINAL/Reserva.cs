using System;
using System.Collections;

namespace Modelo
{
    // Enum para representar o status da reserva
    public enum StatusReserva
    {
        Ativa,
        Cancelada
    }

    // Classe Reserva
    public class Reserva
    {
        public int Id { get; set; }
        public int IdSala { get; set; }
        public int IdAluno { get; set; }
        public int IdMonitor { get; set; }
        public DateTime DataHoraReserva { get; set; }
        public StatusReserva Status { get; set; }
        public bool Emprestimo { get; set; }
        public int QtdAlunos { get; set; }

        public Reserva() {}
        public Reserva(int id, int idsala, int idmonitor, int idaluno, int qtdalunos, DateTime dthreserva, bool emprestimo, StatusReserva status){
            Id = id;
            IdSala = idsala;
            IdAluno = idaluno;
            IdMonitor = idmonitor;
            QtdAlunos = qtdalunos;
            DataHoraReserva = dthreserva;
            Emprestimo = emprestimo;
            Status = status;
        }
    }
}
