
#nullable enable

namespace Loudly
{
    /// <summary>
    /// Energy level of the generated song.
    /// </summary>
    public enum GenerateAiSongRequestEnergy
    {
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
        /// <summary>
        /// 
        /// </summary>
        Original,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateAiSongRequestEnergyExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateAiSongRequestEnergy value)
        {
            return value switch
            {
                GenerateAiSongRequestEnergy.High => "high",
                GenerateAiSongRequestEnergy.Low => "low",
                GenerateAiSongRequestEnergy.Original => "original",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateAiSongRequestEnergy? ToEnum(string value)
        {
            return value switch
            {
                "high" => GenerateAiSongRequestEnergy.High,
                "low" => GenerateAiSongRequestEnergy.Low,
                "original" => GenerateAiSongRequestEnergy.Original,
                _ => null,
            };
        }
    }
}