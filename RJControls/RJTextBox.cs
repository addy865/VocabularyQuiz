using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinformForTesting.RJControls
{
    [DefaultEvent("_TextChanged")]
    public partial class RJTextBox : UserControl
    {
        //Fields
        private Color borderColor = Color.DarkGray;
        private Color borderColorFouce = Color.RoyalBlue;
        private int borderSize = 1;
        private bool underlinedStyle = false;
        private bool isFoucsed = false;

        private int borderRadius = 0;
        private Color placeHolderColer = Color.DarkGray;
        private string placeHoderText = string.Empty;
        private bool isPlaceHoder = false;
        private bool isPasswordChar = false;


        private bool isReadOnly = false;

        //Constructor
        public RJTextBox()
        {
            InitializeComponent();
        }

        //Event
        public event EventHandler _TextChanged;

        //Properties
        #region Properties 

        [Category("RJ Code Advance")]
        public Color BorderColor { get { return borderColor; } set { borderColor = value; this.Invalidate(); } }
        [Category("RJ Code Advance")]
        public int BorderSize { get { return borderSize; } set { borderSize = value; this.Invalidate(); } }
        [Category("RJ Code Advance")]
        public bool UnderlinedStyle { get { return underlinedStyle; } set { underlinedStyle = value; this.Invalidate(); } }
        [Category("RJ Code Advance")]
        public bool PasswordChar { get { return isPasswordChar; } set { isPasswordChar = value; textBox1.UseSystemPasswordChar = value; } }
        [Category("RJ Code Advance")]
        public bool Multiline { get { return textBox1.Multiline; } set { textBox1.Multiline = value; } }
        public override Color BackColor { get { return base.BackColor; } set { base.BackColor = value; textBox1.BackColor = value; } }
        [Category("RJ Code Advance")]
        public override Color ForeColor { get { return base.ForeColor; } set { base.BackColor = value; textBox1.ForeColor = value; } }
        [Category("RJ Code Advance")]
        public override Font Font { get { return base.Font; } set { base.Font = value; textBox1.Font = value; if (this.DesignMode) UpdateControlHeight(); } }
        [Category("RJ Code Advance")]
        public string Texts { get { if (isPlaceHoder) return ""; else return textBox1.Text; } set { textBox1.Text = value; SetPlaceHolder(); } }
        [Category("RJ Code Advance")]
        public Color BorderColorFouce { get { return borderColorFouce; } set { borderColorFouce = value; } }
        [Category("RJ Code Advance")]
        public int BorderRadius { get { return borderRadius; } set { if (value >= 0) borderRadius = value; this.Invalidate();/* Redraw control */ } }
        [Category("RJ Code Advance")]
        public Color PlaceHolderColer { get { return placeHolderColer; } set { placeHolderColer = value; if (isPasswordChar) textBox1.ForeColor = value; } }
        [Category("RJ Code Advance")]
        public string PlaceHoderText { get { return placeHoderText; } set { placeHoderText = value; textBox1.Text = ""; SetPlaceHolder(); } }
        [Category("RJ Code Advance")]
        public bool ReadOnly { get { return isReadOnly; } set { isReadOnly = value; this.Invalidate(); SetReadOnly(); } }               

        private void SetReadOnly()
        {
            if (ReadOnly)
                textBox1.ReadOnly = true;
            else
                textBox1.ReadOnly = false;
        }

        private void SetPlaceHolder()
        {
            if(String.IsNullOrWhiteSpace(textBox1.Text) && placeHoderText != "")
            {
                isPlaceHoder = true;
                textBox1.Text = placeHoderText;
                textBox1.ForeColor = PlaceHolderColer;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = false;
            }
        }

        private void RemovePlaceHoder()
        {
            if (isPlaceHoder && placeHoderText != "")
            {
                isPlaceHoder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = true;
            }
        }
        #endregion

        //Overridden methods
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;

            if (borderRadius > 1) //Rounded TextBox
            {
                //Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;

                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, BorderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, BorderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //Drawing
                    this.Region = new Region(pathBorderSmooth); //Set the rounded region of UserControl
                    if (BorderRadius > 15) SetTextBoxRoundedRegion();
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    //Set fouce color
                    if (isFoucsed) penBorder.Color = borderColorFouce;

                    if (underlinedStyle) //Line Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //Normal Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.DrawPath(penBorder, pathBorder);
                        //graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                        
                }
            }
            else //Square or Normal TextBox
            {
                //Draw border
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    //Set fouce color
                    if (isFoucsed) penBorder.Color = borderColorFouce;

                    if (underlinedStyle) //Line Style
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Normal Style
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }

            
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle,BorderRadius - BorderSize);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, BorderSize * 2);
                textBox1.Region = new Region(pathTxt);
            }
        }

        //Methods
        private GraphicsPath GetFigurePath(RectangleF rect, float radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Width - radius, rect.Y, radius, radius, 270, 90);
            path.AddArc(rect.Width - radius, rect.Height - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            return path;
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
                UpdateControlHeight();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeight();
        }

        private void UpdateControlHeight()
        {
            if (textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }


        #region Events

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (_TextChanged != null) 
                _TextChanged.Invoke(sender, e); 
        }
        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }
        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }
        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }
        private void textBox1_Enter(object sender, EventArgs e)
        {
            isFoucsed = true;
            this.Invalidate();
            RemovePlaceHoder();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFoucsed = false;
            this.Invalidate();
            SetPlaceHolder();
        }

        #endregion
    }
}
