using Xunit;

namespace FusionPInvoke.Tests
{
    public class CreateAssemblyNameObjectTests
    {
        [Fact]
        public void GivenAssemblyName_WhenCreateAssemblyName_ThenReturnSuccess()
        {
            IAssemblyName assemblyNameInstance;
            var hResult = FusionNative.CreateAssemblyNameObject(out assemblyNameInstance,
                "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089",
                CreateAssemblyNameObjectFlags.CanofParseDispayName, 0);

            Assert.True(hResult);
        }
    }
}
