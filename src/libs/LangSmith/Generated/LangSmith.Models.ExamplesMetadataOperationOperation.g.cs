
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// The change to make: SET replaces the value at key; ARRAY_ADD adds values to the<br/>
    /// list at key; ARRAY_REMOVE removes values from it. For array operations, a missing<br/>
    /// or non-list value starts as an empty list, except for dataset_split, where it<br/>
    /// starts as the base split.
    /// </summary>
    public enum ExamplesMetadataOperationOperation
    {
        /// <summary>
        /// SET replaces the value at key; ARRAY_ADD adds values to the
        /// </summary>
        ArrayAdd,
        /// <summary>
        ///
        /// </summary>
        ArrayRemove,
        /// <summary>
        /// SET replaces the value at key; ARRAY_ADD adds values to the
        /// </summary>
        Set,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExamplesMetadataOperationOperationExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExamplesMetadataOperationOperation value)
        {
            return value switch
            {
                ExamplesMetadataOperationOperation.ArrayAdd => "ARRAY_ADD",
                ExamplesMetadataOperationOperation.ArrayRemove => "ARRAY_REMOVE",
                ExamplesMetadataOperationOperation.Set => "SET",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExamplesMetadataOperationOperation? ToEnum(string value)
        {
            return value switch
            {
                "ARRAY_ADD" => ExamplesMetadataOperationOperation.ArrayAdd,
                "ARRAY_REMOVE" => ExamplesMetadataOperationOperation.ArrayRemove,
                "SET" => ExamplesMetadataOperationOperation.Set,
                _ => null,
            };
        }
    }
}