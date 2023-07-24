namespace OperatorExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int a = 17;
            int b = 4;
            
            

            int Addition = a + b;
            
            int Subtraction = a - b;
            
            int Multiplication = a * b;
            
            int Division = a / b;
           
            int Modulus = a % b;

            int Quotient = a / b;
            int Remainder = a % b;
            Console.WriteLine($"{a}/{b} = {Quotient} Remainder {Remainder}");

            double area = AreaofCircle();
            

        }
        public static double AreaofCircle() 
        {
            Console.WriteLine("What is the radius of your circle?");
            var radius = double.Parse(Console.ReadLine());
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine($"The area of the circle is {area}");
            return area;
              
        }
    }
}
