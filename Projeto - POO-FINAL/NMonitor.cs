using System;
using Modelo;
using System.Xml.Serialization;
using System.Linq;
using System.Collections.Generic;
// Classe de negócio para Monitor
namespace Negocio
{
    public static class NMonitor
    {
        private static List<Modelo.Monitor> monitores = new List<Modelo.Monitor>();

        public static List<Modelo.Monitor> MonitorListar()
        {   
            MonitorAbrirArquivo();
            return monitores;
        }

        public static void MonitorInserir(Modelo.Monitor b)
        {
            MonitorAbrirArquivo();
            int id;
            if (monitores.Count == 0){
                id = 1;
            }
            else{
                id = monitores.Max(x => x.Id);
                id++;
            }
            b.Id = id;
            monitores.Add(b);
            MonitorSalvarArquivo();
        }

        public static void MonitorExcluir(Modelo.Monitor b)
        {
            MonitorAbrirArquivo();
            Modelo.Monitor monitor = GetMonitor(b.Id);
            if(monitor == null){
                throw new ArgumentOutOfRangeException("Aluno não existe.");
            }
            monitores.Remove(monitor);
            MonitorSalvarArquivo();
        }

        public static Modelo.Monitor GetMonitor(int id){
            // pegar o id específico do monitor.
            MonitorAbrirArquivo();
            return monitores.Where(x => x.Id == id).SingleOrDefault();
        }

         public static void MonitorAbrirArquivo(){
            XmlSerializer xml = new XmlSerializer(typeof(List<Modelo.Monitor>));
            StreamReader linha = null;
            try{
                linha = new StreamReader("./monitores.xml");
                monitores = (List<Modelo.Monitor>) xml.Deserialize(linha);
            }
            catch (FileNotFoundException){
                monitores = new List<Modelo.Monitor>();
            }
            if (linha != null){
                linha.Close();
            }
        }

        public static void MonitorSalvarArquivo(){
            XmlSerializer xml = new XmlSerializer(typeof(List<Modelo.Monitor>));
            StreamWriter linha = new StreamWriter("./monitores.xml", false);
            xml.Serialize(linha, monitores);
            linha.Close();
        }

        public static void MonitorAlterar(Modelo.Monitor b)
        {   
            MonitorAbrirArquivo();

            Modelo.Monitor monitor = GetMonitor(b.Id);
            if( monitor == null){
                throw new ArgumentOutOfRangeException(" Monitor não existe.");
            }
            monitor.Id = b.Id;
            monitor.Matricula = b.Matricula;
            monitor.Nome = b.Nome;
            monitor.Senha = b.Senha;
            
            MonitorSalvarArquivo();
        }
    }
}
