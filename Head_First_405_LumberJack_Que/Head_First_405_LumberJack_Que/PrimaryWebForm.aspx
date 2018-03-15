<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PrimaryWebForm.aspx.cs" Inherits="Head_First_405_LumberJack_Que.PrimaryWebForm" %>

<!DOCTYPE html>
<link rel="stylesheet" type="text/css" href="/MainStyleSheet.css">
<html xmlns="http://www.w3.org/1999/xhtml">

<head runat="server">
  <title></title>
</head>
<body>
  <form id="form1" runat="server">
    <div>
      <div class="wrapper">
        <div class="one">
          Lumberjack Name 
          <br />
          <asp:TextBox ID="TextBox1" CssClass="textbox" runat="server" Width="198px"></asp:TextBox>
          <br />
          <br />
          <asp:Button ID="AddLumberJackButton" CssClass="buttonModify" runat="server" Text="Add Lumberjack" Width="210px" OnClick="AddLumberJackButton_Click" />
          <br />
        </div>
        <div class="two">
          <br />
          Breakfast Line
          <br />
          <asp:ListBox ID="Line" runat="server" Height="176px" Width="210px"></asp:ListBox>
          <br />
          <br />
          Output Window<br />
          <asp:ListBox ID="OutputListBox" runat="server" Width="210px" Height="150px"></asp:ListBox>
          <br />
        </div>
        <div class="three">
          <br />
          Feed A Lumberjack (Enter # of Lumberjacks)<br />
          <asp:TextBox ID="PanCakeNumBox1" runat="server" Height="59px" Width="210px" GroupName="FlapJacks"></asp:TextBox>

          <br />
          <br />
          <asp:RadioButton ID="CrispyRadioButton1" runat="server" EnableViewState="False" GroupName="FlapJacks" />
          Crispy
          <br />
          <asp:RadioButton ID="SoggyRadioButton1" runat="server" GroupName="FlapJacks" />
          Soggy
          <br />
          <asp:RadioButton ID="BrownedRadioButton1" runat="server" GroupName="FlapJacks" />
          Browned
          <br />
          <asp:RadioButton ID="BananaRadioButton2" runat="server" GroupName="FlapJacks" />
          Banana
          <br />
          <br />
          <asp:Button ID="Addflapjacks" CssClass="buttonModify" runat="server" Text="Add Flapjacks" Width="210px" OnClick="Addflapjacks_Click" />
          <br />
          <br />
          <asp:Label ID="nextInLine" CssClas="labelModify" runat="server" Text=""></asp:Label>
          <br />
          <br />
          <asp:Button ID="NextLumberJackButton" CssClass="buttonModify" runat="server" Text="Next Lumberjack" Width="210px" OnClick="NextLumberJackButton_Click" />
        </div>
      </div>
    </div>
  </form>
</body>
</html>
