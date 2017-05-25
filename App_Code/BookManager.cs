using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Description résumée de BookManager
/// </summary>
public class BookManager
{
    public BookManager()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    List<Book> books = new List<Book>()
        {
            new Book{Id=1, Title = "Book1", Author="Author_1", Price=101 },
             new Book{Id=2, Title = "Book2", Author="Author_2", Price=102 },
              new Book{Id=3, Title = "Book3", Author="Author_3", Price=103 },
               new Book{Id=4, Title = "Book4", Author="Author_4", Price=104 },

        };


    public List<Book> GetAllBooks()
    {
        return books;
    }


    public Book AddBook(Book newBook)
    {
        var IdBook = books.Count() + 1;

        newBook.Id = IdBook;

        books.Add(newBook);

        return newBook;
    }

    public Book GetBook(int id)
    {
        var b = books.FirstOrDefault((bo) => bo.Id == id);
        if (b == null)
        {
            return null;
        }
        return b;
    }


    public Book UpdateBook(Book book)
    {
        Book b = books.FirstOrDefault((bo) => bo.Id == book.Id);

        if (b == null)
        {
            return null;
        }

        b.Title = book.Title;
        b.Author = book.Author;
        b.Price = book.Price;


        return b;
    }

    public List<Book> DeleteBook(int idBook)
    {
        Book b = books.FirstOrDefault((bo) => bo.Id == idBook);

        if (b == null)
        {
            return null;
        }

        books.Remove(b);

        return GetAllBooks();
    }

}