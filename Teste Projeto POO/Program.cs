using System;
using System.Collections.Generic;

// Classe de visão (program) com o menu
public class Program1
{
    public static void Main()
    {
        bool sair = false;

        while (!sair)
        {
            Console.WriteLine("------- Menu -------");
            Console.WriteLine("1. Listar Monitores");
            Console.WriteLine("2. Inserir Monitor");
            Console.WriteLine("3. Excluir Monitor");
            Console.WriteLine("4. Listar Alunos");
            Console.WriteLine("5. Inserir Aluno");
            Console.WriteLine("6. Excluir Aluno");
            Console.WriteLine("7. Listar Reservas");
            Console.WriteLine("8. Inserir Reserva");
            Console.WriteLine("9. Excluir Reserva");
            Console.WriteLine("10. Listar Salas");
            Console.WriteLine("11. Inserir Sala");
            Console.WriteLine("12. Excluir Sala");
            Console.WriteLine("13. Alterar Aluno");
            Console.WriteLine("0. Sair");

            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    ListarMonitores();
                    break;
                case 2:
                    InserirMonitor();
                    break;
                case 3:
                    ExcluirMonitor();
                    break;
                case 4:
                    ListarAlunos();
                    break;
                case 5:
                    InserirAluno();
                    break;
                case 6:
                    ExcluirAluno();
                    break;
                case 7:
                    ListarReservas();
                    break;
                case 8:
                    InserirReserva();
                    break;
                case 9:
                    ExcluirReserva();
                    break;
                case 10:
                    ListarSalas();
                    break;
                case 11:
                    InserirSala();
                    break;
                case 12:
                    ExcluirSala();
                    break;
                case 13:
                    AlunoAlterar();
                    break;
                case 0:
                    sair = true;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.WriteLine("--------------------");
        }
    }

    // Métodos para acessar as funções da área de negócio
    private static void ListarMonitores()
    {
        List<Monitor> monitores = NMonitor.MonitorListar();
        foreach (var monitor in monitores)
        {
            Console.WriteLine("ID: " + monitor.Id + ", Matrícula: " + monitor.Matricula + ", Senha: " + monitor.Senha);
        }
    }

    private static void InserirMonitor()
    {
        Monitor monitor = new Monitor();

        Console.Write("ID: ");
        monitor.Id = int.Parse(Console.ReadLine());

        Console.Write("Matrícula: ");
        monitor.Matricula = Console.ReadLine();

        Console.Write("Senha: ");
        monitor.Senha = Console.ReadLine();

        NMonitor.MonitorInserir(monitor);
        Console.WriteLine("Monitor inserido com sucesso!");
    }

    private static void ExcluirMonitor()
    {
        Console.Write("Digite o ID do monitor a ser excluído: ");
        int id = int.Parse(Console.ReadLine());

        Monitor monitor = NMonitor.MonitorListar().Find(m => m.Id == id);

        if (monitor != null)
        {
            NMonitor.MonitorExcluir(monitor);
            Console.WriteLine("Monitor excluído com sucesso!");
        }
        else
        {
            Console.WriteLine("Monitor não encontrado!");
        }
    }

    private static void ListarAlunos()
    {
        List<Aluno> alunos = NAluno.AlunoListar();
        Console.WriteLine("----LISTANDO ALUNOS----");
        foreach (var aluno in alunos)
        {
            Console.WriteLine(" ID: " + aluno.Id);
            Console.WriteLine(" Matrícula: " + aluno.Matricula);
            Console.WriteLine(" Nome: " + aluno.Nome);
            Console.WriteLine(" Curso " + aluno.Curso);
            Console.WriteLine(" Número para contato: " + aluno.NumContato);
        }
    }

