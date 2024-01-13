using khpiScheduleApi.Enums;
using Newtonsoft.Json;

namespace khpiScheduleApi.Models
{
    [Serializable]
    public class Speciality
    {
        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Код
        /// </summary>
        [JsonProperty("code")]
        public string? Code { get; set; }

        /// <summary>
        /// Название
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("faculty")]
        public Faculty Faculty { get; set; }

        [JsonProperty("profile")]
        public Profile Profile { get; set; }

        /// <summary>
        /// Форма обучения
        /// </summary>
        [JsonProperty("education_form")]
        public EducationForm EducationForm { get; set; }
    }
}
