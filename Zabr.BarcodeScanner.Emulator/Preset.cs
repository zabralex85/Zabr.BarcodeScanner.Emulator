using System.Collections.Generic;
using System.IO;
using CsvHelper;
using Newtonsoft.Json;

namespace ZEP.Scanner
{
    public class Preset
    {
        public string Name { get; set; }
        public string Path { get; set; }
        public PresetConfig PresetConfig { get; set; }
        public List<PresetData> PresetData { get; set; }

        public Preset(string name, string path)
        {
            PresetData = new List<PresetData>();

            Name = name;
            Path = path;

            InitPreset(path);
        }

        private void InitPreset(string path)
        {
            string config = File.ReadAllText(path + "\\config.json");
            PresetConfig = JsonConvert.DeserializeObject<PresetConfig>(config);

            using (var reader = new StreamReader(path + "\\" + PresetConfig.DataFile))
            using (var csv = new CsvReader(reader))
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
