using System;


enum StatusSala : byte{
    Disponivel = 1, Ocupado = 2, Interditado = 3
}
class Sala {
    public int Id;
    public int capacidade;
    public string nome;
    public StatusSala status;
}