namespace FactoryMethod
{
  public sealed class Bus : ITransport
  {
    public string Build()
    {
      return "Transporte Onibus";
    }
  }
}