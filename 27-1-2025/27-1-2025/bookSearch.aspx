<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="bookSearch.aspx.cs" Inherits="_27_1_2025.bookSearch" %>

<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           <div class="d-flex flex-row align-items-center mb-4">
           <i class="fas fa-user fa-lg me-3 fa-fw"></i>
           <div class="data-mdb-input-init" class="form-outline flex-fill mb-0">
         
           <label class="form-label" for="form3Example1c">Book ID</label><br />
           <asp:TextBox ID="booksearch" runat="server" class="form-control"></asp:TextBox>
            </div>
          </div>
            
        <div class="text-center text-lg-start mt-4 pt-2" style="padding-left:10px;">

<asp:Button ID="search" runat="server" Text="Search" OnClick="search_Click" class="btn btn-primary btn-lg"  style="padding-left: 1.5rem; padding-right: 2.5rem;" />
    </div>
            


                    <section class="vh-100" style="background-color: #eee;">
<div class="container h-100">
<div class="row d-flex justify-content-center align-items-center h-100">
  <div class="col-lg-12 col-xl-11">
    <div class="card text-black" style="border-radius: 25px;">
      <div class="card-body p-md-5">
        <div class="row justify-content-center">
          <div class="col-md-10 col-lg-6 col-xl-5 order-2 order-lg-1">


<%--          <div class="d-flex flex-row align-items-center mb-4">
            <i class="fas fa-user fa-lg me-3 fa-fw"></i>
            <div data-mdb-input-init class="form-outline flex-fill mb-0">
     
                <label class="form-label" for="form3Example1c">Book ID</label><br />
                <asp:TextBox ID="bookid1" runat="server" class="form-control"></asp:TextBox>
            </div>
          </div>--%>
                        <asp:Label ID="datalable" runat="server" Visible="false" Text=""></asp:Label>

          <div class="d-flex flex-row align-items-center mb-4">
            <i class="fas fa-envelope fa-lg me-3 fa-fw"></i>
            <div data-mdb-input-init class="form-outline flex-fill mb-0">
             
                <label class="form-label" for="form3Example3c">Name</label><br />
                <asp:TextBox ID="bookName" runat="server" class="form-control"></asp:TextBox>
            </div>
          </div>

          <div class="d-flex flex-row align-items-center mb-4">
            <i class="fas fa-lock fa-lg me-3 fa-fw"></i>
            <div data-mdb-input-init class="form-outline flex-fill mb-0">
             
              <label class="form-label" for="form3Example4c">Type</label><br />
                <asp:TextBox ID="booktype" runat="server" class="form-control"></asp:TextBox>
            </div>
          </div>

          <div class="d-flex flex-row align-items-center mb-4">
            <i class="fas fa-key fa-lg me-3 fa-fw"></i>
            <div data-mdb-input-init class="form-outline flex-fill mb-0">
           
              <label class="form-label" for="form3Example4cd">Level</label><br />
              <asp:TextBox ID="booklevel" runat="server" class="form-control"></asp:TextBox>
            </div>
          </div>
        </div>
    </form>
</body>
</html>
