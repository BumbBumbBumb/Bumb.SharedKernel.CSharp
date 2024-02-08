namespace Bumb.SharedKernel.CSharp.Base.Domain.ValObjs.GuidVal;

public abstract record BaseGuidVal(Guid Val)
{
    public static implicit operator string(BaseGuidVal val)
        => val.ToString();
    
    public override string ToString()
        => Val.ToString();
}