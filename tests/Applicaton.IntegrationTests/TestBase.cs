using NUnit.Framework;
using System.Threading.Tasks;

namespace ca_sln_media_health.Application.IntegrationTests
{
    using static Testing;

    public class TestBase
    {
        [SetUp]
        public async Task TestSetUp()
        {
            await ResetState();
        }
    }
}
