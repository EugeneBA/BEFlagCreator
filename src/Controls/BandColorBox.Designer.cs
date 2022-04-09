
namespace BEFlagCreator
{
    partial class BandColorBox
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this._bandLabel = new System.Windows.Forms.Label();
            this._colorBox = new BEFlagCreator.Controls.ColorPicker();
            this.SuspendLayout();
            // 
            // _bandLabel
            // 
            this._bandLabel.AutoSize = true;
            this._bandLabel.Location = new System.Drawing.Point(34, 9);
            this._bandLabel.Name = "_bandLabel";
            this._bandLabel.Size = new System.Drawing.Size(41, 13);
            this._bandLabel.TabIndex = 1;
            this._bandLabel.Text = "Band 1";
            // 
            // _colorBox
            // 
            this._colorBox.BackColor = System.Drawing.Color.Purple;
            this._colorBox.Color = System.Drawing.Color.Purple;
            this._colorBox.DoRedrawOnColorChange = true;
            this._colorBox.Location = new System.Drawing.Point(3, 3);
            this._colorBox.Name = "_colorBox";
            this._colorBox.ProcessMouseEvents = true;
            this._colorBox.Size = new System.Drawing.Size(24, 24);
            this._colorBox.TabIndex = 0;
            this._colorBox.OnColorSelected += new System.EventHandler(this._colorBox_OnColorSelected);
            // 
            // BandColorBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this._bandLabel);
            this.Controls.Add(this._colorBox);
            this.Name = "BandColorBox";
            this.Size = new System.Drawing.Size(133, 30);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.ColorPicker _colorBox;
        private System.Windows.Forms.Label _bandLabel;
    }
}
