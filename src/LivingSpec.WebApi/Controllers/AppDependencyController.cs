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

	public partial class AppDependencyController : ApiController
	{
		private readonly ILivingSpecContext _livingSpecContext;

		public AppDependencyController(ILivingSpecContext livingSpecContext)
		{
			this._livingSpecContext = livingSpecContext;
		}

		[HttpPost]
		[Route("api/v1/AppDependency")]
		[ValidateModelState]
		[ResponseType(typeof(IApiResponse<object>))]
		public async Task<HttpResponseMessage> Post(AppDependencyCreateModel model)
		{
			var result = new ApiResponse<object>();
			await this._livingSpecContext.AppDependencyInsertAsync(model).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.Created, value: result);
		}

		[HttpPut]
        [Route("api/v1/AppDependency")]
        [ResponseType(typeof(IApiResponse<object>))]
        [ValidateModelState]
        public async Task<HttpResponseMessage> Update(AppDependencyUpdateModel model)
        {
            var result = new ApiResponse<object>();
            await this._livingSpecContext.AppDependencyUpdateAsync(model).ConfigureAwait(false);
            return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
        }

		[HttpGet]
		[Route("api/v1/AppDependency/Select")]
		[ResponseType(typeof(IApiResponse<IAppDependency>))]
		public async Task<HttpResponseMessage> Select(Guid appDependencyGuid)
		{
			var result = new ApiResponse<IAppDependency>();
			result.Payload = await this._livingSpecContext.AppDependencySelectAsync(appDependencyGuid).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}

		[HttpGet]
		[Route("api/v1/AppDependency/Find")]
		[ResponseType(typeof(IApiResponse<List<IAppDependency>>))]
		public async Task<HttpResponseMessage> Find(AppDependencyFindModel model)
		{
			var result = new ApiResponse<List<IAppDependency>>();
			result.Payload = await this._livingSpecContext.AppDependencyFindAsync(appDependencyGuid : model?.AppDependencyGuid,
				appGuid : model?.AppGuid,
				dependsOnAppGuid : model?.DependsOnAppGuid
				).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}

		[HttpDelete]
		[Route("api/v1/AppDependency")]
		[ResponseType(typeof(IApiResponse<object>))]
		public async Task<HttpResponseMessage> Delete(Guid appDependencyGuid)
		{
			var result = new ApiResponse<object>();
			await this._livingSpecContext.AppDependencyDeleteAsync(appDependencyGuid).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}
	}
}
