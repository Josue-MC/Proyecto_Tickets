<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="Ticket_u.aspx.cs" Inherits="Proyecto_Tickets.Ticket.Ticket_u" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h1>Editar Ticket. <small>Editar los elementos del Ticket</small><asp:Label ID="lblFecha" runat="server" CssClass="pull-right" Text="Label"></asp:Label></h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-1">

            </div>
            <div class="col-md-6">
                <!--Nuevo Ticket Box -->
                <div class="box box-success">
                <div class="box-header">
                  <h3 class="box-title">Editar Ticket: #<asp:Label ID="lblID_Ticket" runat="server" Text="Label"></asp:Label></h3>
                  <div class="box-tools pull-right">
                    <button class="btn btn-box-tool" data-widget="collapse" data-toggle="tooltip" title="" data-original-title="Collapse"><i class="fa fa-minus"></i></button>
                  </div>
                </div>
                <form role="form">
                    <div class="box-body">
                        <div class="form-group">
                            <label>Título:</label>
                            <asp:TextBox ID="txtTitulo" CssClass="form-control" AutoComplete="false" runat="server"></asp:TextBox>
                            <asp:RequiredFieldValidator ID="rfvTitulo" runat="server" ControlToValidate="txtTitulo"
                           validationGroup="vlg1"  ErrorMessage="*" Display="Dynamic"  ForeColor="red"></asp:RequiredFieldValidator>
                         <div class="form-group">
                            <label>Descripción:</label>
                             <asp:TextBox ID="txtDescripcion" class="form-control" TextMode="MultiLine" Columns="50" Rows="3" placeholder="Descripción ..." runat="server"></asp:TextBox>
                              <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="txtDescripcion"
                           validationGroup="vlg1"  ErrorMessage="*" Display="Dynamic"  ForeColor="red"></asp:RequiredFieldValidator>
                          </div>
                        <div class="row">
                            <div class="col-xs-6">
                                <label>Producto/servicio:</label><asp:DropDownList ID="ddlCategoría" CssClass="form-control" runat="server"></asp:DropDownList>
                                <asp:RequiredFieldValidator ID="rfvCategoria" runat="server" ControlToValidate="ddlCategoría"
                           validationGroup="vlg1"  ErrorMessage="*" Display="Dynamic" InitialValue="0" ForeColor="red"></asp:RequiredFieldValidator>
                                <label>Cliente:</label><asp:DropDownList ID="ddlUsuario" CssClass="form-control" runat="server" Enabled="false"></asp:DropDownList>
                                <label>Estado:</label><asp:DropDownList ID="ddlStatus" CssClass="form-control" AutoPostBack="true" runat="server"></asp:DropDownList>
                                <asp:RequiredFieldValidator ID="rfvStatus" runat="server" ControlToValidate="ddlStatus"
                           validationGroup="vlg1"  ErrorMessage="*" Display="Dynamic" InitialValue="0" ForeColor="red"></asp:RequiredFieldValidator>
                            </div>
                            <div class="col-xs-6">
                                <label>Categoría:</label><asp:DropDownList ID="ddlTipo" CssClass="form-control" runat="server"></asp:DropDownList>
                                <asp:RequiredFieldValidator ID="rfvTipo" runat="server" ControlToValidate="ddlTipo"
                           validationGroup="vlg1"  ErrorMessage="*" Display="Dynamic" InitialValue="0" ForeColor="red"></asp:RequiredFieldValidator>
                                <label>Fecha Creación:</label><asp:TextBox ID="txtFechaCreacion" CssClass="form-control" enabled="false"  AutoComplete="false" runat="server"></asp:TextBox>
                                <label>Nivel Soporte:</label><asp:DropDownList ID="ddlNivel" CssClass="form-control" runat="server"></asp:DropDownList>
                                <asp:RequiredFieldValidator ID="rvfNivel" runat="server" ControlToValidate="ddlNivel"
                           validationGroup="vlg1"  ErrorMessage="*" Display="Dynamic" InitialValue="0" ForeColor="red"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                       <div class="form-group">
                           <br />
                           <label>Documentación de la Solución:</label>
                             <asp:TextBox ID="txtSolución" class="form-control" TextMode="MultiLine" Columns="50" Rows="4" placeholder="Solución ..." runat="server"></asp:TextBox>
                         </div>
                        </div>
                    </div><!-- /.box-body -->
                    <div class="box-footer">
                        <div class="form-group">
                            <asp:Button ID="btnEditarTicket" runat="server" Text="Editar" CssClass="btn btn-block btn-success center-block" OnClick="btnEditarTicket_Click" ValidationGroup="vlg1"  />
                        </div>
                    </div>
                </form>
              </div>
            </div>
            <div class="col-md-4">
               <div class="callout callout-success">
                    <h4><i class="icon fa fa-info"></i>&nbsp;  Estado de Ticket:</h4>
                    <p>Para cambiar el estado de ticket, editar la lista de Estado.</p>
                  </div>
                <div class="callout callout-success">
                    <h4><i class="icon fa fa-info"></i>&nbsp;  Escalar Ticket:</h4>
                    <p>Para realizar un escalamiento de ticket, seleccionar el nivel de Soporte en la lista Nivel Soporte.</p>
                 </div>
            </div>
            <div class="col-md-1">

            </div>
            </div>
        </section>
   
</asp:Content>
