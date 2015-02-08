using System.Runtime.InteropServices;

namespace FusionPInvoke
{
    [StructLayout(LayoutKind.Sequential)]
    public struct IDENTITY_ATTRIBUTE
    {
        [MarshalAs(UnmanagedType.LPWStr)]
        public string Namespace;

        [MarshalAs(UnmanagedType.LPWStr)]
        public string Name;

        [MarshalAs(UnmanagedType.LPWStr)]
        public string Value;
    }
}
