<%@ Register Tagprefix="IPv5" TagName="ThemeButtonWithArrow" Src="../Shared/ThemeButtonWithArrow.ascx" %>

<%@ Register Tagprefix="IPv5" TagName="PaginationModern" Src="../Shared/PaginationModern.ascx" %>

<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="EditContactsTable.aspx.cs" Culture="en-NZ" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="IPv5.UI.EditContactsTable" %>
<%@ Register Tagprefix="Selectors" Namespace="IPv5" Assembly="IPv5" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Register Tagprefix="IPv5" TagName="ThemeButton" Src="../Shared/ThemeButton.ascx" %>

<%@ Register Tagprefix="IPv5" Namespace="IPv5.UI.Controls.EditContactsTable" Assembly="IPv5" %>
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
                  <table cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="dhel"><img src="../Images/space.gif" alt="" /></td><td class="dhb" style="width: 100%"><table cellpadding="0" cellspacing="0" border="0"><tr><td class="dht" valign="middle"><asp:Literal runat="server" id="ContactsTitle" Text="&lt;%#String.Concat(&quot;Contacts&quot;) %>">	</asp:Literal></td></tr></table>
</td><td class="dhb"><table cellpadding="0" cellspacing="0" border="0" style="width: 100%;"><tr><td></td><td class="prbbc"></td><td class="prbbc"></td><td><div id="ContactsButtonsDiv" runat="server" class="popupWrapper">
                <table border="0" cellpadding="0" cellspacing="0"><tr><td></td><td></td><td></td><td></td><td style="text-align: right;"><input type="image" src="../Images/closeButton.gif" alt="" onclick="ISD_HidePopupPanel();return false;" align="top" /><br /></td></tr><tr><td></td><td>
                    <asp:ImageButton runat="server" id="ContactsAddButton" causesvalidation="False" commandname="AddRecord" imageurl="../Images/ButtonBarNew.gif" onmouseout="this.src=&#39;../Images/ButtonBarNew.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarNewOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ContactsDeleteButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" imageurl="../Images/ButtonBarDelete.gif" onmouseout="this.src=&#39;../Images/ButtonBarDelete.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarDeleteOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Delete&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                  </td><td>
                    <asp:ImageButton runat="server" id="ContactsSaveButton" causesvalidation="True" commandname="UpdateData" imageurl="../Images/ButtonBarSave.gif" onmouseout="this.src=&#39;../Images/ButtonBarSave.gif&#39;" onmouseover="this.src=&#39;../Images/ButtonBarSaveOver.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Btn:Save&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton>
                  </td><td></td></tr><tr><td></td><td></td><td></td><td></td><td></td></tr></table>

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
              </td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="LastName2SortLabel" tooltip="Sort by LastName2" Text="Last Name 2" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="Address1SortLabel" tooltip="Sort by Address1" Text="Address 1" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="TitleSortLabel" tooltip="Sort by Title" Text="Title" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="FirstName2SortLabel" tooltip="Sort by FirstName2" Text="First Name 2" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="Address2SortLabel" tooltip="Sort by Address2" Text="Address 2" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="PostCodeSortLabel" tooltip="Sort by PostCode" Text="Post Code" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="TrustNameSortLabel" tooltip="Sort by TrustName" Text="Trust Name" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="Address3SortLabel" tooltip="Sort by Address3" Text="Address 3" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr><tr><td class="popupTableCellLabel"></td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="IrdNumberSortLabel" tooltip="Sort by IrdNumber" Text="IRD Number" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"><asp:LinkButton runat="server" id="LastNameSortLabel" tooltip="Sort by LastName" Text="Last Name" CausesValidation="False">	</asp:LinkButton>&nbsp;&nbsp;</td><td class="popupTableCellValue"></td><td class="popupTableCellValue"></td></tr></table>

                          </div>
                        </td><td class="dher"><img src="../Images/space.gif" alt="" /></td></tr></table>

                </td><td class="panelHeaderR"></td></tr><tr><td class="panelL"></td><td>
                  <asp:panel id="ContactsTableControlCollapsibleRegion" runat="server"><table class="dBody" cellpadding="0" cellspacing="0" border="0" width="100%"><tr><td class="tre"><table id="ContactsTableControlGrid" cellpadding="0" cellspacing="0" border="0" width="100%" onkeydown="captureUpDownKey(this, event)"><tr class="tch"><th class="thcnb" colspan="3"><asp:CheckBox runat="server" id="ContactsToggleAll" onclick="toggleAllCheckboxes(this);">	</asp:CheckBox></th><th class="thcwb" style="padding:0px;vertical-align:middle;">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th><th class="thc">&nbsp;</th></tr><asp:Repeater runat="server" id="ContactsTableControlRepeater">		<ITEMTEMPLATE>		<IPv5:ContactsTableControlRow runat="server" id="ContactsTableControlRow">
