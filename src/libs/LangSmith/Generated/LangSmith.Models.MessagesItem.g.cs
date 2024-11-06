using System.Linq;
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct MessagesItem : global::System.IEquatable<MessagesItem>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.PlaygroundPromptCanvasPayloadMessageDiscriminatorType? Type { get; }

        /// <summary>
        /// Message from an AI.<br/>
        /// AIMessage is returned from a chat model as a response to a prompt.<br/>
        /// This message represents the output of the model and consists of both<br/>
        /// the raw output as returned by the model together standardized fields<br/>
        /// (e.g., tool calls, usage metadata) added by the LangChain framework.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.AIMessage? Ai { get; init; }
#else
        public global::LangSmith.AIMessage? Ai { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Ai))]
#endif
        public bool IsAi => Ai != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::LangSmith.AIMessage value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LangSmith.AIMessage?(MessagesItem @this) => @this.Ai;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::LangSmith.AIMessage? value)
        {
            Ai = value;
        }

        /// <summary>
        /// Message from a human.<br/>
        /// HumanMessages are messages that are passed in from a human to the model.<br/>
        /// Example:<br/>
        ///     .. code-block:: python<br/>
        ///         from langchain_core.messages import HumanMessage, SystemMessage<br/>
        ///         messages = [<br/>
        ///             SystemMessage(<br/>
        ///                 content="You are a helpful assistant! Your name is Bob."<br/>
        ///             ),<br/>
        ///             HumanMessage(<br/>
        ///                 content="What is your name?"<br/>
        ///             )<br/>
        ///         ]<br/>
        ///         # Instantiate a chat model and invoke it with the messages<br/>
        ///         model = ...<br/>
        ///         print(model.invoke(messages))
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.HumanMessage? Human { get; init; }
#else
        public global::LangSmith.HumanMessage? Human { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Human))]
#endif
        public bool IsHuman => Human != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::LangSmith.HumanMessage value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LangSmith.HumanMessage?(MessagesItem @this) => @this.Human;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::LangSmith.HumanMessage? value)
        {
            Human = value;
        }

        /// <summary>
        /// Message that can be assigned an arbitrary speaker (i.e. role).
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.ChatMessage? Chat { get; init; }
#else
        public global::LangSmith.ChatMessage? Chat { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Chat))]
#endif
        public bool IsChat => Chat != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::LangSmith.ChatMessage value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LangSmith.ChatMessage?(MessagesItem @this) => @this.Chat;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::LangSmith.ChatMessage? value)
        {
            Chat = value;
        }

        /// <summary>
        /// Message for priming AI behavior.<br/>
        /// The system message is usually passed in as the first of a sequence<br/>
        /// of input messages.<br/>
        /// Example:<br/>
        ///     .. code-block:: python<br/>
        ///         from langchain_core.messages import HumanMessage, SystemMessage<br/>
        ///         messages = [<br/>
        ///             SystemMessage(<br/>
        ///                 content="You are a helpful assistant! Your name is Bob."<br/>
        ///             ),<br/>
        ///             HumanMessage(<br/>
        ///                 content="What is your name?"<br/>
        ///             )<br/>
        ///         ]<br/>
        ///         # Define a chat model and invoke it with the messages<br/>
        ///         print(model.invoke(messages))
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.SystemMessage? System { get; init; }
#else
        public global::LangSmith.SystemMessage? System { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(System))]
#endif
        public bool IsSystem => System != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::LangSmith.SystemMessage value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LangSmith.SystemMessage?(MessagesItem @this) => @this.System;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::LangSmith.SystemMessage? value)
        {
            System = value;
        }

        /// <summary>
        /// Message for passing the result of executing a tool back to a model.<br/>
        /// FunctionMessage are an older version of the ToolMessage schema, and<br/>
        /// do not contain the tool_call_id field.<br/>
        /// The tool_call_id field is used to associate the tool call request with the<br/>
        /// tool call response. This is useful in situations where a chat model is able<br/>
        /// to request multiple tool calls in parallel.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.FunctionMessage? Function { get; init; }
