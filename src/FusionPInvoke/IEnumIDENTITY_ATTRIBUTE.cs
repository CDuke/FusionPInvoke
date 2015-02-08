using System;
using System.Runtime.InteropServices;
using System.Security;

namespace FusionPInvoke
{
    /// <summary>
    /// Serves as an enumerator for the attributes of the code object in the current scope.
    /// </summary>
    [Guid("9cdaae75-246e-4b00-a26d-b9aec137a3eb")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IEnumIDENTITY_ATTRIBUTE
    {
        /// <summary>
        /// Gets the specified number of attributes, starting at the current position.
        /// </summary>
        /// <param name="count">Count of items to get.</param>
        /// <param name="attributes">Readed attributes.</param>
        /// <returns>Readed attributes count.</returns>
        /// <remarks>If return value less then <paramref name="count"/>, then no more attributes.</remarks>
        [SecurityCritical]
        int Next(int count, [Out, MarshalAs(UnmanagedType.LPArray)] IDENTITY_ATTRIBUTE[] attributes);

        /// <summary>
        /// Writes the data contained in the elements of this <see cref="IEnumIDENTITY_ATTRIBUTE"/> to the specified data buffer.
        /// </summary>
        /// <param name="available"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        /// <remarks>Use <see cref="Next"/>.</remarks>
        [SecurityCritical]
        int CurrentIntoBuffer(int available, [Out, MarshalAs(UnmanagedType.LPArray)] byte[] data);

        /// <summary>
        /// Moves the instruction pointer forward by the specified number of elements, starting at the current position.
        /// </summary>
        /// <param name="count">Element count to skip.</param>
        [SecurityCritical]
        void Skip(int count);

        /// <summary>
        /// Moves the instruction pointer to the beginning of this <see cref="IEnumIDENTITY_ATTRIBUTE"/>.
        /// </summary>
        [SecurityCritical]
        void Reset();

        /// <summary>
        /// Gets an interface pointer to a new <see cref="IEnumIDENTITY_ATTRIBUTE"/> that contains the same members as this <see cref="IEnumIDENTITY_ATTRIBUTE"/>.
        /// </summary>
        /// <returns><see cref="IEnumIDENTITY_ATTRIBUTE"/> instance.</returns>
        [SecurityCritical]
        IEnumIDENTITY_ATTRIBUTE Clone();
    }
}
