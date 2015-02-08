using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;

namespace FusionPInvoke
{
    /// <summary>
    /// Provides methods for describing and working with an assembly's unique identity.
    /// </summary>
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("CD193BC0-B4BC-11d2-9833-00C04FC31D2E")]
    public interface IAssemblyName
    {
        /// <summary>
        /// Sets the value of the property referenced by the specified property identifier.
        /// </summary>
        /// <param name="propertyId">The unique identifier of the property whose value will be set.</param>
        /// <param name="property">The value to which to set the property referenced by <see cref="propertyId"/>.</param>
        /// <param name="propertySize">The size, in bytes, of <paramref name="property"/>.</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT SetProperty(AssemblyPropertyId propertyId, [MarshalAs(UnmanagedType.LPArray)] byte[] property, int propertySize);

        /// <summary>
        /// Gets the property referenced by the specified property identifier.
        /// </summary>
        /// <param name="propertyId">The unique identifier for the requested property.</param>
        /// <param name="property">The returned property data.</param>
        /// <param name="propertySize">The size, in bytes, of <paramref name="property"/>.</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT GetProperty(AssemblyPropertyId propertyId,[MarshalAs(UnmanagedType.LPArray)] byte[] property, ref int propertySize);

        /// <summary>
        /// Allows this IAssemblyName object to release resources and perform other cleanup operations before its destructor is called.
        /// </summary>
        /// <returns><see cref="HRESULT"/></returns>
        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT Finalize();

        /// <summary>
        /// Gets the human-readable name of the assembly referenced by this <see cref="IAssemblyName"/> object.
        /// </summary>
        /// <param name="displayName">A buffer to hold the name of the referenced assembly.</param>
        /// <param name="displayNameLength">The size of <paramref name="displayName"/> in wide characters, including the null terminator character.</param>
        /// <param name="flags">Flags <see cref="GetDisplayNameFlags"/>.</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT GetDisplayName([Out] StringBuilder displayName, ref int displayNameLength, GetDisplayNameFlags flags);

        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT BindToObject(Guid referenceInterfaceId, IAssemblyScavenger assemblymBindingSink, IApplicationContext applicationContext,
            [MarshalAs(UnmanagedType.LPWStr)] string codeBase, AssemblyBindFlags flags, int reserved, int reservedSize, out IntPtr ppv);

        /// <summary>
        /// Gets the simple, unencrypted name of the assembly referenced by this <see cref="IAssemblyName"/> object.
        /// </summary>
        /// <param name="nameLength">The size of <paramref name="name"/> in wide characters, including the null terminator character.</param>
        /// <param name="name">A buffer to hold the name of the referenced assembly.</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT GetName(ref int nameLength, [Out] StringBuilder name);

        /// <summary>
        /// Gets the version information for the assembly referenced by this <see cref="IAssemblyName"/> object.
        /// </summary>
        /// <param name="versionHi">The high 32 bits of the version.</param>
        /// <param name="versionLow">The low 32 bits of the version.</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT GetVersion(out int versionHi, out int versionLow);

        /// <summary>
        /// Determines whether a specified IAssemblyName object is equal to this IAssemblyName, based on the specified comparison flags.
        /// </summary>
        /// <param name="assemblyName"></param>
        /// <param name="flags"></param>
        /// <returns></returns>
        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT IsEqual(IAssemblyName assemblyName, AssemblyNameEqualsFlags flags);

        /// <summary>
        /// Creates a shallow copy of this <see cref="IAssemblyName"/> object.
        /// </summary>
        /// <param name="assemblyName">Assembly name.</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT Clone(out IAssemblyName assemblyName);
    }
}
