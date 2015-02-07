using System.Runtime.InteropServices;
using System.Text;

namespace FusionPInvoke
{
    /// <summary>
    /// Contains information about an assembly that is registered in the global assembly cache.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct AssemblyInfo
    {
        /// <summary>
        /// Size of the structure in bytes. Permits additions to the structure in future version of the .NET Framework.
        /// </summary>
        public int StructureSize;

        /// <summary>
        /// Flags that indicate installation details about the assembly. Possible values are <see cref="AssemblyInfoFlags"/>.
        /// </summary>
        public AssemblyInfoFlags AssemblyFlags;

        /// <summary>
        /// The total size, in kilobytes, of the files that the assembly contains.
        /// </summary>
        public long AssemblySize;

        /// <summary>
        /// Current path to the manifest file.
        /// </summary>
        ///[MarshalAs(UnmanagedType.LPWStr)]
        public StringBuilder AssemblyPath;

        /// <summary>
        /// The number of wide characters in <see cref="AssemblyPath"/>.
        /// </summary>
        public int AssemblyPathLength;
    }
}
