
#nullable enable

namespace Loudly
{
    public sealed partial class LoudlyClient
    {
        /// <inheritdoc/>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey)
        {
            apiKey = apiKey ?? throw new global::System.ArgumentNullException(nameof(apiKey));

            Authorizations.Clear();
            Authorizations.Add(new global::Loudly.EndPointAuthorization
            {
                Type = "ApiKey",
                Location = "Header",
                Name = "API-KEY",
                Value = apiKey,
            });
        }
    }
}