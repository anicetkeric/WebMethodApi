using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Description résumée de Book
/// </summary>
public class Book
{
    public Book()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public int Id { get; set; }
    public string Title { get; set; }

    public string Author { get; set; }
    public double Price { get; set; }
}