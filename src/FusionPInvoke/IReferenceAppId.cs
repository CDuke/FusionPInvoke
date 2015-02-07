using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Security;

namespace FusionPInvoke
{
    [Guid("054f0bef-9e45-4363-8f5a-2f8e142d9a3b")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IReferenceAppId
    {
        [SecurityCritical]
        string get_SubscriptionId();

        void put_SubscriptionId(string subscription);

        [SecurityCritical]
        [ResourceExposure(ResourceScope.Machine)]
        string get_Codebase();

        [ResourceExposure(ResourceScope.Machine)]
        void put_Codebase(string codeBase);

        [SecurityCritical]
        IEnumReferenceIdentity EnumAppPath();
    }
}
