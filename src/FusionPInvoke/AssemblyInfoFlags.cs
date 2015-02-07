using System;

namespace FusionPInvoke
{
    /// <summary>
    /// Flags that indicate installation details about the assembly.
    /// </summary>
    [Flags]
    public enum AssemblyInfoFlags
    {
        /// <summary>
        /// Indicates that the assembly is installed. The current version of the .NET Framework always sets <see cref="AssemblyInfo.AssemblyFlags"/> to this value.
        /// </summary>
        Installed,

        /// <summary>
        /// Indicates that the assembly is a payload resident. The current version of the .NET Framework never sets <see cref="AssemblyInfo.AssemblyFlags"/> to this value.
        /// </summary>
        PayLoadResident
    }
}
