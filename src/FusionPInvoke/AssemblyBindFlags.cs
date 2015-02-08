namespace FusionPInvoke
{
    /// <summary>
    /// Assembly binding flags.
    /// </summary>
    /// <remarks>External caller of <see cref="IAssemblyName.BindToObject"/> should only use <see cref="ParentAsmHint"/>,
    /// <see cref="None"/> and <see cref="InspectionOnly"/>.
    /// The rest is used internally by fusion. They can(and should) be set via <see cref="IApplicationContext.Set"/>.
    ///</remarks>
    public enum AssemblyBindFlags
    {
        None = 0x0,
        ForceCacheInstall = 0x1,
        RfsIntegrityCheck = 0x2,
        RfsModuleCheck = 0x4,
        BinpathProbeOnly = 0x8,
        //SharedBinpathHint             = 0x10,
        ParentAsmHint = 0x20,
        DisallowApplyPublishErPolicy = 0x40,
        DisallowAppBindingRedirects = 0x80,
        DisableFxUnification = 0x100,
        DoNotProbeNativeImage = 0x200,
        DisableDownload = 0x400,
        InspectionOnly = 0x800,
        DisallowAppBaseProbing = 0x1000
    }
}
