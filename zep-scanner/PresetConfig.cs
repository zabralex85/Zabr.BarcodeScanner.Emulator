using Newtonsoft.Json;
using System.Collections.Generic;

namespace Walli.SweedPos.Utils.Scanner
{
    public class PresetConfig
    {
        [JsonProperty("webService")]
        public string WebService { get; set; }

        [JsonProperty("dataFile")]
        public string DataFile { get; set; }

        [JsonProperty("fields")]
        public List<string> Fields { get; set; }
    }
}
