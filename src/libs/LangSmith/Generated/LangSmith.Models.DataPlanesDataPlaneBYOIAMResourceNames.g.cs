
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataPlanesDataPlaneBYOIAMResourceNames
    {
        /// <summary>
        /// Name of the Karpenter node instance profile. Supply the module's karpenter_instance_profile_name output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("karpenter_instance_profile_name")]
        public string? KarpenterInstanceProfileName { get; set; }

        /// <summary>
        /// Role names keyed by role, such as eks-cluster-role. Supply the module's role_names output.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_names")]
        public global::System.Collections.Generic.Dictionary<string, string>? RoleNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesDataPlaneBYOIAMResourceNames" /> class.
        /// </summary>
        /// <param name="karpenterInstanceProfileName">
        /// Name of the Karpenter node instance profile. Supply the module's karpenter_instance_profile_name output.
        /// </param>
        /// <param name="roleNames">
        /// Role names keyed by role, such as eks-cluster-role. Supply the module's role_names output.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesDataPlaneBYOIAMResourceNames(
            string? karpenterInstanceProfileName,
            global::System.Collections.Generic.Dictionary<string, string>? roleNames)
        {
            this.KarpenterInstanceProfileName = karpenterInstanceProfileName;
            this.RoleNames = roleNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesDataPlaneBYOIAMResourceNames" /> class.
        /// </summary>
        public DataPlanesDataPlaneBYOIAMResourceNames()
        {
        }

    }
}