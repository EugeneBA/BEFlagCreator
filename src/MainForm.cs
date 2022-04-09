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

namespace BEFlagCreator
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            _comboAspectRatio.SelectedIndex = 0;
        }

        private void _btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private Bitmap _flagImage;
        private double[] _aspectRatios = {2.0 / 3.0, 3.0 / 5.0, 1.0 / 2.0};

        void UpdateFlagImage()
        {
            Color[] colors = new Color[]
            {
                _bandColorBox1.BandColor,
                _bandColorBox2.BandColor,
                _bandColorBox3.BandColor,
                _bandColorBox4.BandColor,
                _bandColorBox5.BandColor,
                _bandColorBox6.BandColor,
                _bandColorBox7.BandColor
            };

            int flagHeight = (int) _upDownHeight.Value;
            int margins = 2;

            int flagWidth = (int)_upDownWidth.Value;

            if (_comboAspectRatio.SelectedIndex<=2)
                flagWidth = (int) (flagHeight / _aspectRatios[_comboAspectRatio.SelectedIndex]);

            int bandsCount = (int) _upDownBandsNum.Value;

            _flagImage = new Bitmap(flagWidth, flagHeight);
            using (var g = Graphics.FromImage(_flagImage))
            {
                var bandHeight = _flagImage.Height / (float)bandsCount;

                for (int i = 0; i < bandsCount; i++)
                {
                    using (var brush = new SolidBrush(colors[i]))
                        g.FillRectangle(brush, 0, i * bandHeight, _flagImage.Width, bandHeight);
                }
            }

            _boxImage.Image = _flagImage;
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
            UpdateFlagImage();
        }

        private void _bandColorBox_OnColorChanged(object sender, EventArgs e)
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
    }
}
