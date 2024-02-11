using Bumb.SharedKernel.CSharp.Base.Domain.Exceptions.StringVal;

namespace Bumb.SharedKernel.CSharp.Base.Domain.ValObjs.StringVal;

public interface IRequiredStringVal<TValObj>
{
    public static void ValidateAndThrow(string val)
    {
        if (string.IsNullOrEmpty(val) || string.IsNullOrWhiteSpace(val))
            throw new InvalidRequiredStringValExc<TValObj>();
    }
}