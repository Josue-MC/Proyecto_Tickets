<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="ticket_sg.aspx.cs" Inherits="Proyecto_Tickets.Ticket.ticket_sg" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h1>Detalles de Ticket. <small></small><asp:Label ID="lblFecha" runat="server" CssClass="pull-right" Text="Label"></asp:Label></h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-3">

            </div>
            <div class="col-md-6">
                <!--Nuevo Ticket Box -->
                <div class="box box-success">
                <div class="box-header">
                  <h3 class="box-title"> Ticket: #<asp:Label ID="lblID_Ticket" runat="server" Text="Label"></asp:Label></h3>
                  <div class="box-tools pull-right">
                    <button class="btn btn-box-tool" data-widget="collapse" data-toggle="tooltip" title="" data-original-title="Collapse"><i class="fa fa-minus"></i></button>
                  </div>
                </div>
                <form role="form">
                    <div class="box-body">
                        <div class="form-group">
                            <label>Título:</label>
                            <asp:TextBox ID="txtTitulo" CssClass="form-control" AutoComplete="false" Enabled="false" runat="server"></asp:TextBox>
                         <div class="form-group">
                            <label>Descripción:&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</label>
                             <asp:TextBox ID="txtDescripcion" class="form-control" TextMode="MultiLine" Columns="60" Rows="3" placeholder="Descripción ..." enabled="false" runat="server"></asp:TextBox>
               
                          </div>
                        <div class="row">
                            <div class="col-xs-6">
                                <label>Producto/servicio:</label><asp:DropDownList ID="ddlCategoría" CssClass="form-control" Enabled="false" runat="server"></asp:DropDownList>
                                <label>Cliente:</label><asp:DropDownList ID="ddlUsuario" CssClass="form-control" runat="server" Enabled="false"></asp:DropDownList>
                                <label>Estado:</label><asp:DropDownList ID="ddlStatus" CssClass="form-control" AutoPostBack="true" Enabled="false" runat="server"></asp:DropDownList>
                            </div>
                            <div class="col-xs-6">
                                <label>Categoría:</label><asp:DropDownList ID="ddlTipo" CssClass="form-control" Enabled="false" runat="server"></asp:DropDownList>
                                <label>Fecha Creación:</label><asp:TextBox ID="txtFechaCreacion" CssClass="form-control" enabled="false"  AutoComplete="false" runat="server"></asp:TextBox>
                                <label>Nivel Soporte:</label><asp:DropDownList ID="ddlNivel" CssClass="form-control" Enabled="false" runat="server"></asp:DropDownList>
                            </div>
                        </div>
                       <div class="form-group">
                           <br />
                           <label>Documentación de la Solución:</label>
                             <asp:TextBox ID="txtSolución" class="form-control" TextMode="MultiLine" Columns="60" Rows="4" placeholder="Solución ..." Enabled="false" runat="server"></asp:TextBox>
                         </div>
                        </div>
                    </div><!-- /.box-body -->
                    
                </form>
              </div>
            </div>
           
            <div class="col-md-3">

            </div>
            </div>
        </section>
</asp:Content>
