namespace Bumb.SharedKernel.CSharp.IdentityService.Domain.User.ValueObjects;

// TODO should we load the permissions from db?
public enum Role
{
    EndUser = 0,
    Admin = 1
}