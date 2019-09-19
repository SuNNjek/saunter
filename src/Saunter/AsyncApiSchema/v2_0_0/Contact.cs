using Newtonsoft.Json;

namespace Saunter.AsyncApiSchema.v2_0_0 {
    public class Contact
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }
    }
}