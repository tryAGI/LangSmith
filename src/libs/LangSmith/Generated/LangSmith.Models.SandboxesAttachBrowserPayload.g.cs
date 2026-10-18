
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesAttachBrowserPayload
    {
        /// <summary>
        /// Controller is who drives a window opened with no sandbox: "user"<br/>
        /// (default) for a person in the live view, or "agent" for a client that<br/>
        /// drives it over api_cdp_url. A sandbox's window always starts with<br/>
        /// "agent".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controller")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SandboxesAttachBrowserPayloadControllerJsonConverter))]
        public global::LangSmith.SandboxesAttachBrowserPayloadController? Controller { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        /// Name labels the window in the live view; defaults to the sandbox name.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Sandbox is the name or ID of the sandbox to attach. Leave it out to open a<br/>
        /// window for the person calling, to use from the live view.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox")]
        public string? Sandbox { get; set; }

        /// <summary>
        /// ShareLocalhost shares the sandbox's localhost with the browser, so pages<br/>
        /// can open the servers it runs, such as dev servers, at the response's<br/>
        /// localhost_alias. It reaches every port of the sandbox, including servers<br/>
        /// bound only to its localhost. Off by default. Not available for a window<br/>
        /// opened with no sandbox, or when the sandbox is itself a browser.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("share_localhost")]
        public bool? ShareLocalhost { get; set; }

        /// <summary>
        /// Unrestricted gives the window's CDP clients (its sandbox, or anyone using<br/>
        /// its api_cdp_url) the whole browser, with nothing filtered: every window<br/>
        /// and tab including people's, every site's cookies, and commands that close<br/>
        /// or crash the browser. Taking over its window does not pause them.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unrestricted")]
        public bool? Unrestricted { get; set; }

        /// <summary>
        /// Width and Height size the window's page in CSS pixels; set both or<br/>
        /// neither. Without them the window opens at 1280x800.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesAttachBrowserPayload" /> class.
        /// </summary>
        /// <param name="controller">
        /// Controller is who drives a window opened with no sandbox: "user"<br/>
        /// (default) for a person in the live view, or "agent" for a client that<br/>
        /// drives it over api_cdp_url. A sandbox's window always starts with<br/>
        /// "agent".
        /// </param>
        /// <param name="height"></param>
        /// <param name="name">
        /// Name labels the window in the live view; defaults to the sandbox name.
        /// </param>
        /// <param name="sandbox">
        /// Sandbox is the name or ID of the sandbox to attach. Leave it out to open a<br/>
        /// window for the person calling, to use from the live view.
        /// </param>
        /// <param name="shareLocalhost">
        /// ShareLocalhost shares the sandbox's localhost with the browser, so pages<br/>
        /// can open the servers it runs, such as dev servers, at the response's<br/>
        /// localhost_alias. It reaches every port of the sandbox, including servers<br/>
        /// bound only to its localhost. Off by default. Not available for a window<br/>
        /// opened with no sandbox, or when the sandbox is itself a browser.
        /// </param>
        /// <param name="unrestricted">
        /// Unrestricted gives the window's CDP clients (its sandbox, or anyone using<br/>
        /// its api_cdp_url) the whole browser, with nothing filtered: every window<br/>
        /// and tab including people's, every site's cookies, and commands that close<br/>
        /// or crash the browser. Taking over its window does not pause them.
        /// </param>
        /// <param name="width">
        /// Width and Height size the window's page in CSS pixels; set both or<br/>
        /// neither. Without them the window opens at 1280x800.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesAttachBrowserPayload(
            global::LangSmith.SandboxesAttachBrowserPayloadController? controller,
            int? height,
            string? name,
            string? sandbox,
            bool? shareLocalhost,
            bool? unrestricted,
            int? width)
        {
            this.Controller = controller;
            this.Height = height;
            this.Name = name;
            this.Sandbox = sandbox;
            this.ShareLocalhost = shareLocalhost;
            this.Unrestricted = unrestricted;
            this.Width = width;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesAttachBrowserPayload" /> class.
        /// </summary>
        public SandboxesAttachBrowserPayload()
        {
        }

    }
}