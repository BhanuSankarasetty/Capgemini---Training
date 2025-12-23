using System;
// This is 23rd December 2025 Assignment
// Topic: OOPs Concepts - Inheritance, Encapsulation
namespace PriceCalculator
{
    class Computer
    {

        /// <summary>
        /// Represents a computer with its specifications.
        /// Functionalities:
        /// In class Computer, implement the below-given properties.
        ///     Data Type
        ///    Property Name
        ///     string
        ///   Processor
        ///     int
        ///   RamSize
        ///     int
        ///   HardDiskSize
        ///     int
        ///  GraphicCard

        /// </summary>
        /// <returns></returns>
        public string Processor { get; set; }
        public int RamSize { get; set; }
        public int HardDiskSize { get; set; }
        public int GraphicCard { get; set; }

        public Computer()
        {
            Type = "";
            Processor = "";
            RamSize = 0;
            HardDiskSize = 0;
            GraphicCard = 0;
        }
    }

    class Desktop : Computer
    {

        public int MonitorSize { get; set; }
        public int PowerSupplyVoltage { get; set; }

        public Desktop()
        {
            MonitorSize = 0;
            PowerSupplyVoltage = 0;
        }
        
        /// <summary>
        /// Formula 1:
        /// Desktop Price = Processor Cost + (RamSize * Ram Price) + (HardDiskSize * Hard Disk Price) 
        /// + (GraphicCard * Graphic Card Price) + (MonitorSize * Monitor Price) + 
        /// (PowerSupplyVolt * Power Supply Volt Price);
        ///         ///     Processor
        //    Processor Cost
        //     i3
        //   1500
        //     i5
        //   3000
        //     i7
        //   4500
        //    Ram price (per GB)
        //   Hard disk (per TB)
        //   Graphic Card (per GB)
        //   Power supply (per Volt)
        //   Monitor (per inch)
        //     200
        //    1500
        //    2500
        //    20
        //    250
        /// </summary>
        /// <returns></returns>
        
        public double DesktopPriceCalculation()
        {
            double ProcessorCost = 0;
            double RamPrice = 200;
            double HardDiskPrice = 1500;
            double GraphicCardPrice = 2500;
            double PowerSupplyVoltPrice = 20;
            double MonitorPrice = 250;

            if (Processor == "Intel i3")
                ProcessorCost = 1500;
            else if (Processor == "Intel i5")
                ProcessorCost = 3000;
            else if (Processor == "Intel i7")
                ProcessorCost = 4500;

            return ProcessorCost + (RamSize * RamPrice) + (HardDiskSize * HardDiskPrice) +
                   (GraphicCard * GraphicCardPrice) + (MonitorSize * MonitorPrice) +
                   (PowerSupplyVoltage * PowerSupplyVoltPrice);
        }
    }

    class Laptop : Computer
    {
        public int DisplaySize { get; set; }
        public int BatteryVolt { get; set; }

        public Laptop()
        {
            DisplaySize = 0;
            BatteryVolt = 0;
        }

        /// <summary>
        /// Formula 2:
        ///   Processor
        //    Processor Cost
        //     i3
        //   2500
        //     i5
        //   5000
        //     i7
        //   6500
        //   Ram price (per GB)
        //   Hard disk (per TB)
        //  Graphic Card (per GB)
        //  Battery(per Volt)
        //  Display(per inch)
        //     200
        //    1500
        //    2500
        //    20
        //  250
        //         /// Laptop Price = Processor Cost + (RamSize * Ram Price) + (HardDiskSize * Hard Disk Price) 
        /// + (GraphicCard * Graphic Card Price) + (Display Size* Display Price) 
        /// + (BatteryVolt * Battery Volt Price);
        ///  </summary>
        /// <returns></returns>
        public double LaptopPriceCalculation()
        {
            double ProcessorCost = 0;
            double RamPrice = 200;
            double HardDiskPrice = 1500;
            double GraphicCardPrice = 2500;
            double BatteryVoltPrice = 20;
            double DisplayPrice = 250;

            if (Processor == "Intel i3")
                ProcessorCost = 2500;
            else if (Processor == "Intel i5")
                ProcessorCost = 5000;
            else if (Processor == "Intel i7")
                ProcessorCost = 6500;

            return ProcessorCost + (RamSize * RamPrice) + (HardDiskSize * HardDiskPrice) +
                   (GraphicCard * GraphicCardPrice) + (DisplaySize * DisplayPrice) +
                   (BatteryVolt * BatteryVoltPrice);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Laptop myLaptop = new Laptop();
            myLaptop.Processor = "Intel i7";
            myLaptop.RamSize = 16; // in GB
            myLaptop.HardDiskSize = 512; // in GB
            myLaptop.GraphicCard = 4; // in GB
            myLaptop.DisplaySize = 15; // in inches
            myLaptop.BatteryVolt = 56; // in Wh

            double laptopPrice = myLaptop.LaptopPriceCalculation();
            Console.WriteLine("Laptop Price: $" + laptopPrice);

            Desktop myDesktop = new Desktop();
            myDesktop.Processor = "AMD Ryzen 5";        
            myDesktop.RamSize = 32; // in GB
            myDesktop.HardDiskSize = 1024; // in GB
            myDesktop.GraphicCard = 8; // in GB
            myDesktop.MonitorSize = 27; // in inches        
            myDesktop.PowerSupplyVoltage = 650; // in Watts

            double desktopPrice = myDesktop.DesktopPriceCalculation();
            Console.WriteLine("Desktop Price: $" + desktopPrice);
        }
    }
}