<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="meetingrooms.aspx.cs" Inherits="_27_1_2025.meetingrooms" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.0.2/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-EVSTQN3/azprG1Anm3QDgpJLIm9Nao0Yz1ztcQTwFspd3yD65VohhpuuCOmLASjC" crossorigin="anonymous">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
          <table class="table">
              <thead>
                <tr>
                  <th scope="col">room ID</th>
                  <th scope="col">Room name</th>
                  <th scope="col">room location</th>
                  <th scope="col">room capacity</th>
                </tr>
              </thead>
              <tbody id="Meetingrooms" runat="server">
              </tbody>
          </table>
        </div>
    </form>
</body>
</html>
