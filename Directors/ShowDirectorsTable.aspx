<%@ Register Tagprefix="IPv5" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Register Tagprefix="IPv5" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Register Tagprefix="IPv5" Namespace="IPv5.UI.Controls.ShowDirectorsTable" Assembly="IPv5" %>

<%@ Register Tagprefix="Selectors" Namespace="IPv5" Assembly="IPv5" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="ShowDirectorsTable.aspx.cs" Culture="en-NZ" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="IPv5.UI.ShowDirectorsTable" %>
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
                        <IPv5:DirectorsTableControl runat="server" id="DirectorsTableControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td class="panelTL"><img src="../Images/space.gif" class="panelTLSpace" alt="" /></td><td class="panelT"></td><td class="panelTR"><img src="../Images/space.gif" class="panelTRSpace" alt="" /></td></tr><tr><td class="panelHeaderL"></td><td class="dh">
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb" style="width: 100%"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="DirectorsTitle" Text="&lt;%#String.Concat(&quot;Directors&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="DirectorsButtonsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td></td><td></td><td style="text-align: right;"><input type="image" src="../Images/closeButton.gif" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="DirectorsNewButton" causesvalidation="False" commandname="Redirect" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src=&#39;../Images/ButtonBarNew.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNewOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="DirectorsPDFButton" causesvalidation="False" commandname="ReportData" imageurl="../Images/ButtonBarPDFExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarPDFExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarPDFExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:PDF&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="DirectorsWordButton" causesvalidation="False" commandname="ExportToWord" imageurl="../Images/ButtonBarWordExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarWordExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarWordExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Word&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="DirectorsExportExcelButton" causesvalidation="False" commandname="ExportDataExcel" imageurl="../Images/ButtonBarExcelExport.gif" onmouseout="this.src=&#39;../Images/ButtonBarExcelExport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarExcelExportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:ExportExcel&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="DirectorsImportButton" causesvalidation="False" commandname="ImportCSV" imageurl="../Images/ButtonBarImport.gif" onmouseout="this.src=&#39;../Images/ButtonBarImport.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarImportOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Import&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td><td></td><td></td></tr></table>

                </div></td><td class="prbbc"></td><td class="prspace"></td><td class="prbbc" style="text-align:right"><IPv5:ThemeButtonWithArrow runat="server" id="DirectorsButtonsButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;DirectorsButtonsDiv&#39;,&#39;DirectorsButtonsButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;IPv5&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Actions&quot;, &quot;IPv5&quot;) %>"></IPv5:ThemeButtonWithArrow></td><td class="prbbc" style="text-align:right">
            <IPv5:ThemeButtonWithArrow runat="server" id="DirectorsFiltersButton" button-causesvalidation="False" button-commandname="Custom" button-onclientclick="return ISD_ShowPopupPanel(&#39;DirectorsFiltersDiv&#39;,&#39;DirectorsFiltersButton&#39;,this);" button-text="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;IPv5&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:Filters&quot;, &quot;IPv5&quot;) %>"></IPv5:ThemeButtonWithArrow>
          </td><td class="prbbc"><img src="../Images/space.gif" alt="" style="width: 10px" /></td><td></td></tr></table>
</td><td class="dher"><img src="../Images/space.gif" alt="" /></td><td>
                          <div id="DirectorsFiltersDiv" runat="server" class="popupWrapper">
                          <table cellpadding="0" cellspacing="0" border="0"><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td style="text-align: right;" class="popupTableCellValue"><input type="image" src="../Images/closeButton.gif" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="PropertyIDLabel" Text="Property">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("DirectorsFilterButton"))%>
<asp:DropDownList runat="server" id="PropertyIDFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)">	</asp:DropDownList><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("DirectorsFilterButton"))%>
</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"><asp:Literal runat="server" id="ContactIDLabel" Text="Contact">	</asp:Literal></td><td colspan="2" class="popupTableCellValue"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("DirectorsFilterButton"))%>
<asp:DropDownList runat="server" id="ContactIDFilter" cssclass="Filter_Input" onkeypress="dropDownListTypeAhead(this,false)">	</asp:DropDownList><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("DirectorsFilterButton"))%>
</td><td class="popupTableCellValue"><IPv5:ThemeButton runat="server" id="DirectorsFilterButton" button-causesvalidation="False" button-commandname="Search" button-text="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;IPv5&quot;) %>" button-tooltip="&lt;%# GetResourceValue(&quot;Btn:SearchGoButtonText&quot;, &quot;IPv5&quot;) %>" postback="False"></IPv5:ThemeButton></td><td class="popupTableCellValue">
                                  <asp:ImageButton runat="server" id="DirectorsResetButton" causesvalidation="False" commandname="ResetFilters" imageurl="../Images/ButtonBarResetOver.gif" tooltip="&lt;%# GetResourceValue(&quot;Btn:Reset&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                                </td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="DirectorsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="DirectorsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><asp:Repeater runat="server" id="DirectorsTableControlRepeater">		<ITEMTEMPLATE>		<IPv5:DirectorsTableControlRow runat="server" id="DirectorsTableControlRow">
