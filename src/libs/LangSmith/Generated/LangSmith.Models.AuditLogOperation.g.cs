
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
        CreatePromptWebhook,
        /// <summary>
        /// 
        /// </summary>
        CreateRole,
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
        CreateWorkspace,
        /// <summary>
        /// 
        /// </summary>
        DeleteAccessPolicy,
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
        DeleteExample,
        /// <summary>
        /// 
        /// </summary>
        DeleteExamples,
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
        DeletePromptWebhook,
        /// <summary>
        /// 
        /// </summary>
        DeleteRole,
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
        SetTenantHandle,
        /// <summary>
        /// 
        /// </summary>
        ShareDataset,
        /// <summary>
        /// 
        /// </summary>
        TestPromptWebhook,
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
        UpdateExample,
        /// <summary>
        /// 
        /// </summary>
        UpdateExamples,
        /// <summary>
        /// 
        /// </summary>
        UpdateLoginMethods,
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
        UpdatePromptWebhook,
        /// <summary>
        /// 
        /// </summary>
        UpdateRole,
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
                AuditLogOperation.AddBasicAuthUsersToOrg => "add_basic_auth_users_to_org",
                AuditLogOperation.AddMemberToWorkspace => "add_member_to_workspace",
                AuditLogOperation.AddMembersToWorkspaceBatch => "add_members_to_workspace_batch",
                AuditLogOperation.AttachAccessPolicies => "attach_access_policies",
                AuditLogOperation.CancelBulkExport => "cancel_bulk_export",
                AuditLogOperation.CloneChartSection => "clone_chart_section",
                AuditLogOperation.CloneDataset => "clone_dataset",
                AuditLogOperation.ConfirmPaymentCheckoutSession => "confirm_payment_checkout_session",
                AuditLogOperation.CreateAccessPolicy => "create_access_policy",
                AuditLogOperation.CreateApiKey => "create_api_key",
                AuditLogOperation.CreateBulkExport => "create_bulk_export",
                AuditLogOperation.CreateBulkExportDestination => "create_bulk_export_destination",
                AuditLogOperation.CreateChart => "create_chart",
                AuditLogOperation.CreateChartSection => "create_chart_section",
                AuditLogOperation.CreateComparativeExperiment => "create_comparative_experiment",
                AuditLogOperation.CreateCsvDataset => "create_csv_dataset",
                AuditLogOperation.CreateDataset => "create_dataset",
                AuditLogOperation.CreateDeployment => "create_deployment",
                AuditLogOperation.CreateExample => "create_example",
                AuditLogOperation.CreateExamples => "create_examples",
                AuditLogOperation.CreateExperimentViaUpload => "create_experiment_via_upload",
                AuditLogOperation.CreateModelPriceMap => "create_model_price_map",
                AuditLogOperation.CreateOrgChart => "create_org_chart",
                AuditLogOperation.CreateOrgChartSection => "create_org_chart_section",
                AuditLogOperation.CreatePaymentAccountLink => "create_payment_account_link",
                AuditLogOperation.CreatePaymentCheckoutSession => "create_payment_checkout_session",
                AuditLogOperation.CreatePaymentSetupIntent => "create_payment_setup_intent",
                AuditLogOperation.CreatePersonalAccessToken => "create_personal_access_token",
                AuditLogOperation.CreatePlaygroundExperiment => "create_playground_experiment",
                AuditLogOperation.CreatePromptWebhook => "create_prompt_webhook",
                AuditLogOperation.CreateRole => "create_role",
                AuditLogOperation.CreateScimGroup => "create_scim_group",
                AuditLogOperation.CreateScimToken => "create_scim_token",
                AuditLogOperation.CreateScimUser => "create_scim_user",
                AuditLogOperation.CreateServiceKey => "create_service_key",
                AuditLogOperation.CreateSsoSettings => "create_sso_settings",
                AuditLogOperation.CreateTagKey => "create_tag_key",
                AuditLogOperation.CreateTagValue => "create_tag_value",
                AuditLogOperation.CreateTagging => "create_tagging",
                AuditLogOperation.CreateWorkspace => "create_workspace",
                AuditLogOperation.DeleteAccessPolicy => "delete_access_policy",
                AuditLogOperation.DeleteApiKey => "delete_api_key",
                AuditLogOperation.DeleteChart => "delete_chart",
                AuditLogOperation.DeleteChartSection => "delete_chart_section",
                AuditLogOperation.DeleteComparativeExperiment => "delete_comparative_experiment",
                AuditLogOperation.DeleteDataset => "delete_dataset",
                AuditLogOperation.DeleteDatasets => "delete_datasets",
                AuditLogOperation.DeleteDeployment => "delete_deployment",
                AuditLogOperation.DeleteExample => "delete_example",
                AuditLogOperation.DeleteExamples => "delete_examples",
                AuditLogOperation.DeleteModelPriceMap => "delete_model_price_map",
                AuditLogOperation.DeleteOrgChart => "delete_org_chart",
                AuditLogOperation.DeleteOrgChartSection => "delete_org_chart_section",
                AuditLogOperation.DeleteOrgMember => "delete_org_member",
                AuditLogOperation.DeleteOrgPendingMember => "delete_org_pending_member",
                AuditLogOperation.DeletePersonalAccessToken => "delete_personal_access_token",
                AuditLogOperation.DeletePromptWebhook => "delete_prompt_webhook",
                AuditLogOperation.DeleteRole => "delete_role",
                AuditLogOperation.DeleteScimGroup => "delete_scim_group",
                AuditLogOperation.DeleteScimToken => "delete_scim_token",
                AuditLogOperation.DeleteScimUser => "delete_scim_user",
                AuditLogOperation.DeleteServiceKey => "delete_service_key",
                AuditLogOperation.DeleteSsoSettings => "delete_sso_settings",
                AuditLogOperation.DeleteTagKey => "delete_tag_key",
                AuditLogOperation.DeleteTagValue => "delete_tag_value",
                AuditLogOperation.DeleteTagging => "delete_tagging",
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
                AuditLogOperation.SetTenantHandle => "set_tenant_handle",
                AuditLogOperation.ShareDataset => "share_dataset",
                AuditLogOperation.TestPromptWebhook => "test_prompt_webhook",
                AuditLogOperation.UnshareDataset => "unshare_dataset",
                AuditLogOperation.UnshareEntities => "unshare_entities",
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
                AuditLogOperation.UpdateExample => "update_example",
                AuditLogOperation.UpdateExamples => "update_examples",
                AuditLogOperation.UpdateLoginMethods => "update_login_methods",
                AuditLogOperation.UpdateModelPriceMap => "update_model_price_map",
                AuditLogOperation.UpdateOrgChart => "update_org_chart",
                AuditLogOperation.UpdateOrgChartSection => "update_org_chart_section",
                AuditLogOperation.UpdateOrgMember => "update_org_member",
                AuditLogOperation.UpdateOrganizationInfo => "update_organization_info",
                AuditLogOperation.UpdatePaymentMethod => "update_payment_method",
                AuditLogOperation.UpdatePaymentPlan => "update_payment_plan",
                AuditLogOperation.UpdatePromptWebhook => "update_prompt_webhook",
                AuditLogOperation.UpdateRole => "update_role",
                AuditLogOperation.UpdateScimGroup => "update_scim_group",
                AuditLogOperation.UpdateScimToken => "update_scim_token",
                AuditLogOperation.UpdateScimUser => "update_scim_user",
                AuditLogOperation.UpdateSsoSettings => "update_sso_settings",
                AuditLogOperation.UpdateTagKey => "update_tag_key",
                AuditLogOperation.UpdateTagValue => "update_tag_value",
                AuditLogOperation.UpdateTracerSession => "update_tracer_session",
                AuditLogOperation.UpdateTtlSettings => "update_ttl_settings",
                AuditLogOperation.UpdateUsageLimit => "update_usage_limit",
                AuditLogOperation.UpdateWorkspace => "update_workspace",
                AuditLogOperation.UpdateWorkspaceMember => "update_workspace_member",
                AuditLogOperation.UpdateWorkspaceSecrets => "update_workspace_secrets",
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
                "add_basic_auth_users_to_org" => AuditLogOperation.AddBasicAuthUsersToOrg,
                "add_member_to_workspace" => AuditLogOperation.AddMemberToWorkspace,
                "add_members_to_workspace_batch" => AuditLogOperation.AddMembersToWorkspaceBatch,
                "attach_access_policies" => AuditLogOperation.AttachAccessPolicies,
                "cancel_bulk_export" => AuditLogOperation.CancelBulkExport,
                "clone_chart_section" => AuditLogOperation.CloneChartSection,
                "clone_dataset" => AuditLogOperation.CloneDataset,
                "confirm_payment_checkout_session" => AuditLogOperation.ConfirmPaymentCheckoutSession,
                "create_access_policy" => AuditLogOperation.CreateAccessPolicy,
                "create_api_key" => AuditLogOperation.CreateApiKey,
                "create_bulk_export" => AuditLogOperation.CreateBulkExport,
                "create_bulk_export_destination" => AuditLogOperation.CreateBulkExportDestination,
                "create_chart" => AuditLogOperation.CreateChart,
                "create_chart_section" => AuditLogOperation.CreateChartSection,
                "create_comparative_experiment" => AuditLogOperation.CreateComparativeExperiment,
                "create_csv_dataset" => AuditLogOperation.CreateCsvDataset,
                "create_dataset" => AuditLogOperation.CreateDataset,
                "create_deployment" => AuditLogOperation.CreateDeployment,
                "create_example" => AuditLogOperation.CreateExample,
                "create_examples" => AuditLogOperation.CreateExamples,
                "create_experiment_via_upload" => AuditLogOperation.CreateExperimentViaUpload,
                "create_model_price_map" => AuditLogOperation.CreateModelPriceMap,
                "create_org_chart" => AuditLogOperation.CreateOrgChart,
                "create_org_chart_section" => AuditLogOperation.CreateOrgChartSection,
                "create_payment_account_link" => AuditLogOperation.CreatePaymentAccountLink,
                "create_payment_checkout_session" => AuditLogOperation.CreatePaymentCheckoutSession,
                "create_payment_setup_intent" => AuditLogOperation.CreatePaymentSetupIntent,
                "create_personal_access_token" => AuditLogOperation.CreatePersonalAccessToken,
                "create_playground_experiment" => AuditLogOperation.CreatePlaygroundExperiment,
                "create_prompt_webhook" => AuditLogOperation.CreatePromptWebhook,
                "create_role" => AuditLogOperation.CreateRole,
                "create_scim_group" => AuditLogOperation.CreateScimGroup,
                "create_scim_token" => AuditLogOperation.CreateScimToken,
                "create_scim_user" => AuditLogOperation.CreateScimUser,
                "create_service_key" => AuditLogOperation.CreateServiceKey,
                "create_sso_settings" => AuditLogOperation.CreateSsoSettings,
                "create_tag_key" => AuditLogOperation.CreateTagKey,
                "create_tag_value" => AuditLogOperation.CreateTagValue,
                "create_tagging" => AuditLogOperation.CreateTagging,
                "create_workspace" => AuditLogOperation.CreateWorkspace,
                "delete_access_policy" => AuditLogOperation.DeleteAccessPolicy,
                "delete_api_key" => AuditLogOperation.DeleteApiKey,
                "delete_chart" => AuditLogOperation.DeleteChart,
                "delete_chart_section" => AuditLogOperation.DeleteChartSection,
                "delete_comparative_experiment" => AuditLogOperation.DeleteComparativeExperiment,
                "delete_dataset" => AuditLogOperation.DeleteDataset,
                "delete_datasets" => AuditLogOperation.DeleteDatasets,
                "delete_deployment" => AuditLogOperation.DeleteDeployment,
                "delete_example" => AuditLogOperation.DeleteExample,
                "delete_examples" => AuditLogOperation.DeleteExamples,
                "delete_model_price_map" => AuditLogOperation.DeleteModelPriceMap,
                "delete_org_chart" => AuditLogOperation.DeleteOrgChart,
                "delete_org_chart_section" => AuditLogOperation.DeleteOrgChartSection,
                "delete_org_member" => AuditLogOperation.DeleteOrgMember,
                "delete_org_pending_member" => AuditLogOperation.DeleteOrgPendingMember,
                "delete_personal_access_token" => AuditLogOperation.DeletePersonalAccessToken,
                "delete_prompt_webhook" => AuditLogOperation.DeletePromptWebhook,
                "delete_role" => AuditLogOperation.DeleteRole,
                "delete_scim_group" => AuditLogOperation.DeleteScimGroup,
                "delete_scim_token" => AuditLogOperation.DeleteScimToken,
                "delete_scim_user" => AuditLogOperation.DeleteScimUser,
                "delete_service_key" => AuditLogOperation.DeleteServiceKey,
                "delete_sso_settings" => AuditLogOperation.DeleteSsoSettings,
                "delete_tag_key" => AuditLogOperation.DeleteTagKey,
                "delete_tag_value" => AuditLogOperation.DeleteTagValue,
                "delete_tagging" => AuditLogOperation.DeleteTagging,
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
                "set_tenant_handle" => AuditLogOperation.SetTenantHandle,
                "share_dataset" => AuditLogOperation.ShareDataset,
                "test_prompt_webhook" => AuditLogOperation.TestPromptWebhook,
                "unshare_dataset" => AuditLogOperation.UnshareDataset,
                "unshare_entities" => AuditLogOperation.UnshareEntities,
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
                "update_example" => AuditLogOperation.UpdateExample,
                "update_examples" => AuditLogOperation.UpdateExamples,
                "update_login_methods" => AuditLogOperation.UpdateLoginMethods,
                "update_model_price_map" => AuditLogOperation.UpdateModelPriceMap,
                "update_org_chart" => AuditLogOperation.UpdateOrgChart,
                "update_org_chart_section" => AuditLogOperation.UpdateOrgChartSection,
                "update_org_member" => AuditLogOperation.UpdateOrgMember,
                "update_organization_info" => AuditLogOperation.UpdateOrganizationInfo,
                "update_payment_method" => AuditLogOperation.UpdatePaymentMethod,
                "update_payment_plan" => AuditLogOperation.UpdatePaymentPlan,
                "update_prompt_webhook" => AuditLogOperation.UpdatePromptWebhook,
                "update_role" => AuditLogOperation.UpdateRole,
                "update_scim_group" => AuditLogOperation.UpdateScimGroup,
                "update_scim_token" => AuditLogOperation.UpdateScimToken,
                "update_scim_user" => AuditLogOperation.UpdateScimUser,
                "update_sso_settings" => AuditLogOperation.UpdateSsoSettings,
                "update_tag_key" => AuditLogOperation.UpdateTagKey,
                "update_tag_value" => AuditLogOperation.UpdateTagValue,
                "update_tracer_session" => AuditLogOperation.UpdateTracerSession,
                "update_ttl_settings" => AuditLogOperation.UpdateTtlSettings,
                "update_usage_limit" => AuditLogOperation.UpdateUsageLimit,
                "update_workspace" => AuditLogOperation.UpdateWorkspace,
                "update_workspace_member" => AuditLogOperation.UpdateWorkspaceMember,
                "update_workspace_secrets" => AuditLogOperation.UpdateWorkspaceSecrets,
                _ => null,
            };
        }
    }
}