using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FusionPInvoke
{
    /// <summary>
    /// Represents an enumerator for the referenced assemblies installed in the global assembly cache.
    /// </summary>
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("56b1a988-7c0c-4aa2-8639-c3eb5a90226f")]
    public interface IInstallReferenceEnum
    {
        /// <summary>
        /// Gets the next <see cref="IInstallReferenceItem"/> object contained in this <see cref="IInstallReferenceEnum"/> object.
        /// </summary>
        /// <param name="installReferenceItem">Returned <see cref="IInstallReferenceItem"/>.</param>
        /// <param name="flags">Flags <see cref="GetNextInstallReferenceItem"/>.</param>
        /// <param name="reserved">Reserved for future extensibility, must be a 0 (zero).</param>
        /// <returns>Return <see cref="HRESULT.S_OK"/> when the next item is returned successfully and <see cref="HRESULT.S_FALSE"/> when no more items.</returns>
        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT GetNextInstallReferenceItem(out IInstallReferenceItem installReferenceItem, GetNextInstallReferenceItemFlags flags, int reserved);
    }
}
