using System;

namespace AboutMe
{
    class Program
    {
        public static int counter = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a game. Try to guess some things about me.");
            
            Console.WriteLine("Do I prefer dogs or cats?");
            string ans1 = Console.ReadLine();
            Console.WriteLine(CatsOrDogs(ans1));
            
            Console.WriteLine("How old am I?");
            try
            {
               int ans2 = Convert.ToInt32(Console.ReadLine());
               MyAge(ans2);
            }
            catch
            {
                Console.WriteLine("Wrong! That's not a number");
            }

            Console.WriteLine("Is my hair blonde? Yes or No.");
            string ans3 = Console.ReadLine();
            Console.WriteLine($"That is {MyHair(ans3)}");

            Console.WriteLine("What Color is my car?");
            string ans4 = Console.ReadLine();
            Console.WriteLine(CarColor(ans4));

            Console.WriteLine("What's my favorite color?");
            Console.WriteLine("1. Aquamarine Blue");
            Console.WriteLine("2. Gunmetal Gray");
            Console.WriteLine("3. Pink");
            string ans5 = Console.ReadLine();
            Console.WriteLine($"{FavColor(ans5)}");

            Console.WriteLine($"The end. Your final score was {counter}");
            
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

        static string CatsOrDogs (string ans)
        {
            if (ans.ToLower() == "dogs")
            {
                counter++;
                return "Correct";
            }
            else
                return "Incorrect";
        }
        
        static void MyAge (int guess)
        {
            if (guess == 28)
            {
                counter++;
                Console.WriteLine("Impressive, correct on the first guess!");
            }
            else
                Console.WriteLine($"Incorrect, the answer was 28. Your guess was {AgeDifference(guess)} years off.");
        }

        static int AgeDifference (int ans)
        {
                return Math.Abs(ans - 28);
        }

        static bool MyHair (string ans)
        {
            if (ans.ToLower() == "no")
            {
                counter++;
                return true;
            }
            else
                return false;
        }

        static string CarColor(string ans)
        {
            if (ans.ToLower() == "silver")
            {
                counter++;
                return "Correct";
            }
            else
                return "Incorrect. The answer is Silver.";
        }

        static string FavColor(string ans)
        {
            if (ans == "2" || ans == "Gunmetal Gray")
            {
                counter++;
                return "That's correct!";
            }
            else
                return "Incorrect. The answer was 2. Gunmetal Gray.";
        }

    }
}
