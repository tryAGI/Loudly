
#nullable enable

namespace Loudly
{
    public partial class AiClient
    {
        partial void PrepareGenerateAiSongArguments(
            global::System.Net.Http.HttpClient httpClient,
            global::Loudly.GenerateAiSongRequest request);
        partial void PrepareGenerateAiSongRequest(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpRequestMessage httpRequestMessage,
            global::Loudly.GenerateAiSongRequest request);
        partial void ProcessGenerateAiSongResponse(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage);

        partial void ProcessGenerateAiSongResponseContent(
            global::System.Net.Http.HttpClient httpClient,
            global::System.Net.Http.HttpResponseMessage httpResponseMessage,
            ref string content);

        /// <summary>
        /// Generate AI song (parameter-based)<br/>
        /// Generates an AI song based on provided parameters such as genre, genre_blend,<br/>
        /// duration, energy, bpm, key_root, key_quality, instruments, and structure_id.
        /// </summary>
        /// <param name="request"></param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::Loudly.ApiException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loudly.AiSong> GenerateAiSongAsync(

            global::Loudly.GenerateAiSongRequest request,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            request = request ?? throw new global::System.ArgumentNullException(nameof(request));

            PrepareArguments(
                client: HttpClient);
            PrepareGenerateAiSongArguments(
                httpClient: HttpClient,
                request: request);

            var __pathBuilder = new global::Loudly.PathBuilder(
                path: "/b2b/ai/songs",
                baseUri: HttpClient.BaseAddress); 
            var __path = __pathBuilder.ToString();
            using var __httpRequest = new global::System.Net.Http.HttpRequestMessage(
                method: global::System.Net.Http.HttpMethod.Post,
                requestUri: new global::System.Uri(__path, global::System.UriKind.RelativeOrAbsolute));
#if NET6_0_OR_GREATER
            __httpRequest.Version = global::System.Net.HttpVersion.Version11;
            __httpRequest.VersionPolicy = global::System.Net.Http.HttpVersionPolicy.RequestVersionOrHigher;
#endif

