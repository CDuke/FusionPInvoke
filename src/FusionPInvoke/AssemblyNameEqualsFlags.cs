namespace FusionPInvoke
{
    /// <summary>
    /// Indicates the version, build, culture, signature, and so on, of two assemblies to be compared by the <see cref="IAssemblyName.IsEqual" /> method.
    /// </summary>
    public enum AssemblyNameEqualsFlags
    {
        /// <summary>
        /// By name.
        /// </summary>
        Name = 0x1,

        /// <summary>
        /// By major version.
        /// </summary>
        MajorVersion = 0x2,

        /// <summary>
        /// By minor version.
        /// </summary>
        MinorVersion = 0x4,

        /// <summary>
        /// By build number.
        /// </summary>
        BuildNumber = 0x8,

        /// <summary>
        /// By revision number.
        /// </summary>
        RevisionNumber = 0x10,

        /// <summary>
        /// By version.
        /// </summary>
        Version =
                     MajorVersion |
                     MinorVersion |
                     BuildNumber |
                     RevisionNumber,

        /// <summary>
        /// By public key token.
        /// </summary>
        PublicKeyToken = 0x20,

        /// <summary>
        /// By culture.
        /// </summary>
        Culture = 0x40,

        /// <summary>
        /// By custom.
        /// </summary>
        Custom = 0x80,

        /// <summary>
        /// Default.
        /// </summary>
        Default = 0x100,

        /// <summary>
        /// Retarget.
        /// </summary>
        Retarget = 0x200,

        /// <summary>
        /// By architecture.
        /// </summary>
        Architecture = 0x400,

        /// <summary>
        /// By config mask.
        /// </summary>
        ConfigMask = 0x800,

        /// <summary>
        /// By module version identifier.
        /// </summary>
        Mvid = 0x1000,

        /// <summary>
        /// By signature.
        /// </summary>
        Signature = 0x2000,

        /// <summary>
        /// By strong name.
        /// </summary>
        All =
                     Name |
                     Version |
                     PublicKeyToken |
                     Culture,

        /// <summary>
        /// By strong name except version.
        /// </summary>
        AllNoVersion =
                     Name |
                     PublicKeyToken |
                     Culture
    }
}
