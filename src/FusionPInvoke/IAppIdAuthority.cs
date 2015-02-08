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
        IDefinitionAppId TextToDefinition(int flags, [MarshalAs(UnmanagedType.LPWStr)] string identity);

        [SecurityCritical]
        IReferenceAppId TextToReference(int flags, [MarshalAs(UnmanagedType.LPWStr)] string identity);

        [SecurityCritical]
        [return:MarshalAs(UnmanagedType.LPWStr)]
        string DefinitionToText(int flags, IDefinitionAppId definitionAppId);

        [SecurityCritical]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        string ReferenceToText(int flags, IReferenceAppId referenceAppId);

        [SecurityCritical]
        [return: MarshalAs(UnmanagedType.Bool)]
        bool AreDefinitionsEqual(int flags, IDefinitionAppId definition1, IDefinitionAppId definition2);

        [SecurityCritical]
        [return: MarshalAs(UnmanagedType.Bool)]
        bool AreReferencesEqual(int flags, IReferenceAppId reference1, IReferenceAppId reference2);

        [SecurityCritical]
        [return: MarshalAs(UnmanagedType.Bool)]
        bool AreTextualDefinitionsEqual(int flags, [MarshalAs(UnmanagedType.LPWStr)] string appIdLeft, [MarshalAs(UnmanagedType.LPWStr)] string appIdRight);

        [SecurityCritical]
        [return: MarshalAs(UnmanagedType.Bool)]
        bool AreTextualReferencesEqual(int flags, [MarshalAs(UnmanagedType.LPWStr)] string appIdLeft, [MarshalAs(UnmanagedType.LPWStr)] string appIdRight);

        [SecurityCritical]
        [return: MarshalAs(UnmanagedType.Bool)]
        bool DoesDefinitionMatchReference(int flags, IDefinitionAppId definitionIdentity, IReferenceAppId referenceIdentity);

        [SecurityCritical]
        [return: MarshalAs(UnmanagedType.Bool)]
        bool DoesTextualDefinitionMatchTextualReference(int flags, [MarshalAs(UnmanagedType.LPWStr)] string definition, [MarshalAs(UnmanagedType.LPWStr)] string reference);

        [SecurityCritical]
        int HashReference(int flags, IReferenceAppId referenceIdentity);

        [SecurityCritical]
        int HashDefinition(int flags, IDefinitionAppId definitionIdentity);

        [SecurityCritical]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        string GenerateDefinitionKey(int flags, IDefinitionAppId definitionIdentity);

        [SecurityCritical]
        [return: MarshalAs(UnmanagedType.LPWStr)]
        string GenerateReferenceKey(int flags, IReferenceAppId referenceIdentity);

        [SecurityCritical]
        IDefinitionAppId CreateDefinition();

        [SecurityCritical]
        IReferenceAppId CreateReference();
    }
}
