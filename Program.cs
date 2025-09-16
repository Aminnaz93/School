using System;
using Classes;
using Utils;




Methods.Greeting();


Console.WriteLine("hello motherfucker");


Student Amin = new Student("Amin", 32, "Programmering");


Console.WriteLine(Amin.DisplayInfo());


List<Book> Library = new List<Book>
{
new Book("Harry Potter", "J.K Rowling", 462),
new Book("I am Zlatan Ibrahimovic", "Zlatan" , 250)
};



foreach (Book book in Library)
{
    Console.WriteLine($"\nTitel: {book.Titel}, Författare: {book.Författare}, Antal sidor: {book.AntalSidor}");
}


sayHello();