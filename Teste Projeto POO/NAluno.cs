// Classe de negócio para Aluno
public static class NAluno
{
    private static List<Aluno> alunos = new List<Aluno>();

    public static List<Aluno> AlunoListar()
    {
        return alunos;
    }

    public static void AlunoInserir(Aluno a)
    {
        alunos.Add(a);
    }

    public static void AlunoExcluir(Aluno a)
    {
        alunos.Remove(a);
    }
    // Falta Inplementar a função alterar.
    public static void AlunoAlterar(Aluno a)
    {   
        a.Id;
        a.Matricula;
        a.Nome;
        a.Curso;
        a.NumContato;
        // Implemente o código para alterar um aluno na lista
        // Você pode usar o Id do aluno para encontrá-lo na lista e fazer as alterações necessárias.
    }
}
