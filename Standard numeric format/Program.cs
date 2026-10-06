namespace Standard_numeric_format
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             * (Standard numeric format)
 
                int X = 10;
                int Y = 20;
                Console.WriteLine($"Equation: {X} + {Y} = {X + Y:C}");
 
 
                in one (1) pdf page:
                1. why the output of this Equation = $30.00?
                2. what is its benefit?
                3. try another example with a different specifier with a screenshot of the output.
             
             */

            //double number = 9876.54321;

            //Console.WriteLine($"{number:F2}");               // 9876.54 string interpolation
            //Console.WriteLine(number.ToString("F2"));        // 9876.54
            //Console.WriteLine(string.Format("{0:F2}", number)); // 9876.54


            //int X = 10;
            //int Y = 20;
            //Console.WriteLine($"Equation: {X} + {Y} = {X + Y:C}");//Equation: 10 + 20 = $30.00


            double number = 1234.5678;

            Console.WriteLine($"Number: {number:N2}");


        }
    }
}
