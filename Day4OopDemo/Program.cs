using System;


class Animal
{
    public string Name { get; set; }
    public int Id
    {
        get { return id; }
        set
        {
            if (value > 0)
                id = value;
        }
    }


    public void Speak()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}
class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Woof! Woof!");
    }
}

// Interface
interface IAnimal
{
    void Speak();
}

// Implementing the interface
class Lion : IAnimal
{
    public void Speak()
    {
        Console.WriteLine("Roar!");
    }
}

class Product
{
    private int id;
    public string Name { get; set; }
    public int Price { get; set; }
    public int Id
    {
        get { return id; }
        set
        {
            if (value > 0)
                id = value;
        }
    }
}
class Program
{
    static void Main(string[] args)
    {
        // Upcasting
        Animal myAnimal = new Dog();
        // Downcasting
        Dog myDog = (Dog)myAnimal;

        Console.WriteLine("Dog's Name: " + myDog.Name);
        Console.WriteLine("Dog's ID: " + myDog.id);

        myDog.Name = "Buddy";
        Console.WriteLine("Dog's Name: " + myDog.Name);
        myDog.Speak(); // Inherited method
        myDog.Bark();  // Dog's own method  
        // Using interface
        IAnimal myLion = new Lion();
        myLion.Speak();

        // object initialzer new way of intialization
        Product product = new Product
        {
            Id = 1,
            Name = "Laptop",
            Price = 1000
        };

        Console.WriteLine("Product ID: " + product.Id);
        Console.WriteLine("Product Name: " + product.Name);
        Console.WriteLine("Product Price: " + product.Price);


        // traditional way of initialization        
        Product product2 = new Product();
        product2.Id = 2;

        // collection initializer
        
        
    }
}