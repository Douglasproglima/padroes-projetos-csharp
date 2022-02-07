using System.Globalization;

namespace observer
{
    public class Util
    {
        public string FormatarValor(double valor)
        {
            return valor.ToString("C", CultureInfo.CurrentCulture);
        }
    }
}
