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
```javascript
function GetAllBooks() {
    // JQuery AJAX Code Here 

    var DropDownList1 = $("#DropDownList1");
 

    $.ajax({
        type: "POST",
        url: "index.aspx/GetAllBooks",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {

            var books = response.d;
            $.each(books, function (index, b) {
                DropDownList1.append('<option value="' + b.Id + '">' + b.Title + '</option>');
            });
        },
        failure: function (msg) {
            alert(msg);
        },
        error: function (r) {
            alert(r);

        }
    });


}
```

## HTML Markup
```HTML
 <form id="form1" runat="server">
    
Select book:
    
   <asp:DropDownList ID="DropDownList1" runat="server" Width="150">
      <asp:ListItem Text="Select" Value="-1" />
   </asp:DropDownList>
    
   <br />
   <br />
    
   <table style="border: solid 1px black; width: 300px; display: none; background-color: #f3f3f3"
      cellpadding="4" cellspacing="0" id="outputTable">
      <tr>
         <td>Book ID:</td>
         <td><span id="bId" /></td>  
      </tr>
      <tr>
         <td>Book Title:</td>
         <td><span id="bTitle" /></td>
      </tr>
      <tr>
         <td>Book Author:</td>
         <td><span id="bAuth" /></td>
      </tr>
       <tr>
         <td>Book Price:</td>
         <td><span id="bPrice" /></td>
      </tr>
   </table>

</form>

```
![capture 1](https://github.com/anicetkeric/WebMethodApi/blob/master/Capture.PNG)
