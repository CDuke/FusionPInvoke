using Xunit;
using Xunit.Extensions;

namespace FusionPInvoke.Tests
{
    public class CreateAssemblyEnumTests
    {
        [Theory]
        [InlineData(CreateAssemblyEnumFlags.Gac)]
        [InlineData(CreateAssemblyEnumFlags.Zap)]
        [InlineData(CreateAssemblyEnumFlags.Download)]
        public void WhenGetEnumThenMustReturnSuccessResult(CreateAssemblyEnumFlags flasg)
        {
            IAssemblyEnum assemblyEnum;
            var hresult = FusionNative.CreateAssemblyEnum(out assemblyEnum, null, null, flasg, 0);
            Assert.True(hresult);
            Assert.NotNull(assemblyEnum);
        }
    }
}
