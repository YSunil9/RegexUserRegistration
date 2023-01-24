namespace RegexProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome To Regex User Registration Problem");
            RegexClass obj = new RegexClass();           
            Console.WriteLine("1.First Name\n2.Last Name");
            int select = Convert.ToInt32(Console.ReadLine());
            switch (select)
            {
                case 1:
                    Console.WriteLine("Enter First Name");
                    string firstName = Console.ReadLine();
                    obj.Name(firstName);
                    break;
                case 2:
                    Console.WriteLine("Enter Last Name");
                    string LastName = Console.ReadLine();
                    obj.Name(LastName);
                    break;
            }
        }
    }
}