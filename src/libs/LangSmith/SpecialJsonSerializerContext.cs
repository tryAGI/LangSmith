using System.Text.Json.Serialization;
using System.Text.Json.Serialization.Metadata;

namespace LangSmith;

/// <inheritdoc />
public sealed class SpecialJsonSerializerContext : JsonSerializerContext
{
    /// <inheritdoc />
    protected override JsonSerializerOptions GeneratedSerializerOptions { get; }
        
    /// <inheritdoc />
    public SpecialJsonSerializerContext(JsonSerializerOptions options) : base(null)
    {
        GeneratedSerializerOptions = options;
    }
    
    /// <summary>
    /// 
    /// </summary>
    /// <param name="secondSerializerContext"></param>
    public SpecialJsonSerializerContext(JsonSerializerContext secondSerializerContext) : base(null)
    {
        secondSerializerContext = secondSerializerContext ?? throw new ArgumentNullException(nameof(secondSerializerContext));
        
        var options = new JsonSerializerOptions
        {
            TypeInfoResolver = JsonTypeInfoResolver.Combine(
                SourceGenerationContext.Default,
                secondSerializerContext),
            DefaultIgnoreCondition = SourceGenerationContext.Default.Options.DefaultIgnoreCondition,
        };
        foreach (var converter in SourceGenerationContext.Default.Options.Converters)
        {
            options.Converters.Add(converter);
        }
        foreach (var converter in secondSerializerContext.Options.Converters)
        {
            options.Converters.Add(converter);
        }
        
        GeneratedSerializerOptions = options;
    }

    /// <inheritdoc />
    public override JsonTypeInfo? GetTypeInfo(Type type)
    {
        GeneratedSerializerOptions.TryGetTypeInfo(type, out var typeInfo);
        return typeInfo;
    }
}