namespace LivingSpec.WebApi.Validation.Validatiors
{
    using FluentValidation;
    using RootContracts.DataContracts.Domain;

	public partial class AppDomainValidator : AbstractValidator<IAppDomain>
	{
		public AppDomainValidator()
		{
			RuleFor(obj=>obj.AppDomainGuid).NotEmpty();
			RuleFor(obj=>obj.Name).NotEmpty().Length(min:1,max:50);
			RuleFor(obj=>obj.Description).NotEmpty().Length(min:1,max:200);
		}
	}		
}
