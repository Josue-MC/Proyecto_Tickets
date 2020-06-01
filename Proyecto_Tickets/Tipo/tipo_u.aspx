<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="tipo_u.aspx.cs" Inherits="Proyecto_Tickets.Tipo.tipo_u" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h1>Editar Categoría. <small>Editar los elementos de la Categoría</small><asp:Label ID="lblFecha" runat="server" CssClass="pull-right" Text="Label"></asp:Label></h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-3">

            </div>
            <div class="col-md-6">
                <!--Nuevo Ticket Box -->
                <div class="box box-success">
                <div class="box-header">
                  <h3 class="box-title">Editar Categoría: #<asp:Label ID="lblID_Tipo" runat="server" Text="Label"></asp:Label></h3>
                  <div class="box-tools pull-right">
                    <button class="btn btn-box-tool" data-widget="collapse" data-toggle="tooltip" title="" data-original-title="Collapse"><i class="fa fa-minus"></i></button>
                  </div>
                </div>
                <form role="form">
                    <div class="box-body">
                        <div class="form-group">
                            <label>Nombre:</label>
                            <asp:TextBox ID="txtNombre" CssClass="form-control" AutoComplete="false" runat="server"></asp:TextBox>
                         <div class="form-group">
                            <label>Descripción:</label>
                             <asp:TextBox ID="txtDescripcion" class="form-control" TextMode="MultiLine" Columns="50" Rows="3" placeholder="Descripción ..." runat="server"></asp:TextBox>
               
                          </div>
                     </div><!-- /.box-body -->
                    <div class="box-footer">
                        <div class="form-group">
                            <asp:Button ID="btnEditarTipo" runat="server" Text="Editar" CssClass="btn btn-block btn-success center-block" OnClick="btnEditarTipo_Click"  />
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
