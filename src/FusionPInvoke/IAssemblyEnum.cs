using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FusionPInvoke
{
    /// <summary>
    /// Represents an enumerator for an array of IAssemblyName objects.
    /// </summary>
    [Guid("21b8916c-f28e-11d2-a473-00c04f8ef448")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAssemblyEnum
    {
        /// <summary>
        /// Gets the next <see cref="IAssemblyName"/> contained in this <see cref="IAssemblyEnum"/> object.
        /// </summary>
        /// <param name="applicationContext">Application context.</param>
        /// <param name="assemblyName">Assembly name.</param>
        /// <param name="flags">Flasg <see cref="GetNextAssemblyFlags"/>.</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT GetNextAssembly(out IApplicationContext applicationContext, out IAssemblyName assemblyName, GetNextAssemblyFlags flags);

        /// <summary>
        /// Resets this IAssemblyEnum object to its starting position.
        /// </summary>
        /// <returns><see cref="HRESULT"/>.</returns>
        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT Reset();

        /// <summary>
        /// Creates a shallow copy of this <see cref="IAssemblyEnum"/> object.
        /// </summary>
        /// <param name="assemblyEnum">Cloned assembly enum.</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT Clone(out IAssemblyEnum assemblyEnum);
    }
}
