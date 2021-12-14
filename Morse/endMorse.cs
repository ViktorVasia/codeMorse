using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse
{
    public partial class endMorse : Form
    {
        public endMorse()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            Err_label.Text = Convert.ToString(Morse.countErr);
        }

        private void endMorse_Load(object sender, EventArgs e)
        {

        }

        private void repeat_btn_Click(object sender, EventArgs e)
        {
            Hide();
            begin f = new begin();
            f.ShowDialog();
            Close();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Hide();
            trening f = new trening();
            f.ShowDialog();
            Close();
        }
    }
}
