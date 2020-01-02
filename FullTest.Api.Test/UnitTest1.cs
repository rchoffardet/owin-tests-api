using System;
using System.Threading.Tasks;
using Microsoft.Owin.Testing;
using Newtonsoft.Json;
using NUnit.Framework;

namespace FullTest.Api.Test
{
    [TestFixture]
    public class UnitTest1
    {
        [Test]
        public async Task TestMethod1()
        {
            var server = TestServer.Create<Startup>();
            var response = await server.HttpClient.GetAsync("hello/Robin");
            var result = await response.Content.ReadAsStringAsync();
            var content = JsonConvert.DeserializeObject<string>(result);

            Assert.That(content, Is.EqualTo("Hello Robin!"));
        }
    }
}