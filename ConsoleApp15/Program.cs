using System.Buffers.Text;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

namespace ConsoleApp15
{
    //N1
    class Money
    {
        protected int dollars;
        protected int cents;
        public int Dollars { get; set; }
        public int Cents { get; set; }
        public Money(int dollars, int cents)
        {
            this.dollars = dollars;
            this.cents = cents;
        }
        public void Print()
        {
            Console.WriteLine($"Current balance of money: {dollars} - dollars, {cents} - cents ");
        }
    }
    class Product : Money 
    {
        int dollnumb;
        int centnumb;
        public int Dollnumb
        {
            get { return dollnumb; }
            set { if (value <= 0)
                {
                    Console.WriteLine("Error, the value can't be lower than 0");
                    return;
                }
            else dollnumb = value;
            }
        }
        public int Centnumb
        {
            get { return centnumb; }
            set
            {
                if (value<= 0)
                {
                    Console.WriteLine("Error, the value can't be lower than 0");
                    return;
                }
                else    centnumb = value;
            }
        }
        public Product(int dollnumb, int centnumb, int doll, int cent) : base(doll, cent)
        {
            Dollnumb = dollnumb;
            Centnumb = centnumb;
            
        }
        public void Output()
        {
             dollars -= dollnumb;
             cents -= centnumb;
            Console.WriteLine($"You bought the product and you spent {dollnumb} dollars and {centnumb} cents. Remaining balance: {dollars} dollars and {cents} cents.");
            base.Print();
        }
    }

    //N2

    class Device
    {
        protected string name;
        protected int weight;
        protected string purpose;
        protected double price;
        protected string sound;
        public string Name { get; set; }
        public int Weight { get; set; }
        public string Purpose { get; set;}
        public double Price { get; set; }

        public string Sound { get; set; }
        public Device(string sound, string name, int weight, string purpose, double price)
        {
            Name = name;
            Weight = weight;
            Purpose = purpose;
            Price = price;
            Sound = sound;
          
        }
        public  virtual void Soundd()
        {
            Console.WriteLine("Sound: " + sound);

        }
        public   virtual void Show()
        {
            Console.WriteLine("Name: " + name);
        }
        public  virtual void Description() {
        
            Console.WriteLine("Weight: " + weight);
            Console.WriteLine("Purpose: " + purpose);
            Console.WriteLine("Price: " + price);
        }
      
    }
    class Kettle: Device
    {
        
        public Kettle(string sound, string name, int weight, string purpose, double price) : base(sound, name, weight, purpose, price) {  
        
        }
        public override void Soundd()
        {
            Console.WriteLine("Sound: " + Sound);
        }
        public override void Show() {
            Console.WriteLine("Name: " + Name);
        }
        public override void Description()
        {

            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Purpose: " + Purpose);
            Console.WriteLine("Price: " + Price);
        }

    }
    class Microwave : Device
    {

        public Microwave(string sound, string name, int weight, string purpose, double price) : base(sound, name, weight, purpose, price)
        {

        }
        public override void Soundd()
        {
            Console.WriteLine("Sound: " + Sound);
        }
        public override void Show()
        {
            Console.WriteLine("Name: " + Name);
        }
        public override void Description()
        {

            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Purpose: " + Purpose);
            Console.WriteLine("Price: " + Price);
        }

    }

    class Car: Device
    {
        public Car(string sound, string name, int weight, string purpose, double price) : base(sound, name, weight, purpose, price)
        {

        }
        public override void Soundd()
        {
            Console.WriteLine("Sound: " + Sound);
        }
        public override void Show()
        {
            Console.WriteLine("Name: " + Name);
        }
        public override void Description()
        {

            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Purpose: " + Purpose);
            Console.WriteLine("Price: " + Price);
        }
    }