#else
        public global::LangSmith.FunctionMessage? Function { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Function))]
#endif
        public bool IsFunction => Function != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::LangSmith.FunctionMessage value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LangSmith.FunctionMessage?(MessagesItem @this) => @this.Function;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::LangSmith.FunctionMessage? value)
        {
            Function = value;
        }

        /// <summary>
        /// Message for passing the result of executing a tool back to a model.<br/>
        /// ToolMessages contain the result of a tool invocation. Typically, the result<br/>
        /// is encoded inside the `content` field.<br/>
        /// Example: A ToolMessage representing a result of 42 from a tool call with id<br/>
        ///     .. code-block:: python<br/>
        ///         from langchain_core.messages import ToolMessage<br/>
        ///         ToolMessage(content='42', tool_call_id='call_Jja7J89XsjrOLA5r!MEOW!SL')<br/>
        /// Example: A ToolMessage where only part of the tool output is sent to the model<br/>
        ///     and the full output is passed in to artifact.<br/>
        ///     .. versionadded:: 0.2.17<br/>
        ///     .. code-block:: python<br/>
        ///         from langchain_core.messages import ToolMessage<br/>
        ///         tool_output = {<br/>
        ///             "stdout": "From the graph we can see that the correlation between x and y is ...",<br/>
        ///             "stderr": None,<br/>
        ///             "artifacts": {"type": "image", "base64_data": "/9j/4gIcSU..."},<br/>
        ///         }<br/>
        ///         ToolMessage(<br/>
        ///             content=tool_output["stdout"],<br/>
        ///             artifact=tool_output,<br/>
        ///             tool_call_id='call_Jja7J89XsjrOLA5r!MEOW!SL',<br/>
        ///         )<br/>
        /// The tool_call_id field is used to associate the tool call request with the<br/>
        /// tool call response. This is useful in situations where a chat model is able<br/>
        /// to request multiple tool calls in parallel.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.ToolMessage? Tool { get; init; }
#else
        public global::LangSmith.ToolMessage? Tool { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Tool))]
#endif
        public bool IsTool => Tool != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::LangSmith.ToolMessage value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LangSmith.ToolMessage?(MessagesItem @this) => @this.Tool;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::LangSmith.ToolMessage? value)
        {
            Tool = value;
        }

        /// <summary>
        /// Message chunk from an AI.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.AIMessageChunk? AIMessageChunk { get; init; }
#else
        public global::LangSmith.AIMessageChunk? AIMessageChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AIMessageChunk))]
#endif
        public bool IsAIMessageChunk => AIMessageChunk != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::LangSmith.AIMessageChunk value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LangSmith.AIMessageChunk?(MessagesItem @this) => @this.AIMessageChunk;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::LangSmith.AIMessageChunk? value)
        {
            AIMessageChunk = value;
        }

        /// <summary>
        /// Human Message chunk.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.HumanMessageChunk? HumanMessageChunk { get; init; }
#else
        public global::LangSmith.HumanMessageChunk? HumanMessageChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(HumanMessageChunk))]
#endif
        public bool IsHumanMessageChunk => HumanMessageChunk != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::LangSmith.HumanMessageChunk value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LangSmith.HumanMessageChunk?(MessagesItem @this) => @this.HumanMessageChunk;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::LangSmith.HumanMessageChunk? value)
        {
            HumanMessageChunk = value;
        }

        /// <summary>
        /// Chat Message chunk.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.ChatMessageChunk? ChatMessageChunk { get; init; }
#else
        public global::LangSmith.ChatMessageChunk? ChatMessageChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ChatMessageChunk))]
#endif
        public bool IsChatMessageChunk => ChatMessageChunk != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::LangSmith.ChatMessageChunk value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LangSmith.ChatMessageChunk?(MessagesItem @this) => @this.ChatMessageChunk;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::LangSmith.ChatMessageChunk? value)
        {
            ChatMessageChunk = value;
        }

        /// <summary>
        /// System Message chunk.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.SystemMessageChunk? SystemMessageChunk { get; init; }
