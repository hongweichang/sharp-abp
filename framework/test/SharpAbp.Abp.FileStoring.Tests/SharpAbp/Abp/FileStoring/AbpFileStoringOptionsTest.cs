﻿using SharpAbp.Abp.FileStoring.Fakes;
using SharpAbp.Abp.FileStoring.TestObjects;
using Xunit;

namespace SharpAbp.Abp.FileStoring
{
    public class AbpFileStoringOptionsTest : AbpFileStoringTestBase
    {
        private readonly IFileContainerConfigurationProvider _configurationProvider;

        public AbpFileStoringOptionsTest()
        {
            _configurationProvider = GetRequiredService<IFileContainerConfigurationProvider>();
        }

        [Fact]
        public void Should_Property_Set_And_Get_Options_For_Different_Containers()
        {

            var testContainer1Config = _configurationProvider.Get<TestContainer1>();

            Assert.Equal(nameof(FakeFileProvider1), testContainer1Config.Provider);
            Assert.Equal("TestValue1", testContainer1Config.GetConfigurationOrDefault<string>("TestConfig1"));
            Assert.Equal("TestValueDefault", testContainer1Config.GetConfigurationOrDefault<string>("TestConfigDefault"));


            var testContainer2Config = _configurationProvider.Get<TestContainer2>();
            Assert.Equal(nameof(FakeFileProvider2), testContainer2Config.Provider);
            Assert.Equal("TestValue2", testContainer2Config.GetConfigurationOrDefault<string>("TestConfig2"));
            Assert.Equal("TestValueDefault", testContainer2Config.GetConfigurationOrDefault<string>("TestConfigDefault"));
        }

        [Fact]
        public void Should_Fallback_To_Default_Configuration_If_Not_Specialized()
        {
            var config = _configurationProvider.Get<TestContainer3>();
            Assert.Equal(nameof(FakeFileProvider1), config.Provider);
            Assert.Equal("TestValueDefault", config.GetConfigurationOrNull("TestConfigDefault"));
        }
    }
}
