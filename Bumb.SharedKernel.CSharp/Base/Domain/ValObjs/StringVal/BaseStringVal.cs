namespace Bumb.SharedKernel.CSharp.Base.Domain.ValObjs.StringVal;

public abstract record BaseStringVal(string Val)
{
    public static implicit operator string(BaseStringVal val)
        => val.ToString();

    public override string ToString()
        => Val;
}