// Classe de negócio para Reserva
public static class NReserva
{
    private static List<Reserva> reservas = new List<Reserva>();

    public static List<Reserva> ReservaListar()
    {
        return reservas;
    }

    public static void ReservaInserir(Reserva r)
    {
        reservas.Add(r);
    }

    public static void ReservaExcluir(Reserva r)
    {
        reservas.Remove(r);
    }

    public static void ReservaAlterar(Reserva r)
    {
        // Implemente o código para alterar uma reserva na lista
        // Você pode usar o Id da reserva para encontrá-la na lista e fazer as alterações necessárias.
    }
}
