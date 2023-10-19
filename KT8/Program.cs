namespace KT8
{
    class Program
    {
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