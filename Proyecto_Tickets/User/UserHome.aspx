<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="UserHome.aspx.cs" Inherits="Proyecto_Tickets.User.UserView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h1>Bienvenido. <small>Elementos principales</small><asp:Label ID="lblFecha" runat="server" CssClass="pull-right" Text="Label"></asp:Label></h1>
       
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-header">
                        <h3 class="box-title">Información Personal</h3>
                        <div class="box-tools pull-right">
                            <button class="btn btn-primary btn-xs" data-widget="collapse"><i class="fa fa-minus"></i></button>
                        </div>
                    </div>
                    <form role="form">
                        <div class="box-body">
                            <div class="form-group">
                                <label>Email</label>
                                <asp:TextBox ID="txtEmail" runat="server" TextMode="Email" CssClass="form-control" disabled="disabled"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Nombre</label>
                                <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" disabled="disabled"></asp:TextBox>
                                <br />
                                <asp:TextBox ID="txtApellidos" runat="server" CssClass="form-control" disabled="disabled"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <label>Nivel de Soporte:</label><br />
                                <asp:Label ID="lblNivelSoporte" runat="server" CssClass="h3" Text="Label"></asp:Label>
                            </div>
                        </div>
                    </form>
                </div>
            </div>
            <div class="col-md-3">
                <div class="small-box bg-red">
                    <div class="inner">
                        <h3 id="h3Tickets">
                            <asp:Label ID="lblTickets" runat="server" Text="Label"></asp:Label></h3>
                        <p>Tickets Pendientes</p>
                    </div>
                    <div class="icon">
                        <i class="ion ion-alert-circled ip"></i>
                    </div>
                    <a href="../Ticket/tickets_Desarrollo.aspx" class="small-box-footer">
                  ir a Tickets <i class="fa fa-arrow-circle-right"></i></a>
                </div>
                <div class="small-box bg-blue">
                    <div class="inner">
                        <h3 id="h3Categorias"><asp:Label ID="lblCategoria" runat="server" Text="Label"></asp:Label></h3>
                        <p>Productos/Servicios</p>
                    </div>
                    <div class="icon">
                        <i class="ion ion-grid ip"></i>
                    </div>
                    <a href="../Categoria/categoria_is.aspx" class="small-box-footer">
                  ir a Productos/Servicios <i class="fa fa-arrow-circle-right"></i></a>
                </div>
            </div>
            <div class="col-md-3">
                 <div class="small-box bg-blue">
                    <div class="inner">
                        <h3 id="h3Categorías"><asp:Label ID="lblTipo" runat="server" Text="Label"></asp:Label></h3>
                        <p>Categorías de Tickets.</p>
                    </div>
                    <div class="icon">
                        <i class="ion ion-bookmark ip"></i>
                    </div>
                    <a href="../Tipo/Tipo_is.aspx" class="small-box-footer">
                  ir a Categorías <i class="fa fa-arrow-circle-right"></i></a>
                </div>
                <div class="small-box bg-blue">
                    <div class="inner">
                        <h3 id="h3User"><asp:Label ID="lblCliente" runat="server" Text="Label"></asp:Label></h3>
                        <p>Clientes-Usuarios.</p>
                    </div>
                    <div class="icon">
                        <i class="ion ion-person  ip"></i>
                    </div>
                    <a href="../Clientes/cliente_s.aspx" class="small-box-footer">
                  ir a Usuarios <i class="fa fa-arrow-circle-right"></i></a>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
