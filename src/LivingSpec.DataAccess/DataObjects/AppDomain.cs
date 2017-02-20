
namespace LivingSpec.DataAccess.DataObjects
{ 
	using System;
	using RootContracts.DataContracts.Domain;

	public partial class AppDomain : IAppDomain
	{
		public Guid AppDomainGuid {get;set;}
		public string Name {get;set;}
		public string Description {get;set;}
	}
}
