using System.Runtime.InteropServices;
using System.Security;

namespace FusionPInvoke
{
    [Guid("b30352cf-23da-4577-9b3f-b4e6573be53b")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IEnumReferenceIdentity
    {
        [SecurityCritical]
        uint Next(int celt, [Out, MarshalAs(UnmanagedType.LPArray)] IReferenceIdentity[] referenceIdentity);

        [SecurityCritical]
        void Skip(uint celt);

        [SecurityCritical]
        void Reset();

        [SecurityCritical]
        IEnumReferenceIdentity Clone();
    }
}
