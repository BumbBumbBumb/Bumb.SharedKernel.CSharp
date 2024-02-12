using System.Reflection;

namespace Bumb.SharedKernel.CSharp.Base.Domain.Exceptions;

public abstract class BaseExc(dynamic value, Exception childExc) : Exception
{
    private static string ConvertExcTypeToErrorCode(MemberInfo excType)
        => excType.Name.Split('`')[0];
    
    public string ErrorCode => ConvertExcTypeToErrorCode(ChildExc.GetType());
    
    public dynamic Value { get; } = value;
    
    public Exception ChildExc { get; } = childExc;
}