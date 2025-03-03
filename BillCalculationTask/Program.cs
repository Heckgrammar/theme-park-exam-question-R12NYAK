namespace ThemeParkCalculationTask
{
   internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("enter the number of people");
        string input = Console.ReadLine();

        { 
            int numOfPeople = Convert.ToInt32(input);

            if (numOfPeople > 0)
            {
                int pricePerCustomer = 15;
                int discountMinimum = 6;
                int discountAmount = 5;

                int totalcharge = numOfPeople * pricePerCustomer;


                if (numOfPeople >= discountMinimum) 
                {
                    totalcharge = numOfPeople*pricePerCustomer - discountAmount;
                }
                Console.WriteLine("The total charge for your group is £" + totalcharge);

            }
            
                else 
            {
                Console.WriteLine("enter a valid number please");
            }
            }

    }   


    }
}
