<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminpage.aspx.cs" Inherits="_27_1_2025.adminpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1 style="text-align:center; padding:15px 0px">powers of library owner</h1>
                <div class="row">
                  <div class="col-sm-3" style="padding-left: 10px;">
                    <div class="card">
                      <div class="card-body">
                        <h5 class="card-title">Add Book</h5>
                        <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                        <a href="addbook.aspx" class="btn btn-secondary">Add book</a>
                      </div>
                    </div>
                  </div>
                  <div class="col-sm-3">
                    <div class="card">
                      <div class="card-body">
                        <h5 class="card-title">Show book</h5>
                        <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                        <a href="meetingrooms.aspx"  class="btn btn-secondary">Show book</a>
                      </div>
                    </div>
                  </div>
        
                  <div class="col-sm-3" >
                  <div class="card">
                    <div class="card-body">
                      <h5 class="card-title">Edit book</h5>
                      <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                      <a href="editBook.aspx"  class="btn btn-secondary">Edit book</a>
                     </div>
                   </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
