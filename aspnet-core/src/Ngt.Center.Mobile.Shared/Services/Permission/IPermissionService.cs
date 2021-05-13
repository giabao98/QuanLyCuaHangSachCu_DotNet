namespace Ngt.Center.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}