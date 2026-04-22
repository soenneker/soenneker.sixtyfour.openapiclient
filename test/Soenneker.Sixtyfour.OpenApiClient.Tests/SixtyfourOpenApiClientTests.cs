using Soenneker.Tests.HostedUnit;

namespace Soenneker.Sixtyfour.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class SixtyfourOpenApiClientTests : HostedUnitTest
{
    public SixtyfourOpenApiClientTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
