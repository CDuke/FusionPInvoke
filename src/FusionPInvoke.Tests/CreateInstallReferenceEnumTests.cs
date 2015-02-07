using Xunit;

namespace FusionPInvoke.Tests
{
    public class CreateInstallReferenceEnumTests
    {
        [Fact]
        public void FactMethodName()
        {
            IAssemblyEnum assemblyEnum;
            Assert.True(FusionNative.CreateAssemblyEnum(out assemblyEnum, null, null, CreateAssemblyEnumFlags.Gac, 0));

            IApplicationContext applicationContext;
            IAssemblyName assemblyName;
            Assert.True(assemblyEnum.GetNextAssembly(out applicationContext, out assemblyName, GetNextAssemblyFlags.None));

            IInstallReferenceEnum installReferenceEnum;
            Assert.True(FusionNative.CreateInstallReferenceEnum(out installReferenceEnum, assemblyName,
                CreateInstallReferenceEnum.None, 0));
            Assert.NotNull(installReferenceEnum);
        }
    }
}
