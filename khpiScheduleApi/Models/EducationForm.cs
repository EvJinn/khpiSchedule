using Newtonsoft.Json;

namespace khpiScheduleApi.Models
{
    [Serializable]
    //[JsonObject(Title = "education_form")]
    public class EducationForm
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
