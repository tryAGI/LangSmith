
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Operations that can be logged in audit_logs database table.<br/>
    /// NOTE: not all of @audit_log_operation(&lt;log name&gt;) names are currently used here.<br/>
    /// NOTE: OCSF mapping: endpoints with POST method and operation prefixed with "update_"<br/>
    /// map to OCSF UPDATE activity type.
    /// </summary>
    public enum AuditLogOperation
    {
        /// <summary>
        /// 
        /// </summary>
        CreateApiKey,
        /// <summary>
        /// 
        /// </summary>
        DeleteApiKey,
        /// <summary>
        /// 
        /// </summary>
        CreatePersonalAccessToken,
        /// <summary>
        /// 
        /// </summary>
        DeletePersonalAccessToken,
        /// <summary>
        /// 
        /// </summary>
        CreateServiceKey,
        /// <summary>
        /// 
        /// </summary>
        DeleteServiceKey,
        /// <summary>
        /// 
        /// </summary>
        CreateRole,
        /// <summary>
        /// 
        /// </summary>
        UpdateRole,
        /// <summary>
        /// 
        /// </summary>
        DeleteRole,
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
        AddBasicAuthUsersToOrg,
        /// <summary>
        /// 
        /// </summary>
        UpdateBasicAuthUser,
        /// <summary>
        /// 
        /// </summary>
        DeleteOrgPendingMember,
        /// <summary>
        /// 
        /// </summary>
        DeleteOrgMember,
        /// <summary>
        /// 
        /// </summary>
        UpdateOrgMember,
        /// <summary>
        /// 
        /// </summary>
        CreateSsoSettings,
        /// <summary>
        /// 
        /// </summary>
        UpdateSsoSettings,
        /// <summary>
        /// 
        /// </summary>
        DeleteSsoSettings,
        /// <summary>
        /// 
        /// </summary>
        UpdateDefaultSsoProvisionOrganization,
        /// <summary>
        /// 
        /// </summary>
        UpdateLoginMethods,
        /// <summary>
        /// 
        /// </summary>
        UpdateOrganizationInfo,
        /// <summary>
        /// 
        /// </summary>
        UpdateBusinessInfo,
        /// <summary>
        /// 
        /// </summary>
        UpdatePaymentPlan,
        /// <summary>
        /// 
        /// </summary>
        UpdatePaymentMethod,
        /// <summary>
        /// 
        /// </summary>
        CreatePaymentSetupIntent,
        /// <summary>
        /// 
        /// </summary>
        CreatePaymentCheckoutSession,
        /// <summary>
        /// 
        /// </summary>
        ConfirmPaymentCheckoutSession,
        /// <summary>
        /// 
        /// </summary>
        CreatePaymentAccountLink,
        /// <summary>
        /// 
        /// </summary>
        CreateWorkspace,
        /// <summary>
        /// 
        /// </summary>
        UpdateWorkspace,
        /// <summary>
        /// 
        /// </summary>
        DeleteWorkspace,
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
        DeleteWorkspaceMember,
        /// <summary>
        /// 
        /// </summary>
        UpdateWorkspaceMember,
        /// <summary>
        /// 
        /// </summary>
        DeleteWorkspacePendingMember,
        /// <summary>
        /// 
        /// </summary>
        UpdateWorkspaceSecrets,
        /// <summary>
        /// 
        /// </summary>
        UnshareEntities,
        /// <summary>
        /// 
        /// </summary>
        SetTenantHandle,
        /// <summary>
        /// 
        /// </summary>
        CreateTagKey,
        /// <summary>
        /// 
        /// </summary>
        UpdateTagKey,
        /// <summary>
        /// 
        /// </summary>
        DeleteTagKey,
        /// <summary>
        /// 
        /// </summary>
        CreateTagValue,
        /// <summary>
        /// 
        /// </summary>
        UpdateTagValue,
        /// <summary>
        /// 
        /// </summary>
        DeleteTagValue,
        /// <summary>
        /// 
        /// </summary>
        CreateTagging,
        /// <summary>
        /// 
        /// </summary>
        DeleteTagging,
        /// <summary>
        /// 
        /// </summary>
        CreateBulkExport,
        /// <summary>
        /// 
        /// </summary>
        CancelBulkExport,
        /// <summary>
        /// 
        /// </summary>
        CreateBulkExportDestination,
        /// <summary>
        /// 
        /// </summary>
        UpdateBulkExportDestination,
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
        DeleteUsageLimit,
        /// <summary>
        /// 
        /// </summary>
        CreateModelPriceMap,
        /// <summary>
        /// 
        /// </summary>
        UpdateModelPriceMap,
        /// <summary>
        /// 
        /// </summary>
        DeleteModelPriceMap,
        /// <summary>
        /// 
        /// </summary>
        CreateChart,
        /// <summary>
        /// 
        /// </summary>
        UpdateChart,
        /// <summary>
        /// 
        /// </summary>
        DeleteChart,
        /// <summary>
        /// 
        /// </summary>
        CreateChartSection,
        /// <summary>
        /// 
        /// </summary>
        UpdateChartSection,
        /// <summary>
        /// 
        /// </summary>
        DeleteChartSection,
        /// <summary>
        /// 
        /// </summary>
        CloneChartSection,
        /// <summary>
        /// 
        /// </summary>
        CreateOrgChart,
        /// <summary>
        /// 
        /// </summary>
        UpdateOrgChart,
        /// <summary>
        /// 
        /// </summary>
        DeleteOrgChart,
        /// <summary>
        /// 
        /// </summary>
        CreateOrgChartSection,
        /// <summary>
        /// 
        /// </summary>
        UpdateOrgChartSection,
        /// <summary>
        /// 
        /// </summary>
        DeleteOrgChartSection,
        /// <summary>
        /// 
        /// </summary>
        CreateDeployment,
        /// <summary>
        /// 
        /// </summary>
        UpdateDeployment,
        /// <summary>
        /// 
        /// </summary>
        DeleteDeployment,
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
                AuditLogOperation.CreateApiKey => "create_api_key",
                AuditLogOperation.DeleteApiKey => "delete_api_key",
                AuditLogOperation.CreatePersonalAccessToken => "create_personal_access_token",
                AuditLogOperation.DeletePersonalAccessToken => "delete_personal_access_token",
                AuditLogOperation.CreateServiceKey => "create_service_key",
                AuditLogOperation.DeleteServiceKey => "delete_service_key",
                AuditLogOperation.CreateRole => "create_role",
                AuditLogOperation.UpdateRole => "update_role",
                AuditLogOperation.DeleteRole => "delete_role",
                AuditLogOperation.InviteUserToOrg => "invite_user_to_org",
                AuditLogOperation.InviteUsersToOrgBatch => "invite_users_to_org_batch",
                AuditLogOperation.AddBasicAuthUsersToOrg => "add_basic_auth_users_to_org",
                AuditLogOperation.UpdateBasicAuthUser => "update_basic_auth_user",
                AuditLogOperation.DeleteOrgPendingMember => "delete_org_pending_member",
                AuditLogOperation.DeleteOrgMember => "delete_org_member",
                AuditLogOperation.UpdateOrgMember => "update_org_member",
                AuditLogOperation.CreateSsoSettings => "create_sso_settings",
                AuditLogOperation.UpdateSsoSettings => "update_sso_settings",
                AuditLogOperation.DeleteSsoSettings => "delete_sso_settings",
                AuditLogOperation.UpdateDefaultSsoProvisionOrganization => "update_default_sso_provision_organization",
                AuditLogOperation.UpdateLoginMethods => "update_login_methods",
                AuditLogOperation.UpdateOrganizationInfo => "update_organization_info",
                AuditLogOperation.UpdateBusinessInfo => "update_business_info",
                AuditLogOperation.UpdatePaymentPlan => "update_payment_plan",
                AuditLogOperation.UpdatePaymentMethod => "update_payment_method",
                AuditLogOperation.CreatePaymentSetupIntent => "create_payment_setup_intent",
                AuditLogOperation.CreatePaymentCheckoutSession => "create_payment_checkout_session",
                AuditLogOperation.ConfirmPaymentCheckoutSession => "confirm_payment_checkout_session",
                AuditLogOperation.CreatePaymentAccountLink => "create_payment_account_link",
                AuditLogOperation.CreateWorkspace => "create_workspace",
                AuditLogOperation.UpdateWorkspace => "update_workspace",
                AuditLogOperation.DeleteWorkspace => "delete_workspace",
                AuditLogOperation.AddMemberToWorkspace => "add_member_to_workspace",
                AuditLogOperation.AddMembersToWorkspaceBatch => "add_members_to_workspace_batch",
                AuditLogOperation.DeleteWorkspaceMember => "delete_workspace_member",
                AuditLogOperation.UpdateWorkspaceMember => "update_workspace_member",
                AuditLogOperation.DeleteWorkspacePendingMember => "delete_workspace_pending_member",
                AuditLogOperation.UpdateWorkspaceSecrets => "update_workspace_secrets",
                AuditLogOperation.UnshareEntities => "unshare_entities",
                AuditLogOperation.SetTenantHandle => "set_tenant_handle",
                AuditLogOperation.CreateTagKey => "create_tag_key",
                AuditLogOperation.UpdateTagKey => "update_tag_key",
                AuditLogOperation.DeleteTagKey => "delete_tag_key",
                AuditLogOperation.CreateTagValue => "create_tag_value",
                AuditLogOperation.UpdateTagValue => "update_tag_value",
                AuditLogOperation.DeleteTagValue => "delete_tag_value",
                AuditLogOperation.CreateTagging => "create_tagging",
                AuditLogOperation.DeleteTagging => "delete_tagging",
                AuditLogOperation.CreateBulkExport => "create_bulk_export",
                AuditLogOperation.CancelBulkExport => "cancel_bulk_export",
                AuditLogOperation.CreateBulkExportDestination => "create_bulk_export_destination",
                AuditLogOperation.UpdateBulkExportDestination => "update_bulk_export_destination",
                AuditLogOperation.UpdateTtlSettings => "update_ttl_settings",
                AuditLogOperation.UpdateUsageLimit => "update_usage_limit",
                AuditLogOperation.DeleteUsageLimit => "delete_usage_limit",
                AuditLogOperation.CreateModelPriceMap => "create_model_price_map",
                AuditLogOperation.UpdateModelPriceMap => "update_model_price_map",
                AuditLogOperation.DeleteModelPriceMap => "delete_model_price_map",
                AuditLogOperation.CreateChart => "create_chart",
                AuditLogOperation.UpdateChart => "update_chart",
                AuditLogOperation.DeleteChart => "delete_chart",
                AuditLogOperation.CreateChartSection => "create_chart_section",
                AuditLogOperation.UpdateChartSection => "update_chart_section",
                AuditLogOperation.DeleteChartSection => "delete_chart_section",
                AuditLogOperation.CloneChartSection => "clone_chart_section",
                AuditLogOperation.CreateOrgChart => "create_org_chart",
                AuditLogOperation.UpdateOrgChart => "update_org_chart",
                AuditLogOperation.DeleteOrgChart => "delete_org_chart",
                AuditLogOperation.CreateOrgChartSection => "create_org_chart_section",
                AuditLogOperation.UpdateOrgChartSection => "update_org_chart_section",
                AuditLogOperation.DeleteOrgChartSection => "delete_org_chart_section",
                AuditLogOperation.CreateDeployment => "create_deployment",
                AuditLogOperation.UpdateDeployment => "update_deployment",
                AuditLogOperation.DeleteDeployment => "delete_deployment",
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
                "create_api_key" => AuditLogOperation.CreateApiKey,
                "delete_api_key" => AuditLogOperation.DeleteApiKey,
                "create_personal_access_token" => AuditLogOperation.CreatePersonalAccessToken,
                "delete_personal_access_token" => AuditLogOperation.DeletePersonalAccessToken,
                "create_service_key" => AuditLogOperation.CreateServiceKey,
                "delete_service_key" => AuditLogOperation.DeleteServiceKey,
                "create_role" => AuditLogOperation.CreateRole,
                "update_role" => AuditLogOperation.UpdateRole,
                "delete_role" => AuditLogOperation.DeleteRole,
                "invite_user_to_org" => AuditLogOperation.InviteUserToOrg,
                "invite_users_to_org_batch" => AuditLogOperation.InviteUsersToOrgBatch,
                "add_basic_auth_users_to_org" => AuditLogOperation.AddBasicAuthUsersToOrg,
                "update_basic_auth_user" => AuditLogOperation.UpdateBasicAuthUser,
                "delete_org_pending_member" => AuditLogOperation.DeleteOrgPendingMember,
                "delete_org_member" => AuditLogOperation.DeleteOrgMember,
                "update_org_member" => AuditLogOperation.UpdateOrgMember,
                "create_sso_settings" => AuditLogOperation.CreateSsoSettings,
                "update_sso_settings" => AuditLogOperation.UpdateSsoSettings,
                "delete_sso_settings" => AuditLogOperation.DeleteSsoSettings,
                "update_default_sso_provision_organization" => AuditLogOperation.UpdateDefaultSsoProvisionOrganization,
                "update_login_methods" => AuditLogOperation.UpdateLoginMethods,
                "update_organization_info" => AuditLogOperation.UpdateOrganizationInfo,
                "update_business_info" => AuditLogOperation.UpdateBusinessInfo,
                "update_payment_plan" => AuditLogOperation.UpdatePaymentPlan,
                "update_payment_method" => AuditLogOperation.UpdatePaymentMethod,
                "create_payment_setup_intent" => AuditLogOperation.CreatePaymentSetupIntent,
                "create_payment_checkout_session" => AuditLogOperation.CreatePaymentCheckoutSession,
                "confirm_payment_checkout_session" => AuditLogOperation.ConfirmPaymentCheckoutSession,
                "create_payment_account_link" => AuditLogOperation.CreatePaymentAccountLink,
                "create_workspace" => AuditLogOperation.CreateWorkspace,
                "update_workspace" => AuditLogOperation.UpdateWorkspace,
                "delete_workspace" => AuditLogOperation.DeleteWorkspace,
                "add_member_to_workspace" => AuditLogOperation.AddMemberToWorkspace,
                "add_members_to_workspace_batch" => AuditLogOperation.AddMembersToWorkspaceBatch,
                "delete_workspace_member" => AuditLogOperation.DeleteWorkspaceMember,
                "update_workspace_member" => AuditLogOperation.UpdateWorkspaceMember,
                "delete_workspace_pending_member" => AuditLogOperation.DeleteWorkspacePendingMember,
                "update_workspace_secrets" => AuditLogOperation.UpdateWorkspaceSecrets,
                "unshare_entities" => AuditLogOperation.UnshareEntities,
                "set_tenant_handle" => AuditLogOperation.SetTenantHandle,
                "create_tag_key" => AuditLogOperation.CreateTagKey,
                "update_tag_key" => AuditLogOperation.UpdateTagKey,
                "delete_tag_key" => AuditLogOperation.DeleteTagKey,
                "create_tag_value" => AuditLogOperation.CreateTagValue,
                "update_tag_value" => AuditLogOperation.UpdateTagValue,
                "delete_tag_value" => AuditLogOperation.DeleteTagValue,
                "create_tagging" => AuditLogOperation.CreateTagging,
                "delete_tagging" => AuditLogOperation.DeleteTagging,
                "create_bulk_export" => AuditLogOperation.CreateBulkExport,
                "cancel_bulk_export" => AuditLogOperation.CancelBulkExport,
                "create_bulk_export_destination" => AuditLogOperation.CreateBulkExportDestination,
                "update_bulk_export_destination" => AuditLogOperation.UpdateBulkExportDestination,
                "update_ttl_settings" => AuditLogOperation.UpdateTtlSettings,
                "update_usage_limit" => AuditLogOperation.UpdateUsageLimit,
                "delete_usage_limit" => AuditLogOperation.DeleteUsageLimit,
                "create_model_price_map" => AuditLogOperation.CreateModelPriceMap,
                "update_model_price_map" => AuditLogOperation.UpdateModelPriceMap,
                "delete_model_price_map" => AuditLogOperation.DeleteModelPriceMap,
                "create_chart" => AuditLogOperation.CreateChart,
                "update_chart" => AuditLogOperation.UpdateChart,
                "delete_chart" => AuditLogOperation.DeleteChart,
                "create_chart_section" => AuditLogOperation.CreateChartSection,
                "update_chart_section" => AuditLogOperation.UpdateChartSection,
                "delete_chart_section" => AuditLogOperation.DeleteChartSection,
                "clone_chart_section" => AuditLogOperation.CloneChartSection,
                "create_org_chart" => AuditLogOperation.CreateOrgChart,
                "update_org_chart" => AuditLogOperation.UpdateOrgChart,
                "delete_org_chart" => AuditLogOperation.DeleteOrgChart,
                "create_org_chart_section" => AuditLogOperation.CreateOrgChartSection,
                "update_org_chart_section" => AuditLogOperation.UpdateOrgChartSection,
                "delete_org_chart_section" => AuditLogOperation.DeleteOrgChartSection,
                "create_deployment" => AuditLogOperation.CreateDeployment,
                "update_deployment" => AuditLogOperation.UpdateDeployment,
                "delete_deployment" => AuditLogOperation.DeleteDeployment,
                _ => null,
            };
        }
    }
}