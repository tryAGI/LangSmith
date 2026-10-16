
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Sort direction for sort_by. Unset start dates sort last.<br/>
    /// Default Value: desc
    /// </summary>
    public enum ReadModelPriceMapApiV1ModelPriceMapGetSortOrder
    {
        /// <summary>
        ///
        /// </summary>
        Asc,
        /// <summary>
        ///
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReadModelPriceMapApiV1ModelPriceMapGetSortOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReadModelPriceMapApiV1ModelPriceMapGetSortOrder value)
        {
            return value switch
            {
                ReadModelPriceMapApiV1ModelPriceMapGetSortOrder.Asc => "asc",
                ReadModelPriceMapApiV1ModelPriceMapGetSortOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReadModelPriceMapApiV1ModelPriceMapGetSortOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ReadModelPriceMapApiV1ModelPriceMapGetSortOrder.Asc,
                "desc" => ReadModelPriceMapApiV1ModelPriceMapGetSortOrder.Desc,
                _ => null,
            };
        }
    }
}