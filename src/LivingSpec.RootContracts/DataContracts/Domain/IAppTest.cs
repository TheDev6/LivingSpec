namespace LivingSpec.RootContracts.DataContracts.Domain
{
	using System;

	public interface IAppTest
	{
		Guid AppTestGuid { get; set; }
		Guid AppGuid { get; set; }
		DateTime Date { get; set; }
		string TargetEnvironment { get; set; }
		string TypeKey { get; set; }
		string JsonValue { get; set; }
	}
}


	
