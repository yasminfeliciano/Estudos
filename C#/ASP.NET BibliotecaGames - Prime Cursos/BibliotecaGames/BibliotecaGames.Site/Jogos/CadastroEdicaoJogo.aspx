<%@ Page Title="" Language="C#" MasterPageFile="~/Jogos/SiteMasterPage.Master" AutoEventWireup="true" CodeBehind="CadastroEdicaoJogo.aspx.cs" Inherits="BibliotecaGames.Site.Jogos.CadastroEdicaoJogo" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="form-horizontal"> 
        <div class="form-group">
            <div class="col-md-2">
                <label for="exampleInputEmail">Título</label>
                <asp:TextBox runat="server" ID="TxtTitulo" CssClass="form-control"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RfvTitulo" runat="server" ControlToValidate="TxtTitulo" ErrorMessage="É necessário preencher o campo Título"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-2">
                <label for="exampleInputEmail">Valor Pago</label>
                <asp:TextBox runat="server" ID="TxtValorPago" CssClass="form-control" TextMode="Number"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-2">
                <label for="exampleInputEmail">Data Compra</label>
                <asp:TextBox runat="server" ID="TxtDataCompra" CssClass="form-control" TextMode="Date"></asp:TextBox>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-2">
                <label for="exampleInputEmail">Imagem</label>
                <asp:FileUpload runat="server" ID="fileUploadImage" CssClass="form-control"></asp:FileUpload>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-2">
                <label for="exampleInputEmail">Gênero</label>
                <asp:DropDownList runat="server" DataValueField="id" DataTextField="descricao" ID="DdlGenero" CssClass="form-control"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RfvGenero" runat="server" ControlToValidate="DdlGenero" ErrorMessage="É necessário preencher o campo Gênero"></asp:RequiredFieldValidator>
            </div>
        </div>

        <div class="form-group">
            <div class="col-md-2">
                <label for="exampleInputEmail">Editor</label>
                <asp:DropDownList runat="server" DataValueField="id" DataTextField="nome" ID="DdlEditor" CssClass="form-control"></asp:DropDownList>
                <asp:RequiredFieldValidator ID="RfvEditor" runat="server" ControlToValidate="DdlEditor" ErrorMessage="É necessário preencher o campo Editor"></asp:RequiredFieldValidator>
            </div>
        </div>

        <asp:ValidationSummary ID="valSum"
                            DisplayMode="BulletList"
                            EnableClientScript="true"
                            ForeColor="Red"
                            HeaderText="Você precisa corrigir os seguintes campos:"
                            runat="server" />

        <asp:Label runat="server" ID="LblMensagem"></asp:Label>
        <br />
        <asp:Button ID="BtnGravar" Text="Gravar" CssClass="btn btn-primary" runat="server" OnClick="BtnGravar_Click"/>
        <br />
        <a href="Catalogo.aspx">Voltar ao catálogo de jogos</a> 
    </div>
</asp:Content>
