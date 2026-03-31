
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class AuthnOrganizationConfig
    {
        /// <summary>
        /// AgentBuilderEnabled indicates whether Agent Builder is enabled for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent_builder_enabled")]
        public bool? AgentBuilderEnabled { get; set; }

        /// <summary>
        /// AllowCustomIframes indicates whether to allow custom iframes for trace rendering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("allow_custom_iframes")]
        public bool? AllowCustomIframes { get; set; }

        /// <summary>
        /// ArbitraryCostTrackingEnabled indicates whether arbitrary cost tracking flows are enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("arbitrary_cost_tracking_enabled")]
        public bool? ArbitraryCostTrackingEnabled { get; set; }

        /// <summary>
        /// Indicates whether this org can provision BYOC data planes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("byoc_enabled")]
        public bool? ByocEnabled { get; set; }

        /// <summary>
        /// CanAddSeats indicates whether this org can invite new users based on their plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_add_seats")]
        public bool? CanAddSeats { get; set; }

        /// <summary>
        /// CanDisablePublicSharing indicates whether this org can disable public sharing of resources like traces, datasets, and prompts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_disable_public_sharing")]
        public bool? CanDisablePublicSharing { get; set; }

        /// <summary>
        /// CanRestrictBrowserSecrets indicates whether the org can restrict browser-level secrets in the Playground (enterprise-only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_restrict_browser_secrets")]
        public bool? CanRestrictBrowserSecrets { get; set; }

        /// <summary>
        /// CanSetApiKeyMaxExpiry indicates whether the org can set a maximum expiry duration for API keys (enterprise-only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_set_api_key_max_expiry")]
        public bool? CanSetApiKeyMaxExpiry { get; set; }

        /// <summary>
        /// CanUseAbac indicates whether this org can use attribute-based access control policies.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_abac")]
        public bool? CanUseAbac { get; set; }

        /// <summary>
        /// CanUseAuditLogs indicates whether this org can use audit logging functionality.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_audit_logs")]
        public bool? CanUseAuditLogs { get; set; }

        /// <summary>
        /// CanUseBulkExport indicates whether this org can create bulk exports.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_bulk_export")]
        public bool? CanUseBulkExport { get; set; }

        /// <summary>
        /// CanUseLanggraphCloud indicates whether this org can use LangGraph Platform.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_langgraph_cloud")]
        public bool? CanUseLanggraphCloud { get; set; }

        /// <summary>
        /// CanUseLLMAuthProxy indicates whether the org can use the LLM auth proxy (enterprise-only).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_llm_auth_proxy")]
        public bool? CanUseLlmAuthProxy { get; set; }

        /// <summary>
        /// CanUseRbac indicates whether this org can create new users using roles based on their plan.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_rbac")]
        public bool? CanUseRbac { get; set; }

        /// <summary>
        /// CanUseSamlSso indicates whether this org can configure SAML SSO.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("can_use_saml_sso")]
        public bool? CanUseSamlSso { get; set; }

        /// <summary>
        /// CLIOEnabled indicates whether CLIO is enabled for this org.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clio_enabled")]
        public bool? ClioEnabled { get; set; }

        /// <summary>
        /// DatadogRumSessionSampleRate indicates the sampling rate for datadog RUM sessions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("datadog_rum_session_sample_rate")]
        public int? DatadogRumSessionSampleRate { get; set; }

        /// <summary>
        /// DemoLgpNewGraphEnabled indicates whether this org can use the demo page for creating new graphs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("demo_lgp_new_graph_enabled")]
        public bool? DemoLgpNewGraphEnabled { get; set; }

        /// <summary>
        /// EnableAlignEvaluators indicates whether to enable the align evaluators flow for this org.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_align_evaluators")]
        public bool? EnableAlignEvaluators { get; set; }

        /// <summary>
        /// EnableBurndownVsCommitView indicates whether the org can view contract usage (burndown vs commitment).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_burndown_vs_commit_view")]
        public bool? EnableBurndownVsCommitView { get; set; }

        /// <summary>
        /// EnableGranularUsageReporting indicates whether the org can use granular usage reporting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_granular_usage_reporting")]
        public bool? EnableGranularUsageReporting { get; set; }

        /// <summary>
        /// EnableIncludeExtendedStats indicates whether the include extended stats checkbox should be shown in evaluator forms
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_include_extended_stats")]
        public bool? EnableIncludeExtendedStats { get; set; }

        /// <summary>
        /// EnableLanggraphPricing indicates whether to show Agent marketplace in Langgraph tab.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_langgraph_pricing")]
        public bool? EnableLanggraphPricing { get; set; }

        /// <summary>
        /// EnableLgpListenersPage indicates whether the lgp listeners page should be shown
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_lgp_listeners_page")]
        public bool? EnableLgpListenersPage { get; set; }

        /// <summary>
        /// EnableMarkdownInTracing indicates whether markdown is enabled in tracing
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_markdown_in_tracing")]
        public bool? EnableMarkdownInTracing { get; set; }

        /// <summary>
        /// EnableMonthlyUsageCharts indicates whether to show monthly organization usage charts backed by Metronome for self hosted customers
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_monthly_usage_charts")]
        public bool? EnableMonthlyUsageCharts { get; set; }

        /// <summary>
        /// EnableOrgUsageCharts indicates whether to show organization usage charts backed by ClickHouse queries instead of Metronome.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_org_usage_charts")]
        public bool? EnableOrgUsageCharts { get; set; }

        /// <summary>
        /// EnablePricingRedesign indicates whether the pricing redesign is enabled
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_pricing_redesign")]
        public bool? EnablePricingRedesign { get; set; }

        /// <summary>
        /// EnableQueryingV2Endpoints indicates whether to enable the querying v2 endpoints for this org.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_querying_v2_endpoints")]
        public bool? EnableQueryingV2Endpoints { get; set; }

        /// <summary>
        /// EnableRunTreeStreaming indicates whether to enable the run tree streaming feature for this org.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_run_tree_streaming")]
        public bool? EnableRunTreeStreaming { get; set; }

        /// <summary>
        /// EnableThreadViewPlayground indicates whether to allow opening top-level thread view runs in the playground.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_thread_view_playground")]
        public bool? EnableThreadViewPlayground { get; set; }

        /// <summary>
        /// EnableThreadsImprovements indicates whether to enable the threads improvements feature for this org.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enable_threads_improvements")]
        public bool? EnableThreadsImprovements { get; set; }

        /// <summary>
        /// IPAllowlistEnabled indicates whether this org can configure and enforce IP allowlists.<br/>
        /// Set by Metronome entitlement, not admin-patchable.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("ip_allowlist_enabled")]
        public bool? IpAllowlistEnabled { get; set; }

        /// <summary>
        /// KvDatasetMessageSupport indicates whether to use the new messages experience for KV datasets.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("kv_dataset_message_support")]
        public bool? KvDatasetMessageSupport { get; set; }

        /// <summary>
        /// LangGraphDeployOwnCloudEnabled indicates whether the org can deploy LangGraph cloud to their own cloud.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("langgraph_deploy_own_cloud_enabled")]
        public bool? LanggraphDeployOwnCloudEnabled { get; set; }

        /// <summary>
        /// LangGraphEnterpriseEnabled indicates whether the org has access to LangGraph Enterprise features.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("langgraph_enterprise_enabled")]
        public bool? LanggraphEnterpriseEnabled { get; set; }

        /// <summary>
        /// LangGraphRemoteReconcilerEnabled indicates whether an org's LangGraph deployments are reconciled via a remote reconciler instance.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("langgraph_remote_reconciler_enabled")]
        public bool? LanggraphRemoteReconcilerEnabled { get; set; }

        /// <summary>
        /// LangsmithAlertsPocEnabled indicates whether to enable the legacy alerts POC for this org.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("langsmith_alerts_poc_enabled")]
        public bool? LangsmithAlertsPocEnabled { get; set; }

        /// <summary>
        /// LangSmithDeploymentDistributedRuntimeEnabled indicates whether distributed runtime is enabled for the organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("langsmith_deployment_distributed_runtime_enabled")]
        public bool? LangsmithDeploymentDistributedRuntimeEnabled { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("langsmith_deployment_dr_enabled_dev")]
        public bool? LangsmithDeploymentDrEnabledDev { get; set; }

        /// <summary>
        /// LgpTemplatesEnabled indicates whether to enable LGP templates for this org.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("lgp_templates_enabled")]
        public bool? LgpTemplatesEnabled { get; set; }

        /// <summary>
        /// MaxAgentBuilderAssistants is the maximum number of Agent Builder assistants allowed for this org.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_agent_builder_assistants")]
        public int? MaxAgentBuilderAssistants { get; set; }

        /// <summary>
        /// MaxAgentBuilderRuns is the maximum number of Agent Builder runs per month.<br/>
        /// Default is -1 (unlimited). Set to a positive value for a specific limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_agent_builder_runs")]
        public int? MaxAgentBuilderRuns { get; set; }

        /// <summary>
        /// MaxFreeLanggraphCloudDeployments is the maximum number of free LangGraph Platform deployments allowed for this org.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_free_langgraph_cloud_deployments")]
        public int? MaxFreeLanggraphCloudDeployments { get; set; }

        /// <summary>
        /// MaxIdentities is the maximum number of identities allowed in this org.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_identities")]
        public int? MaxIdentities { get; set; }

        /// <summary>
        /// MaxLanggraphCloudDeployments is the maximum number of LangGraph Platform deployments allowed for this org.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_langgraph_cloud_deployments")]
        public int? MaxLanggraphCloudDeployments { get; set; }

        /// <summary>
        /// MaxPromptWebhooks is the maximum number of prompt webhooks allowed for this org.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_prompt_webhooks")]
        public int? MaxPromptWebhooks { get; set; }

        /// <summary>
        /// MaxSandboxCpu is the total CPU cores allowed for sandboxes (e.g., "4", "8").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_sandbox_cpu")]
        public string? MaxSandboxCpu { get; set; }

        /// <summary>
        /// MaxSandboxMemory is the total memory allowed for sandboxes (e.g., "8Gi", "16Gi").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_sandbox_memory")]
        public string? MaxSandboxMemory { get; set; }

        /// <summary>
        /// MaxSandboxStorage is the total volume storage allowed for sandboxes (e.g., "10Gi", "50Gi").
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_sandbox_storage")]
        public string? MaxSandboxStorage { get; set; }

        /// <summary>
        /// MaxSandboxVolumes is the maximum number of sandbox volumes allowed for this org.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_sandbox_volumes")]
        public int? MaxSandboxVolumes { get; set; }

        /// <summary>
        /// MaxSandboxes is the maximum number of sandbox claims allowed for this org.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_sandboxes")]
        public int? MaxSandboxes { get; set; }

        /// <summary>
        /// MaxWorkspaces is the maximum number of workspaces allowed in this org. -1 means no limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("max_workspaces")]
        public int? MaxWorkspaces { get; set; }

        /// <summary>
        /// New Evaluator Version
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("new_rule_evaluator_creation_version")]
        public int? NewRuleEvaluatorCreationVersion { get; set; }

        /// <summary>
        /// PlanTier is the organization's payment plan tier (e.g., "free", "developer", "plus", "enterprise").<br/>
        /// Populated from Metronome's __tier custom field during auth verification.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plan_tier")]
        public string? PlanTier { get; set; }

        /// <summary>
        /// PlaygroundEvaluatorStrategy indicates the method of running evaluators in the playground<br/>
        /// options are "cron", "background", or "sync"
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("playground_evaluator_strategy")]
        public string? PlaygroundEvaluatorStrategy { get; set; }

        /// <summary>
        /// PremierPlanApprovalDate is the date when the org was approved for the premier plan in YYYY-MM-DD format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("premier_plan_approval_date")]
        public string? PremierPlanApprovalDate { get; set; }

        /// <summary>
        /// PromptOptimizationJobsEnabled indicates whether the org can use the prompt optimization jobs feature.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_optimization_jobs_enabled")]
        public bool? PromptOptimizationJobsEnabled { get; set; }

        /// <summary>
        /// ShowPlaygroundPromptCanvas indicates whether to show the playground prompt canvas.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_playground_prompt_canvas")]
        public bool? ShowPlaygroundPromptCanvas { get; set; }

        /// <summary>
        /// ShowUpdatedResourceTags indicates whether to show updated resource tags to users in this org.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_updated_resource_tags")]
        public bool? ShowUpdatedResourceTags { get; set; }

        /// <summary>
        /// ShowUpdatedSidenav indicates whether to show updated side nav to users in this org.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("show_updated_sidenav")]
        public bool? ShowUpdatedSidenav { get; set; }

        /// <summary>
        /// StartupPlanApprovalDate is the date when the org was approved for the startup plan in YYYY-MM-DD format.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("startup_plan_approval_date")]
        public string? StartupPlanApprovalDate { get; set; }

        /// <summary>
        /// TenantSkipTopkFacets indicates whether the tenant should skip topk facets in run stats.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_skip_topk_facets")]
        public bool? TenantSkipTopkFacets { get; set; }

        /// <summary>
        /// UseExactSearchForPrompts indicates whether to use exact search for prompts.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("use_exact_search_for_prompts")]
        public bool? UseExactSearchForPrompts { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthnOrganizationConfig" /> class.
        /// </summary>
        /// <param name="agentBuilderEnabled">
        /// AgentBuilderEnabled indicates whether Agent Builder is enabled for the organization.
        /// </param>
        /// <param name="allowCustomIframes">
        /// AllowCustomIframes indicates whether to allow custom iframes for trace rendering.
        /// </param>
        /// <param name="arbitraryCostTrackingEnabled">
        /// ArbitraryCostTrackingEnabled indicates whether arbitrary cost tracking flows are enabled
        /// </param>
        /// <param name="byocEnabled">
        /// Indicates whether this org can provision BYOC data planes.
        /// </param>
        /// <param name="canAddSeats">
        /// CanAddSeats indicates whether this org can invite new users based on their plan.
        /// </param>
        /// <param name="canDisablePublicSharing">
        /// CanDisablePublicSharing indicates whether this org can disable public sharing of resources like traces, datasets, and prompts.
        /// </param>
        /// <param name="canRestrictBrowserSecrets">
        /// CanRestrictBrowserSecrets indicates whether the org can restrict browser-level secrets in the Playground (enterprise-only).
        /// </param>
        /// <param name="canSetApiKeyMaxExpiry">
        /// CanSetApiKeyMaxExpiry indicates whether the org can set a maximum expiry duration for API keys (enterprise-only).
        /// </param>
        /// <param name="canUseAbac">
        /// CanUseAbac indicates whether this org can use attribute-based access control policies.
        /// </param>
        /// <param name="canUseAuditLogs">
        /// CanUseAuditLogs indicates whether this org can use audit logging functionality.
        /// </param>
        /// <param name="canUseBulkExport">
        /// CanUseBulkExport indicates whether this org can create bulk exports.
        /// </param>
        /// <param name="canUseLanggraphCloud">
        /// CanUseLanggraphCloud indicates whether this org can use LangGraph Platform.
        /// </param>
        /// <param name="canUseLlmAuthProxy">
        /// CanUseLLMAuthProxy indicates whether the org can use the LLM auth proxy (enterprise-only).
        /// </param>
        /// <param name="canUseRbac">
        /// CanUseRbac indicates whether this org can create new users using roles based on their plan.
        /// </param>
        /// <param name="canUseSamlSso">
        /// CanUseSamlSso indicates whether this org can configure SAML SSO.
        /// </param>
        /// <param name="clioEnabled">
        /// CLIOEnabled indicates whether CLIO is enabled for this org.
        /// </param>
        /// <param name="datadogRumSessionSampleRate">
        /// DatadogRumSessionSampleRate indicates the sampling rate for datadog RUM sessions.
        /// </param>
        /// <param name="demoLgpNewGraphEnabled">
        /// DemoLgpNewGraphEnabled indicates whether this org can use the demo page for creating new graphs.
        /// </param>
        /// <param name="enableAlignEvaluators">
        /// EnableAlignEvaluators indicates whether to enable the align evaluators flow for this org.
        /// </param>
        /// <param name="enableBurndownVsCommitView">
        /// EnableBurndownVsCommitView indicates whether the org can view contract usage (burndown vs commitment).
        /// </param>
        /// <param name="enableGranularUsageReporting">
        /// EnableGranularUsageReporting indicates whether the org can use granular usage reporting.
        /// </param>
        /// <param name="enableIncludeExtendedStats">
        /// EnableIncludeExtendedStats indicates whether the include extended stats checkbox should be shown in evaluator forms
        /// </param>
        /// <param name="enableLanggraphPricing">
        /// EnableLanggraphPricing indicates whether to show Agent marketplace in Langgraph tab.
        /// </param>
        /// <param name="enableLgpListenersPage">
        /// EnableLgpListenersPage indicates whether the lgp listeners page should be shown
        /// </param>
        /// <param name="enableMarkdownInTracing">
        /// EnableMarkdownInTracing indicates whether markdown is enabled in tracing
        /// </param>
        /// <param name="enableMonthlyUsageCharts">
        /// EnableMonthlyUsageCharts indicates whether to show monthly organization usage charts backed by Metronome for self hosted customers
        /// </param>
        /// <param name="enableOrgUsageCharts">
        /// EnableOrgUsageCharts indicates whether to show organization usage charts backed by ClickHouse queries instead of Metronome.
        /// </param>
        /// <param name="enablePricingRedesign">
        /// EnablePricingRedesign indicates whether the pricing redesign is enabled
        /// </param>
        /// <param name="enableQueryingV2Endpoints">
        /// EnableQueryingV2Endpoints indicates whether to enable the querying v2 endpoints for this org.
        /// </param>
        /// <param name="enableRunTreeStreaming">
        /// EnableRunTreeStreaming indicates whether to enable the run tree streaming feature for this org.
        /// </param>
        /// <param name="enableThreadViewPlayground">
        /// EnableThreadViewPlayground indicates whether to allow opening top-level thread view runs in the playground.
        /// </param>
        /// <param name="enableThreadsImprovements">
        /// EnableThreadsImprovements indicates whether to enable the threads improvements feature for this org.
        /// </param>
        /// <param name="ipAllowlistEnabled">
        /// IPAllowlistEnabled indicates whether this org can configure and enforce IP allowlists.<br/>
        /// Set by Metronome entitlement, not admin-patchable.
        /// </param>
        /// <param name="kvDatasetMessageSupport">
        /// KvDatasetMessageSupport indicates whether to use the new messages experience for KV datasets.
        /// </param>
        /// <param name="langgraphDeployOwnCloudEnabled">
        /// LangGraphDeployOwnCloudEnabled indicates whether the org can deploy LangGraph cloud to their own cloud.
        /// </param>
        /// <param name="langgraphEnterpriseEnabled">
        /// LangGraphEnterpriseEnabled indicates whether the org has access to LangGraph Enterprise features.
        /// </param>
        /// <param name="langgraphRemoteReconcilerEnabled">
        /// LangGraphRemoteReconcilerEnabled indicates whether an org's LangGraph deployments are reconciled via a remote reconciler instance.
        /// </param>
        /// <param name="langsmithAlertsPocEnabled">
        /// LangsmithAlertsPocEnabled indicates whether to enable the legacy alerts POC for this org.
        /// </param>
        /// <param name="langsmithDeploymentDistributedRuntimeEnabled">
        /// LangSmithDeploymentDistributedRuntimeEnabled indicates whether distributed runtime is enabled for the organization.
        /// </param>
        /// <param name="langsmithDeploymentDrEnabledDev"></param>
        /// <param name="lgpTemplatesEnabled">
        /// LgpTemplatesEnabled indicates whether to enable LGP templates for this org.
        /// </param>
        /// <param name="maxAgentBuilderAssistants">
        /// MaxAgentBuilderAssistants is the maximum number of Agent Builder assistants allowed for this org.
        /// </param>
        /// <param name="maxAgentBuilderRuns">
        /// MaxAgentBuilderRuns is the maximum number of Agent Builder runs per month.<br/>
        /// Default is -1 (unlimited). Set to a positive value for a specific limit.
        /// </param>
        /// <param name="maxFreeLanggraphCloudDeployments">
        /// MaxFreeLanggraphCloudDeployments is the maximum number of free LangGraph Platform deployments allowed for this org.
        /// </param>
        /// <param name="maxIdentities">
        /// MaxIdentities is the maximum number of identities allowed in this org.
        /// </param>
        /// <param name="maxLanggraphCloudDeployments">
        /// MaxLanggraphCloudDeployments is the maximum number of LangGraph Platform deployments allowed for this org.
        /// </param>
        /// <param name="maxPromptWebhooks">
        /// MaxPromptWebhooks is the maximum number of prompt webhooks allowed for this org.
        /// </param>
        /// <param name="maxSandboxCpu">
        /// MaxSandboxCpu is the total CPU cores allowed for sandboxes (e.g., "4", "8").
        /// </param>
        /// <param name="maxSandboxMemory">
        /// MaxSandboxMemory is the total memory allowed for sandboxes (e.g., "8Gi", "16Gi").
        /// </param>
        /// <param name="maxSandboxStorage">
        /// MaxSandboxStorage is the total volume storage allowed for sandboxes (e.g., "10Gi", "50Gi").
        /// </param>
        /// <param name="maxSandboxVolumes">
        /// MaxSandboxVolumes is the maximum number of sandbox volumes allowed for this org.
        /// </param>
        /// <param name="maxSandboxes">
        /// MaxSandboxes is the maximum number of sandbox claims allowed for this org.
        /// </param>
        /// <param name="maxWorkspaces">
        /// MaxWorkspaces is the maximum number of workspaces allowed in this org. -1 means no limit.
        /// </param>
        /// <param name="newRuleEvaluatorCreationVersion">
        /// New Evaluator Version
        /// </param>
        /// <param name="planTier">
        /// PlanTier is the organization's payment plan tier (e.g., "free", "developer", "plus", "enterprise").<br/>
        /// Populated from Metronome's __tier custom field during auth verification.
        /// </param>
        /// <param name="playgroundEvaluatorStrategy">
        /// PlaygroundEvaluatorStrategy indicates the method of running evaluators in the playground<br/>
        /// options are "cron", "background", or "sync"
        /// </param>
        /// <param name="premierPlanApprovalDate">
        /// PremierPlanApprovalDate is the date when the org was approved for the premier plan in YYYY-MM-DD format.
        /// </param>
        /// <param name="promptOptimizationJobsEnabled">
        /// PromptOptimizationJobsEnabled indicates whether the org can use the prompt optimization jobs feature.
        /// </param>
        /// <param name="showPlaygroundPromptCanvas">
        /// ShowPlaygroundPromptCanvas indicates whether to show the playground prompt canvas.
        /// </param>
        /// <param name="showUpdatedResourceTags">
        /// ShowUpdatedResourceTags indicates whether to show updated resource tags to users in this org.
        /// </param>
        /// <param name="showUpdatedSidenav">
        /// ShowUpdatedSidenav indicates whether to show updated side nav to users in this org.
        /// </param>
        /// <param name="startupPlanApprovalDate">
        /// StartupPlanApprovalDate is the date when the org was approved for the startup plan in YYYY-MM-DD format.
        /// </param>
        /// <param name="tenantSkipTopkFacets">
        /// TenantSkipTopkFacets indicates whether the tenant should skip topk facets in run stats.
        /// </param>
        /// <param name="useExactSearchForPrompts">
        /// UseExactSearchForPrompts indicates whether to use exact search for prompts.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuthnOrganizationConfig(
            bool? agentBuilderEnabled,
            bool? allowCustomIframes,
            bool? arbitraryCostTrackingEnabled,
            bool? byocEnabled,
            bool? canAddSeats,
            bool? canDisablePublicSharing,
            bool? canRestrictBrowserSecrets,
            bool? canSetApiKeyMaxExpiry,
            bool? canUseAbac,
            bool? canUseAuditLogs,
            bool? canUseBulkExport,
            bool? canUseLanggraphCloud,
            bool? canUseLlmAuthProxy,
            bool? canUseRbac,
            bool? canUseSamlSso,
            bool? clioEnabled,
            int? datadogRumSessionSampleRate,
            bool? demoLgpNewGraphEnabled,
            bool? enableAlignEvaluators,
            bool? enableBurndownVsCommitView,
            bool? enableGranularUsageReporting,
            bool? enableIncludeExtendedStats,
            bool? enableLanggraphPricing,
            bool? enableLgpListenersPage,
            bool? enableMarkdownInTracing,
            bool? enableMonthlyUsageCharts,
            bool? enableOrgUsageCharts,
            bool? enablePricingRedesign,
            bool? enableQueryingV2Endpoints,
            bool? enableRunTreeStreaming,
            bool? enableThreadViewPlayground,
            bool? enableThreadsImprovements,
            bool? ipAllowlistEnabled,
            bool? kvDatasetMessageSupport,
            bool? langgraphDeployOwnCloudEnabled,
            bool? langgraphEnterpriseEnabled,
            bool? langgraphRemoteReconcilerEnabled,
            bool? langsmithAlertsPocEnabled,
            bool? langsmithDeploymentDistributedRuntimeEnabled,
            bool? langsmithDeploymentDrEnabledDev,
            bool? lgpTemplatesEnabled,
            int? maxAgentBuilderAssistants,
            int? maxAgentBuilderRuns,
            int? maxFreeLanggraphCloudDeployments,
            int? maxIdentities,
            int? maxLanggraphCloudDeployments,
            int? maxPromptWebhooks,
            string? maxSandboxCpu,
            string? maxSandboxMemory,
            string? maxSandboxStorage,
            int? maxSandboxVolumes,
            int? maxSandboxes,
            int? maxWorkspaces,
            int? newRuleEvaluatorCreationVersion,
            string? planTier,
            string? playgroundEvaluatorStrategy,
            string? premierPlanApprovalDate,
            bool? promptOptimizationJobsEnabled,
            bool? showPlaygroundPromptCanvas,
            bool? showUpdatedResourceTags,
            bool? showUpdatedSidenav,
            string? startupPlanApprovalDate,
            bool? tenantSkipTopkFacets,
            bool? useExactSearchForPrompts)
        {
            this.AgentBuilderEnabled = agentBuilderEnabled;
            this.AllowCustomIframes = allowCustomIframes;
            this.ArbitraryCostTrackingEnabled = arbitraryCostTrackingEnabled;
            this.ByocEnabled = byocEnabled;
            this.CanAddSeats = canAddSeats;
            this.CanDisablePublicSharing = canDisablePublicSharing;
            this.CanRestrictBrowserSecrets = canRestrictBrowserSecrets;
            this.CanSetApiKeyMaxExpiry = canSetApiKeyMaxExpiry;
            this.CanUseAbac = canUseAbac;
            this.CanUseAuditLogs = canUseAuditLogs;
            this.CanUseBulkExport = canUseBulkExport;
            this.CanUseLanggraphCloud = canUseLanggraphCloud;
            this.CanUseLlmAuthProxy = canUseLlmAuthProxy;
            this.CanUseRbac = canUseRbac;
            this.CanUseSamlSso = canUseSamlSso;
            this.ClioEnabled = clioEnabled;
            this.DatadogRumSessionSampleRate = datadogRumSessionSampleRate;
            this.DemoLgpNewGraphEnabled = demoLgpNewGraphEnabled;
            this.EnableAlignEvaluators = enableAlignEvaluators;
            this.EnableBurndownVsCommitView = enableBurndownVsCommitView;
            this.EnableGranularUsageReporting = enableGranularUsageReporting;
            this.EnableIncludeExtendedStats = enableIncludeExtendedStats;
            this.EnableLanggraphPricing = enableLanggraphPricing;
            this.EnableLgpListenersPage = enableLgpListenersPage;
            this.EnableMarkdownInTracing = enableMarkdownInTracing;
            this.EnableMonthlyUsageCharts = enableMonthlyUsageCharts;
            this.EnableOrgUsageCharts = enableOrgUsageCharts;
            this.EnablePricingRedesign = enablePricingRedesign;
            this.EnableQueryingV2Endpoints = enableQueryingV2Endpoints;
            this.EnableRunTreeStreaming = enableRunTreeStreaming;
            this.EnableThreadViewPlayground = enableThreadViewPlayground;
            this.EnableThreadsImprovements = enableThreadsImprovements;
            this.IpAllowlistEnabled = ipAllowlistEnabled;
            this.KvDatasetMessageSupport = kvDatasetMessageSupport;
            this.LanggraphDeployOwnCloudEnabled = langgraphDeployOwnCloudEnabled;
            this.LanggraphEnterpriseEnabled = langgraphEnterpriseEnabled;
            this.LanggraphRemoteReconcilerEnabled = langgraphRemoteReconcilerEnabled;
            this.LangsmithAlertsPocEnabled = langsmithAlertsPocEnabled;
            this.LangsmithDeploymentDistributedRuntimeEnabled = langsmithDeploymentDistributedRuntimeEnabled;
            this.LangsmithDeploymentDrEnabledDev = langsmithDeploymentDrEnabledDev;
            this.LgpTemplatesEnabled = lgpTemplatesEnabled;
            this.MaxAgentBuilderAssistants = maxAgentBuilderAssistants;
            this.MaxAgentBuilderRuns = maxAgentBuilderRuns;
            this.MaxFreeLanggraphCloudDeployments = maxFreeLanggraphCloudDeployments;
            this.MaxIdentities = maxIdentities;
            this.MaxLanggraphCloudDeployments = maxLanggraphCloudDeployments;
            this.MaxPromptWebhooks = maxPromptWebhooks;
            this.MaxSandboxCpu = maxSandboxCpu;
            this.MaxSandboxMemory = maxSandboxMemory;
            this.MaxSandboxStorage = maxSandboxStorage;
            this.MaxSandboxVolumes = maxSandboxVolumes;
            this.MaxSandboxes = maxSandboxes;
            this.MaxWorkspaces = maxWorkspaces;
            this.NewRuleEvaluatorCreationVersion = newRuleEvaluatorCreationVersion;
            this.PlanTier = planTier;
            this.PlaygroundEvaluatorStrategy = playgroundEvaluatorStrategy;
            this.PremierPlanApprovalDate = premierPlanApprovalDate;
            this.PromptOptimizationJobsEnabled = promptOptimizationJobsEnabled;
            this.ShowPlaygroundPromptCanvas = showPlaygroundPromptCanvas;
            this.ShowUpdatedResourceTags = showUpdatedResourceTags;
            this.ShowUpdatedSidenav = showUpdatedSidenav;
            this.StartupPlanApprovalDate = startupPlanApprovalDate;
            this.TenantSkipTopkFacets = tenantSkipTopkFacets;
            this.UseExactSearchForPrompts = useExactSearchForPrompts;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuthnOrganizationConfig" /> class.
        /// </summary>
        public AuthnOrganizationConfig()
        {
        }
    }
}