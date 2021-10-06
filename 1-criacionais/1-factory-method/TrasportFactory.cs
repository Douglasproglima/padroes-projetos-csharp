using System;

namespace FactoryMethod
{
  public static class TransportFactory
  {
    public static ITransport CreateInstance(string name)
    {
        /*
        *Eu usei o Activator para instanciar a subclasse mas poderia
        *ser instanciado de outra forma talvez, por exemplos usando
        *Reflector ou Domain.
        */
        return Activator.CreateInstance(Type.GetType($"FactoryMethod.{name}")) as ITransport;
    }
  }
}