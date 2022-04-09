using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BEFlagCreator
{
    public partial class BandColorBox : UserControl
    {
        public BandColorBox()
        {
            InitializeComponent();
        }

        private void _colorBox_OnColorSelected(object sender, EventArgs e)
        {
            using (var dlg = new ColorDialog())
            {
                dlg.AllowFullOpen = true;
                dlg.FullOpen = true;
                dlg.AnyColor = true;
                dlg.SolidColorOnly = false;
                dlg.ShowHelp = false;
                dlg.Color = BandColor;

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    BandColor = dlg.Color;
                    OnColorChanged?.Invoke(this, EventArgs.Empty);
                }

            }
        }

        public event EventHandler OnColorChanged;

        public Color BandColor
        {
            get => _colorBox.Color;
            set => _colorBox.Color = value;
        }

        public string BandName
        {
            get => _bandLabel.Text;
            set => _bandLabel.Text = value;
        }
    }
}
