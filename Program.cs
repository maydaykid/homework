using System;

namespace альбом
{
    class Program
    {
        static void Main(string[] args)
        {
            int allPic = 52;
            int strings = allPic / 3;
            int picLeft = allPic % 3;
            Console.WriteLine("В альбоме " + strings + " заполененных рядов, " + picLeft + " картинок осталось сверх меры.");
            Console.ReadKey();
        }
    }
}
