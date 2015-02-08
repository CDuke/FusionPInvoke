using System.Reflection;
using Xunit;

namespace FusionPInvoke.Tests
{
    public class GetAssemblyIdentityFromFileTests
    {
        [Fact]
        public void GivenAssemblyExists_WhenGetReferenceIdentity_ShouldReturnObject()
        {
            var guid = typeof (IReferenceIdentity).GUID;
            var path = Assembly.GetExecutingAssembly().Location;
            var refIdentity = FusionNative.GetAssemblyIdentityFromFile(path, ref guid) as IReferenceIdentity;

            Assert.NotNull(refIdentity);
        }
    }
}
