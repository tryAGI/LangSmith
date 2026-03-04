#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    /// 
    /// </summary>
    public readonly partial struct FeedbackSource2 : global::System.IEquatable<FeedbackSource2>
    {
        /// <summary>
        /// 
        /// </summary>
        public global::LangSmith.FeedbackCreateSchemaFeedbackSourceDiscriminatorType? Type { get; }

        /// <summary>
        /// Feedback from the LangChainPlus App.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.AppFeedbackSource? App { get; init; }
#else
        public global::LangSmith.AppFeedbackSource? App { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(App))]
#endif
        public bool IsApp => App != null;

        /// <summary>
        /// API feedback source.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.APIFeedbackSource? Api { get; init; }
#else
        public global::LangSmith.APIFeedbackSource? Api { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Api))]
#endif
        public bool IsApi => Api != null;

        /// <summary>
        /// Model feedback source.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.ModelFeedbackSource? Model { get; init; }
#else
        public global::LangSmith.ModelFeedbackSource? Model { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Model))]
#endif
        public bool IsModel => Model != null;

        /// <summary>
        /// Auto eval feedback source.
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.AutoEvalFeedbackSource? AutoEval { get; init; }
#else
        public global::LangSmith.AutoEvalFeedbackSource? AutoEval { get; }
#endif

        /// <summary>
        /// 
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(AutoEval))]
#endif
        public bool IsAutoEval => AutoEval != null;
        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FeedbackSource2(global::LangSmith.AppFeedbackSource value) => new FeedbackSource2((global::LangSmith.AppFeedbackSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LangSmith.AppFeedbackSource?(FeedbackSource2 @this) => @this.App;

        /// <summary>
        /// 
        /// </summary>
        public FeedbackSource2(global::LangSmith.AppFeedbackSource? value)
        {
            App = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FeedbackSource2(global::LangSmith.APIFeedbackSource value) => new FeedbackSource2((global::LangSmith.APIFeedbackSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LangSmith.APIFeedbackSource?(FeedbackSource2 @this) => @this.Api;

        /// <summary>
        /// 
        /// </summary>
        public FeedbackSource2(global::LangSmith.APIFeedbackSource? value)
        {
            Api = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FeedbackSource2(global::LangSmith.ModelFeedbackSource value) => new FeedbackSource2((global::LangSmith.ModelFeedbackSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LangSmith.ModelFeedbackSource?(FeedbackSource2 @this) => @this.Model;

        /// <summary>
        /// 
        /// </summary>
        public FeedbackSource2(global::LangSmith.ModelFeedbackSource? value)
        {
            Model = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator FeedbackSource2(global::LangSmith.AutoEvalFeedbackSource value) => new FeedbackSource2((global::LangSmith.AutoEvalFeedbackSource?)value);

        /// <summary>
        /// 
        /// </summary>
        public static implicit operator global::LangSmith.AutoEvalFeedbackSource?(FeedbackSource2 @this) => @this.AutoEval;

        /// <summary>
        /// 
        /// </summary>
        public FeedbackSource2(global::LangSmith.AutoEvalFeedbackSource? value)
        {
            AutoEval = value;
        }

        /// <summary>
        /// 
        /// </summary>
        public FeedbackSource2(
            global::LangSmith.FeedbackCreateSchemaFeedbackSourceDiscriminatorType? type,
            global::LangSmith.AppFeedbackSource? app,
            global::LangSmith.APIFeedbackSource? api,
            global::LangSmith.ModelFeedbackSource? model,
            global::LangSmith.AutoEvalFeedbackSource? autoEval
            )
        {
            Type = type;

            App = app;
            Api = api;
            Model = model;
            AutoEval = autoEval;
        }

        /// <summary>
        /// 
        /// </summary>
        public object? Object =>
            AutoEval as object ??
            Model as object ??
            Api as object ??
            App as object 
            ;

        /// <summary>
        /// 
        /// </summary>
        public override string? ToString() =>
            App?.ToString() ??
            Api?.ToString() ??
            Model?.ToString() ??
            AutoEval?.ToString() 
            ;

        /// <summary>
        /// 
        /// </summary>
        public bool Validate()
        {
            return IsApp && !IsApi && !IsModel && !IsAutoEval || !IsApp && IsApi && !IsModel && !IsAutoEval || !IsApp && !IsApi && IsModel && !IsAutoEval || !IsApp && !IsApi && !IsModel && IsAutoEval;
        }

        /// <summary>
        /// 
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LangSmith.AppFeedbackSource?, TResult>? app = null,
            global::System.Func<global::LangSmith.APIFeedbackSource?, TResult>? api = null,
            global::System.Func<global::LangSmith.ModelFeedbackSource?, TResult>? model = null,
            global::System.Func<global::LangSmith.AutoEvalFeedbackSource?, TResult>? autoEval = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApp && app != null)
            {
                return app(App!);
            }
            else if (IsApi && api != null)
            {
                return api(Api!);
            }
            else if (IsModel && model != null)
            {
                return model(Model!);
            }
            else if (IsAutoEval && autoEval != null)
            {
                return autoEval(AutoEval!);
            }

            return default(TResult);
        }

        /// <summary>
        /// 
        /// </summary>
        public void Match(
            global::System.Action<global::LangSmith.AppFeedbackSource?>? app = null,
            global::System.Action<global::LangSmith.APIFeedbackSource?>? api = null,
            global::System.Action<global::LangSmith.ModelFeedbackSource?>? model = null,
            global::System.Action<global::LangSmith.AutoEvalFeedbackSource?>? autoEval = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (IsApp)
            {
                app?.Invoke(App!);
            }
            else if (IsApi)
            {
                api?.Invoke(Api!);
            }
            else if (IsModel)
            {
                model?.Invoke(Model!);
            }
            else if (IsAutoEval)
            {
                autoEval?.Invoke(AutoEval!);
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                App,
                typeof(global::LangSmith.AppFeedbackSource),
                Api,
                typeof(global::LangSmith.APIFeedbackSource),
                Model,
                typeof(global::LangSmith.ModelFeedbackSource),
                AutoEval,
                typeof(global::LangSmith.AutoEvalFeedbackSource),
            };
            const int offset = unchecked((int)2166136261);
            const int prime = 16777619;
            static int HashCodeAggregator(int hashCode, object? value) => value == null
                ? (hashCode ^ 0) * prime
                : (hashCode ^ value.GetHashCode()) * prime;

            return global::System.Linq.Enumerable.Aggregate(fields, offset, HashCodeAggregator);
        }

        /// <summary>
        /// 
        /// </summary>
        public bool Equals(FeedbackSource2 other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.AppFeedbackSource?>.Default.Equals(App, other.App) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.APIFeedbackSource?>.Default.Equals(Api, other.Api) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.ModelFeedbackSource?>.Default.Equals(Model, other.Model) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.AutoEvalFeedbackSource?>.Default.Equals(AutoEval, other.AutoEval) 
                ;
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator ==(FeedbackSource2 obj1, FeedbackSource2 obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<FeedbackSource2>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public static bool operator !=(FeedbackSource2 obj1, FeedbackSource2 obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        /// 
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is FeedbackSource2 o && Equals(o);
        }
    }
}
