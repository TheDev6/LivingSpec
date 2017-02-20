namespace LivingSpec.RootContracts.BehaviorContracts.Validation
{
    using System.Web.Http.ModelBinding;
    using DataContracts.Validation;

    public interface IModelStateErrorParser
    {
        IValidationResult GetErrorsFromModelState(ModelStateDictionary modelState);
    }
}