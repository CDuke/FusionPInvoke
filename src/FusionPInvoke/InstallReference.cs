using System;
using System.Runtime.InteropServices;

namespace FusionPInvoke
{
    /// <summary>
    /// Represents a reference that an application makes to an assembly that the application has installed in the global assembly cache.
    /// </summary>
     [StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
    public struct InstallReference
    {
         /// <summary>
         /// Size of strcture <see cref="InstallReference"/>.
         /// </summary>
        public int Size;

         /// <summary>
        /// Reserved for future extensibility, this value must be 0 (zero).
         /// </summary>
        public int Flags;

        /// <summary>
        /// The entity that adds the reference. Possible values are <see cref="InstallReferenceGuid"/>.
        /// </summary>
        public Guid Scheme;

        /// <summary>
        /// A unique string that identifies the application that installed the assembly in the global assembly cache. Its value depends upon the value of the <see cref="Scheme"/> field.
        /// </summary>
        public string Identifier;

         /// <summary>
        /// A string that is understood only by the entity that adds the reference. The global assembly cache stores this string, but does not use it.
         /// </summary>
        public string NonCannonicalData;
    }
}
