namespace myBuddy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome in My Buddy program");

            Trainee trainee = new Trainee();


            trainee.dateOfBirth = DateTime.Now;



            Console.WriteLine(trainee.GetAllDetails());
        }
    }
}
