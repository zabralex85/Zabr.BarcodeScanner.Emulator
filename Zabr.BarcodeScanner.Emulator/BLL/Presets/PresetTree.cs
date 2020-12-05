using System.Collections.Generic;
using System.IO;

namespace Zabr.BarcodeScanner.Emulator.BLL.Presets
{
    public class PresetTree
    {
        public readonly List<Preset> Presets;

        public PresetTree(string directory)
        {
            Presets = new List<Preset>();
            InitPresets(directory);
        }

        private void InitPresets(string directory)
        {
            var dir = new System.IO.DirectoryInfo(Path.Combine("AppData", "Presets"));
            foreach (var item in dir.EnumerateDirectories())
            {
                this.Presets.Add(new Preset(item.Name, item.FullName));
            }
        }
    }
}
