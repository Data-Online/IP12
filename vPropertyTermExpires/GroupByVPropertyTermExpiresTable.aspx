<%@ Register Tagprefix="Selectors" Namespace="IPv5" Assembly="IPv5" %>

<%@ Register Tagprefix="IPv5" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Register Tagprefix="IPv5" TagName="PaginationMedium" Src="../Shared/PaginationMedium.ascx" %>

<%@ Register Tagprefix="IPv5" Namespace="IPv5.UI.Controls.GroupByVPropertyTermExpiresTable" Assembly="IPv5" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="GroupByVPropertyTermExpiresTable.aspx.cs" Culture="en-NZ" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="IPv5.UI.GroupByVPropertyTermExpiresTable" %>
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
                        <IPv5:VPropertyTermExpiresTableControl runat="server" id="VPropertyTermExpiresTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT" style="text-align:right;"><table><tr><td class="filbc" style="text-align:center;width:150px;"></td><td class="filbc, alerts_overdue" style="text-align:center;width:150px;"></td><td class="filbc" style="text-align:center;width:150px;"><asp:Literal runat="server" id="Literal" Text="Key:">	</asp:Literal></td><td class="filbc, alerts_overdue" style="text-align:center;width:150px;"><asp:Literal runat="server" id="Overdue" Text="Overdue">	</asp:Literal></td><td class="filbc, alerts_duenow" style="text-align:center;width:150px;"><asp:Literal runat="server" id="DueNow" Text="Due Now">	</asp:Literal></td><td class="filbc, alerts_nextmonth" style="text-align:center;width:150px;"><asp:Literal runat="server" id="NextMonth" Text="Due Next Month">	</asp:Literal></td></tr></table>
</td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb" style="width: 100%"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="VPropertyTermExpiresTitle" Text="&lt;%#String.Concat(&quot;Term Expires&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="VPropertyTermExpiresButtonsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td style="text-align: right;"><input type="image" src="../Images/closeButton.gif" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="VPropertyTermExpiresPDFButton" causesvalidation="False" commandname="ReportData" imageurl="../Images/ButtonBarPDFExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarPDFExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarPDFExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:PDF&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="VPropertyTermExpiresWordButton" causesvalidation="False" commandname="ExportToWord" imageurl="../Images/ButtonBarWordExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarWordExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarWordExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Word&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="VPropertyTermExpiresExportExcelButton" causesvalidation="False" commandname="ExportDataExcel" imageurl="../Images/ButtonBarExcelExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarExcelExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarExcelExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><IPv5:ThemeButtonWithArrow runat="server" id="VPropertyTermExpiresButtonsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;VPropertyTermExpiresButtonsDiv&#39;,&#39;VPropertyTermExpiresButtonsButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;IPv5&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;IPv5&quot;) %>"></IPv5:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <IPv5:ThemeButtonWithArrow runat="server" id="VPropertyTermExpiresFiltersButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;VPropertyTermExpiresFiltersDiv&#39;,&#39;VPropertyTermExpiresFiltersButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;IPv5&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;IPv5&quot;) %>"></IPv5:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td class="panelSearchBox"><table><tr><td><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("VPropertyTermExpiresSearchButton"))%>

                <asp:TextBox runat="server" id="VPropertyTermExpiresSearch" columns="50" cssclass="Search_Input">	</asp:TextBox>
<asp:AutoCompleteExtender id="VPropertyTermExpiresSearchAutoCompleteExtender" runat="server" TargetControlID="VPropertyTermExpiresSearch" ServiceMethod="GetAutoCompletionList_VPropertyTermExpiresSearch" MinimumPrefixLength="2" CompletionInterval="700" CompletionSetCount="10" CompletionListCssClass="autotypeahead_completionListElement" CompletionListItemCssClass="autotypeahead_listItem " CompletionListHighlightedItemCssClass="autotypeahead_highlightedListItem">
</asp:AutoCompleteExtender>

              <%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("VPropertyTermExpiresSearchButton"))%>
</td><td>
                <asp:ImageButton runat="server" id="VPropertyTermExpiresSearchButton" causesvalidation="False" commandname="Search" imageurl="../Images/panelSearchButton.png" tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
              </td></tr></table>
