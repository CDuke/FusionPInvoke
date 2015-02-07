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
        string GetAttribute(string @namespace, string name);

        [SecurityCritical]
        void SetAttribute(string @namespace, string name, string value);

        [SecurityCritical]
        IEnumIDENTITY_ATTRIBUTE EnumAttributes();

        [SecurityCritical]
        IDefinitionIdentity Clone(IntPtr /*SIZE_T*/ cDeltas, IDENTITY_ATTRIBUTE[] deltas);
    }
}
