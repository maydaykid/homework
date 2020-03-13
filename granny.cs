using System;

namespace бабульки
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfPeople;
            int timeOfCure = 10;
            int time;
            int hour;
            int minute;

            Console.WriteLine("Сколько людей в очереди?");
            numberOfPeople = Convert.ToInt32(Console.ReadLine());

            time = numberOfPeople * timeOfCure;

            hour = time / 60;
            minute = time % 60;

            Console.WriteLine("Вам придётся подождать " + hour + " часов и " + minute + " минут. Смиритесь.");
            Console.ReadKey();
        }
    }
}
