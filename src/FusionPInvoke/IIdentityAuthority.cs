using System.Runtime.InteropServices;
using System.Security;

namespace FusionPInvoke
{
    [Guid("261a6983-c35d-4d0d-aa5b-7867259e77bc")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IIdentityAuthority
    {
        [SecurityCritical]
        IDefinitionIdentity TextToDefinition(int flags, [MarshalAs(UnmanagedType.LPWStr)] string identity);

        [SecurityCritical]
        IReferenceIdentity TextToReference(int flags, [MarshalAs(UnmanagedType.LPWStr)] string identity);

        [SecurityCritical]
        string DefinitionToText(int flags, IDefinitionIdentity definitionIdentity);

        [SecurityCritical]
        int DefinitionToTextBuffer(int flags, IDefinitionIdentity definitionIdentity, int bufferSize, [Out, MarshalAs(UnmanagedType.LPArray)] char[] buffer);

        [SecurityCritical]
        string ReferenceToText(int flags, IReferenceIdentity referenceIdentity);

        [SecurityCritical]
        int ReferenceToTextBuffer(int flags, IReferenceIdentity referenceIdentity, int bufferSize, [Out, MarshalAs(UnmanagedType.LPArray)] char[] buffer);

        [SecurityCritical]
        bool AreDefinitionsEqual(int flags, IDefinitionIdentity definition1, IDefinitionIdentity definition2);

        [SecurityCritical]
        bool AreReferencesEqual(int flags, IReferenceIdentity reference1, IReferenceIdentity reference2);

        [SecurityCritical]
        bool AreTextualDefinitionsEqual(int flags, [MarshalAs(UnmanagedType.LPWStr)] string identityLeft, [MarshalAs(UnmanagedType.LPWStr)] string identityRight);

        [SecurityCritical]
        bool AreTextualReferencesEqual(int flags, [MarshalAs(UnmanagedType.LPWStr)] string identityLeft, [MarshalAs(UnmanagedType.LPWStr)] string identityRight);

        [SecurityCritical]
        bool DoesDefinitionMatchReference(int flags, IDefinitionIdentity definitionIdentity, IReferenceIdentity referenceIdentity);

        [SecurityCritical]
        bool DoesTextualDefinitionMatchTextualReference(int flags, [MarshalAs(UnmanagedType.LPWStr)] string definition, [MarshalAs(UnmanagedType.LPWStr)] string reference);

        [SecurityCritical]
        int HashReference(int flags, IReferenceIdentity referenceIdentity);

        [SecurityCritical]
        int HashDefinition(int flags, IDefinitionIdentity definitionIdentity);

        [SecurityCritical]
        string GenerateDefinitionKey(int flags, IDefinitionIdentity definitionIdentity);

        [SecurityCritical]
        string GenerateReferenceKey(int flags, IReferenceIdentity referenceIdentity);

        [SecurityCritical]
        IDefinitionIdentity CreateDefinition();

        [SecurityCritical]
        IReferenceIdentity CreateReference();
    }
}
