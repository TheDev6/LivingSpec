
namespace LivingSpec.DataAccess.DataObjects
{
	using System;
    using System.Collections.Generic;
    using System.Linq;
	using System.Threading.Tasks;
	using RootContracts.BehaviorContracts.DataAccess;
	using RootContracts.DataContracts.Domain;


	public partial class LivingSpecContext : ILivingSpecContext
	{

		private readonly IDapperWrapper _dbWrapper;
	
		public LivingSpecContext(IDapperWrapper dbWrapper)
		{
			_dbWrapper = dbWrapper;
		}
		
		#region App
		public IApp AppSelect(Guid appGuid)
		{
		   var input = new{AppGuid = appGuid};
		   return _dbWrapper.CallProcedure<App>(procedureName: "[dbo].[AppSelect]", inputParams: input).SingleOrDefault();
		}
		
		public async Task<IApp> AppSelectAsync(Guid appGuid)
		{
		   var input = new{AppGuid = appGuid};
		   var result = await _dbWrapper.CallProcedureAsync<App>(procedureName: "[dbo].[AppSelect]", inputParams: input).ConfigureAwait(false);
		   return result.SingleOrDefault();
		}
		
		public void AppInsert(IApp app)
		{
			var input = new {
				AppGuid = app.AppGuid,
				AppDomainGuid = app.AppDomainGuid,
				Name = app.Name,
				Description = app.Description,
				IsThirdParty = app.IsThirdParty
			};
		   _dbWrapper.ExecuteProcedure(procedureName: "[dbo].[AppInsert]", inputParams: input);
		}

		public async Task AppInsertAsync(IApp app)
		{
			var input = new {
				AppGuid = app.AppGuid,
				AppDomainGuid = app.AppDomainGuid,
				Name = app.Name,
				Description = app.Description,
				IsThirdParty = app.IsThirdParty
			};
		   await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[AppInsert]", inputParams: input).ConfigureAwait(false);
		}

		public void AppUpdate(IApp app)
		{
			var input = new {
				AppGuid = app.AppGuid,
				AppDomainGuid = app.AppDomainGuid,
				Name = app.Name,
				Description = app.Description,
				IsThirdParty = app.IsThirdParty
			};
			_dbWrapper.ExecuteProcedure(procedureName: "[dbo].[AppUpdate]", inputParams: input);
		}

		public async Task AppUpdateAsync(IApp app)
		{
			var input = new {
				AppGuid = app.AppGuid,
				AppDomainGuid = app.AppDomainGuid,
				Name = app.Name,
				Description = app.Description,
				IsThirdParty = app.IsThirdParty
			};
			await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[AppUpdate]", inputParams: input).ConfigureAwait(false);;
		}
					
		public void AppDelete(Guid appGuid)
		{
		   var input = new{AppGuid = appGuid};
		   _dbWrapper.ExecuteProcedure(procedureName: "[dbo].[AppDelete]", inputParams: input);
		}

		public async Task AppDeleteAsync(Guid appGuid)
		{
		   var input = new{AppGuid = appGuid};
		   await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[AppDelete]", inputParams: input).ConfigureAwait(false);
		}

		public List<IApp> AppFind(Guid? appGuid = null,Guid? appDomainGuid = null,string name = null,string description = null,bool? isThirdParty = null)
		{
			var input = new {
				AppGuid = appGuid,
				AppDomainGuid = appDomainGuid,
				Name = name,
				Description = description,
				IsThirdParty = isThirdParty
			};
			var result = _dbWrapper.CallProcedure<App>(procedureName: "[dbo].[AppFind]", inputParams: input).ToList();
			return new List<IApp>(result);
		}
		
		public async Task<List<IApp>> AppFindAsync(Guid? appGuid = null,Guid? appDomainGuid = null,string name = null,string description = null,bool? isThirdParty = null)
		{
			var input = new {
				AppGuid = appGuid,
				AppDomainGuid = appDomainGuid,
				Name = name,
				Description = description,
				IsThirdParty = isThirdParty
			};
			var result = await _dbWrapper.CallProcedureAsync<App>(procedureName: "[dbo].[AppFind]", inputParams: input).ConfigureAwait(false);
			return new List<IApp>(result);
		}

		public List<IApp> AppSearch(string nameStartsWith = null,string nameContains = null,string descriptionStartsWith = null,string descriptionContains = null)
		{
			var input = new {
				NameStartsWith = nameStartsWith,
				NameContains = nameContains,
				DescriptionStartsWith = descriptionStartsWith,
				DescriptionContains = descriptionContains
			};
			var result = _dbWrapper.CallProcedure<App>(procedureName: "[dbo].[AppSearch]", inputParams: input).ToList();
			return new List<IApp>(result);
		}

