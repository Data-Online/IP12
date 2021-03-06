﻿<%@ Register Tagprefix="IPv5" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="IPv5" Assembly="IPv5" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="ForgotUser.aspx.cs" Culture="en-NZ" MasterPageFile="../Master Pages/HorizontalNoMenu.master" Inherits="IPv5.UI.ForgotUser" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><%@ Register TagPrefix="asp" Namespace="Recaptcha" Assembly="Recaptcha" %>
<asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
     <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion">
    <asp:UpdateProgress runat="server" id="UpdatePanel1_UpdateProgress1" AssociatedUpdatePanelID="UpdatePanel1">
			<ProgressTemplate>
				<div class="ajaxUpdatePanel">
				</div>
				<div style="position:absolute; padding:30px;" class="updatingContainer">
					<img src="../Images/updating.gif" alt="Updating" />
				</div>
			</ProgressTemplate>
		</asp:UpdateProgress>
		<asp:UpdatePanel runat="server" id="UpdatePanel1" UpdateMode="Conditional">
			<ContentTemplate>
<table cellpadding="0" cellspacing="0" border="0" class="dv"><tr><td class="dh"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhb"><table><tr><td class="dht"><asp:Label runat="server" id="PanelTitle" Text="&lt;%# GetResourceValue(&quot;Title:ForgotUser&quot;, &quot;IPv5&quot;) %>">	</asp:Label></td></tr></table>
</td></tr></table>
</td></tr><tr><td class="dBody"><asp:panel id="BlankFrameCollapsibleRegion" runat="server"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SendButton")) %><table cellpadding="0" cellspacing="0" border="0" style="width: 100%"><tr><td class="securityForm"><table><tr><td style="padding-bottom: 10px;"><b><asp:Label runat="server" id="ForgotUserInfoLabel" Text="&lt;%# GetResourceValue(&quot;Txt:UserEmailed&quot;, &quot;IPv5&quot;) %>">	</asp:Label> 
<asp:Label runat="server" id="ForgotUserErrorLabel" visible="False">	</asp:Label></b></td></tr><tr><td><nobr></nobr><asp:Label runat="server" id="EnterEmailLabel" Text="&lt;%# GetResourceValue(&quot;Txt:EnterEmail&quot;, &quot;IPv5&quot;) %>">	</asp:Label> 
<br /><br />
<asp:TextBox runat="server" id="Emailaddress" columns="36">	</asp:TextBox>
	<asp:RequiredFieldValidator runat="server" id="EmailaddressRequiredFieldValidator" ControlToValidate="Emailaddress" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueIsRequired&quot;, &quot;IPv5&quot;).Replace(&quot;{FieldName}&quot;, &quot;Emailaddress&quot;) %>" enabled="True">	</asp:RequiredFieldValidator></td></tr><tr><td><asp:Label runat="server" id="FillRecaptchaLabel" Text="&lt;%# GetResourceValue(&quot;Txt:EnterCaptcha&quot;, &quot;IPv5&quot;) %>">	</asp:Label> 
<br /><br />
<asp:RecaptchaControl ID="recaptcha" runat="server" theme="clean" PublicKey="6LeFp9sSAAAAAKjEO2QQ8qAVgqD2q7BdvDNMZFkQ" PrivateKey="6LeFp9sSAAAAAPXXxTmdfi_fpaz2tkEesjL8Vz-n" /></td></tr><tr><td style="padding-top:10px;padding-bottom:10px;text-align:center;"><table border="0" cellpadding="0" cellspacin="0" style="width: 100%;"><tr><td style="width: 40%;">&nbsp;</td><td><IPv5:ThemeButton runat="server" id="SendButton" button-causesvalidation="True" button-commandname="ResetData" button-text="&lt;%# GetResourceValue(&quot;Btn:Send&quot;, &quot;IPv5&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Send&quot;, &quot;IPv5&quot;) %>" commandname="EmailLinkButton_Command"></IPv5:ThemeButton></td><td style="width: 40%;">&nbsp;</td></tr></table>
</td></tr></table>
</td></tr></table>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SendButton")) %></asp:panel></td></tr></table></ContentTemplate>
</asp:UpdatePanel>
</div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
        <div class="QDialog" id="dialog" style="display:none;">
          <iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe>
        </div>  
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>