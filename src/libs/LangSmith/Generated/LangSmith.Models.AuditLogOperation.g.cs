
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
        AttachAccessPolicies,
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
        CreateAccessPolicy,
        /// <summary>
        /// 
        /// </summary>
        CreateAlertRule,
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
        CreateOrgChart,
        /// <summary>
        /// 
        /// </summary>
        CreateOrgChartSection,
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
        DeletePersonalAccessToken,
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
        DownloadDataset,
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
        ReadAccessPolicy,
        /// <summary>
        /// 
        /// </summary>
        ReadBulkExportDestination,
        /// <summary>
        /// 
        /// </summary>
        ReadRoleAccessPolicies,
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
        SetTenantHandle,
        /// <summary>
        /// 
        /// </summary>
        ShareDataset,
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
                AuditLogOperation.AttachAccessPolicies => "attach_access_policies",
                AuditLogOperation.BulkDeleteEvaluators => "bulk_delete_evaluators",
                AuditLogOperation.CancelBulkExport => "cancel_bulk_export",
                AuditLogOperation.CloneChartSection => "clone_chart_section",
                AuditLogOperation.CloneDataset => "clone_dataset",
                AuditLogOperation.ConfirmPaymentCheckoutSession => "confirm_payment_checkout_session",
                AuditLogOperation.CreateAccessPolicy => "create_access_policy",
                AuditLogOperation.CreateAlertRule => "create_alert_rule",
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
                AuditLogOperation.CreateFleetUsageLimit => "create_fleet_usage_limit",
                AuditLogOperation.CreateFleetWebhook => "create_fleet_webhook",
                AuditLogOperation.CreateForgeConfiguration => "create_forge_configuration",
                AuditLogOperation.CreateGatewayPolicy => "create_gateway_policy",
                AuditLogOperation.CreateHubEnvironment => "create_hub_environment",
                AuditLogOperation.CreateMcpServer => "create_mcp_server",
                AuditLogOperation.CreateMcpVendorSettings => "create_mcp_vendor_settings",
                AuditLogOperation.CreateModelPriceMap => "create_model_price_map",
                AuditLogOperation.CreateOrgChart => "create_org_chart",
                AuditLogOperation.CreateOrgChartSection => "create_org_chart_section",
                AuditLogOperation.CreatePaymentAccountLink => "create_payment_account_link",
                AuditLogOperation.CreatePaymentCheckoutSession => "create_payment_checkout_session",
                AuditLogOperation.CreatePaymentSetupIntent => "create_payment_setup_intent",
                AuditLogOperation.CreatePersonalAccessToken => "create_personal_access_token",
                AuditLogOperation.CreatePlaygroundExperiment => "create_playground_experiment",
                AuditLogOperation.CreatePromptCanvasQuickAction => "create_prompt_canvas_quick_action",
                AuditLogOperation.CreatePromptWebhook => "create_prompt_webhook",
                AuditLogOperation.CreateRole => "create_role",
                AuditLogOperation.CreateSandboxProxyProfile => "create_sandbox_proxy_profile",
                AuditLogOperation.CreateScimGroup => "create_scim_group",
                AuditLogOperation.CreateScimToken => "create_scim_token",
                AuditLogOperation.CreateScimUser => "create_scim_user",
                AuditLogOperation.CreateServiceKey => "create_service_key",
                AuditLogOperation.CreateSsoSettings => "create_sso_settings",
                AuditLogOperation.CreateTagKey => "create_tag_key",
                AuditLogOperation.CreateTagValue => "create_tag_value",
                AuditLogOperation.CreateTagging => "create_tagging",
                AuditLogOperation.CreateTool => "create_tool",
                AuditLogOperation.CreateWorkspace => "create_workspace",
                AuditLogOperation.DeleteAccessPolicy => "delete_access_policy",
                AuditLogOperation.DeleteAlertRule => "delete_alert_rule",
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
                AuditLogOperation.DeleteFleetUsageLimit => "delete_fleet_usage_limit",
                AuditLogOperation.DeleteFleetWebhook => "delete_fleet_webhook",
                AuditLogOperation.DeleteForgeConfiguration => "delete_forge_configuration",
                AuditLogOperation.DeleteGatewayPolicy => "delete_gateway_policy",
                AuditLogOperation.DeleteHubEnvironment => "delete_hub_environment",
                AuditLogOperation.DeleteMcpServer => "delete_mcp_server",
                AuditLogOperation.DeleteMcpVendorSettings => "delete_mcp_vendor_settings",
                AuditLogOperation.DeleteModelPriceMap => "delete_model_price_map",
                AuditLogOperation.DeleteOrgChart => "delete_org_chart",
                AuditLogOperation.DeleteOrgChartSection => "delete_org_chart_section",
                AuditLogOperation.DeleteOrgMember => "delete_org_member",
                AuditLogOperation.DeleteOrgPendingMember => "delete_org_pending_member",
                AuditLogOperation.DeletePersonalAccessToken => "delete_personal_access_token",
                AuditLogOperation.DeletePromptCanvasQuickAction => "delete_prompt_canvas_quick_action",
                AuditLogOperation.DeletePromptWebhook => "delete_prompt_webhook",
                AuditLogOperation.DeleteRole => "delete_role",
                AuditLogOperation.DeleteRuns => "delete_runs",
                AuditLogOperation.DeleteSandboxProxyProfile => "delete_sandbox_proxy_profile",
                AuditLogOperation.DeleteScimGroup => "delete_scim_group",
                AuditLogOperation.DeleteScimToken => "delete_scim_token",
                AuditLogOperation.DeleteScimUser => "delete_scim_user",
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
                AuditLogOperation.DownloadDataset => "download_dataset",
                AuditLogOperation.InviteUserToOrg => "invite_user_to_org",
                AuditLogOperation.InviteUsersToOrgBatch => "invite_users_to_org_batch",
                AuditLogOperation.ListAccessPolicies => "list_access_policies",
                AuditLogOperation.ReadAccessPolicy => "read_access_policy",
                AuditLogOperation.ReadBulkExportDestination => "read_bulk_export_destination",
                AuditLogOperation.ReadRoleAccessPolicies => "read_role_access_policies",
                AuditLogOperation.RegisterMcpServerOauth => "register_mcp_server_oauth",
                AuditLogOperation.RemoveAnnotationQueueReviewer => "remove_annotation_queue_reviewer",
                AuditLogOperation.SetTenantHandle => "set_tenant_handle",
                AuditLogOperation.ShareDataset => "share_dataset",
                AuditLogOperation.SubmitNpsResponse => "submit_nps_response",
                AuditLogOperation.SyncExamples => "sync_examples",
                AuditLogOperation.TestAlertRule => "test_alert_rule",
                AuditLogOperation.TestFleetWebhook => "test_fleet_webhook",
                AuditLogOperation.TestPromptWebhook => "test_prompt_webhook",
                AuditLogOperation.TriggerForgeConfiguration => "trigger_forge_configuration",
                AuditLogOperation.UnshareDataset => "unshare_dataset",
                AuditLogOperation.UnshareEntities => "unshare_entities",
                AuditLogOperation.UpdateAlertRule => "update_alert_rule",
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
                AuditLogOperation.UpdateFleetUsageLimit => "update_fleet_usage_limit",
                AuditLogOperation.UpdateFleetWebhook => "update_fleet_webhook",
                AuditLogOperation.UpdateForgeConfiguration => "update_forge_configuration",
                AuditLogOperation.UpdateGatewayPolicy => "update_gateway_policy",
                AuditLogOperation.UpdateHubEnvironment => "update_hub_environment",
                AuditLogOperation.UpdateLoginMethods => "update_login_methods",
                AuditLogOperation.UpdateMcpServer => "update_mcp_server",
                AuditLogOperation.UpdateMcpVendorSettings => "update_mcp_vendor_settings",
                AuditLogOperation.UpdateModelPriceMap => "update_model_price_map",
                AuditLogOperation.UpdateOrgChart => "update_org_chart",
                AuditLogOperation.UpdateOrgChartSection => "update_org_chart_section",
                AuditLogOperation.UpdateOrgMember => "update_org_member",
                AuditLogOperation.UpdateOrganizationInfo => "update_organization_info",
                AuditLogOperation.UpdatePaymentMethod => "update_payment_method",
                AuditLogOperation.UpdatePaymentPlan => "update_payment_plan",
                AuditLogOperation.UpdatePromptCanvasQuickAction => "update_prompt_canvas_quick_action",
                AuditLogOperation.UpdatePromptWebhook => "update_prompt_webhook",
                AuditLogOperation.UpdateRole => "update_role",
                AuditLogOperation.UpdateSandboxProxyProfile => "update_sandbox_proxy_profile",
                AuditLogOperation.UpdateScimGroup => "update_scim_group",
                AuditLogOperation.UpdateScimToken => "update_scim_token",
                AuditLogOperation.UpdateScimUser => "update_scim_user",
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
                "attach_access_policies" => AuditLogOperation.AttachAccessPolicies,
                "bulk_delete_evaluators" => AuditLogOperation.BulkDeleteEvaluators,
                "cancel_bulk_export" => AuditLogOperation.CancelBulkExport,
                "clone_chart_section" => AuditLogOperation.CloneChartSection,
                "clone_dataset" => AuditLogOperation.CloneDataset,
                "confirm_payment_checkout_session" => AuditLogOperation.ConfirmPaymentCheckoutSession,
                "create_access_policy" => AuditLogOperation.CreateAccessPolicy,
                "create_alert_rule" => AuditLogOperation.CreateAlertRule,
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
                "create_fleet_usage_limit" => AuditLogOperation.CreateFleetUsageLimit,
                "create_fleet_webhook" => AuditLogOperation.CreateFleetWebhook,
                "create_forge_configuration" => AuditLogOperation.CreateForgeConfiguration,
                "create_gateway_policy" => AuditLogOperation.CreateGatewayPolicy,
                "create_hub_environment" => AuditLogOperation.CreateHubEnvironment,
                "create_mcp_server" => AuditLogOperation.CreateMcpServer,
                "create_mcp_vendor_settings" => AuditLogOperation.CreateMcpVendorSettings,
                "create_model_price_map" => AuditLogOperation.CreateModelPriceMap,
                "create_org_chart" => AuditLogOperation.CreateOrgChart,
                "create_org_chart_section" => AuditLogOperation.CreateOrgChartSection,
                "create_payment_account_link" => AuditLogOperation.CreatePaymentAccountLink,
                "create_payment_checkout_session" => AuditLogOperation.CreatePaymentCheckoutSession,
                "create_payment_setup_intent" => AuditLogOperation.CreatePaymentSetupIntent,
                "create_personal_access_token" => AuditLogOperation.CreatePersonalAccessToken,
                "create_playground_experiment" => AuditLogOperation.CreatePlaygroundExperiment,
                "create_prompt_canvas_quick_action" => AuditLogOperation.CreatePromptCanvasQuickAction,
                "create_prompt_webhook" => AuditLogOperation.CreatePromptWebhook,
                "create_role" => AuditLogOperation.CreateRole,
                "create_sandbox_proxy_profile" => AuditLogOperation.CreateSandboxProxyProfile,
                "create_scim_group" => AuditLogOperation.CreateScimGroup,
                "create_scim_token" => AuditLogOperation.CreateScimToken,
                "create_scim_user" => AuditLogOperation.CreateScimUser,
                "create_service_key" => AuditLogOperation.CreateServiceKey,
                "create_sso_settings" => AuditLogOperation.CreateSsoSettings,
                "create_tag_key" => AuditLogOperation.CreateTagKey,
                "create_tag_value" => AuditLogOperation.CreateTagValue,
                "create_tagging" => AuditLogOperation.CreateTagging,
                "create_tool" => AuditLogOperation.CreateTool,
                "create_workspace" => AuditLogOperation.CreateWorkspace,
                "delete_access_policy" => AuditLogOperation.DeleteAccessPolicy,
                "delete_alert_rule" => AuditLogOperation.DeleteAlertRule,
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
                "delete_fleet_usage_limit" => AuditLogOperation.DeleteFleetUsageLimit,
                "delete_fleet_webhook" => AuditLogOperation.DeleteFleetWebhook,
                "delete_forge_configuration" => AuditLogOperation.DeleteForgeConfiguration,
                "delete_gateway_policy" => AuditLogOperation.DeleteGatewayPolicy,
                "delete_hub_environment" => AuditLogOperation.DeleteHubEnvironment,
                "delete_mcp_server" => AuditLogOperation.DeleteMcpServer,
                "delete_mcp_vendor_settings" => AuditLogOperation.DeleteMcpVendorSettings,
                "delete_model_price_map" => AuditLogOperation.DeleteModelPriceMap,
                "delete_org_chart" => AuditLogOperation.DeleteOrgChart,
                "delete_org_chart_section" => AuditLogOperation.DeleteOrgChartSection,
                "delete_org_member" => AuditLogOperation.DeleteOrgMember,
                "delete_org_pending_member" => AuditLogOperation.DeleteOrgPendingMember,
                "delete_personal_access_token" => AuditLogOperation.DeletePersonalAccessToken,
                "delete_prompt_canvas_quick_action" => AuditLogOperation.DeletePromptCanvasQuickAction,
                "delete_prompt_webhook" => AuditLogOperation.DeletePromptWebhook,
                "delete_role" => AuditLogOperation.DeleteRole,
                "delete_runs" => AuditLogOperation.DeleteRuns,
                "delete_sandbox_proxy_profile" => AuditLogOperation.DeleteSandboxProxyProfile,
                "delete_scim_group" => AuditLogOperation.DeleteScimGroup,
                "delete_scim_token" => AuditLogOperation.DeleteScimToken,
                "delete_scim_user" => AuditLogOperation.DeleteScimUser,
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
                "download_dataset" => AuditLogOperation.DownloadDataset,
                "invite_user_to_org" => AuditLogOperation.InviteUserToOrg,
                "invite_users_to_org_batch" => AuditLogOperation.InviteUsersToOrgBatch,
                "list_access_policies" => AuditLogOperation.ListAccessPolicies,
                "read_access_policy" => AuditLogOperation.ReadAccessPolicy,
                "read_bulk_export_destination" => AuditLogOperation.ReadBulkExportDestination,
                "read_role_access_policies" => AuditLogOperation.ReadRoleAccessPolicies,
                "register_mcp_server_oauth" => AuditLogOperation.RegisterMcpServerOauth,
                "remove_annotation_queue_reviewer" => AuditLogOperation.RemoveAnnotationQueueReviewer,
                "set_tenant_handle" => AuditLogOperation.SetTenantHandle,
                "share_dataset" => AuditLogOperation.ShareDataset,
                "submit_nps_response" => AuditLogOperation.SubmitNpsResponse,
                "sync_examples" => AuditLogOperation.SyncExamples,
                "test_alert_rule" => AuditLogOperation.TestAlertRule,
                "test_fleet_webhook" => AuditLogOperation.TestFleetWebhook,
                "test_prompt_webhook" => AuditLogOperation.TestPromptWebhook,
                "trigger_forge_configuration" => AuditLogOperation.TriggerForgeConfiguration,
                "unshare_dataset" => AuditLogOperation.UnshareDataset,
                "unshare_entities" => AuditLogOperation.UnshareEntities,
                "update_alert_rule" => AuditLogOperation.UpdateAlertRule,
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
                "update_fleet_usage_limit" => AuditLogOperation.UpdateFleetUsageLimit,
                "update_fleet_webhook" => AuditLogOperation.UpdateFleetWebhook,
                "update_forge_configuration" => AuditLogOperation.UpdateForgeConfiguration,
                "update_gateway_policy" => AuditLogOperation.UpdateGatewayPolicy,
                "update_hub_environment" => AuditLogOperation.UpdateHubEnvironment,
                "update_login_methods" => AuditLogOperation.UpdateLoginMethods,
                "update_mcp_server" => AuditLogOperation.UpdateMcpServer,
                "update_mcp_vendor_settings" => AuditLogOperation.UpdateMcpVendorSettings,
                "update_model_price_map" => AuditLogOperation.UpdateModelPriceMap,
                "update_org_chart" => AuditLogOperation.UpdateOrgChart,
                "update_org_chart_section" => AuditLogOperation.UpdateOrgChartSection,
                "update_org_member" => AuditLogOperation.UpdateOrgMember,
                "update_organization_info" => AuditLogOperation.UpdateOrganizationInfo,
                "update_payment_method" => AuditLogOperation.UpdatePaymentMethod,
                "update_payment_plan" => AuditLogOperation.UpdatePaymentPlan,
                "update_prompt_canvas_quick_action" => AuditLogOperation.UpdatePromptCanvasQuickAction,
                "update_prompt_webhook" => AuditLogOperation.UpdatePromptWebhook,
                "update_role" => AuditLogOperation.UpdateRole,
                "update_sandbox_proxy_profile" => AuditLogOperation.UpdateSandboxProxyProfile,
                "update_scim_group" => AuditLogOperation.UpdateScimGroup,
                "update_scim_token" => AuditLogOperation.UpdateScimToken,
                "update_scim_user" => AuditLogOperation.UpdateScimUser,
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
                _ => null,
            };
        }
    }
}