namespace LivingSpec.RootContracts.DataContracts.Domain
{
	using System;

	public interface IDomainTerm
	{
		Guid DomainTermGuid { get; set; }
		Guid AppDomainGuid { get; set; }
		string Name { get; set; }
		string Definition { get; set; }
	}
}


	
