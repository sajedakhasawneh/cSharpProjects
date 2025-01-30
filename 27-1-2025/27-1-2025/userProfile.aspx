<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="userProfile.aspx.cs" Inherits="_27_1_2025.userProfile" %>
<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

                 <div class="container rounded bg-white mt-5 mb-5">
                <div class="row">
    
                <div class="col-md-5 border-right">
                <div class="p-3 py-5">
                <div class="d-flex justify-content-between align-items-center mb-3">
                <h4 class="text-right">Profile Settings</h4>
            </div>

             <div class="row mt-3">
                <div class="col-md-12">
                 <label class="labels">Name</label>
                 <asp:TextBox ID="name" runat="server"  class="form-control"></asp:TextBox>
                </div>
            <br />
               <div class="col-md-12">
                  <label class="labels">Email</label>
                  <asp:TextBox ID="email" runat="server"  class="form-control" ></asp:TextBox>
               </div>
             <div class="col-md-12">
   
                 <br />
                   <asp:TextBox ID="flag" runat="server" class="form-control" Visible="false"></asp:TextBox>
                 <asp:TextBox ID="password" runat="server" class="form-control" Visible="false" ></asp:TextBox>
 

 </div>
            <br />
              <div class="mt-5 text-center">
                <asp:Button ID="asktoedit" runat="server" Text="Edit Profile" class="btn btn-primary" OnClick="asktoedit_Click" />
              </div>

              
    </div>
</div>
</div>
</div>
        </div>
    </form>
</body>
</html>
