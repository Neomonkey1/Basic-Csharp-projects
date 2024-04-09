using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayAndList_Submission
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Made string and int Array
            string[] fruitArray = { "Apple", "Banana", "Cherry", "Orange", "Watermelon" };
            int[] luckyNum = { 7, 1000, 77, 7000, 777, 21 };

            // Made string List
            List<string> stringList = new List<string>();
            stringList.Add("Ant");
            stringList.Add("Bear");
            stringList.Add("Cat");
            stringList.Add("Dog");
            stringList.Add("Fish");

            //  Asking user for input, convert input into int variable
            Console.WriteLine("Select a number between 0 - 4 for your mystery fruit!");
            int intFruit = Convert.ToInt32(Console.ReadLine());

            //  Using IF ELSE statement if user input is equal to or greater than 0 AND less than the Array length
            //  Console will print the IF statement with the number they input and the fruit of that index otherwise
            //  The console will print the ELSE statement with the number they input and message.
            if (intFruit >= 0 && intFruit < fruitArray.Length)
            {
                Console.WriteLine($"You picked number {intFruit}, Your mystery fruit is {fruitArray[intFruit]}! \n");
            }
            else
            {
                Console.WriteLine($"The number you picked {intFruit} is not between 0-4 so NO FRUIT for you! \n");
            }

            //  Asking user for input, convert input into int variable
            Console.WriteLine("Pick a number between 0 - 5 and get your LUCKY number!");
            int intLucky = Convert.ToInt32(Console.ReadLine());

            //  Using IF ELSE statement if user input is equal to or greater than 0 AND less than the Array length
            //  Console will print the IF statement with the number they input and the lucky number of that index otherwise
            //  The console will print the ELSE statement with the number they input and message.
            if (intLucky >= 0 && intLucky < luckyNum.Length)
            {
                Console.WriteLine($"You picked number {intLucky}, Your LUCKY number is {luckyNum[intLucky]}! \n");
            }
            else
            {
                Console.WriteLine($"The number you picked {intLucky} is not between 0-5 you very unLUCKY! \n");
            }


            //  Asking user for input, convert input into int variable
            Console.WriteLine("Pick a number between 0 - 4 to figure out which pet you should get.");
            int petString = Convert.ToInt32(Console.ReadLine());

            //  Using IF ELSE statement if user input is equal to or greater than 0 AND less than the List length
            //  Console will print the IF statement with the 'pet' of the index they input otherwise
            //  The console will print the ELSE statement with the number they input and message.
            if (petString >= 0 && petString < stringList.Count)
            {
                Console.WriteLine($"Base of your input, the pet you should get is a {stringList[petString]}! \n");
            }
            else
            {
                Console.WriteLine($"The number you picked {petString} means you can't follow instructions so you can't handle a pet not even an {stringList[0]}. \n");
            }


            Console.ReadLine();
        }
    }
}
