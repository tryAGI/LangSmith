
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class TtlSettingsTtlSettingsResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_custom")]
        public bool? IsCustom { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("longlived_ttl_days")]
        public int? LonglivedTtlDays { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tenant_id")]
        public string? TenantId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="TtlSettingsTtlSettingsResponse" /> class.
        /// </summary>
        /// <param name="isCustom"></param>
        /// <param name="longlivedTtlDays"></param>
        /// <param name="tenantId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public TtlSettingsTtlSettingsResponse(
            bool? isCustom,
            int? longlivedTtlDays,
            string? tenantId)
        {
            this.IsCustom = isCustom;
            this.LonglivedTtlDays = longlivedTtlDays;
            this.TenantId = tenantId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TtlSettingsTtlSettingsResponse" /> class.
        /// </summary>
        public TtlSettingsTtlSettingsResponse()
        {
        }
    }
}