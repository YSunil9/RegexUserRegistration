namespace RegexProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome To Regex User Registration Problem");
            RegexClass obj = new RegexClass();           
            Console.WriteLine("1.First Name\n2.Last Name\n3.Email\n4.Mobile\n5.Password");
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
                case 3:
                    Console.WriteLine("Enter EmailId");
                    string id = Console.ReadLine();
                    obj.Email(id);
                    break;
                case 4:
                    Console.WriteLine("Enter Mobile Number");
                    string no = Console.ReadLine();
                    obj.Mobile(no);
                    break;
                case 5:
                    Console.WriteLine("Enter Password");
                    string pswd = Console.ReadLine();
                    obj.Password(pswd);
                    break;
            }
        }
    }
}