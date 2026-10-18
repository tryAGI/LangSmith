
#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class SandboxesBrowserAttachment
    {
        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("act_url")]
        public string? ActUrl { get; set; }

        /// <summary>
        /// APICDPURL is the same Chrome DevTools endpoint through the LangSmith API,<br/>
        /// for clients outside any sandbox. It takes any API credential: headers as<br/>
        /// for any API call (X-Api-Key, or Authorization: Bearer with an OAuth<br/>
        /// access token, plus X-Tenant-Id where needed), or, for clients that take<br/>
        /// only a URL, api_key, token and tenant_id query parameters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_cdp_url")]
        public string? ApiCdpUrl { get; set; }

        /// <summary>
        /// CDPURL is the Chrome DevTools endpoint the attached sandbox connects to,<br/>
        /// for example with Playwright's connect_over_cdp. It works only from inside<br/>
        /// that sandbox.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("cdp_url")]
        public string? CdpUrl { get; set; }

        /// <summary>
        /// Clients are the sandboxes currently connected to this window, with "api"<br/>
        /// for each client connected through api_cdp_url. An unrestricted window's<br/>
        /// connections are not listed.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("clients")]
        public global::System.Collections.Generic.IList<string>? Clients { get; set; }

        /// <summary>
        /// Controller is "agent" while the attached sandbox drives the window and<br/>
        /// "user" while a person has taken it over.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("controller")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::LangSmith.JsonConverters.SandboxesBrowserAttachmentControllerJsonConverter))]
        public global::LangSmith.SandboxesBrowserAttachmentController? Controller { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public string? CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("height")]
        public int? Height { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        public string? Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("links_expire_at")]
        public string? LinksExpireAt { get; set; }

        /// <summary>
        /// LocalhostAlias is the sandbox's localhost as the browser sees it: open<br/>
        /// http://&lt;localhost_alias&gt;:&lt;port&gt; in a window to reach a server listening<br/>
        /// on that port in the sandbox, whether bound to localhost or to all<br/>
        /// interfaces (any port but 80 and 443). While this is the only sandbox<br/>
        /// sharing its localhost, http://localhost:&lt;port&gt; works too. Pages on other<br/>
        /// sites can navigate to a plain-HTTP server there but cannot fetch from it.<br/>
        /// Set only for windows attached with share_localhost.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("localhost_alias")]
        public string? LocalhostAlias { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// Reason is why the agent asked a person to take over, when it did.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        public string? Reason { get; set; }

        /// <summary>
        /// Sandbox is the attached sandbox; empty for a window a person opened.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sandbox")]
        public string? Sandbox { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("tabs")]
        public global::System.Collections.Generic.IList<global::LangSmith.SandboxesBrowserTab>? Tabs { get; set; }

        /// <summary>
        /// Unrestricted windows give their sandbox the whole browser over CDP, with<br/>
        /// nothing filtered: every window and tab, every site's cookies, and<br/>
        /// commands that close or crash the browser. Taking over such a window does<br/>
        /// not pause its sandbox, and the LSBrowserControl domain is not available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("unrestricted")]
        public bool? Unrestricted { get; set; }

        /// <summary>
        /// ViewURL and ActURL open the window on the sandbox service domain with no<br/>
        /// LangSmith login, for an agent to send to a person: ViewURL to watch it,<br/>
        /// ActURL also to use it while its controller is "user". Anyone holding a<br/>
        /// link can open the window until LinksExpireAt. Each response mints new<br/>
        /// ones; they are returned only to those who may use the browser.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("view_url")]
        public string? ViewUrl { get; set; }

        /// <summary>
        /// Width and Height are the window's page size in CSS pixels, when it was<br/>
        /// given one; a window without one keeps Chrome's default of 1280x800.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("width")]
        public int? Width { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesBrowserAttachment" /> class.
        /// </summary>
        /// <param name="actUrl"></param>
        /// <param name="apiCdpUrl">
        /// APICDPURL is the same Chrome DevTools endpoint through the LangSmith API,<br/>
        /// for clients outside any sandbox. It takes any API credential: headers as<br/>
        /// for any API call (X-Api-Key, or Authorization: Bearer with an OAuth<br/>
        /// access token, plus X-Tenant-Id where needed), or, for clients that take<br/>
        /// only a URL, api_key, token and tenant_id query parameters.
        /// </param>
        /// <param name="cdpUrl">
        /// CDPURL is the Chrome DevTools endpoint the attached sandbox connects to,<br/>
        /// for example with Playwright's connect_over_cdp. It works only from inside<br/>
        /// that sandbox.
        /// </param>
        /// <param name="clients">
        /// Clients are the sandboxes currently connected to this window, with "api"<br/>
        /// for each client connected through api_cdp_url. An unrestricted window's<br/>
        /// connections are not listed.
        /// </param>
        /// <param name="controller">
        /// Controller is "agent" while the attached sandbox drives the window and<br/>
        /// "user" while a person has taken it over.
        /// </param>
        /// <param name="createdAt"></param>
        /// <param name="height"></param>
        /// <param name="id"></param>
        /// <param name="linksExpireAt"></param>
        /// <param name="localhostAlias">
        /// LocalhostAlias is the sandbox's localhost as the browser sees it: open<br/>
        /// http://&lt;localhost_alias&gt;:&lt;port&gt; in a window to reach a server listening<br/>
        /// on that port in the sandbox, whether bound to localhost or to all<br/>
        /// interfaces (any port but 80 and 443). While this is the only sandbox<br/>
        /// sharing its localhost, http://localhost:&lt;port&gt; works too. Pages on other<br/>
        /// sites can navigate to a plain-HTTP server there but cannot fetch from it.<br/>
        /// Set only for windows attached with share_localhost.
        /// </param>
        /// <param name="name"></param>
        /// <param name="reason">
        /// Reason is why the agent asked a person to take over, when it did.
        /// </param>
        /// <param name="sandbox">
        /// Sandbox is the attached sandbox; empty for a window a person opened.
        /// </param>
        /// <param name="tabs"></param>
        /// <param name="unrestricted">
        /// Unrestricted windows give their sandbox the whole browser over CDP, with<br/>
        /// nothing filtered: every window and tab, every site's cookies, and<br/>
        /// commands that close or crash the browser. Taking over such a window does<br/>
        /// not pause its sandbox, and the LSBrowserControl domain is not available.
        /// </param>
        /// <param name="viewUrl">
        /// ViewURL and ActURL open the window on the sandbox service domain with no<br/>
        /// LangSmith login, for an agent to send to a person: ViewURL to watch it,<br/>
        /// ActURL also to use it while its controller is "user". Anyone holding a<br/>
        /// link can open the window until LinksExpireAt. Each response mints new<br/>
        /// ones; they are returned only to those who may use the browser.
        /// </param>
        /// <param name="width">
        /// Width and Height are the window's page size in CSS pixels, when it was<br/>
        /// given one; a window without one keeps Chrome's default of 1280x800.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SandboxesBrowserAttachment(
            string? actUrl,
            string? apiCdpUrl,
            string? cdpUrl,
            global::System.Collections.Generic.IList<string>? clients,
            global::LangSmith.SandboxesBrowserAttachmentController? controller,
            string? createdAt,
            int? height,
            string? id,
            string? linksExpireAt,
            string? localhostAlias,
            string? name,
            string? reason,
            string? sandbox,
            global::System.Collections.Generic.IList<global::LangSmith.SandboxesBrowserTab>? tabs,
            bool? unrestricted,
            string? viewUrl,
            int? width)
        {
            this.ActUrl = actUrl;
            this.ApiCdpUrl = apiCdpUrl;
            this.CdpUrl = cdpUrl;
            this.Clients = clients;
            this.Controller = controller;
            this.CreatedAt = createdAt;
            this.Height = height;
            this.Id = id;
            this.LinksExpireAt = linksExpireAt;
            this.LocalhostAlias = localhostAlias;
            this.Name = name;
            this.Reason = reason;
            this.Sandbox = sandbox;
            this.Tabs = tabs;
            this.Unrestricted = unrestricted;
            this.ViewUrl = viewUrl;
            this.Width = width;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SandboxesBrowserAttachment" /> class.
        /// </summary>
        public SandboxesBrowserAttachment()
        {
        }

    }
}