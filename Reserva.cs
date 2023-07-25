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
    }
}
