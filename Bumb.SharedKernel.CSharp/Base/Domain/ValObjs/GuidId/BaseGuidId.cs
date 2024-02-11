using Bumb.SharedKernel.CSharp.Base.Domain.ValObjs.GuidVal;

namespace Bumb.SharedKernel.CSharp.Base.Domain.ValObjs.GuidId;

public abstract record BaseGuidId<TDerived> : BaseGuidVal
{
    public static void ValidateAndThrow(Guid val)
    {
        IRequiredGuidVal<TDerived>.ValidateAndThrow(val);
    }
    
    protected BaseGuidId(Guid val) : base(val)
    {
        ValidateAndThrow(val);
    }
}