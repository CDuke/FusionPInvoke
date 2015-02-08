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
        [return: MarshalAs(UnmanagedType.LPWStr)]
        string get_SubscriptionId();

        void put_SubscriptionId([MarshalAs(UnmanagedType.LPWStr)] string subscription);

        [SecurityCritical]
        [ResourceExposure(ResourceScope.Machine)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        string get_Codebase();

        [ResourceExposure(ResourceScope.Machine)]
        void put_Codebase([MarshalAs(UnmanagedType.LPWStr)] string codeBase);

        [SecurityCritical]
        IEnumReferenceIdentity EnumAppPath();
    }
}
