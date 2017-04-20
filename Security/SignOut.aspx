﻿<%@ Register Tagprefix="IPv5" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="SignOut.aspx.cs" Culture="en-NZ" MasterPageFile="../Master Pages/HorizontalNoMenu.master" Inherits="IPv5.UI.SignOut" %>
<%@ Register Tagprefix="Selectors" Namespace="IPv5" Assembly="IPv5" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><asp:Content id="Content" ContentPlaceHolderID="PageContent" runat="server">
     <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">
          <table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dht" valign="middle"><asp:Literal runat="server" id="DialogTitle" Text="&lt;%# GetResourceValue(&quot;Txt:SignOut&quot;, &quot;IPv5&quot;) %>">	</asp:Literal></td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>
</td><td class="panelHeaderR"></td></tr><tr><td class="dBody"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("ForgetSignInButton")) %><asp:panel id="SignOutCollapsibleRegion" runat="server"><table cellpadding="0" cellspacing="0" border="0" style="width:100%;"><tr><td><div class="securityGraphicWrapper"><asp:Image runat="server" id="Image" alt="&lt;%# GetResourceValue(&quot;Txt:PageHeader&quot;, &quot;IPv5&quot;) %>" imageurl="../Images/SignOutPageGraphic.jpg" style="border-width:0px;">		
	</asp:Image></div>
    </td><td class="securityForm"><table><tr><td><asp:Label runat="server" id="SignOutMessage" Text="&lt;%# GetResourceValue(&quot;Txt:SuccessfullySignOut&quot;, &quot;IPv5&quot;) %>">	</asp:Label><br /><br /></td></tr><tr><td align="center"><IPv5:ThemeButton runat="server" id="ForgetSignInButton" button-causesvalidation="False" button-commandname="ForgetSignInInformation" button-text="&lt;%# GetResourceValue(&quot;Btn:ForgetSignInButton&quot;, &quot;IPv5&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Txt:ForgetSignInButton&quot;, &quot;IPv5&quot;) %>"></IPv5:ThemeButton></td></tr><tr><td><asp:Label id="CloseWindowMessage" runat="server" Text="<%# GetResourceValue(&quot;Txt:CloseWindowMessage&quot;, &quot;IPv5&quot;) %>" />&nbsp;</td></tr></table>
</td></tr></table></asp:panel>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("ForgetSignInButton")) %></td></tr><tr><td class="panelB"></td></tr></table></div><div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
        <div class="QDialog" id="dialog" style="display:none;">
          <iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe>
        </div>  
          <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
          