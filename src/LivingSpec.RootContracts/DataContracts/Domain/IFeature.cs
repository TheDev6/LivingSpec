namespace LivingSpec.RootContracts.DataContracts.Domain
{
	using System;

	public interface IFeature
	{
		Guid FeatureGuid { get; set; }
		string Name { get; set; }
		string GherkinText { get; set; }
	}
}


	
