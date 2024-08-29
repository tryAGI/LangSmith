
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public sealed partial class LangSmithApi : global::System.IDisposable
    {
        /// <summary>
        /// 
        /// </summary>
        public const string BaseUrl = "https://api.smith.langchain.com";

        private readonly global::System.Net.Http.HttpClient _httpClient;


        /// <summary>
        /// 
        /// </summary>
        public TracerSessionsClient TracerSessions => new TracerSessionsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public OrgsClient Orgs => new OrgsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public AuthClient Auth => new AuthClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public ApiKeyClient ApiKey => new ApiKeyClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public ExamplesClient Examples => new ExamplesClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets => new DatasetsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public RunClient Run => new RunClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public FeedbackClient Feedback => new FeedbackClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public PublicClient Public => new PublicClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public AnnotationQueuesClient AnnotationQueues => new AnnotationQueuesClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public TenantClient Tenant => new TenantClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public InfoClient Info => new InfoClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public FeedbackConfigsClient FeedbackConfigs => new FeedbackConfigsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public ModelPriceMapClient ModelPriceMap => new ModelPriceMapClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public UsageLimitsClient UsageLimits => new UsageLimitsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public TtlSettingsClient TtlSettings => new TtlSettingsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts => new PromptsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public WorkspacesClient Workspaces => new WorkspacesClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public PlaygroundSettingsClient PlaygroundSettings => new PlaygroundSettingsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public ServiceAccountsClient ServiceAccounts => new ServiceAccountsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public ChartsClient Charts => new ChartsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public ReposClient Repos => new ReposClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public LikesClient Likes => new LikesClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public CommitsClient Commits => new CommitsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public SettingsClient Settings => new SettingsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public EventsClient Events => new EventsClient(_httpClient);

        /// <summary>
        /// 
        /// </summary>
        public CommentsClient Comments => new CommentsClient(_httpClient);

        /// <summary>
        /// Creates a new instance of the LangSmithApi.
        /// If no httpClient is provided, a new one will be created.
        /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="baseUri"></param> 
        public LangSmithApi(
            global::System.Net.Http.HttpClient? httpClient = null,
            global::System.Uri? baseUri = null 
            )
        {
            _httpClient = httpClient ?? new global::System.Net.Http.HttpClient();
            _httpClient.BaseAddress ??= baseUri ?? new global::System.Uri(BaseUrl);

            Initialized(_httpClient);
        }

        /// <inheritdoc/>
        public void Dispose()
        {
            _httpClient.Dispose();
        }

        partial void Initialized(
            global::System.Net.Http.HttpClient client);
        partial void PrepareArguments(
            global::System.Net.Http.HttpClient client);
        partial void PrepareRequest(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpRequestMessage request);
        partial void ProcessResponse(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response);
        partial void ProcessResponseContent(
            global::System.Net.Http.HttpClient client,
            global::System.Net.Http.HttpResponseMessage response,
            ref string content);
    }
}