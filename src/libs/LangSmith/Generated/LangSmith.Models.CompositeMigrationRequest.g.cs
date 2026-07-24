
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// A batch of feedback_formulas ids to migrate to the v2 model.<br/>
    /// All ids are processed in the tenant of the calling service-key token; ids for<br/>
    /// other tenants (or already migrated / nonexistent) are reported as skipped,<br/>
    /// never migrated. Both session-scoped and dataset-scoped formulas are migrated.
    /// </summary>
    public sealed partial class CompositeMigrationRequest
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("formula_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::System.Guid> FormulaIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeMigrationRequest" /> class.
        /// </summary>
        /// <param name="formulaIds"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompositeMigrationRequest(
            global::System.Collections.Generic.IList<global::System.Guid> formulaIds)
        {
            this.FormulaIds = formulaIds ?? throw new global::System.ArgumentNullException(nameof(formulaIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompositeMigrationRequest" /> class.
        /// </summary>
        public CompositeMigrationRequest()
        {
        }

    }
}