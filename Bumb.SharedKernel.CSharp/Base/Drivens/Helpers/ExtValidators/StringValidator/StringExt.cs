﻿using System.Text.RegularExpressions;
using Bumb.SharedKernel.CSharp.Base.Drivens.Helpers.ExtValidators.StringValidator.Errors;

namespace Bumb.SharedKernel.CSharp.Base.Drivens.Helpers.ExtValidators.StringValidator;

public static class StringExt
{
    public static Exception? Required(this string value)
        => string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value)
            ? new RequiredStringError()
            : null;

    public static Exception? MinLength(this string value, int minLength)
        => value.Length < minLength
            ? new MinLengthStringError()
            : null;

    public static Exception? MaxLength(this string value, int maxLength)
        => value.Length < maxLength
            ? new MaxLengthStringError()
            : null;

    public static Exception? NoSpaceAround(this string value)
        => value.StartsWith(' ') || value.EndsWith(' ')
            ? new NoSpaceAroundStringError()
            : null;

    public static Exception? NoSpace(this string value)
        => value.Contains(' ')
            ? new NoSpaceStringError()
            : null;
    
    public static Exception? Email(this string value)
    {
        const string regex = @"^[a-zA-Z0-9.!#$%&'*+/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9\-]{0,61}[a-zA-Z0-9])?(?:\.[a-zA-Z0-9](?:[a-zA-Z0-9\-]{0,61}[a-zA-Z0-9])?)*$";
        var match = Regex.Match(value, regex);
        
        return !match.Success
            ? new EmailFormatError()
            : null;
    }
}