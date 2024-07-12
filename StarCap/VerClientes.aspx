<%@ Page Title="" Language="C#" MasterPageFile="~/Principal.Master" AutoEventWireup="true" CodeBehind="VerClientes.aspx.cs" Inherits="StarCap.VerClientes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="Contenido" runat="server">
    <div class="row">
        <div class="col-lg-6 mx-auto">
            <div class="card">
                <div class="card-header bg-danger text-white">
                    <h3>Ver Clientes</h3>
                </div>
                <div class="card-body">
                    <div class="form-group">
                        <label for="nivelDbl">Filtrar por nivel:</label>
                        <asp:DropDownList runat="server" ID="nivelDbl" AutoPostBack="true" OnSelectedIndexChanged="nivelDbl_SelectedIndexChanged">
                            <asp:ListItem Value="0" Text="Todos"></asp:ListItem>
                            <asp:ListItem Value="1" Text="Silver"></asp:ListItem>
                            <asp:ListItem Value="2" Text="Gold"></asp:ListItem>
                            <asp:ListItem Value="3" Text="Platinum"></asp:ListItem>
                        </asp:DropDownList>

                    </div>
                    <asp:GridView runat="server" ID="grillaClientes" EmptyDataText="No hay clientes" ShowHeader="true" CssClass="table table-hover table-bordered" AutoGenerateColumns="false" OnRowCommand="grillaClientes_RowCommand">
                        <Columns>
                            <asp:BoundField DataField="Rut" HeaderText="RUT" />
                            <asp:BoundField DataField="Nombre" HeaderText="Nombre" />
                            <asp:BoundField DataField="NivelString" HeaderText="Nivel" />
                            <asp:BoundField DataField="BebidaFavorita" HeaderText="Bebida Favorita" />
                            <asp:TemplateField>
                                <ItemTemplate>
                                    <asp:Button  CommandName="eliminar" CommandArgument='<%# Eval("Rut") %>' runat="server" CssClass="btn btn-danger" Text="Eliminar"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
            </div>

        </div>

    </div>
</asp:Content>
