
#nullable enable

namespace LangSmith
{
    public sealed partial class LangSmithClient
    {
        /// <inheritdoc cref="LangSmithClient(global::System.Net.Http.HttpClient?, global::System.Uri?, global::System.Collections.Generic.List{global::LangSmith.EndPointAuthorization}?, bool)"/>

        public LangSmithClient(
            string apiKey,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::LangSmith.EndPointAuthorization>? authorizations = null,
            bool disposeHttpClient = true) : this(httpClient, baseUri, authorizations, disposeHttpClient)
        {
            Authorizing(HttpClient, ref apiKey);

            AuthorizeUsingApiKeyInHeader(apiKey);

            Authorized(HttpClient);
        }

        partial void Authorizing(
            global::System.Net.Http.HttpClient client,
            ref string apiKey);
        partial void Authorized(
            global::System.Net.Http.HttpClient client);


        private static readonly string[] s_authorizationEnvironmentVariables = new string[]
        {            "LANGSMITH_API_KEY",
        };

        private static readonly string[] s_baseUrlEnvironmentVariables = new string[]
        { 
        };

        /// <summary>
        /// Creates an authenticated LangSmithClient by resolving the configured credential environment variables.
        /// </summary>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, configured base URL environment variables are checked before using the OpenAPI default.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>

        public static LangSmithClient CreateFromEnvironment(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::LangSmith.EndPointAuthorization>? authorizations = null,
            global::LangSmith.AutoSDKClientOptions? options = null,
            bool disposeHttpClient = true)
        {
            var credentialValue = GetFirstEnvironmentVariableValue(
                s_authorizationEnvironmentVariables,
                out _);
            if (credentialValue is null)
            {
                throw new global::System.InvalidOperationException(
                    "No non-empty credential environment variable value was found. Checked: LANGSMITH_API_KEY.");
            }

            string apiKey = credentialValue;
            if (baseUri is null)
            {
                baseUri = ResolveEnvironmentBaseUriOrThrow();
            }

            var client = new LangSmithClient(
                httpClient,
                baseUri,
                authorizations,
                options,
                disposeHttpClient);

            client.Authorizing(client.HttpClient, ref apiKey);
            client.AuthorizeUsingApiKeyInHeader(apiKey);
            client.Authorized(client.HttpClient);

            return client;
        }

        /// <summary>
        /// Tries to create an authenticated LangSmithClient by resolving the configured credential environment variables.
        /// </summary>
        /// <param name="client">The created client when a non-empty credential and valid base URL environment value are available; otherwise null.</param>
        /// <param name="httpClient">The HttpClient instance. If not provided, a new one will be created.</param>
        /// <param name="baseUri">The base URL for the API. If not provided, configured base URL environment variables are checked before using the OpenAPI default.</param>
        /// <param name="authorizations">The authorizations to use for the requests.</param>
        /// <param name="options">Client-wide request defaults such as headers, query parameters, retries, and timeout.</param>
        /// <param name="disposeHttpClient">Dispose the HttpClient when the instance is disposed. True by default.</param>

        public static bool TryCreateFromEnvironment(
            out LangSmithClient? client,
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null,
            global::System.Collections.Generic.List<global::LangSmith.EndPointAuthorization>? authorizations = null,
            global::LangSmith.AutoSDKClientOptions? options = null,
            bool disposeHttpClient = true)
        {
            client = null;

            var credentialValue = GetFirstEnvironmentVariableValue(
                s_authorizationEnvironmentVariables,
                out _);
            if (credentialValue is null)
            {
                return false;
            }

            string apiKey = credentialValue;
            if (baseUri is null && !TryResolveEnvironmentBaseUri(out baseUri))
            {
                return false;
            }

            client = new LangSmithClient(
                httpClient,
                baseUri,
                authorizations,
                options,
                disposeHttpClient);

            client.Authorizing(client.HttpClient, ref apiKey);
            client.AuthorizeUsingApiKeyInHeader(apiKey);
            client.Authorized(client.HttpClient);

            return true;
        }

        private static global::System.Uri? ResolveEnvironmentBaseUriOrThrow()
        {
            var baseUriValue = GetFirstEnvironmentVariableValue(
                s_baseUrlEnvironmentVariables,
                out var baseUriEnvironmentVariableName);
            if (baseUriValue is null)
            {
                return null;
            }

            if (global::System.Uri.TryCreate(baseUriValue, global::System.UriKind.Absolute, out var baseUri))
            {
                return baseUri;
            }

            throw new global::System.InvalidOperationException(
                "Environment variable '" + baseUriEnvironmentVariableName + "' must contain an absolute URI.");
        }

        private static bool TryResolveEnvironmentBaseUri(
            out global::System.Uri? baseUri)
        {
            baseUri = null;
            var baseUriValue = GetFirstEnvironmentVariableValue(
                s_baseUrlEnvironmentVariables,
                out _);
            return baseUriValue is null ||
                   global::System.Uri.TryCreate(baseUriValue, global::System.UriKind.Absolute, out baseUri);
        }

        private static string? GetFirstEnvironmentVariableValue(
            string[] names,
            out string? resolvedName)
        {
            foreach (var name in names)
            {
                if (string.IsNullOrWhiteSpace(name))
                {
                    continue;
                }

                var value = global::System.Environment.GetEnvironmentVariable(name);
                if (!string.IsNullOrWhiteSpace(value))
                {
                    resolvedName = name;
                    return value;
                }
            }

            resolvedName = null;
            return null;
        }
    }
}