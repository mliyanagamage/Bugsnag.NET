using System;
using Bugsnag.PCL.Request;
using Newtonsoft.Json;
using NUnit.Framework;

namespace Bugsnag.PCL.Tests
{
    class EventTests
    {
        static JsonSerializerSettings _settings = new JsonSerializerSettings
        {
            NullValueHandling = NullValueHandling.Ignore
        };

        [Test]
        public void Does_Event_Serialize_With_Null_Device()
        {
            var evt = new Event(new Exception("Test"))
            {
                App = new App() { ReleaseStage = "development", Version = "0.0.0" }
            };

            var json = JsonConvert.SerializeObject(evt, _settings);
        }
    }
}
