using Bumb.SharedKernel.CSharp.Base.Domain.Exceptions.Base;

namespace Bumb.SharedKernel.CSharp.Base.Domain.Exceptions.StringVal;

public class InvalidMinLengthStringValExc<TValObj>(string value)
    : BaseException<InvalidMinLengthStringValExc<TValObj>>, IExcHasValue<string>
{
    public string Value { get; } = value;
}