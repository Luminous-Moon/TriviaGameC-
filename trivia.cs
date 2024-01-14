//14/01/2024 RADona
//Trivia questions from: https://blog.slido.com/trivia-questions/

using System;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            while (true)
            // Continue the game untill the user does want to anymore...
            //while loop from: https://stackoverflow.com/questions/33157523/how-to-allow-user-to-try-again-or-quit-console-program-in-c
        
            {

                Console.WriteLine("Let's play some trivia!");
                Console.WriteLine("Choose from one of the following categories: Movies, Food, History or General ");

                String category = Console.ReadLine();

                if (category == "Movies" || category == "movies")
                {
                    //if user selects Movies category
                    Console.WriteLine("Movie trivia selected!");
                    Console.WriteLine("3 questions. Can you get them all right?");

                    Console.WriteLine("1) Who played the title role in the movie Forrest Gump? \n A: Tom Hanks \n B: Tom Hiddleston \n C: Tom Hardy\n");
                    String answer1 = Console.ReadLine();

                    if (answer1 == "A" || answer1 == "a" || answer1 == "Tom Hanks")
                    {
                        Console.WriteLine("Correct!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong! Answer was Tom Hanks");
                    }


                    Console.WriteLine("2) What is the name of the main character in the movie The Matrix? \n A: Niall \n B: Neil\n C: Neo\n ");
                    String answer2 = Console.ReadLine();

                    if (answer2 == "C" || answer2 == "c" || answer2 == "Neo")
                    {
                        Console.WriteLine("Correct!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong! Answer was Neo");
                    }



                    Console.WriteLine("3) How many Oscars did Titanic win? \n A: 11 \n B: 14 \n C: 18\n ");
                    String answer3 = Console.ReadLine();

                    if (answer3 == "A" || answer3 == "a" || answer3 == "11")
                    {
                        Console.WriteLine("Correct!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong! Answer was 11");

                    }
                }
                else if (category == "Food" || category == "food")
                {
                    //if user selects Food category
                    Console.WriteLine("Food trivia selected!");
                    Console.WriteLine("3 questions. Can you get them all right?");
                    {

                        Console.WriteLine("1) In which Italian city was pizza first made? \n A: Naples \n B: Rome \n C: Palermo \n ");
                        String answer1 = Console.ReadLine();

                        if (answer1 == "A" || answer1 == "a" || answer1 == "Naples")
                        {
                            Console.WriteLine("Correct!");
                        }
                        else
                        {
                            Console.WriteLine("Wrong! Answer was Naples");

                        }

                        Console.WriteLine("2) Which country has the most Michelin starred restaurants?\n A: India \n B: France \n C: Japan \n ");
                        String answer2 = Console.ReadLine();

                        if (answer2 == "B" || answer2 == "b" || answer2 == "France")
                        {
                            Console.WriteLine("Correct!");
                        }
                        else
                        {
                            Console.WriteLine("Wrong! Answer was France");

                        }

                        Console.WriteLine("3) Which fast food restaurant has the most branches in the world? \n A: McDonalds \n B: Wendys \n C: Subway\n ");
                        String answer3 = Console.ReadLine();

                        if (answer3 == "c" || answer3 == "C" || answer3 == "Subway")
                        {
                            Console.WriteLine("Correct!");
                        }
                        else
                        {
                            Console.WriteLine("Wrong! Answer was Subway");

                        }

                    }
                }
                else if (category == "History" || category == "history")
                {
                    //if user selects History category
                    Console.WriteLine("History trivia selected!");
                    Console.WriteLine("3 questions. Can you get them all right?");
                    {

                        Console.WriteLine("1) In which year did the Berlin Wall fall?\n A: 1987 \n B: 1989 \n C: 1990 \n ");
                        String answer1 = Console.ReadLine();

                        if (answer1 == "B" || answer1 == "b" || answer1 == "1989")
                        {
                            Console.WriteLine("Correct!");
                        }
                        else
                        {
                            Console.WriteLine("Wrong! Answer was 1989");

                        }

                        Console.WriteLine("2) What is the modern name for the island formerly known as Van Diemens Land?\n A: The Isle of Wight \n B: Tasmania \n C: Hawaii  \n ");
                        String answer2 = Console.ReadLine();

                        if (answer2 == "B" || answer2 == "b" || answer2 == "Tasmania")
                        {
                            Console.WriteLine("Correct!");
                        }
                        else
                        {
                            Console.WriteLine("Wrong! Answer was Tasmania");

                        }

                        Console.WriteLine("3) How many times has the Mona Lisa been stolen?\n A: One\n B: Five\n C: Eight\n ");
                        String answer3 = Console.ReadLine();

                        if (answer3 == "A" || answer3 == "a" || answer3 == "One")
                        {
                            Console.WriteLine("Correct!");
                        }
                        else
                        {
                            Console.WriteLine("Wrong! Answer was One");

                        }

                    }
                }

                if (category == "General" || category == "general")
                {
                    //if user selects General category
                    Console.WriteLine("General trivia selected!");
                    Console.WriteLine("3 questions. Can you get them all right?");

                    Console.WriteLine("1) What is King Charles IIIs surname?\n A: Arthur\n B: Wales\n C: Mountbatten-Windsor\n");
                    String answer1 = Console.ReadLine();

                    if (answer1 == "C" || answer1 == "c" || answer1 == "Mountbatten-Windsor")
                    {
                        Console.WriteLine("Correct!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong! Answer was Mountbatten-Windsor");
                    }


                    Console.WriteLine("2) Which country drinks the most amount of coffee per person? \n A: Finland\n B: Italy \n C: Colombia \n ");
                    String answer2 = Console.ReadLine();

                    if (answer2 == "A" || answer2 == "a" || answer2 == "Finland")
                    {
                        Console.WriteLine("Correct!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong! Answer was Finland");
                    }



                    Console.WriteLine("3) How many times per day does the average American open their fridge?\nA: 5\nB: 22\nC: 33\n ");
                    String answer3 = Console.ReadLine();

                    if (answer3 == "C" || answer3 == "c" || answer3 == "33")
                    {
                        Console.WriteLine("Correct!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong! Answer was 33");

                    }
                }

                while (true) // Continue asking until a correct answer is given.
                {
                    Console.Write("Do you want to play again [Y/N]?");
                    string answer = Console.ReadLine().ToUpper();
                    if (answer == "Y")
                        break; // Exit the inner while-loop and continue in the outer while loop.
                    if (answer == "N")
                        return; // Exit the Main-method.
                }
            }

        }
    }
}
