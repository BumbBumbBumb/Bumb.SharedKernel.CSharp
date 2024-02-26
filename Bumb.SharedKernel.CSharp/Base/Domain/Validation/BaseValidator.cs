using FluentValidation;
using FluentValidation.Results;

namespace Bumb.SharedKernel.CSharp.Base.Domain.Validation;

public abstract class BaseValidator<TVal, TDerived> : AbstractValidator<TVal>
    where TDerived : BaseValidator<TVal, TDerived>, new()
{
    public static readonly TDerived Instance = new();

    public static ValidationResult ExcValidation(TVal value)
        => Instance.Validate(value);
    
    public static void ExcValidationAndThrow(TVal value)
        => Instance.ValidateAndThrow(value);
}