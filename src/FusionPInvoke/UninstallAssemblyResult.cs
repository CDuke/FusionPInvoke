namespace FusionPInvoke
{
    /// <summary>
    /// Result of <see cref="IAssemblyCache.UninstallAssembly"/>.
    /// </summary>
    public enum UninstallAssemblyResult
    {
        /// <summary>
        /// No status.
        /// </summary>
        None,

        /// <summary>
        /// Assembly was uninstalled successfully.
        /// </summary>
        Uninstalled,

        /// <summary>
        /// Assembly used by another process.
        /// </summary>
        StillInUse,

        /// <summary>
        /// Assembly already uninstalled.
        /// </summary>
        AlreadyUninstalled,

        /// <summary>
        /// Assembly delete pending. Not used.
        /// </summary>
        DeletePending,

        /// <summary>
        /// The assembly has not been removed from the GAC because another application reference exists.
        /// </summary>
        HasInstallReferences,

        /// <summary>
        /// Assembly not found.
        /// </summary>
        ReferenceNotFound
    }
}
