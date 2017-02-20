namespace LivingSpec.WebApi
{
    using System.Net.Http.Formatting;
    using System.Web.Http;
    using FluentValidation.WebApi;

    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Only use json. Xml will break.
            config.Formatters.Clear();
            config.Formatters.Add(new JsonMediaTypeFormatter());

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );

            //registers custom model validators via Fluent Validation
            //http://www.justinsaraceno.com/2014/07/fluentvalidation-with-webapi2/
            //http://fluentvalidation.codeplex.com/wikipage?title=mvc&referringTitle=Documentation
            FluentValidationModelValidatorProvider.Configure(GlobalConfiguration.Configuration);

            config.EnableCors(defaultPolicyProvider: new CorsCustomPolicyProvider());
        }
    }
}
