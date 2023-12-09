namespace OperatorExercise
{
    public class Program
    {
        public static double AreaOfCircle(double radius)
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }

        static void Main(string[] args)
        {
            /*          EXERCISE 1              */
            int a = 17;
            int b = 4;
            int sum = a + b;
            int difference = a - b;
            int product = a * b;
            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine("Exercise 1");
            Console.WriteLine($"{a} + {b} = {sum}");  // Sum
            Console.WriteLine($"{a} - {b} = {difference}");  // Difference
            Console.WriteLine($"{a} * {b} = {product}");  // Product
            Console.WriteLine($"{a} / {b} = {quotient} remainder {remainder}");  // Quotient and Remainder

            Console.WriteLine("");              // Blank Like to organize output

            /*          EXERCISE 2              */
            Console.WriteLine("Exercise 2");
            Console.WriteLine("What is the radius of your circle? ");
            double radius = double.Parse(Console.ReadLine());
            Console.WriteLine($"The area of a circle with radius of {radius} is {AreaOfCircle(radius)}");

        }
    }
}