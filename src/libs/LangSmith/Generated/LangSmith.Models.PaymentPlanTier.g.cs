
#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public enum PaymentPlanTier
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
        DeveloperLegacy,
        /// <summary>
        /// 
        /// </summary>
        Enterprise,
        /// <summary>
        /// 
        /// </summary>
        EnterpriseLegacy,
        /// <summary>
        /// 
        /// </summary>
        Free,
        /// <summary>
        /// 
        /// </summary>
        NoPlan,
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
        PlusLegacy,
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
        StartupV0,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PaymentPlanTierExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PaymentPlanTier value)
        {
            return value switch
            {
                PaymentPlanTier.Developer => "developer",
                PaymentPlanTier.Developer012026 => "developer_01_2026",
                PaymentPlanTier.DeveloperLegacy => "developer_legacy",
                PaymentPlanTier.Enterprise => "enterprise",
                PaymentPlanTier.EnterpriseLegacy => "enterprise_legacy",
                PaymentPlanTier.Free => "free",
                PaymentPlanTier.NoPlan => "no_plan",
                PaymentPlanTier.Partner => "partner",
                PaymentPlanTier.Plus => "plus",
                PaymentPlanTier.Plus012026 => "plus_01_2026",
                PaymentPlanTier.PlusLegacy => "plus_legacy",
                PaymentPlanTier.Premier => "premier",
                PaymentPlanTier.Startup => "startup",
                PaymentPlanTier.StartupV0 => "startup_v0",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PaymentPlanTier? ToEnum(string value)
        {
            return value switch
            {
                "developer" => PaymentPlanTier.Developer,
                "developer_01_2026" => PaymentPlanTier.Developer012026,
                "developer_legacy" => PaymentPlanTier.DeveloperLegacy,
                "enterprise" => PaymentPlanTier.Enterprise,
                "enterprise_legacy" => PaymentPlanTier.EnterpriseLegacy,
                "free" => PaymentPlanTier.Free,
                "no_plan" => PaymentPlanTier.NoPlan,
                "partner" => PaymentPlanTier.Partner,
                "plus" => PaymentPlanTier.Plus,
                "plus_01_2026" => PaymentPlanTier.Plus012026,
                "plus_legacy" => PaymentPlanTier.PlusLegacy,
                "premier" => PaymentPlanTier.Premier,
                "startup" => PaymentPlanTier.Startup,
                "startup_v0" => PaymentPlanTier.StartupV0,
                _ => null,
            };
        }
    }
}