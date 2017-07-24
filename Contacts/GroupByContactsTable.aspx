<%@ Register Tagprefix="IPv5" Namespace="IPv5.UI.Controls.GroupByContactsTable" Assembly="IPv5" %>

<%@ Register Tagprefix="IPv5" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Register Tagprefix="IPv5" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Register Tagprefix="IPv5" TagName="PaginationMedium" Src="../Shared/PaginationMedium.ascx" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="GroupByContactsTable.aspx.cs" Culture="en-NZ" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="IPv5.UI.GroupByContactsTable" %>
<%@ Register Tagprefix="Selectors" Namespace="IPv5" Assembly="IPv5" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
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

                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%"><tr><td>
                        <IPv5:ContactsTableControl runat="server" id="ContactsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb" style="width: 100%"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="ContactsTitle" Text="&lt;%#String.Concat(&quot;Investors&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="ContactsButtonsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td></td><td></td><td style="text-align: right;"><input type="image" src="../Images/closeButton.gif" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="ContactsNewButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src=&#39;../Images/ButtonBarNew.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNewOver.gif&#39;" requiredroles="&lt;PRoles>1;3&lt;/PRoles>" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ContactsPDFButton" causesvalidation="False" commandname="ReportData" imageurl="../Images/ButtonBarPDFExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarPDFExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarPDFExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:PDF&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ContactsWordButton" causesvalidation="False" commandname="ExportToWord" imageurl="../Images/ButtonBarWordExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarWordExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarWordExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Word&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ContactsExportExcelButton" causesvalidation="False" commandname="ExportDataExcel" imageurl="../Images/ButtonBarExcelExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarExcelExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarExcelExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ContactsImportButton" causesvalidation="False" commandname="ImportCSV" imageurl="../Images/ButtonBarImport.gif" onmouseout="this.src=&#39;../Images/ButtonBarImport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarImportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Import&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><IPv5:ThemeButtonWithArrow runat="server" id="ContactsButtonsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;ContactsButtonsDiv&#39;,&#39;ContactsButtonsButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;IPv5&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;IPv5&quot;) %>"></IPv5:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <IPv5:ThemeButtonWithArrow runat="server" id="ContactsFiltersButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;ContactsFiltersDiv&#39;,&#39;ContactsFiltersButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;IPv5&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;IPv5&quot;) %>"></IPv5:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="panelSearchBox"><table><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("ContactsSearchButton"))%>

                <asp:TextBox runat="server" id="ContactsSearch" columns="50" cssclass="Search_Input">	</asp:TextBox>
<asp:AutoCompleteExtender id="ContactsSearchAutoCompleteExtender" runat="server" TargetControlID="ContactsSearch" ServiceMethod="GetAutoCompletionList_ContactsSearch" MinimumPrefixLength="2" CompletionInterval="700" CompletionSetCount="10" CompletionListCssClass="autotypeahead_completionListElement" CompletionListItemCssClass="autotypeahead_listItem " CompletionListHighlightedItemCssClass="autotypeahead_highlightedListItem">
</asp:AutoCompleteExtender>

              <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("ContactsSearchButton"))%>
</td><td>
                <asp:ImageButton runat="server" id="ContactsSearchButton" causesvalidation="False" commandname="Search" imageurl="../Images/panelSearchButton.png" tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
              </td></tr></table>
