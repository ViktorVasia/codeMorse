using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Morse
{
    public partial class main_menu : Form
    {
        public main_menu()
        {
            InitializeComponent();
            this.MaximizeBox = false;   // запретить увеличение формы

            // Озвучить
            SoundPlayer selectTrening = new SoundPlayer("sounds\\main_menu.wav");
            selectTrening.Play();
        }

        private void main_menu_Load(object sender, EventArgs e)
        {

        }

        private void trening_btn_Click(object sender, EventArgs e)
        {
            // переход на новую форму
            Hide();
            trening f = new trening();
            f.ShowDialog();
            Close();
        }
    }
}
