namespace LivingSpec.WebApi.Validation.Validatiors
{
    using FluentValidation;
    using RootContracts.DataContracts.Domain;

    public partial class AppDependencyValidator : AbstractValidator<IAppDependency>
    {
        public AppDependencyValidator()
        {
            RuleFor(obj => obj.AppDependencyGuid).NotEmpty();
            RuleFor(obj => obj.AppGuid).NotEmpty();
            RuleFor(obj => obj.DependsOnAppGuid).NotEmpty();
        }
    }
}
