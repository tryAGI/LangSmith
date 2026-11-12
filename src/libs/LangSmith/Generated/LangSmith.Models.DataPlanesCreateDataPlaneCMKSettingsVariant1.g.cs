
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DataPlanesCreateDataPlaneCMKSettingsVariant1
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key_arn")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object KeyArn { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesCreateDataPlaneCMKSettingsVariant1" /> class.
        /// </summary>
        /// <param name="keyArn"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DataPlanesCreateDataPlaneCMKSettingsVariant1(
            object keyArn)
        {
            this.KeyArn = keyArn ?? throw new global::System.ArgumentNullException(nameof(keyArn));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataPlanesCreateDataPlaneCMKSettingsVariant1" /> class.
        /// </summary>
        public DataPlanesCreateDataPlaneCMKSettingsVariant1()
        {
        }

    }
}