</td><td></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="ContactsFiltersDiv" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="RegionIDLabel1" Text="Region">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("ContactsFilterButton"))%>
<asp:DropDownList runat="server" id="RegionIDFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)">	</asp:DropDownList><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("ContactsFilterButton"))%>
</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="CityIDLabel1" Text="City">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("ContactsFilterButton"))%>
<asp:DropDownList runat="server" id="CityIDFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)">	</asp:DropDownList><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("ContactsFilterButton"))%>
</td><td class="popupTableCellValue"><IPv5:ThemeButton runat="server" id="ContactsFilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;IPv5&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;IPv5&quot;) %>" postback="False"></IPv5:ThemeButton></td><td class="popupTableCellValue">
                                  <asp:ImageButton runat="server" id="ContactsResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarResetOver.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                                </td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel">
                <%# GetResourceValue("Txt:SortBy", "IPv5") %>
              </td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="LastName2SortLabel" tooltip="Sort by LastName2" Text="Last Name 2" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="Address1SortLabel" tooltip="Sort by Address1" Text="EvaluateFormula(&quot;= \&quot;Address\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="TitleSortLabel" tooltip="Sort by Title" Text="Title" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="PostCodeSortLabel" tooltip="Sort by PostCode" Text="Post Code" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="FirstName2SortLabel" tooltip="Sort by FirstName2" Text="EvaluateFormula(&quot;= \&quot;Second Contact\&quot;&quot;, true)" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="Address2SortLabel" tooltip="Sort by Address2" Text="Address 2" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="IrdNumberSortLabel" tooltip="Sort by IrdNumber" Text="IRD Number" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="ActiveSortLabel" tooltip="Sort by Active" Text="Active" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="TrustNameSortLabel" tooltip="Sort by TrustName" Text="Trust Name" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="Address3SortLabel" tooltip="Sort by Address3" Text="Address 3" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="ContactsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="ContactsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="3" style="display:none"><img src="../Images/space.gif" height="1" width="1" alt="" /></th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th></tr><asp:Repeater runat="server" id="ContactsTableControlRepeater">		<ITEMTEMPLATE>		<IPv5:ContactsTableControlRow runat="server" id="ContactsTableControlRow">
<tr><td class="tableCellSelectCheckbox" colspan="3" rowspan="2"><asp:ImageButton runat="server" id="EditRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" requiredroles="&lt;PRoles>1;3&lt;/PRoles>" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton> <br />
<asp:ImageButton runat="server" id="ViewRowButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_view.gif" onmouseout="this.src=&#39;../Images/icon_view.gif&#39;" onmouseover="this.src=&#39;../Images/icon_view_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton> <br />
<asp:ImageButton runat="server" id="DeleteRowButton" causesvalidation="False" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src=&#39;../Images/icon_delete.gif&#39;" onmouseover="this.src=&#39;../Images/icon_delete_over.gif&#39;" requiredroles="&lt;PRoles>1;3&lt;/PRoles>" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton> <br />
<asp:ImageButton runat="server" id="ExpandRowButton" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" onmouseout="this.src=&#39;../Images/icon_expandcollapserow.gif&#39;" onmouseover="this.src=&#39;../Images/icon_expandcollapserow_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton></td><td class="largeText" colspan="2"><asp:Literal runat="server" id="FirstName4"></asp:Literal> 
<asp:Literal runat="server" id="MiddleName"></asp:Literal> 
<asp:Literal runat="server" id="LastName4"></asp:Literal> 
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="ContactID" visible="False"></asp:Literal></span>
</td><td class="tableCellLabel" style="font-weight:bold"><asp:Literal runat="server" id="FirstName2Label" Text="EvaluateFormula(&quot;= \&quot;Second Contact\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue" colspan="3"><asp:Literal runat="server" id="FirstName22"></asp:Literal> 
<asp:Literal runat="server" id="LastName22"></asp:Literal></td><td class="tableCellLabel" style="text-align:right;"><asp:Literal runat="server" id="Literal" Text="eMail">	</asp:Literal></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel"><asp:Literal runat="server" id="Address1Label11" Text="EvaluateFormula(&quot;= \&quot;Address\&quot;&quot;, true)">	</asp:Literal></td><td class="tableCellValue" rowspan="2"><asp:Literal runat="server" id="Address14"></asp:Literal> <br>
<asp:Literal runat="server" id="Address24"></asp:Literal> <br>
<asp:Literal runat="server" id="Address34"></asp:Literal> <br> 
<asp:Literal runat="server" id="CityID3"></asp:Literal> <br>
<asp:Literal runat="server" id="PostCode4"></asp:Literal> <br>
<asp:Literal runat="server" id="CountryID3"></asp:Literal></td><td class="tableCellLabel"><asp:Literal runat="server" id="TrustNameLabel" Text="Trust Name">	</asp:Literal></td><td class="tableCellValue" style="font-weight:bold" colspan="4"><asp:Literal runat="server" id="TrustName2"></asp:Literal></td><td class="tableCellValue"></td></tr><tr><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;"></td><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;"></td><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;"></td><td class="tableCellValue"></td><td class="tableCellLabel" style="text-align:left;border-width:1px 1px 1px 1px;border-style:solid;" colspan="5"><table><tr><td class="tableCellLabel" style="text-align:left;"><asp:Literal runat="server" id="IrdNumberLabel" Text="IRD Number">	</asp:Literal> <br>
<asp:Literal runat="server" id="BankAccountLabel" Text="Bank Account">	</asp:Literal></td><td class="tableCellLabel" style="text-align:left;"><asp:Literal runat="server" id="PlaceOfBirthLabel" Text="Place Of Birth">	</asp:Literal> <br>
<asp:Literal runat="server" id="DateOfBirthLabel" Text="Date Of Birth">	</asp:Literal></td><td class="tableCellLabel" style="text-align:left;"><asp:Literal runat="server" id="eMailLabel" Text="Email">	</asp:Literal> <br>
<asp:Literal runat="server" id="PhoneNumberLabel" Text="Phone Number">	</asp:Literal></td></tr><tr><td class="tableCellValue"><asp:Literal runat="server" id="IrdNumber2"></asp:Literal> <br>
<asp:Literal runat="server" id="BankAccount2"></asp:Literal></td><td class="tableCellValue"><asp:Literal runat="server" id="PlaceOfBirth2"></asp:Literal> <br>
<span style="white-space:nowrap;">
<asp:Literal runat="server" id="DateOfBirth2"></asp:Literal></span>
</td><td class="tableCellValue"><asp:Literal runat="server" id="eMail3"></asp:Literal> <br>
<asp:Literal runat="server" id="PhoneNumber2"></asp:Literal></td></tr></table>
</td><td class="tableCellValue"></td></tr><tr><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;"></td><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;"></td><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;"></td><td class="tableCellValue" scope="col" colspan="5"><asp:accordion id="Accordion1" runat="server" requireopenedpane="false" suppressheaderpostbacks="true" selectedindex="1">
    <panes>
        <asp:accordionpane id="AccordionPaneA1" runat="server">
            <header><a href=""><img src="../Images/Audit.png"></a></header>  
			<content>
			<p class="auditText">
			Created by: <span style="white-space:nowrap;">
