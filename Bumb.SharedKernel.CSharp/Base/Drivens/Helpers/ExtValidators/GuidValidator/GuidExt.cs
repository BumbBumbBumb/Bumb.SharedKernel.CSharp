using Bumb.SharedKernel.CSharp.Base.Drivens.Helpers.ExtValidators.GuidValidator.Errors;

namespace Bumb.SharedKernel.CSharp.Base.Drivens.Helpers.ExtValidators.GuidValidator;

public static class GuidExt
{
    public static Exception? Required(this Guid value)
        => value.Equals(Guid.Empty) ? new RequiredGuidError() : null;
}