
#nullable enable

#pragma warning disable CS0618 // Type or member is obsolete
#pragma warning disable CS3016 // Arrays as attribute arguments is not CLS-compliant

namespace Loudly
{
    /// <summary>
    /// 
    /// </summary>
    [global::System.Text.Json.Serialization.JsonSourceGenerationOptions(
        DefaultIgnoreCondition = global::System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull,
        Converters = new global::System.Type[]
        {
            typeof(global::Loudly.JsonConverters.GenerateAiSongRequestEnergyJsonConverter),

            typeof(global::Loudly.JsonConverters.GenerateAiSongRequestEnergyNullableJsonConverter),

            typeof(global::Loudly.JsonConverters.GenerateAiSongRequestKeyRootJsonConverter),

            typeof(global::Loudly.JsonConverters.GenerateAiSongRequestKeyRootNullableJsonConverter),

            typeof(global::Loudly.JsonConverters.GenerateAiSongRequestKeyQualityJsonConverter),

            typeof(global::Loudly.JsonConverters.GenerateAiSongRequestKeyQualityNullableJsonConverter),

            typeof(global::Loudly.JsonConverters.UnixTimestampJsonConverter),
        })]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loudly.JsonSerializerContextTypes))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loudly.UsageLimit))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(string))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(int))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loudly.CatalogTags))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loudly.CatalogSong))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(float))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.DateTime))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loudly.AiGenre))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loudly.AiStructure))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loudly.RandomPrompt))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loudly.GenerateAiSongRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loudly.GenerateAiSongRequestEnergy), TypeInfoPropertyName = "GenerateAiSongRequestEnergy2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loudly.GenerateAiSongRequestKeyRoot), TypeInfoPropertyName = "GenerateAiSongRequestKeyRoot2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loudly.GenerateAiSongRequestKeyQuality), TypeInfoPropertyName = "GenerateAiSongRequestKeyQuality2")]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loudly.GenerateAiSongFromPromptRequest))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loudly.AiSong))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loudly.MusicalKey))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(bool))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::Loudly.Error))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loudly.UsageLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loudly.CatalogSong>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loudly.AiGenre>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.IList<global::Loudly.AiStructure>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<string>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loudly.UsageLimit>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loudly.CatalogSong>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loudly.AiGenre>))]
    [global::System.Text.Json.Serialization.JsonSerializable(typeof(global::System.Collections.Generic.List<global::Loudly.AiStructure>))]
    public sealed partial class SourceGenerationContext : global::System.Text.Json.Serialization.JsonSerializerContext
    {
    }
}