
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType
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
    public static class CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType value)
        {
            return value switch
            {
                CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType.Bar => "bar",
                CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType.Kpi => "kpi",
                CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType.Line => "line",
                CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType.Pie => "pie",
                CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType.Table => "table",
                CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType.Text => "text",
                CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType.TopK => "top-k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType.Bar,
                "kpi" => CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType.Kpi,
                "line" => CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType.Line,
                "pie" => CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType.Pie,
                "table" => CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType.Table,
                "text" => CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType.Text,
                "top-k" => CreateChartApiV1ChartsCreatePostRequestDiscriminatorChartType.TopK,
                _ => null,
            };
        }
    }
}