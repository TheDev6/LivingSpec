namespace LivingSpec.RootContracts.DataContracts.Domain
{
	using System;

	public interface IAppDomain
	{
		Guid AppDomainGuid { get; set; }
		string Name { get; set; }
		string Description { get; set; }
	}
}


	
