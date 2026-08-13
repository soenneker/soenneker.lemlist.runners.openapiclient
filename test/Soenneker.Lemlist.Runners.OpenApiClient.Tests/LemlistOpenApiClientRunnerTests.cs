using Soenneker.Tests.HostedUnit;

namespace Soenneker.Lemlist.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class LemlistOpenApiClientRunnerTests : HostedUnitTest
{
    public LemlistOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
