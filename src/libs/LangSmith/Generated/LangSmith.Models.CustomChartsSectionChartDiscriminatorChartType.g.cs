
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum CustomChartsSectionChartDiscriminatorChartType
    {
        /// <summary>
        ///
        /// </summary>
        Bar,
        /// <summary>
        ///
        /// </summary>
        Kpi,
        /// <summary>
        ///
        /// </summary>
        Line,
        /// <summary>
        ///
        /// </summary>
        Pie,
        /// <summary>
        ///
        /// </summary>
        Table,
        /// <summary>
        ///
        /// </summary>
        Text,
        /// <summary>
        ///
        /// </summary>
        TopK,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomChartsSectionChartDiscriminatorChartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomChartsSectionChartDiscriminatorChartType value)
        {
            return value switch
            {
                CustomChartsSectionChartDiscriminatorChartType.Bar => "bar",
                CustomChartsSectionChartDiscriminatorChartType.Kpi => "kpi",
                CustomChartsSectionChartDiscriminatorChartType.Line => "line",
                CustomChartsSectionChartDiscriminatorChartType.Pie => "pie",
                CustomChartsSectionChartDiscriminatorChartType.Table => "table",
                CustomChartsSectionChartDiscriminatorChartType.Text => "text",
                CustomChartsSectionChartDiscriminatorChartType.TopK => "top-k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomChartsSectionChartDiscriminatorChartType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => CustomChartsSectionChartDiscriminatorChartType.Bar,
                "kpi" => CustomChartsSectionChartDiscriminatorChartType.Kpi,
                "line" => CustomChartsSectionChartDiscriminatorChartType.Line,
                "pie" => CustomChartsSectionChartDiscriminatorChartType.Pie,
                "table" => CustomChartsSectionChartDiscriminatorChartType.Table,
                "text" => CustomChartsSectionChartDiscriminatorChartType.Text,
                "top-k" => CustomChartsSectionChartDiscriminatorChartType.TopK,
                _ => null,
            };
        }
    }
}