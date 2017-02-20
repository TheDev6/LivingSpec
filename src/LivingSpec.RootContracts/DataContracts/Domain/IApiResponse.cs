namespace LivingSpec.RootContracts.DataContracts.Domain
{
    using System;
    using System.Collections.Generic;
    using Validation;

    public interface IApiResponse<T>
    {
        IValidationResult ValidationResult { get; set; }
        Exception Exception { get; set; }
        List<string> Information { get; set; }
        T Payload { get; set; }
    }
}