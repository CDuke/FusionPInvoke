namespace FusionPInvoke
{
    /// <summary>
    /// Flags used in <see cref="IAssemblyCache.InstallAssembly"/>.
    /// </summary>
    public enum InstallAssemblyFlags
    {
        /// <summary>
        /// If the assembly is already installed in the GAC return error.
        /// </summary>
        Default = 0,

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
