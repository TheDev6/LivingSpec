
namespace LivingSpec.DataAccess.DataObjects
{ 
	using System;
	using RootContracts.DataContracts.Domain;

	public partial class App : IApp
	{
		public Guid AppGuid {get;set;}
		public Guid AppDomainGuid {get;set;}
		public string Name {get;set;}
		public string Description {get;set;}
		public bool IsThirdParty {get;set;}
	}
}
