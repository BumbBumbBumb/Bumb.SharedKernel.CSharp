using System.Reflection;

namespace Bumb.SharedKernel.CSharp.Base.Domain.Exceptions.Base;

public abstract class BaseException<TDerived> 
    : Exception
    where TDerived : Exception
{
    public static string ErrorCode => ConvertExcTypeToErrorCode(typeof(TDerived));

    private static string ConvertExcTypeToErrorCode(MemberInfo excType)
        => excType.Name.Split('`')[0];
}