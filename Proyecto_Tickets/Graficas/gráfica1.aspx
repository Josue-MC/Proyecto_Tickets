<%@ Page Title="" Language="C#" MasterPageFile="~/site.Master" AutoEventWireup="true" CodeBehind="gráfica1.aspx.cs" Inherits="Proyecto_Tickets.Graficas.gráfica1" %>

<%@ Register Assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" Namespace="System.Web.UI.DataVisualization.Charting" TagPrefix="asp" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="content-header">
        <h1>Gráficas. <small>Datos representados gráficamente</small><asp:Label ID="lblFecha" runat="server" CssClass="pull-right" Text="Label"></asp:Label></h1>
    </section>
    <section class="content">
        <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-header">
                        <i class="fa fa-bar-chart-o"></i>
                        <h3 class="box-title">Tickets - Status</h3>
                    </div>
                    <div class="box-body text-center">
                        <asp:Chart ID="ChartEstado" runat="server" Palette="SeaGreen">
                            <Series>
                                <asp:Series Name="Series1" ChartType="Doughnut"></asp:Series>
                            </Series>
                            <ChartAreas>
                                <asp:ChartArea Name="ChartArea1"></asp:ChartArea>
                            </ChartAreas>
                        </asp:Chart>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-header">
                        <i class="fa fa-bar-chart-o"></i>
                        <h3 class="box-title">Tickets - Productos/Servicios</h3>
                    </div>
                    <div class="box-body text-center">
                        <asp:Chart ID="ChartCategoria" runat="server" Palette="Excel">
                            <Series>
                                <asp:Series Name="Series2"></asp:Series>
                            </Series>
                            <ChartAreas>
                                <asp:ChartArea Name="ChartArea2"></asp:ChartArea>
                            </ChartAreas>
                        </asp:Chart>
                    </div>
                </div>
            </div>
        </div>
             <div class="row">
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-header">
                        <i class="fa fa-bar-chart-o"></i>
                        <h3 class="box-title">Tickets - Categorías</h3>
                    </div>
                    <div class="box-body text-center">
                        <asp:Chart ID="ChartTipo" runat="server" Palette="Excel">
                            <Series>
                                <asp:Series Name="Series3"></asp:Series>
                            </Series>
                            <ChartAreas>
                                <asp:ChartArea Name="ChartArea3"></asp:ChartArea>
                            </ChartAreas>
                        </asp:Chart>
                    </div>
                </div>
            </div>
            <div class="col-md-6">
                <div class="box box-primary">
                    <div class="box-header">
                        <i class="fa fa-bar-chart-o"></i>
                        <h3 class="box-title">Tickets - Niveles Soporte</h3>
                    </div>
                    <div class="box-body text-center">
                        <asp:Chart ID="ChartNivel" runat="server" Palette="Excel">
                            <Series>
                                <asp:Series Name="Series4"></asp:Series>
                            </Series>
                            <ChartAreas>
                                <asp:ChartArea Name="ChartArea4"></asp:ChartArea>
                            </ChartAreas>
                        </asp:Chart>
                    </div>
                </div>
            </div>
        </div>

    </section>
</asp:Content>
