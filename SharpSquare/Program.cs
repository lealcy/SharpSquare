using System;

namespace SharpSquare
{
    class MainClass
    {
        public static void Main (string[] args)
        {
            double targetSqrt;
            double guess;
            double product;
            double oldGuess;
            int steps;

            while (true) {
                Console.Write ("Type a number: ");
                try {
                    targetSqrt = Convert.ToDouble (Console.ReadLine ());
                } catch (FormatException e) {
                    return;
                }
                guess = targetSqrt / 2.0;
                oldGuess = 0;
                steps = 0;
                while (true) {
                    steps++;
                    Console.WriteLine ("(Step {0}): SQRT({1}) = {2}", steps, targetSqrt, guess);
                    product = targetSqrt / guess;
                    oldGuess = guess;
                    guess = (product + guess) / 2.0;
                    if (guess == oldGuess) {
                        break;
                    }
                }
            }

        }
    }
}
