using System;
using System.Dynamic;
using Enums;
using Microsoft.VisualBasic;

namespace Classes
{
    public class Student
    {
        public string StudentName { get; set; }
        public int Age { get; set; }
        public string StudieKurs { get; set; }

        public Student(string name, int studentAge, string kurs)
        {
            StudentName = name;
            Age = studentAge;
            StudieKurs = kurs;
        }

        public string DisplayInfo()
        {
            return $"Studentens namn är {StudentName}, {StudentName} är {Age} år gammal. Kursen han läser är {StudieKurs}";
        }
    }

    public class Book
    {
        public string Titel { get; set; }
        public string Författare { get; set; }
        public int AntalSidor { get; set; }

        public Book(string titel, string författare, int antalSidor)
        {
            Titel = titel;
            Författare = författare;
            AntalSidor = antalSidor;
        }

        public void Info()
        {
            Console.WriteLine($"Titeln på boken är {Titel}, Författaren är {Författare} och boken har {AntalSidor} sidor.");
        }
    }


    public class Employee
    {

        private string name { get; set; }
        private int age { get; set; }
        private int salary { get; set; }


        public Employee(string name, int age, int salary)
        {
            this.name = name;
            this.age = age;
            this.salary = salary;
        }


        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set
            {
                if (value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.WriteLine("Age most be positive.");
                }

            }
        }

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0)
                {
                    salary = value;
                }
                else
                {
                    Console.WriteLine("Salary cannot be negative.");
                }
            }


        }



        public void DisplayInfo()
        {
            Console.WriteLine($"The name is: {Name}");
            Console.WriteLine($"The age is: {Age}");
            Console.WriteLine($"The salary is: {Salary}");
        }


    }





    public class Movie
    {
        public string Title { get; set; }
        public string Director { get; set; }
        private int rating;


        public int Rating
        {
            get { return rating; }
            set
            {
                if (value >= 1 && value <= 5)
                {
                    rating = value;
                }
                else
                {
                    Console.WriteLine("Rating must be between 1 and 5.");
                }

            }

        }

        public void PrintMovieInfo()
        {
            Console.WriteLine($"Title: {Title}.");
            Console.WriteLine($"Director: {Director}");
            Console.WriteLine($"Rating: {rating}");
        }

    }




    public class TrafficControl
    {

        public TraficLight CurrentLight { get; set; }


        public TrafficControl(TraficLight startLight)
        {
            CurrentLight = startLight;
        }


        public void ShowLightAction()
        {
            switch (CurrentLight)
            {
                case TraficLight.Red:
                    Console.WriteLine("Stop");
                    break;
                case TraficLight.Yellow:
                    Console.WriteLine("Slow down");
                    break;
                case TraficLight.Green:
                    Console.WriteLine("Go");
                    break;
            }

        }
    }



    public class Meeting
    {

        public Weekdays DayOfTheWeek { get; set; }

        public void PrintMeetingDay()
        {
            Console.WriteLine($"The meeting is scheduled on: {DayOfTheWeek}");
        }


    }





    public class BankAccount
    {
        // Egenskaper
        public string AccountNumber { get; set; }
        public string AccountHolder { get; set; }
        public decimal Balance { get; private set; }

        // Konstruktor
        public BankAccount(string accountNumber, string accountHolder, decimal balance)
        {
            AccountNumber = accountNumber;
            AccountHolder = accountHolder;
            Balance = balance;
        }

        // Metod för insättning
        public void Deposit(decimal amount)
        {
            Balance += amount;
            Console.WriteLine($"Deposited: {amount}, New Balance: {Balance}");
        }

        // Metod för uttag
        public void Withdraw(decimal amount)
        {
            if (Balance >= amount)
            {
                Balance -= amount;
                Console.WriteLine($"Withdrew: {amount}, New Balance: {Balance}");
            }
            else
            {
                Console.WriteLine("Insufficient funds. Withdrawal denied.");
            }
        }

        // Metod för att visa saldo
        public void DisplayBalance()
        {
            Console.WriteLine($"Balance: {Balance}");
        }
    }



    public class Product
    {

        public string Name { get; set; }

        public double Price { get; set; }

        public Product(string Name, double Price)
        {
            this.Name = Name;
            this.Price = Price;
        }

        public Product()
        {

        }
    }


    public class CartItem
    {
        public Product Product { get; set; }

        public double Quantity { get; set; }


        public CartItem(Product Product, double Quantity)
        {
            this.Product = Product;
            this.Quantity = Quantity;
        }


        public double Sum()
        {

            return Quantity * Product.Price;
        }

    }



    public class ShoppingCart
    {
        public List<CartItem> Items;

        public ShoppingCart()
        {
            Items = new List<CartItem>();
        }


        public void AddProduct(Product product, int Quantity)
        {

            CartItem existingItem = null;

            foreach (CartItem item in Items)
            {
                if (item.Product.Name == product.Name)
                {
                    existingItem = item;

                    break;
                }
            }
            if (existingItem != null)
            {
                existingItem.Quantity += Quantity;
                Console.WriteLine("Produkten finns i listan. Ökar kvantitet.");
            }
            else
            {
                Items.Add(new CartItem(product, Quantity));
            }

        }


        // public void removeItem(Product product)
        // {
        //     CartItem itemRemove = Items.Find(item => item.Product.Name == product.Name);

        //     if (itemRemove != null)
        //     {

        //     }
        // }





    }




    public class Nazari
    {
        private int _age;

        public string Name { get; set; }
        public int age
        {
            get { return _age; }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Cannot be negative.");
                }
                else
                {
                    _age = value;
                }
            }
        }

        public string work { get; set; }


        public Nazari(string name, int age, string work)
        {
            this.Name = name;
            this.age = age;
            this.work = work;
        }


        // public Nazari()
        // {

        // }


        public void getTheAge()
        {
            Console.WriteLine($"The age of this guy is {age}");
        }




    }

}
