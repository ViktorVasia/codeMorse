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
    public partial class trening : Form
    {
        CheckBox[] KeyBoard = new CheckBox[43];
        char[] ListSim = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Е', 'Ж', 'З', 'И', 'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С', 'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь', 'Э', 'Ю', 'Я', '1', '2', '3', '4', '5', '6', '7', '8', '9', '0' };
        public trening()
        {
            InitializeComponent();
            this.MaximizeBox = false;   // запретить увеличение формы

            // инициализация эл. на форме
            init_chBox();               // сконфигурировать checkBox
            if (Morse.speed != 0)
                speed_domain.Text = Convert.ToString(Morse.speed);
            else
                speed_domain.Text = "50";

            Morse.timeDOP = 120;

            // Озвучить
            SoundPlayer Select = new SoundPlayer("sounds\\trening_menu.wav");
            Select.Play();
        }

        private void trening_Load(object sender, EventArgs e)
        {

        }

        private void ComeBack_btn_Click(object sender, EventArgs e)
        {
            // Переход в главное меню
            Hide();
            main_menu f = new main_menu();
            f.ShowDialog();
            Close();
        }

        /// <summary>
        /// Инициализачия checkBox на панеле.
        /// </summary>
        private void init_chBox()
        {
            KeyBoard[0] = chBox1;
            KeyBoard[1] = chBox2;
            KeyBoard[2] = chBox3;
            KeyBoard[3] = chBox4;
            KeyBoard[4] = chBox5;
            KeyBoard[5] = chBox6;
            KeyBoard[6] = chBox7;
            KeyBoard[7] = chBox8;
            KeyBoard[8] = chBox9;
            KeyBoard[9] = chBox10;
            KeyBoard[10] = chBox11;
            KeyBoard[11] = chBox12;
            KeyBoard[12] = chBox13;
            KeyBoard[13] = chBox14;
            KeyBoard[14] = chBox15;
            KeyBoard[15] = chBox16;
            KeyBoard[16] = chBox17;
            KeyBoard[17] = chBox18;
            KeyBoard[18] = chBox19;
            KeyBoard[19] = chBox20;
            KeyBoard[20] = chBox21;
            KeyBoard[21] = chBox22;
            KeyBoard[22] = chBox23;
            KeyBoard[23] = chBox24;
            KeyBoard[24] = chBox25;
            KeyBoard[25] = chBox26;
            KeyBoard[26] = chBox27;
            KeyBoard[27] = chBox28;
            KeyBoard[28] = chBox29;
            KeyBoard[29] = chBox30;
            KeyBoard[30] = chBox31;
            KeyBoard[31] = chBox32;
            KeyBoard[32] = chBox33;
            KeyBoard[33] = chBox34;
            KeyBoard[34] = chBox35;
            KeyBoard[35] = chBox36;
            KeyBoard[36] = chBox37;
            KeyBoard[37] = chBox38;
            KeyBoard[38] = chBox39;
            KeyBoard[39] = chBox40;
            KeyBoard[40] = chBox41;
            KeyBoard[41] = chBox42;
            KeyBoard[42] = chBox43;

            for (int i = 0; i < ListSim.Length; i++)
                KeyBoard[i].Text = Convert.ToString(ListSim[i]);
        }

        int lenText = 80;   // длина текса для задания
        private void Begin_btn_Click(object sender, EventArgs e)
        {
            // сформировать строку
            Morse.Text = getString();
            if (Morse.Text == "")
                return;

            // установить скорость
            Morse.speed = Convert.ToInt32(speed_domain.Text);

            // получить код Морзе
            Morse.SetCode();

            // переход на новую форму
            Hide();
            begin f = new begin();
            f.ShowDialog();
            Close();
        }

        /// <summary>
        /// Получить строку на основе выбранныхх символов.
        /// </summary>
        private string getString()
        {
            Random rnd = new Random();

            string enCheckBox = "";     // строка выбранными символами
            // сформировать строку с выбранными символами
            for (int i = 0; i < KeyBoard.Length; i++)
                if (KeyBoard[i].Checked)
                    enCheckBox += KeyBoard[i].Text;

            // символы не были выбраны
            if (enCheckBox == "")
                return "";

            string Text = "";           // текст задания
            int CNTspace = 0;           // каждый 4 сим. - пробел
            int CNTline_feed = 0;       // каждый 15 сим - \n
            for (int i = 0; i < lenText; i++)
            {
                if (CNTline_feed == 15)
                {
                    Text += "\n";
                    CNTspace = 0;
                    CNTline_feed = 0;
                }
                else if (CNTspace == 3)
                {
                    Text += " ";
                    CNTspace = 0;
                }
                else
                {
                    // получить случайный символ
                    char rndSim = enCheckBox[rnd.Next(0, enCheckBox.Length)];
                    Text += rndSim;

                    CNTspace++;
                    CNTline_feed++;
                }
            }

            return Text;
        }
    }
}
