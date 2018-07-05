<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>
<%@ Register Tagprefix="Selectors" Namespace="IPv5" Assembly="IPv5" %>

<%@ Register Tagprefix="BaseClasses" Namespace="BaseClasses.Web.UI.WebControls" Assembly="BaseClasses" %>
<%@ Page Language="C#" EnableEventValidation="false" AutoEventWireup="false" Codebehind="Reports.aspx.cs" Culture="en-NZ" MasterPageFile="../Master Pages/HorizontalMenu.master" Inherits="IPv5.UI.Reports" %><asp:Content id="PageSection" ContentPlaceHolderID="PageContent" Runat="server">
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

                <table cellpadding="0" cellspacing="0" border="0" class="updatePanelContent"><tr><td>&nbsp;</td><td></td><td></td><td></td><td></td><td></td></tr><tr><td>&nbsp;</td><td></td><td></td><td></td><td></td><td></td></tr><tr><td style="text-align:center;"><asp:ImageButton runat="server" id="DirectorsButton" causesvalidation="False" clientidmode="Inherit" commandname="Redirect" enabletheming="True" imageurl="../Images/Directors.png">		
	</asp:ImageButton></td><td>&nbsp;</td><td style="text-align:center;"><asp:ImageButton runat="server" id="PropertyContactsButton" causesvalidation="False" clientidmode="Inherit" commandname="Redirect" enabletheming="True" imageurl="../Images/PropertyContact.png">		
	</asp:ImageButton></td><td></td><td style="text-align:center;"></td><td>&nbsp;</td></tr><tr><td style="text-align:center;"><asp:Label runat="server" id="Label3" Text="Directors">	</asp:Label></td><td style="text-align:center;"></td><td style="text-align:center;"><asp:Label runat="server" id="Label" Text="Property Contacts">	</asp:Label></td><td style="text-align:center;"></td><td style="text-align:center;"></td><td style="text-align:center;"></td></tr></table>
      </ContentTemplate>
</asp:UpdatePanel>

    </div>
    <div id="detailPopup" class="detailRolloverPopup" onmouseout="detailRolloverPopupClose();" onmouseover="clearTimeout(gPopupTimer);"></div>
                   <div class="QDialog" id="dialog" style="display:none;">
                          <iframe id="QuickPopupIframe" style="width:100%;height:100%;border:none"></iframe>
                   </div>                  
    <asp:ValidationSummary id="ValidationSummary1" ShowMessageBox="true" ShowSummary="false" runat="server"></asp:ValidationSummary>
</asp:Content>
                