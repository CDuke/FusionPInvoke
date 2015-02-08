using System.Runtime.InteropServices;

namespace FusionPInvoke
{
    /// <summary>
    /// Contains information about a single attribute in an assembly, and consists of three DWORDs. Each DWORD is an offset into a character buffer produced by the <see cref="IEnumIDENTITY_ATTRIBUTE.CurrentIntoBuffer"/>.
    /// </summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct IDENTITY_ATTRIBUTE_BLOB
    {
        /// <summary>
        /// The first offset into the character buffer. This offset is not followed by the attribute's namespace, but by a series of null characters. Therefore, it is not used.
        /// </summary>
        public int OffsetNamespace;

        /// <summary>
        /// The second offset into the character buffer. This location marks the start of the attribute's name.
        /// </summary>
        public int OffsetName;

        /// <summary>
        /// The third offset into the character buffer. This location marks the start of the attribute's value.
        /// </summary>
        public int OffsetValue;
    }
}
