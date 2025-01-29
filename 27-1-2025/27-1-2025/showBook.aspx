<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="showBook.aspx.cs" Inherits="_27_1_2025.showBook" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <table class="table">
                <thead>
                  <tr>
                    <th scope="col">Book ID</th>
                    <th scope="col">Book name</th>
                    <th scope="col">Book type</th>
                    <th scope="col">Book level</th>
                  </tr>
                </thead>
                <tbody id="booksrow" runat="server">
                </tbody>
          </table>
        </div>
    </form>
</body>
</html>
