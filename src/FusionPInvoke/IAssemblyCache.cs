using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace FusionPInvoke
{
    /// <summary>
    /// Represents the global assembly cache for use by the fusion technology.
    /// </summary>
    [Guid("e707dcde-d1cd-11d2-bab9-00c04f8eceae")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAssemblyCache
    {
        /// <summary>
        /// Uninstalls the specified assembly from the global assembly cache. If other applications hold no other references to the assembly, the files that make up the assembly are removed from the GAC.
        /// </summary>
        /// <param name="flags">Flags <see cref="UninstallAssemblyFlags"/>.</param>
        /// <param name="assemblyName">The name of the assembly to uninstall.</param>
        /// <param name="references">Contains the <see cref="InstallReference"/> tdata for the assembly. Although this is not recommended, this parameter can be null. The assembly is installed without an application reference, or all existing application references are gone.</param>
        /// <param name="disposition">Result of uninstalling assembly.</param>
        /// <returns>If assembly has been unistalled return <see cref="HRESULT.S_OK"/>, otherwise <see cref="HRESULT.S_FALSE"/> and the reason described in <see cref="disposition"/>.</returns>
        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT UninstallAssembly(UninstallAssemblyFlags flags,
            [MarshalAs(UnmanagedType.LPWStr)] string assemblyName,
            InstallReference[] references,
            out UninstallAssemblyResult disposition);

        /// <summary>
        /// Gets the requested data about the specified assembly.
        /// </summary>
        /// <param name="flags">Flags <see cref="QueryAssemblyInfoFlags"/>.</param>
        /// <param name="assemblyName">The name of the assembly for which data will be retrieved.</param>
        /// <param name="assemblyInfo">Contains data about the assembly.</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT QueryAssemblyInfo(int flags, [MarshalAs(UnmanagedType.LPWStr)] string assemblyName, ref AssemblyInfo assemblyInfo);

        /// <summary>
        /// Gets a reference to a new <see cref="IAssemblyCacheItem"/> object.
        /// </summary>
        /// <param name="flags">Flags <see cref="CreateAssemblyCacheItemFlags"/>.</param>
        /// <param name="reserved">Reserved for future extensibility, must be null.</param>
        /// <param name="assemblyCacheItem">The returned <see cref="IAssemblyCacheItem"/>.</param>
        /// <param name="assemblyName">Uncanonicalized, comma-separated name=value pairs.</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT CreateAssemblyCacheItem(CreateAssemblyCacheItemFlags flags, IntPtr reserved, out IAssemblyCacheItem assemblyCacheItem,
            [MarshalAs(UnmanagedType.LPWStr)] string assemblyName);

        /// <summary>
        /// Reserved for internal use by the fusion technology.
        /// </summary>
        /// <param name="scavenger">Return unknown object</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT CreateAssemblyScavenger([MarshalAs(UnmanagedType.IUnknown)] out object scavenger);

        /// <summary>
        /// Installs the specified assembly in the global assembly cache.
        /// </summary>
        /// <param name="flags">Install flags <see cref="InstallAssemblyFlags"/>.</param>
        /// <param name="manifestFilePath">The path to the manifest for the assembly to install.</param>
        /// <param name="reference">Contains <see cref="InstallReference"/>  that indicates the application on whose behalf the assembly is being installed. Although this is not recommended, this parameter can be null, but this leaves the assembly without any application reference.</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [MethodImpl(MethodImplOptions.PreserveSig)]
        HRESULT InstallAssembly(InstallAssemblyFlags flags, [MarshalAs(UnmanagedType.LPWStr)] string manifestFilePath, InstallReference[] reference);
    }
}
