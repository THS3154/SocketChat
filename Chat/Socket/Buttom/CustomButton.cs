using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
namespace Socket
{
    class CustomButton : Control
    {
        private SolidBrush borderBrush, textBrush;
        private Rectangle borderRectangle;
        private bool active = false;
        private StringFormat stringFormat = new StringFormat();

        private Image image1 = System.Drawing.SystemIcons.Hand.ToBitmap();
        private Image image2 = System.Drawing.SystemIcons.Hand.ToBitmap();

        private string backcolor = "#2f3136";

        public override Cursor Cursor { get; set; } = Cursors.Hand;
        public float BorderThickness { get; set; } = 2;


        public Image Image1
        {
            get
            {
                return this.image1;
            }
            set
            {
                this.image1 = value;
                this.BackgroundImage = this.image1;
            }
        }

        public Image Image2
        {
            get
            {
                return this.image2;
            }
            set
            {
                this.image2 = value;
            }

        }

        public CustomButton()
        {
            this.BackgroundImage = this.image1;
            this.BackgroundImageLayout = ImageLayout.Center;
            
            this.BackColor = ColorTranslator.FromHtml(backcolor);

            borderBrush = new SolidBrush(ColorTranslator.FromHtml("#31302b"));
            textBrush = new SolidBrush(ColorTranslator.FromHtml("#FFF"));

            stringFormat.Alignment = StringAlignment.Center;
            stringFormat.LineAlignment = StringAlignment.Center;

            this.Paint += CustomButton_Paint;
        }

        private void CustomButton_Paint(object sender, PaintEventArgs e)
        { 
            borderRectangle = new Rectangle(0, 0, Width, Height);
            e.Graphics.DrawRectangle(new Pen(borderBrush, BorderThickness), borderRectangle);
            e.Graphics.DrawString(this.Text, this.Font, (active) ? textBrush : borderBrush, borderRectangle, stringFormat);
        }



        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            base.BackColor = ColorTranslator.FromHtml(backcolor);

            active = true;
        }

        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            base.BackColor = ColorTranslator.FromHtml(backcolor);

            active = false;
        }



        protected override void OnMouseHover(EventArgs e)
        {
            //마우스안에있을때
            base.OnMouseHover(e);
            base.BackColor = ColorTranslator.FromHtml(backcolor);

            base.BackgroundImage = this.image2;
            active = true;
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            //마우스떠날때
            base.OnMouseLeave(e);
            base.BackColor = ColorTranslator.FromHtml(backcolor);

            base.BackgroundImage = this.image1;
            active = false;
        }
    }
}
