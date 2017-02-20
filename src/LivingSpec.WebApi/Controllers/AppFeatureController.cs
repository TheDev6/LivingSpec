namespace LivingSpec.WebApi.Controllers
{
    using System;
    using System.Net;
    using System.Net.Http;
	using System.Web.Http;
    using System.Threading.Tasks;
	using System.Collections.Generic;
    using System.Web.Http.Description;
    using Models;
    using RootContracts.BehaviorContracts.DataAccess;
    using RootContracts.DataContracts.Domain;
    using Validation;

	public partial class AppFeatureController : ApiController
	{
		private readonly ILivingSpecContext _livingSpecContext;

		public AppFeatureController(ILivingSpecContext livingSpecContext)
		{
			this._livingSpecContext = livingSpecContext;
		}

		[HttpPost]
		[Route("api/v1/AppFeature")]
		[ValidateModelState]
		[ResponseType(typeof(IApiResponse<object>))]
		public async Task<HttpResponseMessage> Post(AppFeatureCreateModel model)
		{
			var result = new ApiResponse<object>();
			await this._livingSpecContext.AppFeatureInsertAsync(model).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.Created, value: result);
		}

		[HttpPut]
        [Route("api/v1/ArtifactWorkItem")]
        [ResponseType(typeof(IApiResponse<object>))]
        [ValidateModelState]
        public async Task<HttpResponseMessage> Update(AppFeatureUpdateModel model)
        {
            var result = new ApiResponse<object>();
            await this._livingSpecContext.AppFeatureUpdateAsync(model).ConfigureAwait(false);
            return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
        }

		[HttpGet]
		[Route("api/v1/AppFeature/Select")]
		[ResponseType(typeof(IApiResponse<IAppFeature>))]
		public async Task<HttpResponseMessage> Select(Guid appFeatureGuid)
		{
			var result = new ApiResponse<IAppFeature>();
			result.Payload = await this._livingSpecContext.AppFeatureSelectAsync(appFeatureGuid).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}

		[HttpGet]
		[Route("api/v1/AppFeature/Find")]
		[ResponseType(typeof(IApiResponse<List<IAppFeature>>))]
		public async Task<HttpResponseMessage> Find(AppFeatureFindModel model)
		{
			var result = new ApiResponse<List<IAppFeature>>();
			result.Payload = await this._livingSpecContext.AppFeatureFindAsync(appFeatureGuid : model?.AppFeatureGuid,
				appGuid : model?.AppGuid,
				featureGuid : model?.FeatureGuid
				).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}

		[HttpDelete]
		[Route("api/v1/AppFeature")]
		[ResponseType(typeof(IApiResponse<object>))]
		public async Task<HttpResponseMessage> Delete(Guid appFeatureGuid)
		{
			var result = new ApiResponse<object>();
			await this._livingSpecContext.AppFeatureDeleteAsync(appFeatureGuid).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}
	}
}
