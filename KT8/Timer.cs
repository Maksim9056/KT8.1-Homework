using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KT8
{


    /// <summary>
    /// Таймер
    /// </summary>
   public  class Timer
    {

        /// <summary>
        /// Событие
        /// </summary>
        public event EventHandler Tick;

        public void Start()
        {
            while (true)
            {
                Thread.Sleep(1000); // Приостанавливаем выполнение на 1 секунду
                OnTick(); // Вызываем событие Tick
            }
        }

        /// <summary>
        /// Метод
        /// </summary>
        protected virtual void OnTick()
        {
            Tick?.Invoke(this, EventArgs.Empty);
        }
    }
}
