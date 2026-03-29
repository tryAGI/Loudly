namespace Loudly.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static LoudlyClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("LOUDLY_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("LOUDLY_API_KEY environment variable is not found.");

        var client = new LoudlyClient(apiKey);
        
        return client;
    }
}
