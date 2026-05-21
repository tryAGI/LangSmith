#nullable enable

namespace LangSmith
{
    public partial interface IFilesClient
    {
        /// <summary>
        /// Upload a file<br/>
        /// Upload a file to the sandbox filesystem
        /// </summary>
        /// <param name="path"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.HandlersUploadResponse> UploadAFileAsync(
            string path,

            global::LangSmith.CreateUploadRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file<br/>
        /// Upload a file to the sandbox filesystem
        /// </summary>
        /// <param name="path"></param>
        /// <param name="request"></param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.HandlersUploadResponse>> UploadAFileAsResponseAsync(
            string path,

            global::LangSmith.CreateUploadRequest request,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file<br/>
        /// Upload a file to the sandbox filesystem
        /// </summary>
        /// <param name="path"></param>
        /// <param name="file">
        /// File to upload
        /// </param>
        /// <param name="filename">
        /// File to upload
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::System.InvalidOperationException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.HandlersUploadResponse> UploadAFileAsync(
            string path,
            byte[] file,
            string filename,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);

        /// <summary>
        /// Upload a file<br/>
        /// Upload a file to the sandbox filesystem
        /// </summary>
        /// <param name="path"></param>
        /// <param name="file">
        /// File to upload
        /// </param>
        /// <param name="filename">
        /// File to upload
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.HandlersUploadResponse> UploadAFileAsync(
            string path,
            global::System.IO.Stream file,
            string filename,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
        /// <summary>
        /// Upload a file<br/>
        /// Upload a file to the sandbox filesystem
        /// </summary>
        /// <param name="path"></param>
        /// <param name="file">
        /// File to upload
        /// </param>
        /// <param name="filename">
        /// File to upload
        /// </param>
        /// <param name="requestOptions">Per-request overrides such as headers, query parameters, timeout, retries, and response buffering.</param>
        /// <param name="cancellationToken">The token to cancel the operation with</param>
        /// <exception cref="global::LangSmith.ApiException"></exception>
        global::System.Threading.Tasks.Task<global::LangSmith.AutoSDKHttpResponse<global::LangSmith.HandlersUploadResponse>> UploadAFileAsResponseAsync(
            string path,
            global::System.IO.Stream file,
            string filename,
            global::LangSmith.AutoSDKRequestOptions? requestOptions = default,
            global::System.Threading.CancellationToken cancellationToken = default);
    }
}