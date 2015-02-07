using System;
using System.IO;
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
            if (gacPathLength > 0)
            {
                var gacPath = new string('\0', gacPathLength);
                hResult = Fusion.GetCachePath(flags, gacPath, ref gacPathLength);

                Assert.True(hResult);
                var expectedPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "assembly", "GAC") + '\0';
                Assert.Equal(expectedPath, gacPath.Trim(), StringComparer.OrdinalIgnoreCase);
            }
        }
    }
}
