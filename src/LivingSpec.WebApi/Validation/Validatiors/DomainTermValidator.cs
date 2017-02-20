namespace LivingSpec.WebApi.Validation.Validatiors
{
    using FluentValidation;
    using RootContracts.DataContracts.Domain;

	public partial class DomainTermValidator : AbstractValidator<IDomainTerm>
	{
		public DomainTermValidator()
		{
			RuleFor(obj=>obj.DomainTermGuid).NotEmpty();
			RuleFor(obj=>obj.AppDomainGuid).NotEmpty();
			RuleFor(obj=>obj.Name).NotEmpty().Length(min:1,max:50);
			RuleFor(obj=>obj.Definition).NotEmpty().Length(min:1,max:200);
		}
	}		
}

