using Caching.Test.Model;
using Cactus.Blade.Caching;
using FluentAssertions;
using FluentAssertions.Common;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using Xunit;

namespace Caching.Test
{
    public class CachingTests
    {
        [Fact(DisplayName = "Caching should be initializable")]
        public void Caching_Should_Be_Initializable()
        {
            var target = new Cactus.Blade.Caching.Caching();
            target.Should().NotBeNull();
        }

        [Fact(DisplayName = "Caching should implement IDisposable")]
        public void Caching_Should_Implement_IDisposable()
        {
            Cactus.Blade.Caching.Caching caching = new Cactus.Blade.Caching.Caching();
            using Cactus.Blade.Caching.Caching target = caching;
            target.Should().NotBeNull();
        }

        [Fact(DisplayName = "Caching.Store() should persist simple string")]
        public void Caching_Store_Should_Persist_Simple_String()
        {
            var key = Guid.NewGuid().ToString();
            var expectedValue = "I-AM-GROOT";
            var storage = new Cactus.Blade.Caching.Caching();

            storage.Store(key, expectedValue);
            storage.Persist();

            var target = storage.Get(key);
            target.Should().BeOfType<string>();
            target.Should().Be(expectedValue);
        }

        [Fact(DisplayName = "Caching.Store() should persist simple DateTime as struct")]
        public void Caching_Store_Should_Persist_Simple_DateTime_As_Struct()
        {
            var key = Guid.NewGuid().ToString();
            var expectedValue = DateTime.Now;
            var storage = new Cactus.Blade.Caching.Caching();

            storage.Store(key, expectedValue);
            storage.Persist();

            var target = storage.Get<DateTime>(key);
            target.Should().Be(expectedValue);
        }

        [Fact(DisplayName = "Caching.Store() should persist and retrieve correct type")]
        public void Caching_Store_Should_Persist_And_Retrieve_Correct_Type()
        {
            var key = Guid.NewGuid().ToString();
            var value = (double)42.4m;
            var storage = new Cactus.Blade.Caching.Caching();

            storage.Store(key, value);
            storage.Persist();

            var target = storage.Get<double>(key);
            target.Should().Be(value);
        }

        [Fact(DisplayName = "Caching.Store() should persist multiple values")]
        public void Caching_Store_Should_Persist_Multiple_Values()
        {
            var key1 = Guid.NewGuid().ToString();
            var key2 = Guid.NewGuid().ToString();
            var key3 = Guid.NewGuid().ToString();
            var value1 = "It was the best of times, it was the worst of times.";
            var value2 = DateTime.Now;
            var value3 = int.MaxValue;
            var storage = new Cactus.Blade.Caching.Caching();

            storage.Store(key1, value1);
            storage.Store(key2, value2);
            storage.Store(key3, value3);
            storage.Persist();

            var target1 = storage.Get<string>(key1);
            var target2 = storage.Get<DateTime>(key2);
            var target3 = storage.Get<int>(key3);

            target1.Should().Be(value1);
            target2.Should().Be(value2);
            target3.Should().Be(value3);
        }

        [Fact(DisplayName = "Caching.Store() should overwrite existing key")]
        public void Caching_Store_Should_Overwrite_Existing_Key()
        {
            const string key = "I-Will-Be-Used-Twice";
            var storage = new Cactus.Blade.Caching.Caching();
            var original_value = new Joke { Id = 1, Text = "Yo mammo is so fat..." };
            storage.Store(key, original_value);
            storage.Persist();
            var expected_value = new Joke { Id = 2, Text = "... she left the house in high heels and when she came back she had on flip flops" };

            storage.Store(key, expected_value);
            storage.Persist();
            var target = storage.Get<Joke>(key);

            target.Should().NotBeNull();
            target.IsSameOrEqualTo(expected_value);
        }

        [Fact(DisplayName = "Caching.Clear() should clear all in-memory content")]
        public void Caching_Clear_Should_Clear_All_Content()
        {
            var storage = new Cactus.Blade.Caching.Caching();
            var key = Guid.NewGuid().ToString();
            var value = Guid.NewGuid();
            storage.Store(key, value);
            storage.Persist();

            storage.Clear();

            storage.Count.Should().Be(0);
        }

        [Fact(DisplayName = "Caching.Persist() should leave previous entries intact")]
        public void Caching_Persist_Should_Leave_Previous_Entries_Intact()
        {
            var storage = new Cactus.Blade.Caching.Caching();
            var key1 = Guid.NewGuid().ToString();
            var value1 = "Some kind of monster";
            storage.Store(key1, value1);
            storage.Persist();

            var key2 = Guid.NewGuid().ToString();
            var value2 = "Some kind of monster";
            storage.Store(key2, value2);
            storage.Persist();

            var target1 = storage.Get<string>(key1);
            var target2 = storage.Get<string>(key2);
            target1.Should().Be(value1);
            target2.Should().Be(value2);
        }

