﻿namespace Bumb.SharedKernel.CSharp.Domain.Base.ErrorCode;

public static class CommonErrorCodes
{
    public const string Invalid = nameof(Invalid);
    
    public const string Required = nameof(Required);

    public const string ExceedMaxValue = nameof(ExceedMaxValue);
    public const string NotReachMinValue = nameof(NotReachMinValue);
}