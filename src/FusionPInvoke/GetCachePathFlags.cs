namespace FusionPInvoke
{
    /// <summary>
    /// Flags used in <see cref="FusionNative.GetCachePath"/>.
    /// </summary>
    public enum GetCachePathFlags
    {
        /// <summary>
        /// Get path of precompiled assemblies by using Ngen.exe.
        /// </summary>
        Zap = 0x01,

        /// <summary>
        /// Get path of the global assembly cache.
        /// </summary>
        /// <remarks>C:\Windows\Assembly\GAC.</remarks>
        Gac = 0x02,

        /// <summary>
        /// Get path of the assemblies that have been downloaded on demand or that have been shadow-copied.
        /// </summary>
        Download = 0x04,

        /// <summary>
        /// Should return the path to the global assembly cache for the common language runtime (CLR) version 2.0.
        /// </summary>
        /// <remarks>C:\Windows\Assembly.</remarks>
        Root = 0x08,

        /// <summary>
        /// Get path of the msil global assembly cache.
        /// </summary>
        /// <remarks>C:\Windows\assembly\GAC_MSIL.</remarks>
        GacMsil = 0x10,

        /// <summary>
        /// Get path of the 32 bit global assembly cache.
        /// </summary>
        /// <remarks>C:\Windows\Assembly\GAC_32.</remarks>
        Gac32 = 0x20,

        /// <summary>
        /// Get path of the 64 bit global assembly cache.
        /// </summary>
        /// <remarks>C:\Windows\Assembly\GAC_64.</remarks>
        Gac64 = 0x40,

        /// <summary>
        ///  Should return the path to the global assembly cache for CLR version 4
        /// </summary>
        RootEx = 0x80
    }
}
