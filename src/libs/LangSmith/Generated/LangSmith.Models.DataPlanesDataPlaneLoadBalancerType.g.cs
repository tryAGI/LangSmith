
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public enum DataPlanesDataPlaneLoadBalancerType
    {
        /// <summary>
        ///
        /// </summary>
        DataPlaneLoadBalancerTypeALB,
        /// <summary>
        ///
        /// </summary>
        DataPlaneLoadBalancerTypeNLB,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DataPlanesDataPlaneLoadBalancerTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DataPlanesDataPlaneLoadBalancerType value)
        {
            return value switch
            {
                DataPlanesDataPlaneLoadBalancerType.DataPlaneLoadBalancerTypeALB => "ALB",
                DataPlanesDataPlaneLoadBalancerType.DataPlaneLoadBalancerTypeNLB => "NLB",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DataPlanesDataPlaneLoadBalancerType? ToEnum(string value)
        {
            return value switch
            {
                "ALB" => DataPlanesDataPlaneLoadBalancerType.DataPlaneLoadBalancerTypeALB,
                "NLB" => DataPlanesDataPlaneLoadBalancerType.DataPlaneLoadBalancerTypeNLB,
                _ => null,
            };
        }
    }
}