using System;

namespace TheaThePhotographer
{
    class TheaThePhotographer
    {
        static void Main(string[] args)
        {
            //1000
            //1
            //50
            //1

            long numberOfPictures = long.Parse(Console.ReadLine());
            long filterTime = long.Parse(Console.ReadLine());
            double filterFactor = double.Parse(Console.ReadLine());
            long uploadTime = long.Parse(Console.ReadLine());

            long filteredPictures = (long)(Math.Ceiling((numberOfPictures * filterFactor) / 100));
            long filterTimeAllPictures = filterTime * numberOfPictures;
            long totalTime = filterTimeAllPictures + uploadTime * filteredPictures;

            long seconds = totalTime % 60;
            long minutes = (totalTime / 60) % 60;
            long hours = (totalTime / (60 * 60)) % 24;
            long days = totalTime / (60 * 60 * 24);

            //D1 Печата 1 цифра, D2 - 2 цифри
            Console.WriteLine($"{days:D1}:{hours:D2}:{minutes:D2}:{seconds:D2}");

        }
    }
}
