namespace LivingSpec.WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using RootContracts.DataContracts.Domain;
    using RootContracts.DataContracts.Validation;
    using Validation;

	public partial class AppFeatureCreateModel : IAppFeature
	{	
		public Guid AppFeatureGuid { get; set; }
		public Guid AppGuid { get; set; }
		public Guid FeatureGuid { get; set; }
		
	}
}
