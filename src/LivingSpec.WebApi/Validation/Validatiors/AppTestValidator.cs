namespace LivingSpec.WebApi.Validation.Validatiors
{
    using FluentValidation;
    using RootContracts.DataContracts.Domain;

	public partial class AppTestValidator : AbstractValidator<IAppTest>
	{
		public AppTestValidator()
		{
			RuleFor(obj=>obj.AppTestGuid).NotEmpty();
			RuleFor(obj=>obj.AppGuid).NotEmpty();
			RuleFor(obj=>obj.Date).NotEmpty();
			RuleFor(obj=>obj.TargetEnvironment).NotEmpty().Length(min:1,max:50);
			RuleFor(obj=>obj.TypeKey).NotEmpty().Length(min:1,max:50);
			RuleFor(obj=>obj.JsonValue).NotEmpty().Length(min:1,max:4000);
		}
	}		
}
