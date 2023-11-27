using System.Text.Json.Serialization;

namespace api.net.model
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum RpgClass
    {
        Kinght = 1,
        Mage  = 2,

        Cleric = 3
    }
}