using Bumb.SharedKernel.CSharp.Base.Domain.Exceptions.GuidVal;

namespace Bumb.SharedKernel.CSharp.Base.Domain.ValObjs.GuidVal;

public interface IRequiredGuidVal<TValObj>
{
    public static void ValidateAndThrow(Guid val)
    {
        if (val.Equals(Guid.Empty))
            throw new InvalidRequiredGuidValException<TValObj>();
    }
}