namespace LivingSpec.RootContracts.DataContracts.Validation
{
    public interface IValidationFailure
    {
        string PropertyName { get; set; }
        string Message { get; set; }
    }
}