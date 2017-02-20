namespace LivingSpec.WebApi.Validation.Validatiors
{
    using FluentValidation;
    using RootContracts.DataContracts.Domain;

	public partial class AppResourceLinkValidator : AbstractValidator<IAppResourceLink>
	{
		public AppResourceLinkValidator()
		{
			RuleFor(obj=>obj.AppResourceLinkGuid).NotEmpty();
			RuleFor(obj=>obj.AppGuid).NotEmpty();
			RuleFor(obj=>obj.LinkUrl).NotEmpty().Length(min:1,max:4000);
		}
	}		
}
