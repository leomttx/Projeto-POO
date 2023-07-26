using System;
using Modelo;
using System.Linq;
using System.Collections.Generic;
// Classe de negócio para Monitor
namespace Negocio
{
    public static class NMonitor
    {
        private static List<Monitor> monitores = new List<Monitor>();

        public static List<Monitor> MonitorListar()
        {
            return monitores;
        }

        public static void MonitorInserir(Monitor b)
        {
            monitores.Add(b);
        }

        public static void MonitorExcluir(Monitor b)
        {
            monitores.Remove(b);
        }

        public static Monitor MonitorListar(int id){
            // Percorrer o vetor dos monitores e retornar o monitor com o id informado.
            foreach (Monitor b in monitores)
            {
                if( b != null && b.Id == id) return b;
            }
            return null;
        }
        public static void MonitorAlterar(Monitor b)
        {   
            Monitor idMonitor = MonitorListar(b.Id);
            if (idMonitor!= null){
                idMonitor.Id = b.Id;
                idMonitor.Matricula = b.Matricula;
                idMonitor.Nome = b.Nome;
                idMonitor.Senha = b.Senha;
            }
        }
    }
}
