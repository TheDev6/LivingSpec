
namespace LivingSpec.DataAccess.DataObjects
{ 
	using System;
	using RootContracts.DataContracts.Domain;

	public partial class Feature : IFeature
	{
		public Guid FeatureGuid {get;set;}
		public string Name {get;set;}
		public string GherkinText {get;set;}
	}
}
