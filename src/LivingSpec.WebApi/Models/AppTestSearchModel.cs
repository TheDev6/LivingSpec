
namespace LivingSpec.WebApi.Models
{
    using System;
    using System.Collections.Generic;

	public partial class AppTestSearchModel
	{
		public DateTime? DateAfter {get;set;}
				public DateTime? DateBefore {get;set;}
				public string TargetEnvironmentStartsWith {get;set;}
				public string TargetEnvironmentContains {get;set;}
				public string TypeKeyStartsWith {get;set;}
				public string TypeKeyContains {get;set;}
				public string JsonValueStartsWith {get;set;}
				public string JsonValueContains {get;set;}
				
	}
}


