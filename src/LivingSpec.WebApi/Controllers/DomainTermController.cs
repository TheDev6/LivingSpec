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

	public partial class DomainTermController : ApiController
	{
		private readonly ILivingSpecContext _livingSpecContext;

		public DomainTermController(ILivingSpecContext livingSpecContext)
		{
			this._livingSpecContext = livingSpecContext;
		}

		[HttpPost]
		[Route("api/v1/DomainTerm")]
		[ValidateModelState]
		[ResponseType(typeof(IApiResponse<object>))]
		public async Task<HttpResponseMessage> Post(DomainTermCreateModel model)
		{
			var result = new ApiResponse<object>();
			await this._livingSpecContext.DomainTermInsertAsync(model).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.Created, value: result);
		}

		[HttpPut]
        [Route("api/v1/ArtifactWorkItem")]
        [ResponseType(typeof(IApiResponse<object>))]
        [ValidateModelState]
        public async Task<HttpResponseMessage> Update(DomainTermUpdateModel model)
        {
            var result = new ApiResponse<object>();
            await this._livingSpecContext.DomainTermUpdateAsync(model).ConfigureAwait(false);
            return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
        }

		[HttpGet]
		[Route("api/v1/DomainTerm/Select")]
		[ResponseType(typeof(IApiResponse<IDomainTerm>))]
		public async Task<HttpResponseMessage> Select(Guid domainTermGuid)
		{
			var result = new ApiResponse<IDomainTerm>();
			result.Payload = await this._livingSpecContext.DomainTermSelectAsync(domainTermGuid).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}

		[HttpGet]
		[Route("api/v1/DomainTerm/Find")]
		[ResponseType(typeof(IApiResponse<List<IDomainTerm>>))]
		public async Task<HttpResponseMessage> Find(DomainTermFindModel model)
		{
			var result = new ApiResponse<List<IDomainTerm>>();
			result.Payload = await this._livingSpecContext.DomainTermFindAsync(domainTermGuid : model?.DomainTermGuid,
				appDomainGuid : model?.AppDomainGuid,
				name : model?.Name,
				definition : model?.Definition
				).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}

		[HttpGet]
		[Route("api/v1/DomainTerm/Search")]
		[ResponseType(typeof(IApiResponse<List<IDomainTerm>>))]
		public async Task<HttpResponseMessage> Search(DomainTermSearchModel model)
		{
			var result = new ApiResponse<List<IDomainTerm>>();
			result.Payload = await this._livingSpecContext.DomainTermSearchAsync(
			nameStartsWith : model?.NameStartsWith,
				nameContains : model?.NameContains,
				definitionStartsWith : model?.DefinitionStartsWith,
				definitionContains : model?.DefinitionContains
				).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}


		[HttpDelete]
		[Route("api/v1/DomainTerm")]
		[ResponseType(typeof(IApiResponse<object>))]
		public async Task<HttpResponseMessage> Delete(Guid domainTermGuid)
		{
			var result = new ApiResponse<object>();
			await this._livingSpecContext.DomainTermDeleteAsync(domainTermGuid).ConfigureAwait(false);
			return Request.CreateResponse(statusCode: HttpStatusCode.OK, value: result);
		}
	}
}
