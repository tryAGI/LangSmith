#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace LangSmith
{
    /// <summary>
    ///
    /// </summary>
    public readonly partial struct ChartsItem : global::System.IEquatable<ChartsItem>
    {
        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomChartsSectionChartDiscriminatorChartType? ChartType { get; }

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.SingleCustomChartResponseSerialized? Bar { get; init; }
#else
        public global::LangSmith.SingleCustomChartResponseSerialized? Bar { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Bar))]
#endif
        public bool IsBar => Bar != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickBar(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.SingleCustomChartResponseSerialized? value)
        {
            value = Bar;
            return IsBar;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.SingleCustomChartResponseSerialized PickBar() => Bar is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Bar' but the value was {ToString()}.");

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        public global::LangSmith.CustomTextBlock? Text { get; init; }
#else
        public global::LangSmith.CustomTextBlock? Text { get; }
#endif

        /// <summary>
        ///
        /// </summary>
#if NET6_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.MemberNotNullWhen(true, nameof(Text))]
#endif
        public bool IsText => Text != null;

        /// <summary>
        ///
        /// </summary>
        public bool TryPickText(
#if NET6_0_OR_GREATER
            [global::System.Diagnostics.CodeAnalysis.NotNullWhen(true)]
#endif
            out global::LangSmith.CustomTextBlock? value)
        {
            value = Text;
            return IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public global::LangSmith.CustomTextBlock PickText() => Text is { } value
            ? value
            : throw new global::System.InvalidOperationException($"Expected union variant 'Text' but the value was {ToString()}.");
        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChartsItem(global::LangSmith.SingleCustomChartResponseSerialized value) => new ChartsItem((global::LangSmith.SingleCustomChartResponseSerialized?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.SingleCustomChartResponseSerialized?(ChartsItem @this) => @this.Bar;

        /// <summary>
        ///
        /// </summary>
        public ChartsItem(global::LangSmith.SingleCustomChartResponseSerialized? value)
        {
            Bar = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChartsItem FromBar(global::LangSmith.SingleCustomChartResponseSerialized? value) => new ChartsItem(value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator ChartsItem(global::LangSmith.CustomTextBlock value) => new ChartsItem((global::LangSmith.CustomTextBlock?)value);

        /// <summary>
        ///
        /// </summary>
        public static implicit operator global::LangSmith.CustomTextBlock?(ChartsItem @this) => @this.Text;

        /// <summary>
        ///
        /// </summary>
        public ChartsItem(global::LangSmith.CustomTextBlock? value)
        {
            Text = value;
        }

        /// <summary>
        ///
        /// </summary>
        public static ChartsItem FromText(global::LangSmith.CustomTextBlock? value) => new ChartsItem(value);

        /// <summary>
        ///
        /// </summary>
        public ChartsItem(
            global::LangSmith.CustomChartsSectionChartDiscriminatorChartType? chartType,
            global::LangSmith.SingleCustomChartResponseSerialized? bar,
            global::LangSmith.CustomTextBlock? text
            )
        {
            ChartType = chartType;

            Bar = bar;
            Text = text;
        }

        /// <summary>
        ///
        /// </summary>
        public object? Object =>
            Text as object ??
            Bar as object
            ;

        /// <summary>
        ///
        /// </summary>
        public override string? ToString() =>
            Bar?.ToString() ??
            Text?.ToString()
            ;

        /// <summary>
        ///
        /// </summary>
        public bool Validate()
        {
            return IsBar && !IsText || !IsBar && IsText;
        }

        /// <summary>
        ///
        /// </summary>
        public TResult? Match<TResult>(
            global::System.Func<global::LangSmith.SingleCustomChartResponseSerialized, TResult>? bar = null,
            global::System.Func<global::LangSmith.CustomTextBlock, TResult>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Bar is { } __value0 && bar != null)
            {
                return bar(__value0);
            }
            else if (Text is { } __value1 && text != null)
            {
                return text(__value1);
            }

            return default(TResult);
        }

        /// <summary>
        ///
        /// </summary>
        public void Match(
            global::System.Action<global::LangSmith.SingleCustomChartResponseSerialized>? bar = null,

            global::System.Action<global::LangSmith.CustomTextBlock>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Bar is { } __value0)
            {
                bar?.Invoke(__value0);
            }
            else if (Text is { } __value1)
            {
                text?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public void Switch(
            global::System.Action<global::LangSmith.SingleCustomChartResponseSerialized>? bar = null,
            global::System.Action<global::LangSmith.CustomTextBlock>? text = null,
            bool validate = true)
        {
            if (validate)
            {
                Validate();
            }

            if (Bar is { } __value0)
            {
                bar?.Invoke(__value0);
            }
            else if (Text is { } __value1)
            {
                text?.Invoke(__value1);
            }
        }

        /// <summary>
        ///
        /// </summary>
        public override int GetHashCode()
        {
            var fields = new object?[]
            {
                Bar,
                typeof(global::LangSmith.SingleCustomChartResponseSerialized),
                Text,
                typeof(global::LangSmith.CustomTextBlock),
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
        public bool Equals(ChartsItem other)
        {
            return
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.SingleCustomChartResponseSerialized?>.Default.Equals(Bar, other.Bar) &&
                global::System.Collections.Generic.EqualityComparer<global::LangSmith.CustomTextBlock?>.Default.Equals(Text, other.Text)
                ;
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator ==(ChartsItem obj1, ChartsItem obj2)
        {
            return global::System.Collections.Generic.EqualityComparer<ChartsItem>.Default.Equals(obj1, obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public static bool operator !=(ChartsItem obj1, ChartsItem obj2)
        {
            return !(obj1 == obj2);
        }

        /// <summary>
        ///
        /// </summary>
        public override bool Equals(object? obj)
        {
            return obj is ChartsItem o && Equals(o);
        }
    }
}
