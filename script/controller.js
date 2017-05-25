$(document).ready(function () {

    

    
    
// Load books 
    GetAllBooks();

    var DropDownList1 = $("#DropDownList1");
    DropDownList1.change(function (e) {

        var bId = DropDownList1.val();
        if (bId != -1) {

            // Get book Details 
            GetBookDetails(bId);

        } else {

            $("#outputTable").hide();
        }

    });
});

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

function GetBookDetails(BookId) {
    // JQuery AJAX Code Here 

    $.ajax({
        type: "POST",
        url: "index.aspx/GetBookDetails",
        data: "{'bookId':'" + BookId + "'}",
        contentType: "application/json; charset=utf-8",
        dataType: "json",
        success: function (response) {    
            var bo = response.d;
            $("#bId").html(bo.Id);
            $("#bTitle").html(bo.Title);
            $("#bAuth").html(bo.Author);
            $("#bPrice").html(bo.Price);
            $("#outputTable").show();
        },
        failure: function (msg) {
            alert(msg);
        }
    });
}