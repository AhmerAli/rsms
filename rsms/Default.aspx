<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="rsms._Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
    <ajaxToolkit:AutoCompleteExtender
        ID="AutoCompleteExtender1"
        runat="server"
        ServiceMethod="GetParentID"
        ServicePath="~/Services.asmx"
        TargetControlID="TextBox1"
        MinimumPrefixLength="1"
        UseContextKey="false"
        CompletionInterval="0" 
        EnableCaching="true" 
        CompletionSetCount="30" 
        FirstRowSelected="true">
        

    </ajaxToolkit:AutoCompleteExtender>

</asp:Content>
