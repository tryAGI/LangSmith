
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
        AnnotationQueues_create,
        /// <summary>
        /// 
        /// </summary>
        AnnotationQueues_delete,
        /// <summary>
        /// 
        /// </summary>
        AnnotationQueues_read,
        /// <summary>
        /// 
        /// </summary>
        AnnotationQueues_update,
        /// <summary>
        /// 
        /// </summary>
        Charts_create,
        /// <summary>
        /// 
        /// </summary>
        Charts_delete,
        /// <summary>
        /// 
        /// </summary>
        Charts_read,
        /// <summary>
        /// 
        /// </summary>
        Charts_update,
        /// <summary>
        /// 
        /// </summary>
        Datasets_create,
        /// <summary>
        /// 
        /// </summary>
        Datasets_delete,
        /// <summary>
        /// 
        /// </summary>
        Datasets_read,
        /// <summary>
        /// 
        /// </summary>
        Datasets_share,
        /// <summary>
        /// 
        /// </summary>
        Datasets_update,
        /// <summary>
        /// 
        /// </summary>
        Deployments_create,
        /// <summary>
        /// 
        /// </summary>
        Deployments_delete,
        /// <summary>
        /// 
        /// </summary>
        Deployments_read,
        /// <summary>
        /// 
        /// </summary>
        Deployments_update,
        /// <summary>
        /// 
        /// </summary>
        Feedback_create,
        /// <summary>
        /// 
        /// </summary>
        Feedback_delete,
        /// <summary>
        /// 
        /// </summary>
        Feedback_read,
        /// <summary>
        /// 
        /// </summary>
        Feedback_update,
        /// <summary>
        /// 
        /// </summary>
        Projects_create,
        /// <summary>
        /// 
        /// </summary>
        Projects_delete,
        /// <summary>
        /// 
        /// </summary>
        Projects_read,
        /// <summary>
        /// 
        /// </summary>
        Projects_update,
        /// <summary>
        /// 
        /// </summary>
        Prompts_create,
        /// <summary>
        /// 
        /// </summary>
        Prompts_delete,
        /// <summary>
        /// 
        /// </summary>
        Prompts_read,
        /// <summary>
        /// 
        /// </summary>
        Prompts_update,
        /// <summary>
        /// 
        /// </summary>
        Prompts_share,
        /// <summary>
        /// 
        /// </summary>
        Rules_create,
        /// <summary>
        /// 
        /// </summary>
        Rules_delete,
        /// <summary>
        /// 
        /// </summary>
        Rules_read,
        /// <summary>
        /// 
        /// </summary>
        Rules_update,
        /// <summary>
        /// 
        /// </summary>
        Runs_create,
        /// <summary>
        /// 
        /// </summary>
        Runs_read,
        /// <summary>
        /// 
        /// </summary>
        Runs_share,
        /// <summary>
        /// 
        /// </summary>
        Runs_delete,
        /// <summary>
        /// 
        /// </summary>
        Workspaces_manageMembers,
        /// <summary>
        /// 
        /// </summary>
        Workspaces_manageSecrets,
        /// <summary>
        /// 
        /// </summary>
        Workspaces_manage,
        /// <summary>
        /// 
        /// </summary>
        Workspaces_read,
        /// <summary>
        /// 
        /// </summary>
        Alerts_create,
        /// <summary>
        /// 
        /// </summary>
        Alerts_update,
        /// <summary>
        /// 
        /// </summary>
        Alerts_delete,
        /// <summary>
        /// 
        /// </summary>
        Alerts_read,
        /// <summary>
        /// 
        /// </summary>
        Organization_pats_create,
        /// <summary>
        /// 
        /// </summary>
        Organization_read,
        /// <summary>
        /// 
        /// </summary>
        Organization_manage,
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
                AuthzInternalPermission.AnnotationQueues_create => "annotation-queues:create",
                AuthzInternalPermission.AnnotationQueues_delete => "annotation-queues:delete",
                AuthzInternalPermission.AnnotationQueues_read => "annotation-queues:read",
                AuthzInternalPermission.AnnotationQueues_update => "annotation-queues:update",
                AuthzInternalPermission.Charts_create => "charts:create",
                AuthzInternalPermission.Charts_delete => "charts:delete",
                AuthzInternalPermission.Charts_read => "charts:read",
                AuthzInternalPermission.Charts_update => "charts:update",
                AuthzInternalPermission.Datasets_create => "datasets:create",
                AuthzInternalPermission.Datasets_delete => "datasets:delete",
                AuthzInternalPermission.Datasets_read => "datasets:read",
                AuthzInternalPermission.Datasets_share => "datasets:share",
                AuthzInternalPermission.Datasets_update => "datasets:update",
                AuthzInternalPermission.Deployments_create => "deployments:create",
                AuthzInternalPermission.Deployments_delete => "deployments:delete",
                AuthzInternalPermission.Deployments_read => "deployments:read",
                AuthzInternalPermission.Deployments_update => "deployments:update",
                AuthzInternalPermission.Feedback_create => "feedback:create",
                AuthzInternalPermission.Feedback_delete => "feedback:delete",
                AuthzInternalPermission.Feedback_read => "feedback:read",
                AuthzInternalPermission.Feedback_update => "feedback:update",
                AuthzInternalPermission.Projects_create => "projects:create",
                AuthzInternalPermission.Projects_delete => "projects:delete",
                AuthzInternalPermission.Projects_read => "projects:read",
                AuthzInternalPermission.Projects_update => "projects:update",
                AuthzInternalPermission.Prompts_create => "prompts:create",
                AuthzInternalPermission.Prompts_delete => "prompts:delete",
                AuthzInternalPermission.Prompts_read => "prompts:read",
                AuthzInternalPermission.Prompts_update => "prompts:update",
                AuthzInternalPermission.Prompts_share => "prompts:share",
                AuthzInternalPermission.Rules_create => "rules:create",
                AuthzInternalPermission.Rules_delete => "rules:delete",
                AuthzInternalPermission.Rules_read => "rules:read",
                AuthzInternalPermission.Rules_update => "rules:update",
                AuthzInternalPermission.Runs_create => "runs:create",
                AuthzInternalPermission.Runs_read => "runs:read",
                AuthzInternalPermission.Runs_share => "runs:share",
                AuthzInternalPermission.Runs_delete => "runs:delete",
                AuthzInternalPermission.Workspaces_manageMembers => "workspaces:manage-members",
                AuthzInternalPermission.Workspaces_manageSecrets => "workspaces:manage-secrets",
                AuthzInternalPermission.Workspaces_manage => "workspaces:manage",
                AuthzInternalPermission.Workspaces_read => "workspaces:read",
                AuthzInternalPermission.Alerts_create => "alerts:create",
                AuthzInternalPermission.Alerts_update => "alerts:update",
                AuthzInternalPermission.Alerts_delete => "alerts:delete",
                AuthzInternalPermission.Alerts_read => "alerts:read",
                AuthzInternalPermission.Organization_pats_create => "organization:pats:create",
                AuthzInternalPermission.Organization_read => "organization:read",
                AuthzInternalPermission.Organization_manage => "organization:manage",
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
                "annotation-queues:create" => AuthzInternalPermission.AnnotationQueues_create,
                "annotation-queues:delete" => AuthzInternalPermission.AnnotationQueues_delete,
                "annotation-queues:read" => AuthzInternalPermission.AnnotationQueues_read,
                "annotation-queues:update" => AuthzInternalPermission.AnnotationQueues_update,
                "charts:create" => AuthzInternalPermission.Charts_create,
                "charts:delete" => AuthzInternalPermission.Charts_delete,
                "charts:read" => AuthzInternalPermission.Charts_read,
                "charts:update" => AuthzInternalPermission.Charts_update,
                "datasets:create" => AuthzInternalPermission.Datasets_create,
                "datasets:delete" => AuthzInternalPermission.Datasets_delete,
                "datasets:read" => AuthzInternalPermission.Datasets_read,
                "datasets:share" => AuthzInternalPermission.Datasets_share,
                "datasets:update" => AuthzInternalPermission.Datasets_update,
                "deployments:create" => AuthzInternalPermission.Deployments_create,
                "deployments:delete" => AuthzInternalPermission.Deployments_delete,
                "deployments:read" => AuthzInternalPermission.Deployments_read,
                "deployments:update" => AuthzInternalPermission.Deployments_update,
                "feedback:create" => AuthzInternalPermission.Feedback_create,
                "feedback:delete" => AuthzInternalPermission.Feedback_delete,
                "feedback:read" => AuthzInternalPermission.Feedback_read,
                "feedback:update" => AuthzInternalPermission.Feedback_update,
                "projects:create" => AuthzInternalPermission.Projects_create,
                "projects:delete" => AuthzInternalPermission.Projects_delete,
                "projects:read" => AuthzInternalPermission.Projects_read,
                "projects:update" => AuthzInternalPermission.Projects_update,
                "prompts:create" => AuthzInternalPermission.Prompts_create,
                "prompts:delete" => AuthzInternalPermission.Prompts_delete,
                "prompts:read" => AuthzInternalPermission.Prompts_read,
                "prompts:update" => AuthzInternalPermission.Prompts_update,
                "prompts:share" => AuthzInternalPermission.Prompts_share,
                "rules:create" => AuthzInternalPermission.Rules_create,
                "rules:delete" => AuthzInternalPermission.Rules_delete,
                "rules:read" => AuthzInternalPermission.Rules_read,
                "rules:update" => AuthzInternalPermission.Rules_update,
                "runs:create" => AuthzInternalPermission.Runs_create,
                "runs:read" => AuthzInternalPermission.Runs_read,
                "runs:share" => AuthzInternalPermission.Runs_share,
                "runs:delete" => AuthzInternalPermission.Runs_delete,
                "workspaces:manage-members" => AuthzInternalPermission.Workspaces_manageMembers,
                "workspaces:manage-secrets" => AuthzInternalPermission.Workspaces_manageSecrets,
                "workspaces:manage" => AuthzInternalPermission.Workspaces_manage,
                "workspaces:read" => AuthzInternalPermission.Workspaces_read,
                "alerts:create" => AuthzInternalPermission.Alerts_create,
                "alerts:update" => AuthzInternalPermission.Alerts_update,
                "alerts:delete" => AuthzInternalPermission.Alerts_delete,
                "alerts:read" => AuthzInternalPermission.Alerts_read,
                "organization:pats:create" => AuthzInternalPermission.Organization_pats_create,
                "organization:read" => AuthzInternalPermission.Organization_read,
                "organization:manage" => AuthzInternalPermission.Organization_manage,
                _ => null,
            };
        }
    }
}