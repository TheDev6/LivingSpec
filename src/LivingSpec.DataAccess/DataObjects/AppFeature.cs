
namespace LivingSpec.DataAccess.DataObjects
{ 
	using System;
	using RootContracts.DataContracts.Domain;

	public partial class AppFeature : IAppFeature
	{
		public Guid AppFeatureGuid {get;set;}
		public Guid AppGuid {get;set;}
		public Guid FeatureGuid {get;set;}
	}
}
