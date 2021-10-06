namespace AbstractFactory
{
  public class SqlFactory : DbFactory
  {
    public override DbConnection createConnection()
    {
      /* A classe aqui ficou encapsulada */
      return new SqlConnection();
    }

    public override DbCommand createCommand()
    {
      return new SqlCommand();
    }
  }
}