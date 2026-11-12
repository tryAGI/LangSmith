
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataPlanesCreateDataPlaneCMKSettingsVariant2
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("service_key_arns")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object ServiceKeyArns { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesCreateDataPlaneCMKSettingsVariant2" /> class.
        /// </summary>
        /// <param name="serviceKeyArns"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesCreateDataPlaneCMKSettingsVariant2(
            object serviceKeyArns)
        {
            this.ServiceKeyArns = serviceKeyArns ?? throw new global::System.ArgumentNullException(nameof(serviceKeyArns));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesCreateDataPlaneCMKSettingsVariant2" /> class.
        /// </summary>
        public DataPlanesCreateDataPlaneCMKSettingsVariant2()
        {
        }

    }
}