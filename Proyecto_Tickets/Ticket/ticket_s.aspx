<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="ticket_s.aspx.cs" Inherits="Proyecto_Tickets.Ticket.ticket_s" EnableViewState="true" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <section class="content-header">
        <h1>Consulta de Tickets. <small></small><asp:Label ID="lblFecha" runat="server" CssClass="pull-right" Text="Label"></asp:Label></h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-xs-12">
                <div class="box grd">
                    <div class="box-header">
                  <h3 class="box-title">Tickets <strong><asp:Label ID="lblNivel" runat="server" Text="Label"></asp:Label></strong>  de soporte.</h3>
                    </div>
                    <div class="box-body">
                        <div class="row">
                            <div class="col-xs-2">

                            </div>
                            <div class="col-xs-3">
                            
                                <asp:TextBox ID="txtSearch" runat="server" placeholder="#ID" AutoComplete="false" CssClass="form-control" ></asp:TextBox>
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

                            </div>

                        </div>
                        <!--
                        <div class="row">
                            <div class="col-xs-3">
                            <asp:DropDownList ID="ddlStatus" runat="server" CssClass="form-control"></asp:DropDownList>
                           </div>
                            <div class="col-xs-3">
                            <asp:DropDownList ID="ddlCategoría" runat="server" CssClass="form-control"></asp:DropDownList>
                           </div>
                            <div class="col-xs-3">
                            <asp:DropDownList ID="ddlTipo" runat="server" CssClass="form-control"></asp:DropDownList>
                           </div>
                            <div class="col-xs-3">
                                <asp:Button ID="btnconsultar" CssClass="form-control" runat="server" Text="Button" OnClick="btnconsultar_Click" AutoPostBack="false" />
                           </div>
                        </div>
                         -->
                        <br />
                        <asp:GridView ID="grdTickets" AutoGenerateColumns="false" runat="server" CssClass="table table-bordered table-striped dataTable" OnRowCommand="grdTickets_RowCommand" >
                            <Columns>
                                <asp:TemplateField >
                                <ItemTemplate>
                                    <asp:Button ID="btnEditar" class="btn btn-block btn-default" runat="server" Text="Editar" CommandName="Editar1"  CommandArgument='<%# Eval("ID_Ticket") %>' UseSubmitBehavior="false" />
                                </ItemTemplate>
                            </asp:TemplateField>
                                <asp:TemplateField >
                                <ItemTemplate>
                                   <asp:Button ID="btnEliminar" class="btn btn-block btn-default" runat="server" Text="Eliminar" CommandName="Eliminar1" CommandArgument='<%# Eval("ID_Ticket") %>' UseSubmitBehavior="false" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="#ID" DataField="ID_Ticket"/>
                            <asp:BoundField HeaderText="Titulo" DataField="titulo" />
                            <asp:BoundField HeaderText="Estado" DataField="nombreStatus" />
                            <asp:BoundField HeaderText="Producto/Servicio" DataField="nombreCategoria" />
                            <asp:BoundField HeaderText="Categoria" DataField="nombreTipo" />
                            <asp:BoundField HeaderText="Fecha de Creación" DataField="fecha_creacion" DataFormatString="{0:dd/MM/yyyy}" />
                            <asp:BoundField HeaderText="Fecha de Termino" DataField="fecha_termino" DataFormatString="{0:dd/MM/yyyy}" />
                            <asp:BoundField HeaderText="Usuario Asignado" DataField="nombreID_Asignado" />
                            <asp:BoundField HeaderText="Cliente" DataField="ID_Usuario" />

                            </Columns>
                        </asp:GridView>

                        
                    </div>
                </div>
            </div>
        </div>
    </section>
</asp:Content>
