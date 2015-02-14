using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;

namespace FusionPInvoke
{
    /// <summary>
    /// Represents a single assembly in the global assembly cache.
    /// </summary>
    [Guid("9e3aaeb4-d1cd-11d2-bab9-00c04f8eceae")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAssemblyCacheItem
    {
        /// <summary>
        /// Creates a stream with the specified name and format.
        /// </summary>
        /// <param name="assemblyName">Assembly name.</param>
        /// <param name="format">The format of the file to be streamed.</param>
        /// <param name="formatFlags">Flags.</param>
        /// <param name="maxSize"></param>
        /// <param name="stream"></param>
        /// <returns><see cref="HRESULT"/>.</returns>
        HRESULT CreateStream([MarshalAs(UnmanagedType.LPWStr)] string assemblyName, CreateStreamFormat format, int formatFlags, int maxSize, out IStream stream);

        HRESULT IsNameEqual(IAssemblyName pName);

        ///  <summary>
        /// Commits the cached assembly reference to memory.
        ///  </summary>
        ///  <param name="flags">Flags <see cref="AssemblyCacheItemFlags"/>.</param>
        /// <param name="result">Result of commit.</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        HRESULT Commit(AssemblyCacheItemFlags flags, out AssemblyCacheItemCommitResult result);

        /// <summary>
        /// Mark assembly as visible.
        /// </summary>
        /// <param name="flags">Flags.</param>
        void MarkAssemblyVisible(int flags);
    }
}
