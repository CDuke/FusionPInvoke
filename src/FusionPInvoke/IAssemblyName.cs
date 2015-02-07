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
        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT SetProperty(int PropertyId, IntPtr pvProperty, int cbProperty);

        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT GetProperty(int PropertyId, IntPtr pvProperty, ref int pcbProperty);

        /// <summary>
        /// Allows this IAssemblyName object to release resources and perform other cleanup operations before its destructor is called.
        /// </summary>
        /// <returns><see cref="HRESULT"/></returns>
        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT Finalize();

        /// <summary>
        /// Gets the human-readable name of the assembly referenced by this <see cref="IAssemblyName"/> object.
        /// </summary>
        /// <param name="displayName">Display name.</param>
        /// <param name="displayNameLength">Display name length.</param>
        /// <param name="flags">Flags <see cref="GetDisplayNameFlags"/>.</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT GetDisplayName(StringBuilder displayName, ref int displayNameLength, GetDisplayNameFlags flags);

        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT BindToObject(object refIID, object pAsmBindSink, IApplicationContext pApplicationContext,
            string szCodeBase, long llFlags, int pvReserved, int cbReserved, out int ppv);

        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT GetName(out int lpcwBuffer, out int pwzName);

        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT GetVersion(out int pdwVersionHi, out int pdwVersionLow);

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
        /// <returns><see cref="HRESULT"/></returns>
        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT Clone(out IAssemblyName assemblyName);
    }
}
