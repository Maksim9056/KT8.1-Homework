using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT8
{
    /// <summary>
    /// Часы
    /// </summary>
    public   class Clock
    {
        /// <summary>
        /// Обьявляем конструктор класса с параметрами  Timer timer 
        /// </summary>
        /// <param name="timer"></param>
        public Clock(Timer timer)
        {
            //Рекурсивно вызываем метод событиями
            timer.Tick += Timer_Tick;
        }



        private void Timer_Tick(object sender, EventArgs e)
        {
            Console.WriteLine("Clock :" + DateTime.Now.ToShortTimeString());
        }
    }
}
