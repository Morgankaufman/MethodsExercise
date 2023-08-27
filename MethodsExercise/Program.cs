namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, what is your name?");
            string userName = Console.ReadLine();
            Console.WriteLine("What is your favorite color?");
            string Color = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string Animal = Console.ReadLine();
            Console.WriteLine("What is your favorite hobby?");
            string hobby = Console.ReadLine();

            Console.WriteLine($"There was a man named {userName}, His favorite color is {Color}");
            Console.WriteLine($"His favorite animal is {Animal} and he loved to go {hobby}");
            Console.WriteLine($"If {userName} could he would spend everyday {hobby}");

            Console.WriteLine("give me a number to add");
            int num1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2);
            Console.WriteLine($"The sum is: {sum}");

            Console.WriteLine("give me a number");
             num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("give me a number to multiply to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);
            Console.WriteLine($"The product is: {product}");
        }
        
        public static int Sum(params int[] list)
        {
            int sum = 0;
            for(int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }
            return sum;


        }

        public static int Multiply(int x, int y)
        {
            return x * y;

        }

           





       

            



    }


          
        
         
}
