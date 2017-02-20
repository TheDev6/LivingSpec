namespace LivingSpec.WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using RootContracts.DataContracts.Domain;
    using RootContracts.DataContracts.Validation;
    using Validation;

	public partial class AppTestUpdateModel : IAppTest
	{
		public Guid AppTestGuid { get; set; }
		public Guid AppGuid { get; set; }
		public DateTime Date { get; set; }
		public string TargetEnvironment { get; set; }
		public string TypeKey { get; set; }
		public string JsonValue { get; set; }
		}
}
