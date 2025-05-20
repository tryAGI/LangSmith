#nullable enable

namespace LangSmith
{
    public partial interface IAlertRulesClient
    {
        /// <summary>
        /// Test an alert action to determine if configuration is valid<br/>
        /// Tests an alert action which will fire a notification to all configured recipients if the configuration is valid.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<string> TestAnAlertActionToDetermineIfConfigurationIsValidAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}