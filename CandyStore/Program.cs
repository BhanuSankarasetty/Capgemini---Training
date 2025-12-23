using System;

// This is 23rd December 2025 third-Assignment

namespace  candyStore
{
    class Candy
    {
        public string Flavor { get; set; }
        public int Quantity { get; set; }
        public int PricePerPiece { get; set; }
        public double TotalPrice { get; set; }
        public double Discount { get; set; }

        public Candy()
        {
            Flavor = "";
            Quantity = 0;
            PricePerPiece = 0;
            TotalPrice = 0.0;
            Discount = 0.0;
        }
        public bool ValidateCandyFlavour()
        {
            if(Flavor == "Chocolate" || Flavor == "Strawberry" || Flavor == "Lemon" || Flavor == "Mint")
            {
                return true;
            }
            return false;
        }
    }
    class Program
    {
        public static Candy CalculateDiscountedPrice(Candy candy)
        {
            double discount = 0.0;
            if(candy.Flavor == "Chocolate") discount = 0.1;
            else if(candy.Flavor == "Strawberry") discount = 0.05;
            else if(candy.Flavor == "Lemon") discount = 0.02;
            else if(candy.Flavor == "Mint") discount = 0.03;

            candy.TotalPrice = candy.Quantity * candy.PricePerPiece;
            candy.Discount = candy.TotalPrice * discount;
            candy.TotalPrice -= candy.Discount;

            return candy;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Candy Store!");

            Candy myCandy = new Candy();

            Console.Write("Enter Candy Flavor (Chocolate, Strawberry, Lemon, Mint): ");
            string? flavor = Console.ReadLine();

            myCandy.Flavor = flavor;
            myCandy.Quantity = 10;
            myCandy.PricePerPiece = 5;


           
            if(myCandy.ValidateCandyFlavour())
            {
                Console.WriteLine($"Candy Flavor: {myCandy.Flavor}");
                Console.WriteLine($"Quantity: {myCandy.Quantity}");
                Console.WriteLine($"Price Per Piece: {myCandy.PricePerPiece}");
                Console.WriteLine($"Total Price after Discount: {myCandy.TotalPrice}");
                Console.WriteLine($"Discount Applied: {myCandy.Discount}");
                Candy discountedCandy = CalculateDiscountedPrice(myCandy);
                Console.WriteLine($"Total Price after Discount: {discountedCandy.TotalPrice}");
            }
            else
            {
                Console.WriteLine("Invalid Candy Flavor Selected.");
            }
        
        }
    }
}