<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Customer_Management_System3.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel='stylesheet' type='text/css' media='screen' href='./Style.css'/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            
            
            <div class="elements">
                <div id="upform">
                    <asp:TextBox class="Search" ID="TextBox1" runat="server" placeholder="Aramak istediğiniz ismi girin" Height="39px"></asp:TextBox>
                <asp:Button ID="Button1" runat="server" Text="Ara" onClick="Button1_Click" />
                    <asp:Button ID="ButtonNewCustomer" runat="server" Text="Yeni Müşteri Oluştur" OnClick="ButtonNewCustomer_Click" />
                    <asp:Button ID="PaidUpdate" runat="server" Text="Borç Bilgisi Güncelle" OnClick="PaidUpdate_Click" />
                    <asp:Button ID="UpdateCustomer" runat="server" Text="Müşteri Bilgisi Güncelle" OnClick="UpdateCustomer_Click" />
                    
                </div>
                
                <div class="form" id="Invisible">
                    <asp:Label ID="Label4" runat="server" Text="Yeni Müşteri Oluştur"></asp:Label>
                    <asp:Label class="label" ID="Label1" runat="server" Text="Label">İsim-Soyisim</asp:Label>
                    <asp:TextBox CssClass="Textbox" ID="TextBox2" runat="server"></asp:TextBox>
                    <asp:Label class="label" ID="Label2" runat="server" Text="Labe2">Ürün İsim</asp:Label>
                    <asp:TextBox CssClass="Textbox" ID="TextBox3" runat="server"></asp:TextBox>
                    <asp:Label class="label" ID="Label3" runat="server" Text="Labe3">Ürün Fiyatı</asp:Label>
                    <asp:TextBox CssClass="Textbox" ID="TextBox4" runat="server"></asp:TextBox>

                    <div class="odeme">
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="Peşin"/>
                        <asp:CheckBox ID="CheckBox2" runat="server" Text="Taksit"/>
                        
                        <asp:DropDownList ID="DropDownList1" runat="server">
                            <asp:ListItem Text="8" Value="8">8</asp:ListItem>
                            <asp:ListItem Text="12" Value="12">12</asp:ListItem>
                            <asp:ListItem Text="24" Value="24">24</asp:ListItem>

                        </asp:DropDownList>
                    </div>

                    <div class="form-buttons">
                        <asp:Button class="ekle" ID="Button2" runat="server" Text="Ekle" onClick="Button2_Click"/>
                        <asp:Button class="temizle" ID="Button3" runat="server" Text="Temizle" onClick="Button3_Click"/>
                    </div>
                    <asp:Button class="show" ID="Button4" runat="server" Text="Tüm Listeyi Görüntüle" onClick="Button4_Click" />
                    <asp:Label ID="LabelInfo" runat="server" ></asp:Label>
                    
                    <div class="debt">
                        <asp:Label ID="Label5" runat="server" Text="Yeni Borç Bilgileri" ></asp:Label>
                        <asp:Label class="label" ID="Label6" runat="server" Text="İsim-Soyisim"></asp:Label>
                        <asp:TextBox CssClass="Textbox" ID="TextBox5" runat="server"></asp:TextBox>
                        <asp:Label class="label" ID="Label7" runat="server" Text="Ödeme Tutarı"></asp:Label>
                        <asp:TextBox CssClass="Textbox" ID="TextBox6" runat="server"></asp:TextBox>
                        <asp:Button ID="Button5" runat="server" Text="Güncelle" OnClick="Button5_Click" />
                    </div>

                    <div class="update">
                        <asp:Label ID="Label8" runat="server" Text="Müşteri Bilgileri Güncelle"></asp:Label>
                    <asp:Label class="label" ID="Label9" runat="server" Text="Label">İsim-Soyisim</asp:Label>
                    <asp:TextBox CssClass="Textbox" ID="TextBox7" runat="server"></asp:TextBox>
                    <asp:Label class="label" ID="Label10" runat="server" Text="Labe2">Ürün İsim</asp:Label>
                    <asp:TextBox CssClass="Textbox" ID="TextBox8" runat="server"></asp:TextBox>
                    <asp:Label class="label" ID="Label11" runat="server" Text="Labe3">Ürün Fiyatı</asp:Label>
                    <asp:TextBox CssClass="Textbox" ID="TextBox9" runat="server"></asp:TextBox>

                    <div class="odeme">
                        <asp:CheckBox ID="CheckBox3" runat="server" Text="Peşin"/>
                        <asp:CheckBox ID="CheckBox4" runat="server" Text="Taksit"/>
                        
                        <asp:DropDownList ID="DropDownList2" runat="server">
                            <asp:ListItem Text="8" Value="8">8</asp:ListItem>
                            <asp:ListItem Text="12" Value="12">12</asp:ListItem>
                            <asp:ListItem Text="24" Value="24">24</asp:ListItem>

                        </asp:DropDownList>
                    </div>
                        <asp:Button ID="Button6" runat="server" Text="Güncelle" OnClick="Button6_Click" />

                    </div>

            </div>
            </div>
            
                <div id="grid-list-all">
                    <asp:GridView ID="GridView1" runat="server">

                    </asp:GridView>
                </div>
           
                <div id="grid-list-search">
                    <asp:GridView ID="GridView2" runat="server"></asp:GridView>
                </div>
           
            
            </div>
    </form>
   
</html>
