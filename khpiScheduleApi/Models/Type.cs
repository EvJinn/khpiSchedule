using Newtonsoft.Json;

namespace khpiScheduleApi.Models
{
    [Serializable]
    public class Type
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
