using Newtonsoft.Json.Converters;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace khpiScheduleApi.Enums
{
    [JsonConverter(typeof(StringEnumConverter))]
    [DataContract]
    public enum EducationForm
    {
        [EnumMember(Value = "1")]
        Очная = 1,
        [EnumMember(Value = "2")]
        Заочная = 2,
        [EnumMember(Value = "3")]
        Очно_заочная = 3,
    }
}
