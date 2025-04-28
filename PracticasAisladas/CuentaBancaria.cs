using System;


class CuentaBancaria{

public string Titular { get; set; } 
public double Saldo { get; set; }

public CuentaBancaria(string titular, int saldo){
    Titular = titular;
    Saldo = saldo;
}

    public double Depositar(double deposito){
            Saldo= Saldo + deposito;
        return Saldo;
    }

    public double Retirar(double deposito){
            Saldo= Saldo + deposito;
        return Saldo;
    }

    public void MostarSaldo(){
        Console.WriteLine($"Tu salfo es de: {Saldo}");
        Console.WriteLine($"_________________________");
    }

}