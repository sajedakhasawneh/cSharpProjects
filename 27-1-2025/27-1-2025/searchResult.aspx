<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="searchResult.aspx.cs" Inherits="_27_1_2025.searchResult" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
         <%--   <table class="table">
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
</table>--%>

             <section class="vh-100" style="background-color: #eee;">
     <div class="container h-100">
     <div class="row d-flex justify-content-center align-items-center h-100">
       <div class="col-lg-12 col-xl-11">
         <div class="card text-black" style="border-radius: 25px;">
           <div class="card-body p-md-5">
             <div class="row justify-content-center">
               <div class="col-md-10 col-lg-6 col-xl-5 order-2 order-lg-1">


               <div class="d-flex flex-row align-items-center mb-4">
                 <i class="fas fa-user fa-lg me-3 fa-fw"></i>
                 <div data-mdb-input-init class="form-outline flex-fill mb-0">
          
                     <label class="form-label" for="form3Example1c">Book ID</label><br />
                     <asp:TextBox ID="bookid1" runat="server" class="form-control"></asp:TextBox>
                 </div>
               </div>
                   <asp:Label ID="lable" runat="server" Visible="false"></asp:Label>

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
