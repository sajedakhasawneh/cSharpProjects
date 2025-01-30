<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="_27_1_2025.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <section class="vh-100">
  <div class="container-fluid h-custom">
    <div class="row d-flex justify-content-center align-items-center h-100">
      <div class="col-md-9 col-lg-6 col-xl-5">
        <img src="https://mdbcdn.b-cdn.net/img/Photos/new-templates/bootstrap-login-form/draw2.webp" />
          class="img-fluid" alt="Sample image">
      </div>
      <div class="col-md-8 col-lg-6 col-xl-4 offset-xl-1">
       

          <!-- Email input -->
          <div class="data-mdb-input-init form-outline mb-4" >
  
            <label class="form-label" for="form3Example3">Email address</label>
             <asp:TextBox ID="email" runat="server" class="form-control form-control-lg"></asp:TextBox>
          </div>

          <!-- Password input -->
          <div  class="form-outline mb-3 data-mdb-input-init">

            <label class="form-label" for="form3Example4">Password</label>
              <asp:TextBox ID="password" runat="server" class="form-control form-control-lg"></asp:TextBox>
          </div>
           <asp:TextBox ID="flag" runat="server" class="form-control form-control-lg" Visible="false"></asp:TextBox>

          <div class="d-flex justify-content-between align-items-center">
            <!-- Checkbox -->
            <div class="form-check mb-0">
              <input class="form-check-input me-2" type="checkbox" value="" id="form2Example3" />
              <label class="form-check-label" for="form2Example3">
                Remember me
              </label>
            </div>
            <a href="#!" class="text-body">Forgot password?</a>
          </div>

          <asp:Label ID="checkuser" runat="server" Visable="false" ></asp:Label>
          <div class="text-center text-lg-start mt-4 pt-2">
    
              <asp:Button ID="Login" runat="server" Text="Login" OnClick="login_Click" class="btn btn-primary btn-lg"  style="padding-left: 2.5rem; padding-right: 2.5rem;" />
               <asp:Label ID="result" runat="server" Visible="false" ></asp:Label>
            <p class="small fw-bold mt-2 pt-1 mb-0">Don't have an account? <a href="#!"
                class="link-danger">Register</a></p>
     
    </div>
  </div>
</section>
        </div>
    </form>
</body>
</html>
