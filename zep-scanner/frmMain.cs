using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Windows.Forms;

namespace Walli.SweedPos.Utils.Scanner
{
    public partial class frmMain : Form
    {
        private PresetTree presetTree;
        private Preset CurrentPreset => ((Preset) cmbPresets.SelectedItem);
        private PresetData CurrentPresetData => ((PresetData)cmbPresetFilter.SelectedItem);

        public frmMain()
        {
            presetTree = new PresetTree("presets");
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cmbPresets.DataSource = presetTree.Presets;
            cmbPresets.DisplayMember = "Name";
            cmbPresets.ValueMember = "Path";

            cmbPresetFilter.DataSource = FilterData();
            cmbPresetFilter.DisplayMember = "Name";
            cmbPresetFilter.ValueMember = "Value";

            cmbPresets.SelectedIndexChanged += ChangePreset;
            cmbPresetFilter.SelectedIndexChanged += ChangePresetFilter;

            txtScanCode.Text = CurrentPresetData.Value;
        }

        List<PresetData> FilterData()
        {
            List<PresetData> queryFilter = presetTree.Presets.First(p => p.Name == CurrentPreset.Name).PresetData;

            if (CurrentPreset.Name == "ean13")
            {
                queryFilter = queryFilter.Where(l => l.Value.Length == 13).OrderBy(l => l.Name).ToList();
            }
            else
            {
                queryFilter = queryFilter.OrderBy(l => l.Name).ToList();
            }

            return queryFilter;
        }

        private void ChangePresetFilter(object sender, EventArgs e)
        {
            txtScanCode.Text = CurrentPresetData.Value.Replace("\n", Environment.NewLine);
            pctBarCode.Image = GenerateImage(txtScanCode.Text.Replace(Environment.NewLine, "\n"));
        }

        private Image GenerateImage(string data)
        {
            // https://barcode.tec-it.com/barcode.ashx?data=978020137962&code=EAN13&multiplebarcodes=false&translate-esc=false&unit=Fit&dpi=96&imagetype=Gif&rotation=0&color=%23000000&bgcolor=%23ffffff&qunit=Mm&quiet=0&eclevel=L&download=true
            var url = CurrentPreset.PresetConfig.WebService.Replace("{DATA}","");

            WebClient wc = new WebClient();
            byte[] dataBytes = wc.DownloadData(url);

            var ms = new MemoryStream();
            ms.Write(dataBytes, 0, dataBytes.Length);

            return Image.FromStream(ms);
        }

        private void ChangePreset(object sender, EventArgs e)
        {
            cmbPresetFilter.DataSource = FilterData();
        }
    }
}
