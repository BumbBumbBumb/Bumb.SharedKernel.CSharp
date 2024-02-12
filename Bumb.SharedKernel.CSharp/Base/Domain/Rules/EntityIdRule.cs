using Bumb.SharedKernel.CSharp.Base.Domain.Exceptions;
using Bumb.SharedKernel.CSharp.Base.Drivens.Helpers.ExtValidators.GuidValidator;

namespace Bumb.SharedKernel.CSharp.Base.Domain.Rules;

public static class EntityIdRule
{
    public static void ValidateAndThrow(Guid value)
    {
        var exc = value.Required();

        if (exc is not null)
            throw new InvalidEntityIdExc(value, exc);
    }
}