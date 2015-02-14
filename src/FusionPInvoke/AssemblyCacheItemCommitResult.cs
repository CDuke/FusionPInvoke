namespace FusionPInvoke
{
    /// <summary>
    /// Result of <see cref="IAssemblyCacheItem.Commit"/>.
    /// </summary>
    public enum AssemblyCacheItemCommitResult
    {
        /// <summary>
        /// First time install.
        /// </summary>
        Installed = 1,

        /// <summary>
        /// Overwrite, if exististing.
        /// </summary>
        Refreshed = 2,

        /// <summary>
        /// Existing.
        /// </summary>
        AkreadyInstalled = 3
    }
}
