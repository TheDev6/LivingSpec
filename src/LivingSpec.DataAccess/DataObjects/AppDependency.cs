
namespace LivingSpec.DataAccess.DataObjects
{ 
	using System;
	using RootContracts.DataContracts.Domain;

	public partial class AppDependency : IAppDependency
	{
		public Guid AppDependencyGuid {get;set;}
		public Guid AppGuid {get;set;}
		public Guid DependsOnAppGuid {get;set;}
	}
}
