namespace FusionPInvoke
{
    /// <summary>
    /// Indicates the source of an assembly that is represented by <see cref="IAssemblyCacheItem"/> in the global assembly cache.
    /// </summary>
    public enum CreateAssemblyEnumFlags
    {
        /// <summary>
        /// Enumerates the cache of precompiled assemblies by using Ngen.exe.
        /// </summary>
        Zap = 1,

        /// <summary>
        /// Enumerates the global assembly cache.
        /// </summary>
        Gac = 2,

        /// <summary>
        /// Enumerates the assemblies that have been downloaded on demand or that have been shadow-copied.
        /// </summary>
        Download = 4,
    }
}
