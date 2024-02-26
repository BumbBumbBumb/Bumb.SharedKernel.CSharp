using Bumb.SharedKernel.CSharp.Base.Domain.ErrorCodes.Base;
using Bumb.SharedKernel.CSharp.Base.Domain.Validation;
using FluentValidation;

namespace Bumb.SharedKernel.CSharp.Base.Domain.Rules.BaseEntityRules;

public class CreatedAtRule : BaseValidator<DateTime, CreatedAtRule>
{
    public const int AllowedLatencySeconds = 10;
    
    public CreatedAtRule()
    {
        RuleFor(c => c)
            .LessThanOrEqualTo(_ => DateTime.Now.AddSeconds(AllowedLatencySeconds))
            .WithErrorCode(CommonErrorCodes.ExceedMaxValue);
    }
}