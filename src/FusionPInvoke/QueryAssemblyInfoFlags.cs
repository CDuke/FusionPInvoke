namespace FusionPInvoke
{
    /// <summary>
    /// Flags used in <see cref="IAssemblyCache.QueryAssemblyInfo"/>.
    /// </summary>
    public enum QueryAssemblyInfoFlags
    {
        /// <summary>
        /// Performs validation of the files in the GAC against the assembly manifest, including hash verification and strong name signature verification.
        /// </summary>
        Validate = 1,

        /// <summary>
        /// Returns the size of all files in the assembly (disk footprint). If this is not specified, the <see cref="AssemblyInfo.AssemblySizeInKB"/> not modified.
        /// </summary>
        GetSize = 2
    }
}
