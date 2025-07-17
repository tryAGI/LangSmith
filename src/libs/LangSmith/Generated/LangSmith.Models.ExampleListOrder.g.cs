
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum ExampleListOrder
    {
        /// <summary>
        /// 
        /// </summary>
        Recent,
        /// <summary>
        /// 
        /// </summary>
        Random,
        /// <summary>
        /// 
        /// </summary>
        RecentlyCreated,
        /// <summary>
        /// 
        /// </summary>
        Id,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ExampleListOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ExampleListOrder value)
        {
            return value switch
            {
                ExampleListOrder.Recent => "recent",
                ExampleListOrder.Random => "random",
                ExampleListOrder.RecentlyCreated => "recently_created",
                ExampleListOrder.Id => "id",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ExampleListOrder? ToEnum(string value)
        {
            return value switch
            {
                "recent" => ExampleListOrder.Recent,
                "random" => ExampleListOrder.Random,
                "recently_created" => ExampleListOrder.RecentlyCreated,
                "id" => ExampleListOrder.Id,
                _ => null,
            };
        }
    }
}