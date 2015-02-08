using System.Runtime.InteropServices;
using System.Security;

namespace FusionPInvoke
{
    [Guid("f3549d9c-fc73-4793-9c00-1cd204254c0c")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IEnumDefinitionIdentity
    {
        [SecurityCritical]
        uint Next(int celt, [Out, MarshalAs(UnmanagedType.LPArray)] IDefinitionIdentity[] definitionIdentity);

        [SecurityCritical]
        void Skip(int celt);

        [SecurityCritical]
        void Reset();

        [SecurityCritical]
        IEnumDefinitionIdentity Clone();
    }
}
