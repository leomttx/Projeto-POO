using System;
using Modelo;
using System.Linq;
using System.Xml.Serialization;
using System.Collections.Generic;
// Classe de negócio para Sala
namespace Negocio
{
    public static class NSala
    {
        private static List<Sala> salas = new List<Sala>();

        public static List<Sala> SalaListar()
        {
            SalaAbrirArquivo();
            return salas;

        }
        public static Sala GetSala(int id){
            SalaAbrirArquivo();
            return salas.Where(x => x.Id == id).SingleOrDefault();
        }

        public static void SalaInserir(Sala s)
        {
            // Trecho de código para não inserir salas com números de ids repetidos.
            SalaAbrirArquivo();
            int id;
            if (salas.Count == 0){
                id = 1;
            }
            else{
                id = salas.Max(x => x.Id);
                id++;
            }
            s.Id = id;
            salas.Add(s);
            SalaSalvarArquivo();
        }

        public static void SalaExcluir(Sala s)
        {
            SalaAbrirArquivo();
            Sala sala = GetSala(s.Id);
            if(sala == null){
                throw new ArgumentOutOfRangeException("Sala não existe.");
            }
            salas.Remove(sala);
            SalaSalvarArquivo();
        }
        
        public static void SalaAbrirArquivo(){
            XmlSerializer xml = new XmlSerializer(typeof(List<Modelo.Sala>));
            StreamReader linha = null;
            try{
                linha = new StreamReader("./salas.xml");
                salas = (List<Modelo.Sala>) xml.Deserialize(linha);
            }
            catch (FileNotFoundException){
                salas = new List<Modelo.Sala>();
            }
            if (linha != null){
                linha.Close();
            }
        }
        public static void SalaSalvarArquivo(){
            XmlSerializer xml = new XmlSerializer(typeof(List<Modelo.Sala>));
            StreamWriter linha = new StreamWriter("./salas.xml", false);
            xml.Serialize(linha, salas);
            linha.Close();
        }
        public static void SalaAlterar(Sala s)
        {
            SalaAbrirArquivo();
            Sala sala = GetSala(s.Id);
            if(sala == null){
                throw new ArgumentOutOfRangeException("Sala não existe.");
            }
            sala.Capacidade = s.Capacidade;
            sala.Nome = s.Nome;
            sala.Status = s.Status;
            SalaSalvarArquivo();
        }
    }
}


