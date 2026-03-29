
#nullable enable

namespace Loudly
{
    public partial interface ILoudlyClient
    {
        /// <summary>
        /// Authorize using ApiKey authentication.
        /// </summary>
        /// <param name="apiKey"></param>
        public void AuthorizeUsingApiKeyInHeader(
            string apiKey);
    }
}