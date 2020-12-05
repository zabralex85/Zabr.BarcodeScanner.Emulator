using System.Collections.Generic;
using Newtonsoft.Json;

namespace Zabr.BarcodeScanner.Emulator.BLL.Presets
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
