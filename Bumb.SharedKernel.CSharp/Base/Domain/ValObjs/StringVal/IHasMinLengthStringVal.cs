using Bumb.SharedKernel.CSharp.Base.Domain.Exceptions.StringVal;

namespace Bumb.SharedKernel.CSharp.Base.Domain.ValObjs.StringVal;

public interface IHasMinLengthStringVal<TValObj>
{
    public static abstract int MinLength { get; }

    public static void ValidateAndThrow(string val, int minLength)
    {
        if (val.Length < minLength)
            throw new InvalidMinLengthStringValExc<TValObj>(val);
    }
}