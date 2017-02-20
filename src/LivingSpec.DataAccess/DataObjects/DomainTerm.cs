
namespace LivingSpec.DataAccess.DataObjects
{ 
	using System;
	using RootContracts.DataContracts.Domain;

	public partial class DomainTerm : IDomainTerm
	{
		public Guid DomainTermGuid {get;set;}
		public Guid AppDomainGuid {get;set;}
		public string Name {get;set;}
		public string Definition {get;set;}
	}
}


