using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public class ZcDigit:TextBox
    {
        Color _focuseColor = Color.FromArgb(255, 235, 238);
        Color _BackColor = Color.White;

        public ZcDigit()
        {

            this.Enter += ZcTextBox_Enter;
            this.Leave += ZcTextBox_Leave;
            this.KeyPress += ZcDigit_KeyPress;
        }

        private void ZcDigit_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar!=13 && e.KeyChar != 8)
            {
                if(!(e.KeyChar >= 48 && e.KeyChar <= 57))
                {
                    e.KeyChar = (Char)0;
                }
            }
        }
        public Font zcActive { set; get; }
        public Color ZcFocuseColor
        {
            set { _focuseColor = value; }
            get { return _focuseColor; }
        }

        private void ZcTextBox_Leave(object sender, EventArgs e)
        {
            this.BackColor = _BackColor;
        }

        private void ZcTextBox_Enter(object sender, EventArgs e)
        {
            this.BackColor = _focuseColor;
        }
    }
}
