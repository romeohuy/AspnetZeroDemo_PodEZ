namespace PodEZ.PodEZTemplate.Services.Permission
{
    public interface IPermissionService
    {
        bool HasPermission(string key);
    }
}