using System;
using Xunit;
using Xunit.Extensions;

namespace FusionPInvoke.Tests
{
    public class AssemblyEnumTests
    {
        [Theory]
        [InlineData(CreateAssemblyEnumFlags.Gac)]
        [InlineData(CreateAssemblyEnumFlags.Zap)]
        [InlineData(CreateAssemblyEnumFlags.Download)]
        public void GetNextMustReturnAtLeastOneAssembly(CreateAssemblyEnumFlags flags)
        {
            IAssemblyEnum assemblyEnum;
            var hresult = FusionNative.CreateAssemblyEnum(out assemblyEnum, null, null, flags, 0);
            Assert.True(hresult);

            IApplicationContext applicationContext;
            IAssemblyName assemblyName;
            hresult = assemblyEnum.GetNextAssembly(out applicationContext, out assemblyName, GetNextAssemblyFlags.None);
            Assert.True(hresult);
            Assert.NotNull(assemblyName);
        }

        [Theory]
        [InlineData(CreateAssemblyEnumFlags.Gac)]
        [InlineData(CreateAssemblyEnumFlags.Zap)]
        [InlineData(CreateAssemblyEnumFlags.Download)]
        public void ResetNotImplemented(CreateAssemblyEnumFlags flags)
        {
            IAssemblyEnum assemblyEnum;
            var hresult = FusionNative.CreateAssemblyEnum(out assemblyEnum, null, null, flags, 0);
            Assert.True(hresult);

            IApplicationContext applicationContext;
            IAssemblyName firstAssemblyName;
            hresult = assemblyEnum.GetNextAssembly(out applicationContext, out firstAssemblyName, GetNextAssemblyFlags.None);
            Assert.True(hresult);
            Assert.NotNull(firstAssemblyName);

            hresult = assemblyEnum.Reset();
            Assert.Throws<NotImplementedException>(() => (bool)hresult);
        }
    }
}