    private static void InserirAluno()
    {
        Console.WriteLine("----INSERINDO ALUNO----");
        Aluno aluno = new Aluno();

        Console.Write("ID: ");
        aluno.Id = int.Parse(Console.ReadLine());

        Console.Write("Nome: ");
        aluno.Nome = Console.ReadLine();

        Console.Write("Matrícula: ");
        aluno.Matricula = Console.ReadLine();

        Console.Write("Curso: ");
        aluno.Curso = Console.ReadLine();

        Console.Write("Número de contato: ");
        aluno.NumContato = Console.ReadLine();

        NAluno.AlunoInserir(aluno);
        Console.WriteLine("Aluno inserido com sucesso!");
    }
    // Função alterar não funciona ainda.
    private static void AlunoAlterar(){
        Console.WriteLine("----ALTERANDO ALUNO----");

        Console.Write("Digite o ID do aluno a ser Alterado: ");
        int id = int.Parse(Console.ReadLine());

        Aluno aluno = NAluno.AlunoAlterar().Find(a => a.Id == id);

        Console.WriteLine($"O nome do aluno que você quer excluir é: {aluno.Nome}");
        Console.Write("Digite 1 para SIM ou 0 para NÂO:");
        int ctz = int.Parse(Console.ReadLine());
        if (ctz == 1){
            if (aluno != null)
            {
                Console.WriteLine("Altere o nome do Aluno: ");
                aluno.Nome = Console.ReadLine();

                Console.WriteLine("Altere Matricula do Aluno: ");
                aluno.Matricula = Console.ReadLine();

                Console.WriteLine("Altere o número de contato do Aluno: ");
                aluno.NumContato = Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Aluno não encontrado!");
            }
        }
        else{
            Console.WriteLine("Digite novamente a opção 13 para refazer o processo.");
        }
    }
    private static void ExcluirAluno()
    {
        Console.WriteLine("----EXCLUINDO ALUNO----");
        Console.Write("Digite o ID do aluno a ser excluído: ");
        int id = int.Parse(Console.ReadLine());

        Aluno aluno = NAluno.AlunoListar().Find(a => a.Id == id);

        Console.WriteLine($"O nome do aluno que você quer excluir é: {aluno.Nome}");
        Console.Write("Digite 1 para SIM ou 0 para NÂO:");
        int ctz = int.Parse(Console.ReadLine());
        if (ctz == 1){
            if (aluno != null)
            {
                NAluno.AlunoExcluir(aluno);
                Console.WriteLine("Aluno excluído com sucesso!");
            }
            else
            {
                Console.WriteLine("Aluno não encontrado!");
            }
        }
        else{
            Console.WriteLine("Digite novamente a opção 6 para refazer o processo.");
        }
    }

    private static void ListarReservas()
    {
        Console.WriteLine("----LISTANDO RESERVAS----");
        List<Reserva> reservas = NReserva.ReservaListar();
        foreach (var reserva in reservas)
        {
            Console.WriteLine("ID: " + reserva.Id);
            Console.WriteLine(" ID Sala: " + reserva.IdSala);
            Console.WriteLine(" ID Aluno: " + reserva.IdAluno);
            Console.WriteLine(" ID Monitor " + reserva.IdMonitor);
            Console.WriteLine(" Data e Hora da Reserva " + reserva.DataHoraReserva);
            Console.WriteLine(" Status da reserva " + reserva.Status);
            Console.WriteLine(" Itens? " + reserva.Emprestimo);
        }
    }

