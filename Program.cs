using System;
using System.Security.Cryptography;
using Classes;
using Enums;
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

// string name = "Amin";
// int age = 32;
// int salary = 10000000;

// Employee Amin = new Employee(name,age,salary);



// Amin.DisplayInfo();


// int sum = MathHelper.add(2, 4);
// int sum2 = MathHelper.sub(2, 4);


// Console.WriteLine(sum);
// Console.WriteLine(sum2);

// Level mediumLevel = Level.Medium;
// Level HighLevel = (Level)1;

// Console.WriteLine((int)mediumLevel);
// Console.WriteLine(HighLevel);


// TrafficControl controlStop = new TrafficControl(TraficLight.Red);
// TrafficControl controlSlowDown = new TrafficControl(TraficLight.Yellow);
// TrafficControl controlGo = new TrafficControl(TraficLight.Green);

// controlStop.ShowLightAction();
// controlSlowDown.ShowLightAction();
// controlGo.ShowLightAction();

// Meeting WhatDayMeeting = new Meeting();

// WhatDayMeeting.DayOfTheWeek = Weekdays.Saturday; 

// WhatDayMeeting.PrintMeetingDay();

// int a = 5;
// int b = 10;

// int c = a + b;

// //Svar: 15
// Console.WriteLine(c);


// /*
// bool = Sant eller falsk 
// int = heltal
// char = tecken 
// float = decimaler
// */


// // List<int> numbers = new List<int>();

// // for (int i = 0; i < numbers.Count; i++)
// // {
// //     Console.WriteLine(numbers[i]);
// // }



// int i = 3;

// do
// {

//     Console.WriteLine(i);
//     i--;

// } while (i > 0);


// int x = 100;


// Console.WriteLine(x);

// int e = 8;
// if (e % 2 == 0)
// {
//     Console.WriteLine("Even");
// }
// else
// {
//     Console.WriteLine("Odd");
// }



// double a = 10.9;


// int x = (int)(a);


// Console.WriteLine(x);


// int[] numbers = new int[5];


// numbers[0] = 3;

// foreach (int i in numbers)
// {
//     Console.WriteLine(i);
// }

// Console.WriteLine();

// for (int i = 0; i < numbers.Length; i++)
// {
//     Console.WriteLine(numbers[i]);
// }



// int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


// for (int i = 0; i < numbers.Length; i++)
// {


//     if (numbers[i] == 5)
//     {
//         Console.WriteLine("Hoppa över 5");
//         continue;
//     }
//     Console.WriteLine(numbers[i]);
// }




// string myMethods()
// {
//     return "Hello method";
// }





// Console.WriteLine(myMethods());

// Nazari n2 = new Nazari("Amin", 19, "Programmer");

// n2.age = -3;

// n2.getTheAge();


// List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };


// // foreach (int num in numbers)
// // {
// //     Console.WriteLine(num);
// // }

// for (int i = 0; i < numbers.Count; i++)
// {
//     Console.WriteLine($"Index {i}: {numbers[i]}");
// }


// int max = Math.Max(1, 49);

// Console.WriteLine(max);
// 0

// Console.Write("Ange ditt namn: ");

// string name = Console.ReadLine();

// Console.Write("Ange din ålder: ");
// int age = Convert.ToInt32(Console.ReadLine());


// Console.WriteLine($"Ditt namn är {name} och är {age} år gammal.");


// double num = 23.4;

// Console.WriteLine(num);



