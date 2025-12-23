using System;

// This is 23rd December 2025 Assignment
// This cover the Topic of custom Exception Handling, OOPs Concepts - Encapsulation
namespace BakerySystem
{
    class InvalidFlavourException : Exception
    {
        public InvalidFlavourException(string message) : base(message)
        {
        }
    }

    class Cake
    {

        #region Properties
        public string flavor { get; set; } = "";
        public int QuantityInKg { get; set; } = 0;
        public double PricePerKg { get; set; } = 0.0;
        #endregion

        public Cake()
        {
            flavor = "";
            QuantityInKg = 0;
            PricePerKg = 0.0;
        }
        

        public bool CakeOrder()
        {
            if(flavor == "Chocolate" || flavor == "Vanilla" || flavor == "Red Velvet" || flavor == "Strawberry") 
            {
                return true;
            }else throw new InvalidFlavourException("Invalid Flavor Selected");

            return false;   
        }

        public double CalculatePrice()
        {
            double discount = 3;
            if(flavor == "Chocolate") discount = 5;
            if(flavor == "Red Velvet") discount = 10;
            return ((100-discount)/100) * QuantityInKg * PricePerKg;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cake myCake = new Cake();
            myCake.flavor = "Chocolat";
            myCake.QuantityInKg = 2;
            myCake.PricePerKg = 500.0;

            try
            {
                if (myCake.CakeOrder())
                {
                    double totalPrice = myCake.CalculatePrice();
                    Console.WriteLine("Total Price of the Cake: " + totalPrice);
                }
            }
            catch (InvalidFlavourException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}