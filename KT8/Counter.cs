using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT8
{

    /// <summary>
    /// Счетчик
    /// </summary>
    public  class Counter
    {
        private int count = 0;

        /// <summary>
        /// Обьявляем конструктор класса с параметрами  Timer timer 
        /// </summary>
        /// <param name="timer"></param>
        public Counter(Timer timer)
        {

            //Рекурсивно вызываем метод событиямм оно будет вызвана
            timer.Tick += Timer_Tick;
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            count++;
            Console.WriteLine("Текущее значение счетчика из Counter: " + count);
        }
    }
}
