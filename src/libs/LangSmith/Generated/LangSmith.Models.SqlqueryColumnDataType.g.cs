
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// DataType is how the column's values are encoded in JSON: uuid, string,<br/>
    /// integer, float, boolean, timestamp and date (RFC 3339 strings), binary<br/>
    /// (base64 strings), list, object or null. Float values JSON cannot<br/>
    /// represent are the strings "NaN", "Infinity" and "-Infinity".
    /// </summary>
    public enum SqlqueryColumnDataType
    {
        /// <summary>
        ///
        /// </summary>
        Binary,
        /// <summary>
        ///
        /// </summary>
        Boolean,
        /// <summary>
        ///
        /// </summary>
        Date,
        /// <summary>
        ///
        /// </summary>
        Float,
        /// <summary>
        ///
        /// </summary>
        Integer,
        /// <summary>
        ///
        /// </summary>
        List,
        /// <summary>
        ///
        /// </summary>
        Null,
        /// <summary>
        ///
        /// </summary>
        Object,
        /// <summary>
        /// uuid, string,
        /// </summary>
        String,
        /// <summary>
        ///
        /// </summary>
        Timestamp,
        /// <summary>
        /// uuid, string,
        /// </summary>
        Uuid,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SqlqueryColumnDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SqlqueryColumnDataType value)
        {
            return value switch
            {
                SqlqueryColumnDataType.Binary => "binary",
                SqlqueryColumnDataType.Boolean => "boolean",
                SqlqueryColumnDataType.Date => "date",
                SqlqueryColumnDataType.Float => "float",
                SqlqueryColumnDataType.Integer => "integer",
                SqlqueryColumnDataType.List => "list",
                SqlqueryColumnDataType.Null => "null",
                SqlqueryColumnDataType.Object => "object",
                SqlqueryColumnDataType.String => "string",
                SqlqueryColumnDataType.Timestamp => "timestamp",
                SqlqueryColumnDataType.Uuid => "uuid",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SqlqueryColumnDataType? ToEnum(string value)
        {
            return value switch
            {
                "binary" => SqlqueryColumnDataType.Binary,
                "boolean" => SqlqueryColumnDataType.Boolean,
                "date" => SqlqueryColumnDataType.Date,
                "float" => SqlqueryColumnDataType.Float,
                "integer" => SqlqueryColumnDataType.Integer,
                "list" => SqlqueryColumnDataType.List,
                "null" => SqlqueryColumnDataType.Null,
                "object" => SqlqueryColumnDataType.Object,
                "string" => SqlqueryColumnDataType.String,
                "timestamp" => SqlqueryColumnDataType.Timestamp,
                "uuid" => SqlqueryColumnDataType.Uuid,
                _ => null,
            };
        }
    }
}