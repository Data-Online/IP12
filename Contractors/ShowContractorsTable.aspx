<%@ Register Tagprefix="IPv5" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Register Tagprefix="IPv5" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="ShowContractorsTable.aspx.cs" Culture="en-NZ" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="IPv5.UI.ShowContractorsTable" %>
<%@ Register Tagprefix="IPv5" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="Selectors" Namespace="IPv5" Assembly="IPv5" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="IPv5" Namespace="IPv5.UI.Controls.ShowContractorsTable" Assembly="IPv5" %>
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
                        <IPv5:ContractorsTableControl runat="server" id="ContractorsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb" style="width: 100%"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="ContractorsTitle" Text="&lt;%#String.Concat(&quot;Contractors&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="ContractorsButtonsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td></td><td></td><td style="text-align: right;"><input type="image" src="../Images/closeButton.gif" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="ContractorsNewButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src=&#39;../Images/ButtonBarNew.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNewOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ContractorsPDFButton" causesvalidation="False" commandname="ReportData" imageurl="../Images/ButtonBarPDFExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarPDFExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarPDFExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:PDF&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ContractorsWordButton" causesvalidation="False" commandname="ExportToWord" imageurl="../Images/ButtonBarWordExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarWordExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarWordExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Word&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ContractorsExportExcelButton" causesvalidation="False" commandname="ExportDataExcel" imageurl="../Images/ButtonBarExcelExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarExcelExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarExcelExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ContractorsImportButton" causesvalidation="False" commandname="ImportCSV" imageurl="../Images/ButtonBarImport.gif" onmouseout="this.src=&#39;../Images/ButtonBarImport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarImportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Import&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><IPv5:ThemeButtonWithArrow runat="server" id="ContractorsButtonsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;ContractorsButtonsDiv&#39;,&#39;ContractorsButtonsButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;IPv5&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;IPv5&quot;) %>"></IPv5:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <IPv5:ThemeButtonWithArrow runat="server" id="ContractorsFiltersButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;ContractorsFiltersDiv&#39;,&#39;ContractorsFiltersButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;IPv5&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;IPv5&quot;) %>"></IPv5:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="panelSearchBox"><table><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("ContractorsSearchButton"))%>

                <asp:TextBox runat="server" id="ContractorsSearch" columns="50" cssclass="Search_Input">	</asp:TextBox>
<asp:AutoCompleteExtender id="ContractorsSearchAutoCompleteExtender" runat="server" TargetControlID="ContractorsSearch" ServiceMethod="GetAutoCompletionList_ContractorsSearch" MinimumPrefixLength="2" CompletionInterval="700" CompletionSetCount="10" CompletionListCssClass="autotypeahead_completionListElement" CompletionListItemCssClass="autotypeahead_listItem " CompletionListHighlightedItemCssClass="autotypeahead_highlightedListItem">
</asp:AutoCompleteExtender>

              <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("ContractorsSearchButton"))%>
</td><td>
                <asp:ImageButton runat="server" id="ContractorsSearchButton" causesvalidation="False" commandname="Search" imageurl="../Images/panelSearchButton.png" tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
              </td></tr></table>