    class Ship : Device {
        public Ship(string sound, string name, int weight, string purpose, double price) : base(sound, name, weight, purpose, price)
        {

        }
        public override void Soundd()
        {
            Console.WriteLine("Sound: " + Sound);
        }
        public override void Show()
        {
            Console.WriteLine("Name: " + Name);
        }
        public override void Description()
        {

            Console.WriteLine("Weight: " + Weight);
            Console.WriteLine("Purpose: " + Purpose);
            Console.WriteLine("Price: " + Price);
        }
    }
//N3
public abstract class MusicalTool
    {
        
        public string Name { get; set; }
        public int count { get; set; }
        public string Color { get; set; }

        public string SoundD {  get; set; } 
        
        public string Type { get; set; }

        public string History { get; set; }

        public MusicalTool(string name, int countofstryn, string color, string sound, string type, string history)
        {
          Name = name;  
            count = countofstryn;   
            Color = color;
            SoundD = sound;
            Type = type;
            History = history;

        }
        public abstract void Sound();
        public abstract void Show();
        public abstract void Description();

        public abstract void Historyy();
    }
     class Violin: MusicalTool
    {
        public Violin(string name, int countofstryn, string color, string sound, string type, string history): base(name, countofstryn, color, sound, type, history) { }
        public override void Sound()
        {
            Console.WriteLine("Sound: "  + SoundD );
        }
        public override void Show()
        {
            Console.WriteLine("Name:  " + Name);

        }
        public override void Description()
        {
            Console.WriteLine("Count of stryn " + count);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Type " + Type);

        }
        public override void Historyy()
        {
            Console.WriteLine("History: " +  History);
        }
    }
     class Ukulele: MusicalTool
    {
        public Ukulele(string name, int countofstryn, string color, string sound, string type, string history) : base(name, countofstryn, color, sound, type, history) { }
        public override void Sound()
        {
            Console.WriteLine("Sound: " + SoundD);
        }
        public override void Show()
        {
            Console.WriteLine("Name:  " + Name);

        }
        public override void Description()
        {
            Console.WriteLine("Count of stryn " + count);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Type " + Type);

        }
        public override void Historyy()
        {
            Console.WriteLine("History: " + History);
        }
    }
     class Trombone: MusicalTool
    {
        public Trombone(string name, int countofstryn, string color, string sound, string type, string history) : base(name, countofstryn, color, sound, type, history) { }


        public override void Sound()
        {
            Console.WriteLine("Sound: " + SoundD);
        }
        public override void Show()
        {
            Console.WriteLine("Name:  " + Name);

        }
        public override void Description()
        {
            Console.WriteLine("Count of stryn " + count);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Type " + Type);

        }
        public override void Historyy()
        {
            Console.WriteLine("History: " + History);
        }

    }
     class Cello : MusicalTool
    {
        public Cello(string name, int countofstryn, string color, string sound, string type, string history) : base(name, countofstryn, color, sound, type, history) { }


        public override void Sound()
        {
            Console.WriteLine("Sound: " + SoundD);
        }
        public override void Show()
        {
            Console.WriteLine("Name:  " + Name);

        }
        public override void Description()
        {
            Console.WriteLine("Count of stryn " + count);
            Console.WriteLine("Color: " + Color);
            Console.WriteLine("Type " + Type);

        }
        public override void Historyy()
        {
            Console.WriteLine("History: " + History);
        }
    }

    //N4

    class Animal
    {
        public int predators { get; set; }
        public double food { get; set; }
        public string type { get; set; }
        public double weight { get; set; }
        public string name { get; set; }
        public bool isPredator { get; set; }

        public Animal(int predators, double food, string type, double weight, string name, bool ispredator)
        {
            this.predators = predators;
            this.food = food;
            this.type = type;
            this.weight = weight;
            this.name = name;
            this.isPredator = ispredator;
        }

        public bool IsPredator() => isPredator;

        public virtual void Print()
        {
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Type: " + type);
            Console.WriteLine("Weight: " + weight);
        }

        public double CalculateFood()
        {
            
            return food * weight;
        }
    }

    class Tiger : Animal
    {
        
