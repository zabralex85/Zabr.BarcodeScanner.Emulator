using System.Collections.Generic;

namespace Walli.SweedPos.Utils.Scanner
{
    public class PresetTree
    {
        public List<Preset> Presets;

        public PresetTree(string directory)
        {
            Presets = new List<Preset>();
            InitPresets(directory);
        }

        private void InitPresets(string directory)
        {
            var dir = new System.IO.DirectoryInfo("presets");
            foreach (var item in dir.EnumerateDirectories())
            {
                this.Presets.Add(new Preset(item.Name, item.FullName));
            }
        }
    }
}
