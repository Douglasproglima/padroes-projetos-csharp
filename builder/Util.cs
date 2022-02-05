using System.Globalization;

namespace builder
{
    public class Util
    {
        public string FormatarValor(double valor)
        {
            return valor.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
