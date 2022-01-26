namespace FactoryMethod
{
    public sealed class Truck : ITransport
    {
        public string Build()
        {
            return "Transporte Caminhão";
        }
    }
}