#nullable enable

namespace LangSmith
{
    public partial interface IExamplesClient
    {
        /// <summary>
        /// Validate Example<br/>
        /// Validate an example.
        /// </summary>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.ExampleValidationResult> ValidateExampleAsync(
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}