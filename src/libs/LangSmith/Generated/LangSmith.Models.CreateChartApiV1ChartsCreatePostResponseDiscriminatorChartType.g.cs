
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType
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
    public static class CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType value)
        {
            return value switch
            {
                CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType.Bar => "bar",
                CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType.Kpi => "kpi",
                CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType.Line => "line",
                CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType.Pie => "pie",
                CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType.Table => "table",
                CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType.Text => "text",
                CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType.TopK => "top-k",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType? ToEnum(string value)
        {
            return value switch
            {
                "bar" => CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType.Bar,
                "kpi" => CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType.Kpi,
                "line" => CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType.Line,
                "pie" => CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType.Pie,
                "table" => CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType.Table,
                "text" => CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType.Text,
                "top-k" => CreateChartApiV1ChartsCreatePostResponseDiscriminatorChartType.TopK,
                _ => null,
            };
        }
    }
}