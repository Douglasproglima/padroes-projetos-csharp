namespace FactoryMethod
{
  public sealed class Car :ITransport
  {
    public string Build()
    {
      return "Transporte Carro";
    }
  }
}