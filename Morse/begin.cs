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
using System.Threading;
using System.Diagnostics;

namespace Morse
{
    public partial class begin : Form
    {
        string userCode;    // Морзе код, введенный пользователем
        
        // Создать новый поток
        Thread audioThread = new Thread(new ThreadStart(Morse.PlayMorse));
        // Измерение времени нажатия клавиши
        Stopwatch sw = new Stopwatch();
        public begin()
        {
            InitializeComponent();
            this.MaximizeBox = false;

            // Вывести текст
            Task_label.Text = Morse.Text;

            userCode = "";

            this.KeyDown += new KeyEventHandler(Code_KeyDown);
            this.KeyUp += new KeyEventHandler(Code_KeyUp);

            audioThread.Start(); // запускаем поток
            check_tread.Start();
        }

        void Code_KeyUp(object sender, KeyEventArgs e)
        {
            sw.Stop();
            // истекшее время
            long Elapsed = sw.ElapsedMilliseconds;
            if (Elapsed > Morse.timeDOP)
            {
                userCode += '–';
            }
            else
            {
                userCode += '*';
            }
            Test_label.Text = userCode;
        }

        void Code_KeyDown(object sender, KeyEventArgs e)
        {
            if (!sw.IsRunning)
            {
                sw = new Stopwatch();
                sw.Start();
            }
        }

        private void begin_Load(object sender, EventArgs e)
        {

        }

        private void ComeBeck_btn_Click(object sender, EventArgs e)
        {
            audioThread.Abort();
            sw.Stop();

            Hide();
            trening f = new trening();
            f.ShowDialog();
            Close();
        }

        /// <summary>
        /// Проверка завершения потока
        /// </summary>
        private void check_tread_Tick(object sender, EventArgs e)
        {
            // если поток завершен -> проверить на ошибки
            if (!audioThread.IsAlive)
            {
                Task_label.Text = "Da";
            }
        }
    }
}
