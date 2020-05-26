using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace CustomControls
{
    //inherit TextBox object
    public class RequiredTextBox: TextBox
    {
        //add properties
        private String WatermarkText = "Required";

        private bool _Required;

        //property that will be visible on properties window
        public bool Required
        {
            get { return _Required; }
            set
            {
                _Required = value;

                //add or remove the watermark
                if (value)
                    ShowWaterMark();
                else
                    RemoveWaterMark();
            }
        }

        //watermark holder
        private Panel WatermarkHolder = new Panel();

        //constructor
        public RequiredTextBox()
        {
            //lets draw the watermark
            WatermarkHolder.Paint += WatermarkHolder_Paint;

            //what if the panel/textbox was clicked by the user
            //we must remove the watermark
            WatermarkHolder.Click += WatermarkHolder_Click;

            //what if the textbox receive focus
            //we should remove the watermark
            this.Enter += RequiredTextBox_Enter;

            //what if the textbox lost focus
            //we should show the watermark
            this.Leave += RequiredTextBox_Leave;
        }

        private void WatermarkHolder_Click(object sender, EventArgs e)
        {
            RemoveWaterMark();
            this.Focus();
        }

        private void RequiredTextBox_Leave(object sender, EventArgs e)
        {
            if (this.Required)
                ShowWaterMark();
        }

        private void RequiredTextBox_Enter(object sender, EventArgs e)
        {
            RemoveWaterMark();
        }

        private void WatermarkHolder_Paint(object sender, PaintEventArgs e)
        {
            using (Brush brush = new SolidBrush(Color.Gray))
                e.Graphics.DrawString(WatermarkText, this.Font, brush, new PointF(-0.1F, 0.1F));
        }

        private void ShowWaterMark()
        {
            //show watermark if text is empty
            if (String.IsNullOrWhiteSpace(this.Text))
                this.Controls.Add(WatermarkHolder);
        }

        private void RemoveWaterMark()
        {
            this.Controls.Clear();
        }

        //I think we were done, lets build and test it
    }
}
