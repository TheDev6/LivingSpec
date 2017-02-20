namespace LivingSpec.WebApi.Validation.Validatiors
{
    using FluentValidation;
    using RootContracts.DataContracts.Domain;

	public partial class AppFeatureValidator : AbstractValidator<IAppFeature>
	{
		public AppFeatureValidator()
		{
			RuleFor(obj=>obj.AppFeatureGuid).NotEmpty();
			RuleFor(obj=>obj.AppGuid).NotEmpty();
			RuleFor(obj=>obj.FeatureGuid).NotEmpty();
		}
	}		
}
