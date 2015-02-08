using System;
using System.Text;
using Xunit;

namespace FusionPInvoke.Tests
{
    public class AssemblyNameTests
    {
        private const string MscorlibStrongName = "mscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089";
        private const string MscorlibName = "mscorlib";

        [Fact]
        public void WhenClone_ThenMustReturnSame()
        {
            var assemblyEnum = GetGacAssemblyEnum();

            IApplicationContext applicationContext;
            IAssemblyName firstAssemblyName;
            var hresult = assemblyEnum.GetNextAssembly(out applicationContext, out firstAssemblyName, GetNextAssemblyFlags.None);
            Assert.True(hresult);
            Assert.NotNull(firstAssemblyName);

            IAssemblyName clonedAssembly;
            hresult = firstAssemblyName.Clone(out clonedAssembly);
            Assert.True(hresult);
            var equals = firstAssemblyName.IsEqual(clonedAssembly, AssemblyNameEqualsFlags.All);
            Assert.True(equals);
        }

        [Fact]
        public void WhenGetVersion_ShoulReturnVersion()
        {
            var mscorlibAssemblyName = GetMscorlib();

            int hiVersion;
            int lowVersion;
            var hresult = mscorlibAssemblyName.GetVersion(out hiVersion, out lowVersion);
            Assert.True(hresult, "Couldn't read assembly version");

            var version = ToVersion(hiVersion, lowVersion);
            Assert.Equal(version.Major, 4);
            Assert.Equal(version.Minor, 0);
            Assert.Equal(version.Build, 0);
            Assert.Equal(version.Revision, 0);
        }

        [Fact]
        public void WhenGetStrongName_ShouldReturnStrongName()
        {
            var mscorlibAssemblyName = GetMscorlib();
            var lenght = 0;
            var flags = GetDisplayNameFlags.Full;
            var hresult = mscorlibAssemblyName.GetDisplayName(null, ref lenght, flags);
            if (hresult.InsufficientBuffer)
            {
                var strongName = new StringBuilder(lenght);
                hresult = mscorlibAssemblyName.GetDisplayName(strongName, ref lenght, flags);
                Assert.True(hresult);

                Assert.Equal(MscorlibStrongName, strongName.ToString());
            }
        }

        [Fact]
        public void WhenGetName_ShouldReturnName()
        {
            var mscorlibAssemblyName = GetMscorlib();
            var lenght = 0;
            var hresult = mscorlibAssemblyName.GetName(ref lenght, null);
            if (hresult.InsufficientBuffer)
            {
                var name = new StringBuilder(lenght);
                hresult = mscorlibAssemblyName.GetName(ref lenght, name);
                Assert.True(hresult);

                Assert.Equal(MscorlibName, name.ToString());
            }
        }

        [Fact]
        public void WhenGetNameProperty_ShouldReturnName()
        {
            var mscorlibAssemblyName = GetMscorlib();
            var propertyId = AssemblyPropertyId.Name;
            var size = 0;
            var hresult = mscorlibAssemblyName.GetProperty(propertyId, null, ref size);
            if (hresult.InsufficientBuffer)
            {
                var nameBuffer = new byte[size];
                hresult = mscorlibAssemblyName.GetProperty(propertyId, nameBuffer, ref size);
                Assert.True(hresult);

                var name = Encoding.Unicode.GetString(nameBuffer, 0, size - 2);
                Assert.Equal(MscorlibName, name);
            }
        }

        private static IAssemblyEnum GetGacAssemblyEnum(IAssemblyName assemblyName = null)
        {
            const CreateAssemblyEnumFlags flags = CreateAssemblyEnumFlags.Zap;
            IAssemblyEnum assemblyEnum;
            var hresult = FusionNative.CreateAssemblyEnum(out assemblyEnum, null, assemblyName, flags, 0);
            Assert.True(hresult, "Couldn't create assembly enum object");
            return assemblyEnum;
        }

        static IAssemblyName GetMscorlib()
        {
            IAssemblyName assemblyName;
            var hresult = FusionNative.CreateAssemblyNameObject(out assemblyName, MscorlibStrongName,
                CreateAssemblyNameObjectFlags.CanofParseDispayName, 0);
            Assert.True(hresult, "Couldn't create assembly name object");

            var assemblyEnum = GetGacAssemblyEnum(assemblyName);

            IApplicationContext applicationContext;
            hresult = assemblyEnum.GetNextAssembly(out applicationContext, out assemblyName, GetNextAssemblyFlags.None);
            Assert.True(hresult, "Couldn't read next assembly name object");

            return assemblyName;
        }

        private static Version ToVersion(int hiVersion, int lowVersion)
        {
            return new Version(hiVersion >> 16, hiVersion & 0xffff, lowVersion >> 16, lowVersion & 0xffff);
        }
    }
}
