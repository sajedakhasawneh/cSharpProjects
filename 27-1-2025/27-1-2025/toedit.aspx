<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="toedit.aspx.cs" Inherits="_27_1_2025.toedit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
        <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">

    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
              <div class="d-flex flex-row align-items-center mb-4">
               <i class="fas fa-user fa-lg me-3 fa-fw"></i>
               <div class="data-mdb-input-init" class="form-outline flex-fill mb-0">
             
               <label class="form-label" for="form3Example1c">Book ID</label><br />
               <asp:TextBox ID="bookid" runat="server" class="form-control"></asp:TextBox>
                </div>
              </div>

            <div class="text-center text-lg-start mt-4 pt-2" style="padding-left:10px;">
    
    <asp:Button ID="Edit" runat="server" Text="edit Book" OnClick="Edit_Click" class="btn btn-primary btn-lg"  style="padding-left: 1.5rem; padding-right: 2.5rem;" />
        </div>
    </form>
</body>
</html>
