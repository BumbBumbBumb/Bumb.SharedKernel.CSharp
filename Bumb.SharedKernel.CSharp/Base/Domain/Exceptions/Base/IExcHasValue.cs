namespace Bumb.SharedKernel.CSharp.Base.Domain.Exceptions.Base;

public interface IExcHasValue<out TVal>
{
    public TVal Value { get; }
}