namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args) 
        {
            CreateStory();
            Add(9, 7);
            Subtract (9, 7);
            Divide (10, 2);
            Multiply(2, 5);
        
        }
        public static String CreateStory() 
        {
            Console.WriteLine("what is your name");
            string name = Console.ReadLine ();

            Console.WriteLine("what is your favorite color");
            string favoriteColor = Console.ReadLine();

            Console.WriteLine("what is your favorite animail");
            string animail  = Console.ReadLine();

            Console.WriteLine("what is your favorite band");
            string band = Console.ReadLine();

            string story = $"{name} loves the Color {favoriteColor} there favorite animail is {animail} there favorite band  is {band}";

            Console.WriteLine(story);
            return story;
        
        }
        public static int Add(int num1, int num2)
        {
            int sum = num1 + num2;
            Console.WriteLine(sum);
            return sum;
        
        
        
        }
        public static int Subtract (int num1, int num2)
        {
            int diffrence = num1 - num2;
            Console.WriteLine(diffrence);
            return diffrence;



        }

        public static int Multiply(int num1, int num2)
        {
            int mult = num1 * num2;
            Console.WriteLine(mult);
            return mult;



        }
        public static int Divide (int num1, int num2)
        {
            int divide = num1 / num2;
            Console.WriteLine(divide);
            return divide;



        }
    }
}
