using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_2
{
    public class FishUtility : Fish
    {
        public void AddFish(string Species, double PricePerFish)
        {
            this.Species = Species;
            this.PricePerFish = PricePerFish;
        }
        public bool BuyFish()
        {
            if (Species == "Clownfish" || Species == "Goldenfish")
            {
                return true;
            }
            else
            {
                Console.WriteLine($"{Species} not fount ");
                return false;
            }
        }
        public double CalculatePrice(int NumOfFish)
        {
            if (Species == "Clownfish")
            {
                double TotalPrice = (NumOfFish * PricePerFish) + 100;
                return TotalPrice;
            }
            else 
            {
                double TotalPrice = (NumOfFish * PricePerFish) + 150;
                return TotalPrice;
            }
        }
    }
}
