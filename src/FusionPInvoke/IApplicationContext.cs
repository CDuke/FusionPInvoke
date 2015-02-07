using System.Runtime.InteropServices;

namespace FusionPInvoke
{
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("7c23ff90-33af-11d3-95da-00a024a85b51")]
    public interface IApplicationContext
    {
        void SetContextNameObject(IAssemblyName assemblyName);

        void GetContextNameObject(out IAssemblyName assemblyName);

        void Set(string name, int value, int cbValue, int flags);

        void Get(string name, out int pvValue, ref int pcbValue, int flags);

        void GetDynamicDirectory(out int dynamicDir, ref int size);
    }
}
