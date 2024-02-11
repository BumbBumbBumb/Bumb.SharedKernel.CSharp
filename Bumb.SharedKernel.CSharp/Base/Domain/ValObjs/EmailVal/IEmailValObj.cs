using System.Text.RegularExpressions;
using Bumb.SharedKernel.CSharp.Base.Domain.Exceptions.EmailVal;

namespace Bumb.SharedKernel.CSharp.Base.Domain.ValObjs.EmailVal;

public interface IEmailValObj<TValObj>
{
    public static void ValidateAndThrow(string val)
    {
        const string regex = @"^([\w\. \-]+)@([\w\-]+)((\. (\w){2,3})+)$";
        var match = Regex.Match(val, regex);

        if (!match.Success)
            throw new InvalidEmailFormatException<TValObj>(val);
    }
}