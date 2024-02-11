using Bumb.SharedKernel.CSharp.Base.Domain.Exceptions.Base;

namespace Bumb.SharedKernel.CSharp.Base.Domain.Exceptions.EmailVal;

public class InvalidEmailFormatException<TValObj>(string value)
    : BaseException<InvalidEmailFormatException<TValObj>>, IExcHasValue<string>
{
    public string Value { get; } = value;
}