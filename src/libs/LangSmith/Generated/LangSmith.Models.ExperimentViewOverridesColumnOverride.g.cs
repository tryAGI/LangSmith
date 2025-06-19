
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ExperimentViewOverridesColumnOverride
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_gradient")]
        public global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? ColorGradient { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("color_map")]
        public object? ColorMap { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("column")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Column { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("hide")]
        public bool? Hide { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("precision")]
        public int? Precision { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentViewOverridesColumnOverride" /> class.
        /// </summary>
        /// <param name="colorGradient"></param>
        /// <param name="colorMap"></param>
        /// <param name="column"></param>
        /// <param name="hide"></param>
        /// <param name="precision"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExperimentViewOverridesColumnOverride(
            string column,
            global::System.Collections.Generic.IList<global::System.Collections.Generic.IList<object>>? colorGradient,
            object? colorMap,
            bool? hide,
            int? precision)
        {
            this.Column = column ?? throw new global::System.ArgumentNullException(nameof(column));
            this.ColorGradient = colorGradient;
            this.ColorMap = colorMap;
            this.Hide = hide;
            this.Precision = precision;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExperimentViewOverridesColumnOverride" /> class.
        /// </summary>
        public ExperimentViewOverridesColumnOverride()
        {
        }
    }
}