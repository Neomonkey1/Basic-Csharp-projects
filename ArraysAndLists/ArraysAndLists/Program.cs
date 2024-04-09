using System;
using System.Collections.Generic;


    class Program
    {
        static void Main()
        {
        
        // How to write a List
        List<int> intList = new List<int>();
        intList.Add(4);
        intList.Add(10);
        intList.Remove(10);

        List<string> stringList = new List<string>();
        stringList.Add("Hello");
        stringList.Add("World!");
        stringList.Remove("World!");

        Console.WriteLine(intList[0]);
        Console.WriteLine(stringList[0]);

        //// Basic way to write an Array ( In this way you need to preset how big the array can be)
        //int[] numArray = new int[5];
        //numArray[0] = 5;
        //numArray[1] = 2;
        //numArray[2] = 10;
        //numArray[3] = 200;
        //numArray[4] = 5000;

        //Console.WriteLine(numArray[3]);

        //// An easier way to write an Array ( This way you do not need to preset how big the array is)
        //int[] numArray1 = new int[] { 5, 2, 10, 200, 5000, 600, 2300 };
        //Console.WriteLine(numArray1[3]);

        //// Simplest way to write an Array ( This way you do not need to preset how big the array is)
        //int[] numArray2 = { 5, 2, 10, 200, 5000, 600, 2300 };
        //Console.WriteLine(numArray2[3]);
        ////  This is how you would rewrite a value in the array.
        //numArray2[5] = 650;
        //Console.WriteLine(numArray2[5]);



        Console.ReadLine();
        }
    }

