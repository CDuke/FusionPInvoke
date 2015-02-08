using System;
using System.Runtime.InteropServices;
using System.Security;

namespace FusionPInvoke
{
    [Guid("587bf538-4d90-4a3c-9ef1-58a200a8a9e7")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IDefinitionIdentity
    {
        [SecurityCritical]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        string GetAttribute([MarshalAs(UnmanagedType.LPWStr)] string @namespace, [MarshalAs(UnmanagedType.LPWStr)] string name);

        [SecurityCritical]
        void SetAttribute(
            [MarshalAs(UnmanagedType.LPWStr)] string @namespace,
            [MarshalAs(UnmanagedType.LPWStr)] string name,
            [MarshalAs(UnmanagedType.LPWStr)] string value);

        [SecurityCritical]
        IEnumIDENTITY_ATTRIBUTE EnumAttributes();

        [SecurityCritical]
        IDefinitionIdentity Clone(IntPtr /*SIZE_T*/ cDeltas, [MarshalAs(UnmanagedType.LPArray)] IDENTITY_ATTRIBUTE[] deltas);
    }
}
