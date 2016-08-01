<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="IPv5" Assembly="IPv5" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="ShowMMContractExpiration.aspx.cs" Culture="en-NZ" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="IPv5.UI.ShowMMContractExpiration" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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

                <table cellpadding="0" cellspacing="0" border="0" style="width: 100%"><tr><td><asp:dropdownlist id="Expiration" runat="server" onselectedindexchanged="Expiration_SelectedIndexChanged" /></td><td></td></tr><tr><td></td><td><asp:GridView ID="MyGrid" runat="server" OnPageIndexChanging="gridView_PageIndexChanging" bordercolor="Silver" borderstyle="Solid" borderwidth="1px" cellpadding="5" cellspacing="1" cssclass="ttc_" forecolor="Silver" horizontalalign="Left" allowpaging="True" pageindex="1">
	<PagerSettings LastPageImageUrl="~/Images/arrow_end.gif" PreviousPageImageUrl="~/Images/arrow_left.gif" FirstPageImageUrl="~/Images/arrow_beg.gif" Position="Top" NextPageImageUrl="~/Images/arrow_right.gif" Mode="NextPreviousFirstLast"></PagerSettings>
	<RowStyle CssClass="ttc"></RowStyle>
	<SelectedRowStyle CssClass="ttcs"></SelectedRowStyle>
	<PagerStyle CssClass="ttc"></PagerStyle>
	<HeaderStyle CssClass="thc"></HeaderStyle>
</asp:GridView></td></tr></table>
    </ContentTemplate>
</asp:UpdatePanel>
</div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
    <div class="QDialog" id="dialog" style="display:none;"><iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe></div>  <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                