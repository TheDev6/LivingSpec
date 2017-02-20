
namespace LivingSpec.DataAccess.DataObjects
{ 
	using System;
	using RootContracts.DataContracts.Domain;

	public partial class AppTest : IAppTest
	{
		public Guid AppTestGuid {get;set;}
		public Guid AppGuid {get;set;}
		public DateTime Date {get;set;}
		public string TargetEnvironment {get;set;}
		public string TypeKey {get;set;}
		public string JsonValue {get;set;}
	}
}
