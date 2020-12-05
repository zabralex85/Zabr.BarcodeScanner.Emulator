using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;
using Newtonsoft.Json;

namespace Zabr.BarcodeScanner.Emulator.BLL.Presets
{
    public class Preset
    {
        public string Name { get; set; }
        public PresetConfig PresetConfig { get; set; }
        public List<PresetData> PresetData { get; set; }

        public Preset(string name, string path)
        {
            PresetData = new List<PresetData>();
            Name = name;

            InitPreset(path);
        }

        private void InitPreset(string path)
        {
            string config = File.ReadAllText(Path.Combine(path, "config.json"));
            PresetConfig = JsonConvert.DeserializeObject<PresetConfig>(config);

            var presetFile = Path.Combine(path, PresetConfig.DataFile);
            if(!File.Exists(presetFile))
                return;

            using (TextReader fileReader = File.OpenText(presetFile))
            {
                var configuration = new CsvConfiguration(CultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true, 
                    Delimiter = ";"
                };

                using (var csv = new CsvReader(fileReader, configuration))
                {
                    var records = csv.GetRecords<Record>();
                    foreach (var item in records)
                    {
                        this.PresetData.Add(new PresetData(item));
                    }
                }
            }
        }
    }
}
