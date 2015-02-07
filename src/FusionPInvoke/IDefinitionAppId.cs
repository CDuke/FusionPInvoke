using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;

namespace FusionPInvoke
{
    [Guid("d91e12d8-98ed-47fa-9936-39421283d59b")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDefinitionAppId
    {
        [SecurityCritical]
        string get_SubscriptionId();

        void put_SubscriptionId(string subscription);

        [SecurityCritical]
        [ResourceExposure(ResourceScope.Machine)]
        string get_Codebase();

        [SecurityCritical]
        [ResourceExposure(ResourceScope.Machine)]
        void put_Codebase(string codeBase);

        [SecurityCritical]
        IEnumDefinitionIdentity EnumAppPath();

        [SecurityCritical]
        void SetAppPath([In] uint cIDefinitionIdentity, IDefinitionIdentity[] definitionIdentity);
    }
}
