using System;
using System.Collections.Generic;
using template_method.Relatorios.Interface;

namespace template_method.Relatorios.Strateges
{
    public class SimpleReport : TemplateReport
    {
        public override void Header()
        {
            Console.WriteLine("Banco Itaú");
        }

        public override void Body(IList<Conta> contas)
        {
            foreach (Conta conta in contas)
                Console.WriteLine(conta.Nome + " - " + conta.Saldo);
        }

        public override void Footer()
        {
            Console.WriteLine("(37) 3241 - 3265");
        }
    }
}
