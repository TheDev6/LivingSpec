namespace LivingSpec.WebApi.Configuration
{
    using System.Configuration;
    using RootContracts.BehaviorContracts.Configuration;

    public class Config : IConfig
    {
        public string LivingSpecConnection() => ConfigurationManager.ConnectionStrings[""].ConnectionString;

    }
}