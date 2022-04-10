using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BECSLibrary;
using BECSLibrary.Controls;
using BEFlagCreator.Properties;

namespace BEFlagCreator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            _bandColorBoxes = new BandColorBox[]
            {
                _bandColorBox1,
                _bandColorBox2,
                _bandColorBox3,
                _bandColorBox4,
                _bandColorBox5,
                _bandColorBox6,
                _bandColorBox7
            };

            UpdateBandColorBoxEnables();

            if (_comboAspectRatio.SelectedIndex < 0)
                _comboAspectRatio.SelectedIndex = 0;
        }

        private void _btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private BandColorBox[] _bandColorBoxes;

        private Bitmap _flagImage;
        private double[] _aspectRatios = { 2.0 / 3.0, 3.0 / 5.0, 1.0 / 2.0 };

        void UpdateFlagImage()
        {
            int flagHeight = (int)_upDownHeight.Value;
            int margins = 2;

            int flagWidth = (int)_upDownWidth.Value;

            if (_comboAspectRatio.SelectedIndex <= 2)
            {
                flagWidth = (int)(flagHeight / _aspectRatios[_comboAspectRatio.SelectedIndex]);
                _upDownWidth.Value = flagWidth;
            }

            int bandsCount = (int)_upDownBandsNum.Value;
            var bandColors = _bandColorBoxes.Take(bandsCount).Select(box => box.BandColor).ToArray();

            _flagImage = _radioHorizontal.Checked ? CreateHBandsFlag(flagWidth, flagHeight, bandColors) : CreateVBandsFlag(flagWidth, flagHeight, bandColors);

            _boxImage.Image = _flagImage;
        }

        private Bitmap CreateHBandsFlag(int flagWidth, int flagHeight, Color[] bandColors)
        {
            var flag = new Bitmap(flagWidth, flagHeight);
            using (var g = Graphics.FromImage(flag))
            {
                var bandHeight = flag.Height / (float)bandColors.Length;

                for (int i = 0; i < bandColors.Length; i++)
                {
                    using (var brush = new SolidBrush(bandColors[i]))
                        g.FillRectangle(brush, 0, i * bandHeight, flag.Width, bandHeight);
                }
            }

            return flag;
        }

        private Bitmap CreateVBandsFlag(int flagWidth, int flagHeight, Color[] bandColors)
        {
            var flag = new Bitmap(flagWidth, flagHeight);
            using (var g = Graphics.FromImage(flag))
            {
                var bandWidth = flag.Width / (float)bandColors.Length;

                for (int i = 0; i < bandColors.Length; i++)
                {
                    using (var brush = new SolidBrush(bandColors[i]))
                        g.FillRectangle(brush, i * bandWidth, 0, bandWidth, flag.Height);
                }
            }
            return flag;
        }

        private void _upDownHeight_ValueChanged(object sender, EventArgs e)
        {
            UpdateFlagImage();
        }

        private void _comboAspectRatio_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateFlagImage();
        }

        private void _upDownWidth_ValueChanged(object sender, EventArgs e)
        {
            UpdateFlagImage();
        }

        private void _upDownBandsNum_ValueChanged(object sender, EventArgs e)
        {
            UpdateBandColorBoxEnables();

            UpdateFlagImage();
        }

        private void UpdateBandColorBoxEnables()
        {
            var bandsCount = (int)_upDownBandsNum.Value;
            for (int i = 0; i < _bandColorBoxes.Length; i++)
                _bandColorBoxes[i].Enabled = i < bandsCount;
        }

        private void _bandColorBox_OnColorChanged(object sender, EventArgs e)
        {
            UpdateFlagImage();
        }

        private void _radioHorizontal_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFlagImage();
        }

        private void _btnSaveAs_Click(object sender, EventArgs e)
        {
            using (var dlg = new SaveFileDialog())
            {
                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _flagImage.Save(dlg.FileName);
                }
            }
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Settings.Default.Save();
        }
    }
}
