using System;
using System.Runtime.InteropServices;
using System.Text;

namespace FusionPInvoke
{
    /// <summary>
    /// Provide function from fusion.dll.
    /// </summary>
    public static class FusionNative
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
        [DllImport("Fusion.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern HRESULT CreateAssemblyEnum(out IAssemblyEnum assemblyEnum,
            IApplicationContext applicationContext, IAssemblyName assemblyName, CreateAssemblyEnumFlags flags, int reserved);

        /// <summary>
        /// Get <see cref="IAssemblyName"/> instance that represents the unique identity of the assembly with the specified name.
        /// </summary>
        /// <param name="assemblyNameInstance"></param>
        /// <param name="assemblyName">The name of the assembly for which to create the new <see cref="IAssemblyName"/> instance.</param>
        /// <param name="flags">Flasg <see cref="CreateAssemblyNameObjectFlags"/>.</param>
        /// <param name="reserved">Reserved for future extensibility, must be a 0 (zero).</param>
        /// <returns>If this function succeeds, it returns <see cref="HRESULT.S_OK"/>. Otherwise, it returns an HRESULT error code..</returns>
        [DllImport("Fusion.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern HRESULT CreateAssemblyNameObject(out IAssemblyName assemblyNameInstance, string assemblyName, CreateAssemblyNameObjectFlags flags, int reserved);

        /// <summary>
        /// Get <see cref="IAssemblyCache"/> instance that represents the global assembly cache.
        /// </summary>
        /// <param name="assemblyCache">Returned assembly cache.</param>
        /// <param name="reserved">Reserved for future extensibility, must be 0 (zero).</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [DllImport("Fusion.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern HRESULT CreateAssemblyCache(out IAssemblyCache assemblyCache, int reserved);

        /// <summary>
        /// Gets an <see cref="IInstallReferenceEnum"/> instance that represents a list of an application's references to the specified assembly.
        /// </summary>
        /// <param name="installReferenceEnum">The returned IInstallReferenceEnum.</param>
        /// <param name="assemblyName">The <see cref="IAssemblyName"/> that identifies the assembly for which to enumerate references.</param>
        /// <param name="flags">Flags <see cref="CreateInstallReferenceEnum"/>.</param>
        /// <param name="reserved">Reserved for future extensibility, must be 0 (zero).</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [DllImport("Fusion.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern HRESULT CreateInstallReferenceEnum(out IInstallReferenceEnum installReferenceEnum, IAssemblyName assemblyName,
            CreateInstallReferenceFlags flags, int reserved);

        /// <summary>
        /// Gets the path to the cached assembly, using the specified flags.
        /// </summary>
        /// <param name="flags">Flags <see cref="GetCachePathFlags"/>.</param>
        /// <param name="cachePath">Returned cache path.</param>
        /// <param name="cachePathLength">Cache path length.</param>
        /// <returns>If <paramref name="cachePath"/> has not enough length return <see cref="HRESULT.E_INSUFFICIENT_BUFFER"/> error and <paramref name="cachePathLength"/> has needed buffer length, otherwise return <see cref="HRESULT.S_OK"/>.</returns>
        [DllImport("Fusion.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern HRESULT GetCachePath(GetCachePathFlags flags,[MarshalAs(UnmanagedType.LPWStr)] StringBuilder cachePath, ref int cachePathLength);

        /// <summary>
        /// Clears the global assembly cache of downloaded assemblies.
        /// </summary>
        /// <returns><see cref="HRESULT"/>.</returns>
        [DllImport("Fusion.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern HRESULT ClearDownloadCache();

        /// <summary>
        /// This function supports the .NET Framework infrastructure and is not intended to be used directly from your code.
        /// </summary>
        /// <param name="assemblyName">Friendly name.</param>
        /// <param name="applicationContext">Application context.</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [DllImport("Fusion.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern HRESULT CreateApplicationContext(IAssemblyName assemblyName, out IApplicationContext applicationContext);

//        /// <summary>
//        /// Creates a history reader for the specified file.
//        /// </summary>
//        /// <param name="filePath">The file path.</param>
//        /// <param name="historyReader">History reader</param>
//        /// <returns><see cref="HRESULT"/>.</returns>
//        [DllImport("Fusion.dll", CharSet = CharSet.Unicode, SetLastError = true)]
//        public static extern HRESULT CreateHistoryReader(string filePath, out IHistoryReader historyReader);

        /// <summary>
        /// Get IUnknown object with the specified IID in the assembly at the specified file path.
        /// </summary>
        /// <param name="filePath">A valid path to the requested assembly.</param>
        /// <param name="interfaceId">Interface guid.</param>
        /// <returns>Object.</returns>
        [DllImport("Fusion.dll", CharSet = CharSet.Unicode, SetLastError = true, PreserveSig = false)]
        [return: MarshalAs(UnmanagedType.IUnknown)]
        public static extern object GetAssemblyIdentityFromFile([MarshalAs(UnmanagedType.LPWStr)] string filePath, ref Guid interfaceId);

        /// <summary>
        /// Gets an IAppIdAuthority instance that manages keys for application identities and references.
        /// </summary>
        /// <param name="appIdAuthority">The returned <see cref="IAppIdAuthority"/>.</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [DllImport("Fusion.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern HRESULT GetAppIdAuthority(out IAppIdAuthority appIdAuthority);

        /// <summary>
        /// Retrieves the path of the application history directory.
        /// </summary>
        /// <param name="dir">Path to the application history directory.</param>
        /// <param name="dirLength">Length of <paramref name="dir"/>.</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        [DllImport("Fusion.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern HRESULT GetHistoryFileDirectory(StringBuilder dir, ref int dirLength);

        /// <summary>
        /// Gets an <see cref="IIdentityAuthority"/> instance that manages keys for code objects.
        /// </summary>
        /// <returns>Return <see cref="IIdentityAuthority"/>.</returns>
        [DllImport("Fusion.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern IIdentityAuthority GetIdentityAuthority();

        /// <summary>
        /// Gets a value that indicates whether the specified assembly is managed.
        /// </summary>
        /// <param name="assemblyReference">The name of the assembly to check.</param>
        /// <param name="isFrameworkAssembly">A Boolean value that indicates whether the assembly is managed.</param>
        /// <param name="frameworkAssemblyIdentity"> An uncanonicalized string that contains the unique identity of the assembly.</param>
        /// <param name="frameworkAssemblyIdentityLength">The length of <paramref name="frameworkAssemblyIdentity"/>.</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        /// <remarks>If this assembly is part of the .NET Framework, the <paramref name="isFrameworkAssembly"/> parameter will contain a Boolean value of true.
        /// If the named assembly is not part of the .NET Framework, or if the <paramref name="assemblyReference"/> parameter does not name an assembly, <paramref name="isFrameworkAssembly"/> will contain a Boolean value of false.</remarks>
        [DllImport("Fusion.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern HRESULT IsFrameworkAssembly(string assemblyReference, out bool isFrameworkAssembly,
            string frameworkAssemblyIdentity, int frameworkAssemblyIdentityLength);

        /// <summary>
        /// Deletes the common language runtime (CLR) download cache.
        /// </summary>
        /// <returns><see cref="HRESULT"/>.</returns>
        /// <remarks>The CLR download cache is the area where strong-named assemblies that are downloaded from a URL are stored for possible reuse.</remarks>
        [DllImport("Fusion.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern HRESULT NukeDownloadedCache();

        /// <summary>
        /// Gets the post-policy display name for an assembly. This function supports the .NET Framework infrastructure and is not intended to be used directly from your code.
        /// </summary>
        /// <param name="applicationContext">Identifies the application context.</param>
        /// <param name="assemblyName">Identifies the assembly name.</param>
        /// <param name="parentAssembly">Identifies the parent assembly. This parameter is ignored.</param>
        /// <param name="runtimeVersion">Identifies the runtime version.</param>
        /// <param name="namePostPolicy">Contains the post-policy display name.</param>
        /// <param name="reserved"> Reserved for future extensibility, must be 0 (zero).</param>
        /// <returns><see cref="HRESULT"/>.</returns>
        /// <remarks>The <paramref name="namePostPolicy"/> output parameter is set only if the function returns <see cref="HRESULT.FUSION_E_REF_DEF_MISMATCH"/>. Otherwise, it is null.</remarks>
        [DllImport("Fusion.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern HRESULT PreBindAssemblyEx(IApplicationContext applicationContext,
            IAssemblyName assemblyName,
            IntPtr parentAssembly, string runtimeVersion, out IAssemblyName namePostPolicy, int reserved);

        /// <summary>
        /// Compares two assembly identities to determine whether they are equivalent.
        /// </summary>
        /// <param name="assemblyIdentity1">The textual identity of the first assembly in the comparison.</param>
        /// <param name="unified1"> Boolean flag that indicates user-specified unification for <paramref name="assemblyIdentity1"/>.</param>
        /// <param name="assemblyIdentity2"> The textual identity of the second assembly in the comparison.</param>
        /// <param name="unified2">A Boolean flag that indicates user-specified unification for <paramref name="assemblyIdentity2"/>.</param>
        /// <param name="equivalent">A Boolean flag that indicates whether the two assemblies are equivalent.</param>
        /// <param name="comparisonResult">An <see cref="AssemblyComparisonResult"/> enumeration that contains detailed information about the comparison.</param>
        /// <returns></returns>
        [DllImport("Fusion.dll", CharSet = CharSet.Unicode, SetLastError = true)]
        public static extern HRESULT CompareAssemblyIdentity(string assemblyIdentity1, bool unified1,
            string assemblyIdentity2, bool unified2,
            out bool equivalent, out AssemblyComparisonResult comparisonResult);
    }
}
