
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
        ProjectsCreate,
        /// <summary>
        /// 
        /// </summary>
        ProjectsDelete,
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
        PromptsUpdate,
        /// <summary>
        /// 
        /// </summary>
        PromptsShare,
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
        RunsRead,
        /// <summary>
        /// 
        /// </summary>
        RunsShare,
        /// <summary>
        /// 
        /// </summary>
        RunsDelete,
        /// <summary>
        /// 
        /// </summary>
        WorkspacesManageMembers,
        /// <summary>
        /// 
        /// </summary>
        WorkspacesManageSecrets,
        /// <summary>
        /// 
        /// </summary>
        WorkspacesManage,
        /// <summary>
        /// 
        /// </summary>
        WorkspacesRead,
        /// <summary>
        /// 
        /// </summary>
        AlertsCreate,
        /// <summary>
        /// 
        /// </summary>
        AlertsUpdate,
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
        OrganizationPATsCreate,
        /// <summary>
        /// 
        /// </summary>
        OrganizationRead,
        /// <summary>
        /// 
        /// </summary>
        OrganizationManage,
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
                AuthzInternalPermission.FeedbackCreate => "feedback:create",
                AuthzInternalPermission.FeedbackDelete => "feedback:delete",
                AuthzInternalPermission.FeedbackRead => "feedback:read",
                AuthzInternalPermission.FeedbackUpdate => "feedback:update",
                AuthzInternalPermission.ProjectsCreate => "projects:create",
                AuthzInternalPermission.ProjectsDelete => "projects:delete",
                AuthzInternalPermission.ProjectsRead => "projects:read",
                AuthzInternalPermission.ProjectsUpdate => "projects:update",
                AuthzInternalPermission.PromptsCreate => "prompts:create",
                AuthzInternalPermission.PromptsDelete => "prompts:delete",
                AuthzInternalPermission.PromptsRead => "prompts:read",
                AuthzInternalPermission.PromptsUpdate => "prompts:update",
                AuthzInternalPermission.PromptsShare => "prompts:share",
                AuthzInternalPermission.RulesCreate => "rules:create",
                AuthzInternalPermission.RulesDelete => "rules:delete",
                AuthzInternalPermission.RulesRead => "rules:read",
                AuthzInternalPermission.RulesUpdate => "rules:update",
                AuthzInternalPermission.RunsCreate => "runs:create",
                AuthzInternalPermission.RunsRead => "runs:read",
                AuthzInternalPermission.RunsShare => "runs:share",
                AuthzInternalPermission.RunsDelete => "runs:delete",
                AuthzInternalPermission.WorkspacesManageMembers => "workspaces:manage-members",
                AuthzInternalPermission.WorkspacesManageSecrets => "workspaces:manage-secrets",
                AuthzInternalPermission.WorkspacesManage => "workspaces:manage",
                AuthzInternalPermission.WorkspacesRead => "workspaces:read",
                AuthzInternalPermission.AlertsCreate => "alerts:create",
                AuthzInternalPermission.AlertsUpdate => "alerts:update",
                AuthzInternalPermission.AlertsDelete => "alerts:delete",
                AuthzInternalPermission.AlertsRead => "alerts:read",
                AuthzInternalPermission.OrganizationPATsCreate => "organization:pats:create",
                AuthzInternalPermission.OrganizationRead => "organization:read",
                AuthzInternalPermission.OrganizationManage => "organization:manage",
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
                "feedback:create" => AuthzInternalPermission.FeedbackCreate,
                "feedback:delete" => AuthzInternalPermission.FeedbackDelete,
                "feedback:read" => AuthzInternalPermission.FeedbackRead,
                "feedback:update" => AuthzInternalPermission.FeedbackUpdate,
                "projects:create" => AuthzInternalPermission.ProjectsCreate,
                "projects:delete" => AuthzInternalPermission.ProjectsDelete,
                "projects:read" => AuthzInternalPermission.ProjectsRead,
                "projects:update" => AuthzInternalPermission.ProjectsUpdate,
                "prompts:create" => AuthzInternalPermission.PromptsCreate,
                "prompts:delete" => AuthzInternalPermission.PromptsDelete,
                "prompts:read" => AuthzInternalPermission.PromptsRead,
                "prompts:update" => AuthzInternalPermission.PromptsUpdate,
                "prompts:share" => AuthzInternalPermission.PromptsShare,
                "rules:create" => AuthzInternalPermission.RulesCreate,
                "rules:delete" => AuthzInternalPermission.RulesDelete,
                "rules:read" => AuthzInternalPermission.RulesRead,
                "rules:update" => AuthzInternalPermission.RulesUpdate,
                "runs:create" => AuthzInternalPermission.RunsCreate,
                "runs:read" => AuthzInternalPermission.RunsRead,
                "runs:share" => AuthzInternalPermission.RunsShare,
                "runs:delete" => AuthzInternalPermission.RunsDelete,
                "workspaces:manage-members" => AuthzInternalPermission.WorkspacesManageMembers,
                "workspaces:manage-secrets" => AuthzInternalPermission.WorkspacesManageSecrets,
                "workspaces:manage" => AuthzInternalPermission.WorkspacesManage,
                "workspaces:read" => AuthzInternalPermission.WorkspacesRead,
                "alerts:create" => AuthzInternalPermission.AlertsCreate,
                "alerts:update" => AuthzInternalPermission.AlertsUpdate,
                "alerts:delete" => AuthzInternalPermission.AlertsDelete,
                "alerts:read" => AuthzInternalPermission.AlertsRead,
                "organization:pats:create" => AuthzInternalPermission.OrganizationPATsCreate,
                "organization:read" => AuthzInternalPermission.OrganizationRead,
                "organization:manage" => AuthzInternalPermission.OrganizationManage,
                _ => null,
            };
        }
    }
}