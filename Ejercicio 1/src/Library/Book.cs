using System;

namespace Ucu.Poo.Expert
{
    public class Book
{
    public string Title { get; }
    public string Author { get; }
    public string Code { get; }

    public Book(string title, string author, string code)
    {
        this.Title = title;
        this.Author = author;
        this.Code = code;
    }
}

public class LibraryBook
{
    public string LibrarySector { get; set; }
    public string LibraryShelve { get; set; }

    public void ShelveBook(string sector, string shelve)
    {
        this.LibrarySector = sector;
        this.LibraryShelve = shelve;
    }

}
