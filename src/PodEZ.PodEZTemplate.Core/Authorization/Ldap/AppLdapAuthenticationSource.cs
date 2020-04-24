using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using PodEZ.PodEZTemplate.Authorization.Users;
using PodEZ.PodEZTemplate.MultiTenancy;

namespace PodEZ.PodEZTemplate.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}