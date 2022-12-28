<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="projeee.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="background-color:rgba(255, 99, 71, 0.5);" >
 <font face="Arial">   
    <form id="form1" runat="server">
      <table width="50%" border="1">   
          <tr>  
              <td colspan="2" margin="10"  >  
                 İsim
              <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
          </tr>
          <tr>
              <td margin="1">
                  Soyad
              <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox></td>
          </tr>
          <tr>
              <td>Seçenekler
               <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                   <asp:ListItem Selected="True">Seçiniz</asp:ListItem>
                   <asp:ListItem>Çanta</asp:ListItem>
                   <asp:ListItem>Kalem</asp:ListItem>
                   <asp:ListItem>Silgi</asp:ListItem>
                   <asp:ListItem>Defter</asp:ListItem>
                   <asp:ListItem>Kalem Kutu</asp:ListItem>
               </asp:DropDownList>
              </td>
           </tr>
          <tr>  
              <td>
                  Renk
              <asp:TextBox  ID="TextBox3" runat="server"></asp:TextBox></td>
          </tr>
          <tr>  
              <td>
                  Miktar
              <asp:TextBox  ID="TextBox4" runat="server"></asp:TextBox></td>
          </tr>
          <tr>  
              <td>
                  Bakiye
              <asp:TextBox  ID="TextBox5" runat="server"></asp:TextBox></td>
          </tr>
          <tr>  
              <td >
                <asp:DropDownList ID="az" runat="server">
                 <asp:ListItem>2 Gözlü</asp:ListItem>
                 <asp:ListItem>3 Gözlü</asp:ListItem>
                 <asp:ListItem>4 Gözlü</asp:ListItem>
                </asp:DropDownList>
              </td>
          </tr>
          <tr>  
              <td >
                <asp:DropDownList ID="yeto" runat="server">
                 <asp:ListItem>Kurşun Kalem</asp:ListItem>
                 <asp:ListItem>Tükenmez Kalem</asp:ListItem>
                 <asp:ListItem>Dolma Kalem</asp:ListItem>
                </asp:DropDownList>
              </td>
          </tr>
          <tr>  
              <td >
                <asp:DropDownList ID="ofua" runat="server">
                 <asp:ListItem>Kokulu</asp:ListItem>
                 <asp:ListItem>Kokusuz</asp:ListItem>
                </asp:DropDownList>
              </td>
          </tr>
          <tr>  
              <td >
                <asp:DropDownList ID="yavru" runat="server">
                 <asp:ListItem>Kareli</asp:ListItem>
                 <asp:ListItem>Çizgili</asp:ListItem>
                 <asp:ListItem>Düz</asp:ListItem>
                </asp:DropDownList>
              </td>
          </tr>
           <tr>  
              <td >
                <asp:DropDownList ID="mark" runat="server">
                 <asp:ListItem>Fermuarlı</asp:ListItem>
                 <asp:ListItem>2 Fermuarlı</asp:ListItem>
                 <asp:ListItem>3 Fermuarlı</asp:ListItem>
                </asp:DropDownList>
              </td>
          </tr>
          <tr >  
              <th >
                  <asp:Button ID="Button1" runat="server" Text="Satın Al" OnClick="Button1_Click"></asp:Button>
              </th>           
          </tr>


      </table>
        <asp:ListBox id="lste" Width="50%" length="20px" runat="server"></asp:ListBox>
      
    </form>
</font>
</body>
</html>
