using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class index : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    [WebMethod]
    public static List<Book> GetAllBooks()
    {
        return new BookManager().GetAllBooks();
    }

    [WebMethod]
    public static Book GetBookDetails(int bookId)
    {
        return new BookManager().GetBook(bookId);
    }
}