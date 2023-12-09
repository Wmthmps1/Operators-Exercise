namespace OperatorExercise
{
    public class Program
    {
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

            

        }
    }
}

/*
 Exercise 1:
Create 2 integer variables.
Use these variables names and values:
int a = 17;
int b = 4;
Write out operations for addition, subtraction, and multiplication.
Use the a and b variables you have already created and store the answer in a new variable.
i.e. int sum = a + b;
For division and modulus, create 2 more integer variables.
Use these variable names:
int quotient = a / b;
int remainder = a % b;
Use Console.WriteLine(); and string interpolation to write out the results in the following format for each operation:
$"{a}/{b} is {quotient} remainder {remainder}."
Output to console for the above string interpolation should look like this:
17/4 is 4 remainder 1
Note: Be sure to write this in your main method



Exercise 2:
Create a method that will Calculate the area of a circle based on its radius
Name the method AreaOfCircle.
The return type will be a double.
It will accept a parameter of type double. Name it radius.
Allow a user to input a value for radius in the console using the following code in your main method:
double radius = double.Parse(Console.ReadLine());
Use this formula in the body of the method:
Math.PI * Math.Pow(radius, 2)
Note: Write your AreaOfCircle method outside of the main method. Call the AreaOfACircle method in the main method.
 */