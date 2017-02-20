namespace LivingSpec.WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using RootContracts.DataContracts.Domain;
    using RootContracts.DataContracts.Validation;
    using Validation;

	public partial class AppCreateModel : IApp
	{	
		public Guid AppGuid { get; set; }
		public Guid AppDomainGuid { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public bool IsThirdParty { get; set; }
		
	}
}
