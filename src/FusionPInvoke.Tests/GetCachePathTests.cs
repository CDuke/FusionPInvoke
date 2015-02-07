using System;
using System.IO;
using System.Text;
using Xunit;

namespace FusionPInvoke.Tests
{
    public class GetCachePathTests
    {
        [Fact]
        public void MustReturnRightsPaths()
        {
            var gacPathLength = 0;

            var flags = GetCachePathFlags.Gac;
            var hResult = Fusion.GetCachePath(flags, null, ref gacPathLength);
            if (hResult.InsufficientBuffer)
            {
                var gacPath = new StringBuilder(gacPathLength);
                hResult = Fusion.GetCachePath(flags, gacPath, ref gacPathLength);

                Assert.True(hResult);
                var expectedPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "assembly", "GAC");
                Assert.Equal(expectedPath, gacPath.ToString(), StringComparer.OrdinalIgnoreCase);
            }
        }
    }
}
