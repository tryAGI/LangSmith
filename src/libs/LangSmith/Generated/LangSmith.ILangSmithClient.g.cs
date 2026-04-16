
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// The LangSmith API is used to programmatically create and manage LangSmith resources.<br/>
    /// ## Host<br/>
    /// https://api.smith.langchain.com<br/>
    /// ## Authentication<br/>
    /// To authenticate with the LangSmith API, set the `X-Api-Key` header<br/>
    /// to a valid [LangSmith API key](https://docs.langchain.com/langsmith/create-account-api-key#create-an-api-key).<br/>
    /// If no httpClient is provided, a new one will be created.<br/>
    /// If no baseUri is provided, the default baseUri from OpenAPI spec will be used.
    /// </summary>
    public partial interface ILangSmithClient : global::System.IDisposable
    {
        /// <summary>
        /// The HttpClient instance.
        /// </summary>
        public global::System.Net.Http.HttpClient HttpClient { get; }

        /// <summary>
        /// The base URL for the API.
        /// </summary>
        public System.Uri? BaseUri { get; }

        /// <summary>
        /// The authorizations to use for the requests.
        /// </summary>
        public global::System.Collections.Generic.List<global::LangSmith.EndPointAuthorization> Authorizations { get; }

        /// <summary>
        /// Gets or sets a value indicating whether the response content should be read as a string.
        /// True by default in debug builds, false otherwise.
        /// When false, successful responses are deserialized directly from the response stream for better performance.
        /// Error responses are always read as strings regardless of this setting,
        /// ensuring <see cref="ApiException.ResponseBody"/> is populated.
        /// </summary>
        public bool ReadResponseAsString { get; set; }
        /// <summary>
        /// Client-wide request defaults such as headers, query parameters, retries, and timeout.
        /// </summary>
        public global::LangSmith.AutoSDKClientOptions Options { get; }


        /// <summary>
        /// 
        /// </summary>
        global::System.Text.Json.Serialization.JsonSerializerContext JsonSerializerContext { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public AccessPoliciesClient AccessPolicies { get; }

        /// <summary>
        /// 
        /// </summary>
        public AceClient Ace { get; }

        /// <summary>
        /// 
        /// </summary>
        public AlertRulesClient AlertRules { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnnotationQueuesClient AnnotationQueues { get; }

        /// <summary>
        /// 
        /// </summary>
        public AnnotationQueues2Client AnnotationQueues2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public ApiKeyClient ApiKey { get; }

        /// <summary>
        /// 
        /// </summary>
        public AuditLogsClient AuditLogs { get; }

        /// <summary>
        /// 
        /// </summary>
        public AuthClient Auth { get; }

        /// <summary>
        /// 
        /// </summary>
        public BackfillsClient Backfills { get; }

        /// <summary>
        /// 
        /// </summary>
        public BeaconClient Beacon { get; }

        /// <summary>
        /// 
        /// </summary>
        public BulkExportsClient BulkExports { get; }

        /// <summary>
        /// 
        /// </summary>
        public ChartsClient Charts { get; }

        /// <summary>
        /// 
        /// </summary>
        public CommentsClient Comments { get; }

        /// <summary>
        /// 
        /// </summary>
        public CommitsClient Commits { get; }

        /// <summary>
        /// 
        /// </summary>
        public DatasetsClient Datasets { get; }

        /// <summary>
        /// 
        /// </summary>
        public EvaluatorsClient Evaluators { get; }

        /// <summary>
        /// 
        /// </summary>
        public ExamplesClient Examples { get; }

        /// <summary>
        /// 
        /// </summary>
        public ExperimentViewOverridesClient ExperimentViewOverrides { get; }

        /// <summary>
        /// 
        /// </summary>
        public ExperimentsClient Experiments { get; }

        /// <summary>
        /// 
        /// </summary>
        public FeaturesClient Features { get; }

        /// <summary>
        /// 
        /// </summary>
        public FeedbackClient Feedback { get; }

        /// <summary>
        /// 
        /// </summary>
        public FeedbackConfigsClient FeedbackConfigs { get; }

        /// <summary>
        /// 
        /// </summary>
        public FleetGithubAppClient FleetGithubApp { get; }

        /// <summary>
        /// 
        /// </summary>
        public FleetIntegrationsClient FleetIntegrations { get; }

        /// <summary>
        /// 
        /// </summary>
        public FleetMcpClient FleetMcp { get; }

        /// <summary>
        /// 
        /// </summary>
        public FleetUsageClient FleetUsage { get; }

        /// <summary>
        /// 
        /// </summary>
        public FleetWebhooksClient FleetWebhooks { get; }

        /// <summary>
        /// 
        /// </summary>
        public ForgeConfigurationsClient ForgeConfigurations { get; }

        /// <summary>
        /// 
        /// </summary>
        public HubEnvironmentsClient HubEnvironments { get; }

        /// <summary>
        /// 
        /// </summary>
        public InfoClient Info { get; }

        /// <summary>
        /// 
        /// </summary>
        public IntegrationsClient Integrations { get; }

        /// <summary>
        /// 
        /// </summary>
        public LikesClient Likes { get; }

        /// <summary>
        /// 
        /// </summary>
        public McpClient Mcp { get; }

        /// <summary>
        /// 
        /// </summary>
        public McpVendorsClient McpVendors { get; }

        /// <summary>
        /// 
        /// </summary>
        public MeClient Me { get; }

        /// <summary>
        /// 
        /// </summary>
        public MetricsClient Metrics { get; }

        /// <summary>
        /// 
        /// </summary>
        public ModelPriceMapClient ModelPriceMap { get; }

        /// <summary>
        /// 
        /// </summary>
        public NpsClient Nps { get; }

        /// <summary>
        /// 
        /// </summary>
        public OptimizationJobsClient OptimizationJobs { get; }

        /// <summary>
        /// 
        /// </summary>
        public OrganizationsClient Organizations { get; }

        /// <summary>
        /// 
        /// </summary>
        public OrgsClient Orgs { get; }

        /// <summary>
        /// 
        /// </summary>
        public OwnershipsClient Ownerships { get; }

        /// <summary>
        /// 
        /// </summary>
        public PlaygroundSettingsClient PlaygroundSettings { get; }

        /// <summary>
        /// 
        /// </summary>
        public PromptWebhooksClient PromptWebhooks { get; }

        /// <summary>
        /// 
        /// </summary>
        public PromptsClient Prompts { get; }

        /// <summary>
        /// 
        /// </summary>
        public PublicClient Public { get; }

        /// <summary>
        /// 
        /// </summary>
        public ReposClient Repos { get; }

        /// <summary>
        /// 
        /// </summary>
        public RunClient Run { get; }

        /// <summary>
        /// 
        /// </summary>
        public RunsClient Runs { get; }

        /// <summary>
        /// 
        /// </summary>
        public SandboxesClient Sandboxes { get; }

        /// <summary>
        /// 
        /// </summary>
        public ScimTokensClient ScimTokens { get; }

        /// <summary>
        /// 
        /// </summary>
        public ServiceAccountsClient ServiceAccounts { get; }

        /// <summary>
        /// 
        /// </summary>
        public SessionsClient Sessions { get; }

        /// <summary>
        /// 
        /// </summary>
        public SettingsClient Settings { get; }

        /// <summary>
        /// 
        /// </summary>
        public TagTransitionsClient TagTransitions { get; }

        /// <summary>
        /// 
        /// </summary>
        public TagsClient Tags { get; }

        /// <summary>
        /// 
        /// </summary>
        public TenantClient Tenant { get; }

        /// <summary>
        /// 
        /// </summary>
        public ThreadsClient Threads { get; }

        /// <summary>
        /// 
        /// </summary>
        public ToolsClient Tools { get; }

        /// <summary>
        /// 
        /// </summary>
        public TracerSessionsClient TracerSessions { get; }

        /// <summary>
        /// 
        /// </summary>
        public TtlSettingsClient TtlSettings { get; }

        /// <summary>
        /// 
        /// </summary>
        public TtlSettings2Client TtlSettings2 { get; }

        /// <summary>
        /// 
        /// </summary>
        public UsageLimitsClient UsageLimits { get; }

        /// <summary>
        /// 
        /// </summary>
        public WorkspacesClient Workspaces { get; }

    }
}