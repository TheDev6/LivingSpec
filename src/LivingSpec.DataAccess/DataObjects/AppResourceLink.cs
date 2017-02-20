
namespace LivingSpec.DataAccess.DataObjects
{ 
	using System;
	using RootContracts.DataContracts.Domain;

	public partial class AppResourceLink : IAppResourceLink
	{
		public Guid AppResourceLinkGuid {get;set;}
		public Guid AppGuid {get;set;}
		public string LinkUrl {get;set;}
	}
}
