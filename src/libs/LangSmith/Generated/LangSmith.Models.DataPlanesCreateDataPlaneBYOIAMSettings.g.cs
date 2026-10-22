
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataPlanesCreateDataPlaneBYOIAMSettings
    {
        /// <summary>
        /// Use customer-managed IAM roles created by the LangSmith BYOIAM Terraform module.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_enabled")]
        public bool? IsEnabled { get; set; }

        /// <summary>
        /// Custom names of the customer-managed IAM resources. Requires is_enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_names")]
        public global::LangSmith.DataPlanesDataPlaneBYOIAMResourceNames? ResourceNames { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesCreateDataPlaneBYOIAMSettings" /> class.
        /// </summary>
        /// <param name="isEnabled">
        /// Use customer-managed IAM roles created by the LangSmith BYOIAM Terraform module.
        /// </param>
        /// <param name="resourceNames">
        /// Custom names of the customer-managed IAM resources. Requires is_enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesCreateDataPlaneBYOIAMSettings(
            bool? isEnabled,
            global::LangSmith.DataPlanesDataPlaneBYOIAMResourceNames? resourceNames)
        {
            this.IsEnabled = isEnabled;
            this.ResourceNames = resourceNames;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesCreateDataPlaneBYOIAMSettings" /> class.
        /// </summary>
        public DataPlanesCreateDataPlaneBYOIAMSettings()
        {
        }

    }
}