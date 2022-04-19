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

            _flagImage = new Bitmap(flagWidth, flagHeight);
            using (var g = Graphics.FromImage(_flagImage))
            {
                if (_radioHorizontal.Checked)
                    DrawHFlagBands(g, flagWidth, flagHeight, bandColors);
                else
                    DrawVFlagBands(g, flagWidth, flagHeight, bandColors);

                if (_checkBorder.Checked)
                    DrawFlagBorder(g, flagWidth, flagHeight, _pickerBorderColor.Color);
            }

            _boxImage.Image = _flagImage;
        }

        private void DrawFlagBorder(Graphics graphics, int flagWidth, int flagHeight, Color color)
        {
            using (var pen = new Pen(color))
                graphics.DrawRectangle(pen, 0, 0, flagWidth - 1, flagHeight - 1);
        }

        private void DrawHFlagBands(Graphics g, int flagWidth, int flagHeight, Color[] bandColors)
        {
            var bandHeight = flagHeight / (float)bandColors.Length;

            for (int i = 0; i < bandColors.Length; i++)
            {
                using (var brush = new SolidBrush(bandColors[i]))
                    g.FillRectangle(brush, 0, i * bandHeight, flagWidth, bandHeight);
            }
        }

        private void DrawVFlagBands(Graphics g, int flagWidth, int flagHeight, Color[] bandColors)
        {
            var bandWidth = flagWidth / (float)bandColors.Length;

            for (int i = 0; i < bandColors.Length; i++)
            {
                using (var brush = new SolidBrush(bandColors[i]))
                    g.FillRectangle(brush, i * bandWidth, 0, bandWidth, flagHeight);
            }
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

        private void _pickerBorderColor_OnColorSelected(object sender, EventArgs e)
        {
            using (var dlg = new ColorDialog())
            {
                dlg.AllowFullOpen = true;
                dlg.FullOpen = true;
                dlg.AnyColor = true;
                dlg.SolidColorOnly = false;
                dlg.ShowHelp = false;
                dlg.Color = _pickerBorderColor.Color;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    _pickerBorderColor.Color = dlg.Color;
                    UpdateFlagImage();
                }

            }
        }

        private void _checkBorder_CheckedChanged(object sender, EventArgs e)
        {
            UpdateFlagImage();
        }

        private Bitmap[] _frames;

        void CreateFrames(int frameCount)
        {
            int margins = 10;

            float waveAmplitude = 0.1f;

            Debug.Assert(waveAmplitude < 0.5);

            var frameHeight = (int)Math.Round(_flagImage.Height * (1 + 4 * waveAmplitude)) + 2 * margins;
            var frameWidth = _flagImage.Width + 2 * margins;

            int A = (int)Math.Round(_flagImage.Height * waveAmplitude);

            Debug.Assert(frameCount > 0);
            _frames = new Bitmap[frameCount];

            var dPh = -2 * Math.PI / frameCount;
            for (int i = 0; i < frameCount; i++)
            {
                Debug.WriteLine($"i={i}");
                var ph = dPh * i;
                Console.WriteLine($"Ph={ph}");
                var w = 1.5 * Math.PI / _flagImage.Width;
                _frames[i] = new Bitmap(frameWidth, frameHeight);

                var xshift = margins;

                var sin0 = Math.Sin(ph);

                for (int x = 0; x < _flagImage.Width; x++)
                {
                    var sin = Math.Sin(w * x + ph);
                    var yshift = (int)Math.Round(margins + 2 * A + A * (sin - sin0));

                    for (int y = 0; y < _flagImage.Height; y++)
                    {
                        _frames[i].SetPixel(x + xshift, y + yshift, _flagImage.GetPixel(x, y));
                    }
                }
            }

            //using (var gif = AnimatedGif.AnimatedGif.Create("flag.gif", 31))
            //{
            //    var dPh = -2 * Math.PI / (N);
            //    for (int i = 0; i < N; i++)
            //    {
            //        Console.WriteLine($"i={i}");
            //        var ph = dPh * i;
            //        Console.WriteLine($"Ph={ph}");
            //        var w = 1.5 * Math.PI / flagWidth;
            //        var frame = new Bitmap(gifWidth, gifHeight);

            //        var xshift = margins;

            //        var sin0 = Math.Sin(ph);

            //        for (int x = 0; x < flagImage.Width; x++)
            //        {
            //            var sin = Math.Sin(w * x + ph);
            //            var yshift = (int)Math.Round(margins + 2 * A + A * (sin - sin0));

            //            for (int y = 0; y < flagImage.Height; y++)
            //            {
            //                frame.SetPixel(x + xshift, y + yshift, flagImage.GetPixel(x, y));
            //            }
            //        }
            //        gif.AddFrame(frame, delay: -1, quality: GifQuality.Bit8);
            //    }

            //for (int i = N-1; i >=0; i--)
            //{
            //    Console.WriteLine($"i={i}");
            //    var a = -A + dA * i;
            //    var w = 2 * Math.PI / flagWidth;
            //    var frame = new Bitmap(flagWidth, height);
            //    for (int x = 0; x < flagWidth; x++)
            //    {
            //        var ybeg = A + a * Math.Sin(w * x);
            //        var yend = flagHeight + ybeg;

            //        for (int y = 0; y < height; y++)
            //        {
            //            if (y > ybeg && y < yend)
            //                frame.SetPixel(x, y, colors[0]);
            //        }
            //    }
            //    gif.AddFrame(frame, delay: -1, quality: GifQuality.Bit8);
            //}
        }

        private int _curFrame = 0;
        private void _timerAnimation_Tick(object sender, EventArgs e)
        {
            _curFrame++;
            if (_curFrame >= _frames.Length)
                _curFrame = 0;
            _boxImage.Image = _frames[_curFrame];
            _labelCurFrame.Text = $"{_curFrame + 1}/{_frames.Length}";
        }

        private void _btnStartStop_Click(object sender, EventArgs e)
        {
            _timerAnimation.Enabled = !_timerAnimation.Enabled;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CreateFrames(20);
        }
    }
}

