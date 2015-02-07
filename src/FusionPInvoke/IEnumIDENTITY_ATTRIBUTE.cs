using System;
using System.Runtime.InteropServices;
using System.Security;

namespace FusionPInvoke
{
    [Guid("9cdaae75-246e-4b00-a26d-b9aec137a3eb")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IEnumIDENTITY_ATTRIBUTE
    {
        [SecurityCritical]
        int Next(int celt, out IDENTITY_ATTRIBUTE[] rgAttributes);

        [SecurityCritical]
        IntPtr CurrentIntoBuffer(IntPtr /*SIZE_T*/ available, out byte[] data);

        [SecurityCritical]
        void Skip(int celt);

        [SecurityCritical]
        void Reset();

        [SecurityCritical]
        IEnumIDENTITY_ATTRIBUTE Clone();
    }
}
