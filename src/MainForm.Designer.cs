
using BEFlagCreator.Controls;

namespace BEFlagCreator
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this._boxImage = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this._comboAspectRatio = new System.Windows.Forms.ComboBox();
            this._radioHorizontal = new System.Windows.Forms.RadioButton();
            this._radioVertical = new System.Windows.Forms.RadioButton();
            this._btnSaveAs = new System.Windows.Forms.Button();
            this._btnClose = new System.Windows.Forms.Button();
            this._upDownBandsNum = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this._upDownMargins = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this._upDownWidth = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this._upDownHeight = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this._groupBands = new System.Windows.Forms.GroupBox();
            this._bandColorBox7 = new BEFlagCreator.BandColorBox();
            this._bandColorBox6 = new BEFlagCreator.BandColorBox();
            this._bandColorBox5 = new BEFlagCreator.BandColorBox();
            this._bandColorBox4 = new BEFlagCreator.BandColorBox();
            this._bandColorBox3 = new BEFlagCreator.BandColorBox();
            this._bandColorBox2 = new BEFlagCreator.BandColorBox();
            this._bandColorBox1 = new BEFlagCreator.BandColorBox();
            ((System.ComponentModel.ISupportInitialize)(this._boxImage)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._upDownBandsNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._upDownMargins)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._upDownWidth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._upDownHeight)).BeginInit();
            this._groupBands.SuspendLayout();
            this.SuspendLayout();
            // 
            // _boxImage
            // 
            this._boxImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this._boxImage.Dock = System.Windows.Forms.DockStyle.Fill;
            this._boxImage.Image = ((System.Drawing.Image)(resources.GetObject("_boxImage.Image")));
            this._boxImage.Location = new System.Drawing.Point(0, 0);
            this._boxImage.MinimumSize = new System.Drawing.Size(16, 16);
            this._boxImage.Name = "_boxImage";
            this._boxImage.Size = new System.Drawing.Size(972, 604);
            this._boxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this._boxImage.TabIndex = 0;
            this._boxImage.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._groupBands);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this._comboAspectRatio);
            this.panel1.Controls.Add(this._radioHorizontal);
            this.panel1.Controls.Add(this._radioVertical);
            this.panel1.Controls.Add(this._btnSaveAs);
            this.panel1.Controls.Add(this._btnClose);
            this.panel1.Controls.Add(this._upDownBandsNum);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this._upDownMargins);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this._upDownWidth);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this._upDownHeight);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(977, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(188, 604);
            this.panel1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Aspect ratio:";
            // 
            // _comboAspectRatio
            // 
            this._comboAspectRatio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this._comboAspectRatio.FormattingEnabled = true;
            this._comboAspectRatio.Items.AddRange(new object[] {
            "2/3",
            "3/5",
            "1/2",
            "free"});
            this._comboAspectRatio.Location = new System.Drawing.Point(112, 38);
            this._comboAspectRatio.Name = "_comboAspectRatio";
            this._comboAspectRatio.Size = new System.Drawing.Size(59, 21);
            this._comboAspectRatio.TabIndex = 9;
            this._comboAspectRatio.SelectedIndexChanged += new System.EventHandler(this._comboAspectRatio_SelectedIndexChanged);
            // 
            // _radioHorizontal
            // 
            this._radioHorizontal.AutoSize = true;
            this._radioHorizontal.Checked = true;
            this._radioHorizontal.Location = new System.Drawing.Point(99, 152);
            this._radioHorizontal.Name = "_radioHorizontal";
            this._radioHorizontal.Size = new System.Drawing.Size(72, 17);
            this._radioHorizontal.TabIndex = 8;
            this._radioHorizontal.TabStop = true;
            this._radioHorizontal.Text = "Horizontal";
            this._radioHorizontal.UseVisualStyleBackColor = true;
            // 
            // _radioVertical
            // 
            this._radioVertical.AutoSize = true;
            this._radioVertical.Location = new System.Drawing.Point(33, 152);
            this._radioVertical.Name = "_radioVertical";
            this._radioVertical.Size = new System.Drawing.Size(60, 17);
            this._radioVertical.TabIndex = 8;
            this._radioVertical.Text = "Vertical";
            this._radioVertical.UseVisualStyleBackColor = true;
            // 
            // _btnSaveAs
            // 
            this._btnSaveAs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnSaveAs.Location = new System.Drawing.Point(101, 422);
            this._btnSaveAs.Name = "_btnSaveAs";
            this._btnSaveAs.Size = new System.Drawing.Size(75, 23);
            this._btnSaveAs.TabIndex = 7;
            this._btnSaveAs.Text = "Save as";
            this._btnSaveAs.UseVisualStyleBackColor = true;
            this._btnSaveAs.Click += new System.EventHandler(this._btnSaveAs_Click);
            // 
            // _btnClose
            // 
            this._btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this._btnClose.Location = new System.Drawing.Point(101, 569);
            this._btnClose.Name = "_btnClose";
            this._btnClose.Size = new System.Drawing.Size(75, 23);
            this._btnClose.TabIndex = 7;
            this._btnClose.Text = "Close";
            this._btnClose.UseVisualStyleBackColor = true;
            this._btnClose.Click += new System.EventHandler(this._btnClose_Click);
            // 
            // _upDownBandsNum
            // 
            this._upDownBandsNum.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._upDownBandsNum.Location = new System.Drawing.Point(112, 117);
            this._upDownBandsNum.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this._upDownBandsNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this._upDownBandsNum.Name = "_upDownBandsNum";
            this._upDownBandsNum.Size = new System.Drawing.Size(59, 20);
            this._upDownBandsNum.TabIndex = 5;
            this._upDownBandsNum.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this._upDownBandsNum.ValueChanged += new System.EventHandler(this._upDownBandsNum_ValueChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 120);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Number of bands:";
            // 
            // _upDownMargins
            // 
            this._upDownMargins.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._upDownMargins.Location = new System.Drawing.Point(112, 91);
            this._upDownMargins.Maximum = new decimal(new int[] {
            32,
            0,
            0,
            0});
            this._upDownMargins.Name = "_upDownMargins";
            this._upDownMargins.Size = new System.Drawing.Size(59, 20);
            this._upDownMargins.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(59, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Margins:";
            // 
            // _upDownWidth
            // 
            this._upDownWidth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._upDownWidth.Location = new System.Drawing.Point(112, 65);
            this._upDownWidth.Maximum = new decimal(new int[] {
            8196,
            0,
            0,
            0});
            this._upDownWidth.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this._upDownWidth.Name = "_upDownWidth";
            this._upDownWidth.Size = new System.Drawing.Size(59, 20);
            this._upDownWidth.TabIndex = 3;
            this._upDownWidth.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this._upDownWidth.ValueChanged += new System.EventHandler(this._upDownWidth_ValueChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Width:";
            // 
            // _upDownHeight
            // 
            this._upDownHeight.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this._upDownHeight.Location = new System.Drawing.Point(112, 12);
            this._upDownHeight.Maximum = new decimal(new int[] {
            8196,
            0,
            0,
            0});
            this._upDownHeight.Minimum = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this._upDownHeight.Name = "_upDownHeight";
            this._upDownHeight.Size = new System.Drawing.Size(59, 20);
            this._upDownHeight.TabIndex = 1;
            this._upDownHeight.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this._upDownHeight.ValueChanged += new System.EventHandler(this._upDownHeight_ValueChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(65, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Height:";
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Right;
            this.splitter1.Location = new System.Drawing.Point(972, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(5, 604);
            this.splitter1.TabIndex = 2;
            this.splitter1.TabStop = false;
            // 
            // _groupBands
            // 
            this._groupBands.Controls.Add(this._bandColorBox7);
            this._groupBands.Controls.Add(this._bandColorBox6);
            this._groupBands.Controls.Add(this._bandColorBox5);
            this._groupBands.Controls.Add(this._bandColorBox4);
            this._groupBands.Controls.Add(this._bandColorBox3);
            this._groupBands.Controls.Add(this._bandColorBox2);
            this._groupBands.Controls.Add(this._bandColorBox1);
            this._groupBands.Location = new System.Drawing.Point(33, 185);
            this._groupBands.Name = "_groupBands";
            this._groupBands.Padding = new System.Windows.Forms.Padding(9, 3, 3, 3);
            this._groupBands.Size = new System.Drawing.Size(143, 231);
            this._groupBands.TabIndex = 11;
            this._groupBands.TabStop = false;
            this._groupBands.Text = "Bands";
            // 
            // _bandColorBox7
            // 
            this._bandColorBox7.BandColor = System.Drawing.Color.Black;
            this._bandColorBox7.BandName = "Band 7";
            this._bandColorBox7.Dock = System.Windows.Forms.DockStyle.Top;
            this._bandColorBox7.Location = new System.Drawing.Point(9, 196);
            this._bandColorBox7.Name = "_bandColorBox7";
            this._bandColorBox7.Size = new System.Drawing.Size(131, 30);
            this._bandColorBox7.TabIndex = 6;
            this._bandColorBox7.OnColorChanged += new System.EventHandler(this._bandColorBox_OnColorChanged);
            // 
            // _bandColorBox6
            // 
            this._bandColorBox6.BandColor = System.Drawing.Color.Yellow;
            this._bandColorBox6.BandName = "Band 6";
            this._bandColorBox6.Dock = System.Windows.Forms.DockStyle.Top;
            this._bandColorBox6.Location = new System.Drawing.Point(9, 166);
            this._bandColorBox6.Name = "_bandColorBox6";
            this._bandColorBox6.Size = new System.Drawing.Size(131, 30);
            this._bandColorBox6.TabIndex = 5;
            this._bandColorBox6.OnColorChanged += new System.EventHandler(this._bandColorBox_OnColorChanged);
            // 
            // _bandColorBox5
            // 
            this._bandColorBox5.BandColor = System.Drawing.Color.Purple;
            this._bandColorBox5.BandName = "Band 5";
            this._bandColorBox5.Dock = System.Windows.Forms.DockStyle.Top;
            this._bandColorBox5.Location = new System.Drawing.Point(9, 136);
            this._bandColorBox5.Name = "_bandColorBox5";
            this._bandColorBox5.Size = new System.Drawing.Size(131, 30);
            this._bandColorBox5.TabIndex = 4;
            this._bandColorBox5.OnColorChanged += new System.EventHandler(this._bandColorBox_OnColorChanged);
            // 
            // _bandColorBox4
            // 
            this._bandColorBox4.BandColor = System.Drawing.Color.Red;
            this._bandColorBox4.BandName = "Band 4";
            this._bandColorBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this._bandColorBox4.Location = new System.Drawing.Point(9, 106);
            this._bandColorBox4.Name = "_bandColorBox4";
            this._bandColorBox4.Size = new System.Drawing.Size(131, 30);
            this._bandColorBox4.TabIndex = 3;
            this._bandColorBox4.OnColorChanged += new System.EventHandler(this._bandColorBox_OnColorChanged);
            // 
            // _bandColorBox3
            // 
            this._bandColorBox3.BandColor = System.Drawing.Color.Lime;
            this._bandColorBox3.BandName = "Band 3";
            this._bandColorBox3.Dock = System.Windows.Forms.DockStyle.Top;
            this._bandColorBox3.Location = new System.Drawing.Point(9, 76);
            this._bandColorBox3.Name = "_bandColorBox3";
            this._bandColorBox3.Size = new System.Drawing.Size(131, 30);
            this._bandColorBox3.TabIndex = 2;
            this._bandColorBox3.OnColorChanged += new System.EventHandler(this._bandColorBox_OnColorChanged);
            // 
            // _bandColorBox2
            // 
            this._bandColorBox2.BandColor = System.Drawing.Color.Blue;
            this._bandColorBox2.BandName = "Band 2";
            this._bandColorBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this._bandColorBox2.Location = new System.Drawing.Point(9, 46);
            this._bandColorBox2.Name = "_bandColorBox2";
            this._bandColorBox2.Size = new System.Drawing.Size(131, 30);
            this._bandColorBox2.TabIndex = 1;
            this._bandColorBox2.OnColorChanged += new System.EventHandler(this._bandColorBox_OnColorChanged);
            // 
            // _bandColorBox1
            // 
            this._bandColorBox1.BandColor = System.Drawing.Color.White;
            this._bandColorBox1.BandName = "Band 1";
            this._bandColorBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this._bandColorBox1.Location = new System.Drawing.Point(9, 16);
            this._bandColorBox1.Name = "_bandColorBox1";
            this._bandColorBox1.Size = new System.Drawing.Size(131, 30);
            this._bandColorBox1.TabIndex = 0;
            this._bandColorBox1.OnColorChanged += new System.EventHandler(this._bandColorBox_OnColorChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1165, 604);
            this.Controls.Add(this._boxImage);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Flag creator";
            ((System.ComponentModel.ISupportInitialize)(this._boxImage)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._upDownBandsNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._upDownMargins)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._upDownWidth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._upDownHeight)).EndInit();
            this._groupBands.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox _boxImage;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox _comboAspectRatio;
        private System.Windows.Forms.RadioButton _radioHorizontal;
        private System.Windows.Forms.RadioButton _radioVertical;
        private System.Windows.Forms.Button _btnSaveAs;
        private System.Windows.Forms.Button _btnClose;
        private System.Windows.Forms.NumericUpDown _upDownBandsNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown _upDownMargins;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown _upDownWidth;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown _upDownHeight;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox _groupBands;
        private BandColorBox _bandColorBox7;
        private BandColorBox _bandColorBox6;
        private BandColorBox _bandColorBox5;
        private BandColorBox _bandColorBox4;
        private BandColorBox _bandColorBox3;
        private BandColorBox _bandColorBox2;
        private BandColorBox _bandColorBox1;
    }
}

