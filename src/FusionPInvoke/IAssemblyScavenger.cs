using System.Runtime.InteropServices;

namespace FusionPInvoke
{
    [InterfaceType(ComInterfaceType.InterfaceIsIUnknown)]
    [Guid("21b8916c-f28e-11d2-a473-00ccff8ef448")]
    public interface IAssemblyScavenger
    {
        HRESULT  ScavengeAssemblyCache();

        HRESULT GetCacheDiskQuotas(out int pdwZapQuotaInGAC, out int pdwDownloadQuotaAdmin, out int pdwDownloadQuotaUser);

        HRESULT SetCacheDiskQuotas(int dwZapQuotaInGAC, int dwDownloadQuotaAdmin, int dwDownloadQuotaUser);

        HRESULT  GetCurrentCacheUsage(out int dwZapUsage, out int dwDownloadUsage);
    }
}
