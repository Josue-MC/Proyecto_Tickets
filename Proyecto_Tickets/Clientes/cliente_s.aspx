<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="cliente_s.aspx.cs" Inherits="Proyecto_Tickets.Clientes.cliente_s" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h1>Consulta de Clientes <small></small><asp:Label ID="lblFecha" runat="server" CssClass="pull-right" Text="Label"></asp:Label></h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-xs-12">
                <div class="box grd">
                    <div class="box-header">
                  <h3 class="box-title">Clientes  Registrados.</h3>
                    </div>
                    <div class="box-body">
                        <div class="row">
                            <div class="col-xs-1">

                            </div>
                            <div class="col-xs-3">
                            
                                <asp:TextBox ID="txtSearch" runat="server" AutoComplete="off" placeholder="correo..."  CssClass="form-control" ></asp:TextBox>
                                <asp:RequiredFieldValidator ID="rfvSearch" runat="server" ControlToValidate="txtSearch"
                           validationGroup="vlg1"  ErrorMessage="*" Display="Dynamic"  ForeColor="red"></asp:RequiredFieldValidator>
                                
                            </div>
                            <div class="col-xs-3">
                                <asp:Button ID="btnSearch" CssClass="btn btn-block btn-info" runat="server" Text="Buscar" OnClick="btnSearch_Click" ValidationGroup="vlg1" />
                                
                              </div>
                            <div class="col-xs-2">
                                <asp:Button ID="btnCargar" CssClass="btn btn-block btn-info" runat="server" Text="Cargar" OnClick="btnCargar_Click" />
                            </div>
                            <div class="col-xs-2">
                                 <asp:Button ID="btnAgregar" CssClass="btn btn-block btn-info" runat="server" Text="Agregar" OnClick="btnAgregar_Click" />
                            </div>
                            <div class="col-xs-1">

                            </div>

                        </div>
                       
                        <br />
                        <asp:GridView ID="grdClientes" AutoGenerateColumns="false" runat="server" CssClass="table table-bordered table-striped dataTable" OnRowCommand="grdClientes_RowCommand" >
                            <Columns>
                               
                            <asp:BoundField HeaderText="#ID" DataField="ID_Cliente"/>
                            <asp:BoundField HeaderText="Nombre" DataField="nombre" />
                            <asp:BoundField HeaderText="Apellidos" DataField="apellidos" />
                            <asp:BoundField HeaderText="Correo" DataField="email" />
                            <asp:BoundField HeaderText="Teléfono" DataField="telefono" />
                            </Columns>
                        </asp:GridView>

                        
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