<tr><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;" colspan="3">
                                  <asp:ImageButton runat="server" id="DirectorsRowEditButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton><br /><br />
                                
                                  <asp:ImageButton runat="server" id="DirectorsRowDeleteButton" causesvalidation="False" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src=&#39;../Images/icon_delete.gif&#39;" onmouseover="this.src=&#39;../Images/icon_delete_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton><br /><br />
                                
                                  <asp:ImageButton runat="server" id="DirectorsRowExpandCollapseRowButton" causesvalidation="False" commandname="ExpandCollapseRow" cssclass="button_link" imageurl="../Images/icon_expandcollapserow.gif" tooltip="&lt;%# GetResourceValue(&quot;Txt:ExpandCollapseRow&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton><br /><br />
                                </td><td class="$FieldValueCssName"></td><td class="$FieldValueCssName"></td><td class="$FieldValueCssName"></td><td class="$FieldValueCssName"></td><td class="$FieldValueCssName"></td><td class="$FieldValueCssName"></td><td class="$FieldValueCssName"></td><td class="$FieldValueCssName"></td></tr><tr id="DirectorsTableControlAltRow" runat="server"><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableRowButton" scope="row">&nbsp;</td><td class="tableCellValue" colspan="8"><%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("CancelButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureBeginTag(FindControlRecursively("SaveButton"))%>
<BaseClasses:TabContainer runat="server" id="DirectorsTabContainer" panellayout="Tabbed">
 <BaseClasses:TabPanel runat="server" id="ContactsTabPanel" HeaderText="Contact">	<ContentTemplate>
  <IPv5:ContactsRecordControl runat="server" id="ContactsRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="ContactsRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="ContactsRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="LastName2Label" Text="Last Name 2">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="LastName2"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="Address1Label1" Text="Address 1">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="Address11"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="TitleLabel" Text="Title">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="Title"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="PostCodeLabel1" Text="Post Code">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="PostCode1"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="FirstName2Label" Text="First Name 2">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="FirstName2"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="Address2Label1" Text="Address 2">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="Address21"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="IrdNumberLabel" Text="IRD Number">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="IrdNumber"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="ActiveLabel" Text="Active">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="Active"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="TrustNameLabel" Text="Trust Name">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="TrustName"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="Address3Label1" Text="Address 3">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="Address31"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="BankAccountLabel" Text="Bank Account">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="BankAccount"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="LastNameLabel" Text="Last Name">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="LastName"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="FirstNameLabel" Text="First Name">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="FirstName"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="eMailLabel" Text="Email">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="eMail"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="PhoneNumberLabel" Text="Phone Number">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="PhoneNumber"></asp:Literal> </td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="ContactsRecordControl_PostbackTracker" runat="server" />
</IPv5:ContactsRecordControl>

 </ContentTemplate></BaseClasses:TabPanel>
 <BaseClasses:TabPanel runat="server" id="PropertiesTabPanel" HeaderText="Property">	<ContentTemplate>
  <IPv5:PropertiesRecordControl runat="server" id="PropertiesRecordControl">	<table class="dv" cellpadding="0" cellspacing="0" border="0"><tr><td></td><td></td><td></td></tr><tr><td></td><td>
                  <asp:panel id="PropertiesRecordControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td><asp:panel id="PropertiesRecordControlPanel" runat="server"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="fls"><asp:Literal runat="server" id="CompanyNameLabel" Text="Company Name">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="CompanyName"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="Address1Label" Text="Address 1">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="Address1"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="PostCodeLabel" Text="Post Code">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="PostCode"></asp:Literal> </td></tr><tr><td class="fls"><asp:Literal runat="server" id="Address2Label" Text="Address 2">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="Address2"></asp:Literal> </td><td class="fls"><asp:Literal runat="server" id="Address3Label" Text="Address 3">	</asp:Literal></td><td class="dfv"><asp:Literal runat="server" id="Address3"></asp:Literal> </td><td class="fls"></td><td class="dfv"></td></tr></table></asp:panel>
</td></tr></table>
</asp:panel>
                </td><td></td></tr><tr><td></td><td></td><td></td></tr></table>
	<asp:hiddenfield id="PropertiesRecordControl_PostbackTracker" runat="server" />
</IPv5:PropertiesRecordControl>

 </ContentTemplate></BaseClasses:TabPanel>
</BaseClasses:TabContainer><%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("SaveAndNewButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("OKButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("EditButton"))%>
<%= SystemUtils.GenerateEnterKeyCaptureEndTag(FindControlRecursively("CancelButton"))%>
</td></tr><tr><td class="tableRowDivider" colspan="11">&nbsp;</td></tr></IPv5:DirectorsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <IPv5:PaginationModern runat="server" id="DirectorsPagination"></IPv5:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="DirectorsTableControl_PostbackTracker" runat="server" />
</IPv5:DirectorsTableControl>

            </td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>
</div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <div class="QDialog" id="dialog" style="display:none;"><iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe></div>  <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                