<tr><td class="tableCellSelectCheckbox" scope="row" style="font-size: 5px;" rowspan="6" colspan="3">
                              <asp:CheckBox runat="server" id="ContactsRecordRowSelection" onclick="moveToThisTableRow(this);">	</asp:CheckBox><br /><br />
                            </td><td class="tableRowButton" rowspan="6">
                          <asp:ImageButton runat="server" id="ContactsRowViewButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_view.gif" onmouseout="this.src=&#39;../Images/icon_view.gif&#39;" onmouseover="this.src=&#39;../Images/icon_view_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:ViewRecord&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton><br /><br />
                        
                          <asp:ImageButton runat="server" id="ContactsRowEditButton" causesvalidation="False" commandname="Redirect" cssclass="button_link" imageurl="../Images/icon_edit.gif" onmouseout="this.src=&#39;../Images/icon_edit.gif&#39;" onmouseover="this.src=&#39;../Images/icon_edit_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:EditRecord&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton><br /><br />
                        
                          <asp:ImageButton runat="server" id="ContactsRowDeleteButton" causesvalidation="False" commandargument="DeleteOnUpdate" commandname="DeleteRecord" cssclass="button_link" imageurl="../Images/icon_delete.gif" onmouseout="this.src=&#39;../Images/icon_delete.gif&#39;" onmouseover="this.src=&#39;../Images/icon_delete_over.gif&#39;" tooltip="&lt;%# GetResourceValue(&quot;Txt:DeleteRecord&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton><br /><br />
                        </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="LastName2Label" Text="Last Name 2">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="LastName2" Columns="30" MaxLength="30" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="LastName2TextBoxMaxLengthValidator" ControlToValidate="LastName2" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IPv5&quot;).Replace(&quot;{FieldName}&quot;, &quot;Last Name 2&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="Address1Label" Text="Address 1">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="Address1" Columns="40" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="Address1TextBoxMaxLengthValidator" ControlToValidate="Address1" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IPv5&quot;).Replace(&quot;{FieldName}&quot;, &quot;Address 1&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TitleLabel" Text="Title">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="Title" Columns="10" MaxLength="10" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="TitleTextBoxMaxLengthValidator" ControlToValidate="Title" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IPv5&quot;).Replace(&quot;{FieldName}&quot;, &quot;Title&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FirstName2Label" Text="First Name 2">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FirstName2" Columns="30" MaxLength="30" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FirstName2TextBoxMaxLengthValidator" ControlToValidate="FirstName2" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IPv5&quot;).Replace(&quot;{FieldName}&quot;, &quot;First Name 2&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="Address2Label" Text="Address 2">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="Address2" Columns="40" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="Address2TextBoxMaxLengthValidator" ControlToValidate="Address2" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IPv5&quot;).Replace(&quot;{FieldName}&quot;, &quot;Address 2&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="PostCodeLabel" Text="Post Code">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="PostCode" Columns="35" MaxLength="35" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="PostCodeTextBoxMaxLengthValidator" ControlToValidate="PostCode" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IPv5&quot;).Replace(&quot;{FieldName}&quot;, &quot;Post Code&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="TrustNameLabel" Text="Trust Name">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="TrustName" Columns="40" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="TrustNameTextBoxMaxLengthValidator" ControlToValidate="TrustName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IPv5&quot;).Replace(&quot;{FieldName}&quot;, &quot;Trust Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="Address3Label" Text="Address 3">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="Address3" Columns="40" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="Address3TextBoxMaxLengthValidator" ControlToValidate="Address3" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IPv5&quot;).Replace(&quot;{FieldName}&quot;, &quot;Address 3&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="IrdNumberLabel" Text="IRD Number">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="IrdNumber" Columns="15" MaxLength="15" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="IrdNumberTextBoxMaxLengthValidator" ControlToValidate="IrdNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IPv5&quot;).Replace(&quot;{FieldName}&quot;, &quot;IRD Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="LastNameLabel" Text="Last Name">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="LastName" Columns="30" MaxLength="30" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="LastNameTextBoxMaxLengthValidator" ControlToValidate="LastName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IPv5&quot;).Replace(&quot;{FieldName}&quot;, &quot;Last Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="CityIDLabel" Text="City">	</asp:Literal> 
</td><td class="tableCellValue" style="white-space:nowrap;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="CityID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
 
<asp:ImageButton runat="server" id="CityIDAddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" redirectstyle="NewWindow" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="ActiveLabel" Text="Active">	</asp:Literal> 
</td><td class="tableCellValue"><asp:CheckBox runat="server" id="Active"></asp:CheckBox> </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="FirstNameLabel" Text="First Name">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="FirstName" Columns="30" MaxLength="30" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="FirstNameTextBoxMaxLengthValidator" ControlToValidate="FirstName" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IPv5&quot;).Replace(&quot;{FieldName}&quot;, &quot;First Name&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="RegionIDLabel" Text="Region">	</asp:Literal> 
</td><td class="tableCellValue" style="white-space:nowrap;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="RegionID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
 
<asp:ImageButton runat="server" id="RegionIDAddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" redirectstyle="NewWindow" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="BankAccountLabel" Text="Bank Account">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="BankAccount" Columns="15" MaxLength="15" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="BankAccountTextBoxMaxLengthValidator" ControlToValidate="BankAccount" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IPv5&quot;).Replace(&quot;{FieldName}&quot;, &quot;Bank Account&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="eMailLabel" Text="Email">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="eMail" Columns="40" MaxLength="50" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="eMailTextBoxMaxLengthValidator" ControlToValidate="eMail" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IPv5&quot;).Replace(&quot;{FieldName}&quot;, &quot;Email&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="CountryIDLabel" Text="Country">	</asp:Literal> 
</td><td class="tableCellValue" style="white-space:nowrap;"><span style="white-space:nowrap;">
<asp:DropDownList runat="server" id="CountryID" cssclass="field_input" onkeypress="dropDownListTypeAhead(this,false)"></asp:DropDownList></span>
 
<asp:ImageButton runat="server" id="CountryIDAddRecordLink" causesvalidation="False" commandname="Redirect" imageurl="../Images/iconNewFlat.gif" redirectstyle="NewWindow" tooltip="&lt;%# GetResourceValue(&quot;Btn:Add&quot;, &quot;IPv5&quot;) %>">		
	</asp:ImageButton> </td><td class="tableCellLabel" scope="col"><asp:Literal runat="server" id="PhoneNumberLabel" Text="Phone Number">	</asp:Literal> 
</td><td class="tableCellValue"><span style="white-space:nowrap;">
<asp:TextBox runat="server" id="PhoneNumber" Columns="30" MaxLength="30" cssclass="field_input"></asp:TextBox>&nbsp;
<BaseClasses:TextBoxMaxLengthValidator runat="server" id="PhoneNumberTextBoxMaxLengthValidator" ControlToValidate="PhoneNumber" ErrorMessage="&lt;%# GetResourceValue(&quot;Val:ValueTooLong&quot;, &quot;IPv5&quot;).Replace(&quot;{FieldName}&quot;, &quot;Phone Number&quot;) %>"></BaseClasses:TextBoxMaxLengthValidator></span>
 </td></tr><tr><td class="tableRowDivider" colspan="10">&nbsp;</td></tr></IPv5:ContactsTableControlRow>
</ITEMTEMPLATE>

</asp:Repeater>
</table>
</td></tr></table>
</asp:panel>
                </td><td class="panelR"></td></tr><tr><td class="panelL"></td><td class="panelPaginationC">
                    <IPv5:PaginationModern runat="server" id="ContactsPagination"></IPv5:PaginationModern>
                    <!--To change the position of the pagination control, please search for "prspace" on the Online Help for instruction. -->
                  </td><td class="panelR"></td></tr><tr><td class="panelBL"><img src="../Images/space.gif" class="panelBLSpace" alt="" /></td><td class="panelB"></td><td class="panelBR"><img src="../Images/space.gif" class="panelBRSpace" alt="" /></td></tr></table>
	<asp:hiddenfield id="ContactsTableControl_PostbackTracker" runat="server" />
</IPv5:ContactsTableControl>

            </td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>
</div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <div class="QDialog" id="dialog" style="display:none;"><iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe></div>  <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                