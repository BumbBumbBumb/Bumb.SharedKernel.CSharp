using FluentValidation;
using FluentValidation.Results;

namespace Bumb.SharedKernel.CSharp.Base.Domain.Validation;

public abstract class BaseValueObjectValidator<TVal, TDerived> : AbstractValidator<TVal>
    where TDerived : BaseValueObjectValidator<TVal, TDerived>, new()
{
    public static readonly TDerived Instance = new();

    public static ValidationResult Validate(TVal value, string varName)
    {
        return Instance.Validate(value);
    }
}