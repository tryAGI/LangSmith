
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Request body for creating or updating a usage limit.
    /// </summary>
    public sealed partial class UpsertUsageLimit
    {
        /// <summary>
        /// Type of usage limit.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.UsageLimitTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.UsageLimitType LimitType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit_value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int LimitValue { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public global::System.Guid? Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertUsageLimit" /> class.
        /// </summary>
        /// <param name="limitType">
        /// Type of usage limit.
        /// </param>
        /// <param name="limitValue"></param>
        /// <param name="id"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public UpsertUsageLimit(
            global::LangSmith.UsageLimitType limitType,
            int limitValue,
            global::System.Guid? id)
        {
            this.LimitType = limitType;
            this.LimitValue = limitValue;
            this.Id = id;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpsertUsageLimit" /> class.
        /// </summary>
        public UpsertUsageLimit()
        {
        }
    }
}