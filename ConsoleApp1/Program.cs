namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Current Hour Prompt
            Console.Write("Enter the current hour (0-23);");
            int hour= int.Parse(Console.ReadLine());


            if (hour >= 5 && hour <= 11)
            {
                Console.WriteLine("Good Morning!");
            }
            else if (hour >= 12 && hour <= 17)
            {
                Console.WriteLine("Good Afternoon!");
            }
            else if(hour >= 18 && hour <=20)
            {
                Console.WriteLine("Good Evening!");
            }
            else
            {
                Console.WriteLine("Good Night!");
            }
        }
    }
}
