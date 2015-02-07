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
        string GetAttribute(string @namespace,string name);

        [SecurityCritical]
        void SetAttribute(string @namespace, string name, string value);

        [SecurityCritical]
        IEnumIDENTITY_ATTRIBUTE EnumAttributes();

        [SecurityCritical]
        IReferenceIdentity Clone(IntPtr cDeltas, IDENTITY_ATTRIBUTE[] deltas);
    }
}
