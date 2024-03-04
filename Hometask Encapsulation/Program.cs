namespace Hometask_Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User newuser = new User("Salam123", "saalaaaAmmama2am");
            newuser.Age = 10;
            Console.WriteLine(newuser.Username);
            Console.WriteLine(newuser.Password);
            Console.WriteLine(newuser.Age);


        }
    }
}