#else
        public global::LangSmith.SystemMessageChunk? SystemMessageChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(SystemMessageChunk))]
#endif
        public bool IsSystemMessageChunk => SystemMessageChunk != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::LangSmith.SystemMessageChunk value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LangSmith.SystemMessageChunk?(MessagesItem @this) => @this.SystemMessageChunk;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::LangSmith.SystemMessageChunk? value)
        {
            SystemMessageChunk = value;
        }

        /// <summary>
        /// Function Message chunk.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.FunctionMessageChunk? FunctionMessageChunk { get; init; }
#else
        public global::LangSmith.FunctionMessageChunk? FunctionMessageChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(FunctionMessageChunk))]
#endif
        public bool IsFunctionMessageChunk => FunctionMessageChunk != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::LangSmith.FunctionMessageChunk value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LangSmith.FunctionMessageChunk?(MessagesItem @this) => @this.FunctionMessageChunk;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::LangSmith.FunctionMessageChunk? value)
        {
            FunctionMessageChunk = value;
        }

        /// <summary>
        /// Tool Message chunk.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.ToolMessageChunk? ToolMessageChunk { get; init; }
#else
        public global::LangSmith.ToolMessageChunk? ToolMessageChunk { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(ToolMessageChunk))]
#endif
        public bool IsToolMessageChunk => ToolMessageChunk != null;

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator MessagesItem(global::LangSmith.ToolMessageChunk value) => new MessagesItem(value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LangSmith.ToolMessageChunk?(MessagesItem @this) => @this.ToolMessageChunk;

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(global::LangSmith.ToolMessageChunk? value)
        {
            ToolMessageChunk = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public MessagesItem(
            global::LangSmith.PlaygroundPromptCanvasPayloadMessageDiscriminatorType? type,
            global::LangSmith.AIMessage? ai,
            global::LangSmith.HumanMessage? human,
            global::LangSmith.ChatMessage? chat,
            global::LangSmith.SystemMessage? system,
            global::LangSmith.FunctionMessage? function,
            global::LangSmith.ToolMessage? tool,
            global::LangSmith.AIMessageChunk? aIMessageChunk,
            global::LangSmith.HumanMessageChunk? humanMessageChunk,
            global::LangSmith.ChatMessageChunk? chatMessageChunk,
            global::LangSmith.SystemMessageChunk? systemMessageChunk,
            global::LangSmith.FunctionMessageChunk? functionMessageChunk,
            global::LangSmith.ToolMessageChunk? toolMessageChunk
            )
        {
            Type = type;

            Ai = ai;
            Human = human;
            Chat = chat;
            System = system;
            Function = function;
            Tool = tool;
            AIMessageChunk = aIMessageChunk;
            HumanMessageChunk = humanMessageChunk;
            ChatMessageChunk = chatMessageChunk;
            SystemMessageChunk = systemMessageChunk;
            FunctionMessageChunk = functionMessageChunk;
            ToolMessageChunk = toolMessageChunk;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            ToolMessageChunk as object ??
            FunctionMessageChunk as object ??
            SystemMessageChunk as object ??
            ChatMessageChunk as object ??
            HumanMessageChunk as object ??
            AIMessageChunk as object ??
            Tool as object ??
            Function as object ??
            System as object ??
            Chat as object ??
            Human as object ??
            Ai as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsAi && !IsHuman && !IsChat && !IsSystem && !IsFunction && !IsTool && !IsAIMessageChunk && !IsHumanMessageChunk && !IsChatMessageChunk && !IsSystemMessageChunk && !IsFunctionMessageChunk && !IsToolMessageChunk || !IsAi && IsHuman && !IsChat && !IsSystem && !IsFunction && !IsTool && !IsAIMessageChunk && !IsHumanMessageChunk && !IsChatMessageChunk && !IsSystemMessageChunk && !IsFunctionMessageChunk && !IsToolMessageChunk || !IsAi && !IsHuman && IsChat && !IsSystem && !IsFunction && !IsTool && !IsAIMessageChunk && !IsHumanMessageChunk && !IsChatMessageChunk && !IsSystemMessageChunk && !IsFunctionMessageChunk && !IsToolMessageChunk || !IsAi && !IsHuman && !IsChat && IsSystem && !IsFunction && !IsTool && !IsAIMessageChunk && !IsHumanMessageChunk && !IsChatMessageChunk && !IsSystemMessageChunk && !IsFunctionMessageChunk && !IsToolMessageChunk || !IsAi && !IsHuman && !IsChat && !IsSystem && IsFunction && !IsTool && !IsAIMessageChunk && !IsHumanMessageChunk && !IsChatMessageChunk && !IsSystemMessageChunk && !IsFunctionMessageChunk && !IsToolMessageChunk || !IsAi && !IsHuman && !IsChat && !IsSystem && !IsFunction && IsTool && !IsAIMessageChunk && !IsHumanMessageChunk && !IsChatMessageChunk && !IsSystemMessageChunk && !IsFunctionMessageChunk && !IsToolMessageChunk || !IsAi && !IsHuman && !IsChat && !IsSystem && !IsFunction && !IsTool && IsAIMessageChunk && !IsHumanMessageChunk && !IsChatMessageChunk && !IsSystemMessageChunk && !IsFunctionMessageChunk && !IsToolMessageChunk || !IsAi && !IsHuman && !IsChat && !IsSystem && !IsFunction && !IsTool && !IsAIMessageChunk && IsHumanMessageChunk && !IsChatMessageChunk && !IsSystemMessageChunk && !IsFunctionMessageChunk && !IsToolMessageChunk || !IsAi && !IsHuman && !IsChat && !IsSystem && !IsFunction && !IsTool && !IsAIMessageChunk && !IsHumanMessageChunk && IsChatMessageChunk && !IsSystemMessageChunk && !IsFunctionMessageChunk && !IsToolMessageChunk || !IsAi && !IsHuman && !IsChat && !IsSystem && !IsFunction && !IsTool && !IsAIMessageChunk && !IsHumanMessageChunk && !IsChatMessageChunk && IsSystemMessageChunk && !IsFunctionMessageChunk && !IsToolMessageChunk || !IsAi && !IsHuman && !IsChat && !IsSystem && !IsFunction && !IsTool && !IsAIMessageChunk && !IsHumanMessageChunk && !IsChatMessageChunk && !IsSystemMessageChunk && IsFunctionMessageChunk && !IsToolMessageChunk || !IsAi && !IsHuman && !IsChat && !IsSystem && !IsFunction && !IsTool && !IsAIMessageChunk && !IsHumanMessageChunk && !IsChatMessageChunk && !IsSystemMessageChunk && !IsFunctionMessageChunk && IsToolMessageChunk;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LangSmith.AIMessage?, TResult>? ai = null,
            global::System.Func<global::LangSmith.HumanMessage?, TResult>? human = null,
            global::System.Func<global::LangSmith.ChatMessage?, TResult>? chat = null,
            global::System.Func<global::LangSmith.SystemMessage?, TResult>? system = null,
            global::System.Func<global::LangSmith.FunctionMessage?, TResult>? function = null,
            global::System.Func<global::LangSmith.ToolMessage?, TResult>? tool = null,
            global::System.Func<global::LangSmith.AIMessageChunk?, TResult>? aIMessageChunk = null,
            global::System.Func<global::LangSmith.HumanMessageChunk?, TResult>? humanMessageChunk = null,
            global::System.Func<global::LangSmith.ChatMessageChunk?, TResult>? chatMessageChunk = null,
            global::System.Func<global::LangSmith.SystemMessageChunk?, TResult>? systemMessageChunk = null,
            global::System.Func<global::LangSmith.FunctionMessageChunk?, TResult>? functionMessageChunk = null,
            global::System.Func<global::LangSmith.ToolMessageChunk?, TResult>? toolMessageChunk = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAi && ai != null)
            {
                return ai(Ai!);
            }
            else if (IsHuman && human != null)
            {
                return human(Human!);
            }
            else if (IsChat && chat != null)
            {
                return chat(Chat!);
            }
            else if (IsSystem && system != null)
            {
                return system(System!);
            }
            else if (IsFunction && function != null)
            {
                return function(Function!);
            }
            else if (IsTool && tool != null)
            {
                return tool(Tool!);
            }
            else if (IsAIMessageChunk && aIMessageChunk != null)
            {
                return aIMessageChunk(AIMessageChunk!);
            }
            else if (IsHumanMessageChunk && humanMessageChunk != null)
            {
                return humanMessageChunk(HumanMessageChunk!);
            }
            else if (IsChatMessageChunk && chatMessageChunk != null)
            {
                return chatMessageChunk(ChatMessageChunk!);
            }
            else if (IsSystemMessageChunk && systemMessageChunk != null)
            {
                return systemMessageChunk(SystemMessageChunk!);
            }
            else if (IsFunctionMessageChunk && functionMessageChunk != null)
            {
                return functionMessageChunk(FunctionMessageChunk!);
            }
            else if (IsToolMessageChunk && toolMessageChunk != null)
            {
                return toolMessageChunk(ToolMessageChunk!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::LangSmith.AIMessage?>? ai = null,
            global::System.Action<global::LangSmith.HumanMessage?>? human = null,
            global::System.Action<global::LangSmith.ChatMessage?>? chat = null,
            global::System.Action<global::LangSmith.SystemMessage?>? system = null,
            global::System.Action<global::LangSmith.FunctionMessage?>? function = null,
            global::System.Action<global::LangSmith.ToolMessage?>? tool = null,
            global::System.Action<global::LangSmith.AIMessageChunk?>? aIMessageChunk = null,
            global::System.Action<global::LangSmith.HumanMessageChunk?>? humanMessageChunk = null,
            global::System.Action<global::LangSmith.ChatMessageChunk?>? chatMessageChunk = null,
            global::System.Action<global::LangSmith.SystemMessageChunk?>? systemMessageChunk = null,
            global::System.Action<global::LangSmith.FunctionMessageChunk?>? functionMessageChunk = null,
            global::System.Action<global::LangSmith.ToolMessageChunk?>? toolMessageChunk = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsAi)
            {
                ai?.Invoke(Ai!);
            }
            else if (IsHuman)
            {
                human?.Invoke(Human!);
            }
            else if (IsChat)
            {
                chat?.Invoke(Chat!);
            }
            else if (IsSystem)
            {
                system?.Invoke(System!);
            }
            else if (IsFunction)
            {
                function?.Invoke(Function!);
            }
            else if (IsTool)
            {
                tool?.Invoke(Tool!);
            }
            else if (IsAIMessageChunk)
            {
                aIMessageChunk?.Invoke(AIMessageChunk!);
            }
            else if (IsHumanMessageChunk)
            {
                humanMessageChunk?.Invoke(HumanMessageChunk!);
            }
            else if (IsChatMessageChunk)
            {
                chatMessageChunk?.Invoke(ChatMessageChunk!);
            }
            else if (IsSystemMessageChunk)
            {
                systemMessageChunk?.Invoke(SystemMessageChunk!);
            }
            else if (IsFunctionMessageChunk)
            {
                functionMessageChunk?.Invoke(FunctionMessageChunk!);
            }
            else if (IsToolMessageChunk)
            {
                toolMessageChunk?.Invoke(ToolMessageChunk!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Ai,
                typeof(global::LangSmith.AIMessage),
                Human,
                typeof(global::LangSmith.HumanMessage),
                Chat,
                typeof(global::LangSmith.ChatMessage),
                System,
                typeof(global::LangSmith.SystemMessage),
                Function,
                typeof(global::LangSmith.FunctionMessage),
                Tool,
                typeof(global::LangSmith.ToolMessage),
                AIMessageChunk,
                typeof(global::LangSmith.AIMessageChunk),
                HumanMessageChunk,
                typeof(global::LangSmith.HumanMessageChunk),
                ChatMessageChunk,
                typeof(global::LangSmith.ChatMessageChunk),
                SystemMessageChunk,
                typeof(global::LangSmith.SystemMessageChunk),
                FunctionMessageChunk,
                typeof(global::LangSmith.FunctionMessageChunk),
                ToolMessageChunk,
                typeof(global::LangSmith.ToolMessageChunk),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;
            return fields.Aggregate(offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(MessagesItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.AIMessage?>.Default.Equals(Ai, other.Ai) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.HumanMessage?>.Default.Equals(Human, other.Human) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.ChatMessage?>.Default.Equals(Chat, other.Chat) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.SystemMessage?>.Default.Equals(System, other.System) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.FunctionMessage?>.Default.Equals(Function, other.Function) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.ToolMessage?>.Default.Equals(Tool, other.Tool) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.AIMessageChunk?>.Default.Equals(AIMessageChunk, other.AIMessageChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.HumanMessageChunk?>.Default.Equals(HumanMessageChunk, other.HumanMessageChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.ChatMessageChunk?>.Default.Equals(ChatMessageChunk, other.ChatMessageChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.SystemMessageChunk?>.Default.Equals(SystemMessageChunk, other.SystemMessageChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.FunctionMessageChunk?>.Default.Equals(FunctionMessageChunk, other.FunctionMessageChunk) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.ToolMessageChunk?>.Default.Equals(ToolMessageChunk, other.ToolMessageChunk) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(MessagesItem obj1, MessagesItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<MessagesItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(MessagesItem obj1, MessagesItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is MessagesItem o && Equals(o);
        }


        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public string ToJson(
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                this.GetType(),
                jsonSerializerContext);
        }

        /// <summary>
        /// Serializes the current instance to a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public string ToJson(
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Serialize(
                this,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerContext.
        /// </summary>
        public static global::LangSmith.MessagesItem? FromJson(
            string json,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize(
                json,
                typeof(global::LangSmith.MessagesItem),
                jsonSerializerContext) as global::LangSmith.MessagesItem?;
        }

        /// <summary>
        /// Deserializes a JSON string using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::LangSmith.MessagesItem? FromJson(
            string json,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.Deserialize<global::LangSmith.MessagesItem>(
                json,
                jsonSerializerOptions);
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerContext.
        /// </summary>
        public static async global::System.Threading.Tasks.ValueTask<global::LangSmith.MessagesItem?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.Serialization.JsonSerializerContext jsonSerializerContext)
        {
            return (await global::System.Text.Json.JsonSerializer.DeserializeAsync(
                jsonStream,
                typeof(global::LangSmith.MessagesItem),
                jsonSerializerContext).ConfigureAwait(false)) as global::LangSmith.MessagesItem?;
        }

        /// <summary>
        /// Deserializes a JSON stream using the provided JsonSerializerOptions.
        /// </summary>
#if NET8_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.RequiresUnreferencedCode("JSON serialization and deserialization might require types that cannot be statically analyzed. Use the overload that takes a JsonTypeInfo or JsonSerializerContext, or make sure all of the required types are preserved.")]
        [global::System.Diagnostics.CodeAnalysis.RequiresDynamicCode("JSON serialization and deserialization might require types that cannot be statically analyzed and might need runtime code generation. Use System.Text.Json source generation for native AOT applications.")]
#endif
        public static global::System.Threading.Tasks.ValueTask<global::LangSmith.MessagesItem?> FromJsonStream(
            global::System.IO.Stream jsonStream,
            global::System.Text.Json.JsonSerializerOptions? jsonSerializerOptions = null)
        {
            return global::System.Text.Json.JsonSerializer.DeserializeAsync<global::LangSmith.MessagesItem?>(
                jsonStream,
                jsonSerializerOptions);
        }

    }
}
