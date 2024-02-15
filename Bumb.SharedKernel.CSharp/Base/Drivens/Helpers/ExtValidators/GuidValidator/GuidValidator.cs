using Bumb.SharedKernel.CSharp.Base.Drivens.Helpers.ExtValidators.GuidValidator.Errors;

namespace Bumb.SharedKernel.CSharp.Base.Drivens.Helpers.ExtValidators.GuidValidator;

/// <summary>
/// <see cref="Required"/><br/>
/// </summary>
public static class GuidValidator
{
    public static Exception? Required(this Guid value)
        => value.Equals(Guid.Empty) ? new RequiredGuidError() : null;
}