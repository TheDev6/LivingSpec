namespace LivingSpec.WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using RootContracts.DataContracts.Domain;
    using RootContracts.DataContracts.Validation;
    using Validation;

	public partial class AppDependencyCreateModel : IAppDependency
	{	
		public Guid AppDependencyGuid { get; set; }
		public Guid AppGuid { get; set; }
		public Guid DependsOnAppGuid { get; set; }
		
	}
}
