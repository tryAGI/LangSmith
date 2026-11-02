
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Which scope owns the entry. Server-assigned from the route that created it.<br/>
    /// Default Value: BUILTIN
    /// </summary>
    public enum ModelPriceMapSchemaScope
    {
        /// <summary>
        ///
        /// </summary>
        Builtin,
        /// <summary>
        ///
        /// </summary>
        Organization,
        /// <summary>
        ///
        /// </summary>
        Workspace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelPriceMapSchemaScopeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelPriceMapSchemaScope value)
        {
            return value switch
            {
                ModelPriceMapSchemaScope.Builtin => "BUILTIN",
                ModelPriceMapSchemaScope.Organization => "ORGANIZATION",
                ModelPriceMapSchemaScope.Workspace => "WORKSPACE",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelPriceMapSchemaScope? ToEnum(string value)
        {
            return value switch
            {
                "BUILTIN" => ModelPriceMapSchemaScope.Builtin,
                "ORGANIZATION" => ModelPriceMapSchemaScope.Organization,
                "WORKSPACE" => ModelPriceMapSchemaScope.Workspace,
                _ => null,
            };
        }
    }
}