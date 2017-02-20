namespace LivingSpec.WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using RootContracts.DataContracts.Domain;
    using RootContracts.DataContracts.Validation;
    using Validation;

	public partial class AppDomainUpdateModel : IAppDomain
	{
		public Guid AppDomainGuid { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		}
}
