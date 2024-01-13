using Newtonsoft.Json;

namespace khpiScheduleApi.Models
{
    [Serializable]
    public class Faculty
    {
        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
