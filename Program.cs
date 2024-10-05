namespace Test_2
{
    public class Program
    {
        static void Main(string[] args)
        {
            FishUtility f = new FishUtility();
            Console.WriteLine("Enter the Species to buy: ");
            string fishname = Console.ReadLine();

            Console.WriteLine("Enter the Price per fish: ");
            double PricePerFish = double.Parse(Console.ReadLine());

            f.AddFish(fishname, PricePerFish);

            if(f.BuyFish())
            { 
                Console.WriteLine("Enter the number of fish you need to buy: ");
                int num=int.Parse(Console.ReadLine());

                double TotalPrice=f.CalculatePrice(num);
                Console.WriteLine($"Total cost is: {TotalPrice}");
            }

            else
            {
                Console.WriteLine($"{f.Species} not found");
            }            

        }
    }
}
