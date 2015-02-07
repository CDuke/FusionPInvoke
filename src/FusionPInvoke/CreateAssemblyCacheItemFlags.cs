namespace FusionPInvoke
{
    /// <summary>
    /// Flags used in <see cref="IAssemblyCache.CreateAssemblyCacheItem"/>.
    /// </summary>
    public enum CreateAssemblyCacheItemFlags
    {
        /// <summary>
        ///  If the assembly is already installed in the GAC and the file version numbers of the assembly being installed are the same or later, the files are replaced.
        /// </summary>
        Refresh = 1,

        /// <summary>
        /// The files of an existing assembly are overwritten regardless of their version number.
        /// </summary>
        ForceRefresh = 2
    }
}
