<%@ Register Tagprefix="IPv5" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="ShowContacts.aspx.cs" Culture="en-NZ" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="IPv5.UI.ShowContacts" %>
<%@ Register Tagprefix="Selectors" Namespace="IPv5" Assembly="IPv5" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="IPv5" Namespace="IPv5.UI.Controls.ShowContacts" Assembly="IPv5" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="IPv5" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>
<asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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

                        <IPv5:ContactsRecordControl runat="server" id="ContactsRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="ContactsTitle" Text="&lt;%#String.Concat(&quot;Contacts&quot;) %>">	</asp:Literal></td><td class="dhir"><asp:ImageButton runat="server" id="ContactsDialogEditButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconEdit.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Edit&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="ContactsRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="ContactsRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="fls"><asp:Literal runat="server" id="TitleLabel" Text="Title">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="Title"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="ActiveLabel" Text="Active">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="Active"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="IrdNumberLabel2" Text="IRD Number">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="IrdNumber2"></asp:Literal></td></tr><tr><td class="fls"><asp:Literal runat="server" id="FirstNameLabel" Text="First Name">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="FirstName"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="LastNameLabel" Text="Last Name">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="LastName"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="BankAccountLabel1" Text="Bank Account">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="BankAccount1"></asp:Literal></td></tr><tr><td class="fls"><asp:Literal runat="server" id="FirstName2Label" Text="EvaluateFormula(&quot;= \&quot;Second Contact\&quot;&quot;, true)">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="FirstName2"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="LastName2Label" Text="Last Name 2">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="LastName2"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="DateOfBirthLabel1" Text="Date Of Birth">	</asp:Literal></td><td class="dfv"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="DateOfBirth1"></asp:Literal></span>
</td></tr><tr><td class="fls"><asp:Literal runat="server" id="TrustNameLabel" Text="Trust Name">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="TrustName"></asp:Literal></td><td class="fls"><asp:Literal runat="server" id="eMailLabel1" Text="Email">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="eMail1"></asp:Literal></td><td class="fls"><asp:Literal runat="server" id="PlaceOfBirthLabel1" Text="Place Of Birth">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="PlaceOfBirth1"></asp:Literal></td></tr><tr><td class="fls"><asp:Literal runat="server" id="Address1Label1" Text="EvaluateFormula(&quot;= \&quot;Address\&quot;&quot;, true)">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="Address11"></asp:Literal></td><td class="fls"><asp:Literal runat="server" id="CityIDLabel1" Text="City">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="CityID1"></asp:Literal></td><td class="fls"><asp:Literal runat="server" id="PhoneNumberLabel" Text="Phone Number">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="PhoneNumber"></asp:Literal></td></tr><tr><td class="fls"></td><td class="dfv"><asp:Literal runat="server" id="Address21"></asp:Literal></td><td class="fls"><asp:Literal runat="server" id="PostCodeLabel1" Text="Post Code">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="PostCode1"></asp:Literal></td><td class="fls"></td><td class="fls"></td></tr><tr><td class="fls"></td><td class="dfv"><asp:Literal runat="server" id="Address31"></asp:Literal></td><td class="fls"><asp:Literal runat="server" id="RegionIDLabel1" Text="Region">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="RegionID1"></asp:Literal></td><td class="fls"></td><td class="fls"></td></tr><tr><td class="fls"></td><td class="dfv"></td><td class="fls"><asp:Literal runat="server" id="CountryIDLabel1" Text="Country">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="CountryID1"></asp:Literal></td><td class="dfv"></td><td class="dfv"></td></tr><tr><td class="fls" colspan="6"><BaseClasses:TabContainer runat="server" id="ContactsRecordControlTabContainer" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="TabPanel" HeaderText="Investments">	<ContentTemplate> 
  <IPv5:LinkTableTableControl runat="server" id="LinkTableTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion1" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="LinkTableTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:LinkButton runat="server" id="PropertyIDLabel" Text="Property" CausesValidation="False">	</asp:LinkButton></th><th class="thc"></th><th class="thc"></th><th class="thc"></th><th class="thc"></th><th class="thc"></th><th class="thc"></th><th class="thc"></th></tr><asp:Repeater runat="server" id="LinkTableTableControlRepeater">		<ITEMTEMPLATE>		<IPv5:LinkTableTableControlRow runat="server" id="LinkTableTableControlRow">
