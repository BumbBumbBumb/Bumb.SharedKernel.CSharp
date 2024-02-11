using Bumb.SharedKernel.CSharp.Base.Domain.Exceptions.Base;

namespace Bumb.SharedKernel.CSharp.Base.Domain.Exceptions.StringVal;

public class HasSpaceAroundStringValExc<TValObj>(string value) 
    : BaseException<HasSpaceAroundStringValExc<TValObj>>, IExcHasValue<string>
{
    public string Value { get; } = value;
}