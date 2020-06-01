<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="Proyecto_Tickets.login" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0, shrink-to-fit=no">
    <link href="dist/css/login.css" rel="stylesheet" />
    <link rel="stylesheet" 
    href="https://use.fontawesome.com/releases/v5.7.2/css/all.css" 
    integrity="sha384-fnmOCqbTlWIlj8LyTjo7mOUStjsKC4pOpQbqyi7RrhN7udi9RwhKkMHpvLbHG9Sr" 
    crossorigin="anonymous">
    <!--Bootstrap CSS-->
    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/css/bootstrap.min.css" integrity="sha384-GJzZqFGwb1QTTN6wy59ffF1BuGJpLSa9DkKMp0DgiMDm4iYMj70gZWKYbI706tWS" crossorigin="anonymous">
    <title>Login</title>
</head>
<body>
   <div class="cont1 container-fluid text-center">
       <div class="cont2 container text-center">
        <form class="form-signin" runat="server">
            <h1 class="mb-4">Bienvenido</h1>
            <i class="fas fa-headset mb-4"></i>
            <asp:TextBox ID="txtEmail" TextMode="Email" CssClass="form-control mb-1" placeholder="Email Address" AutoComplete="false" runat="server"></asp:TextBox>
            
            <asp:TextBox ID="txtPassword" TextMode="Password" CssClass="form-control mb-4" placeholder="Password" runat="server"></asp:TextBox>
            
            <asp:Button ID="btnIniciarSesion" runat="server" CssClass="btn btn-lg btn-primary btn-block" Text="Inicia sesión"  OnClick="btnIniciarSesion_Click"  />
            
        </form>
       </div>
       <div class=" contf d-md-flex flex-md-equal w-100 my-md-3 pl-md-3">
           <div class="cont3 cont31 mr-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center text-white overflow-hidden">
                <div class="my-3 py-3">
                    <h2 class="display-5">Gestión de Tickets</h2>
                    <h2 class="display-5">Administración de incidencias</h2>
                </div>
                
           </div>
           <div class="cont3 cont32 mr-md-3 pt-3 px-3 pt-md-5 px-md-5 text-center overflow-hidden">
            <div class="my-3 py-3">
                <h2 class="display-5">Información de la Empresa:</h2>
            </div>
            <div class="fo2 bg-light shadow-sm mx-auto" style="width: 80%; height: 300px; border-radius: 21px 21px 0 0;">

            </div>
           </div>
       </div>
   </div>
   <!--JavaScript BT-->
   <script src="https://code.jquery.com/jquery-3.3.1.slim.min.js" integrity="sha384-q8i/X+965DzO0rT7abK41JStQIAqVgRVzpbzo5smXKp4YfRvH+8abtTE1Pi6jizo" crossorigin="anonymous"></script>
   <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.14.6/umd/popper.min.js" integrity="sha384-wHAiFfRlMFy6i5SRaxvfOCifBUQy1xHdJ/yoi7FRNXMRBu5WHdZYu1hA6ZOblgut" crossorigin="anonymous"></script>
   <script src="https://stackpath.bootstrapcdn.com/bootstrap/4.2.1/js/bootstrap.min.js" integrity="sha384-B0UglyR+jN6CkvvICOB2joaf5I4l3gm9GU6Hc1og6Ls7i6U/mkkaduKaBhlAXv9k" crossorigin="anonymous"></script> 
</body>
</html>
