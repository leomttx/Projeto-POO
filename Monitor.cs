using System;

class Monitor {
    public int idMonitor;
    public long matricula;
    public string senha;

    public Monitor(int idMonitor, long matricula, string senha){
        this.idMonitor = idMonitor;
        this.matricula = matricula;
        this.senha = senha;
    }

    /*public void SetIdBolsita(int idMonitor){
        this.idMonitor = idMonitor;
    } 
    public void SetMatricula(long matricula){
        this.matricula = matricula;
    }
    public void SetSenha(string senha){
        this.senha = senha;
    }
    public int GetIdMonitor(){
        return idMonitor;
    }
    public long GetMatricula(){
        return matricula;
    }
    public string GetSenha(){
        return senha;
    }*/
    public override string ToString() {
        return $"{idMonitor} - {matricula} - {senha}";
    }
}