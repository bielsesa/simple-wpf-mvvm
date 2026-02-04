using System;
using System.Text.Json;
using System.Text.Json.Serialization;

using SimpleMvvm.Cat;

namespace SimpleMvvm.Data
{
    public class CatColorJsonConverter : JsonConverter<CatColor>
    {
        public override CatColor Read(ref Utf8JsonReader reader, Type typeToConvert, JsonSerializerOptions options)
        {
            if (reader.TokenType != JsonTokenType.String)
            {
                throw new JsonException($"Unable to convert {reader.GetString()} to CatColor");
            }

            var colorString = reader.GetString();

            // Handle custom color string mappings if needed
            switch (colorString?.ToLowerInvariant())
            {
                case "grey":
                case "gray":
                    return CatColor.Gray;
                case "orange":
                    return CatColor.Orange;
                case "black":
                    return CatColor.Black;
                case "white":
                    return CatColor.White;
                default:
                    return CatColor.Unknown;
            }
        }

        public override void Write(Utf8JsonWriter writer, CatColor value, JsonSerializerOptions options)
        {
            writer.WriteStringValue(value.ToString());
        }
    }
}