		public async Task<List<IApp>> AppSearchAsync(string nameStartsWith = null,string nameContains = null,string descriptionStartsWith = null,string descriptionContains = null)
		{
			var input = new {
				NameStartsWith = nameStartsWith,
				NameContains = nameContains,
				DescriptionStartsWith = descriptionStartsWith,
				DescriptionContains = descriptionContains
			};
			var result = await _dbWrapper.CallProcedureAsync<App>(procedureName: "[dbo].[AppSearch]", inputParams: input).ConfigureAwait(false);
			return new List<IApp>(result);
		} 
		#endregion

		
		#region AppDependency
		public IAppDependency AppDependencySelect(Guid appDependencyGuid)
		{
		   var input = new{AppDependencyGuid = appDependencyGuid};
		   return _dbWrapper.CallProcedure<AppDependency>(procedureName: "[dbo].[AppDependencySelect]", inputParams: input).SingleOrDefault();
		}
		
		public async Task<IAppDependency> AppDependencySelectAsync(Guid appDependencyGuid)
		{
		   var input = new{AppDependencyGuid = appDependencyGuid};
		   var result = await _dbWrapper.CallProcedureAsync<AppDependency>(procedureName: "[dbo].[AppDependencySelect]", inputParams: input).ConfigureAwait(false);
		   return result.SingleOrDefault();
		}
		
		public void AppDependencyInsert(IAppDependency appDependency)
		{
			var input = new {
				AppDependencyGuid = appDependency.AppDependencyGuid,
				AppGuid = appDependency.AppGuid,
				DependsOnAppGuid = appDependency.DependsOnAppGuid
			};
		   _dbWrapper.ExecuteProcedure(procedureName: "[dbo].[AppDependencyInsert]", inputParams: input);
		}

		public async Task AppDependencyInsertAsync(IAppDependency appDependency)
		{
			var input = new {
				AppDependencyGuid = appDependency.AppDependencyGuid,
				AppGuid = appDependency.AppGuid,
				DependsOnAppGuid = appDependency.DependsOnAppGuid
			};
		   await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[AppDependencyInsert]", inputParams: input).ConfigureAwait(false);
		}

		public void AppDependencyUpdate(IAppDependency appDependency)
		{
			var input = new {
				AppDependencyGuid = appDependency.AppDependencyGuid,
				AppGuid = appDependency.AppGuid,
				DependsOnAppGuid = appDependency.DependsOnAppGuid
			};
			_dbWrapper.ExecuteProcedure(procedureName: "[dbo].[AppDependencyUpdate]", inputParams: input);
		}

		public async Task AppDependencyUpdateAsync(IAppDependency appDependency)
		{
			var input = new {
				AppDependencyGuid = appDependency.AppDependencyGuid,
				AppGuid = appDependency.AppGuid,
				DependsOnAppGuid = appDependency.DependsOnAppGuid
			};
			await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[AppDependencyUpdate]", inputParams: input).ConfigureAwait(false);;
		}
					
		public void AppDependencyDelete(Guid appDependencyGuid)
		{
		   var input = new{AppDependencyGuid = appDependencyGuid};
		   _dbWrapper.ExecuteProcedure(procedureName: "[dbo].[AppDependencyDelete]", inputParams: input);
		}

		public async Task AppDependencyDeleteAsync(Guid appDependencyGuid)
		{
		   var input = new{AppDependencyGuid = appDependencyGuid};
		   await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[AppDependencyDelete]", inputParams: input).ConfigureAwait(false);
		}

		public List<IAppDependency> AppDependencyFind(Guid? appDependencyGuid = null,Guid? appGuid = null,Guid? dependsOnAppGuid = null)
		{
			var input = new {
				AppDependencyGuid = appDependencyGuid,
				AppGuid = appGuid,
				DependsOnAppGuid = dependsOnAppGuid
			};
			var result = _dbWrapper.CallProcedure<AppDependency>(procedureName: "[dbo].[AppDependencyFind]", inputParams: input).ToList();
			return new List<IAppDependency>(result);
		}
		
		public async Task<List<IAppDependency>> AppDependencyFindAsync(Guid? appDependencyGuid = null,Guid? appGuid = null,Guid? dependsOnAppGuid = null)
		{
			var input = new {
				AppDependencyGuid = appDependencyGuid,
				AppGuid = appGuid,
				DependsOnAppGuid = dependsOnAppGuid
			};
			var result = await _dbWrapper.CallProcedureAsync<AppDependency>(procedureName: "[dbo].[AppDependencyFind]", inputParams: input).ConfigureAwait(false);
			return new List<IAppDependency>(result);
		}

		public List<IAppDependency> AppDependencySearch()
		{
			var input = new {
			};
			var result = _dbWrapper.CallProcedure<AppDependency>(procedureName: "[dbo].[AppDependencySearch]", inputParams: input).ToList();
			return new List<IAppDependency>(result);
		}

		public async Task<List<IAppDependency>> AppDependencySearchAsync()
		{
			var input = new {
			};
			var result = await _dbWrapper.CallProcedureAsync<AppDependency>(procedureName: "[dbo].[AppDependencySearch]", inputParams: input).ConfigureAwait(false);
			return new List<IAppDependency>(result);
		} 
		#endregion

		
		#region AppDomain
		public IAppDomain AppDomainSelect(Guid appDomainGuid)
		{
		   var input = new{AppDomainGuid = appDomainGuid};
		   return _dbWrapper.CallProcedure<AppDomain>(procedureName: "[dbo].[AppDomainSelect]", inputParams: input).SingleOrDefault();
		}
		
