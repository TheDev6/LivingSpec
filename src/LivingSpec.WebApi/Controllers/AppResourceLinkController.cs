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

	public partial class AppResourceLinkController : ApiController
	{
		private readonly ILivingSpecContext _livingSpecContext;

		public AppResourceLinkController(ILivingSpecContext livingSpecContext)
		{
			this._livingSpecContext = livingSpecContext;
		}

		[HttpPost]
		[Route("api/v1/AppResourceLink")]
		[ValidateModelState]
		[ResponseType(typeof(IApiResponse<object>))]
		public async Task<HttpResponseMessage> Post(AppResourceLinkCreateModel model)
		{
			var result = new ApiResponse<object>();
			await this._livingSpecContext.AppResourceLinkInsertAsync(model).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.Created, value: result);
		}

		[HttpPut]
        [Route("api/v1/AppResourceLink")]
        [ResponseType(typeof(IApiResponse<object>))]
        [ValidateModelState]
        public async Task<HttpResponseMessage> Update(AppResourceLinkUpdateModel model)
        {
            var result = new ApiResponse<object>();
            await this._livingSpecContext.AppResourceLinkUpdateAsync(model).ConfigureAwait(false);
            return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
        }

		[HttpGet]
		[Route("api/v1/AppResourceLink/Select")]
		[ResponseType(typeof(IApiResponse<IAppResourceLink>))]
		public async Task<HttpResponseMessage> Select(Guid appResourceLinkGuid)
		{
			var result = new ApiResponse<IAppResourceLink>();
			result.Payload = await this._livingSpecContext.AppResourceLinkSelectAsync(appResourceLinkGuid).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}

		[HttpGet]
		[Route("api/v1/AppResourceLink/Find")]
		[ResponseType(typeof(IApiResponse<List<IAppResourceLink>>))]
		public async Task<HttpResponseMessage> Find(AppResourceLinkFindModel model)
		{
			var result = new ApiResponse<List<IAppResourceLink>>();
			result.Payload = await this._livingSpecContext.AppResourceLinkFindAsync(appResourceLinkGuid : model?.AppResourceLinkGuid,
				appGuid : model?.AppGuid,
				linkUrl : model?.LinkUrl
				).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}

		[HttpGet]
		[Route("api/v1/AppResourceLink/Search")]
		[ResponseType(typeof(IApiResponse<List<IAppResourceLink>>))]
		public async Task<HttpResponseMessage> Search(AppResourceLinkSearchModel model)
		{
			var result = new ApiResponse<List<IAppResourceLink>>();
			result.Payload = await this._livingSpecContext.AppResourceLinkSearchAsync(
			linkUrlStartsWith : model?.LinkUrlStartsWith,
				linkUrlContains : model?.LinkUrlContains
				).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}


		[HttpDelete]
		[Route("api/v1/AppResourceLink")]
		[ResponseType(typeof(IApiResponse<object>))]
		public async Task<HttpResponseMessage> Delete(Guid appResourceLinkGuid)
		{
			var result = new ApiResponse<object>();
			await this._livingSpecContext.AppResourceLinkDeleteAsync(appResourceLinkGuid).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}
	}
}