<asp:Literal runat="server" id="CreatedBy1"></asp:Literal></span>

			On: <span style="white-space:nowrap;">
<asp:Literal runat="server" id="CreatedOn1"></asp:Literal></span>

			<br>
			Last update by: <span style="white-space:nowrap;">
<asp:Literal runat="server" id="UpdatedBy1"></asp:Literal></span>
 
			On: <span style="white-space:nowrap;">
<asp:Literal runat="server" id="UpdatedOn1"></asp:Literal></span>

			</p>
			</content>			
        </asp:accordionpane>
		
	</panes>    
</asp:accordion></td><td class="tableCellValue"></td><td class="tableCellLabel" scope="col"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;"></td><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;"></td><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;"></td><td class="tableCellLabel" scope="col"></td><td class="tableCellValue"></td><td class="tableCellLabel" scope="col"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr id="ContactsTableControlAltRow" runat="server"><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableCellValue" colspan="7"><BaseClasses:TabContainer runat="server" id="ContactsTableControlTabContainer" onclientactivetabchanged="fixedHeaderTab" panellayout="Tabbed"> 
 <BaseClasses:TabPanel runat="server" id="TabPanel" HeaderText="Investments">	<ContentTemplate> 
  <IPv5:LinkTableTableControl runat="server" id="LinkTableTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="LinkTableTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="LinkTableTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc">&nbsp; 
<asp:LinkButton runat="server" id="PropertyIDLabel2" tooltip="Sort by property name" Text="Property" CausesValidation="False">	</asp:LinkButton></th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th></tr><asp:Repeater runat="server" id="LinkTableTableControlRepeater">		<ITEMTEMPLATE>		<IPv5:LinkTableTableControlRow runat="server" id="LinkTableTableControlRow">
<tr><td class="tableCellValue" scope="col" colspan="4"><asp:LinkButton runat="server" id="PropertyID1" causesvalidation="False" commandname="Redirect"></asp:LinkButton></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="8">&nbsp;</td></tr></IPv5:LinkTableTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <IPv5:PaginationModern runat="server" id="LinkTablePagination"></IPv5:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="LinkTableTableControl_PostbackTracker" runat="server" />
</IPv5:LinkTableTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="TabPanel1" HeaderText="Directorships">	<ContentTemplate> 
  <IPv5:DirectorsTableControl runat="server" id="DirectorsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="DirectorsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="DirectorsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc">&nbsp; 