		public async Task<IAppDomain> AppDomainSelectAsync(Guid appDomainGuid)
		{
		   var input = new{AppDomainGuid = appDomainGuid};
		   var result = await _dbWrapper.CallProcedureAsync<AppDomain>(procedureName: "[dbo].[AppDomainSelect]", inputParams: input).ConfigureAwait(false);
		   return result.SingleOrDefault();
		}
		
		public void AppDomainInsert(IAppDomain appDomain)
		{
			var input = new {
				AppDomainGuid = appDomain.AppDomainGuid,
				Name = appDomain.Name,
				Description = appDomain.Description
			};
		   _dbWrapper.ExecuteProcedure(procedureName: "[dbo].[AppDomainInsert]", inputParams: input);
		}

		public async Task AppDomainInsertAsync(IAppDomain appDomain)
		{
			var input = new {
				AppDomainGuid = appDomain.AppDomainGuid,
				Name = appDomain.Name,
				Description = appDomain.Description
			};
		   await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[AppDomainInsert]", inputParams: input).ConfigureAwait(false);
		}

		public void AppDomainUpdate(IAppDomain appDomain)
		{
			var input = new {
				AppDomainGuid = appDomain.AppDomainGuid,
				Name = appDomain.Name,
				Description = appDomain.Description
			};
			_dbWrapper.ExecuteProcedure(procedureName: "[dbo].[AppDomainUpdate]", inputParams: input);
		}

		public async Task AppDomainUpdateAsync(IAppDomain appDomain)
		{
			var input = new {
				AppDomainGuid = appDomain.AppDomainGuid,
				Name = appDomain.Name,
				Description = appDomain.Description
			};
			await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[AppDomainUpdate]", inputParams: input).ConfigureAwait(false);;
		}
					
		public void AppDomainDelete(Guid appDomainGuid)
		{
		   var input = new{AppDomainGuid = appDomainGuid};
		   _dbWrapper.ExecuteProcedure(procedureName: "[dbo].[AppDomainDelete]", inputParams: input);
		}

		public async Task AppDomainDeleteAsync(Guid appDomainGuid)
		{
		   var input = new{AppDomainGuid = appDomainGuid};
		   await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[AppDomainDelete]", inputParams: input).ConfigureAwait(false);
		}

		public List<IAppDomain> AppDomainFind(Guid? appDomainGuid = null,string name = null,string description = null)
		{
			var input = new {
				AppDomainGuid = appDomainGuid,
				Name = name,
				Description = description
			};
			var result = _dbWrapper.CallProcedure<AppDomain>(procedureName: "[dbo].[AppDomainFind]", inputParams: input).ToList();
			return new List<IAppDomain>(result);
		}
		
		public async Task<List<IAppDomain>> AppDomainFindAsync(Guid? appDomainGuid = null,string name = null,string description = null)
		{
			var input = new {
				AppDomainGuid = appDomainGuid,
				Name = name,
				Description = description
			};
			var result = await _dbWrapper.CallProcedureAsync<AppDomain>(procedureName: "[dbo].[AppDomainFind]", inputParams: input).ConfigureAwait(false);
			return new List<IAppDomain>(result);
		}

		public List<IAppDomain> AppDomainSearch(string nameStartsWith = null,string nameContains = null,string descriptionStartsWith = null,string descriptionContains = null)
		{
			var input = new {
				NameStartsWith = nameStartsWith,
				NameContains = nameContains,
				DescriptionStartsWith = descriptionStartsWith,
				DescriptionContains = descriptionContains
			};
			var result = _dbWrapper.CallProcedure<AppDomain>(procedureName: "[dbo].[AppDomainSearch]", inputParams: input).ToList();
			return new List<IAppDomain>(result);
		}

		public async Task<List<IAppDomain>> AppDomainSearchAsync(string nameStartsWith = null,string nameContains = null,string descriptionStartsWith = null,string descriptionContains = null)
		{
			var input = new {
				NameStartsWith = nameStartsWith,
				NameContains = nameContains,
				DescriptionStartsWith = descriptionStartsWith,
				DescriptionContains = descriptionContains
			};
			var result = await _dbWrapper.CallProcedureAsync<AppDomain>(procedureName: "[dbo].[AppDomainSearch]", inputParams: input).ConfigureAwait(false);
			return new List<IAppDomain>(result);
		} 
		#endregion

		
		#region AppFeature
		public IAppFeature AppFeatureSelect(Guid appFeatureGuid)
		{
		   var input = new{AppFeatureGuid = appFeatureGuid};
		   return _dbWrapper.CallProcedure<AppFeature>(procedureName: "[dbo].[AppFeatureSelect]", inputParams: input).SingleOrDefault();
		}
		
		public async Task<IAppFeature> AppFeatureSelectAsync(Guid appFeatureGuid)
		{
		   var input = new{AppFeatureGuid = appFeatureGuid};
		   var result = await _dbWrapper.CallProcedureAsync<AppFeature>(procedureName: "[dbo].[AppFeatureSelect]", inputParams: input).ConfigureAwait(false);
		   return result.SingleOrDefault();
		}
		
