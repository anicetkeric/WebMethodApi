# WebMethodApi

ASP.Net WebMethod using jQuery AJAX


## The WebMethod
An important thing to note is that the method is declared as static (C#) and is decorated with WebMethod attribute, this is necessary otherwise the method will not be called from client side jQuery AJAX call.

```c#
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
```


## Jquery Script


## HTML Markup

![capture 1](https://github.com/anicetkeric/WebMethodApi/blob/master/Capture.PNG)
