
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SqlqueryColumn
    {
        /// <summary>
        /// DataType is how the column's values are encoded in JSON: uuid, string,<br/>
        /// integer, float, boolean, timestamp and date (RFC 3339 strings), binary<br/>
        /// (base64 strings), list, object or null. Float values JSON cannot<br/>
        /// represent are the strings "NaN", "Infinity" and "-Infinity".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SqlqueryColumnDataTypeJsonConverter))]
        public global::LangSmith.SqlqueryColumnDataType? DataType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlqueryColumn" /> class.
        /// </summary>
        /// <param name="dataType">
        /// DataType is how the column's values are encoded in JSON: uuid, string,<br/>
        /// integer, float, boolean, timestamp and date (RFC 3339 strings), binary<br/>
        /// (base64 strings), list, object or null. Float values JSON cannot<br/>
        /// represent are the strings "NaN", "Infinity" and "-Infinity".
        /// </param>
        /// <param name="name"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SqlqueryColumn(
            global::LangSmith.SqlqueryColumnDataType? dataType,
            string? name)
        {
            this.DataType = dataType;
            this.Name = name;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlqueryColumn" /> class.
        /// </summary>
        public SqlqueryColumn()
        {
        }

    }
}