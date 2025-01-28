<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="studentpage.aspx.cs" Inherits="_27_1_2025.studentpage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <%-- <asp:TextBox ID="text1" runat="server" Text="HEllo"></asp:TextBox>
            <asp:Button ID="btn" runat="server"/>--%>


            <h1 style="text-align:center;">Powers of Student</h1>
                <div class="row">
                  <div class="col-sm-6">
                    <div class="card">
                      <div class="card-body">
                        <h5 class="card-title">See all Books</h5>
                        <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                        <a href="booksstudent.aspx" class="btn btn-secondary">See all Books</a>
                      </div>
                    </div>
                  </div>
                  <div class="col-sm-6">
                    <div class="card">
                      <div class="card-body">
                        <h5 class="card-title">See a meeting rooms</h5>
                        <p class="card-text">With supporting text below as a natural lead-in to additional content.</p>
                        <a href="meetingrooms.aspx"  class="btn btn-secondary">See a meeting rooms</a>
                      </div>
                    </div>
                  </div>
                </div>

        </div>
    </form>
</body>
</html>
