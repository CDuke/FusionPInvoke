using System;
using System.Runtime.InteropServices;
using System.Text;
using Xunit;

namespace FusionPInvoke.Tests
{
    public class AssemblyCacheTests
    {
        private const string MscorlibName = "mscorlib";

        [Fact]
        public void GivenAssemblyExistsInGac_WhenQueryAssemblyInfo_ThenInfoReturned()
        {
            var assemblyCache = GetGlobalAssemblyCache();

            var assemblyInfo = new AssemblyInfo();
            assemblyInfo.StructureSize = Marshal.SizeOf(typeof(AssemblyInfo));
            var hResult = assemblyCache.QueryAssemblyInfo(QueryAssemblyInfoFlags.None, MscorlibName, ref assemblyInfo);
            if (hResult.InsufficientBuffer)
            {
                assemblyInfo.AssemblyPath = new string('\0', assemblyInfo.AssemblyPathLength);
                hResult = assemblyCache.QueryAssemblyInfo(QueryAssemblyInfoFlags.None, MscorlibName, ref assemblyInfo);
                Assert.True(hResult);
            }
        }

        [Fact]
        public void WhenCreateAssemblyScavenger_ThenScavengerReturned()
        {
            var assemblyCache = GetGlobalAssemblyCache();

            IAssemblyScavenger assemblyScavenger;
            var hResult = assemblyCache.CreateAssemblyScavenger(out assemblyScavenger);
            Assert.True(hResult);
            Assert.NotNull(assemblyScavenger);
        }

        private static IAssemblyCache GetGlobalAssemblyCache()
        {
            IAssemblyCache assemblyCache;
            var hResult = FusionNative.CreateAssemblyCache(out assemblyCache, 0);
            Assert.True(hResult);

            return assemblyCache;
        }
    }
}
