using System;
using System.Drawing;
using System.Windows.Forms;

namespace BEFlagCreator.Controls
{
    public partial class ColorPicker : UserControl
    {
        public ColorPicker()
        {
            InitializeComponent();
            _State = EnumState.Normal;
            ProcessMouseEvents = false;
            DoRedrawOnColorChange = false;
            Color = Color.Purple;
        }

        public ColorPicker(Color color, bool processMouseEvents)
            : this()
        {
            Color = color;
            ProcessMouseEvents = processMouseEvents;
        }

        public Color Color
        {
            get { return BackColor; }
            set
            {
                BackColor = value;
                if (DoRedrawOnColorChange)
                    this.Update();
                _ToolTip.SetToolTip(this, GetColorString(Color));
            }
        }

        public event EventHandler OnColorSelected;

        public bool ProcessMouseEvents { get; set; }
        public bool DoRedrawOnColorChange { get; set; }


        static public string GetColorString(Color color)
        {
            return string.Format("[R={0}, G={1}, B={2}]", color.R, color.G, color.B);
        }

        enum EnumState { MouseOver, Clicked, Normal };
        EnumState _State;

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            Graphics g = e.Graphics;

            Color color1 = SystemColors.ControlDark;
            Color color2 = SystemColors.ControlDark;

            if (_State == EnumState.MouseOver) 		//mouse over
            {
                color1 = SystemColors.ControlLightLight;
                color2 = SystemColors.ControlDarkDark;
            }
            else if (_State == EnumState.Clicked)	//clicked
            {
                color1 = SystemColors.ControlDarkDark;
                color2 = SystemColors.ControlLightLight;
            }

            Rectangle r = ClientRectangle;
            Point p1 = new Point(r.Left, r.Top); 				//top left
            Point p2 = new Point(r.Right - 1, r.Top);			//top right
            Point p3 = new Point(r.Left, r.Bottom - 1);		//bottom left
            Point p4 = new Point(r.Right - 1, r.Bottom - 1);	//bottom right

            using (Pen pen1 = new Pen(color1))
            {
                g.DrawLine(pen1, p1, p2);
                g.DrawLine(pen1, p1, p3);
            }
            using (Pen pen2 = new Pen(color2))
            {
                g.DrawLine(pen2, p2, p4);
                g.DrawLine(pen2, p3, p4);
            }
        }

        protected override void OnMouseEnter(EventArgs e)
        {
            if (ProcessMouseEvents)
            {
                _State = EnumState.MouseOver;
                Invalidate();
            }

            base.OnMouseEnter(e);
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            if (ProcessMouseEvents)
            {
                _State = EnumState.Normal;
                Invalidate();
            }

            base.OnMouseLeave(e);
        }

        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (ProcessMouseEvents)
            {
                _State = EnumState.Clicked;
                Invalidate();
            }
            base.OnMouseDown(e);
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            if (ProcessMouseEvents)
            {
                _State = EnumState.MouseOver;
                Invalidate();

                OnColorSelected?.Invoke(this, EventArgs.Empty);
            }
            base.OnMouseUp(e);
        }
    }
}
