<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="Tipo_is.aspx.cs" Inherits="Proyecto_Tickets.Tipo.Tipo_is" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h1>Categorías. <small>Categorías de Tickets.</small><asp:Label ID="lblFecha" runat="server" CssClass="pull-right" Text="Label"></asp:Label></h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6">
                <!--Nuevo Categoría Box -->
                <div class="box box-success">
                <div class="box-header">
                  <h3 class="box-title">Categorías</h3>
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
                        </div>
                    </div><!-- /.box-body -->
                    <div class="box-footer">
                        <div class="form-group">
                            <asp:Button ID="btnAgregarTipo" runat="server" Text="Agregar" CssClass="btn btn-block btn-success center-block" OnClick="btnAgregarTipo_Click"  />
                        </div>
                    </div>
                </form>
              </div>
            </div>
            <div class="col-md-6">
                <!--View State Box-->
                <div class="box box-solid box-primary">
                <div class="box-header">
                  <h3 class="box-title">Categorías</h3>
                  <div class="box-tools pull-right">
                    <button class="btn btn-primary btn-sm" data-widget="collapse"><i class="fa fa-minus"></i></button>
   
                  </div>
                </div>
                <div class="box-body no-padding">
                    <asp:GridView ID="grdCategoria" CssClass="table table-condensed" runat="server" AutoGenerateColumns="false" OnRowCommand="grdCategoria_RowCommand">
                        <Columns>
                            <asp:TemplateField >
                                <ItemTemplate>
                                    <asp:Button ID="btnEditar" class="btn btn-block btn-default" runat="server" Text="Editar" CommandName="Editar1"  CommandArgument='<%# Eval("ID_Tipo") %>' UseSubmitBehavior="false" />
                                </ItemTemplate>
                            </asp:TemplateField>
                            <asp:BoundField HeaderText="#ID" DataField="ID_Tipo"/>
                            <asp:BoundField HeaderText="Nombre" DataField="nombre" />
                            <asp:BoundField HeaderText="Descripcion" DataField="descripcion" />
                        </Columns>
                    </asp:GridView>
                </div><!-- /.box-body -->
              </div>
            </div>
        </div>
    </section>
</asp:Content>
