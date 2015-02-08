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
        [return: MarshalAs(UnmanagedType.LPWStr)]
        string get_SubscriptionId();

        void put_SubscriptionId([MarshalAs(UnmanagedType.LPWStr)]string subscription);

        [SecurityCritical]
        [ResourceExposure(ResourceScope.Machine)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        string get_Codebase();

        [SecurityCritical]
        [ResourceExposure(ResourceScope.Machine)]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        void put_Codebase([MarshalAs(UnmanagedType.LPWStr)] string codeBase);

        [SecurityCritical]
        IEnumDefinitionIdentity EnumAppPath();

        [SecurityCritical]
        void SetAppPath(int cIDefinitionIdentity, [MarshalAs(UnmanagedType.LPArray)]  IDefinitionIdentity[] definitionIdentity);
    }
}
