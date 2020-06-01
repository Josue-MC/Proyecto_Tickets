<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="cliente_i.aspx.cs" Inherits="Proyecto_Tickets.Clientes.cliente_i" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <section class="content-header">
        <h1>Agregar Cliente. <small>Formulario de Registro de Cliente.</small><asp:Label ID="lblFecha" runat="server" CssClass="pull-right" Text="Label"></asp:Label></h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-3">

            </div>
            <div class="col-md-6">
                <div class="box box-success">
                    <div class="box-header">
                        <h3 class="box-title">Nuevo Cliente</h3>
                    </div>
                    <form role="form">
                        <div class="box-body">
                            <div class="form-group">
                                <label>Nombre(s):</label>
                                <asp:TextBox ID="txtNombre" MaxLength="20" CssClass="form-control span6" placeholder="Nombre" AutoComplete="off" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvNombre" runat="server" ControlToValidate="txtNombre"
                           validationGroup="vlg1"  ErrorMessage="*" Display="Dynamic" ForeColor="red"></asp:RequiredFieldValidator>

                            </div>
                            <div class="form-group">
                                <label>Apellidos:</label>
                                <asp:TextBox ID="txtApellidos" MaxLength="40" CssClass="form-control span6" placeholder="Apellidos" AutoComplete="off" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvApellidos" runat="server" ControlToValidate="txtApellidos"
                           validationGroup="vlg1"  ErrorMessage="*" Display="Dynamic" ForeColor="red"></asp:RequiredFieldValidator>

                            </div>
                            <div class="form-group">
                                <label>Correo Electrónico:</label>
                                <asp:TextBox ID="txtCorreo" MaxLength="40" TextMode="Email" CssClass="form-control span6" placeholder="name@correo.com" AutoComplete="off" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvCorreo" runat="server" ControlToValidate="txtCorreo"
                           validationGroup="vlg1"  ErrorMessage="*" Display="Dynamic" ForeColor="red"></asp:RequiredFieldValidator>

                            </div>
                            <div class="form-group">
                                <label>Teléfono:</label>
                                <asp:TextBox ID="txtTelefono" MaxLength="20" TextMode="Number" CssClass="form-control span6"  AutoComplete="off" runat="server"></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvTelefono" runat="server" ControlToValidate="txtTelefono"
                           validationGroup="vlg1"  ErrorMessage="*" Display="Dynamic" ForeColor="red"></asp:RequiredFieldValidator>

                            </div>
                            <div class="form-group">
                                <label>Género:</label>
                                <asp:DropDownList ID="ddlSexo" runat="server"></asp:DropDownList>
                                <asp:RequiredFieldValidator ID="rfvSexo" runat="server" ControlToValidate="ddlSexo" InitialValue="0"
                           validationGroup="vlg1"  ErrorMessage="*" Display="Dynamic" ForeColor="red"></asp:RequiredFieldValidator>

                            </div>
                        </div>
                    <div class="box-footer">
                        <div class="form-group">
                            <asp:Button ID="btnAgregarCliente" runat="server" Text="Agregar" CssClass="btn btn-block btn-success center-block" OnClick="btnAgregarCliente_Click" ValidationGroup="vlg1" />
                        </div>
                    </div>
                    </form>
                </div>
            </div>
            <div class="col-md-3">

            </div>
        </div>
    </section>
</asp:Content>
