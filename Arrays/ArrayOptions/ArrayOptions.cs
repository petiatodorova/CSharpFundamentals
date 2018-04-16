using System;
using System.Linq;

namespace ArrayOptions
{
    class ArrayOptions
    {
        static void Main(string[] args)
        {
            string[] stringArray1 = Console
                .ReadLine()
                .Split(' ')
                .ToArray();

            //string[] stringArray2 = Console
            //    .ReadLine()
            //    .Split(' ')
            //    .ToArray();

            //double[] intArray = Console
            //    .ReadLine()
            //    .Split(' ')
            //    .Select(double.Parse)
            //    .ToArray();




            ////************************************************************************************************
            ////!!! Променя масива и го връща Reverse масива
            //Array.Reverse(stringArray1);
            //Console.WriteLine($"{string.Join(" ", stringArray1)}");




            ////************************************************************************************************
            ////!!! Променя масива и го връща Reverse от 2-ра поз., count 4
            ////Array.Reverse(stringArray1, 2, 4);
            //Console.WriteLine($"{string.Join(" ", stringArray1)}");





            ////************************************************************************************************
            ////!!! Променя масива и го връща като нулира елементите му от индекс 2, с дължина 3
            //Array.Clear(stringArray1, 2, 3);
            //Console.WriteLine($"{string.Join(" ", stringArray1)}");




            ////************************************************************************************************
            ////Променя масив stringArray2, като копира 3 елемента от индекс 2 на масив 1 в масив 2, от индекс 4 натам
            ////Вземи от Array1 ot индекс 2 3 елемента и ги премести в Array2 от позиция 4, като го промениш трайно

            //Array.ConstrainedCopy(stringArray1, 2, stringArray2, 4, 3);
            //Console.WriteLine($"{string.Join(" ", stringArray2)}");

            //stringArray1  -->   a b c d e f g h
            //stringArray2  -->   1 2 3 4 5 6 7 8 9
            //stringArray1  -->   a b c d e f g h
            //stringArray2  -->   1 2 3 4 c d e 8 9




            //************************************************************************************************
            //Прави нов масив array2 от int-ove, в който Convert double to int като Math.Flooring
            //Пример:
            //2.6 3.6 7.7 8.9
            //array2 > 2 | intArray > 2.6
            //array2 > 3 | intArray > 3.6
            //array2 > 7 | intArray > 7.7
            //array2 > 8 | intArray > 8.9

            //int[] array2 = Array.ConvertAll(intArray,
            //element => (int)element);
            //for (int i = 0; i < array2.Length; i++)
            //{
            //    Console.WriteLine($"array2  >  {array2[i]} | intArray  >  {intArray[i]}");
            //}




            //************************************************************************************************
            //Прави нов масив arrayTest и в първите му 3 елемента копира първите 3 от stringArray1, а останалите са null
            //string[] arrayTest = new string[stringArray1.Length];
            //Array.Copy(stringArray1, arrayTest, 3);
            //Console.WriteLine($"{string.Join(" ", arrayTest)}");
            //a b c d e f g
            //a b c "null" "null" "null" "null"

            //string[] arrayTest = new string[4];
            //Array.Copy(stringArray1, arrayTest, 4);
            //Console.WriteLine($"{string.Join(" ", arrayTest)}");

            ////Вземи от 2-ра позиция на stringArray1 3 елемента и ги изкопирай в arrayTest, като започнеш от 4-та
            //string[] arrayTest = new string[stringArray1.Length];
            //Array.Copy(stringArray1, 2, arrayTest, 4, 3);
            //Console.WriteLine($"{string.Join(" ", arrayTest)}");




            ////************************************************************************************************
            ////Проверява дали масива stringArray1 има елемент с някакво условие
            //bool arrayHasElement = Array.Exists(stringArray1, element => element.StartsWith("M"));
            //Console.WriteLine($"{arrayHasElement}");



            ////************************************************************************************************
            ////Реже последните елементи и го оразмерява до 3 елемента
            //Array.Resize(ref stringArray1, 3);
            //Console.WriteLine($"{string.Join(" ", stringArray1)}");

            ////************************************************************************************************
            ////Обръща реда на елементите в отрязък от индекс 5, с дължина 4
            //Array.Reverse(stringArray1, 5, 4);
            //Console.WriteLine($"{string.Join(" ", stringArray1)}");




            ////************************************************************************************************
            ////Сортира елементите в отрязък от индекс 2, с дължина 5
            //Array.Sort(stringArray1, 2, 5);
            //Console.WriteLine($"{string.Join(" ", stringArray1)}");


            ////************************************************************************************************
            ////Връща общите елементи между 2 масива
            //Console.WriteLine($"{string.Join(", ", stringArray1.Intersect(stringArray2))}");


            Console.WriteLine($"{string.Join(" ", stringArray1.Skip(3).ToArray())}");
            Console.WriteLine($"{string.Join(" ", stringArray1.Take(3))}");
            Console.WriteLine($"{}");
            

        }
    }
}