		public void AppFeatureInsert(IAppFeature appFeature)
		{
			var input = new {
				AppFeatureGuid = appFeature.AppFeatureGuid,
				AppGuid = appFeature.AppGuid,
				FeatureGuid = appFeature.FeatureGuid
			};
		   _dbWrapper.ExecuteProcedure(procedureName: "[dbo].[AppFeatureInsert]", inputParams: input);
		}

		public async Task AppFeatureInsertAsync(IAppFeature appFeature)
		{
			var input = new {
				AppFeatureGuid = appFeature.AppFeatureGuid,
				AppGuid = appFeature.AppGuid,
				FeatureGuid = appFeature.FeatureGuid
			};
		   await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[AppFeatureInsert]", inputParams: input).ConfigureAwait(false);
		}

		public void AppFeatureUpdate(IAppFeature appFeature)
		{
			var input = new {
				AppFeatureGuid = appFeature.AppFeatureGuid,
				AppGuid = appFeature.AppGuid,
				FeatureGuid = appFeature.FeatureGuid
			};
			_dbWrapper.ExecuteProcedure(procedureName: "[dbo].[AppFeatureUpdate]", inputParams: input);
		}

		public async Task AppFeatureUpdateAsync(IAppFeature appFeature)
		{
			var input = new {
				AppFeatureGuid = appFeature.AppFeatureGuid,
				AppGuid = appFeature.AppGuid,
				FeatureGuid = appFeature.FeatureGuid
			};
			await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[AppFeatureUpdate]", inputParams: input).ConfigureAwait(false);;
		}
					
		public void AppFeatureDelete(Guid appFeatureGuid)
		{
		   var input = new{AppFeatureGuid = appFeatureGuid};
		   _dbWrapper.ExecuteProcedure(procedureName: "[dbo].[AppFeatureDelete]", inputParams: input);
		}

		public async Task AppFeatureDeleteAsync(Guid appFeatureGuid)
		{
		   var input = new{AppFeatureGuid = appFeatureGuid};
		   await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[AppFeatureDelete]", inputParams: input).ConfigureAwait(false);
		}

		public List<IAppFeature> AppFeatureFind(Guid? appFeatureGuid = null,Guid? appGuid = null,Guid? featureGuid = null)
		{
			var input = new {
				AppFeatureGuid = appFeatureGuid,
				AppGuid = appGuid,
				FeatureGuid = featureGuid
			};
			var result = _dbWrapper.CallProcedure<AppFeature>(procedureName: "[dbo].[AppFeatureFind]", inputParams: input).ToList();
			return new List<IAppFeature>(result);
		}
		
		public async Task<List<IAppFeature>> AppFeatureFindAsync(Guid? appFeatureGuid = null,Guid? appGuid = null,Guid? featureGuid = null)
		{
			var input = new {
				AppFeatureGuid = appFeatureGuid,
				AppGuid = appGuid,
				FeatureGuid = featureGuid
			};
			var result = await _dbWrapper.CallProcedureAsync<AppFeature>(procedureName: "[dbo].[AppFeatureFind]", inputParams: input).ConfigureAwait(false);
			return new List<IAppFeature>(result);
		}

		public List<IAppFeature> AppFeatureSearch()
		{
			var input = new {
			};
			var result = _dbWrapper.CallProcedure<AppFeature>(procedureName: "[dbo].[AppFeatureSearch]", inputParams: input).ToList();
			return new List<IAppFeature>(result);
		}

		public async Task<List<IAppFeature>> AppFeatureSearchAsync()
		{
			var input = new {
			};
			var result = await _dbWrapper.CallProcedureAsync<AppFeature>(procedureName: "[dbo].[AppFeatureSearch]", inputParams: input).ConfigureAwait(false);
			return new List<IAppFeature>(result);
		} 
		#endregion

		
		#region AppResourceLink
		public IAppResourceLink AppResourceLinkSelect(Guid appResourceLinkGuid)
		{
		   var input = new{AppResourceLinkGuid = appResourceLinkGuid};
		   return _dbWrapper.CallProcedure<AppResourceLink>(procedureName: "[dbo].[AppResourceLinkSelect]", inputParams: input).SingleOrDefault();
		}
		
		public async Task<IAppResourceLink> AppResourceLinkSelectAsync(Guid appResourceLinkGuid)
		{
		   var input = new{AppResourceLinkGuid = appResourceLinkGuid};
		   var result = await _dbWrapper.CallProcedureAsync<AppResourceLink>(procedureName: "[dbo].[AppResourceLinkSelect]", inputParams: input).ConfigureAwait(false);
		   return result.SingleOrDefault();
		}
		
		public void AppResourceLinkInsert(IAppResourceLink appResourceLink)
		{
			var input = new {
				AppResourceLinkGuid = appResourceLink.AppResourceLinkGuid,
				AppGuid = appResourceLink.AppGuid,
				LinkUrl = appResourceLink.LinkUrl
			};
		   _dbWrapper.ExecuteProcedure(procedureName: "[dbo].[AppResourceLinkInsert]", inputParams: input);
		}

