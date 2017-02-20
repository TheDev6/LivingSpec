namespace LivingSpec.WebApi
{
    using System;
    using System.Configuration;
    using System.Net.Http;
    using System.Threading;
    using System.Threading.Tasks;
    using System.Web.Cors;

    public class CorsCustomPolicyProvider : System.Web.Http.Cors.ICorsPolicyProvider
    {
        private readonly CorsPolicy _corsPolicy;

        public CorsCustomPolicyProvider()
        {
            this._corsPolicy = new CorsPolicy()
            {
                AllowAnyMethod = true,
                AllowAnyHeader = true,
                AllowAnyOrigin = false,
                SupportsCredentials = true
            };


            var internalOrigins = ConfigurationManager.AppSettings.Get("internal:origins");
            if (!String.IsNullOrWhiteSpace(internalOrigins))
            {
                var origins = internalOrigins.Split(',');
                foreach (var origin in origins)
                {
                    this._corsPolicy.Origins.Add(origin);
                }
            }
        }

        public Task<CorsPolicy> GetCorsPolicyAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return Task.FromResult(this._corsPolicy);
        }
    }
}