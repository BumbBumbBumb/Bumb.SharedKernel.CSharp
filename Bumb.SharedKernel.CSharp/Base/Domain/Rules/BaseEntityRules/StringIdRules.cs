using Bumb.SharedKernel.CSharp.Base.Domain.Rules.Base.StringRules;
using Bumb.SharedKernel.CSharp.Base.Domain.Validation;

namespace Bumb.SharedKernel.CSharp.Base.Domain.Rules.BaseEntityRules;

public class StringIdRules : BaseValidator<string, StringIdRules>
{
    public StringIdRules()
    {
        RuleFor(id => id)
            .SetValidator(new RequiredString());
    }
}