		public async Task AppResourceLinkInsertAsync(IAppResourceLink appResourceLink)
		{
			var input = new {
				AppResourceLinkGuid = appResourceLink.AppResourceLinkGuid,
				AppGuid = appResourceLink.AppGuid,
				LinkUrl = appResourceLink.LinkUrl
			};
		   await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[AppResourceLinkInsert]", inputParams: input).ConfigureAwait(false);
		}

		public void AppResourceLinkUpdate(IAppResourceLink appResourceLink)
		{
			var input = new {
				AppResourceLinkGuid = appResourceLink.AppResourceLinkGuid,
				AppGuid = appResourceLink.AppGuid,
				LinkUrl = appResourceLink.LinkUrl
			};
			_dbWrapper.ExecuteProcedure(procedureName: "[dbo].[AppResourceLinkUpdate]", inputParams: input);
		}

		public async Task AppResourceLinkUpdateAsync(IAppResourceLink appResourceLink)
		{
			var input = new {
				AppResourceLinkGuid = appResourceLink.AppResourceLinkGuid,
				AppGuid = appResourceLink.AppGuid,
				LinkUrl = appResourceLink.LinkUrl
			};
			await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[AppResourceLinkUpdate]", inputParams: input).ConfigureAwait(false);;
		}
					
		public void AppResourceLinkDelete(Guid appResourceLinkGuid)
		{
		   var input = new{AppResourceLinkGuid = appResourceLinkGuid};
		   _dbWrapper.ExecuteProcedure(procedureName: "[dbo].[AppResourceLinkDelete]", inputParams: input);
		}

		public async Task AppResourceLinkDeleteAsync(Guid appResourceLinkGuid)
		{
		   var input = new{AppResourceLinkGuid = appResourceLinkGuid};
		   await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[AppResourceLinkDelete]", inputParams: input).ConfigureAwait(false);
		}

		public List<IAppResourceLink> AppResourceLinkFind(Guid? appResourceLinkGuid = null,Guid? appGuid = null,string linkUrl = null)
		{
			var input = new {
				AppResourceLinkGuid = appResourceLinkGuid,
				AppGuid = appGuid,
				LinkUrl = linkUrl
			};
			var result = _dbWrapper.CallProcedure<AppResourceLink>(procedureName: "[dbo].[AppResourceLinkFind]", inputParams: input).ToList();
			return new List<IAppResourceLink>(result);
		}
		
		public async Task<List<IAppResourceLink>> AppResourceLinkFindAsync(Guid? appResourceLinkGuid = null,Guid? appGuid = null,string linkUrl = null)
		{
			var input = new {
				AppResourceLinkGuid = appResourceLinkGuid,
				AppGuid = appGuid,
				LinkUrl = linkUrl
			};
			var result = await _dbWrapper.CallProcedureAsync<AppResourceLink>(procedureName: "[dbo].[AppResourceLinkFind]", inputParams: input).ConfigureAwait(false);
			return new List<IAppResourceLink>(result);
		}

		public List<IAppResourceLink> AppResourceLinkSearch(string linkUrlStartsWith = null,string linkUrlContains = null)
		{
			var input = new {
				LinkUrlStartsWith = linkUrlStartsWith,
				LinkUrlContains = linkUrlContains
			};
			var result = _dbWrapper.CallProcedure<AppResourceLink>(procedureName: "[dbo].[AppResourceLinkSearch]", inputParams: input).ToList();
			return new List<IAppResourceLink>(result);
		}

		public async Task<List<IAppResourceLink>> AppResourceLinkSearchAsync(string linkUrlStartsWith = null,string linkUrlContains = null)
		{
			var input = new {
				LinkUrlStartsWith = linkUrlStartsWith,
				LinkUrlContains = linkUrlContains
			};
			var result = await _dbWrapper.CallProcedureAsync<AppResourceLink>(procedureName: "[dbo].[AppResourceLinkSearch]", inputParams: input).ConfigureAwait(false);
			return new List<IAppResourceLink>(result);
		} 
		#endregion

		
		#region AppTest
		public IAppTest AppTestSelect(Guid appTestGuid)
		{
		   var input = new{AppTestGuid = appTestGuid};
		   return _dbWrapper.CallProcedure<AppTest>(procedureName: "[dbo].[AppTestSelect]", inputParams: input).SingleOrDefault();
		}
		
		public async Task<IAppTest> AppTestSelectAsync(Guid appTestGuid)
		{
		   var input = new{AppTestGuid = appTestGuid};
		   var result = await _dbWrapper.CallProcedureAsync<AppTest>(procedureName: "[dbo].[AppTestSelect]", inputParams: input).ConfigureAwait(false);
		   return result.SingleOrDefault();
		}
		
		public void AppTestInsert(IAppTest appTest)
		{
			var input = new {
				AppTestGuid = appTest.AppTestGuid,
				AppGuid = appTest.AppGuid,
				Date = appTest.Date,
				TargetEnvironment = appTest.TargetEnvironment,
				TypeKey = appTest.TypeKey,
				JsonValue = appTest.JsonValue
			};
		   _dbWrapper.ExecuteProcedure(procedureName: "[dbo].[AppTestInsert]", inputParams: input);
		}

