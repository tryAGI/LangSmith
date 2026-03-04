
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtlSettingsUpdateTtlSettingsRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("longlived_ttl_days")]
        public int? LonglivedTtlDays { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtlSettingsUpdateTtlSettingsRequest" /> class.
        /// </summary>
        /// <param name="longlivedTtlDays"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtlSettingsUpdateTtlSettingsRequest(
            int? longlivedTtlDays)
        {
            this.LonglivedTtlDays = longlivedTtlDays;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtlSettingsUpdateTtlSettingsRequest" /> class.
        /// </summary>
        public TtlSettingsUpdateTtlSettingsRequest()
        {
        }
    }
}