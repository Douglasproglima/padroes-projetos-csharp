using System;
using System.Collections.Generic;
using template_method.Relatorios.Interface;

namespace template_method.Relatorios.Strateges
{
    public class DetailReport : TemplateReport
    {
        public override void Header()
        {
            Console.WriteLine("Banco Itaú");
            Console.WriteLine("Avenida Silva Jardim, Centro, Itaúna - MG");
            Console.WriteLine("(37) 3224 - 3265");
        }

        public override void Body(IList<Conta> contas)
        {
            foreach(Conta conta in contas)
                Console.WriteLine(conta.Nome + " - " + conta.Agencia + " - " + conta.Saldo);
        }

        public override void Footer()
        {
            Console.WriteLine("contato@bancoitau.com.br");
            Console.WriteLine(DateTime.Now.Date);
        }
    }
}
