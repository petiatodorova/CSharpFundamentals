using System;
using System.Collections.Generic;

public class ReverseComparer : IComparer<string>
{
    public int Compare(string x, string y)
    {
        // Compare y and x in reverse order.
        return y.CompareTo(x);
    }
}

public class Example
{
    public static void Main()
    {
        string[] dinosaurs = {
            "Seismosaurus",
            "Chasmosaurus",
            "Coelophysis",
            "Mamenchisaurus",
            "Caudipteryx",
            "Cetiosaurus"  };

        int[] dinosaurSizes = { 40, 5, 3, 22, 1, 18 };

        

        //************************

        //ReverseComparer rc = new ReverseComparer();

        //Console.WriteLine("\n{Sort(dinosaurs, dinosaurSizes, rc)}");
        //Array.Sort(dinosaurs, dinosaurSizes, rc);

        //Console.WriteLine();
        //for (int i = 0; i < dinosaurs.Length; i++)
        //{
        //    Console.WriteLine("{0}: up to {1} meters long.",
        //        dinosaurs[i], dinosaurSizes[i]);
        //}

        //************************

        Console.WriteLine("\nSort(dinosaurs, dinosaurSizes, 3, 3)");
        Array.Sort(dinosaurs, dinosaurSizes, 3, 3);

        //Console.WriteLine();
        //for (int i = 0; i < dinosaurs.Length; i++)
        //{
        //    Console.WriteLine("{0}: up to {1} meters long.",
        //        dinosaurs[i], dinosaurSizes[i]);
        //}

        //************************

        //Console.WriteLine("\nSort(dinosaurs, dinosaurSizes, 3, 3, rc)");
        //Array.Sort(dinosaurs, dinosaurSizes, 3, 3, rc);

        //Console.WriteLine();
        //for (int i = 0; i < dinosaurs.Length; i++)
        //{
        //    Console.WriteLine("{0}: up to {1} meters long.",
        //        dinosaurs[i], dinosaurSizes[i]);
        //}
    }
}