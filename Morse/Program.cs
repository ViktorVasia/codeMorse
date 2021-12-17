using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Morse
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new main_menu());
        }
    }

    static class Morse
    {
        public static int speed { get; set; }           // скорость [зн. в мин.]
        public static string Text { get; set; }         // текст задания
        public static string Code { get; set; }         // код Морзе
        public static int timeDOP { get; set; }         // длительность одной точки [мс.]
        public static int countErr { get; set; }        // Кол-во ошибок
        public static string audioCode { get; set; }    // воспроизведенный код
        
        public static void SetCode()
        {
            string Text_in = Morse.Text;
            char[] characters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И',
                                                        'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                        'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь',
                                                        'Э', 'Ю', 'Я', '1', '2', '3', '4', '5', '6', '7',
                                                        '8', '9', '0' };

            string[] codeMorse = new string[] { "*–", "–***", "*––", "––*",
                                                        "–**", "*", "***–", "––**",
                                                        "**", "*–––", "–*–", "*–**",
                                                        "––", "–*", "–––", "*––*",
                                                        "*–*", "***", "–", "**–",
                                                        "**–*", "****", "–*–*",
                                                        "–––*", "––––", "−−*−",
                                                        "*--*-*",//ъ
                                                        "−*−−", "−**−", "**−**",
                                                        "**−−", "*−*−", "*−−−−",
                                                        "**−−−", "***−−", "****−",
                                                        "*****", "−****", "−−***",
                                                        "−−−**", "−−−−*", "−−−−−" };

            Text_in = Text_in.ToUpper();
            string code = "";
            int index;

            foreach (char c in Text_in)
            {
                if (c != ' ' & c != '\n')
                {
                    index = Array.IndexOf(characters, c);
                    code += codeMorse[index] + ' ';
                }
            }
            code = code.Remove(code.Length - 1);

            Morse.Code = code;
        }

        public static string SimConvertToMorse(char symbol)
        {
            string Morse = "";
            char[] characters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И',
                                                        'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                                        'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ъ', 'Ы', 'Ь',
                                                        'Э', 'Ю', 'Я', '1', '2', '3', '4', '5', '6', '7',
                                                        '8', '9', '0' };
            string[] codeMorse = new string[] { "*–", "–***", "*––", "––*",
                                                        "–**", "*", "***–", "––**",
                                                        "**", "*–––", "–*–", "*–**",
                                                        "––", "–*", "–––", "*––*",
                                                        "*–*", "***", "–", "**–",
                                                        "**–*", "****", "–*–*",
                                                        "–––*", "––––", "−−*−",
                                                        "*--*-*",//ъ
                                                        "−*−−", "−**−", "**−**",
                                                        "**−−", "*−*−", "*−−−−",
                                                        "**−−−", "***−−", "****−",
                                                        "*****", "−****", "−−***",
                                                        "−−−**", "−−−−*", "−−−−−" };

            for (int sim = 0; sim < characters.Length; sim++)
            {
                if (symbol == characters[sim])
                {
                    Morse = codeMorse[sim];
                    return Morse;
                }
            }

            return Morse;
        }

        /// <summary>
        /// Поток воспроизведения кода Морзе
        /// </summary>
        public static void PlayMorse()
        {
            Thread.Sleep(2000);
            Morse.audioCode = "";
            for (int sim = 0; sim < Morse.Code.Length; sim++)
            {
                char playSim = Morse.Code[sim];
                if (playSim == ' ')
                    Thread.Sleep(Morse.timeDOP);
                else if (playSim == '*')
                {
                    Console.Beep(888, Morse.timeDOP);
                    Morse.audioCode += sim;
                    // задержка между символами
                    Thread.Sleep(Morse.timeDOP);
                }
                else if (playSim == '−')
                {
                    Console.Beep(888, Morse.timeDOP * 3);
                    Morse.audioCode += sim;
                    // задержка между символами
                    Thread.Sleep(Morse.timeDOP);
                }
                // Записано без пробела, т.к. я еще не придумал
                // как отследить пробел от ввода пользователя
                //Morse.audioCode += sim;
            }
            Thread.Sleep(2000);
        }
    }
}
