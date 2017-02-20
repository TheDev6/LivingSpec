namespace LivingSpec.RootContracts.BehaviorContracts.DataAccess
{
    using System.Data.SqlClient;

    public interface IDatabaseProvider
    {
        SqlConnection GetConnection();
    }
}