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

	public partial class AppController : ApiController
	{
		private readonly ILivingSpecContext _livingSpecContext;

		public AppController(ILivingSpecContext livingSpecContext)
		{
			this._livingSpecContext = livingSpecContext;
		}

		[HttpPost]
		[Route("api/v1/App")]
		[ValidateModelState]
		[ResponseType(typeof(IApiResponse<object>))]
		public async Task<HttpResponseMessage> Post(AppCreateModel model)
		{
			var result = new ApiResponse<object>();
			await this._livingSpecContext.AppInsertAsync(model).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.Created, value: result);
		}

		[HttpPut]
        [Route("api/v1/ArtifactWorkItem")]
        [ResponseType(typeof(IApiResponse<object>))]
        [ValidateModelState]
        public async Task<HttpResponseMessage> Update(AppUpdateModel model)
        {
            var result = new ApiResponse<object>();
            await this._livingSpecContext.AppUpdateAsync(model).ConfigureAwait(false);
            return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
        }

		[HttpGet]
		[Route("api/v1/App/Select")]
		[ResponseType(typeof(IApiResponse<IApp>))]
		public async Task<HttpResponseMessage> Select(Guid appGuid)
		{
			var result = new ApiResponse<IApp>();
			result.Payload = await this._livingSpecContext.AppSelectAsync(appGuid).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}

		[HttpGet]
		[Route("api/v1/App/Find")]
		[ResponseType(typeof(IApiResponse<List<IApp>>))]
		public async Task<HttpResponseMessage> Find(AppFindModel model)
		{
			var result = new ApiResponse<List<IApp>>();
			result.Payload = await this._livingSpecContext.AppFindAsync(appGuid : model?.AppGuid,
				appDomainGuid : model?.AppDomainGuid,
				name : model?.Name,
				description : model?.Description,
				isThirdParty : model?.IsThirdParty
				).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}

		[HttpGet]
		[Route("api/v1/App/Search")]
		[ResponseType(typeof(IApiResponse<List<IApp>>))]
		public async Task<HttpResponseMessage> Search(AppSearchModel model)
		{
			var result = new ApiResponse<List<IApp>>();
			result.Payload = await this._livingSpecContext.AppSearchAsync(
			nameStartsWith : model?.NameStartsWith,
				nameContains : model?.NameContains,
				descriptionStartsWith : model?.DescriptionStartsWith,
				descriptionContains : model?.DescriptionContains
				).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}


		[HttpDelete]
		[Route("api/v1/App")]
		[ResponseType(typeof(IApiResponse<object>))]
		public async Task<HttpResponseMessage> Delete(Guid appGuid)
		{
			var result = new ApiResponse<object>();
			await this._livingSpecContext.AppDeleteAsync(appGuid).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}
	}
}
