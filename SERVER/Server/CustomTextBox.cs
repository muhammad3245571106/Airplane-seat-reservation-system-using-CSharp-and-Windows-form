using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    [DefaultEvent("TextChanged")]
    public partial class CustomTextBox : UserControl
    {
        private Color borderColor = Color.FromArgb(88, 205, 54);
        private int bordesSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.Gray;
        private bool isFocused = false;
        private bool isPlaceholder = false;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPasswordChar = false;
        //private int MaxLength = 1000;
        //constructor
        public CustomTextBox()
        {
            InitializeComponent();
        }
        //events
        public event EventHandler TextChanged;
        //properties
        [Category("custom")]
        public Color BorderColor
        {
            get
            {
                return borderColor;
            }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }
        [Category("custom")]
        public int BordesSize
        {
            get
            {
                return bordesSize;
            }
            set
            {
                bordesSize = value;
                this.Invalidate();
            }
        }
        [Category("custom")]
        public bool UnderlinedStyle
        {
            get
            {
                return underlinedStyle;
            }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }
        [Category("custom")]
        public bool PasswordChar
        {
            get
            {
                return isPasswordChar;
            }
            set
            {
                isPasswordChar = value;
                textBox1.UseSystemPasswordChar = value;
            }
        }
        [Category("custom")]
        public bool Multiline
        {
            get
            {
                return textBox1.Multiline;
            }
            set
            {
                textBox1.Multiline = value;
            }
        }
        [Category("custom")]
        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }
            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }
        [Category("custom")]
        public override Color ForeColor
        {
            get
            {
                return base.ForeColor;
            }
            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }
        [Category("custom")]
        public override Font Font
        {
            get
            {
                return base.Font;
            }
            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                {
                    updateControlHeight();
                }
            }
        }
        [Category("custom")]
        public string Text
        {
            get
            {
                if (isPlaceholder)
                {
                    return "";
                }
                else
                {
                    return textBox1.Text;
                }
            }
            set
            {
                textBox1.Text = value;
                SetPlaceholder();
            }
        }
        [Category("custom")]
        public Color BorderFocusColor
        {
            get
            {
                return borderFocusColor;
            }
            set
            {
                borderFocusColor = value;
            }
        }
        public Color PlaceholderColor
        {
            get
            {
                return placeholderColor;
            }
            set
            {
                placeholderColor = value;
                if (isPlaceholder)
                {
                    textBox1.ForeColor = value;
                }
            }
        }
        [Category("custom")]
        public string PlaceholderText
        {
            get
            {
                return placeholderText;
            }
            set
            {
                placeholderText = value;
                textBox1.Text = "";
                SetPlaceholder();
            }
        }
        public int MaxLength
        {
            get
            {
                return textBox1.MaxLength;
            }
            set
            {
                textBox1.MaxLength = value;
            }
        }
        [Category("custom")]
        private void SetPlaceholder()
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
            {
                isPlaceholder = true;
                textBox1.Text = placeholderText;
                textBox1.ForeColor = placeholderColor;
                if (isPasswordChar)
                {
                    textBox1.UseSystemPasswordChar = false;
                }
            }
        }
        [Category("custom")]
        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                {
                    textBox1.UseSystemPasswordChar = true;
                }
            }
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            using (Pen penBorder = new Pen(borderColor, bordesSize))
            {
                penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                if (!isFocused)
                {
                    if (underlinedStyle)
                    {
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else
                    {
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }
                else
                {
                    penBorder.Color = borderFocusColor;
                    if (underlinedStyle)
                    {
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else
                    {
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                    }
                }
            }
        }
        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if (this.DesignMode)
            {
                updateControlHeight();
            }

        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            updateControlHeight();
        }
        private void updateControlHeight()
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
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (TextChanged != null)
            {
                TextChanged(sender, e);
            }
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
            isFocused = true;
            this.Invalidate();
            RemovePlaceholder();
        }
        private void textBox1_Leave(object sender, EventArgs e)
        {
            isFocused = false;
            this.Invalidate();
            SetPlaceholder();
        }
    }
}
