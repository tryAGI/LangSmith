
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// Enum for payment plans that the user can change to. Developer plans are permanent and enterprise plans will be changed manually.
    /// </summary>
    public enum ChangePaymentPlanReq
    {
        /// <summary>
        /// 
        /// </summary>
        Developer,
        /// <summary>
        /// 
        /// </summary>
        Developer012026,
        /// <summary>
        /// 
        /// </summary>
        Developer072026,
        /// <summary>
        /// 
        /// </summary>
        Disabled,
        /// <summary>
        /// 
        /// </summary>
        Free,
        /// <summary>
        /// 
        /// </summary>
        Free072026,
        /// <summary>
        /// 
        /// </summary>
        Partner,
        /// <summary>
        /// 
        /// </summary>
        Plus,
        /// <summary>
        /// 
        /// </summary>
        Plus012026,
        /// <summary>
        /// 
        /// </summary>
        Plus072026,
        /// <summary>
        /// 
        /// </summary>
        Premier,
        /// <summary>
        /// 
        /// </summary>
        Startup,
        /// <summary>
        /// 
        /// </summary>
        Startup072026,
        /// <summary>
        /// 
        /// </summary>
        StartupV0,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChangePaymentPlanReqExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChangePaymentPlanReq value)
        {
            return value switch
            {
                ChangePaymentPlanReq.Developer => "developer",
                ChangePaymentPlanReq.Developer012026 => "developer_01_2026",
                ChangePaymentPlanReq.Developer072026 => "developer_07_2026",
                ChangePaymentPlanReq.Disabled => "disabled",
                ChangePaymentPlanReq.Free => "free",
                ChangePaymentPlanReq.Free072026 => "free_07_2026",
                ChangePaymentPlanReq.Partner => "partner",
                ChangePaymentPlanReq.Plus => "plus",
                ChangePaymentPlanReq.Plus012026 => "plus_01_2026",
                ChangePaymentPlanReq.Plus072026 => "plus_07_2026",
                ChangePaymentPlanReq.Premier => "premier",
                ChangePaymentPlanReq.Startup => "startup",
                ChangePaymentPlanReq.Startup072026 => "startup_07_2026",
                ChangePaymentPlanReq.StartupV0 => "startup_v0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChangePaymentPlanReq? ToEnum(string value)
        {
            return value switch
            {
                "developer" => ChangePaymentPlanReq.Developer,
                "developer_01_2026" => ChangePaymentPlanReq.Developer012026,
                "developer_07_2026" => ChangePaymentPlanReq.Developer072026,
                "disabled" => ChangePaymentPlanReq.Disabled,
                "free" => ChangePaymentPlanReq.Free,
                "free_07_2026" => ChangePaymentPlanReq.Free072026,
                "partner" => ChangePaymentPlanReq.Partner,
                "plus" => ChangePaymentPlanReq.Plus,
                "plus_01_2026" => ChangePaymentPlanReq.Plus012026,
                "plus_07_2026" => ChangePaymentPlanReq.Plus072026,
                "premier" => ChangePaymentPlanReq.Premier,
                "startup" => ChangePaymentPlanReq.Startup,
                "startup_07_2026" => ChangePaymentPlanReq.Startup072026,
                "startup_v0" => ChangePaymentPlanReq.StartupV0,
                _ => null,
            };
        }
    }
}