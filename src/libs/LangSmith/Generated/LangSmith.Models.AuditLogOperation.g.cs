
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Operations that are logged in audit_logs database table.
    /// </summary>
    public enum AuditLogOperation
    {
        /// <summary>
        /// 
        /// </summary>
        AddAnnotationQueueReviewer,
        /// <summary>
        /// 
        /// </summary>
        AddBasicAuthUsersToOrg,
        /// <summary>
        /// 
        /// </summary>
        AddMemberToWorkspace,
        /// <summary>
        /// 
        /// </summary>
        AddMembersToWorkspaceBatch,
        /// <summary>
        /// 
        /// </summary>
        AddRunsToAnnotationQueue,
        /// <summary>
        /// 
        /// </summary>
        AttachAccessPolicies,
        /// <summary>
        /// 
        /// </summary>
        BatchQueryTraceMessages,
        /// <summary>
        /// 
        /// </summary>
        BulkDeleteEvaluators,
        /// <summary>
        /// 
        /// </summary>
        CancelBulkExport,
        /// <summary>
        /// 
        /// </summary>
        ClaimPendingOrganizationInvite,
        /// <summary>
        /// 
        /// </summary>
        ClaimPendingWorkspaceInvite,
        /// <summary>
        /// 
        /// </summary>
        CloneChartSection,
        /// <summary>
        /// 
        /// </summary>
        CloneDataset,
        /// <summary>
        /// 
        /// </summary>
        ConfirmPaymentCheckoutSession,
        /// <summary>
        /// 
        /// </summary>
        ConfirmSsoUserEmail,
        /// <summary>
        /// 
        /// </summary>
        CountExamples,
        /// <summary>
        /// 
        /// </summary>
        CreateAccessPolicy,
        /// <summary>
        /// 
        /// </summary>
        CreateAlertRule,
        /// <summary>
        /// 
        /// </summary>
        CreateAnnotationQueue,
        /// <summary>
        /// 
        /// </summary>
        CreateAnnotationQueueRunStatus,
        /// <summary>
        /// 
        /// </summary>
        CreateApiKey,
        /// <summary>
        /// 
        /// </summary>
        CreateBulkExport,
        /// <summary>
        /// 
        /// </summary>
        CreateBulkExportDestination,
        /// <summary>
        /// 
        /// </summary>
        CreateChart,
        /// <summary>
        /// 
        /// </summary>
        CreateChartSection,
        /// <summary>
        /// 
        /// </summary>
        CreateCommit,
        /// <summary>
        /// 
        /// </summary>
        CreateComparativeExperiment,
        /// <summary>
        /// 
        /// </summary>
        CreateCsvDataset,
        /// <summary>
        /// 
        /// </summary>
        CreateDataset,
        /// <summary>
        /// 
        /// </summary>
        CreateDeployment,
        /// <summary>
        /// 
        /// </summary>
        CreateDirectoryCommit,
        /// <summary>
        /// 
        /// </summary>
        CreateEvaluator,
        /// <summary>
        /// 
        /// </summary>
        CreateExample,
        /// <summary>
        /// 
        /// </summary>
        CreateExamples,
        /// <summary>
        /// 
        /// </summary>
        CreateExperimentViaUpload,
        /// <summary>
        /// 
        /// </summary>
        CreateExperimentViewOverride,
        /// <summary>
        /// 
        /// </summary>
        CreateFeedbackConfig,
        /// <summary>
        /// 
        /// </summary>
        CreateFeedbackFormula,
        /// <summary>
        /// 
        /// </summary>
        CreateFilterView,
        /// <summary>
        /// 
        /// </summary>
        CreateFleetUsageLimit,
        /// <summary>
        /// 
        /// </summary>
        CreateFleetWebhook,
        /// <summary>
        /// 
        /// </summary>
        CreateForgeConfiguration,
        /// <summary>
        /// 
        /// </summary>
        CreateGatewayPolicy,
        /// <summary>
        /// 
        /// </summary>
        CreateHubEnvironment,
        /// <summary>
        /// 
        /// </summary>
        CreateInsightsJob,
        /// <summary>
        /// 
        /// </summary>
        CreateInsightsJobConfig,
        /// <summary>
        /// 
        /// </summary>
        CreateMcpServer,
        /// <summary>
        /// 
        /// </summary>
        CreateMcpVendorSettings,
        /// <summary>
        /// 
        /// </summary>
        CreateModelPriceMap,
        /// <summary>
        /// 
        /// </summary>
        CreateOnboardingState,
        /// <summary>
        /// 
        /// </summary>
        CreateOrgChart,
        /// <summary>
        /// 
        /// </summary>
        CreateOrgChartSection,
        /// <summary>
        /// 
        /// </summary>
        CreateOrganization,
        /// <summary>
        /// 
        /// </summary>
        CreatePaymentAccountLink,
        /// <summary>
        /// 
        /// </summary>
        CreatePaymentCheckoutSession,
        /// <summary>
        /// 
        /// </summary>
        CreatePaymentSetupIntent,
        /// <summary>
        /// 
        /// </summary>
        CreatePersonalAccessToken,
        /// <summary>
        /// 
        /// </summary>
        CreatePlaygroundExperiment,
        /// <summary>
        /// 
        /// </summary>
        CreatePlaygroundSettings,
        /// <summary>
        /// 
        /// </summary>
        CreatePromptCanvasQuickAction,
        /// <summary>
        /// 
        /// </summary>
        CreatePromptWebhook,
        /// <summary>
        /// 
        /// </summary>
        CreateRole,
        /// <summary>
        /// 
        /// </summary>
        CreateSandboxProxyProfile,
        /// <summary>
        /// 
        /// </summary>
        CreateScimGroup,
        /// <summary>
        /// 
        /// </summary>
        CreateScimToken,
        /// <summary>
        /// 
        /// </summary>
        CreateScimUser,
        /// <summary>
        /// 
        /// </summary>
        CreateServiceAccount,
        /// <summary>
        /// 
        /// </summary>
        CreateServiceKey,
        /// <summary>
        /// 
        /// </summary>
        CreateSsoSettings,
        /// <summary>
        /// 
        /// </summary>
        CreateTagKey,
        /// <summary>
        /// 
        /// </summary>
        CreateTagValue,
        /// <summary>
        /// 
        /// </summary>
        CreateTagging,
        /// <summary>
        /// 
        /// </summary>
        CreateTenant,
        /// <summary>
        /// 
        /// </summary>
        CreateTool,
        /// <summary>
        /// 
        /// </summary>
        CreateWorkspace,
        /// <summary>
        /// 
        /// </summary>
        DeleteAccessPolicy,
        /// <summary>
        /// 
        /// </summary>
        DeleteAlertRule,
        /// <summary>
        /// 
        /// </summary>
        DeleteAnnotationQueue,
        /// <summary>
        /// 
        /// </summary>
        DeleteAnnotationQueueRun,
        /// <summary>
        /// 
        /// </summary>
        DeleteAnnotationQueueRuns,
        /// <summary>
        /// 
        /// </summary>
        DeleteAnnotationQueues,
        /// <summary>
        /// 
        /// </summary>
        DeleteApiKey,
        /// <summary>
        /// 
        /// </summary>
        DeleteChart,
        /// <summary>
        /// 
        /// </summary>
        DeleteChartSection,
        /// <summary>
        /// 
        /// </summary>
        DeleteComparativeExperiment,
        /// <summary>
        /// 
        /// </summary>
        DeleteDataset,
        /// <summary>
        /// 
        /// </summary>
        DeleteDatasets,
        /// <summary>
        /// 
        /// </summary>
        DeleteDeployment,
        /// <summary>
        /// 
        /// </summary>
        DeleteDirectory,
        /// <summary>
        /// 
        /// </summary>
        DeleteEvaluator,
        /// <summary>
        /// 
        /// </summary>
        DeleteExample,
        /// <summary>
        /// 
        /// </summary>
        DeleteExamples,
        /// <summary>
        /// 
        /// </summary>
        DeleteExperimentViewOverride,
        /// <summary>
        /// 
        /// </summary>
        DeleteFeatureDefaultModel,
        /// <summary>
        /// 
        /// </summary>
        DeleteFeatureDisabledModel,
        /// <summary>
        /// 
        /// </summary>
        DeleteFeedbackConfig,
        /// <summary>
        /// 
        /// </summary>
        DeleteFeedbackFormula,
        /// <summary>
        /// 
        /// </summary>
        DeleteFilterView,
        /// <summary>
        /// 
        /// </summary>
        DeleteFleetUsageLimit,
        /// <summary>
        /// 
        /// </summary>
        DeleteFleetWebhook,
        /// <summary>
        /// 
        /// </summary>
        DeleteForgeConfiguration,
        /// <summary>
        /// 
        /// </summary>
        DeleteGatewayPolicy,
        /// <summary>
        /// 
        /// </summary>
        DeleteHubEnvironment,
        /// <summary>
        /// 
        /// </summary>
        DeleteInsightsJob,
        /// <summary>
        /// 
        /// </summary>
        DeleteInsightsJobConfig,
        /// <summary>
        /// 
        /// </summary>
        DeleteMcpServer,
        /// <summary>
        /// 
        /// </summary>
        DeleteMcpVendorSettings,
        /// <summary>
        /// 
        /// </summary>
        DeleteModelPriceMap,
        /// <summary>
        /// 
        /// </summary>
        DeleteOrgChart,
        /// <summary>
        /// 
        /// </summary>
        DeleteOrgChartSection,
        /// <summary>
        /// 
        /// </summary>
        DeleteOrgMember,
        /// <summary>
        /// 
        /// </summary>
        DeleteOrgPendingMember,
        /// <summary>
        /// 
        /// </summary>
        DeletePendingOrganizationInvite,
        /// <summary>
        /// 
        /// </summary>
        DeletePendingWorkspaceInvite,
        /// <summary>
        /// 
        /// </summary>
        DeletePersonalAccessToken,
        /// <summary>
        /// 
        /// </summary>
        DeletePlaygroundSettings,
        /// <summary>
        /// 
        /// </summary>
        DeletePromptCanvasQuickAction,
        /// <summary>
        /// 
        /// </summary>
        DeletePromptWebhook,
        /// <summary>
        /// 
        /// </summary>
        DeleteRole,
        /// <summary>
        /// 
        /// </summary>
        DeleteRuns,
        /// <summary>
        /// 
        /// </summary>
        DeleteSandboxProxyProfile,
        /// <summary>
        /// 
        /// </summary>
        DeleteScimGroup,
        /// <summary>
        /// 
        /// </summary>
        DeleteScimToken,
        /// <summary>
        /// 
        /// </summary>
        DeleteScimUser,
        /// <summary>
        /// 
        /// </summary>
        DeleteServiceAccount,
        /// <summary>
        /// 
        /// </summary>
        DeleteServiceKey,
        /// <summary>
        /// 
        /// </summary>
        DeleteSsoSettings,
        /// <summary>
        /// 
        /// </summary>
        DeleteTagKey,
        /// <summary>
        /// 
        /// </summary>
        DeleteTagValue,
        /// <summary>
        /// 
        /// </summary>
        DeleteTagging,
        /// <summary>
        /// 
        /// </summary>
        DeleteTool,
        /// <summary>
        /// 
        /// </summary>
        DeleteTracerSession,
        /// <summary>
        /// 
        /// </summary>
        DeleteTracerSessions,
        /// <summary>
        /// 
        /// </summary>
        DeleteUsageLimit,
        /// <summary>
        /// 
        /// </summary>
        DeleteWorkspace,
        /// <summary>
        /// 
        /// </summary>
        DeleteWorkspaceMember,
        /// <summary>
        /// 
        /// </summary>
        DeleteWorkspacePendingMember,
        /// <summary>
        /// 
        /// </summary>
        DiffDatasetVersions,
        /// <summary>
        /// 
        /// </summary>
        DownloadDataset,
        /// <summary>
        /// 
        /// </summary>
        EvaluateExperiment,
        /// <summary>
        /// 
        /// </summary>
        ExecuteCustomCode,
        /// <summary>
        /// 
        /// </summary>
        ExportAnnotationQueue,
        /// <summary>
        /// 
        /// </summary>
        ExportGranularUsageCsv,
        /// <summary>
        /// 
        /// </summary>
        ExportUsageBackfillCsv,
        /// <summary>
        /// 
        /// </summary>
        GenerateDataset,
        /// <summary>
        /// 
        /// </summary>
        GenerateInsightsJobConfig,
        /// <summary>
        /// 
        /// </summary>
        GenerateRunsQuery,
        /// <summary>
        /// 
        /// </summary>
        GenerateSharedDatasetQuery,
        /// <summary>
        /// 
        /// </summary>
        GetAnnotationQueue,
        /// <summary>
        /// 
        /// </summary>
        GetAnnotationQueueArchivedSize,
        /// <summary>
        /// 
        /// </summary>
        GetAnnotationQueueRun,
        /// <summary>
        /// 
        /// </summary>
        GetAnnotationQueueRuns,
        /// <summary>
        /// 
        /// </summary>
        GetAnnotationQueueSize,
        /// <summary>
        /// 
        /// </summary>
        GetAnnotationQueueTotalSize,
        /// <summary>
        /// 
        /// </summary>
        GetAnnotationQueuesForRun,
        /// <summary>
        /// 
        /// </summary>
        GetAuditLogs,
        /// <summary>
        /// 
        /// </summary>
        GetBulkExport,
        /// <summary>
        /// 
        /// </summary>
        GetBulkExportRun,
        /// <summary>
        /// 
        /// </summary>
        GetBulkExportRuns,
        /// <summary>
        /// 
        /// </summary>
        GetBulkExportRunsFiltered,
        /// <summary>
        /// 
        /// </summary>
        GetCompanyInfo,
        /// <summary>
        /// 
        /// </summary>
        GetDatasetComparisonView,
        /// <summary>
        /// 
        /// </summary>
        GetDatasetVersion,
        /// <summary>
        /// 
        /// </summary>
        GetDatasetVersions,
        /// <summary>
        /// 
        /// </summary>
        GetExample,
        /// <summary>
        /// 
        /// </summary>
        GetExperimentViewOverride,
        /// <summary>
        /// 
        /// </summary>
        GetExperimentViewOverrides,
        /// <summary>
        /// 
        /// </summary>
        GetFeedbackFormula,
        /// <summary>
        /// 
        /// </summary>
        GetFilterView,
        /// <summary>
        /// 
        /// </summary>
        GetGranularUsage,
        /// <summary>
        /// 
        /// </summary>
        GetInsightsJob,
        /// <summary>
        /// 
        /// </summary>
        GetInsightsJobRuns,
        /// <summary>
        /// 
        /// </summary>
        GetLoginMethods,
        /// <summary>
        /// 
        /// </summary>
        GetMcpTools,
        /// <summary>
        /// 
        /// </summary>
        GetOnboardingState,
        /// <summary>
        /// 
        /// </summary>
        GetOrgDashboard,
        /// <summary>
        /// 
        /// </summary>
        GetOrgUsage,
        /// <summary>
        /// 
        /// </summary>
        GetOrgUsageLimits,
        /// <summary>
        /// 
        /// </summary>
        GetOrganizationBillingInfo,
        /// <summary>
        /// 
        /// </summary>
        GetOrganizationInfo,
        /// <summary>
        /// 
        /// </summary>
        GetPairwiseQueue,
        /// <summary>
        /// 
        /// </summary>
        GetRunCluster,
        /// <summary>
        /// 
        /// </summary>
        GetSharedExamplesCount,
        /// <summary>
        /// 
        /// </summary>
        GetSharedTokens,
        /// <summary>
        /// 
        /// </summary>
        GetSsoSettings,
        /// <summary>
        /// 
        /// </summary>
        GetSsoSettingsCurrent,
        /// <summary>
        /// 
        /// </summary>
        GetTagKey,
        /// <summary>
        /// 
        /// </summary>
        GetTagValue,
        /// <summary>
        /// 
        /// </summary>
        GetUsageLimits,
        /// <summary>
        /// 
        /// </summary>
        GetWorkspaceStats,
        /// <summary>
        /// 
        /// </summary>
        GetWorkspaceUsageLimitsInfo,
        /// <summary>
        /// 
        /// </summary>
        InvalidateMcpToolsCache,
        /// <summary>
        /// 
        /// </summary>
        InviteUserToOrg,
        /// <summary>
        /// 
        /// </summary>
        InviteUsersToOrgBatch,
        /// <summary>
        /// 
        /// </summary>
        ListAccessPolicies,
        /// <summary>
        /// 
        /// </summary>
        ListAnnotationQueues,
        /// <summary>
        /// 
        /// </summary>
        ListBulkExportDestinations,
        /// <summary>
        /// 
        /// </summary>
        ListBulkExports,
        /// <summary>
        /// 
        /// </summary>
        ListChartSections,
        /// <summary>
        /// 
        /// </summary>
        ListExamples,
        /// <summary>
        /// 
        /// </summary>
        ListFeedbackConfigs,
        /// <summary>
        /// 
        /// </summary>
        ListFeedbackFormulas,
        /// <summary>
        /// 
        /// </summary>
        ListFilterViews,
        /// <summary>
        /// 
        /// </summary>
        ListInsightsJobConfigs,
        /// <summary>
        /// 
        /// </summary>
        ListInsightsJobs,
        /// <summary>
        /// 
        /// </summary>
        ListOrgMembers,
        /// <summary>
        /// 
        /// </summary>
        ListOrgPersonalAccessTokens,
        /// <summary>
        /// 
        /// </summary>
        ListOrgServiceKeys,
        /// <summary>
        /// 
        /// </summary>
        ListOrganizationRoles,
        /// <summary>
        /// 
        /// </summary>
        ListOrganizations,
        /// <summary>
        /// 
        /// </summary>
        ListPairwiseEntries,
        /// <summary>
        /// 
        /// </summary>
        ListPairwiseQueues,
        /// <summary>
        /// 
        /// </summary>
        ListPendingOrganizationInvites,
        /// <summary>
        /// 
        /// </summary>
        ListPendingWorkspaceInvites,
        /// <summary>
        /// 
        /// </summary>
        ListPermissions,
        /// <summary>
        /// 
        /// </summary>
        ListServiceAccounts,
        /// <summary>
        /// 
        /// </summary>
        ListTagKeys,
        /// <summary>
        /// 
        /// </summary>
        ListTagValues,
        /// <summary>
        /// 
        /// </summary>
        ListTaggings,
        /// <summary>
        /// 
        /// </summary>
        ListTags,
        /// <summary>
        /// 
        /// </summary>
        ListTagsForResource,
        /// <summary>
        /// 
        /// </summary>
        ListWorkspaceMembers,
        /// <summary>
        /// 
        /// </summary>
        ListWorkspaces,
        /// <summary>
        /// 
        /// </summary>
        Login,
        /// <summary>
        /// 
        /// </summary>
        McpProxy,
        /// <summary>
        /// 
        /// </summary>
        McpProxyGet,
        /// <summary>
        /// 
        /// </summary>
        PopulateAnnotationQueue,
        /// <summary>
        /// 
        /// </summary>
        QueryRun,
        /// <summary>
        /// 
        /// </summary>
        QueryRuns,
        /// <summary>
        /// 
        /// </summary>
        QueryThreadTraces,
        /// <summary>
        /// 
        /// </summary>
        QueryThreads,
        /// <summary>
        /// 
        /// </summary>
        QueryTrace,
        /// <summary>
        /// 
        /// </summary>
        QueryTraceMessages,
        /// <summary>
        /// 
        /// </summary>
        ReadAccessPolicy,
        /// <summary>
        /// 
        /// </summary>
        ReadBulkExportDestination,
        /// <summary>
        /// 
        /// </summary>
        ReadChart,
        /// <summary>
        /// 
        /// </summary>
        ReadChartPreview,
        /// <summary>
        /// 
        /// </summary>
        ReadChartSection,
        /// <summary>
        /// 
        /// </summary>
        ReadCharts,
        /// <summary>
        /// 
        /// </summary>
        ReadDatasetDelta,
        /// <summary>
        /// 
        /// </summary>
        ReadDatasetShareState,
        /// <summary>
        /// 
        /// </summary>
        ReadExample,
        /// <summary>
        /// 
        /// </summary>
        ReadExamples,
        /// <summary>
        /// 
        /// </summary>
        ReadFeedback,
        /// <summary>
        /// 
        /// </summary>
        ReadFeedbacks,
        /// <summary>
        /// 
        /// </summary>
        ReadModelPriceMap,
        /// <summary>
        /// 
        /// </summary>
        ReadRoleAccessPolicies,
        /// <summary>
        /// 
        /// </summary>
        ReadRun,
        /// <summary>
        /// 
        /// </summary>
        ReadRuns,
        /// <summary>
        /// 
        /// </summary>
        ReadSharedDelta,
        /// <summary>
        /// 
        /// </summary>
        ReadSharedDeltaStream,
        /// <summary>
        /// 
        /// </summary>
        ReadTracingDashboard,
        /// <summary>
        /// 
        /// </summary>
        RegisterMcpServerOauth,
        /// <summary>
        /// 
        /// </summary>
        RemoveAnnotationQueueReviewer,
        /// <summary>
        /// 
        /// </summary>
        RenameFilterView,
        /// <summary>
        /// 
        /// </summary>
        ResolveAnnotationQueueRun,
        /// <summary>
        /// 
        /// </summary>
        SendSsoEmailConfirmation,
        /// <summary>
        /// 
        /// </summary>
        SetTenantHandle,
        /// <summary>
        /// 
        /// </summary>
        ShareDataset,
        /// <summary>
        /// 
        /// </summary>
        StreamDatasetComparisonView,
        /// <summary>
        /// 
        /// </summary>
        StreamFeedbackDelta,
        /// <summary>
        /// 
        /// </summary>
        SubmitNpsResponse,
        /// <summary>
        /// 
        /// </summary>
        SyncExamples,
        /// <summary>
        /// 
        /// </summary>
        TestAlertRule,
        /// <summary>
        /// 
        /// </summary>
        TestFleetWebhook,
        /// <summary>
        /// 
        /// </summary>
        TestPromptWebhook,
        /// <summary>
        /// 
        /// </summary>
        TriggerForgeConfiguration,
        /// <summary>
        /// 
        /// </summary>
        UnshareDataset,
        /// <summary>
        /// 
        /// </summary>
        UnshareEntities,
        /// <summary>
        /// 
        /// </summary>
        UpdateAlertRule,
        /// <summary>
        /// 
        /// </summary>
        UpdateAnnotationQueue,
        /// <summary>
        /// 
        /// </summary>
        UpdateAnnotationQueueRun,
        /// <summary>
        /// 
        /// </summary>
        UpdateBasicAuthUser,
        /// <summary>
        /// 
        /// </summary>
        UpdateBulkExportDestination,
        /// <summary>
        /// 
        /// </summary>
        UpdateBusinessInfo,
        /// <summary>
        /// 
        /// </summary>
        UpdateChart,
        /// <summary>
        /// 
        /// </summary>
        UpdateChartSection,
        /// <summary>
        /// 
        /// </summary>
        UpdateDataset,
        /// <summary>
        /// 
        /// </summary>
        UpdateDatasetSplits,
        /// <summary>
        /// 
        /// </summary>
        UpdateDatasetVersion,
        /// <summary>
        /// 
        /// </summary>
        UpdateDefaultSsoProvisionOrganization,
        /// <summary>
        /// 
        /// </summary>
        UpdateDeployment,
        /// <summary>
        /// 
        /// </summary>
        UpdateEvaluator,
        /// <summary>
        /// 
        /// </summary>
        UpdateExample,
        /// <summary>
        /// 
        /// </summary>
        UpdateExamples,
        /// <summary>
        /// 
        /// </summary>
        UpdateExperimentViewOverride,
        /// <summary>
        /// 
        /// </summary>
        UpdateFeedbackConfig,
        /// <summary>
        /// 
        /// </summary>
        UpdateFeedbackFormula,
        /// <summary>
        /// 
        /// </summary>
        UpdateFilterView,
        /// <summary>
        /// 
        /// </summary>
        UpdateFleetUsageLimit,
        /// <summary>
        /// 
        /// </summary>
        UpdateFleetWebhook,
        /// <summary>
        /// 
        /// </summary>
        UpdateForgeConfiguration,
        /// <summary>
        /// 
        /// </summary>
        UpdateGatewayPolicy,
        /// <summary>
        /// 
        /// </summary>
        UpdateHubEnvironment,
        /// <summary>
        /// 
        /// </summary>
        UpdateInsightsJob,
        /// <summary>
        /// 
        /// </summary>
        UpdateInsightsJobConfig,
        /// <summary>
        /// 
        /// </summary>
        UpdateLoginMethods,
        /// <summary>
        /// 
        /// </summary>
        UpdateMcpServer,
        /// <summary>
        /// 
        /// </summary>
        UpdateMcpVendorSettings,
        /// <summary>
        /// 
        /// </summary>
        UpdateModelPriceMap,
        /// <summary>
        /// 
        /// </summary>
        UpdateOnboardingState,
        /// <summary>
        /// 
        /// </summary>
        UpdateOrgChart,
        /// <summary>
        /// 
        /// </summary>
        UpdateOrgChartSection,
        /// <summary>
        /// 
        /// </summary>
        UpdateOrgMember,
        /// <summary>
        /// 
        /// </summary>
        UpdateOrganizationInfo,
        /// <summary>
        /// 
        /// </summary>
        UpdatePaymentMethod,
        /// <summary>
        /// 
        /// </summary>
        UpdatePaymentPlan,
        /// <summary>
        /// 
        /// </summary>
        UpdatePlaygroundSettings,
        /// <summary>
        /// 
        /// </summary>
        UpdatePromptCanvasQuickAction,
        /// <summary>
        /// 
        /// </summary>
        UpdatePromptWebhook,
        /// <summary>
        /// 
        /// </summary>
        UpdateRole,
        /// <summary>
        /// 
        /// </summary>
        UpdateSandboxProxyProfile,
        /// <summary>
        /// 
        /// </summary>
        UpdateScimGroup,
        /// <summary>
        /// 
        /// </summary>
        UpdateScimToken,
        /// <summary>
        /// 
        /// </summary>
        UpdateScimUser,
        /// <summary>
        /// 
        /// </summary>
        UpdateSelfHostedCustomer,
        /// <summary>
        /// 
        /// </summary>
        UpdateSelfHostedLicense,
        /// <summary>
        /// 
        /// </summary>
        UpdateSsoSettings,
        /// <summary>
        /// 
        /// </summary>
        UpdateTagKey,
        /// <summary>
        /// 
        /// </summary>
        UpdateTagValue,
        /// <summary>
        /// 
        /// </summary>
        UpdateTool,
        /// <summary>
        /// 
        /// </summary>
        UpdateTracerSession,
        /// <summary>
        /// 
        /// </summary>
        UpdateTtlSettings,
        /// <summary>
        /// 
        /// </summary>
        UpdateUsageLimit,
        /// <summary>
        /// 
        /// </summary>
        UpdateWorkspace,
        /// <summary>
        /// 
        /// </summary>
        UpdateWorkspaceMember,
        /// <summary>
        /// 
        /// </summary>
        UpdateWorkspaceSecrets,
        /// <summary>
        /// 
        /// </summary>
        UpsertFeatureDefaultModel,
        /// <summary>
        /// 
        /// </summary>
        UpsertFeatureDisabledModel,
        /// <summary>
        /// 
        /// </summary>
        ValidateExample,
        /// <summary>
        /// 
        /// </summary>
        ValidateExamples,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuditLogOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuditLogOperation value)
        {
            return value switch
            {
                AuditLogOperation.AddAnnotationQueueReviewer => "add_annotation_queue_reviewer",
                AuditLogOperation.AddBasicAuthUsersToOrg => "add_basic_auth_users_to_org",
                AuditLogOperation.AddMemberToWorkspace => "add_member_to_workspace",
                AuditLogOperation.AddMembersToWorkspaceBatch => "add_members_to_workspace_batch",
                AuditLogOperation.AddRunsToAnnotationQueue => "add_runs_to_annotation_queue",
                AuditLogOperation.AttachAccessPolicies => "attach_access_policies",
                AuditLogOperation.BatchQueryTraceMessages => "batch_query_trace_messages",
                AuditLogOperation.BulkDeleteEvaluators => "bulk_delete_evaluators",
                AuditLogOperation.CancelBulkExport => "cancel_bulk_export",
                AuditLogOperation.ClaimPendingOrganizationInvite => "claim_pending_organization_invite",
                AuditLogOperation.ClaimPendingWorkspaceInvite => "claim_pending_workspace_invite",
                AuditLogOperation.CloneChartSection => "clone_chart_section",
                AuditLogOperation.CloneDataset => "clone_dataset",
                AuditLogOperation.ConfirmPaymentCheckoutSession => "confirm_payment_checkout_session",
                AuditLogOperation.ConfirmSsoUserEmail => "confirm_sso_user_email",
                AuditLogOperation.CountExamples => "count_examples",
                AuditLogOperation.CreateAccessPolicy => "create_access_policy",
                AuditLogOperation.CreateAlertRule => "create_alert_rule",
                AuditLogOperation.CreateAnnotationQueue => "create_annotation_queue",
                AuditLogOperation.CreateAnnotationQueueRunStatus => "create_annotation_queue_run_status",
                AuditLogOperation.CreateApiKey => "create_api_key",
                AuditLogOperation.CreateBulkExport => "create_bulk_export",
                AuditLogOperation.CreateBulkExportDestination => "create_bulk_export_destination",
                AuditLogOperation.CreateChart => "create_chart",
                AuditLogOperation.CreateChartSection => "create_chart_section",
                AuditLogOperation.CreateCommit => "create_commit",
                AuditLogOperation.CreateComparativeExperiment => "create_comparative_experiment",
                AuditLogOperation.CreateCsvDataset => "create_csv_dataset",
                AuditLogOperation.CreateDataset => "create_dataset",
                AuditLogOperation.CreateDeployment => "create_deployment",
                AuditLogOperation.CreateDirectoryCommit => "create_directory_commit",
                AuditLogOperation.CreateEvaluator => "create_evaluator",
                AuditLogOperation.CreateExample => "create_example",
                AuditLogOperation.CreateExamples => "create_examples",
                AuditLogOperation.CreateExperimentViaUpload => "create_experiment_via_upload",
                AuditLogOperation.CreateExperimentViewOverride => "create_experiment_view_override",
                AuditLogOperation.CreateFeedbackConfig => "create_feedback_config",
                AuditLogOperation.CreateFeedbackFormula => "create_feedback_formula",
                AuditLogOperation.CreateFilterView => "create_filter_view",
                AuditLogOperation.CreateFleetUsageLimit => "create_fleet_usage_limit",
                AuditLogOperation.CreateFleetWebhook => "create_fleet_webhook",
                AuditLogOperation.CreateForgeConfiguration => "create_forge_configuration",
                AuditLogOperation.CreateGatewayPolicy => "create_gateway_policy",
                AuditLogOperation.CreateHubEnvironment => "create_hub_environment",
                AuditLogOperation.CreateInsightsJob => "create_insights_job",
                AuditLogOperation.CreateInsightsJobConfig => "create_insights_job_config",
                AuditLogOperation.CreateMcpServer => "create_mcp_server",
                AuditLogOperation.CreateMcpVendorSettings => "create_mcp_vendor_settings",
                AuditLogOperation.CreateModelPriceMap => "create_model_price_map",
                AuditLogOperation.CreateOnboardingState => "create_onboarding_state",
                AuditLogOperation.CreateOrgChart => "create_org_chart",
                AuditLogOperation.CreateOrgChartSection => "create_org_chart_section",
                AuditLogOperation.CreateOrganization => "create_organization",
                AuditLogOperation.CreatePaymentAccountLink => "create_payment_account_link",
                AuditLogOperation.CreatePaymentCheckoutSession => "create_payment_checkout_session",
                AuditLogOperation.CreatePaymentSetupIntent => "create_payment_setup_intent",
                AuditLogOperation.CreatePersonalAccessToken => "create_personal_access_token",
                AuditLogOperation.CreatePlaygroundExperiment => "create_playground_experiment",
                AuditLogOperation.CreatePlaygroundSettings => "create_playground_settings",
                AuditLogOperation.CreatePromptCanvasQuickAction => "create_prompt_canvas_quick_action",
                AuditLogOperation.CreatePromptWebhook => "create_prompt_webhook",
                AuditLogOperation.CreateRole => "create_role",
                AuditLogOperation.CreateSandboxProxyProfile => "create_sandbox_proxy_profile",
                AuditLogOperation.CreateScimGroup => "create_scim_group",
                AuditLogOperation.CreateScimToken => "create_scim_token",
                AuditLogOperation.CreateScimUser => "create_scim_user",
                AuditLogOperation.CreateServiceAccount => "create_service_account",
                AuditLogOperation.CreateServiceKey => "create_service_key",
                AuditLogOperation.CreateSsoSettings => "create_sso_settings",
                AuditLogOperation.CreateTagKey => "create_tag_key",
                AuditLogOperation.CreateTagValue => "create_tag_value",
                AuditLogOperation.CreateTagging => "create_tagging",
                AuditLogOperation.CreateTenant => "create_tenant",
                AuditLogOperation.CreateTool => "create_tool",
                AuditLogOperation.CreateWorkspace => "create_workspace",
                AuditLogOperation.DeleteAccessPolicy => "delete_access_policy",
                AuditLogOperation.DeleteAlertRule => "delete_alert_rule",
                AuditLogOperation.DeleteAnnotationQueue => "delete_annotation_queue",
                AuditLogOperation.DeleteAnnotationQueueRun => "delete_annotation_queue_run",
                AuditLogOperation.DeleteAnnotationQueueRuns => "delete_annotation_queue_runs",
                AuditLogOperation.DeleteAnnotationQueues => "delete_annotation_queues",
                AuditLogOperation.DeleteApiKey => "delete_api_key",
                AuditLogOperation.DeleteChart => "delete_chart",
                AuditLogOperation.DeleteChartSection => "delete_chart_section",
                AuditLogOperation.DeleteComparativeExperiment => "delete_comparative_experiment",
                AuditLogOperation.DeleteDataset => "delete_dataset",
                AuditLogOperation.DeleteDatasets => "delete_datasets",
                AuditLogOperation.DeleteDeployment => "delete_deployment",
                AuditLogOperation.DeleteDirectory => "delete_directory",
                AuditLogOperation.DeleteEvaluator => "delete_evaluator",
                AuditLogOperation.DeleteExample => "delete_example",
                AuditLogOperation.DeleteExamples => "delete_examples",
                AuditLogOperation.DeleteExperimentViewOverride => "delete_experiment_view_override",
                AuditLogOperation.DeleteFeatureDefaultModel => "delete_feature_default_model",
                AuditLogOperation.DeleteFeatureDisabledModel => "delete_feature_disabled_model",
                AuditLogOperation.DeleteFeedbackConfig => "delete_feedback_config",
                AuditLogOperation.DeleteFeedbackFormula => "delete_feedback_formula",
                AuditLogOperation.DeleteFilterView => "delete_filter_view",
                AuditLogOperation.DeleteFleetUsageLimit => "delete_fleet_usage_limit",
                AuditLogOperation.DeleteFleetWebhook => "delete_fleet_webhook",
                AuditLogOperation.DeleteForgeConfiguration => "delete_forge_configuration",
                AuditLogOperation.DeleteGatewayPolicy => "delete_gateway_policy",
                AuditLogOperation.DeleteHubEnvironment => "delete_hub_environment",
                AuditLogOperation.DeleteInsightsJob => "delete_insights_job",
                AuditLogOperation.DeleteInsightsJobConfig => "delete_insights_job_config",
                AuditLogOperation.DeleteMcpServer => "delete_mcp_server",
                AuditLogOperation.DeleteMcpVendorSettings => "delete_mcp_vendor_settings",
                AuditLogOperation.DeleteModelPriceMap => "delete_model_price_map",
                AuditLogOperation.DeleteOrgChart => "delete_org_chart",
                AuditLogOperation.DeleteOrgChartSection => "delete_org_chart_section",
                AuditLogOperation.DeleteOrgMember => "delete_org_member",
                AuditLogOperation.DeleteOrgPendingMember => "delete_org_pending_member",
                AuditLogOperation.DeletePendingOrganizationInvite => "delete_pending_organization_invite",
                AuditLogOperation.DeletePendingWorkspaceInvite => "delete_pending_workspace_invite",
                AuditLogOperation.DeletePersonalAccessToken => "delete_personal_access_token",
                AuditLogOperation.DeletePlaygroundSettings => "delete_playground_settings",
                AuditLogOperation.DeletePromptCanvasQuickAction => "delete_prompt_canvas_quick_action",
                AuditLogOperation.DeletePromptWebhook => "delete_prompt_webhook",
                AuditLogOperation.DeleteRole => "delete_role",
                AuditLogOperation.DeleteRuns => "delete_runs",
                AuditLogOperation.DeleteSandboxProxyProfile => "delete_sandbox_proxy_profile",
                AuditLogOperation.DeleteScimGroup => "delete_scim_group",
                AuditLogOperation.DeleteScimToken => "delete_scim_token",
                AuditLogOperation.DeleteScimUser => "delete_scim_user",
                AuditLogOperation.DeleteServiceAccount => "delete_service_account",
                AuditLogOperation.DeleteServiceKey => "delete_service_key",
                AuditLogOperation.DeleteSsoSettings => "delete_sso_settings",
                AuditLogOperation.DeleteTagKey => "delete_tag_key",
                AuditLogOperation.DeleteTagValue => "delete_tag_value",
                AuditLogOperation.DeleteTagging => "delete_tagging",
                AuditLogOperation.DeleteTool => "delete_tool",
                AuditLogOperation.DeleteTracerSession => "delete_tracer_session",
                AuditLogOperation.DeleteTracerSessions => "delete_tracer_sessions",
                AuditLogOperation.DeleteUsageLimit => "delete_usage_limit",
                AuditLogOperation.DeleteWorkspace => "delete_workspace",
                AuditLogOperation.DeleteWorkspaceMember => "delete_workspace_member",
                AuditLogOperation.DeleteWorkspacePendingMember => "delete_workspace_pending_member",
                AuditLogOperation.DiffDatasetVersions => "diff_dataset_versions",
                AuditLogOperation.DownloadDataset => "download_dataset",
                AuditLogOperation.EvaluateExperiment => "evaluate_experiment",
                AuditLogOperation.ExecuteCustomCode => "execute_custom_code",
                AuditLogOperation.ExportAnnotationQueue => "export_annotation_queue",
                AuditLogOperation.ExportGranularUsageCsv => "export_granular_usage_csv",
                AuditLogOperation.ExportUsageBackfillCsv => "export_usage_backfill_csv",
                AuditLogOperation.GenerateDataset => "generate_dataset",
                AuditLogOperation.GenerateInsightsJobConfig => "generate_insights_job_config",
                AuditLogOperation.GenerateRunsQuery => "generate_runs_query",
                AuditLogOperation.GenerateSharedDatasetQuery => "generate_shared_dataset_query",
                AuditLogOperation.GetAnnotationQueue => "get_annotation_queue",
                AuditLogOperation.GetAnnotationQueueArchivedSize => "get_annotation_queue_archived_size",
                AuditLogOperation.GetAnnotationQueueRun => "get_annotation_queue_run",
                AuditLogOperation.GetAnnotationQueueRuns => "get_annotation_queue_runs",
                AuditLogOperation.GetAnnotationQueueSize => "get_annotation_queue_size",
                AuditLogOperation.GetAnnotationQueueTotalSize => "get_annotation_queue_total_size",
                AuditLogOperation.GetAnnotationQueuesForRun => "get_annotation_queues_for_run",
                AuditLogOperation.GetAuditLogs => "get_audit_logs",
                AuditLogOperation.GetBulkExport => "get_bulk_export",
                AuditLogOperation.GetBulkExportRun => "get_bulk_export_run",
                AuditLogOperation.GetBulkExportRuns => "get_bulk_export_runs",
                AuditLogOperation.GetBulkExportRunsFiltered => "get_bulk_export_runs_filtered",
                AuditLogOperation.GetCompanyInfo => "get_company_info",
                AuditLogOperation.GetDatasetComparisonView => "get_dataset_comparison_view",
                AuditLogOperation.GetDatasetVersion => "get_dataset_version",
                AuditLogOperation.GetDatasetVersions => "get_dataset_versions",
                AuditLogOperation.GetExample => "get_example",
                AuditLogOperation.GetExperimentViewOverride => "get_experiment_view_override",
                AuditLogOperation.GetExperimentViewOverrides => "get_experiment_view_overrides",
                AuditLogOperation.GetFeedbackFormula => "get_feedback_formula",
                AuditLogOperation.GetFilterView => "get_filter_view",
                AuditLogOperation.GetGranularUsage => "get_granular_usage",
                AuditLogOperation.GetInsightsJob => "get_insights_job",
                AuditLogOperation.GetInsightsJobRuns => "get_insights_job_runs",
                AuditLogOperation.GetLoginMethods => "get_login_methods",
                AuditLogOperation.GetMcpTools => "get_mcp_tools",
                AuditLogOperation.GetOnboardingState => "get_onboarding_state",
                AuditLogOperation.GetOrgDashboard => "get_org_dashboard",
                AuditLogOperation.GetOrgUsage => "get_org_usage",
                AuditLogOperation.GetOrgUsageLimits => "get_org_usage_limits",
                AuditLogOperation.GetOrganizationBillingInfo => "get_organization_billing_info",
                AuditLogOperation.GetOrganizationInfo => "get_organization_info",
                AuditLogOperation.GetPairwiseQueue => "get_pairwise_queue",
                AuditLogOperation.GetRunCluster => "get_run_cluster",
                AuditLogOperation.GetSharedExamplesCount => "get_shared_examples_count",
                AuditLogOperation.GetSharedTokens => "get_shared_tokens",
                AuditLogOperation.GetSsoSettings => "get_sso_settings",
                AuditLogOperation.GetSsoSettingsCurrent => "get_sso_settings_current",
                AuditLogOperation.GetTagKey => "get_tag_key",
                AuditLogOperation.GetTagValue => "get_tag_value",
                AuditLogOperation.GetUsageLimits => "get_usage_limits",
                AuditLogOperation.GetWorkspaceStats => "get_workspace_stats",
                AuditLogOperation.GetWorkspaceUsageLimitsInfo => "get_workspace_usage_limits_info",
                AuditLogOperation.InvalidateMcpToolsCache => "invalidate_mcp_tools_cache",
                AuditLogOperation.InviteUserToOrg => "invite_user_to_org",
                AuditLogOperation.InviteUsersToOrgBatch => "invite_users_to_org_batch",
                AuditLogOperation.ListAccessPolicies => "list_access_policies",
                AuditLogOperation.ListAnnotationQueues => "list_annotation_queues",
                AuditLogOperation.ListBulkExportDestinations => "list_bulk_export_destinations",
                AuditLogOperation.ListBulkExports => "list_bulk_exports",
                AuditLogOperation.ListChartSections => "list_chart_sections",
                AuditLogOperation.ListExamples => "list_examples",
                AuditLogOperation.ListFeedbackConfigs => "list_feedback_configs",
                AuditLogOperation.ListFeedbackFormulas => "list_feedback_formulas",
                AuditLogOperation.ListFilterViews => "list_filter_views",
                AuditLogOperation.ListInsightsJobConfigs => "list_insights_job_configs",
                AuditLogOperation.ListInsightsJobs => "list_insights_jobs",
                AuditLogOperation.ListOrgMembers => "list_org_members",
                AuditLogOperation.ListOrgPersonalAccessTokens => "list_org_personal_access_tokens",
                AuditLogOperation.ListOrgServiceKeys => "list_org_service_keys",
                AuditLogOperation.ListOrganizationRoles => "list_organization_roles",
                AuditLogOperation.ListOrganizations => "list_organizations",
                AuditLogOperation.ListPairwiseEntries => "list_pairwise_entries",
                AuditLogOperation.ListPairwiseQueues => "list_pairwise_queues",
                AuditLogOperation.ListPendingOrganizationInvites => "list_pending_organization_invites",
                AuditLogOperation.ListPendingWorkspaceInvites => "list_pending_workspace_invites",
                AuditLogOperation.ListPermissions => "list_permissions",
                AuditLogOperation.ListServiceAccounts => "list_service_accounts",
                AuditLogOperation.ListTagKeys => "list_tag_keys",
                AuditLogOperation.ListTagValues => "list_tag_values",
                AuditLogOperation.ListTaggings => "list_taggings",
                AuditLogOperation.ListTags => "list_tags",
                AuditLogOperation.ListTagsForResource => "list_tags_for_resource",
                AuditLogOperation.ListWorkspaceMembers => "list_workspace_members",
                AuditLogOperation.ListWorkspaces => "list_workspaces",
                AuditLogOperation.Login => "login",
                AuditLogOperation.McpProxy => "mcp_proxy",
                AuditLogOperation.McpProxyGet => "mcp_proxy_get",
                AuditLogOperation.PopulateAnnotationQueue => "populate_annotation_queue",
                AuditLogOperation.QueryRun => "query_run",
                AuditLogOperation.QueryRuns => "query_runs",
                AuditLogOperation.QueryThreadTraces => "query_thread_traces",
                AuditLogOperation.QueryThreads => "query_threads",
                AuditLogOperation.QueryTrace => "query_trace",
                AuditLogOperation.QueryTraceMessages => "query_trace_messages",
                AuditLogOperation.ReadAccessPolicy => "read_access_policy",
                AuditLogOperation.ReadBulkExportDestination => "read_bulk_export_destination",
                AuditLogOperation.ReadChart => "read_chart",
                AuditLogOperation.ReadChartPreview => "read_chart_preview",
                AuditLogOperation.ReadChartSection => "read_chart_section",
                AuditLogOperation.ReadCharts => "read_charts",
                AuditLogOperation.ReadDatasetDelta => "read_dataset_delta",
                AuditLogOperation.ReadDatasetShareState => "read_dataset_share_state",
                AuditLogOperation.ReadExample => "read_example",
                AuditLogOperation.ReadExamples => "read_examples",
                AuditLogOperation.ReadFeedback => "read_feedback",
                AuditLogOperation.ReadFeedbacks => "read_feedbacks",
                AuditLogOperation.ReadModelPriceMap => "read_model_price_map",
                AuditLogOperation.ReadRoleAccessPolicies => "read_role_access_policies",
                AuditLogOperation.ReadRun => "read_run",
                AuditLogOperation.ReadRuns => "read_runs",
                AuditLogOperation.ReadSharedDelta => "read_shared_delta",
                AuditLogOperation.ReadSharedDeltaStream => "read_shared_delta_stream",
                AuditLogOperation.ReadTracingDashboard => "read_tracing_dashboard",
                AuditLogOperation.RegisterMcpServerOauth => "register_mcp_server_oauth",
                AuditLogOperation.RemoveAnnotationQueueReviewer => "remove_annotation_queue_reviewer",
                AuditLogOperation.RenameFilterView => "rename_filter_view",
                AuditLogOperation.ResolveAnnotationQueueRun => "resolve_annotation_queue_run",
                AuditLogOperation.SendSsoEmailConfirmation => "send_sso_email_confirmation",
                AuditLogOperation.SetTenantHandle => "set_tenant_handle",
                AuditLogOperation.ShareDataset => "share_dataset",
                AuditLogOperation.StreamDatasetComparisonView => "stream_dataset_comparison_view",
                AuditLogOperation.StreamFeedbackDelta => "stream_feedback_delta",
                AuditLogOperation.SubmitNpsResponse => "submit_nps_response",
                AuditLogOperation.SyncExamples => "sync_examples",
                AuditLogOperation.TestAlertRule => "test_alert_rule",
                AuditLogOperation.TestFleetWebhook => "test_fleet_webhook",
                AuditLogOperation.TestPromptWebhook => "test_prompt_webhook",
                AuditLogOperation.TriggerForgeConfiguration => "trigger_forge_configuration",
                AuditLogOperation.UnshareDataset => "unshare_dataset",
                AuditLogOperation.UnshareEntities => "unshare_entities",
                AuditLogOperation.UpdateAlertRule => "update_alert_rule",
                AuditLogOperation.UpdateAnnotationQueue => "update_annotation_queue",
                AuditLogOperation.UpdateAnnotationQueueRun => "update_annotation_queue_run",
                AuditLogOperation.UpdateBasicAuthUser => "update_basic_auth_user",
                AuditLogOperation.UpdateBulkExportDestination => "update_bulk_export_destination",
                AuditLogOperation.UpdateBusinessInfo => "update_business_info",
                AuditLogOperation.UpdateChart => "update_chart",
                AuditLogOperation.UpdateChartSection => "update_chart_section",
                AuditLogOperation.UpdateDataset => "update_dataset",
                AuditLogOperation.UpdateDatasetSplits => "update_dataset_splits",
                AuditLogOperation.UpdateDatasetVersion => "update_dataset_version",
                AuditLogOperation.UpdateDefaultSsoProvisionOrganization => "update_default_sso_provision_organization",
                AuditLogOperation.UpdateDeployment => "update_deployment",
                AuditLogOperation.UpdateEvaluator => "update_evaluator",
                AuditLogOperation.UpdateExample => "update_example",
                AuditLogOperation.UpdateExamples => "update_examples",
                AuditLogOperation.UpdateExperimentViewOverride => "update_experiment_view_override",
                AuditLogOperation.UpdateFeedbackConfig => "update_feedback_config",
                AuditLogOperation.UpdateFeedbackFormula => "update_feedback_formula",
                AuditLogOperation.UpdateFilterView => "update_filter_view",
                AuditLogOperation.UpdateFleetUsageLimit => "update_fleet_usage_limit",
                AuditLogOperation.UpdateFleetWebhook => "update_fleet_webhook",
                AuditLogOperation.UpdateForgeConfiguration => "update_forge_configuration",
                AuditLogOperation.UpdateGatewayPolicy => "update_gateway_policy",
                AuditLogOperation.UpdateHubEnvironment => "update_hub_environment",
                AuditLogOperation.UpdateInsightsJob => "update_insights_job",
                AuditLogOperation.UpdateInsightsJobConfig => "update_insights_job_config",
                AuditLogOperation.UpdateLoginMethods => "update_login_methods",
                AuditLogOperation.UpdateMcpServer => "update_mcp_server",
                AuditLogOperation.UpdateMcpVendorSettings => "update_mcp_vendor_settings",
                AuditLogOperation.UpdateModelPriceMap => "update_model_price_map",
                AuditLogOperation.UpdateOnboardingState => "update_onboarding_state",
                AuditLogOperation.UpdateOrgChart => "update_org_chart",
                AuditLogOperation.UpdateOrgChartSection => "update_org_chart_section",
                AuditLogOperation.UpdateOrgMember => "update_org_member",
                AuditLogOperation.UpdateOrganizationInfo => "update_organization_info",
                AuditLogOperation.UpdatePaymentMethod => "update_payment_method",
                AuditLogOperation.UpdatePaymentPlan => "update_payment_plan",
                AuditLogOperation.UpdatePlaygroundSettings => "update_playground_settings",
                AuditLogOperation.UpdatePromptCanvasQuickAction => "update_prompt_canvas_quick_action",
                AuditLogOperation.UpdatePromptWebhook => "update_prompt_webhook",
                AuditLogOperation.UpdateRole => "update_role",
                AuditLogOperation.UpdateSandboxProxyProfile => "update_sandbox_proxy_profile",
                AuditLogOperation.UpdateScimGroup => "update_scim_group",
                AuditLogOperation.UpdateScimToken => "update_scim_token",
                AuditLogOperation.UpdateScimUser => "update_scim_user",
                AuditLogOperation.UpdateSelfHostedCustomer => "update_self_hosted_customer",
                AuditLogOperation.UpdateSelfHostedLicense => "update_self_hosted_license",
                AuditLogOperation.UpdateSsoSettings => "update_sso_settings",
                AuditLogOperation.UpdateTagKey => "update_tag_key",
                AuditLogOperation.UpdateTagValue => "update_tag_value",
                AuditLogOperation.UpdateTool => "update_tool",
                AuditLogOperation.UpdateTracerSession => "update_tracer_session",
                AuditLogOperation.UpdateTtlSettings => "update_ttl_settings",
                AuditLogOperation.UpdateUsageLimit => "update_usage_limit",
                AuditLogOperation.UpdateWorkspace => "update_workspace",
                AuditLogOperation.UpdateWorkspaceMember => "update_workspace_member",
                AuditLogOperation.UpdateWorkspaceSecrets => "update_workspace_secrets",
                AuditLogOperation.UpsertFeatureDefaultModel => "upsert_feature_default_model",
                AuditLogOperation.UpsertFeatureDisabledModel => "upsert_feature_disabled_model",
                AuditLogOperation.ValidateExample => "validate_example",
                AuditLogOperation.ValidateExamples => "validate_examples",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuditLogOperation? ToEnum(string value)
        {
            return value switch
            {
                "add_annotation_queue_reviewer" => AuditLogOperation.AddAnnotationQueueReviewer,
                "add_basic_auth_users_to_org" => AuditLogOperation.AddBasicAuthUsersToOrg,
                "add_member_to_workspace" => AuditLogOperation.AddMemberToWorkspace,
                "add_members_to_workspace_batch" => AuditLogOperation.AddMembersToWorkspaceBatch,
                "add_runs_to_annotation_queue" => AuditLogOperation.AddRunsToAnnotationQueue,
                "attach_access_policies" => AuditLogOperation.AttachAccessPolicies,
                "batch_query_trace_messages" => AuditLogOperation.BatchQueryTraceMessages,
                "bulk_delete_evaluators" => AuditLogOperation.BulkDeleteEvaluators,
                "cancel_bulk_export" => AuditLogOperation.CancelBulkExport,
                "claim_pending_organization_invite" => AuditLogOperation.ClaimPendingOrganizationInvite,
                "claim_pending_workspace_invite" => AuditLogOperation.ClaimPendingWorkspaceInvite,
                "clone_chart_section" => AuditLogOperation.CloneChartSection,
                "clone_dataset" => AuditLogOperation.CloneDataset,
                "confirm_payment_checkout_session" => AuditLogOperation.ConfirmPaymentCheckoutSession,
                "confirm_sso_user_email" => AuditLogOperation.ConfirmSsoUserEmail,
                "count_examples" => AuditLogOperation.CountExamples,
                "create_access_policy" => AuditLogOperation.CreateAccessPolicy,
                "create_alert_rule" => AuditLogOperation.CreateAlertRule,
                "create_annotation_queue" => AuditLogOperation.CreateAnnotationQueue,
                "create_annotation_queue_run_status" => AuditLogOperation.CreateAnnotationQueueRunStatus,
                "create_api_key" => AuditLogOperation.CreateApiKey,
                "create_bulk_export" => AuditLogOperation.CreateBulkExport,
                "create_bulk_export_destination" => AuditLogOperation.CreateBulkExportDestination,
                "create_chart" => AuditLogOperation.CreateChart,
                "create_chart_section" => AuditLogOperation.CreateChartSection,
                "create_commit" => AuditLogOperation.CreateCommit,
                "create_comparative_experiment" => AuditLogOperation.CreateComparativeExperiment,
                "create_csv_dataset" => AuditLogOperation.CreateCsvDataset,
                "create_dataset" => AuditLogOperation.CreateDataset,
                "create_deployment" => AuditLogOperation.CreateDeployment,
                "create_directory_commit" => AuditLogOperation.CreateDirectoryCommit,
                "create_evaluator" => AuditLogOperation.CreateEvaluator,
                "create_example" => AuditLogOperation.CreateExample,
                "create_examples" => AuditLogOperation.CreateExamples,
                "create_experiment_via_upload" => AuditLogOperation.CreateExperimentViaUpload,
                "create_experiment_view_override" => AuditLogOperation.CreateExperimentViewOverride,
                "create_feedback_config" => AuditLogOperation.CreateFeedbackConfig,
                "create_feedback_formula" => AuditLogOperation.CreateFeedbackFormula,
                "create_filter_view" => AuditLogOperation.CreateFilterView,
                "create_fleet_usage_limit" => AuditLogOperation.CreateFleetUsageLimit,
                "create_fleet_webhook" => AuditLogOperation.CreateFleetWebhook,
                "create_forge_configuration" => AuditLogOperation.CreateForgeConfiguration,
                "create_gateway_policy" => AuditLogOperation.CreateGatewayPolicy,
                "create_hub_environment" => AuditLogOperation.CreateHubEnvironment,
                "create_insights_job" => AuditLogOperation.CreateInsightsJob,
                "create_insights_job_config" => AuditLogOperation.CreateInsightsJobConfig,
                "create_mcp_server" => AuditLogOperation.CreateMcpServer,
                "create_mcp_vendor_settings" => AuditLogOperation.CreateMcpVendorSettings,
                "create_model_price_map" => AuditLogOperation.CreateModelPriceMap,
                "create_onboarding_state" => AuditLogOperation.CreateOnboardingState,
                "create_org_chart" => AuditLogOperation.CreateOrgChart,
                "create_org_chart_section" => AuditLogOperation.CreateOrgChartSection,
                "create_organization" => AuditLogOperation.CreateOrganization,
                "create_payment_account_link" => AuditLogOperation.CreatePaymentAccountLink,
                "create_payment_checkout_session" => AuditLogOperation.CreatePaymentCheckoutSession,
                "create_payment_setup_intent" => AuditLogOperation.CreatePaymentSetupIntent,
                "create_personal_access_token" => AuditLogOperation.CreatePersonalAccessToken,
                "create_playground_experiment" => AuditLogOperation.CreatePlaygroundExperiment,
                "create_playground_settings" => AuditLogOperation.CreatePlaygroundSettings,
                "create_prompt_canvas_quick_action" => AuditLogOperation.CreatePromptCanvasQuickAction,
                "create_prompt_webhook" => AuditLogOperation.CreatePromptWebhook,
                "create_role" => AuditLogOperation.CreateRole,
                "create_sandbox_proxy_profile" => AuditLogOperation.CreateSandboxProxyProfile,
                "create_scim_group" => AuditLogOperation.CreateScimGroup,
                "create_scim_token" => AuditLogOperation.CreateScimToken,
                "create_scim_user" => AuditLogOperation.CreateScimUser,
                "create_service_account" => AuditLogOperation.CreateServiceAccount,
                "create_service_key" => AuditLogOperation.CreateServiceKey,
                "create_sso_settings" => AuditLogOperation.CreateSsoSettings,
                "create_tag_key" => AuditLogOperation.CreateTagKey,
                "create_tag_value" => AuditLogOperation.CreateTagValue,
                "create_tagging" => AuditLogOperation.CreateTagging,
                "create_tenant" => AuditLogOperation.CreateTenant,
                "create_tool" => AuditLogOperation.CreateTool,
                "create_workspace" => AuditLogOperation.CreateWorkspace,
                "delete_access_policy" => AuditLogOperation.DeleteAccessPolicy,
                "delete_alert_rule" => AuditLogOperation.DeleteAlertRule,
                "delete_annotation_queue" => AuditLogOperation.DeleteAnnotationQueue,
                "delete_annotation_queue_run" => AuditLogOperation.DeleteAnnotationQueueRun,
                "delete_annotation_queue_runs" => AuditLogOperation.DeleteAnnotationQueueRuns,
                "delete_annotation_queues" => AuditLogOperation.DeleteAnnotationQueues,
                "delete_api_key" => AuditLogOperation.DeleteApiKey,
                "delete_chart" => AuditLogOperation.DeleteChart,
                "delete_chart_section" => AuditLogOperation.DeleteChartSection,
                "delete_comparative_experiment" => AuditLogOperation.DeleteComparativeExperiment,
                "delete_dataset" => AuditLogOperation.DeleteDataset,
                "delete_datasets" => AuditLogOperation.DeleteDatasets,
                "delete_deployment" => AuditLogOperation.DeleteDeployment,
                "delete_directory" => AuditLogOperation.DeleteDirectory,
                "delete_evaluator" => AuditLogOperation.DeleteEvaluator,
                "delete_example" => AuditLogOperation.DeleteExample,
                "delete_examples" => AuditLogOperation.DeleteExamples,
                "delete_experiment_view_override" => AuditLogOperation.DeleteExperimentViewOverride,
                "delete_feature_default_model" => AuditLogOperation.DeleteFeatureDefaultModel,
                "delete_feature_disabled_model" => AuditLogOperation.DeleteFeatureDisabledModel,
                "delete_feedback_config" => AuditLogOperation.DeleteFeedbackConfig,
                "delete_feedback_formula" => AuditLogOperation.DeleteFeedbackFormula,
                "delete_filter_view" => AuditLogOperation.DeleteFilterView,
                "delete_fleet_usage_limit" => AuditLogOperation.DeleteFleetUsageLimit,
                "delete_fleet_webhook" => AuditLogOperation.DeleteFleetWebhook,
                "delete_forge_configuration" => AuditLogOperation.DeleteForgeConfiguration,
                "delete_gateway_policy" => AuditLogOperation.DeleteGatewayPolicy,
                "delete_hub_environment" => AuditLogOperation.DeleteHubEnvironment,
                "delete_insights_job" => AuditLogOperation.DeleteInsightsJob,
                "delete_insights_job_config" => AuditLogOperation.DeleteInsightsJobConfig,
                "delete_mcp_server" => AuditLogOperation.DeleteMcpServer,
                "delete_mcp_vendor_settings" => AuditLogOperation.DeleteMcpVendorSettings,
                "delete_model_price_map" => AuditLogOperation.DeleteModelPriceMap,
                "delete_org_chart" => AuditLogOperation.DeleteOrgChart,
                "delete_org_chart_section" => AuditLogOperation.DeleteOrgChartSection,
                "delete_org_member" => AuditLogOperation.DeleteOrgMember,
                "delete_org_pending_member" => AuditLogOperation.DeleteOrgPendingMember,
                "delete_pending_organization_invite" => AuditLogOperation.DeletePendingOrganizationInvite,
                "delete_pending_workspace_invite" => AuditLogOperation.DeletePendingWorkspaceInvite,
                "delete_personal_access_token" => AuditLogOperation.DeletePersonalAccessToken,
                "delete_playground_settings" => AuditLogOperation.DeletePlaygroundSettings,
                "delete_prompt_canvas_quick_action" => AuditLogOperation.DeletePromptCanvasQuickAction,
                "delete_prompt_webhook" => AuditLogOperation.DeletePromptWebhook,
                "delete_role" => AuditLogOperation.DeleteRole,
                "delete_runs" => AuditLogOperation.DeleteRuns,
                "delete_sandbox_proxy_profile" => AuditLogOperation.DeleteSandboxProxyProfile,
                "delete_scim_group" => AuditLogOperation.DeleteScimGroup,
                "delete_scim_token" => AuditLogOperation.DeleteScimToken,
                "delete_scim_user" => AuditLogOperation.DeleteScimUser,
                "delete_service_account" => AuditLogOperation.DeleteServiceAccount,
                "delete_service_key" => AuditLogOperation.DeleteServiceKey,
                "delete_sso_settings" => AuditLogOperation.DeleteSsoSettings,
                "delete_tag_key" => AuditLogOperation.DeleteTagKey,
                "delete_tag_value" => AuditLogOperation.DeleteTagValue,
                "delete_tagging" => AuditLogOperation.DeleteTagging,
                "delete_tool" => AuditLogOperation.DeleteTool,
                "delete_tracer_session" => AuditLogOperation.DeleteTracerSession,
                "delete_tracer_sessions" => AuditLogOperation.DeleteTracerSessions,
                "delete_usage_limit" => AuditLogOperation.DeleteUsageLimit,
                "delete_workspace" => AuditLogOperation.DeleteWorkspace,
                "delete_workspace_member" => AuditLogOperation.DeleteWorkspaceMember,
                "delete_workspace_pending_member" => AuditLogOperation.DeleteWorkspacePendingMember,
                "diff_dataset_versions" => AuditLogOperation.DiffDatasetVersions,
                "download_dataset" => AuditLogOperation.DownloadDataset,
                "evaluate_experiment" => AuditLogOperation.EvaluateExperiment,
                "execute_custom_code" => AuditLogOperation.ExecuteCustomCode,
                "export_annotation_queue" => AuditLogOperation.ExportAnnotationQueue,
                "export_granular_usage_csv" => AuditLogOperation.ExportGranularUsageCsv,
                "export_usage_backfill_csv" => AuditLogOperation.ExportUsageBackfillCsv,
                "generate_dataset" => AuditLogOperation.GenerateDataset,
                "generate_insights_job_config" => AuditLogOperation.GenerateInsightsJobConfig,
                "generate_runs_query" => AuditLogOperation.GenerateRunsQuery,
                "generate_shared_dataset_query" => AuditLogOperation.GenerateSharedDatasetQuery,
                "get_annotation_queue" => AuditLogOperation.GetAnnotationQueue,
                "get_annotation_queue_archived_size" => AuditLogOperation.GetAnnotationQueueArchivedSize,
                "get_annotation_queue_run" => AuditLogOperation.GetAnnotationQueueRun,
                "get_annotation_queue_runs" => AuditLogOperation.GetAnnotationQueueRuns,
                "get_annotation_queue_size" => AuditLogOperation.GetAnnotationQueueSize,
                "get_annotation_queue_total_size" => AuditLogOperation.GetAnnotationQueueTotalSize,
                "get_annotation_queues_for_run" => AuditLogOperation.GetAnnotationQueuesForRun,
                "get_audit_logs" => AuditLogOperation.GetAuditLogs,
                "get_bulk_export" => AuditLogOperation.GetBulkExport,
                "get_bulk_export_run" => AuditLogOperation.GetBulkExportRun,
                "get_bulk_export_runs" => AuditLogOperation.GetBulkExportRuns,
                "get_bulk_export_runs_filtered" => AuditLogOperation.GetBulkExportRunsFiltered,
                "get_company_info" => AuditLogOperation.GetCompanyInfo,
                "get_dataset_comparison_view" => AuditLogOperation.GetDatasetComparisonView,
                "get_dataset_version" => AuditLogOperation.GetDatasetVersion,
                "get_dataset_versions" => AuditLogOperation.GetDatasetVersions,
                "get_example" => AuditLogOperation.GetExample,
                "get_experiment_view_override" => AuditLogOperation.GetExperimentViewOverride,
                "get_experiment_view_overrides" => AuditLogOperation.GetExperimentViewOverrides,
                "get_feedback_formula" => AuditLogOperation.GetFeedbackFormula,
                "get_filter_view" => AuditLogOperation.GetFilterView,
                "get_granular_usage" => AuditLogOperation.GetGranularUsage,
                "get_insights_job" => AuditLogOperation.GetInsightsJob,
                "get_insights_job_runs" => AuditLogOperation.GetInsightsJobRuns,
                "get_login_methods" => AuditLogOperation.GetLoginMethods,
                "get_mcp_tools" => AuditLogOperation.GetMcpTools,
                "get_onboarding_state" => AuditLogOperation.GetOnboardingState,
                "get_org_dashboard" => AuditLogOperation.GetOrgDashboard,
                "get_org_usage" => AuditLogOperation.GetOrgUsage,
                "get_org_usage_limits" => AuditLogOperation.GetOrgUsageLimits,
                "get_organization_billing_info" => AuditLogOperation.GetOrganizationBillingInfo,
                "get_organization_info" => AuditLogOperation.GetOrganizationInfo,
                "get_pairwise_queue" => AuditLogOperation.GetPairwiseQueue,
                "get_run_cluster" => AuditLogOperation.GetRunCluster,
                "get_shared_examples_count" => AuditLogOperation.GetSharedExamplesCount,
                "get_shared_tokens" => AuditLogOperation.GetSharedTokens,
                "get_sso_settings" => AuditLogOperation.GetSsoSettings,
                "get_sso_settings_current" => AuditLogOperation.GetSsoSettingsCurrent,
                "get_tag_key" => AuditLogOperation.GetTagKey,
                "get_tag_value" => AuditLogOperation.GetTagValue,
                "get_usage_limits" => AuditLogOperation.GetUsageLimits,
                "get_workspace_stats" => AuditLogOperation.GetWorkspaceStats,
                "get_workspace_usage_limits_info" => AuditLogOperation.GetWorkspaceUsageLimitsInfo,
                "invalidate_mcp_tools_cache" => AuditLogOperation.InvalidateMcpToolsCache,
                "invite_user_to_org" => AuditLogOperation.InviteUserToOrg,
                "invite_users_to_org_batch" => AuditLogOperation.InviteUsersToOrgBatch,
                "list_access_policies" => AuditLogOperation.ListAccessPolicies,
                "list_annotation_queues" => AuditLogOperation.ListAnnotationQueues,
                "list_bulk_export_destinations" => AuditLogOperation.ListBulkExportDestinations,
                "list_bulk_exports" => AuditLogOperation.ListBulkExports,
                "list_chart_sections" => AuditLogOperation.ListChartSections,
                "list_examples" => AuditLogOperation.ListExamples,
                "list_feedback_configs" => AuditLogOperation.ListFeedbackConfigs,
                "list_feedback_formulas" => AuditLogOperation.ListFeedbackFormulas,
                "list_filter_views" => AuditLogOperation.ListFilterViews,
                "list_insights_job_configs" => AuditLogOperation.ListInsightsJobConfigs,
                "list_insights_jobs" => AuditLogOperation.ListInsightsJobs,
                "list_org_members" => AuditLogOperation.ListOrgMembers,
                "list_org_personal_access_tokens" => AuditLogOperation.ListOrgPersonalAccessTokens,
                "list_org_service_keys" => AuditLogOperation.ListOrgServiceKeys,
                "list_organization_roles" => AuditLogOperation.ListOrganizationRoles,
                "list_organizations" => AuditLogOperation.ListOrganizations,
                "list_pairwise_entries" => AuditLogOperation.ListPairwiseEntries,
                "list_pairwise_queues" => AuditLogOperation.ListPairwiseQueues,
                "list_pending_organization_invites" => AuditLogOperation.ListPendingOrganizationInvites,
                "list_pending_workspace_invites" => AuditLogOperation.ListPendingWorkspaceInvites,
                "list_permissions" => AuditLogOperation.ListPermissions,
                "list_service_accounts" => AuditLogOperation.ListServiceAccounts,
                "list_tag_keys" => AuditLogOperation.ListTagKeys,
                "list_tag_values" => AuditLogOperation.ListTagValues,
                "list_taggings" => AuditLogOperation.ListTaggings,
                "list_tags" => AuditLogOperation.ListTags,
                "list_tags_for_resource" => AuditLogOperation.ListTagsForResource,
                "list_workspace_members" => AuditLogOperation.ListWorkspaceMembers,
                "list_workspaces" => AuditLogOperation.ListWorkspaces,
                "login" => AuditLogOperation.Login,
                "mcp_proxy" => AuditLogOperation.McpProxy,
                "mcp_proxy_get" => AuditLogOperation.McpProxyGet,
                "populate_annotation_queue" => AuditLogOperation.PopulateAnnotationQueue,
                "query_run" => AuditLogOperation.QueryRun,
                "query_runs" => AuditLogOperation.QueryRuns,
                "query_thread_traces" => AuditLogOperation.QueryThreadTraces,
                "query_threads" => AuditLogOperation.QueryThreads,
                "query_trace" => AuditLogOperation.QueryTrace,
                "query_trace_messages" => AuditLogOperation.QueryTraceMessages,
                "read_access_policy" => AuditLogOperation.ReadAccessPolicy,
                "read_bulk_export_destination" => AuditLogOperation.ReadBulkExportDestination,
                "read_chart" => AuditLogOperation.ReadChart,
                "read_chart_preview" => AuditLogOperation.ReadChartPreview,
                "read_chart_section" => AuditLogOperation.ReadChartSection,
                "read_charts" => AuditLogOperation.ReadCharts,
                "read_dataset_delta" => AuditLogOperation.ReadDatasetDelta,
                "read_dataset_share_state" => AuditLogOperation.ReadDatasetShareState,
                "read_example" => AuditLogOperation.ReadExample,
                "read_examples" => AuditLogOperation.ReadExamples,
                "read_feedback" => AuditLogOperation.ReadFeedback,
                "read_feedbacks" => AuditLogOperation.ReadFeedbacks,
                "read_model_price_map" => AuditLogOperation.ReadModelPriceMap,
                "read_role_access_policies" => AuditLogOperation.ReadRoleAccessPolicies,
                "read_run" => AuditLogOperation.ReadRun,
                "read_runs" => AuditLogOperation.ReadRuns,
                "read_shared_delta" => AuditLogOperation.ReadSharedDelta,
                "read_shared_delta_stream" => AuditLogOperation.ReadSharedDeltaStream,
                "read_tracing_dashboard" => AuditLogOperation.ReadTracingDashboard,
                "register_mcp_server_oauth" => AuditLogOperation.RegisterMcpServerOauth,
                "remove_annotation_queue_reviewer" => AuditLogOperation.RemoveAnnotationQueueReviewer,
                "rename_filter_view" => AuditLogOperation.RenameFilterView,
                "resolve_annotation_queue_run" => AuditLogOperation.ResolveAnnotationQueueRun,
                "send_sso_email_confirmation" => AuditLogOperation.SendSsoEmailConfirmation,
                "set_tenant_handle" => AuditLogOperation.SetTenantHandle,
                "share_dataset" => AuditLogOperation.ShareDataset,
                "stream_dataset_comparison_view" => AuditLogOperation.StreamDatasetComparisonView,
                "stream_feedback_delta" => AuditLogOperation.StreamFeedbackDelta,
                "submit_nps_response" => AuditLogOperation.SubmitNpsResponse,
                "sync_examples" => AuditLogOperation.SyncExamples,
                "test_alert_rule" => AuditLogOperation.TestAlertRule,
                "test_fleet_webhook" => AuditLogOperation.TestFleetWebhook,
                "test_prompt_webhook" => AuditLogOperation.TestPromptWebhook,
                "trigger_forge_configuration" => AuditLogOperation.TriggerForgeConfiguration,
                "unshare_dataset" => AuditLogOperation.UnshareDataset,
                "unshare_entities" => AuditLogOperation.UnshareEntities,
                "update_alert_rule" => AuditLogOperation.UpdateAlertRule,
                "update_annotation_queue" => AuditLogOperation.UpdateAnnotationQueue,
                "update_annotation_queue_run" => AuditLogOperation.UpdateAnnotationQueueRun,
                "update_basic_auth_user" => AuditLogOperation.UpdateBasicAuthUser,
                "update_bulk_export_destination" => AuditLogOperation.UpdateBulkExportDestination,
                "update_business_info" => AuditLogOperation.UpdateBusinessInfo,
                "update_chart" => AuditLogOperation.UpdateChart,
                "update_chart_section" => AuditLogOperation.UpdateChartSection,
                "update_dataset" => AuditLogOperation.UpdateDataset,
                "update_dataset_splits" => AuditLogOperation.UpdateDatasetSplits,
                "update_dataset_version" => AuditLogOperation.UpdateDatasetVersion,
                "update_default_sso_provision_organization" => AuditLogOperation.UpdateDefaultSsoProvisionOrganization,
                "update_deployment" => AuditLogOperation.UpdateDeployment,
                "update_evaluator" => AuditLogOperation.UpdateEvaluator,
                "update_example" => AuditLogOperation.UpdateExample,
                "update_examples" => AuditLogOperation.UpdateExamples,
                "update_experiment_view_override" => AuditLogOperation.UpdateExperimentViewOverride,
                "update_feedback_config" => AuditLogOperation.UpdateFeedbackConfig,
                "update_feedback_formula" => AuditLogOperation.UpdateFeedbackFormula,
                "update_filter_view" => AuditLogOperation.UpdateFilterView,
                "update_fleet_usage_limit" => AuditLogOperation.UpdateFleetUsageLimit,
                "update_fleet_webhook" => AuditLogOperation.UpdateFleetWebhook,
                "update_forge_configuration" => AuditLogOperation.UpdateForgeConfiguration,
                "update_gateway_policy" => AuditLogOperation.UpdateGatewayPolicy,
                "update_hub_environment" => AuditLogOperation.UpdateHubEnvironment,
                "update_insights_job" => AuditLogOperation.UpdateInsightsJob,
                "update_insights_job_config" => AuditLogOperation.UpdateInsightsJobConfig,
                "update_login_methods" => AuditLogOperation.UpdateLoginMethods,
                "update_mcp_server" => AuditLogOperation.UpdateMcpServer,
                "update_mcp_vendor_settings" => AuditLogOperation.UpdateMcpVendorSettings,
                "update_model_price_map" => AuditLogOperation.UpdateModelPriceMap,
                "update_onboarding_state" => AuditLogOperation.UpdateOnboardingState,
                "update_org_chart" => AuditLogOperation.UpdateOrgChart,
                "update_org_chart_section" => AuditLogOperation.UpdateOrgChartSection,
                "update_org_member" => AuditLogOperation.UpdateOrgMember,
                "update_organization_info" => AuditLogOperation.UpdateOrganizationInfo,
                "update_payment_method" => AuditLogOperation.UpdatePaymentMethod,
                "update_payment_plan" => AuditLogOperation.UpdatePaymentPlan,
                "update_playground_settings" => AuditLogOperation.UpdatePlaygroundSettings,
                "update_prompt_canvas_quick_action" => AuditLogOperation.UpdatePromptCanvasQuickAction,
                "update_prompt_webhook" => AuditLogOperation.UpdatePromptWebhook,
                "update_role" => AuditLogOperation.UpdateRole,
                "update_sandbox_proxy_profile" => AuditLogOperation.UpdateSandboxProxyProfile,
                "update_scim_group" => AuditLogOperation.UpdateScimGroup,
                "update_scim_token" => AuditLogOperation.UpdateScimToken,
                "update_scim_user" => AuditLogOperation.UpdateScimUser,
                "update_self_hosted_customer" => AuditLogOperation.UpdateSelfHostedCustomer,
                "update_self_hosted_license" => AuditLogOperation.UpdateSelfHostedLicense,
                "update_sso_settings" => AuditLogOperation.UpdateSsoSettings,
                "update_tag_key" => AuditLogOperation.UpdateTagKey,
                "update_tag_value" => AuditLogOperation.UpdateTagValue,
                "update_tool" => AuditLogOperation.UpdateTool,
                "update_tracer_session" => AuditLogOperation.UpdateTracerSession,
                "update_ttl_settings" => AuditLogOperation.UpdateTtlSettings,
                "update_usage_limit" => AuditLogOperation.UpdateUsageLimit,
                "update_workspace" => AuditLogOperation.UpdateWorkspace,
                "update_workspace_member" => AuditLogOperation.UpdateWorkspaceMember,
                "update_workspace_secrets" => AuditLogOperation.UpdateWorkspaceSecrets,
                "upsert_feature_default_model" => AuditLogOperation.UpsertFeatureDefaultModel,
                "upsert_feature_disabled_model" => AuditLogOperation.UpsertFeatureDisabledModel,
                "validate_example" => AuditLogOperation.ValidateExample,
                "validate_examples" => AuditLogOperation.ValidateExamples,
                _ => null,
            };
        }
    }
}