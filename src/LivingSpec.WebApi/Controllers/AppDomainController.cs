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

	public partial class AppDomainController : ApiController
	{
		private readonly ILivingSpecContext _livingSpecContext;

		public AppDomainController(ILivingSpecContext livingSpecContext)
		{
			this._livingSpecContext = livingSpecContext;
		}

		[HttpPost]
		[Route("api/v1/AppDomain")]
		[ValidateModelState]
		[ResponseType(typeof(IApiResponse<object>))]
		public async Task<HttpResponseMessage> Post(AppDomainCreateModel model)
		{
			var result = new ApiResponse<object>();
			await this._livingSpecContext.AppDomainInsertAsync(model).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.Created, value: result);
		}

		[HttpPut]
        [Route("api/v1/AppDomain")]
        [ResponseType(typeof(IApiResponse<object>))]
        [ValidateModelState]
        public async Task<HttpResponseMessage> Update(AppDomainUpdateModel model)
        {
            var result = new ApiResponse<object>();
            await this._livingSpecContext.AppDomainUpdateAsync(model).ConfigureAwait(false);
            return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
        }

		[HttpGet]
		[Route("api/v1/AppDomain/Select")]
		[ResponseType(typeof(IApiResponse<IAppDomain>))]
		public async Task<HttpResponseMessage> Select(Guid appDomainGuid)
		{
			var result = new ApiResponse<IAppDomain>();
			result.Payload = await this._livingSpecContext.AppDomainSelectAsync(appDomainGuid).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}

		[HttpGet]
		[Route("api/v1/AppDomain/Find")]
		[ResponseType(typeof(IApiResponse<List<IAppDomain>>))]
		public async Task<HttpResponseMessage> Find(AppDomainFindModel model)
		{
			var result = new ApiResponse<List<IAppDomain>>();
			result.Payload = await this._livingSpecContext.AppDomainFindAsync(appDomainGuid : model?.AppDomainGuid,
				name : model?.Name,
				description : model?.Description
				).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}

		[HttpGet]
		[Route("api/v1/AppDomain/Search")]
		[ResponseType(typeof(IApiResponse<List<IAppDomain>>))]
		public async Task<HttpResponseMessage> Search(AppDomainSearchModel model)
		{
			var result = new ApiResponse<List<IAppDomain>>();
			result.Payload = await this._livingSpecContext.AppDomainSearchAsync(
			nameStartsWith : model?.NameStartsWith,
				nameContains : model?.NameContains,
				descriptionStartsWith : model?.DescriptionStartsWith,
				descriptionContains : model?.DescriptionContains
				).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}


		[HttpDelete]
		[Route("api/v1/AppDomain")]
		[ResponseType(typeof(IApiResponse<object>))]
		public async Task<HttpResponseMessage> Delete(Guid appDomainGuid)
		{
			var result = new ApiResponse<object>();
			await this._livingSpecContext.AppDomainDeleteAsync(appDomainGuid).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}
	}
}
