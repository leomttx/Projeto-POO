using System;
//using Monitor;

namespace Projeto_POO
{
    class Program
    {
        static void Main(string[] args)
        {
            Monitor leo = new Monitor(1, 20221014040020, "1234");
            Console.WriteLine(leo);
            StatusSala Sala = StatusSala.Ocupado;
            Console.WriteLine((byte) Sala);
            Sala = (StatusSala) 2;
            Console.WriteLine(Sala);
        }
    }
}
