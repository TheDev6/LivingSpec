namespace LivingSpec.WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using RootContracts.DataContracts.Domain;
    using RootContracts.DataContracts.Validation;
    using Validation;

	public partial class AppResourceLinkFindModel
	{
		public Guid? AppResourceLinkGuid { get; set; }
		public Guid? AppGuid { get; set; }
		public string LinkUrl { get; set; }
	}
}
