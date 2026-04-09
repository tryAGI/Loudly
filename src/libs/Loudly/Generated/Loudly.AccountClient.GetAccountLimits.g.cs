
#nullable enable

namespace Loudly
{
    public partial class AccountClient
    {


        private static readonly global::Loudly.EndPointSecurityRequirement s_GetAccountLimitsSecurityRequirement0 =
            new global::Loudly.EndPointSecurityRequirement
            {
                Authorizations = new global::Loudly.EndPointAuthorizationRequirement[]
                {                    new global::Loudly.EndPointAuthorizationRequirement
                    {
                        Type = "ApiKey",
                        Location = "Header",
                        Name = "API-KEY",
                        FriendlyName = "ApiKeyInHeader",
                    },
                },
            };
        private static readonly global::Loudly.EndPointSecurityRequirement[] s_GetAccountLimitsSecurityRequirements =
            new global::Loudly.EndPointSecurityRequirement[]
            {                s_GetAccountLimitsSecurityRequirement0,
            };
        partial void PrepareGetAccountLimitsArguments(
            global::System.Net.Http.HttpClient httpClient,
            ref global::System.DateTime? dateFrom,
            ref global::System.DateTime? dateTo);
        partial void PrepareGetAccountLimitsRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::System.DateTime? dateFrom,
            global::System.DateTime? dateTo);
        partial void ProcessGetAccountLimitsResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGetAccountLimitsResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Check usage limits<br/>
        /// Retrieves the usage limits, how much has been used, and how much is left,<br/>
        /// optionally filtered by a date range.
        /// </summary>
        /// <param name="dateFrom"></param>
        /// <param name="dateTo"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loudly.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::System.Collections.Generic.IList<global::Loudly.UsageLimit>> GetAccountLimitsAsync(
            global::System.DateTime? dateFrom = default,
            global::System.DateTime? dateTo = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            PrepareArguments(
                client: HttpClient);
            PrepareGetAccountLimitsArguments(
                httpClient: HttpClient,
                dateFrom: ref dateFrom,
                dateTo: ref dateTo);


            var __authorizations = global::Loudly.EndPointSecurityResolver.ResolveAuthorizations(
                availableAuthorizations: Authorizations,
                securityRequirements: s_GetAccountLimitsSecurityRequirements,
                operationName: "GetAccountLimitsAsync");

            var __pathBuilder = new global::Loudly.PathBuilder(
                path: "/b2b/account/limits",
                baseUri: HttpClient.BaseAddress); 
            __pathBuilder
                .AddOptionalParameter("date_from", dateFrom?.ToString("yyyy-MM-dd"))
                .AddOptionalParameter("date_to", dateTo?.ToString("yyyy-MM-dd")) 
                ;
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Get,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in __authorizations)
            {
                if (__authorization.Type == "Http" ||
                    __authorization.Type == "OAuth2")
                {
                    __httpRequest.Headers.Authorization = new global::System.Net.Http.Headers.AuthenticationHeaderValue(
                        scheme: __authorization.Name,
                        parameter: __authorization.Value);
                }
                else if (__authorization.Type == "ApiKey" &&
                         __authorization.Location == "Header")
                {
                    __httpRequest.Headers.Add(__authorization.Name, __authorization.Value);
                }
            }

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGetAccountLimitsRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                dateFrom: dateFrom,
                dateTo: dateTo);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGetAccountLimitsResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);

            if (ReadResponseAsString)
            {
                var __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                    cancellationToken
#endif
                ).ConfigureAwait(false);

                ProcessResponseContent(
                    client: HttpClient,
                    response: __response,
                    content: ref __content);
                ProcessGetAccountLimitsResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        (global::System.Collections.Generic.IList<global::Loudly.UsageLimit>?)global::System.Text.Json.JsonSerializer.Deserialize(__content, typeof(global::System.Collections.Generic.IList<global::Loudly.UsageLimit>), JsonSerializerContext) ??
                        throw new global::System.InvalidOperationException($"Response deserialization failed for \"{__content}\" ");
                }
                catch (global::System.Exception __ex)
                {
                    throw new global::Loudly.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
            else
            {
                try
                {
                    __response.EnsureSuccessStatusCode();
                    using var __content = await __response.Content.ReadAsStreamAsync(
#if NET5_0_OR_GREATER
                        cancellationToken
#endif
                    ).ConfigureAwait(false);

                    return
                        (global::System.Collections.Generic.IList<global::Loudly.UsageLimit>?)await global::System.Text.Json.JsonSerializer.DeserializeAsync(__content, typeof(global::System.Collections.Generic.IList<global::Loudly.UsageLimit>), JsonSerializerContext).ConfigureAwait(false) ??
                        throw new global::System.InvalidOperationException("Response deserialization failed.");
                }
                catch (global::System.Exception __ex)
                {
                    string? __content = null;
                    try
                    {
                        __content = await __response.Content.ReadAsStringAsync(
#if NET5_0_OR_GREATER
                            cancellationToken
#endif
                        ).ConfigureAwait(false);
                    }
                    catch (global::System.Exception)
                    {
                    }

                    throw new global::Loudly.ApiException(
                        message: __content ?? __response.ReasonPhrase ?? string.Empty,
                        innerException: __ex,
                        statusCode: __response.StatusCode)
                    {
                        ResponseBody = __content,
                        ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                            __response.Headers,
                            h => h.Key,
                            h => h.Value),
                    };
                }
            }
        }
    }
}