namespace LivingSpec.WebApi.Validation
{
    using System.Collections.Generic;
    using RootContracts.DataContracts.Validation;

    public class ValidationResult : IValidationResult
    {
        public ValidationResult()
        {
            this.ValidationFailures = new List<IValidationFailure>();
        }
        public bool IsValid => this.ValidationFailures.Count == 0;
        public List<IValidationFailure> ValidationFailures { get; set; }
    }
}