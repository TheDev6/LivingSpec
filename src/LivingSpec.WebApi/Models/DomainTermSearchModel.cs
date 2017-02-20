
namespace LivingSpec.WebApi.Models
{
    using System;
    using System.Collections.Generic;

	public partial class DomainTermSearchModel
	{
		public string NameStartsWith {get;set;}
				public string NameContains {get;set;}
				public string DefinitionStartsWith {get;set;}
				public string DefinitionContains {get;set;}
				
	}
}



