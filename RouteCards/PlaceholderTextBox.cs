using System;
using System.Drawing;
using System.Windows.Forms;

namespace RouteCards
{
    public class PlaceholderTextBox : TextBox
    {
        string placeHolder;

        public string Placeholder 
        {
            get => placeHolder;
            set
            {
                placeHolder = value;
                ForeColor = Color.Gray;
                Text = value;
                Invalidate();
            }
        }

        public string Value 
        { 
            get
            {
                if (Text != Placeholder)
                {
                    return Text;
                }
                else
                {
                    return "";
                }
            }
        }

        public PlaceholderTextBox()
        {
            Enter += CustomTextBox_Enter;
            Leave += CustomTextBox_Leave;
            DoubleClick += PlaceholderTextBox_DoubleClick;
        }

        private void CustomTextBox_Enter(object sender, EventArgs e)
        {
            ForeColor = Color.Black;

            if (Text == Placeholder) 
                Text = "";
        }

        private void CustomTextBox_Leave(object sender, EventArgs e)
        {
            if (Text.Trim() == "")
            {
                ForeColor = Color.Gray;
                Text = Placeholder;
            }
        }

        private void PlaceholderTextBox_DoubleClick(object sender, EventArgs e)
        {
            Text = "";
        }
    }
}
