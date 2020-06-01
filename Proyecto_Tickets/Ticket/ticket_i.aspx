<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="ticket_i.aspx.cs" Inherits="Proyecto_Tickets.Ticket.ticket_i" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h1>Agregar Ticket Abierto. <small>Ticket en estado de Desarrollo.</small><asp:Label ID="lblFecha" runat="server" CssClass="pull-right" Text="Label"></asp:Label></h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6">
                <!--Nuevo Ticket Box -->
                <div class="box box-success">
                <div class="box-header">
                  <h3 class="box-title">Nuevo Ticket</h3>
                  <div class="box-tools pull-right">
                    <button class="btn btn-box-tool" data-widget="collapse" data-toggle="tooltip" title="" data-original-title="Collapse"><i class="fa fa-minus"></i></button>
                  </div>
                </div>
                <form role="form">
                    <div class="box-body">
                        <div class="form-group">
                            <label>Título:</label>
                            <asp:TextBox ID="txtTitulo" MaxLength="20" CssClass="form-control span6" placeholder="Ticket-Categoría-DD" AutoComplete="off" runat="server"></asp:TextBox>
                             <asp:RequiredFieldValidator ID="rfvTitulo" runat="server" ControlToValidate="txtTitulo"
                           validationGroup="vlg1"  ErrorMessage="*" Display="Dynamic" ForeColor="red"></asp:RequiredFieldValidator>

                         <div class="form-group">
                            <label>Descripción:</label>
                             <asp:TextBox ID="txtDescripcion" class="form-control" TextMode="MultiLine" Columns="50" Rows="3" placeholder="Descripción ..." runat="server"></asp:TextBox>
                              <asp:RequiredFieldValidator ID="rfvDescripcion" runat="server" ControlToValidate="txtDescripcion"
                           validationGroup="vlg1"  ErrorMessage="*" Display="Dynamic" ForeColor="red"></asp:RequiredFieldValidator>
               
                          </div>
                        <div class="row">
                            <div class="col-xs-6">
                                <label>Producto/servicio:</label><asp:DropDownList ID="ddlCategoría" CssClass="form-control" runat="server"></asp:DropDownList>
                                 <asp:RequiredFieldValidator ID="rfvCategoria" runat="server" ControlToValidate="ddlCategoría"
                           validationGroup="vlg1"  ErrorMessage="*" Display="Dynamic" InitialValue="0" ForeColor="red"></asp:RequiredFieldValidator>
                                <label>Cliente:</label><asp:DropDownList ID="ddlUsuario" CssClass="form-control" runat="server"></asp:DropDownList>
                                <asp:RequiredFieldValidator ID="rfvUsuario" runat="server" ControlToValidate="ddlUsuario"
                           validationGroup="vlg1"  ErrorMessage="*" Display="Dynamic" InitialValue="0" ForeColor="red"></asp:RequiredFieldValidator>
                                <label>Estado:</label><asp:DropDownList ID="ddlStatus" CssClass="form-control" runat="server" disabled="true"></asp:DropDownList>
                            </div>
                            <div class="col-xs-6">
                                <label>Categoría:</label><asp:DropDownList ID="ddlTipo" CssClass="form-control" runat="server"></asp:DropDownList>
                                <asp:RequiredFieldValidator ID="rfvTipo" runat="server" ControlToValidate="ddlTipo"
                           validationGroup="vlg1"  ErrorMessage="*" Display="Dynamic" InitialValue="0" ForeColor="red"></asp:RequiredFieldValidator>
                                <label>Fecha Creación:</label><asp:TextBox ID="txtFechaCreacion" CssClass="form-control"  AutoComplete="false" Enabled="false"  runat="server"></asp:TextBox>
                                <label>Nivel Soporte:</label><asp:TextBox ID="txtNivelSoporte" CssClass="form-control" disabled="true" AutoComplete="false" runat="server"></asp:TextBox>
                            </div>
                        </div>
                        </div>
                    </div><!-- /.box-body -->
                    <div class="box-footer">
                        <div class="form-group">
                            <asp:Button ID="btnAgregarTicket" runat="server" Text="Agregar" CssClass="btn btn-block btn-success center-block" OnClick="btnAgregarTicket_Click" ValidationGroup="vlg1" />
                        </div>
                    </div>
                </form>
              </div>
            </div>
            <div class="col-md-6">
                <!--View State Box-->
                <div class="box box-solid box-primary">
                <div class="box-header">
                  <h3 class="box-title">Recuento de tickets</h3>
                  <div class="box-tools pull-right">
                    <button class="btn btn-primary btn-sm" data-widget="collapse"><i class="fa fa-minus"></i></button>
   
                  </div>
                </div>
                <div class="box-body no-padding">
                    <asp:GridView ID="grdTickets" CssClass="table table-condensed" runat="server" AutoGenerateColumns="false" OnRowCommand="grdTickets_RowCommand" >
                        <Columns>
                            <asp:TemplateField >
                                <ItemTemplate>
                                    <asp:ImageButton ID="btnEditar" runat="server"  ImageUrl="../../dist/img/draw.png" height="20px" Width="20px" 
                                        commandName="Editar" CommandArgument='<%# Eval("ID_Ticket") %>'/>
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="#ID" DataField="ID_Ticket"/>
                            <asp:BoundField HeaderText="Titulo" DataField="titulo" />
                            <asp:BoundField HeaderText="Estado" DataField="status" />
                        </Columns>
                    </asp:GridView>
                </div><!-- /.box-body -->
              </div>
            </div>
        </div>
    </section>
</asp:Content>
