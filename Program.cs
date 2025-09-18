using System;
using System.Security.Cryptography;
using Classes;
using Utils;



// Console.WriteLine("hello motherfucker");


// Student Amin = new Student("Amin", 32, "Programmering");


// Console.WriteLine(Amin.DisplayInfo());


// List<Book> Library = new List<Book>
// {
// new Book("Harry Potter", "J.K Rowling", 462),
// new Book("I am Zlatan Ibrahimovic", "Zlatan" , 250)
// };



// foreach (Book book in Library)
// {
//     Console.WriteLine($"\nTitel: {book.Titel}, Författare: {book.Författare}, Antal sidor: {book.AntalSidor}");
// }



// Student Gurra = new Student("Gustav", 24, "Programmering");



// Console.WriteLine($"Gurras age is {Gurra.Age}");






// int sum = 0;
// int number;

// Console.WriteLine("Skriv in heltal (0 för att avsluta):");

// do
// {
//     number = Convert.ToInt32(Console.ReadLine());
//     sum += number;
// } while (number != 0);

// Console.WriteLine($"Summan är: {sum}");



// Console.Write("Ange ett heltal: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine($"Multiplikationstabellen för {number}:");
// for (int i = 1; i <= 10; i++)
// {
//     Console.WriteLine($"{number} x {i} = {number * i}");
// }




// List<int> numbers = new List<int> { 1, 2, 3, 2, 4, 2, 5 };

// Console.Write("Ange ett tal att räkna: ");
// int search = Convert.ToInt32(Console.ReadLine());

// int count = 0;
// foreach (int n in numbers)
// {
//     if (n == search)
//         count++;
// }

// Console.WriteLine($"{search} förekommer {count} gånger i listan.");



//         Console.Write("Ange ett lösenord: ");
//         string password = Console.ReadLine();

//         if (CheckLength(password) && CheckUpper(password) && CheckSpecial(password))
//         {
//             Console.WriteLine("Lösenordet är giltigt!");
//         }
//         else
//         {
//             Console.WriteLine("Lösenordet är ogiltigt!");
//         }


//     static bool CheckLength(string pw) => pw.Length >= 8;

//     static bool CheckUpper(string pw)
//     {
//         foreach (char c in pw)
//         {
//             if (char.IsUpper(c)) return true;
//         }
//         return false;
//     }

//     static bool CheckSpecial(string pw)
// {
//     string specialCharacters = "!@#$%^&*()-_=+[{]};:'\"|\\,<.>/?";
//     foreach (char c in pw)
//     {
//         if (specialCharacters.Contains(c)) return true;
//     }
//     return false;
// }

string name = "Amin";
int age = 32;
int salary = 10000000;

Employee Amin = new Employee(name,age,salary);



Amin.DisplayInfo();


int sum = MathHelper.add(2, 4);


Console.WriteLine(sum);


