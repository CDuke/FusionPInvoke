namespace FusionPInvoke
{
    /// <summary>
    /// Indicates the equivalence of two assembly identities, as determined by the <see cref="FusionNative.CompareAssemblyIdentity"/> function.
    /// </summary>
    public enum AssemblyComparisonResult
    {
        /// <summary>
        /// Indicates that the reason for non-equivalency is not known.
        /// </summary>
        Unknown = 0,

        /// <summary>
        /// Indicates that all assembly fields in the comparison match.
        /// </summary>
        EquivalentFullMatch = 1,

        /// <summary>
        /// Indicates a match between two simply named assemblies whose version numbers were ignored.
        /// </summary>
        EquivalentWeakNamed = 2,

        /// <summary>
        /// Indicates that assemblies are considered equivalent based on the common language runtime version (CLR) unification of assembly version numbers in the .NET Framework version 2.0.
        /// </summary>
        EquivalentFXUnified = 3,

        /// <summary>
        /// Indicates that assemblies are considered equivalent based on the CLR unification of version numbers in legacy versions of the .NET Framework.
        /// </summary>
        EquivalentUnified = 4,

        /// <summary>
        /// Indicates that the two assemblies match except for their version numbers, which do not match.
        /// </summary>
        NonEquivalentVersion = 5,

        /// <summary>
        /// Indicates that no match occurred between the two assemblies.
        /// </summary>
        NonEquivalent = 6,

        /// <summary>
        /// Indicates a partial match of the assemblies.
        /// </summary>
        EquivalentPartialMatch = 7,

        /// <summary>
        /// Indicates a partial match of simply named assemblies.
        /// </summary>
        EquivalentPartialWeakNamed = 8,

        /// <summary>
        /// Indicates a partial match of the assemblies based on legacy unification of version numbers.
        /// </summary>
        EquivalentPartialUnified = 9,

        /// <summary>
        /// Indicates a partial match of the assemblies based on the CLR unification of assembly version numbers in the .NET Framework 2.0.
        /// </summary>
        EquivalentPartialFXUnified = 10,

        /// <summary>
        /// Indicates that the two assemblies match except for their version numbers, which match only partially.
        /// </summary>
        NonEquivalentPartialVersion = 11
    }
}
