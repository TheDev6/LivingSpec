namespace LivingSpec.WebApi.Validation
{
    using System.Web.Http.ModelBinding;
    using RootContracts.BehaviorContracts.Validation;
    using RootContracts.DataContracts.Validation;

    public class ModelStateErrorParser : IModelStateErrorParser
    {
        //TODO lots of class name clashes here. Need a wrapper? Does this code help or hurt?
        //Extention perhaps?

        public IValidationResult GetErrorsFromModelState(ModelStateDictionary modelState)
        {
            var result = new ValidationResult();

            foreach (var state in modelState)
            {
                if (state.Value.Errors.Count > 0)
                {
                    foreach (var error in state.Value.Errors)
                    {
                        result.ValidationFailures.Add(new ValidationFailure
                        {
                            PropertyName = state.Key,
                            Message = $"{error.ErrorMessage} {error.Exception?.Message}"
                        });
                    }
                }
            }

            return result;
        }
    }
}