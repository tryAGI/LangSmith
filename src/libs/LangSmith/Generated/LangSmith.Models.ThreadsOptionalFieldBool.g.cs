
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ThreadsOptionalFieldBool
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("set")]
        public bool? Set { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public bool? Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsOptionalFieldBool" /> class.
        /// </summary>
        /// <param name="set"></param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ThreadsOptionalFieldBool(
            bool? set,
            bool? value)
        {
            this.Set = set;
            this.Value = value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadsOptionalFieldBool" /> class.
        /// </summary>
        public ThreadsOptionalFieldBool()
        {
        }

    }
}