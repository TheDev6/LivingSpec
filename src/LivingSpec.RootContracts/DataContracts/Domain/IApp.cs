namespace LivingSpec.RootContracts.DataContracts.Domain
{
	using System;

	public interface IApp
	{
		Guid AppGuid { get; set; }
		Guid AppDomainGuid { get; set; }
		string Name { get; set; }
		string Description { get; set; }
		bool IsThirdParty { get; set; }
	}
}


	
