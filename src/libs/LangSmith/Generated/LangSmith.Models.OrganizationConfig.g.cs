
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Organization level configuration. May include any field that exists in tenant config and additional fields.
    /// </summary>
    public sealed partial class OrganizationConfig
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_tier")]
        public string? PlanTier { get; set; }

        /// <summary>
        /// Default Value: 5
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_identities")]
        public int? MaxIdentities { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_workspaces")]
        public int? MaxWorkspaces { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_rbac")]
        public bool? CanUseRbac { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_abac")]
        public bool? CanUseAbac { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_audit_logs")]
        public bool? CanUseAuditLogs { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_add_seats")]
        public bool? CanAddSeats { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startup_plan_approval_date")]
        public string? StartupPlanApprovalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("partner_plan_approval_date")]
        public string? PartnerPlanApprovalDate { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("premier_plan_approval_date")]
        public string? PremierPlanApprovalDate { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_disable_public_sharing")]
        public bool? CanDisablePublicSharing { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_langgraph_cloud")]
        public bool? CanUseLanggraphCloud { get; set; }

        /// <summary>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_langgraph_cloud_deployments")]
        public int? MaxLanggraphCloudDeployments { get; set; }

        /// <summary>
        /// Default Value: 0
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_free_langgraph_cloud_deployments")]
        public int? MaxFreeLanggraphCloudDeployments { get; set; }

        /// <summary>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_sandboxes")]
        public int? MaxSandboxes { get; set; }

        /// <summary>
        /// Default Value: 100
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_sandbox_volumes")]
        public int? MaxSandboxVolumes { get; set; }

        /// <summary>
        /// Default Value: 200
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_sandbox_cpu")]
        public string? MaxSandboxCpu { get; set; }

        /// <summary>
        /// Default Value: 400Gi
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_sandbox_memory")]
        public string? MaxSandboxMemory { get; set; }

        /// <summary>
        /// Default Value: 1Ti
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_sandbox_storage")]
        public string? MaxSandboxStorage { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_saml_sso")]
        public bool? CanUseSamlSso { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_bulk_export")]
        public bool? CanUseBulkExport { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_updated_sidenav")]
        public bool? ShowUpdatedSidenav { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_updated_resource_tags")]
        public bool? ShowUpdatedResourceTags { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kv_dataset_message_support")]
        public bool? KvDatasetMessageSupport { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_playground_prompt_canvas")]
        public bool? ShowPlaygroundPromptCanvas { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_custom_iframes")]
        public bool? AllowCustomIframes { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_langgraph_pricing")]
        public bool? EnableLanggraphPricing { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_thread_view_playground")]
        public bool? EnableThreadViewPlayground { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_org_usage_charts")]
        public bool? EnableOrgUsageCharts { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_exact_search_for_prompts")]
        public bool? UseExactSearchForPrompts { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("langgraph_deploy_own_cloud_enabled")]
        public bool? LanggraphDeployOwnCloudEnabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_optimization_jobs_enabled")]
        public bool? PromptOptimizationJobsEnabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("demo_lgp_new_graph_enabled")]
        public bool? DemoLgpNewGraphEnabled { get; set; }

        /// <summary>
        /// Default Value: 20
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datadog_rum_session_sample_rate")]
        public int? DatadogRumSessionSampleRate { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("langgraph_remote_reconciler_enabled")]
        public bool? LanggraphRemoteReconcilerEnabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("langgraph_enterprise_enabled")]
        public bool? LanggraphEnterpriseEnabled { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("langsmith_alerts_poc_enabled")]
        public bool? LangsmithAlertsPocEnabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_skip_topk_facets")]
        public bool? TenantSkipTopkFacets { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lgp_templates_enabled")]
        public bool? LgpTemplatesEnabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_align_evaluators")]
        public bool? EnableAlignEvaluators { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_run_tree_streaming")]
        public bool? EnableRunTreeStreaming { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_querying_v2_endpoints")]
        public bool? EnableQueryingV2Endpoints { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_threads_improvements")]
        public bool? EnableThreadsImprovements { get; set; }

        /// <summary>
        /// Default Value: 1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_prompt_webhooks")]
        public int? MaxPromptWebhooks { get; set; }

        /// <summary>
        /// Default Value: sync
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playground_evaluator_strategy")]
        public string? PlaygroundEvaluatorStrategy { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_set_api_key_max_expiry")]
        public bool? CanSetApiKeyMaxExpiry { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_monthly_usage_charts")]
        public bool? EnableMonthlyUsageCharts { get; set; }

        /// <summary>
        /// Default Value: 3
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_rule_evaluator_creation_version")]
        public int? NewRuleEvaluatorCreationVersion { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_lgp_listeners_page")]
        public bool? EnableLgpListenersPage { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clio_enabled")]
        public bool? ClioEnabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_include_extended_stats")]
        public bool? EnableIncludeExtendedStats { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_markdown_in_tracing")]
        public bool? EnableMarkdownInTracing { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_pricing_redesign")]
        public bool? EnablePricingRedesign { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arbitrary_cost_tracking_enabled")]
        public bool? ArbitraryCostTrackingEnabled { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("langsmith_deployment_distributed_runtime_enabled")]
        public bool? LangsmithDeploymentDistributedRuntimeEnabled { get; set; }

        /// <summary>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_builder_enabled")]
        public bool? AgentBuilderEnabled { get; set; }

        /// <summary>
        /// Default Value: 1000
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_agent_builder_assistants")]
        public int? MaxAgentBuilderAssistants { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_granular_usage_reporting")]
        public bool? EnableGranularUsageReporting { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_burndown_vs_commit_view")]
        public bool? EnableBurndownVsCommitView { get; set; }

        /// <summary>
        /// Default Value: -1
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_agent_builder_runs")]
        public int? MaxAgentBuilderRuns { get; set; }

        /// <summary>
        /// Default Value: false
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("langsmith_deployment_dr_enabled_dev")]
        public bool? LangsmithDeploymentDrEnabledDev { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationConfig" /> class.
        /// </summary>
        /// <param name="planTier"></param>
        /// <param name="maxIdentities">
        /// Default Value: 5
        /// </param>
        /// <param name="maxWorkspaces">
        /// Default Value: 1
        /// </param>
        /// <param name="canUseRbac">
        /// Default Value: false
        /// </param>
        /// <param name="canUseAbac">
        /// Default Value: false
        /// </param>
        /// <param name="canUseAuditLogs">
        /// Default Value: false
        /// </param>
        /// <param name="canAddSeats">
        /// Default Value: true
        /// </param>
        /// <param name="startupPlanApprovalDate"></param>
        /// <param name="partnerPlanApprovalDate"></param>
        /// <param name="premierPlanApprovalDate"></param>
        /// <param name="canDisablePublicSharing">
        /// Default Value: false
        /// </param>
        /// <param name="canUseLanggraphCloud">
        /// Default Value: false
        /// </param>
        /// <param name="maxLanggraphCloudDeployments">
        /// Default Value: 3
        /// </param>
        /// <param name="maxFreeLanggraphCloudDeployments">
        /// Default Value: 0
        /// </param>
        /// <param name="maxSandboxes">
        /// Default Value: 100
        /// </param>
        /// <param name="maxSandboxVolumes">
        /// Default Value: 100
        /// </param>
        /// <param name="maxSandboxCpu">
        /// Default Value: 200
        /// </param>
        /// <param name="maxSandboxMemory">
        /// Default Value: 400Gi
        /// </param>
        /// <param name="maxSandboxStorage">
        /// Default Value: 1Ti
        /// </param>
        /// <param name="canUseSamlSso">
        /// Default Value: false
        /// </param>
        /// <param name="canUseBulkExport">
        /// Default Value: false
        /// </param>
        /// <param name="showUpdatedSidenav">
        /// Default Value: false
        /// </param>
        /// <param name="showUpdatedResourceTags">
        /// Default Value: false
        /// </param>
        /// <param name="kvDatasetMessageSupport">
        /// Default Value: true
        /// </param>
        /// <param name="showPlaygroundPromptCanvas">
        /// Default Value: false
        /// </param>
        /// <param name="allowCustomIframes">
        /// Default Value: false
        /// </param>
        /// <param name="enableLanggraphPricing">
        /// Default Value: false
        /// </param>
        /// <param name="enableThreadViewPlayground">
        /// Default Value: false
        /// </param>
        /// <param name="enableOrgUsageCharts">
        /// Default Value: false
        /// </param>
        /// <param name="useExactSearchForPrompts">
        /// Default Value: false
        /// </param>
        /// <param name="langgraphDeployOwnCloudEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="promptOptimizationJobsEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="demoLgpNewGraphEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="datadogRumSessionSampleRate">
        /// Default Value: 20
        /// </param>
        /// <param name="langgraphRemoteReconcilerEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="langgraphEnterpriseEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="langsmithAlertsPocEnabled">
        /// Default Value: true
        /// </param>
        /// <param name="tenantSkipTopkFacets">
        /// Default Value: false
        /// </param>
        /// <param name="lgpTemplatesEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="enableAlignEvaluators">
        /// Default Value: false
        /// </param>
        /// <param name="enableRunTreeStreaming">
        /// Default Value: false
        /// </param>
        /// <param name="enableQueryingV2Endpoints">
        /// Default Value: false
        /// </param>
        /// <param name="enableThreadsImprovements">
        /// Default Value: false
        /// </param>
        /// <param name="maxPromptWebhooks">
        /// Default Value: 1
        /// </param>
        /// <param name="playgroundEvaluatorStrategy">
        /// Default Value: sync
        /// </param>
        /// <param name="canSetApiKeyMaxExpiry">
        /// Default Value: false
        /// </param>
        /// <param name="enableMonthlyUsageCharts">
        /// Default Value: false
        /// </param>
        /// <param name="newRuleEvaluatorCreationVersion">
        /// Default Value: 3
        /// </param>
        /// <param name="enableLgpListenersPage">
        /// Default Value: false
        /// </param>
        /// <param name="clioEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="enableIncludeExtendedStats">
        /// Default Value: false
        /// </param>
        /// <param name="enableMarkdownInTracing">
        /// Default Value: false
        /// </param>
        /// <param name="enablePricingRedesign">
        /// Default Value: false
        /// </param>
        /// <param name="arbitraryCostTrackingEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="langsmithDeploymentDistributedRuntimeEnabled">
        /// Default Value: false
        /// </param>
        /// <param name="agentBuilderEnabled">
        /// Default Value: true
        /// </param>
        /// <param name="maxAgentBuilderAssistants">
        /// Default Value: 1000
        /// </param>
        /// <param name="enableGranularUsageReporting">
        /// Default Value: false
        /// </param>
        /// <param name="enableBurndownVsCommitView">
        /// Default Value: false
        /// </param>
        /// <param name="maxAgentBuilderRuns">
        /// Default Value: -1
        /// </param>
        /// <param name="langsmithDeploymentDrEnabledDev">
        /// Default Value: false
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OrganizationConfig(
            string? planTier,
            int? maxIdentities,
            int? maxWorkspaces,
            bool? canUseRbac,
            bool? canUseAbac,
            bool? canUseAuditLogs,
            bool? canAddSeats,
            string? startupPlanApprovalDate,
            string? partnerPlanApprovalDate,
            string? premierPlanApprovalDate,
            bool? canDisablePublicSharing,
            bool? canUseLanggraphCloud,
            int? maxLanggraphCloudDeployments,
            int? maxFreeLanggraphCloudDeployments,
            int? maxSandboxes,
            int? maxSandboxVolumes,
            string? maxSandboxCpu,
            string? maxSandboxMemory,
            string? maxSandboxStorage,
            bool? canUseSamlSso,
            bool? canUseBulkExport,
            bool? showUpdatedSidenav,
            bool? showUpdatedResourceTags,
            bool? kvDatasetMessageSupport,
            bool? showPlaygroundPromptCanvas,
            bool? allowCustomIframes,
            bool? enableLanggraphPricing,
            bool? enableThreadViewPlayground,
            bool? enableOrgUsageCharts,
            bool? useExactSearchForPrompts,
            bool? langgraphDeployOwnCloudEnabled,
            bool? promptOptimizationJobsEnabled,
            bool? demoLgpNewGraphEnabled,
            int? datadogRumSessionSampleRate,
            bool? langgraphRemoteReconcilerEnabled,
            bool? langgraphEnterpriseEnabled,
            bool? langsmithAlertsPocEnabled,
            bool? tenantSkipTopkFacets,
            bool? lgpTemplatesEnabled,
            bool? enableAlignEvaluators,
            bool? enableRunTreeStreaming,
            bool? enableQueryingV2Endpoints,
            bool? enableThreadsImprovements,
            int? maxPromptWebhooks,
            string? playgroundEvaluatorStrategy,
            bool? canSetApiKeyMaxExpiry,
            bool? enableMonthlyUsageCharts,
            int? newRuleEvaluatorCreationVersion,
            bool? enableLgpListenersPage,
            bool? clioEnabled,
            bool? enableIncludeExtendedStats,
            bool? enableMarkdownInTracing,
            bool? enablePricingRedesign,
            bool? arbitraryCostTrackingEnabled,
            bool? langsmithDeploymentDistributedRuntimeEnabled,
            bool? agentBuilderEnabled,
            int? maxAgentBuilderAssistants,
            bool? enableGranularUsageReporting,
            bool? enableBurndownVsCommitView,
            int? maxAgentBuilderRuns,
            bool? langsmithDeploymentDrEnabledDev)
        {
            this.PlanTier = planTier;
            this.MaxIdentities = maxIdentities;
            this.MaxWorkspaces = maxWorkspaces;
            this.CanUseRbac = canUseRbac;
            this.CanUseAbac = canUseAbac;
            this.CanUseAuditLogs = canUseAuditLogs;
            this.CanAddSeats = canAddSeats;
            this.StartupPlanApprovalDate = startupPlanApprovalDate;
            this.PartnerPlanApprovalDate = partnerPlanApprovalDate;
            this.PremierPlanApprovalDate = premierPlanApprovalDate;
            this.CanDisablePublicSharing = canDisablePublicSharing;
            this.CanUseLanggraphCloud = canUseLanggraphCloud;
            this.MaxLanggraphCloudDeployments = maxLanggraphCloudDeployments;
            this.MaxFreeLanggraphCloudDeployments = maxFreeLanggraphCloudDeployments;
            this.MaxSandboxes = maxSandboxes;
            this.MaxSandboxVolumes = maxSandboxVolumes;
            this.MaxSandboxCpu = maxSandboxCpu;
            this.MaxSandboxMemory = maxSandboxMemory;
            this.MaxSandboxStorage = maxSandboxStorage;
            this.CanUseSamlSso = canUseSamlSso;
            this.CanUseBulkExport = canUseBulkExport;
            this.ShowUpdatedSidenav = showUpdatedSidenav;
            this.ShowUpdatedResourceTags = showUpdatedResourceTags;
            this.KvDatasetMessageSupport = kvDatasetMessageSupport;
            this.ShowPlaygroundPromptCanvas = showPlaygroundPromptCanvas;
            this.AllowCustomIframes = allowCustomIframes;
            this.EnableLanggraphPricing = enableLanggraphPricing;
            this.EnableThreadViewPlayground = enableThreadViewPlayground;
            this.EnableOrgUsageCharts = enableOrgUsageCharts;
            this.UseExactSearchForPrompts = useExactSearchForPrompts;
            this.LanggraphDeployOwnCloudEnabled = langgraphDeployOwnCloudEnabled;
            this.PromptOptimizationJobsEnabled = promptOptimizationJobsEnabled;
            this.DemoLgpNewGraphEnabled = demoLgpNewGraphEnabled;
            this.DatadogRumSessionSampleRate = datadogRumSessionSampleRate;
            this.LanggraphRemoteReconcilerEnabled = langgraphRemoteReconcilerEnabled;
            this.LanggraphEnterpriseEnabled = langgraphEnterpriseEnabled;
            this.LangsmithAlertsPocEnabled = langsmithAlertsPocEnabled;
            this.TenantSkipTopkFacets = tenantSkipTopkFacets;
            this.LgpTemplatesEnabled = lgpTemplatesEnabled;
            this.EnableAlignEvaluators = enableAlignEvaluators;
            this.EnableRunTreeStreaming = enableRunTreeStreaming;
            this.EnableQueryingV2Endpoints = enableQueryingV2Endpoints;
            this.EnableThreadsImprovements = enableThreadsImprovements;
            this.MaxPromptWebhooks = maxPromptWebhooks;
            this.PlaygroundEvaluatorStrategy = playgroundEvaluatorStrategy;
            this.CanSetApiKeyMaxExpiry = canSetApiKeyMaxExpiry;
            this.EnableMonthlyUsageCharts = enableMonthlyUsageCharts;
            this.NewRuleEvaluatorCreationVersion = newRuleEvaluatorCreationVersion;
            this.EnableLgpListenersPage = enableLgpListenersPage;
            this.ClioEnabled = clioEnabled;
            this.EnableIncludeExtendedStats = enableIncludeExtendedStats;
            this.EnableMarkdownInTracing = enableMarkdownInTracing;
            this.EnablePricingRedesign = enablePricingRedesign;
            this.ArbitraryCostTrackingEnabled = arbitraryCostTrackingEnabled;
            this.LangsmithDeploymentDistributedRuntimeEnabled = langsmithDeploymentDistributedRuntimeEnabled;
            this.AgentBuilderEnabled = agentBuilderEnabled;
            this.MaxAgentBuilderAssistants = maxAgentBuilderAssistants;
            this.EnableGranularUsageReporting = enableGranularUsageReporting;
            this.EnableBurndownVsCommitView = enableBurndownVsCommitView;
            this.MaxAgentBuilderRuns = maxAgentBuilderRuns;
            this.LangsmithDeploymentDrEnabledDev = langsmithDeploymentDrEnabledDev;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationConfig" /> class.
        /// </summary>
        public OrganizationConfig()
        {
        }
    }
}