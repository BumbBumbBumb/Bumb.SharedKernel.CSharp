using Bumb.SharedKernel.CSharp.Domain.Base.ErrorCode;
using FluentValidation;

namespace Bumb.SharedKernel.CSharp.Domain.Base.Rules;

public sealed class CreatedAtRule : AbstractValidator<DateTime>
{
    public CreatedAtRule()
    {
        RuleFor(c => c)
            .LessThanOrEqualTo(_ => DateTime.Now.AddSeconds(5))
            .WithErrorCode(nameof(CommonErrorCodes.ExceedMaxValue));
    }
}