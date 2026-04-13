
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum AuthzInternalPermission
    {
        /// <summary>
        /// 
        /// </summary>
        AlertsCreate,
        /// <summary>
        /// 
        /// </summary>
        AlertsDelete,
        /// <summary>
        /// 
        /// </summary>
        AlertsRead,
        /// <summary>
        /// 
        /// </summary>
        AlertsUpdate,
        /// <summary>
        /// 
        /// </summary>
        AnnotationQueuesCreate,
        /// <summary>
        /// 
        /// </summary>
        AnnotationQueuesDelete,
        /// <summary>
        /// 
        /// </summary>
        AnnotationQueuesRead,
        /// <summary>
        /// 
        /// </summary>
        AnnotationQueuesUpdate,
        /// <summary>
        /// 
        /// </summary>
        ChartsCreate,
        /// <summary>
        /// 
        /// </summary>
        ChartsDelete,
        /// <summary>
        /// 
        /// </summary>
        ChartsRead,
        /// <summary>
        /// 
        /// </summary>
        ChartsUpdate,
        /// <summary>
        /// 
        /// </summary>
        DatasetsCreate,
        /// <summary>
        /// 
        /// </summary>
        DatasetsDelete,
        /// <summary>
        /// 
        /// </summary>
        DatasetsRead,
        /// <summary>
        /// 
        /// </summary>
        DatasetsShare,
        /// <summary>
        /// 
        /// </summary>
        DatasetsUpdate,
        /// <summary>
        /// 
        /// </summary>
        DeploymentsCreate,
        /// <summary>
        /// 
        /// </summary>
        DeploymentsDelete,
        /// <summary>
        /// 
        /// </summary>
        DeploymentsRead,
        /// <summary>
        /// 
        /// </summary>
        DeploymentsUpdate,
        /// <summary>
        /// 
        /// </summary>
        ExperimentsRun,
        /// <summary>
        /// 
        /// </summary>
        FeedbackCreate,
        /// <summary>
        /// 
        /// </summary>
        FeedbackDelete,
        /// <summary>
        /// 
        /// </summary>
        FeedbackRead,
        /// <summary>
        /// 
        /// </summary>
        FeedbackUpdate,
        /// <summary>
        /// 
        /// </summary>
        FleetReadAdminConfig,
        /// <summary>
        /// 
        /// </summary>
        FleetWriteAdminConfig,
        /// <summary>
        /// 
        /// </summary>
        McpServersCreate,
        /// <summary>
        /// 
        /// </summary>
        McpServersDelete,
        /// <summary>
        /// 
        /// </summary>
        McpServersInvoke,
        /// <summary>
        /// 
        /// </summary>
        McpServersRead,
        /// <summary>
        /// 
        /// </summary>
        McpServersUpdate,
        /// <summary>
        /// 
        /// </summary>
        OrganizationManage,
        /// <summary>
        /// 
        /// </summary>
        OrganizationPATsCreate,
        /// <summary>
        /// 
        /// </summary>
        OrganizationRead,
        /// <summary>
        /// 
        /// </summary>
        ProjectsCreate,
        /// <summary>
        /// 
        /// </summary>
        ProjectsDecreaseTraceTier,
        /// <summary>
        /// 
        /// </summary>
        ProjectsDelete,
        /// <summary>
        /// 
        /// </summary>
        ProjectsIncreaseTraceTier,
        /// <summary>
        /// 
        /// </summary>
        ProjectsRead,
        /// <summary>
        /// 
        /// </summary>
        ProjectsUpdate,
        /// <summary>
        /// 
        /// </summary>
        PromptsCreate,
        /// <summary>
        /// 
        /// </summary>
        PromptsDelete,
        /// <summary>
        /// 
        /// </summary>
        PromptsRead,
        /// <summary>
        /// 
        /// </summary>
        PromptsShare,
        /// <summary>
        /// 
        /// </summary>
        PromptsUpdate,
        /// <summary>
        /// 
        /// </summary>
        RulesCreate,
        /// <summary>
        /// 
        /// </summary>
        RulesDelete,
        /// <summary>
        /// 
        /// </summary>
        RulesRead,
        /// <summary>
        /// 
        /// </summary>
        RulesUpdate,
        /// <summary>
        /// 
        /// </summary>
        RunsCreate,
        /// <summary>
        /// 
        /// </summary>
        RunsDelete,
        /// <summary>
        /// 
        /// </summary>
        RunsRead,
        /// <summary>
        /// 
        /// </summary>
        RunsShare,
        /// <summary>
        /// 
        /// </summary>
        WorkspacesManage,
        /// <summary>
        /// 
        /// </summary>
        WorkspacesManageMembers,
        /// <summary>
        /// 
        /// </summary>
        WorkspacesManageModelConfigs,
        /// <summary>
        /// 
        /// </summary>
        WorkspacesManageSecrets,
        /// <summary>
        /// 
        /// </summary>
        WorkspacesRead,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AuthzInternalPermissionExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AuthzInternalPermission value)
        {
            return value switch
            {
                AuthzInternalPermission.AlertsCreate => "alerts:create",
                AuthzInternalPermission.AlertsDelete => "alerts:delete",
                AuthzInternalPermission.AlertsRead => "alerts:read",
                AuthzInternalPermission.AlertsUpdate => "alerts:update",
                AuthzInternalPermission.AnnotationQueuesCreate => "annotation-queues:create",
                AuthzInternalPermission.AnnotationQueuesDelete => "annotation-queues:delete",
                AuthzInternalPermission.AnnotationQueuesRead => "annotation-queues:read",
                AuthzInternalPermission.AnnotationQueuesUpdate => "annotation-queues:update",
                AuthzInternalPermission.ChartsCreate => "charts:create",
                AuthzInternalPermission.ChartsDelete => "charts:delete",
                AuthzInternalPermission.ChartsRead => "charts:read",
                AuthzInternalPermission.ChartsUpdate => "charts:update",
                AuthzInternalPermission.DatasetsCreate => "datasets:create",
                AuthzInternalPermission.DatasetsDelete => "datasets:delete",
                AuthzInternalPermission.DatasetsRead => "datasets:read",
                AuthzInternalPermission.DatasetsShare => "datasets:share",
                AuthzInternalPermission.DatasetsUpdate => "datasets:update",
                AuthzInternalPermission.DeploymentsCreate => "deployments:create",
                AuthzInternalPermission.DeploymentsDelete => "deployments:delete",
                AuthzInternalPermission.DeploymentsRead => "deployments:read",
                AuthzInternalPermission.DeploymentsUpdate => "deployments:update",
                AuthzInternalPermission.ExperimentsRun => "experiments:run",
                AuthzInternalPermission.FeedbackCreate => "feedback:create",
                AuthzInternalPermission.FeedbackDelete => "feedback:delete",
                AuthzInternalPermission.FeedbackRead => "feedback:read",
                AuthzInternalPermission.FeedbackUpdate => "feedback:update",
                AuthzInternalPermission.FleetReadAdminConfig => "fleet:read-admin-config",
                AuthzInternalPermission.FleetWriteAdminConfig => "fleet:write-admin-config",
                AuthzInternalPermission.McpServersCreate => "mcp-servers:create",
                AuthzInternalPermission.McpServersDelete => "mcp-servers:delete",
                AuthzInternalPermission.McpServersInvoke => "mcp-servers:invoke",
                AuthzInternalPermission.McpServersRead => "mcp-servers:read",
                AuthzInternalPermission.McpServersUpdate => "mcp-servers:update",
                AuthzInternalPermission.OrganizationManage => "organization:manage",
                AuthzInternalPermission.OrganizationPATsCreate => "organization:pats:create",
                AuthzInternalPermission.OrganizationRead => "organization:read",
                AuthzInternalPermission.ProjectsCreate => "projects:create",
                AuthzInternalPermission.ProjectsDecreaseTraceTier => "projects:decrease-trace-tier",
                AuthzInternalPermission.ProjectsDelete => "projects:delete",
                AuthzInternalPermission.ProjectsIncreaseTraceTier => "projects:increase-trace-tier",
                AuthzInternalPermission.ProjectsRead => "projects:read",
                AuthzInternalPermission.ProjectsUpdate => "projects:update",
                AuthzInternalPermission.PromptsCreate => "prompts:create",
                AuthzInternalPermission.PromptsDelete => "prompts:delete",
                AuthzInternalPermission.PromptsRead => "prompts:read",
                AuthzInternalPermission.PromptsShare => "prompts:share",
                AuthzInternalPermission.PromptsUpdate => "prompts:update",
                AuthzInternalPermission.RulesCreate => "rules:create",
                AuthzInternalPermission.RulesDelete => "rules:delete",
                AuthzInternalPermission.RulesRead => "rules:read",
                AuthzInternalPermission.RulesUpdate => "rules:update",
                AuthzInternalPermission.RunsCreate => "runs:create",
                AuthzInternalPermission.RunsDelete => "runs:delete",
                AuthzInternalPermission.RunsRead => "runs:read",
                AuthzInternalPermission.RunsShare => "runs:share",
                AuthzInternalPermission.WorkspacesManage => "workspaces:manage",
                AuthzInternalPermission.WorkspacesManageMembers => "workspaces:manage-members",
                AuthzInternalPermission.WorkspacesManageModelConfigs => "workspaces:manage-model-configs",
                AuthzInternalPermission.WorkspacesManageSecrets => "workspaces:manage-secrets",
                AuthzInternalPermission.WorkspacesRead => "workspaces:read",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AuthzInternalPermission? ToEnum(string value)
        {
            return value switch
            {
                "alerts:create" => AuthzInternalPermission.AlertsCreate,
                "alerts:delete" => AuthzInternalPermission.AlertsDelete,
                "alerts:read" => AuthzInternalPermission.AlertsRead,
                "alerts:update" => AuthzInternalPermission.AlertsUpdate,
                "annotation-queues:create" => AuthzInternalPermission.AnnotationQueuesCreate,
                "annotation-queues:delete" => AuthzInternalPermission.AnnotationQueuesDelete,
                "annotation-queues:read" => AuthzInternalPermission.AnnotationQueuesRead,
                "annotation-queues:update" => AuthzInternalPermission.AnnotationQueuesUpdate,
                "charts:create" => AuthzInternalPermission.ChartsCreate,
                "charts:delete" => AuthzInternalPermission.ChartsDelete,
                "charts:read" => AuthzInternalPermission.ChartsRead,
                "charts:update" => AuthzInternalPermission.ChartsUpdate,
                "datasets:create" => AuthzInternalPermission.DatasetsCreate,
                "datasets:delete" => AuthzInternalPermission.DatasetsDelete,
                "datasets:read" => AuthzInternalPermission.DatasetsRead,
                "datasets:share" => AuthzInternalPermission.DatasetsShare,
                "datasets:update" => AuthzInternalPermission.DatasetsUpdate,
                "deployments:create" => AuthzInternalPermission.DeploymentsCreate,
                "deployments:delete" => AuthzInternalPermission.DeploymentsDelete,
                "deployments:read" => AuthzInternalPermission.DeploymentsRead,
                "deployments:update" => AuthzInternalPermission.DeploymentsUpdate,
                "experiments:run" => AuthzInternalPermission.ExperimentsRun,
                "feedback:create" => AuthzInternalPermission.FeedbackCreate,
                "feedback:delete" => AuthzInternalPermission.FeedbackDelete,
                "feedback:read" => AuthzInternalPermission.FeedbackRead,
                "feedback:update" => AuthzInternalPermission.FeedbackUpdate,
                "fleet:read-admin-config" => AuthzInternalPermission.FleetReadAdminConfig,
                "fleet:write-admin-config" => AuthzInternalPermission.FleetWriteAdminConfig,
                "mcp-servers:create" => AuthzInternalPermission.McpServersCreate,
                "mcp-servers:delete" => AuthzInternalPermission.McpServersDelete,
                "mcp-servers:invoke" => AuthzInternalPermission.McpServersInvoke,
                "mcp-servers:read" => AuthzInternalPermission.McpServersRead,
                "mcp-servers:update" => AuthzInternalPermission.McpServersUpdate,
                "organization:manage" => AuthzInternalPermission.OrganizationManage,
                "organization:pats:create" => AuthzInternalPermission.OrganizationPATsCreate,
                "organization:read" => AuthzInternalPermission.OrganizationRead,
                "projects:create" => AuthzInternalPermission.ProjectsCreate,
                "projects:decrease-trace-tier" => AuthzInternalPermission.ProjectsDecreaseTraceTier,
                "projects:delete" => AuthzInternalPermission.ProjectsDelete,
                "projects:increase-trace-tier" => AuthzInternalPermission.ProjectsIncreaseTraceTier,
                "projects:read" => AuthzInternalPermission.ProjectsRead,
                "projects:update" => AuthzInternalPermission.ProjectsUpdate,
                "prompts:create" => AuthzInternalPermission.PromptsCreate,
                "prompts:delete" => AuthzInternalPermission.PromptsDelete,
                "prompts:read" => AuthzInternalPermission.PromptsRead,
                "prompts:share" => AuthzInternalPermission.PromptsShare,
                "prompts:update" => AuthzInternalPermission.PromptsUpdate,
                "rules:create" => AuthzInternalPermission.RulesCreate,
                "rules:delete" => AuthzInternalPermission.RulesDelete,
                "rules:read" => AuthzInternalPermission.RulesRead,
                "rules:update" => AuthzInternalPermission.RulesUpdate,
                "runs:create" => AuthzInternalPermission.RunsCreate,
                "runs:delete" => AuthzInternalPermission.RunsDelete,
                "runs:read" => AuthzInternalPermission.RunsRead,
                "runs:share" => AuthzInternalPermission.RunsShare,
                "workspaces:manage" => AuthzInternalPermission.WorkspacesManage,
                "workspaces:manage-members" => AuthzInternalPermission.WorkspacesManageMembers,
                "workspaces:manage-model-configs" => AuthzInternalPermission.WorkspacesManageModelConfigs,
                "workspaces:manage-secrets" => AuthzInternalPermission.WorkspacesManageSecrets,
                "workspaces:read" => AuthzInternalPermission.WorkspacesRead,
                _ => null,
            };
        }
    }
}