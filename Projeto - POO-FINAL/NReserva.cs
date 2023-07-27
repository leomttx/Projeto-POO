using System;
using Modelo;
using System.Linq;
using System.Xml.Serialization;
using System.Collections.Generic;
// Classe de negócio para Reserva
namespace Negocio
{
    public static class NReserva
    {
        private static List<Reserva> reservas = new List<Reserva>();

        public static List<Reserva> ReservaListar()
        {
            ReservaAbrirArquivo();
            return reservas;
        }

        public static void ReservaInserir(Reserva r)
        {
            // Trecho de código para não inserir salas com números repetidos.
            ReservaAbrirArquivo();
            int id;
            if (reservas.Count == 0){
                id = 1;
            }
            else{
                id = reservas.Max(x => x.Id);
                id++;
            }
            r.Id = id;
            reservas.Add(r);
            ReservaSalvarArquivo();
        }

        public static void ReservaExcluir(Reserva r)
        {
            ReservaAbrirArquivo();
            Reserva reserva = GetReserva(r.Id);
            if(reserva == null){
                throw new ArgumentOutOfRangeException("Reserva não existe.");
            }
            reservas.Remove(reserva);
            ReservaSalvarArquivo();
        }

        public static Reserva GetReserva(int id){
            // Pega o id especifico da reserva.
            ReservaAbrirArquivo();
            return reservas.Where(i => i.Id == id).SingleOrDefault();
        }

        public static void ReservaAbrirArquivo(){
            XmlSerializer xml = new XmlSerializer(typeof(List<Modelo.Reserva>));
            StreamReader linha = null;
            try{
                linha = new StreamReader("./reservas.xml");
                reservas = (List<Modelo.Reserva>) xml.Deserialize(linha);
            }
            catch (FileNotFoundException){
                reservas = new List<Modelo.Reserva>();
            }
            if (linha != null){
                linha.Close();
            }
        }

        public static void ReservaSalvarArquivo(){
            XmlSerializer xml = new XmlSerializer(typeof(List<Modelo.Reserva>));
            StreamWriter linha = new StreamWriter("./reservas.xml", false);
            xml.Serialize(linha, reservas);
            linha.Close();
        }
        public static void ReservaAlterar(Reserva r)
        {   
            ReservaAbrirArquivo();
            Reserva idReserva = GetReserva(r.Id);
            if(idReserva == null){
                throw new ArgumentOutOfRangeException("Reserva não existe.");
            }
            idReserva.Id = r.Id;
            idReserva.IdAluno = r.IdAluno;
            idReserva.IdMonitor = r.IdMonitor;
            idReserva.IdSala = r.IdSala;
            idReserva.DataHoraReserva = r.DataHoraReserva;
            idReserva.QtdAlunos = r.QtdAlunos;
            idReserva.Status = r.Status;
            idReserva.Emprestimo = r.Emprestimo;
            ReservaSalvarArquivo();
        }
    }
}

