
namespace LivingSpec.WebApi.Models
{
    using System;
    using System.Collections.Generic;

	public partial class FeatureSearchModel
	{
		public string NameStartsWith {get;set;}
				public string NameContains {get;set;}
				public string GherkinTextStartsWith {get;set;}
				public string GherkinTextContains {get;set;}
				
	}
}


