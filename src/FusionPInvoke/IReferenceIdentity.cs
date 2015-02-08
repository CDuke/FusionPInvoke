using System;
using System.Runtime.InteropServices;
using System.Security;

namespace FusionPInvoke
{
    [Guid("6eaf5ace-7917-4f3c-b129-e046a9704766")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IReferenceIdentity
    {
        [SecurityCritical]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        string GetAttribute([MarshalAs(UnmanagedType.LPWStr)] string @namespace, [MarshalAs(UnmanagedType.LPWStr)] string name);

        [SecurityCritical]
        void SetAttribute([MarshalAs(UnmanagedType.LPWStr)] string @namespace, [MarshalAs(UnmanagedType.LPWStr)] string name,
            [In, MarshalAs(UnmanagedType.LPWStr)] string value);

        [SecurityCritical]
        IEnumIDENTITY_ATTRIBUTE EnumAttributes();

        [SecurityCritical]
        IReferenceIdentity Clone(IntPtr cDeltas, [MarshalAs(UnmanagedType.LPArray)] IDENTITY_ATTRIBUTE[] deltas);
    }
}
