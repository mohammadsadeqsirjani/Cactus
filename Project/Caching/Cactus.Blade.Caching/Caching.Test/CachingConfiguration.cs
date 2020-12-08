using FluentAssertions;
using System;
using System.IO;
using Xunit;

namespace Caching.Test
{
    public class CachingConfigurationTest
    {
        [Fact(DisplayName = "Caching should not be initializable with null for configuration")]
        public void Caching_Should_Not_Be_Initializable_With_Argument_Null()
        {
            Assert.Throws<ArgumentNullException>(() =>
            {
                var target = new Cactus.Blade.Caching.Caching(null);
            });
        }

        [Fact(DisplayName = "CachingConfiguration should respect custom filename")]
        public void CachingConfiguration_Should_Respect_Custom_Filename()
        {
            var random_filename = Guid.NewGuid().ToString("N");
            var config = new Cactus.Blade.Caching.CachingConfiguration()
            {
                Filename = random_filename
            };

            var storage = new Cactus.Blade.Caching.Caching(config);
            storage.Persist();
            var target = Cactus.Blade.Caching.Helper.FileHelpers.GetLocalStoreFilePath(random_filename);

            File.Exists(target).Should().BeTrue();

            storage.Destroy();
        }

        [Fact(DisplayName = "CachingConfiguration.AutoLoad should load persisted state when enabled")]
        public void CachingConfiguration_AutoLoad_Should_Load_Previous_State_OnLoad()
        {
        }

        [Fact(DisplayName = "CachingConfiguration.AutoLoad should skip loading persisted state when disabled")]
        public void CachingConfiguration_AutoLoad_Should_Skip_Loading_Previous_State_OnLoad()
        {

        }

        [Fact(DisplayName = "CachingConfiguration.AutoSave should save changes to disk when enabled")]
        public void CachingConfiguration_AutoSave_Should_Persist_When_Enabled()
        {

        }

        [Fact(DisplayName = "CachingConfiguration.AutoSave should not save changes to disk when disabled")]
        public void CachingConfiguration_AutoSave_Should_Not_Persist_When_Disabled()
        {

        }
    }
}
