namespace RegexProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome To Regex User Registration Problem");
            RegexClass obj = new RegexClass();           
            Console.WriteLine("1.First Name");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.WriteLine("Enter First Name");
                    string firstName = Console.ReadLine();
                    obj.FirstName(firstName);
                    break;
            }
        }
    }
}