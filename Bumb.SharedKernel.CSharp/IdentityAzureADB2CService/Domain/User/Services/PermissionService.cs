using System.Collections.Immutable;
using Bumb.SharedKernel.CSharp.IdentityAzureADB2CService.Domain.User.ValueObjects;

namespace Bumb.SharedKernel.CSharp.IdentityAzureADB2CService.Domain.User.Services;

public interface IPermissionService;

public record PermissionService : IPermissionService
{
    private static readonly IEnumerable<Permission> EndUserPermissions = [];
    
    private static readonly IEnumerable<Permission> AdminPermissions = [];
    
    public static readonly IImmutableDictionary<Role, IEnumerable<Permission>> RolePermissionDic
        = ImmutableDictionary<Role, IEnumerable<Permission>>
            .Empty
            .Add(Role.EndUser, EndUserPermissions)
            .Add(Role.Admin, AdminPermissions);
}