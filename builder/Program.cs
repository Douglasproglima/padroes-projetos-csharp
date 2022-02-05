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
            criarNf.InserirRazaoSocial("Minha Empresa");
            criarNf.InserirCNPJ("45.563.289/0001-95");
            criarNf.InserirItem(new ItemNota("Item 1", 55.68));
            criarNf.InserirItem(new ItemNota("Item 2", 105.01));
            criarNf.InserirItem(new ItemNota("Item 3", 75.65));
            criarNf.InserirItem(new ItemNota("Item 4", 10.34));
            criarNf.InserirObs("Uma observação qualquer");
            criarNf.DataAtual();

            NotaFiscal nf = criarNf.CriarNF();

            Console.WriteLine($"Empresa: {nf.RazaoSocial}\nCNPJ: {nf.Cnpj}");
            Console.ReadKey();
        }
    }
}
