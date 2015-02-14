namespace FusionPInvoke
{
    /// <summary>
    /// Format of created strem <see cref="IAssemblyCacheItem.CreateStream"/>.
    /// </summary>
    public enum CreateStreamFormat
    {
        /// <summary>
        /// Copy the source of a module for a non-Windows assembly to a stream.
        /// </summary>
        ComplibModule = 1,

        /// <summary>
        /// Copy the source of a manifest for a non-Windows assembly to a stream.
        /// </summary>
        ComplibManifest = 2,

        /// <summary>
        /// Copy the source of a module for a Windows assembly to a stream.
        /// </summary>
        Win32Module = 3,

        /// <summary>
        /// Copy the source of a manifest for a Windows assembly to a stream.
        /// </summary>
        Win32Manifest = 4
    }
}
