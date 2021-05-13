using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Ngt.Center.Authorization.Users;
using Ngt.Center.MultiTenancy;

namespace Ngt.Center.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}