<asp:LinkButton runat="server" id="PropertyIDLabel" tooltip="Sort by property name" viewstatemode="Inherit" Text="Property" CausesValidation="False">	</asp:LinkButton></th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th></tr><asp:Repeater runat="server" id="DirectorsTableControlRepeater">		<ITEMTEMPLATE>		<IPv5:DirectorsTableControlRow runat="server" id="DirectorsTableControlRow">
<tr><td class="tableCellValue" scope="col" colspan="4"><asp:LinkButton runat="server" id="PropertyID" causesvalidation="False" commandname="Redirect"></asp:LinkButton></td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="8">&nbsp;</td></tr></IPv5:DirectorsTableControlRow>
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
  <IPv5:ContactNotesTableControl runat="server" id="ContactNotesTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="ContactNotesTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="ContactNotesTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc">&nbsp; 
<asp:LinkButton runat="server" id="NotesLabel" Text="Notes" CausesValidation="False">	</asp:LinkButton></th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th></tr><asp:Repeater runat="server" id="ContactNotesTableControlRepeater">		<ITEMTEMPLATE>		<IPv5:ContactNotesTableControlRow runat="server" id="ContactNotesTableControlRow">
<tr><td class="tableCellValue" scope="col" colspan="4"><asp:Literal runat="server" id="Notes"></asp:Literal></td></tr><tr><td class="tableRowDivider" colspan="4">&nbsp;</td></tr></IPv5:ContactNotesTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td class="panelPaginationC">
                    <IPv5:PaginationModern runat="server" id="ContactNotesPagination"></IPv5:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="ContactNotesTableControl_PostbackTracker" runat="server" />
</IPv5:ContactNotesTableControl>
 
 </ContentTemplate></BaseClasses:TabPanel> 
 <BaseClasses:TabPanel runat="server" id="TabPanel3" HeaderText="Background">	<ContentTemplate> 
  <IPv5:ContactNotesTableControl1 runat="server" id="ContactNotesTableControl1">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="CollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre">
                    <table id="ContactNotesTableControl1Grid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:Literal runat="server" id="NotesLabel1" Text="Notes">	</asp:Literal></th><th class="thc"></th><th class="thc"></th><th class="thc"></th><th class="thc"></th><th class="thc"></th></tr><asp:Repeater runat="server" id="ContactNotesTableControl1Repeater">		<ITEMTEMPLATE>		<IPv5:ContactNotesTableControl1Row runat="server" id="ContactNotesTableControl1Row">
<tr><td class="tableCellValue" colspan="4"><asp:Literal runat="server" id="Notes1"></asp:Literal></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="6"></td></tr></IPv5:ContactNotesTableControl1Row>
</ITEMTEMPLATE>

</asp:Repeater>
</table>

                  </td></tr></table>
</asp:panel>
                </td></tr><tr><td></td><td class="panelPaginationC">
                    <IPv5:PaginationModern runat="server" id="Pagination"></IPv5:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td></tr></table>
	<asp:hiddenfield id="ContactNotesTableControl1_PostbackTracker" runat="server" />
</IPv5:ContactNotesTableControl1>
 
 </ContentTemplate></BaseClasses:TabPanel> 
</BaseClasses:TabContainer></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="11">&nbsp;</td></tr></IPv5:ContactsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <IPv5:PaginationMedium runat="server" id="ContactsPagination"></IPv5:PaginationMedium>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="ContactsTableControl_PostbackTracker" runat="server" />
</IPv5:ContactsTableControl>

            </td></tr><tr><td class="recordPanelButtonsAlignment"><table cellpadding="0" cellspacing="0" border="0"><tr><td><IPv5:ThemeButton runat="server" id="OKButton" button-causesvalidation="False" button-commandname="Redirect" button-text="&lt;%# GetResourceValue(&quot;Btn:OK&quot;, &quot;IPv5&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:OK&quot;, &quot;IPv5&quot;) %>" postback="False"></IPv5:ThemeButton></td></tr></table>
</td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>
</div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <div class="QDialog" id="dialog" style="display:none;"><iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe></div>  <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                