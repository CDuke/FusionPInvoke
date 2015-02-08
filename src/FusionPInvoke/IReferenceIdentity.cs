using System;
using System.Runtime.InteropServices;
using System.Security;

namespace FusionPInvoke
{
    /// <summary>
    /// Represents a reference to the unique signature of a code object.
    /// </summary>
    [Guid("6eaf5ace-7917-4f3c-b129-e046a9704766")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IReferenceIdentity
    {
        /// <summary>
        /// Gets the value of the attribute in the specified namespace, with the specified name.
        /// </summary>
        /// <param name="namespace">Attribute namespace.</param>
        /// <param name="name">Attribute name.</param>
        /// <returns>Attribute value.</returns>
        [SecurityCritical]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        string GetAttribute([MarshalAs(UnmanagedType.LPWStr)] string @namespace, [MarshalAs(UnmanagedType.LPWStr)] string name);

        /// <summary>
        /// Sets the attribute that has the specified namespace and the specified name to the specified value.
        /// </summary>
        /// <param name="namespace">Attribute namespace.</param>
        /// <param name="name">Attribute name.</param>
        /// <param name="value">Attribute value.</param>
        [SecurityCritical]
        void SetAttribute([MarshalAs(UnmanagedType.LPWStr)] string @namespace, [MarshalAs(UnmanagedType.LPWStr)] string name,
            [MarshalAs(UnmanagedType.LPWStr)] string value);

        /// <summary>
        /// Gets an <see cref="IEnumIDENTITY_ATTRIBUTE"/> instance that contains the attributes associated with this <see cref="IReferenceIdentity"/>.
        /// </summary>
        /// <returns><see cref="IEnumIDENTITY_ATTRIBUTE"/> instance.</returns>
        [SecurityCritical]
        IEnumIDENTITY_ATTRIBUTE EnumAttributes();

        /// <summary>
        /// Gets a new <see cref="IReferenceIdentity"/> instance that is identical to this <see cref="IReferenceIdentity"/>, except for the specified attribute changes.
        /// </summary>
        /// <param name="deltasCount">Count of elements in <paramref name="deltas"/>.</param>
        /// <param name="deltas">Changed attributes.</param>
        /// <returns><see cref="IReferenceIdentity"/> instance.</returns>
        [SecurityCritical]
        IReferenceIdentity Clone(IntPtr deltasCount, [MarshalAs(UnmanagedType.LPArray)] IDENTITY_ATTRIBUTE[] deltas);
    }
}