            foreach (var __authorization in Authorizations)
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
            using var __httpRequestContent = new global::System.Net.Http.MultipartFormDataContent();
            __httpRequestContent.Add(
                content: new global::System.Net.Http.StringContent($"{request.Genre}"),
                name: "\"genre\"");
            if (request.GenreBlend != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.GenreBlend}"),
                    name: "\"genre_blend\"");
            } 
            if (request.Duration != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Duration}"),
                    name: "\"duration\"");
            } 
            if (request.Energy != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Energy?.ToValueString()}"),
                    name: "\"energy\"");
            } 
            if (request.Bpm != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.Bpm}"),
                    name: "\"bpm\"");
            } 
            if (request.KeyRoot != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.KeyRoot?.ToValueString()}"),
                    name: "\"key_root\"");
            } 
            if (request.KeyQuality != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.KeyQuality?.ToValueString()}"),
                    name: "\"key_quality\"");
            } 
            if (request.Instruments != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"[{string.Join(",", global::System.Linq.Enumerable.Select(request.Instruments, x => x))}]"),
                    name: "\"instruments\"");
            } 
            if (request.StructureId != default)
            {

                __httpRequestContent.Add(
                    content: new global::System.Net.Http.StringContent($"{request.StructureId}"),
                    name: "\"structure_id\"");
            }
            __httpRequest.Content = __httpRequestContent;

            PrepareRequest(
                client: HttpClient,
                request: __httpRequest);
            PrepareGenerateAiSongRequest(
                httpClient: HttpClient,
                httpRequestMessage: __httpRequest,
                request: request);

            using var __response = await HttpClient.SendAsync(
                request: __httpRequest,
                completionOption: global::System.Net.Http.HttpCompletionOption.ResponseContentRead,
                cancellationToken: cancellationToken).ConfigureAwait(false);

            ProcessResponse(
                client: HttpClient,
                response: __response);
            ProcessGenerateAiSongResponse(
                httpClient: HttpClient,
                httpResponseMessage: __response);
            // Bad request (e.g. invalid genre).
            if ((int)__response.StatusCode == 400)
            {
                string? __content_400 = null;
                global::System.Exception? __exception_400 = null;
                global::Loudly.Error? __value_400 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_400 = global::Loudly.Error.FromJson(__content_400, JsonSerializerContext);
                    }
                    else
                    {
                        __content_400 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_400 = global::Loudly.Error.FromJson(__content_400, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_400 = __ex;
                }

                throw new global::Loudly.ApiException<global::Loudly.Error>(
                    message: __content_400 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_400,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_400,
                    ResponseObject = __value_400,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }
            // Internal server error (e.g. rate limit exceeded).
            if ((int)__response.StatusCode == 500)
            {
                string? __content_500 = null;
                global::System.Exception? __exception_500 = null;
                global::Loudly.Error? __value_500 = null;
                try
                {
                    if (ReadResponseAsString)
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
                        __value_500 = global::Loudly.Error.FromJson(__content_500, JsonSerializerContext);
                    }
                    else
                    {
                        __content_500 = await __response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);

                        __value_500 = global::Loudly.Error.FromJson(__content_500, JsonSerializerContext);
                    }
                }
                catch (global::System.Exception __ex)
                {
                    __exception_500 = __ex;
                }

                throw new global::Loudly.ApiException<global::Loudly.Error>(
                    message: __content_500 ?? __response.ReasonPhrase ?? string.Empty,
                    innerException: __exception_500,
                    statusCode: __response.StatusCode)
                {
                    ResponseBody = __content_500,
                    ResponseObject = __value_500,
                    ResponseHeaders = global::System.Linq.Enumerable.ToDictionary(
                        __response.Headers,
                        h => h.Key,
                        h => h.Value),
                };
            }

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
                ProcessGenerateAiSongResponseContent(
                    httpClient: HttpClient,
                    httpResponseMessage: __response,
                    content: ref __content);

                try
                {
                    __response.EnsureSuccessStatusCode();

                    return
                        global::Loudly.AiSong.FromJson(__content, JsonSerializerContext) ??
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
                        await global::Loudly.AiSong.FromJsonStreamAsync(__content, JsonSerializerContext).ConfigureAwait(false) ??
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
        /// <summary>
        /// Generate AI song (parameter-based)<br/>
        /// Generates an AI song based on provided parameters such as genre, genre_blend,<br/>
        /// duration, energy, bpm, key_root, key_quality, instruments, and structure_id.
        /// </summary>
        /// <param name="genre">
        /// The main genre or subgenre. Use GET /b2b/ai/genres to see available genres and micro-genres.
        /// </param>
        /// <param name="genreBlend">
        /// A secondary genre to blend with the main genre. Use GET /b2b/ai/genres to see available genres.
        /// </param>
        /// <param name="duration">
        /// Desired song duration in seconds. Must be between 30 and 420.
        /// </param>
        /// <param name="energy">
        /// Energy level of the generated song.
        /// </param>
        /// <param name="bpm">
        /// Tempo in BPM. For optimal results, choose a value in the recommended range from GET /b2b/ai/genres.
        /// </param>
        /// <param name="keyRoot">
        /// The root note of the musical key.
        /// </param>
        /// <param name="keyQuality">
        /// The quality of the musical key.
        /// </param>
        /// <param name="instruments">
        /// A list of instruments to include. Available instruments depend on the selected genre<br/>
        /// and are found in GET /b2b/ai/genres. Instruments can be repeated for multiple instances.
        /// </param>
        /// <param name="structureId">
        /// Choose a structure from GET /b2b/ai/structures.
        /// </param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        public async global::System.Threading.Tasks.Task<global::Loudly.AiSong> GenerateAiSongAsync(
            string genre,
            string? genreBlend = default,
            int? duration = default,
            global::Loudly.GenerateAiSongRequestEnergy? energy = default,
            int? bpm = default,
            global::Loudly.GenerateAiSongRequestKeyRoot? keyRoot = default,
            global::Loudly.GenerateAiSongRequestKeyQuality? keyQuality = default,
            global::System.Collections.Generic.IList<string>? instruments = default,
            int? structureId = default,
            global::System.Threading.CancellationToken cancellationToken = default)
        {
            var __request = new global::Loudly.GenerateAiSongRequest
            {
                Genre = genre,
                GenreBlend = genreBlend,
                Duration = duration,
                Energy = energy,
                Bpm = bpm,
                KeyRoot = keyRoot,
                KeyQuality = keyQuality,
                Instruments = instruments,
                StructureId = structureId,
            };

            return await GenerateAiSongAsync(
                request: __request,
                cancellationToken: cancellationToken).ConfigureAwait(false);
        }
    }
}