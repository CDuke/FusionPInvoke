using System.Runtime.InteropServices;
using System.Text;

namespace FusionPInvoke
{
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("7c23ff90-33af-11d3-95da-00a024a85b51")]
    public interface IApplicationContext
    {
        HRESULT SetContextNameObject(IAssemblyName assemblyName);

        HRESULT GetContextNameObject(out IAssemblyName assemblyName);

        HRESULT Set([MarshalAs(UnmanagedType.LPWStr)] string name, int value, int cbValue, int flags);

        HRESULT Get([MarshalAs(UnmanagedType.LPWStr)] string name, out int pvValue, ref int pcbValue, int flags);

        HRESULT GetDynamicDirectory(out int dynamicDir, ref int size);

        HRESULT GetAppCacheDirectory([Out] StringBuilder wzAppCacheDir,ref int pdwSize);

        //HRESULT RegisterKnownAssembly(IAssemblyName name, string pwzAsmURL, out IAssembly assembly);

        HRESULT PrefetchAppConfigFile();


    }
}
