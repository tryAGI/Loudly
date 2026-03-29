
#nullable enable

namespace Loudly
{
    /// <summary>
    /// The root note of the musical key.
    /// </summary>
    public enum GenerateAiSongRequestKeyRoot
    {
        /// <summary>
        /// 
        /// </summary>
        A,
        /// <summary>
        /// 
        /// </summary>
        A_Bb,
        /// <summary>
        /// 
        /// </summary>
        B,
        /// <summary>
        /// 
        /// </summary>
        C,
        /// <summary>
        /// 
        /// </summary>
        C_Db,
        /// <summary>
        /// 
        /// </summary>
        D,
        /// <summary>
        /// 
        /// </summary>
        D_Eb,
        /// <summary>
        /// 
        /// </summary>
        E,
        /// <summary>
        /// 
        /// </summary>
        F,
        /// <summary>
        /// 
        /// </summary>
        F_Gb,
        /// <summary>
        /// 
        /// </summary>
        G,
        /// <summary>
        /// 
        /// </summary>
        G_Ab,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GenerateAiSongRequestKeyRootExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GenerateAiSongRequestKeyRoot value)
        {
            return value switch
            {
                GenerateAiSongRequestKeyRoot.A => "A",
                GenerateAiSongRequestKeyRoot.A_Bb => "A#/Bb",
                GenerateAiSongRequestKeyRoot.B => "B",
                GenerateAiSongRequestKeyRoot.C => "C",
                GenerateAiSongRequestKeyRoot.C_Db => "C#/Db",
                GenerateAiSongRequestKeyRoot.D => "D",
                GenerateAiSongRequestKeyRoot.D_Eb => "D#/Eb",
                GenerateAiSongRequestKeyRoot.E => "E",
                GenerateAiSongRequestKeyRoot.F => "F",
                GenerateAiSongRequestKeyRoot.F_Gb => "F#/Gb",
                GenerateAiSongRequestKeyRoot.G => "G",
                GenerateAiSongRequestKeyRoot.G_Ab => "G#/Ab",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GenerateAiSongRequestKeyRoot? ToEnum(string value)
        {
            return value switch
            {
                "A" => GenerateAiSongRequestKeyRoot.A,
                "A#/Bb" => GenerateAiSongRequestKeyRoot.A_Bb,
                "B" => GenerateAiSongRequestKeyRoot.B,
                "C" => GenerateAiSongRequestKeyRoot.C,
                "C#/Db" => GenerateAiSongRequestKeyRoot.C_Db,
                "D" => GenerateAiSongRequestKeyRoot.D,
                "D#/Eb" => GenerateAiSongRequestKeyRoot.D_Eb,
                "E" => GenerateAiSongRequestKeyRoot.E,
                "F" => GenerateAiSongRequestKeyRoot.F,
                "F#/Gb" => GenerateAiSongRequestKeyRoot.F_Gb,
                "G" => GenerateAiSongRequestKeyRoot.G,
                "G#/Ab" => GenerateAiSongRequestKeyRoot.G_Ab,
                _ => null,
            };
        }
    }
}