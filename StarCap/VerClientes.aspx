<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerClientes.aspx.cs" Inherits="StarCap.VerClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Clientes</h3>
                </div>
                <div class="card-body">
                    <asp:GridView runat="server" ID="grillaClientes" CssClass="table table-hover table-bordered" AutoGenerateColumns="false">
                        <Columns>
                            <asp:BoundField DataField="Rut" HeaderText="RUT" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="NivelString" HeaderText="Nivel" />
                            <asp:BoundField DataField="BebidaFavorita" HeaderText="Bebida Favorita" />
                        </Columns>
                    </asp:GridView>
                </div>
            </div>

        </div>

    </div>
</asp:Content>
