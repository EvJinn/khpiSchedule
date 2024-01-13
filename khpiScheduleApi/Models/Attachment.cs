using Newtonsoft.Json;

namespace khpiScheduleApi.Models
{
    [Serializable]
    public class Attachment
    {
        /// <summary>
        /// ID
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Файл
        /// </summary>
        [JsonProperty("file")]
        public string File { get; set; }

        /// <summary>
        /// Дата загрузки
        /// </summary>
        [JsonProperty("upload_date")]
        public string UploadDate { get; set; }
    }
}
