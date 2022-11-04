namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            string customerName = "Alexander the Great";
            int customerAge = 27;
            char middleInitial = 'T';
            bool cardMember = true;
            double registerBalance = 100.00;
            decimal carriedCash = 10.00m;
            //Test
            Console.WriteLine($"{customerName} ({middleInitial}.) is {customerAge} years old and carrying ${carriedCash}. Our register's balance is {registerBalance}.");
            if (cardMember == true)
            {
                Console.WriteLine($"{customerName} is a rewards member.");
            } else
            {
                Console.WriteLine($"{customerName} is NOT a rewards member.");
            }
        }
    }
}
