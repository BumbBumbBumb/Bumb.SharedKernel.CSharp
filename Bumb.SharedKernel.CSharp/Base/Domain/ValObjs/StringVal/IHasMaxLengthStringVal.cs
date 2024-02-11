using Bumb.SharedKernel.CSharp.Base.Domain.Exceptions.StringVal;

namespace Bumb.SharedKernel.CSharp.Base.Domain.ValObjs.StringVal;

public interface IHasMaxLengthStringVal<TValObj>
{
    public static abstract int MaxLength { get; }

    public static void ValidateAndThrow(string val, int maxLength)
    {
        if (val.Length > maxLength)
            throw new InvalidMaxLengthStringValExc<TValObj>(val);
    }
}