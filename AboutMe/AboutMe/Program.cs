using System;

namespace AboutMe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a game. Try to guess some things about me.");

            Console.WriteLine("Do I prefer dogs or cats?");
            string ans1 = Console.ReadLine();
            Console.WriteLine(DogsCats(ans1));
            
            Console.WriteLine("How old am I?");
            try
            {
               int ans2 = Convert.ToInt32(Console.ReadLine());
               MyAge(ans2);
            }
            catch (Exception e)
            {
                Console.WriteLine("Wrong! That's not a number");
            }


            // dogs or cats? 
            // yes or no - is my hair black?
            // my age > too low too high? chances?
            // what color is my car? - boolean
            // Multiple choice? favotire color


            // cities I've lived in? ---- maybe

            //hints?

            // return string somehow?
            // correct number checkerr- return int

        }

        static string DogsCats (string ans)
        {
            if (ans == "dogs")
                return "Correct";
            else
                return "Incorrect";
        }

        static void MyAge (int guess)
        {
            if (guess == 28)
            {
                Console.WriteLine("Impressive, correct on the first guess!");
            }
            else
            {
                Console.WriteLine($"Incorrect, the answer was 28. Your guess was {AgeDifference(guess)} years off.");
            }
        }

        static int AgeDifference (int ans)
        {
                return Math.Abs(ans - 28);
        }
        
    }
}
