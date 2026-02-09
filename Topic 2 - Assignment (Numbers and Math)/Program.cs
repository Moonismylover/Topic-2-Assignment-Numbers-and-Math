namespace Topic_2___Assignment__Numbers_and_Math_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Angel

            Console.Title = "Topic 2 - Assignment (Numbers and Math)";

            Console.WriteLine("I was born in 2009. As of right now, I am " + (2026 - 2009) + " years old.");
            Console.WriteLine(" ");

            Console.WriteLine("The average of the numbers '14, 15, 16' is " + ((14 + 15 + 16) / 3) + ".");
            Console.WriteLine(" ");


            Console.WriteLine("The average of the numbers '14, 15, 16, 17' is " + ((14.0 + 15.0 + 16.0 + 17.0) / 4.0) + ".");
            Console.WriteLine(" ");


            double pi = Math.PI;
            Console.WriteLine("The area of a circle with the radius of 3 cm is " + Math.Round(2 * 3 * pi, 1));
            Console.WriteLine(" ");


            Console.WriteLine("How does C# know when to add when you use the '+' operator instead of sticking things together (concatenate)? Be precise in your answer.");
            Console.WriteLine(" ");
            Console.WriteLine("When we are attempting to add things together, we use brackets capturing the given values into a operation. If we are trying to attach strings, then we use double quotes instead of brackets. With the brackets, the computer knows to do mathematical operations and with double quotes, it knows to connect strings.");

        }
    }
}
