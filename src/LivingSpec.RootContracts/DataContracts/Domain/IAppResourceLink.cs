namespace LivingSpec.RootContracts.DataContracts.Domain
{
	using System;

	public interface IAppResourceLink
	{
		Guid AppResourceLinkGuid { get; set; }
		Guid AppGuid { get; set; }
		string LinkUrl { get; set; }
	}
}


	
