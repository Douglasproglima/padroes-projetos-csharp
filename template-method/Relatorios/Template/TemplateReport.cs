using System.Collections.Generic;

namespace template_method.Relatorios.Interface
{
    public abstract class TemplateReport
    {
        public abstract void Header();
        public abstract void Body(IList<Conta> contas);
        public abstract void Footer();
        public void Printer(IList<Conta> contas)
        { 
            this.Header();
            this.Body(contas);
            this.Footer();
        }
    }
}
