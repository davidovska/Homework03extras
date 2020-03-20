using System;

namespace Homework03extras
{
    class Program
    {
        static void Main(string[] args)
        {
            //            1.Write a C# Sharp program to find the sum of first 10 natural numbers
            //int num;
            //int sum = 0;
            //for (num = 1; num <= 10; num++)
            //{
            //    sum = sum + num;
            //}
            //Console.WriteLine("Sum = {0}", sum);
            //Console.ReadLine();


            //          2.Write a program in C# Sharp to read 10 numbers from keyboard and find their sum and average.

            //int sum = 0;
            //int[] num = new int[10];
            //Console.WriteLine("Enter any 10 numbers: ");
            //for (int i = 0; i < num.Length; i++)
            //{
            //    num[i] = int.Parse(Console.ReadLine());
            //    sum = sum + num[i];
            //}
            //Console.WriteLine("The sum of numbers is {0}", sum);
            //int aveg;
            //aveg = sum / 10;
            //Console.WriteLine("The avearge is {0}", aveg);
            //Console.ReadLine();

            ////          3.Declare and init array of 10 integers by your choise. 
            ////   Find maximum and minimum element in that array and their indexes.

            //int[] number = new int[10] { 22, 9, 88, 5, 55, 24, 22, 10, 2014, 45 };

            //int max = number[0];
            //int min = number[0];

            //for (int i = 0; i < number.Length; i++)
            //{
            //    if (number[i] >= max)
            //    {
            //        max = number[i];
            //    }
            //    if (number[i] <= min)
            //    {
            //        min = number[i];
            //    }
            //}

            //int indexOfMin = Array.IndexOf(number, min);
            //int indexOfMax = Array.IndexOf(number, max);

            //Console.WriteLine($"Minimum number in the array is {min} at index {indexOfMin}");
            //Console.WriteLine($"Maximum number in the array is {max} at index {indexOfMax}");

            //Console.ReadLine();


            //4.arrayWithDuplicates = [1, 4, 6, 3, 4, 5, 9, 3, 2, 9]
            //   Write a program in C# Sharp to count a total number of duplicate elements in arrayWithDuplicates

            //int[] arrayWithDuplicates = new int[] { 1, 4, 6, 3, 4, 5, 9, 3, 2, 9 };

            //int count = 0;

            //for (int i = 0; i < arrayWithDuplicates.Length; i++)
            //{
            //    for (int j = i + 1; j < arrayWithDuplicates.Length; j++)
            //    {
            //        if (arrayWithDuplicates[i] == arrayWithDuplicates[j])
            //        {
            //            count++;
            //            break;
            //        }
            //    }
            //}

            //Console.WriteLine($"Total number of duplicates in the array is {count}");
            Console.ReadLine();


            //  5. Write a program in C# Sharp to separate odd and even integers from the oddEvenArray in separate arrays

            int[] oddEvenArray = { 10, 23, 44, 123, 55, 52, 98, 99, 102, 103, 152, 49 };

            int[] evenArray = new int[] { };
            int[] oddArray = new int[] { };
            int index = 0;
            int counter = 0;

            for (int i = 0; i < oddEvenArray.Length; i++)
            {
                if (oddEvenArray[i] % 2 == 0)
                {
                    Array.Resize(ref evenArray, evenArray.Length + 1);
                    evenArray[index] = oddEvenArray[i];
                    index++;
                }
                else if (oddEvenArray[i] % 2 != 0)
                {
                    Array.Resize(ref oddArray, oddArray.Length + 1);
                    oddArray[counter] = oddEvenArray[i];
                    counter++;
                }
            }

            Console.WriteLine("My even array: ");
            foreach (var item in evenArray)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("My odd array: ");
            foreach (var item in oddArray)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();



            //6.Write a program in C# Sharp to read any Day Number in integer (from 1 to 7) and display on screen
            //   the day with strings.Example: user enters 1, you should print Monday.

            int dayNr;

            Console.Write("Input Day No : ");
            dayNr = Convert.ToInt32(Console.ReadLine());

            switch (dayNr)
            {
                case 1:
                    Console.Write("Monday \n");
                    break;
                case 2:
                    Console.Write("Tuesday \n");
                    break;
                case 3:
                    Console.Write("Wednesday \n");
                    break;
                case 4:
                    Console.Write("Thursday \n");
                    break;
                case 5:
                    Console.Write("Friday \n");
                    break;
                case 6:
                    Console.Write("Saturday \n");
                    break;
                case 7:
                    Console.Write("Sunday  \n");
                    break;
                default:
                    Console.Write("There is no such a day :-)");
                    break;
            }
                    Console.ReadLine();


            //7.userNames = ["user1", "user2", "user3"]
            //   passwords = ["first", "second", "third"]
            //   Write a program in C# Sharp to ask the user to enter a username. After that user should provide a password.
            //   Create a logic when user enters specific username to provide a correct password for that user, and when that
            //   happens you should print on the screen "You are logged in successfully".
            //   If username or password are invalid or don't correspond "Incorrect username or password" should be print on the screen and 
            //   repeat the proccess from begining while he / she doesn't input correct username and password.

            string[] userNames = { "user1", "user2", "user3" };
            string[] passwords = { "first", "second", "third" };

            while (true)
            {
                Console.WriteLine("Please enter your username:");
                string userInput = (Console.ReadLine());
                Console.WriteLine("Please enter your password:");
                string passInput = (Console.ReadLine());

                if (userInput == userNames[0] && passInput == passwords[0])
                {
                    Console.WriteLine("You are logged in successfully!");
                    break;
                }
                else if (userInput == userNames[1] && passInput == passwords[1])
                {
                    Console.WriteLine("You are logged in successfully!");
                    break;
                }
                else if (userInput == userNames[2] && passInput == passwords[2])
                {
                    Console.WriteLine("You are logged in successfully!");
                    break;
                }
                else
                {
                    Console.WriteLine("Incorrect username or password!");
                }
            }

            Console.ReadLine();

        }
    }

}
    

