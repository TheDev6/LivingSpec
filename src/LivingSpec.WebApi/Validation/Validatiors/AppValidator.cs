namespace LivingSpec.WebApi.Validation.Validatiors
{
    using FluentValidation;
    using RootContracts.DataContracts.Domain;

	public partial class AppValidator : AbstractValidator<IApp>
	{
		public AppValidator()
		{
			RuleFor(obj=>obj.AppGuid).NotEmpty();
			RuleFor(obj=>obj.AppDomainGuid).NotEmpty();
			RuleFor(obj=>obj.Name).NotEmpty().Length(min:1,max:50);
			RuleFor(obj=>obj.Description).NotEmpty().Length(min:1,max:200);
			RuleFor(obj=>obj.IsThirdParty).NotEmpty();
		}
	}		
}
