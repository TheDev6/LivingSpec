namespace LivingSpec.RootContracts.DataContracts.Domain
{
	using System;

	public interface IAppFeature
	{
		Guid AppFeatureGuid { get; set; }
		Guid AppGuid { get; set; }
		Guid FeatureGuid { get; set; }
	}
}


	
