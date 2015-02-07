using System.Runtime.InteropServices;
using System.Text;

namespace FusionPInvoke
{
    /// <summary>
    /// Provide function from fusion.dll.
    /// </summary>
    public static class Fusion
    {
        /// <summary>
        /// Gets a an IAssemblyEnum instance that can enumerate the objects in the assembly with the specified IAssemblyName.
        /// </summary>
        /// <param name="assemblyEnum">Assembly enum.</param>
        /// <param name="applicationContext">Application context.</param>
        /// <param name="assemblyName">This name is used to filter the enumeration. It can be null to enumerate all assemblies in the global assembly cache.</param>
        /// <param name="flags">Flags for modifying the enumerator's behavior.</param>
        /// <param name="reserved">Reserved for future extensibility, must be 0.</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [DllImport("Fusion.dll", CharSet = CharSet.Auto)]
        public static extern HRESULT CreateAssemblyEnum(out IAssemblyEnum assemblyEnum,
            IApplicationContext applicationContext, IAssemblyName assemblyName, CreateAssemblyEnumFlags flags, int reserved);

        /// <summary>
        /// Get <see cref="IAssemblyName"/> instance that represents the unique identity of the assembly with the specified name.
        /// </summary>
        /// <param name="assemblyNameInstance"></param>
        /// <param name="assemblyName">The name of the assembly for which to create the new <see cref="IAssemblyName"/> instance.</param>
        /// <param name="flags">Flasg <see cref="CreateAssemblyNameObjectFlags"/>.</param>
        /// <param name="reserved">Reserved for future extensibility, must be a 0 (zero).</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [DllImport("fusion.dll")]
        public static extern HRESULT CreateAssemblyNameObject(out IAssemblyName assemblyNameInstance, string assemblyName, CreateAssemblyNameObjectFlags flags, int reserved);

        /// <summary>
        /// Get <see cref="IAssemblyCache"/> instance that represents the global assembly cache.
        /// </summary>
        /// <param name="assemblyCache">Returned assembly cache.</param>
        /// <param name="reserved">Reserved for future extensibility, must be 0 (zero).</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [DllImport("fusion.dll")]
        public static extern HRESULT CreateAssemblyCache(out IAssemblyCache assemblyCache, int reserved);

        /// <summary>
        /// Gets an <see cref="IInstallReferenceEnum"/> instance that represents a list of an application's references to the specified assembly.
        /// </summary>
        /// <param name="installReferenceEnum">The returned IInstallReferenceEnum.</param>
        /// <param name="assemblyName">The <see cref="IAssemblyName"/> that identifies the assembly for which to enumerate references.</param>
        /// <param name="flags">Flags <see cref="CreateAssemblyCacheItemFlags"/>.</param>
        /// <param name="reserved">Reserved for future extensibility, must be 0 (zero).</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [DllImport("fusion.dll")]
        public static extern HRESULT CreateInstallReferenceEnum(out IInstallReferenceEnum installReferenceEnum, IAssemblyName assemblyName,
            CreateAssemblyCacheItemFlags flags, int reserved);

        /// <summary>
        /// Gets the path to the cached assembly, using the specified flags.
        /// </summary>
        /// <param name="flags">Flags <see cref="GetCachePathFlags"/>.</param>
        /// <param name="cachePath">Returned cache path.</param>
        /// <param name="cachePathLength">Chane path length.</param>
        /// <returns></returns>
        [DllImport("fusion.dll")]
        public static extern HRESULT GetCachePath(GetCachePathFlags flags, [MarshalAs(UnmanagedType.LPWStr)] string cachePath, ref int cachePathLength);
    }
}
