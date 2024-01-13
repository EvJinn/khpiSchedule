using Newtonsoft.Json;

namespace khpiScheduleApi.Models
{
    [Serializable]
    public class Schedule
    {
        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Дата начала действия расписания
        /// </summary>
        [JsonProperty("date_from")]
        public string DateFrom { get; set; }

        /// <summary>
        /// Дата окончания действия расписания
        /// </summary>
        [JsonProperty("date_to")]
        public string DateTo { get; set; }

        /// <summary>
        /// Тип расписания
        /// </summary>
        [JsonProperty("type")]
        public Type? Type { get; set; }

        /// <summary>
        /// Примечание
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("groups")]
        public List<AcademicGroup> Groups { get; set; } = new List<AcademicGroup>();

        [JsonProperty("attachments")]
        public List<Attachment> Attachments { get; set; } = new List<Attachment>();

        /// <summary>
        /// Дата, которая будет в подписи
        /// </summary>
        [JsonProperty("sign_date")]
        public string? SignDate { get; set; }
    }
}
