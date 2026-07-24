
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Per-id outcome of a composite migration batch.
    /// </summary>
    public sealed partial class CompositeMigrationResult
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("migrated")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> Migrated { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skipped")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> Skipped { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("failed")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> Failed { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeMigrationResult" /> class.
        /// </summary>
        /// <param name="migrated"></param>
        /// <param name="skipped"></param>
        /// <param name="failed"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompositeMigrationResult(
            global::System.Collections.Generic.IList<global::System.Guid> migrated,
            global::System.Collections.Generic.IList<global::System.Guid> skipped,
            global::System.Collections.Generic.IList<global::System.Guid> failed)
        {
            this.Migrated = migrated ?? throw new global::System.ArgumentNullException(nameof(migrated));
            this.Skipped = skipped ?? throw new global::System.ArgumentNullException(nameof(skipped));
            this.Failed = failed ?? throw new global::System.ArgumentNullException(nameof(failed));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeMigrationResult" /> class.
        /// </summary>
        public CompositeMigrationResult()
        {
        }

    }
}