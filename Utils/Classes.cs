using System;

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
}