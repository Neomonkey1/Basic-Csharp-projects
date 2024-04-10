using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
        //  Assignment part 1
       
        //  Making a string Array
        string[] stringArray = {"Day one was ", "Day two was " , "Day three was ", "Day four was " };
        
        //  Asking the user for input 
        Console.WriteLine("Hello, How was your day today?");
        string userInput1 = Console.ReadLine();

        //  Making a FOR loop to iterate through the Array and added the user input to each value.
        for (int i = 0; i < stringArray.Length; i++)
        {
            stringArray[i] += userInput1;
        }

        //  Using FOREACH loop to print the updated Array to the console
        foreach (string userArray in stringArray)
        {
            Console.WriteLine(userArray);
        }
        //  End of Assignment part 1

        //  Assignment part 2

        ////  infinite loop 
        //int a = 0;
        //while (a < 5)
        //{
        //    Console.WriteLine(a);
        //}

        //  Fixed infinite loop by adding the incerment to element
        int a = 0;
         while (a < 5)
        {
            Console.WriteLine(a);
            a++;
        }
        //  End of Assignment part 2

        //  Assignment part 3

        //  Making a loop with < to iterate while variable int is less than 5
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(i);
        }

        //  Making a loop with <= to iterate while variable int is less than or equal to 30
        for (int i = 25; i <= 30; i++)
        {
            Console.WriteLine(i);
        }
        //  End of Assignment part 3

        //  Assignment part 4

        //  Making a string List and bool
        List<string> daysList = new List<string>() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        bool dayFound = false;
        
        //  Using WHILE loop to keep asking for input till it is a match and bool = true
        while (!dayFound)
        {
            //  Asking user to pick a day
            Console.WriteLine("Pick a day of the week.");
            string userDay = Console.ReadLine();

            //  Using FOR loop to iterate through List for a match with user input than use break to end program
            for (int i = 0; i < daysList.Count; i++)
            {
                if (daysList[i].Contains(userDay))
                {
                    Console.WriteLine($"That day is in index {i}");
                    dayFound = true;
                    break;
                }
            }
            //  Using IF to let user know input they gave has no match and to try again
            if (!dayFound)
            {
                Console.WriteLine($"{userDay} is not in the list try again. Check spelling and use capital letter.");
            }
        }
        //  End of Assignment part 4

        //  Assignment part 5

        //  Making a string List and bool
        List<string> fruitList = new List<string>() {"apple", "banana", "banana", "cherry", "orange", "apple", "mango", "orange" };
        bool fruitFound = false;

        //  Asking for user to pick a fruit
        Console.WriteLine("Pick a fruit.");
        string userFruit = Console.ReadLine();

        //  Using FOR loop to iterate through all the List for a match/matches with user input.
        for (int i = 0; i < fruitList.Count; i++)
        {
            if (fruitList[i].Contains(userFruit))
            {
                Console.WriteLine($"{userFruit} is at index {i}.");
                fruitFound = true;
            }
        }
        //  Using IF statement to let user know input they gave is not in the list.
        if (!fruitFound)
        {
            Console.WriteLine($"{userFruit} is not in the list sorry.");
        }
        //  End of Assignment part 5

        //  Assignment part 6

        //  Making a string List with names in the List and making another List for newNames 
        List<string> names = new List<string>() {"Adam", "Barbie", "Lisa", "John", "Barbie" };
        List<string> newNames = new List<string>();

        //  Using FOREACH loop to iterate through each string in the List, then using IF and ELSE statement,
        //  IF statement will check if string List newNames has a string in it, if it does it will print to console.
        //  Otherwise if no string it will send the string to ELSE statement.
        //  ELSE statement will take string and add to string List newNames then print to console.
        foreach (string name in names)
        {
            if (newNames.Contains(name))
            {
                Console.WriteLine($"{name} name is a duplicate.");
            }
            else
            {
                newNames.Add(name);
                Console.WriteLine($"{name} name is unique.");
            }
        }
        //  End of Assignment part 6

        Console.ReadLine();
        }
    }

