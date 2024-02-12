using Bumb.SharedKernel.CSharp.Base.Domain.Exceptions;
using Bumb.SharedKernel.CSharp.Base.Drivens.Helpers.ExtValidators.StringValidator;

namespace Bumb.SharedKernel.CSharp.Base.Domain.Rules;

public static class StringIdRule
{
    public const int MinLength = 1;
    public const int MaxLength = 255;
    
    public static void ValidateAndThrow(string value)
    {
        var exc =
            value.Required()
            ?? value.MinLength(MinLength)
            ?? value.MaxLength(MaxLength);

        if (exc is not null)
            throw new InvalidStringIdExc(value, exc);
    }
}