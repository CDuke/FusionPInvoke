using System;

namespace FusionPInvoke
{
    /// <summary>
    /// Flags used in <see cref="IAssemblyName.GetDisplayName"/>.
    /// </summary>
    [Flags]
    public enum GetDisplayNameFlags
    {
        /// <summary>
        ///Return version.
        /// </summary>
        Version = 0x01,

        /// <summary>
        /// Return culture.
        /// </summary>
        Culture = 0x02,

        /// <summary>
        /// Return public key token.
        /// </summary>
        PublicKeyToken = 0x04,

        /// <summary>
        /// Return public key.
        /// </summary>
        PublicKey = 0x08,

        /// <summary>
        /// Custom.
        /// </summary>
        Custom = 0x10,

        /// <summary>
        /// Return processor architecture.
        /// </summary>
        ProcessorArchitecture = 0x20,

        /// <summary>
        /// Return language id.
        /// </summary>
        LanguageId = 0x40,

        /// <summary>
        /// Retargetable.
        /// </summary>
        Retargetable = 0x80,

        /// <summary>
        /// Config mask.
        /// </summary>
        ConfigMask = 0x100,

        /// <summary>
        /// Module version identifier.
        /// </summary>
        Mvid = 0x200,

        /// <summary>
        /// Content type.
        /// </summary>
        ContentType = 0x400,

        /// <summary>
        /// Full name.
        /// </summary>
        Full = Version
            | Culture
            | PublicKeyToken
            | ProcessorArchitecture
            | Retargetable
            | ContentType
    }
}
