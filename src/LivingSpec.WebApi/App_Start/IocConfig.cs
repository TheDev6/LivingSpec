namespace LivingSpec.WebApi
{
    using System.Web.Http;
    using Configuration;
    using DataAccess.DataObjects;
    using DataAccess.Utilities;
    using RootContracts.BehaviorContracts.Configuration;
    using RootContracts.BehaviorContracts.DataAccess;
    using RootContracts.BehaviorContracts.Validation;
    using SimpleInjector;
    using SimpleInjector.Integration.WebApi;
    using Validation;

    public static class IocConfig
    {
        public static SimpleInjector.Container SimpleInjectorContainer { get; private set; }

        internal static void RegisterComponents(HttpConfiguration config)
        {
            var container = new Container();

            #region Registrations
            container.Register<IConfig, Config>();
            container.Register<IDapperWrapper, DapperWrapper>();
            container.Register<IDatabaseProvider, DatabaseProvider>();
            container.Register<ILivingSpecContext, LivingSpecContext>();
            container.Register<IModelStateErrorParser, ModelStateErrorParser>();
            #endregion

            //This is what allows the controllers to instantiate using simple injector
            GlobalConfiguration.Configuration.DependencyResolver = new SimpleInjectorWebApiDependencyResolver(container);

            //get errors at start rather than run. Thanks SimpleInjector :)
            container.Verify();

            //set the public container for lame things like attributes and service locator pattern.
            SimpleInjectorContainer = container;
        }
    }
}