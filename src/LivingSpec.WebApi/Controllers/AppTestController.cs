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

	public partial class AppTestController : ApiController
	{
		private readonly ILivingSpecContext _livingSpecContext;

		public AppTestController(ILivingSpecContext livingSpecContext)
		{
			this._livingSpecContext = livingSpecContext;
		}

		[HttpPost]
		[Route("api/v1/AppTest")]
		[ValidateModelState]
		[ResponseType(typeof(IApiResponse<object>))]
		public async Task<HttpResponseMessage> Post(AppTestCreateModel model)
		{
			var result = new ApiResponse<object>();
			await this._livingSpecContext.AppTestInsertAsync(model).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.Created, value: result);
		}

		[HttpPut]
        [Route("api/v1/AppTest")]
        [ResponseType(typeof(IApiResponse<object>))]
        [ValidateModelState]
        public async Task<HttpResponseMessage> Update(AppTestUpdateModel model)
        {
            var result = new ApiResponse<object>();
            await this._livingSpecContext.AppTestUpdateAsync(model).ConfigureAwait(false);
            return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
        }

		[HttpGet]
		[Route("api/v1/AppTest/Select")]
		[ResponseType(typeof(IApiResponse<IAppTest>))]
		public async Task<HttpResponseMessage> Select(Guid appTestGuid)
		{
			var result = new ApiResponse<IAppTest>();
			result.Payload = await this._livingSpecContext.AppTestSelectAsync(appTestGuid).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}

		[HttpGet]
		[Route("api/v1/AppTest/Find")]
		[ResponseType(typeof(IApiResponse<List<IAppTest>>))]
		public async Task<HttpResponseMessage> Find(AppTestFindModel model)
		{
			var result = new ApiResponse<List<IAppTest>>();
			result.Payload = await this._livingSpecContext.AppTestFindAsync(appTestGuid : model?.AppTestGuid,
				appGuid : model?.AppGuid,
				date : model?.Date,
				targetEnvironment : model?.TargetEnvironment,
				typeKey : model?.TypeKey,
				jsonValue : model?.JsonValue
				).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}

		[HttpGet]
		[Route("api/v1/AppTest/Search")]
		[ResponseType(typeof(IApiResponse<List<IAppTest>>))]
		public async Task<HttpResponseMessage> Search(AppTestSearchModel model)
		{
			var result = new ApiResponse<List<IAppTest>>();
			result.Payload = await this._livingSpecContext.AppTestSearchAsync(
			dateAfter : model?.DateAfter,
				dateBefore : model?.DateBefore,
				targetEnvironmentStartsWith : model?.TargetEnvironmentStartsWith,
				targetEnvironmentContains : model?.TargetEnvironmentContains,
				typeKeyStartsWith : model?.TypeKeyStartsWith,
				typeKeyContains : model?.TypeKeyContains,
				jsonValueStartsWith : model?.JsonValueStartsWith,
				jsonValueContains : model?.JsonValueContains
				).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}


		[HttpDelete]
		[Route("api/v1/AppTest")]
		[ResponseType(typeof(IApiResponse<object>))]
		public async Task<HttpResponseMessage> Delete(Guid appTestGuid)
		{
			var result = new ApiResponse<object>();
			await this._livingSpecContext.AppTestDeleteAsync(appTestGuid).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}
	}
}
