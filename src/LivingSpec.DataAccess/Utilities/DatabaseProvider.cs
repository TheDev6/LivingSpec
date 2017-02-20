namespace LivingSpec.DataAccess.Utilities
{
    using System.Data.SqlClient;
    using RootContracts.BehaviorContracts.Configuration;
    using RootContracts.BehaviorContracts.DataAccess;

    public class DatabaseProvider : IDatabaseProvider
    {
        private readonly IConfig _config;

        public DatabaseProvider(IConfig config)
        {
            this._config = config;
        }

        public SqlConnection GetConnection()
        {
            var result = new SqlConnection(this._config.LivingSpecConnection());
            //TODO set timouts?
            return result;
        }
    }
}