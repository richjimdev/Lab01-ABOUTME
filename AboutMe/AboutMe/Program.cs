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


            // dogs or cats? 
            // yes or no - is my hair black?
            // my age > too low too high? chances?
            // what color is my car? - boolean
            // Multiple choice? favotire color


            // cities I've lived in? ---- maybe

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

    }
}
