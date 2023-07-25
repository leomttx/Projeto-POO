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

        public static void MonitorAlterar(Monitor b)
        {
            // Implemente o código para alterar um monitor na lista
            // Você pode usar o Id do monitor para encontrá-lo na lista e fazer as alterações necessárias.
        }
    }
}
