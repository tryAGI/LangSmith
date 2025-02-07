
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class MonitorRequest
    {
        /// <summary>
        /// Default Value: UTC
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("groups")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::LangSmith.MonitorGroupSpec> Groups { get; set; }

        /// <summary>
        /// Timedelta input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("interval")]
        public global::LangSmith.TimedeltaInput? Interval { get; set; }

        /// <summary>
        /// Timedelta input.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stride")]
        public global::LangSmith.TimedeltaInput? Stride { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorRequest" /> class.
        /// </summary>
        /// <param name="timezone">
        /// Default Value: UTC
        /// </param>
        /// <param name="groups"></param>
        /// <param name="interval">
        /// Timedelta input.
        /// </param>
        /// <param name="stride">
        /// Timedelta input.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public MonitorRequest(
            global::System.Collections.Generic.IList<global::LangSmith.MonitorGroupSpec> groups,
            string? timezone,
            global::LangSmith.TimedeltaInput? interval,
            global::LangSmith.TimedeltaInput? stride)
        {
            this.Groups = groups ?? throw new global::System.ArgumentNullException(nameof(groups));
            this.Timezone = timezone;
            this.Interval = interval;
            this.Stride = stride;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MonitorRequest" /> class.
        /// </summary>
        public MonitorRequest()
        {
        }
    }
}