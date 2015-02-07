namespace FusionPInvoke
{
    /// <summary>
    /// Flags used in <see cref="Fusion.GetCachePath"/>.
    /// </summary>
    public enum GetCachePathFlags
    {
        /// <summary>
        /// Get path of precompiled assemblies by using Ngen.exe.
        /// </summary>
        Zap = 1,

        /// <summary>
        /// Get path of the global assembly cache.
        /// </summary>
        Gac = 2,

        /// <summary>
        /// Get path of the assemblies that have been downloaded on demand or that have been shadow-copied.
        /// </summary>
        Download = 4,

        /// <summary>
        /// Should return the path to the global assembly cache for the common language runtime (CLR) version 2.0.
        /// </summary>
        Root = 0x8,

        /// <summary>
        ///  Should return the path to the global assembly cache for CLR version 4
        /// </summary>
        RootEx = 0x80
    }
}
