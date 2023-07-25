using System;
using Modelo;
using System.Linq;
using System.Collections.Generic;
// Classe de negócio para Sala
namespace Negocio
{
    public static class NSala
    {
        private static List<Sala> salas = new List<Sala>();

        public static List<Sala> SalaListar()
        {
            return salas;
        }

        public static void SalaInserir(Sala s)
        {
            salas.Add(s);
        }

        public static void SalaExcluir(Sala s)
        {
            salas.Remove(s);
        }

        public static void SalaAlterar(Sala s)
        {
            // Implemente o código para alterar uma sala na lista
            // Você pode usar o Id da sala para encontrá-la na lista e fazer as alterações necessárias.
        }
    }
}


