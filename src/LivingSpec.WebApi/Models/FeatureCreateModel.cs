namespace LivingSpec.WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using RootContracts.DataContracts.Domain;
    using RootContracts.DataContracts.Validation;
    using Validation;

	public partial class FeatureCreateModel : IFeature
	{	
		public Guid FeatureGuid { get; set; }
		public string Name { get; set; }
		public string GherkinText { get; set; }
		
	}
}
