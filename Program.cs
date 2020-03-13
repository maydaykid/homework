using System;

namespace строки
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            string age;
            string zodiac;
            string work;

            Console.WriteLine("Как вас зовут?");
            name = Console.ReadLine();

            Console.WriteLine("Сколько вам лет?");
            age = Console.ReadLine();

            Console.WriteLine("Кто вы по знаку зодиака?");
            zodiac = Console.ReadLine();

            Console.WriteLine("Какова ваша профессия?");
            work = Console.ReadLine();

            Console.WriteLine("Подтвердите введённую информацию: вас зовут " + name + ", вам " + age + " лет," +
                " вы " + zodiac + " по знаку зодиака и трудитесь на благо общества как " + work + ".");
            Console.ReadKey();
        }
    }
}
