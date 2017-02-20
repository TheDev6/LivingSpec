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

	public partial class FeatureController : ApiController
	{
		private readonly ILivingSpecContext _livingSpecContext;

		public FeatureController(ILivingSpecContext livingSpecContext)
		{
			this._livingSpecContext = livingSpecContext;
		}

		[HttpPost]
		[Route("api/v1/Feature")]
		[ValidateModelState]
		[ResponseType(typeof(IApiResponse<object>))]
		public async Task<HttpResponseMessage> Post(FeatureCreateModel model)
		{
			var result = new ApiResponse<object>();
			await this._livingSpecContext.FeatureInsertAsync(model).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.Created, value: result);
		}

		[HttpPut]
        [Route("api/v1/ArtifactWorkItem")]
        [ResponseType(typeof(IApiResponse<object>))]
        [ValidateModelState]
        public async Task<HttpResponseMessage> Update(FeatureUpdateModel model)
        {
            var result = new ApiResponse<object>();
            await this._livingSpecContext.FeatureUpdateAsync(model).ConfigureAwait(false);
            return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
        }

		[HttpGet]
		[Route("api/v1/Feature/Select")]
		[ResponseType(typeof(IApiResponse<IFeature>))]
		public async Task<HttpResponseMessage> Select(Guid featureGuid)
		{
			var result = new ApiResponse<IFeature>();
			result.Payload = await this._livingSpecContext.FeatureSelectAsync(featureGuid).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}

		[HttpGet]
		[Route("api/v1/Feature/Find")]
		[ResponseType(typeof(IApiResponse<List<IFeature>>))]
		public async Task<HttpResponseMessage> Find(FeatureFindModel model)
		{
			var result = new ApiResponse<List<IFeature>>();
			result.Payload = await this._livingSpecContext.FeatureFindAsync(featureGuid : model?.FeatureGuid,
				name : model?.Name,
				gherkinText : model?.GherkinText
				).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}

		[HttpGet]
		[Route("api/v1/Feature/Search")]
		[ResponseType(typeof(IApiResponse<List<IFeature>>))]
		public async Task<HttpResponseMessage> Search(FeatureSearchModel model)
		{
			var result = new ApiResponse<List<IFeature>>();
			result.Payload = await this._livingSpecContext.FeatureSearchAsync(
			nameStartsWith : model?.NameStartsWith,
				nameContains : model?.NameContains,
				gherkinTextStartsWith : model?.GherkinTextStartsWith,
				gherkinTextContains : model?.GherkinTextContains
				).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}


		[HttpDelete]
		[Route("api/v1/Feature")]
		[ResponseType(typeof(IApiResponse<object>))]
		public async Task<HttpResponseMessage> Delete(Guid featureGuid)
		{
			var result = new ApiResponse<object>();
			await this._livingSpecContext.FeatureDeleteAsync(featureGuid).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}
	}
}
