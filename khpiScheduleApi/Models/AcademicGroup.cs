using Newtonsoft.Json;

namespace khpiScheduleApi.Models
{
    [Serializable]
    public class AcademicGroup
    {
        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Курс
        /// </summary>
        [JsonProperty("course")]
        public int Course { get; set; }

        [JsonProperty("speciality")]
        public Speciality Speciality { get; set; }
    }
}
