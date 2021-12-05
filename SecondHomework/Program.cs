using System;
using System.Collections.Generic;

namespace SecondHomework
{
    class Program
    {
        static void executeFirst()
        {
            int count;
            //Console.WriteLine("Case 1");
            Console.WriteLine("Hur många vi ar som ska gå på bio?");
            if (!int.TryParse(Console.ReadLine(), out count))
            {
                Console.WriteLine("Invalid number of people entered. Try again.");
            }
            else
            {
                int totalCost = 0;
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine($"Enter the age of person {i + 1} - ");
                    int age = getAge();
                    int price = findTicketPriceBasedOnAge(age);
                    totalCost += price;
                }

                Console.WriteLine($"Total Number of people: {count}");
                Console.WriteLine($"Total Ticket price: {totalCost}");
            }

        }

        static void executeSecond()
        {
            Console.WriteLine("Please enter some text");
            string someText = Console.ReadLine();
            for (int i = 1; i <= 10; i++)
            {
                Console.Write($" {i}. {someText}");
                // add comma for all but last repetition. 
                if (i != 10)
                    Console.Write(",");
                else
                    Console.WriteLine("");
            }
        }
        static void executeThird()
        {
            Console.WriteLine("Enter a sentence with atleast three words.");
            string sentence = Console.ReadLine();
            //check for nulls and empties..
            if (sentence == null || sentence.Equals(String.Empty) || sentence.Trim().Equals(String.Empty))
            {
                Console.WriteLine("Invalid input.");
                return;
            }
            List<string> words = new List<string>();

            string[] wordArray = sentence.Split(' '); //split based on space
            for (int i = 0; i < wordArray.Length; i++)
            {

                string word = wordArray[i].Trim(); //remove leading and trailing whitespaces
                if (!(word == null || word.Equals(String.Empty))) //skip multiple whitespace and empty strings as words. 
                {
                    words.Add(word); //add trimed and valid words in list
                }

            }
            //Again check for atleast three words after trimming whitespaces.
            if (words.Count < 3)
                Console.WriteLine("Invalid sentence. Must contains atleast three words.");
            else
                Console.WriteLine($"Third word is {words[2]}");

        }
        static int getAge()
        {
            int age;

            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Pleae enter a valid age");
            }
            return age;
        }

        static int findTicketPriceBasedOnAge(int age)
        {
            if (age <= 5)
            {
                Console.WriteLine("Free for children under 5");
                return 0;
            }
            else if (age >= 100)
            {
                Console.WriteLine("Free for seniors over 100");
                return 0;
            }
            else if (age <= 20)
            {
                Console.WriteLine("Ungdom pris: SEK 80");
                return 80;
            }
            else if (age >= 64)
            {
                Console.WriteLine("Pensionär pris: SEK 90");
                return 90;
            }
            else
            {
                Console.WriteLine("Standardpris: SEK 120");
                return 120;
            }
        }


        static void mainMenu()
        {
            Console.WriteLine("You have reached the main menu.");
            Console.WriteLine("Enter choice to continue...");

            do
            {
                Console.WriteLine("Enter 0 for Exiting program...");
                Console.WriteLine("Enter 1 for cinema ticket price");
                Console.WriteLine("Enter 2 for Repeat string 10 times");
                Console.WriteLine("Enter 3 for printing third word in a sentence");
                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Pleae enter a valid choice");
                }
                else
                {
                    switch (choice)
                    {
                        case 0:
                            Console.WriteLine("Exiting..");
                            Environment.Exit(0);
                            break;
                        case 1:
                            executeFirst(); 
                            break;
                        case 2:
                            //Console.WriteLine("Case 2");
                            executeSecond();
                            break;
                        case 3:
                            executeThird();
                            break;
                        default:
                            Console.WriteLine("Please enter a valid choice");
                            break;

                    }

                }

            } while (true);
        }

        static void Main(string[] args)
        {
            mainMenu();
        }
    }
}