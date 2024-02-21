namespace Bumb.SharedKernel.CSharp.Domain.Base.ErrorCode;

public static class StringErrorCodes
{
    public const string ExceedMaxLength = nameof(ExceedMaxLength);
    public const string NotReachMinLength = nameof(NotReachMinLength);
    
    public const string ShouldNotHaveSpace = nameof(ShouldNotHaveSpace);
    public const string ShouldNotHaveSpaceAround = nameof(ShouldNotHaveSpaceAround);
    public const string ShouldNotHaveSpaceBetween = nameof(ShouldNotHaveSpaceBetween);
}