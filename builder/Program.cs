using System;
using System.Collections.Generic;

namespace builder
{
    internal class Program
    {
        /*Problema Proposto: Resolver a qtde de parâmetros passados no construtor de uma class para criação do objeto.*/
        static void Main(string[] args)
        {
            IList<ItemDaNota> itens = new List<ItemDaNota>();
            double valorTotal = 0;
            
            foreach (ItemDaNota item in itens)
            {
                valorTotal += item.Valor;
            }
            double impostos = valorTotal * 0.05;

            NotaFiscal nf = new NotaFiscal("Minha Empresa", "45.563.289/0001-95", DateTime.Now, valorTotal, impostos, itens, "observacoes quaisquer aqui");

            Console.WriteLine($"Empresa: {nf.RazaoSocial}\nCNPJ: {nf.Cnpj}");
            Console.ReadKey();
        }
    }
}
