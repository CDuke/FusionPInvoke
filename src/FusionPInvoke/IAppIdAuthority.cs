using System;
using System.Runtime.InteropServices;
using System.Security;

namespace FusionPInvoke
{
    [Guid("8c87810c-2541-4f75-b2d0-9af515488e23")]
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    public interface IAppIdAuthority
    {
        [SecurityCritical]
        IDefinitionAppId TextToDefinition(int flags, string identity);

        [SecurityCritical]
        IReferenceAppId TextToReference(int flags, string identity);

        [SecurityCritical]
        string DefinitionToText(int flags, IDefinitionAppId definitionAppId);

        [SecurityCritical]
        string ReferenceToText(int flags, IReferenceAppId referenceAppId);

        [SecurityCritical]
        bool AreDefinitionsEqual(int flags, IDefinitionAppId definition1, IDefinitionAppId definition2);

        [SecurityCritical]
        bool AreReferencesEqual(int flags, IReferenceAppId reference1, IReferenceAppId reference2);

        [SecurityCritical]
        bool AreTextualDefinitionsEqual(int flags, string appIdLeft, string appIdRight);

        [SecurityCritical]
        bool AreTextualReferencesEqual(int flags, string appIdLeft, string appIdRight);

        [SecurityCritical]
        bool DoesDefinitionMatchReference(int flags, IDefinitionAppId definitionIdentity, IReferenceAppId referenceIdentity);

        [SecurityCritical]
        bool DoesTextualDefinitionMatchTextualReference(int flags, string definition, string reference);

        [SecurityCritical]
        HRESULT HashReference(int flags, IReferenceAppId referenceIdentity);

        [SecurityCritical]
        UInt64 HashDefinition(int flags, IDefinitionAppId definitionIdentity);

        [SecurityCritical]
        string GenerateDefinitionKey(int flags, IDefinitionAppId definitionIdentity);

        [SecurityCritical]
        string GenerateReferenceKey(int flags, IReferenceAppId referenceIdentity);

        [SecurityCritical]
        IDefinitionAppId CreateDefinition();

        [SecurityCritical]
        IReferenceAppId CreateReference();
    }
}
