using Newtonsoft.Json;

namespace Models
{
    public class Varibles
    {
        [JsonProperty("AgentNum")]
        public int AgentNum { get; set; }

        [JsonProperty("JsonOrXML")]
        public string JsonOrXML{ get; set; }

        [JsonProperty("PageSize")]
        public int? PageSize { get; set; }

        [JsonProperty("PageNum")]
        public int? PageNum { get; set; }

        [JsonProperty("SortingColumn")]
        public string sortingColumn { get; set; }
    }
}
