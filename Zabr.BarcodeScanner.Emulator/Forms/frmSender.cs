using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using WindowsInput;
using Zabr.BarcodeScanner.Emulator.BLL.Presets;

namespace Zabr.BarcodeScanner.Emulator.Forms
{
    public partial class frmSender : Form
    {
        private readonly PresetTree _presetTree;
        private Preset CurrentPreset => ((Preset)cmbPresets.SelectedItem);
        private PresetData CurrentPresetData => ((PresetData)cmbPresetFilter.SelectedItem);

        public frmSender()
        {
            _presetTree = new PresetTree("presets");
            InitializeComponent();
        }

        private List<PresetData> FilterData()
        {
            var queryFilter = _presetTree.Presets.First(p => p.Name == CurrentPreset.Name).PresetData;

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
            var url = CurrentPreset.PresetConfig.WebService.Replace("{DATA}", System.Net.WebUtility.UrlEncode(data));

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

        private void btnScan_Click(object sender, EventArgs e)
        {
            Thread.Sleep((int)numScanTimeOut.Value);

            var input = new InputSimulator();
            string data;

            if (CurrentPreset.Name == "pdf417")
            {
                data = txtScanCode.Text.Replace("\r\r", "\r")
                                       .Replace(Environment.NewLine, "\n");
            }
            else
            {
                data = txtScanCode.Text;
            }

            if (numScanTimeoutLag.Value > 0)
            {
                for (int i = 0; i < data.Length; i++)
                {
                    input.Keyboard.TextEntry(data[i]);
                    Thread.Sleep((int)numScanTimeoutLag.Value);
                }
            }
            else
            {
                input.Keyboard.TextEntry(data);
            }
        }
        
        private void frmSender_Load(object sender, EventArgs e)
        {
            cmbPresets.DataSource = _presetTree.Presets;
            cmbPresets.DisplayMember = "Name";

            cmbPresetFilter.DataSource = FilterData();
            cmbPresetFilter.DisplayMember = "Name";
            cmbPresetFilter.ValueMember = "Value";

            cmbPresets.SelectedIndexChanged += ChangePreset;
            cmbPresetFilter.SelectedIndexChanged += ChangePresetFilter;

            txtScanCode.Text = CurrentPresetData.Value;
            pctBarCode.Image = GenerateImage(txtScanCode.Text.Replace(Environment.NewLine, "\n"));
        }

        private void txtScanCode_TextChanged(object sender, EventArgs e)
        {
            pctBarCode.Image = GenerateImage(txtScanCode.Text.Replace(Environment.NewLine, "\n"));
        }
    }
}
