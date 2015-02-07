using System;

namespace FusionPInvoke
{
    /// <summary>
    /// Contains GUID which can be in <see cref="InstallReference.Scheme"/>.
    /// </summary>
    public class InstallReferenceGuid
    {
        /// <summary>
        /// he assembly is referenced by an application that was installed using the Microsoft Windows Installer. The <see cref="InstallReference.Identifier"/> field is set to MSI, and the <see cref="InstallReference.NonCannonicalData"/> field is set to Windows Installer. This scheme is used for Windows side-by-side assemblies
        /// </summary>
        public static Guid Msi = new Guid(0x25df0fc1, 0x7f97, 0x4070, 0xad, 0xd7, 0x4b, 0x13, 0xbb, 0xfd, 0x7c, 0xb8);

        /// <summary>
        ///  The assembly is referenced by an application that appears in the Add/Remove Programs interface. The <see cref="InstallReference.Identifier"/> field provides the token that registers the application with the Add/Remove Programs interface.
        /// </summary>
        public static Guid UnistallSubKey = new Guid(0x8cedc215, 0xac4b, 0x488b, 0x93, 0xc0, 0xa5, 0x0a, 0x49, 0xcb, 0x2f, 0xb8);

        /// <summary>
        ///  The assembly is referenced by an application that is represented by a file in the file system. The <see cref="InstallReference.Identifier"/> field provides the path to this file.
        /// </summary>
        public static Guid FilePath = new Guid(0xb02f9d65, 0xfb77, 0x4f7a, 0xaf, 0xa5, 0xb3, 0x91, 0x30, 0x9f, 0x11, 0xc9);

        /// <summary>
        /// The assembly is referenced by an application that is represented only by an opaque string. The <see cref="InstallReference.Identifier"/> field provides this opaque string. The global assembly cache does not check for the existence of opaque references when you remove this value.
        /// </summary>
        public static Guid OpaqueString = new Guid(0x2ec93463, 0xb0c3, 0x45e1, 0x83, 0x64, 0x32, 0x7e, 0x96, 0xae, 0xa8, 0x56);

        /// <summary>
        /// This value is reserved.
        /// </summary>
        public static Guid OSInstall = new Guid(0xd16d444c, 0x56d8, 0x11d5, 0x88, 0x2d, 0x00, 0x80, 0xc8, 0x47, 0xb1, 0x95);
    }
}
