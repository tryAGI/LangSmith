
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExamplesMetadataOperation
    {
        /// <summary>
        /// The top-level metadata key to change, at most 255 bytes. Use dataset_split with<br/>
        /// ARRAY_ADD or ARRAY_REMOVE to change which splits the examples belong to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("key")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Key { get; set; }

        /// <summary>
        /// The change to make: SET replaces the value at key; ARRAY_ADD adds values to the<br/>
        /// list at key; ARRAY_REMOVE removes values from it. For array operations, a missing<br/>
        /// or non-list value starts as an empty list, except for dataset_split, where it<br/>
        /// starts as the base split.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("operation")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.ExamplesMetadataOperationOperationJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::LangSmith.ExamplesMetadataOperationOperation Operation { get; set; }

        /// <summary>
        /// The new value for a SET operation; any JSON value, at most 64 KB. Ignored by<br/>
        /// array operations.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        public object? Value { get; set; }

        /// <summary>
        /// The values to add or remove for an array operation; at most 1000 values of at<br/>
        /// most 255 bytes each. Ignored by SET.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("values")]
        public global::System.Collections.Generic.IList<string>? Values { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExamplesMetadataOperation" /> class.
        /// </summary>
        /// <param name="key">
        /// The top-level metadata key to change, at most 255 bytes. Use dataset_split with<br/>
        /// ARRAY_ADD or ARRAY_REMOVE to change which splits the examples belong to.
        /// </param>
        /// <param name="operation">
        /// The change to make: SET replaces the value at key; ARRAY_ADD adds values to the<br/>
        /// list at key; ARRAY_REMOVE removes values from it. For array operations, a missing<br/>
        /// or non-list value starts as an empty list, except for dataset_split, where it<br/>
        /// starts as the base split.
        /// </param>
        /// <param name="value">
        /// The new value for a SET operation; any JSON value, at most 64 KB. Ignored by<br/>
        /// array operations.
        /// </param>
        /// <param name="values">
        /// The values to add or remove for an array operation; at most 1000 values of at<br/>
        /// most 255 bytes each. Ignored by SET.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExamplesMetadataOperation(
            string key,
            global::LangSmith.ExamplesMetadataOperationOperation operation,
            object? value,
            global::System.Collections.Generic.IList<string>? values)
        {
            this.Key = key ?? throw new global::System.ArgumentNullException(nameof(key));
            this.Operation = operation;
            this.Value = value;
            this.Values = values;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExamplesMetadataOperation" /> class.
        /// </summary>
        public ExamplesMetadataOperation()
        {
        }

    }
}