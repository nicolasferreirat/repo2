using System;

namespace Ucu.Poo.Expert
{

    class Program
    {
        static void Main()
        {
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            book1.LibraryBook.ShelveBook("A","7");
            book2.LibraryBook.ShelveBook("B","3");

        }
    }
}

/* No cumple con el principio SRP porque tiene dos responsabilidades, lo mejor sería 
dividirlo en dos clases, la clase Book y la clase ShelveBook/*