        public string Strenght { get; set; }
        public Tiger(string strenght, int predators, double food, string type, double weight, string name, bool ispredator) : base (predators, food, type, weight, name, ispredator)
        {
            Strenght = strenght;
            IsPredator();
        }
        public  override void Print()
        {
            base.Print();
            Console.WriteLine($"Strength: {Strenght}");
        }
    }


    class Rabbit: Animal
    {
       public int jumpdistance { get; set; }
        public Rabbit(int jumpDistance, int predators, double food, string type, double weight, string name, bool ispredator) : base(predators, food, type, weight, name, ispredator)
        {
            jumpdistance = jumpDistance;
            IsPredator();
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Jump Distance: {jumpdistance}");
        }

    }

    class Wolf: Animal
    {
        public string place { get; set; }
        public Wolf(string Place ,int predators, double food, string type, double weight, string name, bool ispredator) : base(predators, food, type, weight, name, ispredator) { 
        
            place = Place;
        
        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Place: {place}");
        }

    }

    class Kangoroo : Animal
    {
        public double speed { get; set; }
        public Kangoroo(double Speed, int predators, double food, string type, double weight, string name, bool ispredator) : base(predators, food, type, weight, name, ispredator)
        {
            speed = Speed;

        }
        public override void Print()
        {
            base.Print();
            Console.WriteLine($"Speed: {speed}");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            //N1
            Money obj = new Money(25, 36);
            obj.Print();
            Product obj2 = new Product(15, 5, 25, 36);
            obj2.Output();

            Console.WriteLine();

            //N2
            Device[] arr = new Device[] { new Kettle("Woooo", "Kittle", 3, "To boil water", 25.35) ,
                new Microwave("Pipi", "Microwawe", 6, "To warm up food", 67.56) ,
                new Car("Wroom", "Car", 500, "To drive people", 5000),
                new Ship("Pih", "Ship", 100000, "To swim", 10000) };
            foreach (Device value in arr)
            {
                value.Soundd();



                value.Show();
                value.Description();
            }

            Console.WriteLine();
            //N3

            Violin obj3 = new Violin("Violin", 4, "Golden", "Concert", "Woo", "blalbla");
            obj3.Sound();
            obj3.Show();
            obj3.Description();
            obj3.Historyy();
            Ukulele obj4 = new Ukulele("Ukulele", 5, "Silver", "Concert", "Lallaa", "blablabla");
            obj4.Sound();
            obj4.Show(); 
            obj4.Description();
            obj4.Historyy();
            Trombone obj5 = new Trombone("Trombone", 0, "Yellow", "Dyhovoe", "Pam Pam", "blablablabla");
            obj5.Sound(); 
            obj5.Show();
            obj5.Description();
            obj5.Historyy();
            Cello obj6 = new Cello("Cello", 4, "Diamond", "Concert", "Papapa Pam", "bla");
            obj5.Sound();
            obj6.Show();
            obj6.Description();
            obj6.Historyy();

            Console.WriteLine();

            //N4
            Animal[] zoo = new Animal[] { new Tiger("4 bite", 0, 5.9, "Predator", 14.5, "Tiger", true),
                new Rabbit(5,0, 5.7, "Herbiroves", 10.5, "Rabbit", false),
                new Wolf("Forest", 20,6, "Predator", 20.5, "Wolf", true),
                new Kangoroo(50.00, 50, 9, "Herbiroves", 40.9, "Kangoroo", false)
                
            };

            int predatorCount = 0;
            int herbivoreCount = 0;

            foreach (Animal value in zoo)
            {
                value.Print();
                if (value.IsPredator())
                {
                    predatorCount++;
                }
                else
                {
                    herbivoreCount++;
                }

                double amountOfFood = value.CalculateFood();
                Console.WriteLine("Food needed: " + amountOfFood);
            }

            Console.WriteLine($"\nTotal Predators: {predatorCount}");
            Console.WriteLine($"Total Herbivores: {herbivoreCount}");
        }
    }
}