</td><td></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="ContractorsFiltersDiv" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="ContactNameLabel1" Text="Contact Name">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("ContractorsFilterButton"))%>
<asp:DropDownList runat="server" id="ContactNameFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)">	</asp:DropDownList><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("ContractorsFilterButton"))%>
</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="CityIDLabel" Text="City">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("ContractorsFilterButton"))%>
<asp:DropDownList runat="server" id="CityIDFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)">	</asp:DropDownList><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("ContractorsFilterButton"))%>
</td><td class="popupTableCellValue"><IPv5:ThemeButton runat="server" id="ContractorsFilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;IPv5&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;IPv5&quot;) %>" postback="False"></IPv5:ThemeButton></td><td class="popupTableCellValue">
                                  <asp:ImageButton runat="server" id="ContractorsResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarResetOver.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                                </td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel">
                <%# GetResourceValue("Txt:SortBy", "IPv5") %>
              </td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="ContactNameSortLabel" tooltip="Sort by ContactName" Text="Contact Name" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="Address1SortLabel" tooltip="Sort by Address1" Text="Address 1" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="PostCodeSortLabel" tooltip="Sort by PostCode" Text="Post Code" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="ContractorIDSortLabel" tooltip="Sort by ContractorID" Text="Contractor" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="ServiceTypeIDSortLabel" tooltip="Sort by ServiceTypeID" Text="Service Type" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="LandPhoneSortLabel" tooltip="Sort by LandPhone" Text="Land Phone" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="CellPhoneSortLabel" tooltip="Sort by CellPhone" Text="Cell Phone" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="Address2SortLabel" tooltip="Sort by Address2" Text="Address 2" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="eMailSortLabel" tooltip="Sort by eMail" Text="Email" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="CompanyNameSortLabel" tooltip="Sort by CompanyName" Text="Company Name" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="ContractorsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="ContractorsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc" colspan="3" style="display:none"><img src="../Images/space.gif" height="1" width="1" alt="" /></th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th><th class="thc" style="display: none">&nbsp;</th></tr><asp:Repeater runat="server" id="ContractorsTableControlRepeater">		<ITEMTEMPLATE>		<IPv5:ContractorsTableControlRow runat="server" id="ContractorsTableControlRow">
<tr><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;" rowspan="3" colspan="3">
                                  <asp:ImageButton runat="server" id="ContractorsRowEditButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton><br /><br />
                                
                                  <asp:ImageButton runat="server" id="ContractorsRowDeleteButton" causesvalidation="False" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src=&#39;../Images/icon_delete.gif&#39;" onmouseover="this.src=&#39;../Images/icon_delete_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton><br /><br />
                                
                                  <asp:ImageButton runat="server" id="ContractorsRowExpandCollapseRowButton" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton><br /><br />
                                </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ContactNameLabel" Text="Contact Name">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="ContactName"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="Address1Label" Text="Address 1">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="Address1"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="PostCodeLabel" Text="Post Code">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="PostCode"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ContractorIDLabel" Text="Contractor">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ContractorID"></asp:Literal></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ServiceTypeIDLabel" Text="Service Type">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ServiceTypeID"></asp:Literal></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="LandPhoneLabel" Text="Land Phone">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="LandPhone"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="CellPhoneLabel" Text="Cell Phone">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="CellPhone"></asp:Literal> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="Address2Label" Text="Address 2">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="Address2"></asp:Literal> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="eMailLabel" Text="Email">	</asp:Literal> 
</td><td class="tableCellValue"><asp:Literal runat="server" id="eMail"></asp:Literal> </td><td class="tableCellLabel"></td><td class="tableCellValue"></td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="CompanyNameLabel" Text="Company Name">	</asp:Literal> 
</td><td class="tableCellValue" colspan="3"><asp:Literal runat="server" id="CompanyName"></asp:Literal> </td></tr><tr id="ContractorsTableControlAltRow" runat="server"><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableCellValue" colspan="8"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<BaseClasses:TabContainer runat="server" id="ContractorsTabContainer" panellayout="Tabbed">
 <BaseClasses:TabPanel runat="server" id="CitiesTabPanel" HeaderText="City">	<ContentTemplate>
  <IPv5:CitiesRecordControl runat="server" id="CitiesRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="CitiesRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="CitiesRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="CityLabel" Text="City">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="City"></asp:Literal> </td><td class="fls"></td><td class="dfv"></td><td class="fls"></td><td class="dfv"></td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="CitiesRecordControl_PostbackTracker" runat="server" />
</IPv5:CitiesRecordControl>

 </ContentTemplate></BaseClasses:TabPanel>
</BaseClasses:TabContainer><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="tableRowDivider" colspan="11">&nbsp;</td></tr></IPv5:ContractorsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <IPv5:PaginationModern runat="server" id="ContractorsPagination"></IPv5:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="ContractorsTableControl_PostbackTracker" runat="server" />
</IPv5:ContractorsTableControl>

            </td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>
</div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <div class="QDialog" id="dialog" style="display:none;"><iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe></div>  <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                