<tr><td class="tableCellValue" colspan="4"><asp:LinkButton runat="server" id="PropertyID" CommandName="Redirect"></asp:LinkButton></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="8"></td></tr></IPv5:LinkTableTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <IPv5:PaginationModern runat="server" id="Pagination1"></IPv5:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="LinkTableTableControl_PostbackTracker" runat="server" />
</IPv5:LinkTableTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="TabPanel1" HeaderText="Directorships">	<ContentTemplate> 
  <IPv5:DirectorsTableControl runat="server" id="DirectorsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="DirectorsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="DirectorsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc">&nbsp; 
<asp:LinkButton runat="server" id="PropertyIDLabel1" tooltip="Sort by property name" viewstatemode="Inherit" Text="Property" CausesValidation="False">	</asp:LinkButton></th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th></tr><asp:Repeater runat="server" id="DirectorsTableControlRepeater">		<ITEMTEMPLATE>		<IPv5:DirectorsTableControlRow runat="server" id="DirectorsTableControlRow">
<tr><td class="tableCellValue" scope="col" colspan="4"><asp:LinkButton runat="server" id="PropertyID1" causesvalidation="False" commandname="Redirect"></asp:LinkButton></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="8">&nbsp;</td></tr></IPv5:DirectorsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <IPv5:PaginationModern runat="server" id="DirectorsPagination"></IPv5:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="DirectorsTableControl_PostbackTracker" runat="server" />
</IPv5:DirectorsTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="TabPanel2" HeaderText="Notes">	<ContentTemplate> 
  <IPv5:ContactNotesTableControl1 runat="server" id="ContactNotesTableControl1">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="ContactNotesTableControl1Grid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:LinkButton runat="server" id="NotesLabel1" Text="Notes" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="CreatedOnLabel1" tooltip="Sort by CreatedOn" Text="Created On" CausesValidation="False">	</asp:LinkButton></th><th class="thc"></th><th class="thc"></th><th class="thc"></th><th class="thc"></th><th class="thc"></th><th class="thc"></th></tr><asp:Repeater runat="server" id="ContactNotesTableControl1Repeater">		<ITEMTEMPLATE>		<IPv5:ContactNotesTableControl1Row runat="server" id="ContactNotesTableControl1Row">
<tr><td class="tableCellValue"><asp:Literal runat="server" id="Notes1"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="CreatedOn1"></asp:Literal></span>
</td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="8"></td></tr></IPv5:ContactNotesTableControl1Row>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <IPv5:PaginationModern runat="server" id="Pagination"></IPv5:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="ContactNotesTableControl1_PostbackTracker" runat="server" />
</IPv5:ContactNotesTableControl1>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="TabPanel3" HeaderText="Background">	<ContentTemplate> 
  <IPv5:ContactBackgroundTableControl runat="server" id="ContactBackgroundTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="CollapsibleRegion2" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="ContactBackgroundTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:LinkButton runat="server" id="NotesLabel" Text="Notes" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="CreatedOnLabel" Text="Created On" CausesValidation="False">	</asp:LinkButton></th><th class="thc"></th><th class="thc"></th><th class="thc"></th><th class="thc"></th><th class="thc"></th><th class="thc"></th></tr><asp:Repeater runat="server" id="ContactBackgroundTableControlRepeater">		<ITEMTEMPLATE>		<IPv5:ContactBackgroundTableControlRow runat="server" id="ContactBackgroundTableControlRow">
<tr><td class="tableCellValue"><asp:Literal runat="server" id="Notes"></asp:Literal></td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="CreatedOn"></asp:Literal></span>
</td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="8"></td></tr></IPv5:ContactBackgroundTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <IPv5:PaginationModern runat="server" id="Pagination2"></IPv5:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="ContactBackgroundTableControl_PostbackTracker" runat="server" />
</IPv5:ContactBackgroundTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
</BaseClasses:TabContainer></td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="ContactsRecordControl_PostbackTracker" runat="server" />
</IPv5:ContactsRecordControl>

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
                