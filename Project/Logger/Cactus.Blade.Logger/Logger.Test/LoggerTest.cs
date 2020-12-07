﻿//using System;
//using System.Collections.Generic;
//using System.Threading;
//using System.Threading.Tasks;

//namespace Logger.Test
//{
//    public class LoggerTest
//    {
//        public LoggerTest(ITestOutputHelper output)
//        {
//            Logger.RegisterWriter(d =>
//            {
//                output.WriteLine(d.ToString());
//            });
//        }

//        [Fact]
//        public void LogMessage()
//        {
//            var k = 42;
//            var l = 100;

//            Logger.Trace().Message("Sample trace message, k={0}, l={1}", k, l).Write();
//            Logger.Debug().Message("Sample debug message, k={0}, l={1}", k, l).Write();
//            Logger.Info().Message("Sample informational message, k={0}, l={1}", k, l).Write();
//            Logger.Warn().Message("Sample warning message, k={0}, l={1}", k, l).Write();
//            Logger.Error().Message("Sample error message, k={0}, l={1}", k, l).Write();
//            Logger.Fatal().Message("Sample fatal error message, k={0}, l={1}", k, l).Write();
//            Logger.Log(LogLevel.Info).Message("Sample fatal error message, k={0}, l={1}", k, l).Write();
//            Logger.Log(() => LogLevel.Info).Message("Sample fatal error message, k={0}, l={1}", k, l).Write();
//        }

//        [Fact]
//        public void LogInfoProperty()
//        {
//            var k = 42;
//            var l = 100;

//            Logger.Info()
//                .Message("Sample informational message, k={0}, l={1}", k, l)
//                .Property("Test", "Tesing properties")
//                .Write();
//        }

//        [Fact]
//        public void LogError()
//        {
//            var path = "blah.txt";
//            try
//            {
//                string text = File.ReadAllText(path);
//            }
//            catch (Exception ex)
//            {
//                Logger.Error()
//                    .Message("Error reading file '{0}'.", path)
//                    .Exception(ex)
//                    .Property("Test", "ErrorWrite")
//                    .Write();
//            }
//        }

//        [Fact]
//        public void LogThreadProperty()
//        {
//            var w1 = new ManualResetEvent(false);
//            var w2 = new ManualResetEvent(false);

//            LogData d1 = null;
//            LogData d2 = null;

//            var l = 100;
//            Logger.GlobalProperties.Set("L", l.ToString());

//            var t1 = new Thread(o =>
//            {
//                var k = 41;

//                using (var state = Logger.ThreadProperties.Set("K", k))
//                {

//                    var builder = Logger.Info();

//                    builder
//                        .Message("Sample informational message, k={0}, l={1}", k, l)
//                        .Property("Test", "Testing properties");


//                    d1 = builder.LogData;

//                }

//                w1.Set();
//            });


//            var t2 = new Thread(o =>
//            {
//                var k = 42;

//                Logger.ThreadProperties.Set("K", k);


//                var builder = Logger.Info();

//                builder
//                    .Message("Sample informational message, k={0}, l={1}", k, l)
//                    .Property("Test", "Testing properties");


//                d2 = builder.LogData;

//                Logger.ThreadProperties.Remove("K");

//                w2.Set();
//            });


//            t1.Start();
//            t2.Start();

//            w1.WaitOne();
//            w2.WaitOne();


//            d1.Should().NotBeNull();

//            var k1 = d1.Properties["K"];
//            k1.Should().Be(41);

//            d2.Should().NotBeNull();

//            var k2 = d2.Properties["K"];
//            k2.Should().Be(42);

//            var l1 = d1.Properties["L"];
//            var l2 = d2.Properties["L"];

//            l1.Should().Be(l2);
//        }

//        [Fact]
//        public void LoggerFromClass()
//        {
//            var logger = Logger.CreateLogger<LoggerTest>();

//            var k = 42;
//            var l = 100;

//            logger.Info()
//                .Message("Sample informational message from class, k={0}, l={1}", k, l)
//                .Property("Test", "Tesing properties")
//                .Write();

//        }

//        [Fact]
//        public void LoggerWithDefaultProperty()
//        {
//            var logger = Logger.CreateLogger(c => c.Logger<LoggerTest>().Property("Default", "All Logs Have This"));

//            var k = 42;
//            var l = 100;

//            var builder = logger.Info()
//                .Message("Sample informational message with default property, k={0}, l={1}", k, l)
//                .Property("Test", "Tesing properties");


//            builder.LogData.Properties.Count.Should().BeGreaterOrEqualTo(2);

//            builder.Write();

//        }

//#if !PORTABLE && !NETSTANDARD1_3 && !NETSTANDARD1_6
//        [Fact]
//        public async void LoggerAsyncProperty()
//        {
//            // properties set outside of async/await should be passed into async call
//            Logger.AsyncProperties.Set("Async", 13);

//            // thread-local context is lost on async/await
//            Logger.ThreadProperties.Set("Thread", 23);

//            LogData d1 = null;

//            Func<Task> action = async () =>
//            {
//                await Task.Yield();

//                Logger.AsyncProperties.Set("Inner", 97);

//                var v = Logger.AsyncProperties.Get("Async");
//                var t = Logger.ThreadProperties.Get("Thread");

//                v.Should().Be(13);

//                var builder = Logger.Info();

//                builder
//                    .Message("Sample informational message")
//                    .Property("Test", "Testing properties");


//                d1 = builder.LogData;
//            };
//            await action().ConfigureAwait(false);

//            // check log data got async property
//            d1.Should().NotBeNull();

//            var a1 = d1.Properties["Async"];
//            a1.Should().Be(13);

//            // check async property still valid after await
//            var i1 = Logger.AsyncProperties.Get("Async");
//            i1.Should().Be(13);

//            var i2 = Logger.AsyncProperties.Get("Inner");
//            i2.Should().Be(97);
//        }
//#endif
//    }
//}
