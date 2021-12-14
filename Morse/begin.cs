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
    public partial class begin : Form
    {
        bool keyMax;        // true - тире, false - точка
        string userCode;    // Морзе код, введенный пользователем
        string audioCode;   // Морзе код, программный
        int indexMorseCode; // воспроизводить каждый сим. в строке Morse
        public begin()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            // Вывести текст
            Task_label.Text = Morse.Text;
            // Установить переодичность таймеров
            audio_timer.Interval = 60000 / Morse.speed;
            key_timer.Interval = 160;
            endwrite.Interval = 1000;

            keyMax = false;
            userCode = "";
            audioCode = "";
            indexMorseCode = 0;

            this.KeyDown += new KeyEventHandler(Code_KeyDown);
            this.KeyUp += new KeyEventHandler(Code_KeyUp);

            // запустить таймер
            audio_timer.Start();
        }

        void Code_KeyUp(object sender, KeyEventArgs e)
        {
            if (!keyMax)
            {
                key_timer.Stop();
                userCode += '*';
            }
            else 
                keyMax = false;
            Test_label.Text = userCode;
        }

        void Code_KeyDown(object sender, KeyEventArgs e)
        {
            key_timer.Start();
        }

        private void begin_Load(object sender, EventArgs e)
        {

        }

        private void ComeBeck_btn_Click(object sender, EventArgs e)
        {
            audio_timer.Stop();

            Hide();
            trening f = new trening();
            f.ShowDialog();
            Close();
        }

        private void key_timer_Tick(object sender, EventArgs e)
        {
            // сработает, если длительность нажатия
            // клавиши больше заданного интервала
            keyMax = true;      // уведомить о длительном нажатии
            key_timer.Stop();   // остановить таймер

            userCode += '–';
        }

        private void audio_timer_Tick(object sender, EventArgs e)
        {
            // воспроизвести соответствующий звувк
            char sim = Morse.Code[indexMorseCode];
            if (sim == '*')
            {
                Console.Beep(1000, Morse.timeDOP);
                audioCode += '*';
            }
            else
            {
                Console.Beep(1000, Morse.timeDOP*3);
                audioCode += '–';
            }

            indexMorseCode++;
            // если воспроизведена вся строка
            if (indexMorseCode >= Morse.Code.Length)
            {
                indexMorseCode = 0;
                audio_timer.Stop();
                endwrite.Start();
            }
            // если сл. символ пробел - пропустить его
            else if (Morse.Code[indexMorseCode] == ' ')
            {
                // пропустить этот символ
                indexMorseCode++;
            }
        }

        private void endwrite_Tick(object sender, EventArgs e)
        {
            // посчитать кол-во ошибок
            int countErr;
            countErr = audioCode.Length - userCode.Length;
            for (int sim = 0; sim < userCode.Length; sim++)
                if (userCode[sim] != audioCode[sim])
                    countErr++;
            
            endwrite.Stop();

            Morse.countErr = countErr;

            Hide();
            endMorse f = new endMorse();
            f.ShowDialog();
            Close();
        }
    }
}
