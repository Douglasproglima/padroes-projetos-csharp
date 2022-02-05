using System;
using System.Collections.Generic;

namespace builder
{
    internal class Program
    {
        /*Problema Proposto: Resolver a qtde de parâmetros passados no construtor de uma class para criação do objeto.*/
        static void Main(string[] args)
        {
            NotaFiscalBuilder criarNf = new NotaFiscalBuilder();
            criarNf.InserirRazaoSocial("Minha Empresa")
                   .InserirCNPJ("45.563.289/0001-95")
                   .InserirItem(new ItemNota("Item 1", 55.68))
                   .InserirItem(new ItemNota("Item 2", 105.01))
                   .InserirItem(new ItemNota("Item 3", 75.65))
                   .InserirItem(new ItemNota("Item 4", 10.34))
                   .InserirObs("Uma observação qualquer")
                   .DataAtual();

            NotaFiscal nf = criarNf.CriarNF();

            Console.WriteLine($"Empresa: {nf.RazaoSocial}\nCNPJ: {nf.Cnpj}");
            Console.ReadKey();
        }
    }
}