</td><td></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="VPropertyTermExpiresFiltersDiv" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="PropertyIDLabel1" Text="Property">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("VPropertyTermExpiresFilterButton"))%>
<asp:DropDownList runat="server" id="PropertyIDFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)">	</asp:DropDownList><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("VPropertyTermExpiresFilterButton"))%>
</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="CityIDLabel1" Text="City">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("VPropertyTermExpiresFilterButton"))%>
<asp:DropDownList runat="server" id="CityIDFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)">	</asp:DropDownList><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("VPropertyTermExpiresFilterButton"))%>
</td><td class="popupTableCellValue"><IPv5:ThemeButton runat="server" id="VPropertyTermExpiresFilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;IPv5&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;IPv5&quot;) %>" postback="False"></IPv5:ThemeButton></td><td class="popupTableCellValue">
                                  <asp:ImageButton runat="server" id="VPropertyTermExpiresResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarResetOver.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                                </td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel">
                <%# GetResourceValue("Txt:SortBy", "IPv5") %>
              </td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="CompanyNameSortLabel" tooltip="Sort by CompanyName" Text="Company Name" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="Address1SortLabel" tooltip="Sort by Address1" Text="Address 1" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="ExpiryDateSortLabel" tooltip="Sort by ExpiryDate" Text="Expiration Date" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="TermExpireIDSortLabel" tooltip="Sort by TermExpireID" Text="Term Expire" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="PropertyIDSortLabel" tooltip="Sort by PropertyID" Text="Property" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="Address2SortLabel" tooltip="Sort by Address2" Text="Address 2" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="PostCodeSortLabel" tooltip="Sort by PostCode" Text="Post Code" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="DescriptionSortLabel" tooltip="Sort by Description" Text="Description" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="Address3SortLabel" tooltip="Sort by Address3" Text="Address 3" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="CityIDSortLabel" tooltip="Sort by CityID" Text="City" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="VPropertyTermExpiresTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="VPropertyTermExpiresTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thc"><asp:LinkButton runat="server" id="PropertyIDLabel11" tooltip="Sort by Company Name" width="175px" Text="Company Name" CausesValidation="False">	</asp:LinkButton></th><th class="thc">&nbsp; 
<asp:LinkButton runat="server" id="Address1Label1" tooltip="Sort by Address" Text="Address" CausesValidation="False">	</asp:LinkButton></th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp; 
<asp:LinkButton runat="server" id="CityIDLabel11" tooltip="Sort by CityID" Text="City" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="RegionIDLabel" tooltip="Sort by RegionID" Text="Region" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="CountryIDLabel" tooltip="Sort by CountryID" Text="Country" CausesValidation="False">	</asp:LinkButton></th><th class="thc">&nbsp; 
<asp:LinkButton runat="server" id="PostCodeLabel1" tooltip="Sort by PostCode" Text="Post Code" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="ExpiryDateLabel1" tooltip="Sort by ExpiryDate" Text="Expiration Date" CausesValidation="False">	</asp:LinkButton></th><th class="thc"><asp:LinkButton runat="server" id="DescriptionLabel1" tooltip="Sort by Description" width="120px" Text="Description" CausesValidation="False">	</asp:LinkButton></th></tr><asp:Repeater runat="server" id="VPropertyTermExpiresTableControlRepeater">		<ITEMTEMPLATE>		<IPv5:VPropertyTermExpiresTableControlRow runat="server" id="VPropertyTermExpiresTableControlRow">
<tr id="MyTR" runat="server"><td class="MyTR" scope="server"><asp:LinkButton runat="server" id="PropertyID" CommandName="Redirect"></asp:LinkButton></td><td class="MyTR" scope="server"><asp:Literal runat="server" id="Address1"></asp:Literal> 
<asp:Literal runat="server" id="Address2"></asp:Literal> 
<asp:Literal runat="server" id="Address3"></asp:Literal></td><td class="MyTR" scope="server"></td><td class="MyTR" scope="server"></td><td class="MyTR" scope="server"><asp:Literal runat="server" id="CityID"></asp:Literal></td><td class="MyTR" scope="server"><asp:Literal runat="server" id="RegionID"></asp:Literal></td><td class="MyTR" scope="server"><asp:Literal runat="server" id="CountryID"></asp:Literal></td><td class="MyTR" scope="server"><asp:Literal runat="server" id="PostCode"></asp:Literal></td><td class="MyTR" scope="server"><span style="white-space:nowrap;">
<asp:Literal runat="server" id="ExpiryDate"></asp:Literal></span>
</td><td class="MyTR" scope="server"><asp:Literal runat="server" id="Description"></asp:Literal></td></tr><tr><td class="tableCellLabel" scope="col"></td><td class="tableCellValue"></td><td class="tableCellLabel" scope="col"></td><td class="tableCellValue"></td><td class="tableCellLabel" scope="col"></td><td class="tableCellValue"></td><td class="tableCellLabel" scope="col"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableCellLabel" scope="col"></td><td class="tableCellValue"></td><td class="tableCellLabel" scope="col"></td><td class="tableCellValue"></td><td class="tableCellLabel" scope="col"></td><td class="tableCellValue"></td><td class="tableCellLabel" scope="col"></td><td class="tableCellValue"></td><td class="tableCellValue"></td><td class="tableCellValue"></td></tr><tr><td class="tableRowDivider" colspan="8">&nbsp;</td><td class="tableRowDivider"></td><td class="tableRowDivider"></td></tr></IPv5:VPropertyTermExpiresTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <IPv5:PaginationMedium runat="server" id="VPropertyTermExpiresPagination"></IPv5:PaginationMedium>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="VPropertyTermExpiresTableControl_PostbackTracker" runat="server" />
</IPv5:VPropertyTermExpiresTableControl>

            </td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>
</div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <div class="QDialog" id="dialog" style="display:none;"><iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe></div>  <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                