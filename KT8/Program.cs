namespace KT8
{
    class Program
    {
        /// <summary>
        /// Напишите класс Timer, который имеет событие типа EventHandler с именем Tick, которое возникает каждую секунду. 
        /// Затем напишите класс Clock, 
        /// который подписывается на это событие и выводит на консоль текущее время при каждом его возникновении. 
        /// Затем напишите класс Counter, который также подписывается на это событие и увеличивает свое значение на единицу при каждом его возникновении. 
        /// Продемонстрируйте работу этих классов в методе Main.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Обьявляем класс Timer
            Timer timer = new Timer();
            //Обьявляем класс Clock и параметр от класса Timer  переменую timer
            Clock clock = new Clock(timer);
            //Обьявляем класс Counter и параметр от класса Timer  переменую timer
            Counter counter = new Counter(timer);
            //Запускаем таймер
            timer.Start();
            Console.ReadLine();
        }
    }
}