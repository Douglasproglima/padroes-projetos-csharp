namespace AbstractFactory
{
    public abstract class DbFactory
    {
        public abstract DbConnection CreateConnection();

        public abstract DbCommand CreateCommand();
    }
}