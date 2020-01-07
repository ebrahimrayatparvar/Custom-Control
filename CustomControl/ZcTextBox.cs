using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControl
{
    public class ZcTextBox:TextBox
    {
        Color _focuseColor = Color.FromArgb(255, 235, 238);
        Color _BackColor = Color.White;

        public ZcTextBox()
        {

            this.Enter += ZcTextBox_Enter;
            this.Leave += ZcTextBox_Leave;
        }
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
