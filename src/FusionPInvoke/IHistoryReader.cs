using System.Runtime.InteropServices;
using System.Text;

namespace FusionPInvoke
{
    [Guid("1D23DF4D-A1E2-4B8B-93D6-6EA3DC285A54")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IHistoryReader
    {
        [PreserveSig]
        int GetFilePath([MarshalAs(UnmanagedType.LPWStr)] StringBuilder filePath, ref uint size);

        [PreserveSig]
        int GetApplicationName([MarshalAs(UnmanagedType.LPWStr)] StringBuilder applicationName, ref uint size);

        [PreserveSig]
        int GetEXEModulePath([MarshalAs(UnmanagedType.LPWStr)] StringBuilder exePath, ref uint size);

        void GetNumActivations(out uint numActivations);

        void GetActivationDate(uint idx, out long date);

        [PreserveSig()]
        int GetRunTimeVersion(ref long activationDate, [MarshalAs(UnmanagedType.LPWStr)] StringBuilder runTimeVersion, ref uint size);

        void GetNumAssemblies(ref long activationDate, out uint numAsms);

        void GetHistoryAssembly(ref long activationDate,uint idx, [MarshalAs(UnmanagedType.IUnknown)] out object histAsm);
    }
}
