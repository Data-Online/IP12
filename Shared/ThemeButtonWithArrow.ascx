﻿<%@ Register Tagprefix="Selectors" Namespace="IPv5" Assembly="IPv5" %>

<%@ Control Language="C#" AutoEventWireup="false" Codebehind="ThemeButtonWithArrow.ascx.cs" Inherits="IPv5.UI.ThemeButtonWithArrow" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %><table class="buttonPadding" cellspacing="0" cellpadding="0" border="0" onmouseover="this.style.cursor='pointer'; return true;" onclick="clickLinkButtonText(this, event);"><tr><td><div class="themeButton" onclick="return ISD_ModernButtonClick(this,event);"><asp:LinkButton CommandName="Redirect" runat="server" id="_Button" cssclass="button_link">		
	</asp:LinkButton><asp:Image runat="server" id="_ArrowImage" imageurl="../Images/ButtonExpandArrow.png">		
	</asp:Image></div></td></tr></table>