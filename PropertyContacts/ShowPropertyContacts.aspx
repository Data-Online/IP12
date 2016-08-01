<%@ Register Tagprefix="IPv5" Namespace="IPv5.UI.Controls.ShowPropertyContacts" Assembly="IPv5" %>

<%@ Register Tagprefix="Selectors" Namespace="IPv5" Assembly="IPv5" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="IPv5" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="ShowPropertyContacts.aspx.cs" Culture="en-NZ" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="IPv5.UI.ShowPropertyContacts" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
    <a id="StartOfPageContent"></a>
    <div id="scrollRegion" class="scrollRegion"><asp:UpdateProgress runat="server" id="UpdatePanel1_UpdateProgress1" AssociatedUpdatePanelID="UpdatePanel1">
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

                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%"><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>

                        <IPv5:PropertyContactsRecordControl runat="server" id="PropertyContactsRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="PropertyContactsTitle" Text="&lt;%#String.Concat(&quot;Property Contacts&quot;) %>">	</asp:Literal></td><td class="dhir"><asp:ImageButton runat="server" id="PropertyContactsDialogEditButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconEdit.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="PropertyContactsRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="PropertyContactsRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="LastNameLabel" Text="Last Name">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="LastName"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="Address1Label" Text="Address 1">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="Address1"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="TitleLabel" Text="Title">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="Title"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="PostCodeLabel" Text="Post Code">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="PostCode"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="FirstNameLabel" Text="First Name">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="FirstName"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="Address2Label" Text="Address 2">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="Address2"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="PropertyIDLabel" Text="Property">	</asp:Literal></td><td class="dfv"><asp:LinkButton runat="server" id="PropertyID" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td><td class="fls"><asp:Literal runat="server" id="ContactTypeIDLabel" Text="Contact Type">	</asp:Literal></td><td class="dfv"><asp:LinkButton runat="server" id="ContactTypeID" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="eMailLabel" Text="Email">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="eMail"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="Address3Label" Text="Address 3">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="Address3"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="CityIDLabel" Text="City">	</asp:Literal></td><td class="dfv"><asp:LinkButton runat="server" id="CityID" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td><td class="fls"><asp:Literal runat="server" id="RegionIDLabel" Text="Region">	</asp:Literal></td><td class="dfv"><asp:LinkButton runat="server" id="RegionID" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="CountryIDLabel" Text="Country">	</asp:Literal></td><td class="dfv"><asp:LinkButton runat="server" id="CountryID" causesvalidation="False" commandname="Redirect"></asp:LinkButton> </td><td class="fls"></td><td class="dfv"></td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="PropertyContactsRecordControl_PostbackTracker" runat="server" />
</IPv5:PropertyContactsRecordControl>

            <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0"><tr><td><IPv5:ThemeButton runat="server" id="OKButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:OK&quot;, &quot;IPv5&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:OK&quot;, &quot;IPv5&quot;) %>" postback="False"></IPv5:ThemeButton></td><td><IPv5:ThemeButton runat="server" id="EditButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;IPv5&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;IPv5&quot;) %>" postback="False"></IPv5:ThemeButton></td></tr></table>
</td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>
</div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <div class="QDialog" id="dialog" style="display:none;"><iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe></div>  <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                