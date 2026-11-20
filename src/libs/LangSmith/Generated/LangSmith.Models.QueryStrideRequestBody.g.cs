
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class QueryStrideRequestBody
    {
        /// <summary>
        /// `unit` is the unit of time used for each bucket. See the `StrideUnit` enum for allowed values.<br/>
        /// Example: HOUR
        /// </summary>
        /// <example>HOUR</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("unit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.QueryStrideUnitJsonConverter))]
        public global::LangSmith.QueryStrideUnit? Unit { get; set; }

        /// <summary>
        /// `value` is the number of time units per bucket. Must be at least 1.<br/>
        /// Example: 1
        /// </summary>
        /// <example>1</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public int? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryStrideRequestBody" /> class.
        /// </summary>
        /// <param name="unit">
        /// `unit` is the unit of time used for each bucket. See the `StrideUnit` enum for allowed values.<br/>
        /// Example: HOUR
        /// </param>
        /// <param name="value">
        /// `value` is the number of time units per bucket. Must be at least 1.<br/>
        /// Example: 1
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public QueryStrideRequestBody(
            global::LangSmith.QueryStrideUnit? unit,
            int? value)
        {
            this.Unit = unit;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryStrideRequestBody" /> class.
        /// </summary>
        public QueryStrideRequestBody()
        {
        }

    }
}