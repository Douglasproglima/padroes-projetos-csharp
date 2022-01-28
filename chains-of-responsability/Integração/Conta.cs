﻿namespace chains_of_responsability.Integração
{
    public class Conta
    {
        public string Titular { get; private set; }
        public double Saldo { get; private set; }


        public Conta(string titular, double saldo)
        { 
            this.Titular = titular;
            this.Saldo = saldo;
        }
    }
}
