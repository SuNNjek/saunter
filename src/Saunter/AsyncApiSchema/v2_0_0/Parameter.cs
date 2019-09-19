using Newtonsoft.Json;

namespace Saunter.AsyncApiSchema.v2_0_0 {
    public class Parameter 
    {
        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("schema")]
        public Schema Schema { get; set; }

        [JsonProperty("location")]
        public string Location { get; set; }
    }
}