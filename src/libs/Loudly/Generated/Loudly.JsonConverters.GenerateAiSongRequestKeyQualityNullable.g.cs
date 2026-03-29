#nullable enable

namespace Loudly.JsonConverters
{
    /// <inheritdoc />
    public sealed class GenerateAiSongRequestKeyQualityNullableJsonConverter : global::System.Text.Json.Serialization.JsonConverter<global::Loudly.GenerateAiSongRequestKeyQuality?>
    {
        /// <inheritdoc />
        public override global::Loudly.GenerateAiSongRequestKeyQuality? Read(
            ref global::System.Text.Json.Utf8JsonReader reader,
            global::System.Type typeToConvert,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            switch (reader.TokenType)
            {
                case global::System.Text.Json.JsonTokenType.String:
                {
                    var stringValue = reader.GetString();
                    if (stringValue != null)
                    {
                        return global::Loudly.GenerateAiSongRequestKeyQualityExtensions.ToEnum(stringValue);
                    }
                    
                    break;
                }
                case global::System.Text.Json.JsonTokenType.Number:
                {
                    var numValue = reader.GetInt32();
                    return (global::Loudly.GenerateAiSongRequestKeyQuality)numValue;
                }
                case global::System.Text.Json.JsonTokenType.Null:
                {
                    return default(global::Loudly.GenerateAiSongRequestKeyQuality?);
                }
                default:
                    throw new global::System.ArgumentOutOfRangeException(nameof(reader));
            }

            return default;
        }

        /// <inheritdoc />
        public override void Write(
            global::System.Text.Json.Utf8JsonWriter writer,
            global::Loudly.GenerateAiSongRequestKeyQuality? value,
            global::System.Text.Json.JsonSerializerOptions options)
        {
            writer = writer ?? throw new global::System.ArgumentNullException(nameof(writer));

            if (value == null)
            {
                writer.WriteNullValue();
            }
            else
            {
                writer.WriteStringValue(global::Loudly.GenerateAiSongRequestKeyQualityExtensions.ToValueString(value.Value));
            }
        }
    }
}