		public async Task AppTestInsertAsync(IAppTest appTest)
		{
			var input = new {
				AppTestGuid = appTest.AppTestGuid,
				AppGuid = appTest.AppGuid,
				Date = appTest.Date,
				TargetEnvironment = appTest.TargetEnvironment,
				TypeKey = appTest.TypeKey,
				JsonValue = appTest.JsonValue
			};
		   await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[AppTestInsert]", inputParams: input).ConfigureAwait(false);
		}

		public void AppTestUpdate(IAppTest appTest)
		{
			var input = new {
				AppTestGuid = appTest.AppTestGuid,
				AppGuid = appTest.AppGuid,
				Date = appTest.Date,
				TargetEnvironment = appTest.TargetEnvironment,
				TypeKey = appTest.TypeKey,
				JsonValue = appTest.JsonValue
			};
			_dbWrapper.ExecuteProcedure(procedureName: "[dbo].[AppTestUpdate]", inputParams: input);
		}

		public async Task AppTestUpdateAsync(IAppTest appTest)
		{
			var input = new {
				AppTestGuid = appTest.AppTestGuid,
				AppGuid = appTest.AppGuid,
				Date = appTest.Date,
				TargetEnvironment = appTest.TargetEnvironment,
				TypeKey = appTest.TypeKey,
				JsonValue = appTest.JsonValue
			};
			await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[AppTestUpdate]", inputParams: input).ConfigureAwait(false);;
		}
					
		public void AppTestDelete(Guid appTestGuid)
		{
		   var input = new{AppTestGuid = appTestGuid};
		   _dbWrapper.ExecuteProcedure(procedureName: "[dbo].[AppTestDelete]", inputParams: input);
		}

		public async Task AppTestDeleteAsync(Guid appTestGuid)
		{
		   var input = new{AppTestGuid = appTestGuid};
		   await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[AppTestDelete]", inputParams: input).ConfigureAwait(false);
		}

		public List<IAppTest> AppTestFind(Guid? appTestGuid = null,Guid? appGuid = null,DateTime? date = null,string targetEnvironment = null,string typeKey = null,string jsonValue = null)
		{
			var input = new {
				AppTestGuid = appTestGuid,
				AppGuid = appGuid,
				Date = date,
				TargetEnvironment = targetEnvironment,
				TypeKey = typeKey,
				JsonValue = jsonValue
			};
			var result = _dbWrapper.CallProcedure<AppTest>(procedureName: "[dbo].[AppTestFind]", inputParams: input).ToList();
			return new List<IAppTest>(result);
		}
		
		public async Task<List<IAppTest>> AppTestFindAsync(Guid? appTestGuid = null,Guid? appGuid = null,DateTime? date = null,string targetEnvironment = null,string typeKey = null,string jsonValue = null)
		{
			var input = new {
				AppTestGuid = appTestGuid,
				AppGuid = appGuid,
				Date = date,
				TargetEnvironment = targetEnvironment,
				TypeKey = typeKey,
				JsonValue = jsonValue
			};
			var result = await _dbWrapper.CallProcedureAsync<AppTest>(procedureName: "[dbo].[AppTestFind]", inputParams: input).ConfigureAwait(false);
			return new List<IAppTest>(result);
		}

		public List<IAppTest> AppTestSearch(DateTime? dateAfter = null,DateTime? dateBefore = null,string targetEnvironmentStartsWith = null,string targetEnvironmentContains = null,string typeKeyStartsWith = null,string typeKeyContains = null,string jsonValueStartsWith = null,string jsonValueContains = null)
		{
			var input = new {
				DateAfter = dateAfter,
				DateBefore = dateBefore,
				TargetEnvironmentStartsWith = targetEnvironmentStartsWith,
				TargetEnvironmentContains = targetEnvironmentContains,
				TypeKeyStartsWith = typeKeyStartsWith,
				TypeKeyContains = typeKeyContains,
				JsonValueStartsWith = jsonValueStartsWith,
				JsonValueContains = jsonValueContains
			};
			var result = _dbWrapper.CallProcedure<AppTest>(procedureName: "[dbo].[AppTestSearch]", inputParams: input).ToList();
			return new List<IAppTest>(result);
		}

		public async Task<List<IAppTest>> AppTestSearchAsync(DateTime? dateAfter = null,DateTime? dateBefore = null,string targetEnvironmentStartsWith = null,string targetEnvironmentContains = null,string typeKeyStartsWith = null,string typeKeyContains = null,string jsonValueStartsWith = null,string jsonValueContains = null)
		{
			var input = new {
				DateAfter = dateAfter,
				DateBefore = dateBefore,
				TargetEnvironmentStartsWith = targetEnvironmentStartsWith,
				TargetEnvironmentContains = targetEnvironmentContains,
				TypeKeyStartsWith = typeKeyStartsWith,
				TypeKeyContains = typeKeyContains,
				JsonValueStartsWith = jsonValueStartsWith,
				JsonValueContains = jsonValueContains
			};
			var result = await _dbWrapper.CallProcedureAsync<AppTest>(procedureName: "[dbo].[AppTestSearch]", inputParams: input).ConfigureAwait(false);
			return new List<IAppTest>(result);
		} 
		#endregion

		
		#region DomainTerm
		public IDomainTerm DomainTermSelect(Guid domainTermGuid)
		{
		   var input = new{DomainTermGuid = domainTermGuid};
		   return _dbWrapper.CallProcedure<DomainTerm>(procedureName: "[dbo].[DomainTermSelect]", inputParams: input).SingleOrDefault();
		}
		
