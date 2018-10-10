using System;

namespace AboutMe
{
    class Program
    {
        public static int counter = 0; //score tally

        static void Main(string[] args)
        {
            Console.WriteLine("Let's play a game. Try to guess some things about me.");
            
            //Question 1 - Type one of two answers
            Console.WriteLine("Do I prefer dogs or cats?");
            string ans = Console.ReadLine();
            Console.WriteLine(CatsOrDogs(ans));
            
            //Question 2 - Type a number
            Console.WriteLine("How old am I?");
            try //handle errors if a non-int is typed in
            {
               int ans2 = Convert.ToInt32(Console.ReadLine());
               MyAge(ans2);
            }
            catch
            {
                Console.WriteLine("Wrong! That's not a number");
            }

            //Question 3 - Yes or No
            Console.WriteLine("Is my hair blonde? Yes or No.");
            ans = Console.ReadLine();
            Console.WriteLine($"That is {MyHair(ans)}");

            //Question 4 - Type any guess
            Console.WriteLine("What Color is my car?");
            ans = Console.ReadLine();
            Console.WriteLine(CarColor(ans));

            //Question 5 - Multiple choice
            Console.WriteLine("What's my favorite color?");
            Console.WriteLine("1. Aquamarine Blue");
            Console.WriteLine("2. Gunmetal Gray");
            Console.WriteLine("3. Pink");
            ans = Console.ReadLine();
            Console.WriteLine($"{FavColor(ans)}");

            Console.WriteLine($"The end. Your final score was {counter}");
        }

        //Question 1 Method
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

        //Question 2 Method
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

        //Question 2 helper method to determine how far the guess was from the answer
        static int AgeDifference (int ans)
        {
            return Math.Abs(ans - 28);
        }

        //Question 3 Method
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

        //Question 4 Method
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

        //Question 5 Method
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

