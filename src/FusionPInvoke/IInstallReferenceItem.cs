using System.Runtime.InteropServices;

namespace FusionPInvoke
{
    /// <summary>
    /// Represents an item installed in the global assembly cache.
    /// </summary>
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("582dac66-e678-449f-aba6-6faaec8a9394")]
    public interface IInstallReferenceItem
    {
        /// <summary>
        /// Gets a <see cref="InstallReference"/> instance.
        /// </summary>
        /// <param name="installReference"><see cref="InstallReference"/> instance.</param>
        /// <param name="flags">Flags <see cref="GetReferenceFlags"/>.</param>
        /// <param name="reserved"> Reserved for future extensibility, must be 0 (zero).</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [PreserveSig()]
        HRESULT GetReference(out InstallReference installReference, GetReferenceFlags flags, int reserved);
    }
}
