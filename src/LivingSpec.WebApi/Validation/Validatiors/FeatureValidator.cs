namespace LivingSpec.WebApi.Validation.Validatiors
{
    using FluentValidation;
    using RootContracts.DataContracts.Domain;

	public partial class FeatureValidator : AbstractValidator<IFeature>
	{
		public FeatureValidator()
		{
			RuleFor(obj=>obj.FeatureGuid).NotEmpty();
			RuleFor(obj=>obj.Name).NotEmpty().Length(min:1,max:200);
			RuleFor(obj=>obj.GherkinText).NotEmpty().Length(min:1,max:-1);
		}
	}		
}
