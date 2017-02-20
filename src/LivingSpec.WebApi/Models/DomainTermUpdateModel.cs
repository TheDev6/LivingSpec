namespace LivingSpec.WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using RootContracts.DataContracts.Domain;
    using RootContracts.DataContracts.Validation;
    using Validation;

	public partial class DomainTermUpdateModel : IDomainTerm
	{
		public Guid DomainTermGuid { get; set; }
		public Guid AppDomainGuid { get; set; }
		public string Name { get; set; }
		public string Definition { get; set; }
		}
}