        [Fact(DisplayName = "Caching should remain intact between multiple instances")]
        public void Caching_Should_Remain_Intact_Between_Multiple_Instances()
        {
            var storage1 = new Cactus.Blade.Caching.Caching();
            var key1 = Guid.NewGuid().ToString();
            var value1 = "Robert Baratheon";
            storage1.Store(key1, value1);
            storage1.Persist();

            var storage2 = new Cactus.Blade.Caching.Caching();
            var key2 = Guid.NewGuid().ToString();
            var value2 = "Ned Stark";
            storage2.Store(key2, value2);
            storage2.Persist();

            var storage3 = new Cactus.Blade.Caching.Caching();
            var target1 = storage3.Get<string>(key1);
            var target2 = storage3.Get<string>(key2);
            target1.Should().Be(value1);
            target2.Should().Be(value2);
        }

        [Fact(DisplayName = "Caching should support unicode")]
        public void Caching_Store_Should_Support_Unicode()
        {
            var key = Guid.NewGuid().ToString();
            const string expectedValue = "Juliën's Special Characters: ~!@#$%^&*()œōøęsæ";
            var storage = new Cactus.Blade.Caching.Caching();

            storage.Store(key, expectedValue);
            storage.Persist();

            var target = storage.Get(key);
            target.Should().BeOfType<string>();
            target.Should().Be(expectedValue);
        }

        [Fact(DisplayName = "Caching should perform decently with large collections")]
        public void Caching_Should_Perform_Decently_With_Large_Collections()
        {
            var stopwatch = Stopwatch.StartNew();
            var storage = new Cactus.Blade.Caching.Caching();
            for (var i = 0; i < 100000; i++)
                storage.Store(Guid.NewGuid().ToString(), i);

            storage.Persist();

            var target = new Cactus.Blade.Caching.Caching();
            target.Clear();
            stopwatch.Stop();

            target.Destroy();

            stopwatch.ElapsedMilliseconds.Should().BeLessOrEqualTo(1000);
        }

        [Fact(DisplayName = "Caching should perform decently with many iterations collections")]
        public void Caching_Should_Perform_Decently_With_Many_Opens_And_Writes()
        {
            for (var i = 0; i < 1000; i++)
            {
                var storage = new Cactus.Blade.Caching.Caching();
                storage.Store(Guid.NewGuid().ToString(), i);
                storage.Persist();
            }

            var store = new Cactus.Blade.Caching.Caching();
            store.Destroy();
        }

        [Fact(DisplayName = "Caching.Exists() should locate existing key")]
        public void Caching_Exists_Should_Locate_Existing_Key()
        {
            var storage = new Cactus.Blade.Caching.Caching();
            var expected_key = Guid.NewGuid().ToString();
            storage.Store(expected_key, Guid.NewGuid().ToString());

            var target = storage.Exists(expected_key);

            target.Should().BeTrue();
        }

        [Fact(DisplayName = "Caching.Exists() should ignore non-existing key")]
        public void Caching_Exists_Should_Ignore_NonExisting_Key()
        {
            var storage = new Cactus.Blade.Caching.Caching();
            var nonexisting_key = Guid.NewGuid().ToString();

            var target = storage.Exists(nonexisting_key);

            target.Should().BeFalse();
        }

        [Fact(DisplayName = "Caching.Keys() should return collection of all keys")]
        public void Caching_Keys_Should_Return_Collection_Of_Keys()
        {
            var storage = new Cactus.Blade.Caching.Caching(TestHelpers.UniqueInstance());
            for (var i = 0; i < 10; i++)
                storage.Store(Guid.NewGuid().ToString(), i);
            var expected_keycount = storage.Count;

            var target = storage.Keys();

            target.Should().NotBeNullOrEmpty();
            target.Count.Should().Be(expected_keycount);
        }

        [Fact(DisplayName = "Caching.Keys() should return 0 on empty collection")]
        public void Caching_Keys_Should_Return_Zero_On_Empty_Collection()
        {
            var storage = new Cactus.Blade.Caching.Caching(TestHelpers.UniqueInstance());

            var target = storage.Keys();

            target.Should().NotBeNull();
            target.Should().BeEmpty();
            target.Count.Should().Be(0, because: "nothing is added to the Caching");
        }

        [Fact(DisplayName = "Caching.Query() should respect a provided predicate")]
        public void Caching_Query_Should_Respect_Provided_Predicate()
        {
            var collection = CarFactory.Create();
            var storage = new Cactus.Blade.Caching.Caching();
            var key = Guid.NewGuid().ToString();
            var expected_brand = "BMW";
            var expected_amount = collection.Count(c => c.Brand == expected_brand);
            storage.Store(key, collection);

            var target = storage.Query<Car>(key, c => c.Brand == expected_brand);

            target.Should().NotBeNull();
            target.Count().Should().Be(expected_amount);
            target.All(c => c.Brand == expected_brand);
        }

        [Fact(DisplayName = "Caching.Destroy() should delete file on disk")]
        public void Caching_Destroy_Should_Delete_File_On_Disk()
        {
            var random_filename = Guid.NewGuid().ToString("N");
            var filepath = Cactus.Blade.Caching.Helper.FileHelpers.GetLocalStoreFilePath(random_filename);
            var config = new CachingConfiguration()
            {
                Filename = random_filename
            };

            var storage = new Cactus.Blade.Caching.Caching(config);
            storage.Persist();

            storage.Destroy();

            File.Exists(filepath).Should().BeFalse();
        }
    }
}