		public async Task<IDomainTerm> DomainTermSelectAsync(Guid domainTermGuid)
		{
		   var input = new{DomainTermGuid = domainTermGuid};
		   var result = await _dbWrapper.CallProcedureAsync<DomainTerm>(procedureName: "[dbo].[DomainTermSelect]", inputParams: input).ConfigureAwait(false);
		   return result.SingleOrDefault();
		}
		
		public void DomainTermInsert(IDomainTerm domainTerm)
		{
			var input = new {
				DomainTermGuid = domainTerm.DomainTermGuid,
				AppDomainGuid = domainTerm.AppDomainGuid,
				Name = domainTerm.Name,
				Definition = domainTerm.Definition
			};
		   _dbWrapper.ExecuteProcedure(procedureName: "[dbo].[DomainTermInsert]", inputParams: input);
		}

		public async Task DomainTermInsertAsync(IDomainTerm domainTerm)
		{
			var input = new {
				DomainTermGuid = domainTerm.DomainTermGuid,
				AppDomainGuid = domainTerm.AppDomainGuid,
				Name = domainTerm.Name,
				Definition = domainTerm.Definition
			};
		   await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[DomainTermInsert]", inputParams: input).ConfigureAwait(false);
		}

		public void DomainTermUpdate(IDomainTerm domainTerm)
		{
			var input = new {
				DomainTermGuid = domainTerm.DomainTermGuid,
				AppDomainGuid = domainTerm.AppDomainGuid,
				Name = domainTerm.Name,
				Definition = domainTerm.Definition
			};
			_dbWrapper.ExecuteProcedure(procedureName: "[dbo].[DomainTermUpdate]", inputParams: input);
		}

		public async Task DomainTermUpdateAsync(IDomainTerm domainTerm)
		{
			var input = new {
				DomainTermGuid = domainTerm.DomainTermGuid,
				AppDomainGuid = domainTerm.AppDomainGuid,
				Name = domainTerm.Name,
				Definition = domainTerm.Definition
			};
			await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[DomainTermUpdate]", inputParams: input).ConfigureAwait(false);;
		}
					
		public void DomainTermDelete(Guid domainTermGuid)
		{
		   var input = new{DomainTermGuid = domainTermGuid};
		   _dbWrapper.ExecuteProcedure(procedureName: "[dbo].[DomainTermDelete]", inputParams: input);
		}

		public async Task DomainTermDeleteAsync(Guid domainTermGuid)
		{
		   var input = new{DomainTermGuid = domainTermGuid};
		   await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[DomainTermDelete]", inputParams: input).ConfigureAwait(false);
		}

		public List<IDomainTerm> DomainTermFind(Guid? domainTermGuid = null,Guid? appDomainGuid = null,string name = null,string definition = null)
		{
			var input = new {
				DomainTermGuid = domainTermGuid,
				AppDomainGuid = appDomainGuid,
				Name = name,
				Definition = definition
			};
			var result = _dbWrapper.CallProcedure<DomainTerm>(procedureName: "[dbo].[DomainTermFind]", inputParams: input).ToList();
			return new List<IDomainTerm>(result);
		}
		
		public async Task<List<IDomainTerm>> DomainTermFindAsync(Guid? domainTermGuid = null,Guid? appDomainGuid = null,string name = null,string definition = null)
		{
			var input = new {
				DomainTermGuid = domainTermGuid,
				AppDomainGuid = appDomainGuid,
				Name = name,
				Definition = definition
			};
			var result = await _dbWrapper.CallProcedureAsync<DomainTerm>(procedureName: "[dbo].[DomainTermFind]", inputParams: input).ConfigureAwait(false);
			return new List<IDomainTerm>(result);
		}

		public List<IDomainTerm> DomainTermSearch(string nameStartsWith = null,string nameContains = null,string definitionStartsWith = null,string definitionContains = null)
		{
			var input = new {
				NameStartsWith = nameStartsWith,
				NameContains = nameContains,
				DefinitionStartsWith = definitionStartsWith,
				DefinitionContains = definitionContains
			};
			var result = _dbWrapper.CallProcedure<DomainTerm>(procedureName: "[dbo].[DomainTermSearch]", inputParams: input).ToList();
			return new List<IDomainTerm>(result);
		}

