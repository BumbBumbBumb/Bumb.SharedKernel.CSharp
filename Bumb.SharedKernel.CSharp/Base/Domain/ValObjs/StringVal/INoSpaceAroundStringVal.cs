using Bumb.SharedKernel.CSharp.Base.Domain.Exceptions.StringVal;

namespace Bumb.SharedKernel.CSharp.Base.Domain.ValObjs.StringVal;

public interface INoSpaceAroundStringVal<TValObj>
{
    public static void ValidateAndThrow(string val)
    {
        if (val.StartsWith(' ') || val.EndsWith(' '))
            throw new HasSpaceAroundStringValExc<TValObj>(val);
    }
}