namespace LivingSpec.WebApi.Models
{
    using System;
    using System.Collections.Generic;
    using RootContracts.DataContracts.Domain;
    using RootContracts.DataContracts.Validation;
    using Validation;

    public class ApiResponse<T> : IApiResponse<T>
    {
        public ApiResponse()
        {
            this.ValidationResult = new ValidationResult();
            this.Information = new List<string>();
        }
        public IValidationResult ValidationResult { get; set; }
        public Exception Exception { get; set; }
        public List<string> Information { get; set; }
        public T Payload { get; set; }
    }
}