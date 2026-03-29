
#nullable enable

namespace Loudly
{
    /// <summary>
    /// The quality of the musical key.
    /// </summary>
    public enum GenerateAiSongRequestKeyQuality
    {
        /// <summary>
        /// 
        /// </summary>
        Major,
        /// <summary>
        /// 
        /// </summary>
        Minor,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateAiSongRequestKeyQualityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateAiSongRequestKeyQuality value)
        {
            return value switch
            {
                GenerateAiSongRequestKeyQuality.Major => "major",
                GenerateAiSongRequestKeyQuality.Minor => "minor",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateAiSongRequestKeyQuality? ToEnum(string value)
        {
            return value switch
            {
                "major" => GenerateAiSongRequestKeyQuality.Major,
                "minor" => GenerateAiSongRequestKeyQuality.Minor,
                _ => null,
            };
        }
    }
}