    private static void InserirReserva()
    {
        Console.WriteLine("----INSERINDO RESERVAS----");
        Reserva reserva = new Reserva();

        Console.Write("ID: ");
        reserva.Id = int.Parse(Console.ReadLine());

        Console.Write("ID Sala: ");
        reserva.IdSala = int.Parse(Console.ReadLine());

        Console.Write("ID Aluno: ");
        reserva.IdAluno = int.Parse(Console.ReadLine());

        Console.WriteLine("ID Monitor: ");
        reserva.IdMonitor = int.Parse(Console.ReadLine());

        reserva.DataHoraReserva = DateTime.Now;

        reserva.Status = StatusReserva.Ativa; 

        Console.WriteLine(" Pegou itens?: ");
        reserva.Emprestimo = bool.Parse(Console.ReadLine());

        Console.WriteLine(" Quantidade de alunos: ");
        reserva.QtdAlunos = int.Parse(Console.ReadLine());

        NReserva.ReservaInserir(reserva);
        Console.WriteLine("Reserva inserida com sucesso!");
    }
    private static void ReservaAlterar(){
        Console.WriteLine("----ALTERANDO RESERVA----");
        Reserva reserva = new Reserva();
        Console.WriteLine(" Altere o ID da Reserva: ");
        reserva.Id = int.Parse(Console.ReadLine());

        Console.WriteLine(" Altere o ID da Sala: ");
        reserva.IdSala = int.Parse(Console.ReadLine());

        Console.WriteLine(" Altere o ID do Monitor: ");
        reserva.IdMonitor = int.Parse(Console.ReadLine());

        Console.WriteLine(" Altere a hora da Reserva: ");
        reserva.DataHoraReserva = DateTime.Parse(Console.ReadLine());

        Console.WriteLine(" Altere se alguém pegou items: ");
        reserva.Emprestimo = bool.Parse(Console.ReadLine());

        Console.WriteLine(" Altere a Quantidade de alunos: ");
        reserva.QtdAlunos = int.Parse(Console.ReadLine());
    }
    private static void ExcluirReserva()
    {
        Console.WriteLine("----EXCLUINDO RESERVA----");
        Console.Write("Digite o ID da reserva a ser excluída: ");
        int id = int.Parse(Console.ReadLine());
        
        Reserva reserva = NReserva.ReservaListar().Find(r => r.Id == id);

        Console.WriteLine($"O ID da reserva que você quer excluir é: {reserva.Id}");
        Console.Write("Digite 1 para SIM ou 0 para NÂO:");
        int ctz = int.Parse(Console.ReadLine());
        if (ctz == 1){

            if (reserva != null)
            {
                NReserva.ReservaExcluir(reserva);
                Console.WriteLine("Reserva excluída com sucesso!");
            }
            else
            {
                Console.WriteLine("Reserva não encontrada!");
            }
        }
        else{
            Console.WriteLine("Digite novamente a opção 9 para refazer o processo.");
        }
    }

    private static void ListarSalas()
    {
        Console.WriteLine("----LISTANDO SALAS----");
        List<Sala> salas = NSala.SalaListar();
        foreach (var sala in salas)
        {
            Console.WriteLine(" ID Sala: " + sala.Id);
            Console.WriteLine(" Nome da Sala: " + sala.Nome);
            Console.WriteLine(" Capacidade da Sala: " + sala.Capacidade);
            Console.WriteLine(" Status da Sala: " + sala.Status);
        }
    }

    private static void InserirSala()
    {
        Console.WriteLine("----INSERINDO SALAS----");
        Sala sala = new Sala();

        Console.Write("ID: ");
        sala.Id = int.Parse(Console.ReadLine());

        Console.Write("Nome: ");
        sala.Nome = Console.ReadLine();

        Console.Write("Capacidade: ");
        sala.Capacidade = int.Parse(Console.ReadLine());

        Console.Write("Status da Sala: ");
        sala.Status = StatusSala.Disponivel;

        NSala.SalaInserir(sala);
        Console.WriteLine("Sala inserida com sucesso!");
    }

    private static void ExcluirSala()
    {
        Console.WriteLine("----EXCLUINDO SALAS----");
        Console.Write("Digite o ID da sala a ser excluída: ");
        int id = int.Parse(Console.ReadLine());

        Sala sala = NSala.SalaListar().Find(s => s.Id == id);

        Console.WriteLine($"O ID e o nome da sala que você quer excluir é: {sala.Id} {sala.Nome}");
        Console.Write("Digite 1 para SIM ou 0 para NÂO:");
        int ctz = int.Parse(Console.ReadLine());
        if (ctz == 1){

            if (sala != null)
            {
                NSala.SalaExcluir(sala);
                Console.WriteLine("Sala excluída com sucesso!");
            }
            else
            {
                Console.WriteLine("Sala não encontrada!");
            }
        }
        else{
            Console.WriteLine("Digite novamente a opção 12 para refazer o processo.");
        }
    }
}
