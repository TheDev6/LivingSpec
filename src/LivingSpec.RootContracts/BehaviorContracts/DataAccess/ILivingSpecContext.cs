
namespace  LivingSpec.RootContracts.BehaviorContracts.DataAccess
{
    using System;
    using System.Collections.Generic;
	using System.Threading.Tasks;
	using DataContracts.Domain;

	public partial interface ILivingSpecContext
	{
		
		#region App
		Task<IApp> AppSelectAsync(Guid appGuid);
		IApp AppSelect(Guid appGuid);
		Task AppInsertAsync(IApp app);
		void AppInsert(IApp app);
		Task AppUpdateAsync(IApp app);
		void AppUpdate(IApp app);
		Task AppDeleteAsync(Guid appGuid);
		void AppDelete(Guid appGuid);
		Task<List<IApp>> AppFindAsync(Guid? appGuid = null,Guid? appDomainGuid = null,string name = null,string description = null,bool? isThirdParty = null);
		List<IApp> AppFind(Guid? appGuid = null,Guid? appDomainGuid = null,string name = null,string description = null,bool? isThirdParty = null);
		Task<List<IApp>> AppSearchAsync(string nameStartsWith = null,string nameContains = null,string descriptionStartsWith = null,string descriptionContains = null);
		List<IApp> AppSearch(string nameStartsWith = null,string nameContains = null,string descriptionStartsWith = null,string descriptionContains = null);	
		#endregion

		
		#region AppDependency
		Task<IAppDependency> AppDependencySelectAsync(Guid appDependencyGuid);
		IAppDependency AppDependencySelect(Guid appDependencyGuid);
		Task AppDependencyInsertAsync(IAppDependency appDependency);
		void AppDependencyInsert(IAppDependency appDependency);
		Task AppDependencyUpdateAsync(IAppDependency appDependency);
		void AppDependencyUpdate(IAppDependency appDependency);
		Task AppDependencyDeleteAsync(Guid appDependencyGuid);
		void AppDependencyDelete(Guid appDependencyGuid);
		Task<List<IAppDependency>> AppDependencyFindAsync(Guid? appDependencyGuid = null,Guid? appGuid = null,Guid? dependsOnAppGuid = null);
		List<IAppDependency> AppDependencyFind(Guid? appDependencyGuid = null,Guid? appGuid = null,Guid? dependsOnAppGuid = null);
		Task<List<IAppDependency>> AppDependencySearchAsync();
		List<IAppDependency> AppDependencySearch();	
		#endregion

		
		#region AppDomain
		Task<IAppDomain> AppDomainSelectAsync(Guid appDomainGuid);
		IAppDomain AppDomainSelect(Guid appDomainGuid);
		Task AppDomainInsertAsync(IAppDomain appDomain);
		void AppDomainInsert(IAppDomain appDomain);
		Task AppDomainUpdateAsync(IAppDomain appDomain);
		void AppDomainUpdate(IAppDomain appDomain);
		Task AppDomainDeleteAsync(Guid appDomainGuid);
		void AppDomainDelete(Guid appDomainGuid);
		Task<List<IAppDomain>> AppDomainFindAsync(Guid? appDomainGuid = null,string name = null,string description = null);
		List<IAppDomain> AppDomainFind(Guid? appDomainGuid = null,string name = null,string description = null);
		Task<List<IAppDomain>> AppDomainSearchAsync(string nameStartsWith = null,string nameContains = null,string descriptionStartsWith = null,string descriptionContains = null);
		List<IAppDomain> AppDomainSearch(string nameStartsWith = null,string nameContains = null,string descriptionStartsWith = null,string descriptionContains = null);	
		#endregion

		
		#region AppFeature
		Task<IAppFeature> AppFeatureSelectAsync(Guid appFeatureGuid);
		IAppFeature AppFeatureSelect(Guid appFeatureGuid);
		Task AppFeatureInsertAsync(IAppFeature appFeature);
		void AppFeatureInsert(IAppFeature appFeature);
		Task AppFeatureUpdateAsync(IAppFeature appFeature);
		void AppFeatureUpdate(IAppFeature appFeature);
		Task AppFeatureDeleteAsync(Guid appFeatureGuid);
		void AppFeatureDelete(Guid appFeatureGuid);
		Task<List<IAppFeature>> AppFeatureFindAsync(Guid? appFeatureGuid = null,Guid? appGuid = null,Guid? featureGuid = null);
		List<IAppFeature> AppFeatureFind(Guid? appFeatureGuid = null,Guid? appGuid = null,Guid? featureGuid = null);
		Task<List<IAppFeature>> AppFeatureSearchAsync();
		List<IAppFeature> AppFeatureSearch();	
		#endregion

		
		#region AppResourceLink
		Task<IAppResourceLink> AppResourceLinkSelectAsync(Guid appResourceLinkGuid);
		IAppResourceLink AppResourceLinkSelect(Guid appResourceLinkGuid);
		Task AppResourceLinkInsertAsync(IAppResourceLink appResourceLink);
		void AppResourceLinkInsert(IAppResourceLink appResourceLink);
		Task AppResourceLinkUpdateAsync(IAppResourceLink appResourceLink);
		void AppResourceLinkUpdate(IAppResourceLink appResourceLink);
		Task AppResourceLinkDeleteAsync(Guid appResourceLinkGuid);
		void AppResourceLinkDelete(Guid appResourceLinkGuid);
		Task<List<IAppResourceLink>> AppResourceLinkFindAsync(Guid? appResourceLinkGuid = null,Guid? appGuid = null,string linkUrl = null);
		List<IAppResourceLink> AppResourceLinkFind(Guid? appResourceLinkGuid = null,Guid? appGuid = null,string linkUrl = null);
		Task<List<IAppResourceLink>> AppResourceLinkSearchAsync(string linkUrlStartsWith = null,string linkUrlContains = null);
		List<IAppResourceLink> AppResourceLinkSearch(string linkUrlStartsWith = null,string linkUrlContains = null);	
		#endregion

		
		#region AppTest
		Task<IAppTest> AppTestSelectAsync(Guid appTestGuid);
		IAppTest AppTestSelect(Guid appTestGuid);
		Task AppTestInsertAsync(IAppTest appTest);
		void AppTestInsert(IAppTest appTest);
		Task AppTestUpdateAsync(IAppTest appTest);
		void AppTestUpdate(IAppTest appTest);
		Task AppTestDeleteAsync(Guid appTestGuid);
		void AppTestDelete(Guid appTestGuid);
		Task<List<IAppTest>> AppTestFindAsync(Guid? appTestGuid = null,Guid? appGuid = null,DateTime? date = null,string targetEnvironment = null,string typeKey = null,string jsonValue = null);
		List<IAppTest> AppTestFind(Guid? appTestGuid = null,Guid? appGuid = null,DateTime? date = null,string targetEnvironment = null,string typeKey = null,string jsonValue = null);
		Task<List<IAppTest>> AppTestSearchAsync(DateTime? dateAfter = null,DateTime? dateBefore = null,string targetEnvironmentStartsWith = null,string targetEnvironmentContains = null,string typeKeyStartsWith = null,string typeKeyContains = null,string jsonValueStartsWith = null,string jsonValueContains = null);
		List<IAppTest> AppTestSearch(DateTime? dateAfter = null,DateTime? dateBefore = null,string targetEnvironmentStartsWith = null,string targetEnvironmentContains = null,string typeKeyStartsWith = null,string typeKeyContains = null,string jsonValueStartsWith = null,string jsonValueContains = null);	
		#endregion

		
		#region DomainTerm
		Task<IDomainTerm> DomainTermSelectAsync(Guid domainTermGuid);
		IDomainTerm DomainTermSelect(Guid domainTermGuid);
		Task DomainTermInsertAsync(IDomainTerm domainTerm);
		void DomainTermInsert(IDomainTerm domainTerm);
		Task DomainTermUpdateAsync(IDomainTerm domainTerm);
		void DomainTermUpdate(IDomainTerm domainTerm);
		Task DomainTermDeleteAsync(Guid domainTermGuid);
		void DomainTermDelete(Guid domainTermGuid);
		Task<List<IDomainTerm>> DomainTermFindAsync(Guid? domainTermGuid = null,Guid? appDomainGuid = null,string name = null,string definition = null);
		List<IDomainTerm> DomainTermFind(Guid? domainTermGuid = null,Guid? appDomainGuid = null,string name = null,string definition = null);
		Task<List<IDomainTerm>> DomainTermSearchAsync(string nameStartsWith = null,string nameContains = null,string definitionStartsWith = null,string definitionContains = null);
		List<IDomainTerm> DomainTermSearch(string nameStartsWith = null,string nameContains = null,string definitionStartsWith = null,string definitionContains = null);	
		#endregion

		
		#region Feature
		Task<IFeature> FeatureSelectAsync(Guid featureGuid);
		IFeature FeatureSelect(Guid featureGuid);
		Task FeatureInsertAsync(IFeature feature);
		void FeatureInsert(IFeature feature);
		Task FeatureUpdateAsync(IFeature feature);
		void FeatureUpdate(IFeature feature);
		Task FeatureDeleteAsync(Guid featureGuid);
		void FeatureDelete(Guid featureGuid);
		Task<List<IFeature>> FeatureFindAsync(Guid? featureGuid = null,string name = null,string gherkinText = null);
		List<IFeature> FeatureFind(Guid? featureGuid = null,string name = null,string gherkinText = null);
		Task<List<IFeature>> FeatureSearchAsync(string nameStartsWith = null,string nameContains = null,string gherkinTextStartsWith = null,string gherkinTextContains = null);
		List<IFeature> FeatureSearch(string nameStartsWith = null,string nameContains = null,string gherkinTextStartsWith = null,string gherkinTextContains = null);	
		#endregion


#region GeneratedNonBoilerPlateSprocs
#endregion
	}
}