		public async Task<List<IDomainTerm>> DomainTermSearchAsync(string nameStartsWith = null,string nameContains = null,string definitionStartsWith = null,string definitionContains = null)
		{
			var input = new {
				NameStartsWith = nameStartsWith,
				NameContains = nameContains,
				DefinitionStartsWith = definitionStartsWith,
				DefinitionContains = definitionContains
			};
			var result = await _dbWrapper.CallProcedureAsync<DomainTerm>(procedureName: "[dbo].[DomainTermSearch]", inputParams: input).ConfigureAwait(false);
			return new List<IDomainTerm>(result);
		} 
		#endregion

		
		#region Feature
		public IFeature FeatureSelect(Guid featureGuid)
		{
		   var input = new{FeatureGuid = featureGuid};
		   return _dbWrapper.CallProcedure<Feature>(procedureName: "[dbo].[FeatureSelect]", inputParams: input).SingleOrDefault();
		}
		
		public async Task<IFeature> FeatureSelectAsync(Guid featureGuid)
		{
		   var input = new{FeatureGuid = featureGuid};
		   var result = await _dbWrapper.CallProcedureAsync<Feature>(procedureName: "[dbo].[FeatureSelect]", inputParams: input).ConfigureAwait(false);
		   return result.SingleOrDefault();
		}
		
		public void FeatureInsert(IFeature feature)
		{
			var input = new {
				FeatureGuid = feature.FeatureGuid,
				Name = feature.Name,
				GherkinText = feature.GherkinText
			};
		   _dbWrapper.ExecuteProcedure(procedureName: "[dbo].[FeatureInsert]", inputParams: input);
		}

		public async Task FeatureInsertAsync(IFeature feature)
		{
			var input = new {
				FeatureGuid = feature.FeatureGuid,
				Name = feature.Name,
				GherkinText = feature.GherkinText
			};
		   await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[FeatureInsert]", inputParams: input).ConfigureAwait(false);
		}

		public void FeatureUpdate(IFeature feature)
		{
			var input = new {
				FeatureGuid = feature.FeatureGuid,
				Name = feature.Name,
				GherkinText = feature.GherkinText
			};
			_dbWrapper.ExecuteProcedure(procedureName: "[dbo].[FeatureUpdate]", inputParams: input);
		}

		public async Task FeatureUpdateAsync(IFeature feature)
		{
			var input = new {
				FeatureGuid = feature.FeatureGuid,
				Name = feature.Name,
				GherkinText = feature.GherkinText
			};
			await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[FeatureUpdate]", inputParams: input).ConfigureAwait(false);;
		}
					
		public void FeatureDelete(Guid featureGuid)
		{
		   var input = new{FeatureGuid = featureGuid};
		   _dbWrapper.ExecuteProcedure(procedureName: "[dbo].[FeatureDelete]", inputParams: input);
		}

		public async Task FeatureDeleteAsync(Guid featureGuid)
		{
		   var input = new{FeatureGuid = featureGuid};
		   await _dbWrapper.ExecuteProcedureAsync(procedureName: "[dbo].[FeatureDelete]", inputParams: input).ConfigureAwait(false);
		}

		public List<IFeature> FeatureFind(Guid? featureGuid = null,string name = null,string gherkinText = null)
		{
			var input = new {
				FeatureGuid = featureGuid,
				Name = name,
				GherkinText = gherkinText
			};
			var result = _dbWrapper.CallProcedure<Feature>(procedureName: "[dbo].[FeatureFind]", inputParams: input).ToList();
			return new List<IFeature>(result);
		}
		
		public async Task<List<IFeature>> FeatureFindAsync(Guid? featureGuid = null,string name = null,string gherkinText = null)
		{
			var input = new {
				FeatureGuid = featureGuid,
				Name = name,
				GherkinText = gherkinText
			};
			var result = await _dbWrapper.CallProcedureAsync<Feature>(procedureName: "[dbo].[FeatureFind]", inputParams: input).ConfigureAwait(false);
			return new List<IFeature>(result);
		}

		public List<IFeature> FeatureSearch(string nameStartsWith = null,string nameContains = null,string gherkinTextStartsWith = null,string gherkinTextContains = null)
		{
			var input = new {
				NameStartsWith = nameStartsWith,
				NameContains = nameContains,
				GherkinTextStartsWith = gherkinTextStartsWith,
				GherkinTextContains = gherkinTextContains
			};
			var result = _dbWrapper.CallProcedure<Feature>(procedureName: "[dbo].[FeatureSearch]", inputParams: input).ToList();
			return new List<IFeature>(result);
		}

		public async Task<List<IFeature>> FeatureSearchAsync(string nameStartsWith = null,string nameContains = null,string gherkinTextStartsWith = null,string gherkinTextContains = null)
		{
			var input = new {
				NameStartsWith = nameStartsWith,
				NameContains = nameContains,
				GherkinTextStartsWith = gherkinTextStartsWith,
				GherkinTextContains = gherkinTextContains
			};
			var result = await _dbWrapper.CallProcedureAsync<Feature>(procedureName: "[dbo].[FeatureSearch]", inputParams: input).ConfigureAwait(false);
			return new List<IFeature>(result);
		} 
		#endregion


		#region GeneratedNonBoilerPlateSprocs
				#endregion


			}
		}








