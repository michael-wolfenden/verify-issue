namespace VerifyIssue.Tests;

public class VerifySpecs
{
    [Fact]
    public Task verify_is_configured_correctly() =>
        VerifyChecks.Run();
}