namespace LivingSpec.RootContracts.DataContracts.Domain
{
	using System;

	public interface IAppDependency
	{
		Guid AppDependencyGuid { get; set; }
		Guid AppGuid { get; set; }
		Guid DependsOnAppGuid { get; set; }
	}
}


	
