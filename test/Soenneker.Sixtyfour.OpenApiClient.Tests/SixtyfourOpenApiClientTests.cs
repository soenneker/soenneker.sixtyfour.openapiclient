using Soenneker.Tests.FixturedUnit;
using Xunit;

namespace Soenneker.Sixtyfour.OpenApiClient.Tests;

[Collection("Collection")]
public sealed class SixtyfourOpenApiClientTests : FixturedUnitTest
{
    public SixtyfourOpenApiClientTests(Fixture fixture, ITestOutputHelper output) : base(fixture, output)
    {
    }

    [Fact]
    public void Default()
    {

    }
}
