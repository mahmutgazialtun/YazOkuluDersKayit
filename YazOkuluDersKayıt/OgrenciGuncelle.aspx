<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="OgrenciGuncelle.aspx.cs" Inherits="YazOkuluDersKayıt.OgrenciGuncelle" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder2" runat="server">
    <form id="form1" runat="server">

        <div class="form-group">
            <div>
                <strong>
                <asp:Label for="TxtId" runat="server" Text="Öğrenci ID :" style="margin-left:60px"></asp:Label>
                </strong>
            <asp:TextBox ID="TxtId" runat="server" CssClass="form-control" style="margin-left: 60px" Width="1465px"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TxtAd" runat="server" Text="Öğrenci Adı :" style="margin-left:60px"></asp:Label>
                </strong>
            <asp:TextBox ID="TxtAd" runat="server" CssClass="form-control" style="margin-left: 60px" Width="1465px"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TxtSoyad" runat="server" Text="Öğrenci Soyadı :" style="margin-left:60px"></asp:Label>
                </strong>
            <asp:TextBox ID="TxtSoyad" runat="server" CssClass="form-control" style="margin-left: 60px" Width="1465px"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TxtNumara" runat="server" Text="Öğrenci Numara :" style="margin-left:60px"></asp:Label>
                </strong>
            <asp:TextBox ID="TxtNumara" runat="server" CssClass="form-control" style="margin-left: 60px" Width="1465px"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TxtSifre" runat="server" Text="Öğrenci Şifre :" style="margin-left:60px"></asp:Label>
                </strong>
            <asp:TextBox ID="TxtSıfre" runat="server" CssClass="form-control" style="margin-left: 60px" Width="1465px"></asp:TextBox>
            </div>
            <br />
            <div>
                <strong>
                <asp:Label for="TxtFoto" runat="server" Text="Öğrenci Fotoğraf :" style="margin-left:60px"></asp:Label>
                </strong>
            <asp:TextBox ID="TxtFoto" runat="server" CssClass="form-control" style="margin-left: 60px" Width="1465px"></asp:TextBox>
            </div>
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="Güncelle"  CssClass="btn btn-warning" style="margin-left:60px" />
    </form>
</asp:Content>
