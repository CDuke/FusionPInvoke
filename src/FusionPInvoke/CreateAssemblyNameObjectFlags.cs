using System;

namespace FusionPInvoke
{
    /// <summary>
    /// Flags used in <see cref="FusionNative.CreateAssemblyNameObject"/>.
    /// </summary>
    [Flags]
    public enum CreateAssemblyNameObjectFlags
    {
        /// <summary>
        /// If this flag is specified, assemblyName is the Name portion of the side-by-side assembly name.
        /// </summary>
        Default = 0,

        /// <summary>
        /// If this flag is specified, the assemblyName parameter is a full assembly name and is parsed to the individual properties.
        /// </summary>
        CanofParseDispayName = 1,

        /// <summary>
        ///  If this flag is specified, certain properties, such as processor architecture, are set to their default values.
        /// </summary>
        CanofSetDefaultValues = 2,

        /// <summary>
        /// Verifies the friend assembly rule (only name and public key). This member is for internal use only.
        /// </summary>
        CanofVerifyFriendAssemblyname = 4,

        /// <summary>
        /// A combination of the <see cref="CanofParseDispayName"/> and <see cref="CanofVerifyFriendAssemblyname"/>. This member is for internal use only.
        /// </summary>
        CanofParseFriendDisplayName = CanofParseDispayName | CanofVerifyFriendAssemblyname
    }
}
