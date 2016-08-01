
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// ShowVPropertyContactsTable.aspx page.  The Row or RecordControl classes are the 
// ideal place to add code customizations. For example, you can override the LoadData, 
// CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.

#region "Using statements"    

using Microsoft.VisualBasic;
using BaseClasses.Web.UI.WebControls;
using System;
using System.Collections;
using System.Collections.Generic;

using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Utils;
using ReportTools.ReportCreator;
using ReportTools.Shared;

        
using IPv5.Business;
using IPv5.Data;
using IPv5.UI;
using IPv5;
		

#endregion

  
namespace IPv5.UI.Controls.ShowVPropertyContactsTable
{
  

#region "Section 1: Place your customizations here."

    
public class VPropertyContactsTableControlRow : BaseVPropertyContactsTableControlRow
{
      
        // The BaseVPropertyContactsTableControlRow implements code for a ROW within the
        // the VPropertyContactsTableControl table.  The BaseVPropertyContactsTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of VPropertyContactsTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class VPropertyContactsTableControl : BaseVPropertyContactsTableControl
{
    // The BaseVPropertyContactsTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The VPropertyContactsTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  
public class ContactsRecordControl : BaseContactsRecordControl
{
      
        // The BaseContactsRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  
public class PropertiesRecordControl : BasePropertiesRecordControl
{
      
        // The BasePropertiesRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the VPropertyContactsTableControlRow control on the ShowVPropertyContactsTable page.
// Do not modify this class. Instead override any method in VPropertyContactsTableControlRow.
public class BaseVPropertyContactsTableControlRow : IPv5.UI.BaseApplicationRecordControl
{
        public BaseVPropertyContactsTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in VPropertyContactsTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in VPropertyContactsTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.VPropertyContactsRowExpandCollapseRowButton.Click += VPropertyContactsRowExpandCollapseRowButton_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseMM_IP1%dbo.vPropertyContacts record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseVPropertyContactsTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new VPropertyContactsRecord();
            
        }

        public override void DataBind()
        {
            // The DataBind method binds the user interface controls to the values
            // from the database record.  To do this, it calls the Set methods for 
            // each of the field displayed on the webpage.  It is better to make 
            // changes in the Set methods, rather than making changes here.
            
            base.DataBind();
            
            this.ClearControlsFromSession();
            
            // Make sure that the DataSource is initialized.
            
            if (this.DataSource == null) {
             //This is to make sure all the controls will be invisible if no record is present in the cell
             
                return;
            }
              
            // LoadData for DataSource for chart and report if they exist
          

            // Call the Set methods for each controls on the panel
        
                SetActive();
                SetActiveLabel();
                SetAddress1();
                SetAddress1Label();
                SetAddress2();
                SetAddress2Label();
                SetAddress3();
                SetAddress3Label();
                SetBankAccount();
                SetBankAccountLabel();
                SetCity();
                SetCityLabel();
                
                
                SetCountry();
                SetCountryLabel();
                SeteMail();
                SeteMailLabel();
                SetFirstName();
                SetFirstName2();
                SetFirstName2Label();
                SetFirstNameLabel();
                SetIrdNumber();
                SetIrdNumberLabel();
                SetLastName();
                SetLastName2();
                SetLastName2Label();
                SetLastNameLabel();
                SetLinkID();
                SetLinkIDLabel();
                SetPhoneNumber();
                SetPhoneNumberLabel();
                SetPostCode();
                SetPostCodeLabel();
                
                
                SetRegion();
                SetRegionLabel();
                SetTitle();
                SetTitleLabel();
                SetTrustName();
                SetTrustNameLabel();
                
                SetVPropertyContactsTabContainer();
                SetVPropertyContactsRowExpandCollapseRowButton();
              

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
            }
            

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
                      
        SetContactsRecordControl();

                  
        SetPropertiesRecordControl();

        
        }
        
        
        public virtual void SetActive()
        {
            
                    
            // Set the Active Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyContacts record retrieved from the database.
            // this.Active is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ActiveSpecified) {
                								
                // If the Active is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyContactsView.Active);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Active.Text = formattedValue;
                   
            } 
            
            else {
            
                // Active is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Active.Text = VPropertyContactsView.Active.Format(VPropertyContactsView.Active.DefaultValue);
            		
            }
            
            // If the Active is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Active.Text == null ||
                this.Active.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Active.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAddress1()
        {
            
                    
            // Set the Address1 Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyContacts record retrieved from the database.
            // this.Address1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address1Specified) {
                								
                // If the Address1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyContactsView.Address1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address1.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address1.Text = VPropertyContactsView.Address1.Format(VPropertyContactsView.Address1.DefaultValue);
            		
            }
            
            // If the Address1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Address1.Text == null ||
                this.Address1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Address1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAddress2()
        {
            
                    
            // Set the Address2 Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyContacts record retrieved from the database.
            // this.Address2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address2Specified) {
                								
                // If the Address2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyContactsView.Address2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address2.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address2.Text = VPropertyContactsView.Address2.Format(VPropertyContactsView.Address2.DefaultValue);
            		
            }
            
            // If the Address2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Address2.Text == null ||
                this.Address2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Address2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAddress3()
        {
            
                    
            // Set the Address3 Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyContacts record retrieved from the database.
            // this.Address3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address3Specified) {
                								
                // If the Address3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyContactsView.Address3);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address3.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address3.Text = VPropertyContactsView.Address3.Format(VPropertyContactsView.Address3.DefaultValue);
            		
            }
            
            // If the Address3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Address3.Text == null ||
                this.Address3.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Address3.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBankAccount()
        {
            
                    
            // Set the BankAccount Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyContacts record retrieved from the database.
            // this.BankAccount is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BankAccountSpecified) {
                								
                // If the BankAccount is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyContactsView.BankAccount);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BankAccount.Text = formattedValue;
                   
            } 
            
            else {
            
                // BankAccount is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BankAccount.Text = VPropertyContactsView.BankAccount.Format(VPropertyContactsView.BankAccount.DefaultValue);
            		
            }
            
            // If the BankAccount is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BankAccount.Text == null ||
                this.BankAccount.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BankAccount.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCity()
        {
            
                    
            // Set the City Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyContacts record retrieved from the database.
            // this.City is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CitySpecified) {
                								
                // If the City is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyContactsView.City);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.City.Text = formattedValue;
                   
            } 
            
            else {
            
                // City is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.City.Text = VPropertyContactsView.City.Format(VPropertyContactsView.City.DefaultValue);
            		
            }
            
            // If the City is NULL or blank, then use the value specified  
            // on Properties.
            if (this.City.Text == null ||
                this.City.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.City.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCountry()
        {
            
                    
            // Set the Country Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyContacts record retrieved from the database.
            // this.Country is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CountrySpecified) {
                								
                // If the Country is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyContactsView.Country);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Country.Text = formattedValue;
                   
            } 
            
            else {
            
                // Country is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Country.Text = VPropertyContactsView.Country.Format(VPropertyContactsView.Country.DefaultValue);
            		
            }
            
            // If the Country is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Country.Text == null ||
                this.Country.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Country.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SeteMail()
        {
            
                    
            // Set the eMail Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyContacts record retrieved from the database.
            // this.eMail is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.eMailSpecified) {
                								
                // If the eMail is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyContactsView.eMail);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.eMail.Text = formattedValue;
                   
            } 
            
            else {
            
                // eMail is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.eMail.Text = VPropertyContactsView.eMail.Format(VPropertyContactsView.eMail.DefaultValue);
            		
            }
            
            // If the eMail is NULL or blank, then use the value specified  
            // on Properties.
            if (this.eMail.Text == null ||
                this.eMail.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.eMail.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetFirstName()
        {
            
                    
            // Set the FirstName Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyContacts record retrieved from the database.
            // this.FirstName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FirstNameSpecified) {
                								
                // If the FirstName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyContactsView.FirstName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.FirstName.Text = formattedValue;
                   
            } 
            
            else {
            
                // FirstName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FirstName.Text = VPropertyContactsView.FirstName.Format(VPropertyContactsView.FirstName.DefaultValue);
            		
            }
            
            // If the FirstName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.FirstName.Text == null ||
                this.FirstName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.FirstName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetFirstName2()
        {
            
                    
            // Set the FirstName2 Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyContacts record retrieved from the database.
            // this.FirstName2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FirstName2Specified) {
                								
                // If the FirstName2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyContactsView.FirstName2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.FirstName2.Text = formattedValue;
                   
            } 
            
            else {
            
                // FirstName2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FirstName2.Text = VPropertyContactsView.FirstName2.Format(VPropertyContactsView.FirstName2.DefaultValue);
            		
            }
            
            // If the FirstName2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.FirstName2.Text == null ||
                this.FirstName2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.FirstName2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetIrdNumber()
        {
            
                    
            // Set the IrdNumber Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyContacts record retrieved from the database.
            // this.IrdNumber is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IrdNumberSpecified) {
                								
                // If the IrdNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyContactsView.IrdNumber);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.IrdNumber.Text = formattedValue;
                   
            } 
            
            else {
            
                // IrdNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.IrdNumber.Text = VPropertyContactsView.IrdNumber.Format(VPropertyContactsView.IrdNumber.DefaultValue);
            		
            }
            
            // If the IrdNumber is NULL or blank, then use the value specified  
            // on Properties.
            if (this.IrdNumber.Text == null ||
                this.IrdNumber.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.IrdNumber.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLastName()
        {
            
                    
            // Set the LastName Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyContacts record retrieved from the database.
            // this.LastName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LastNameSpecified) {
                								
                // If the LastName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyContactsView.LastName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LastName.Text = formattedValue;
                   
            } 
            
            else {
            
                // LastName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LastName.Text = VPropertyContactsView.LastName.Format(VPropertyContactsView.LastName.DefaultValue);
            		
            }
            
            // If the LastName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LastName.Text == null ||
                this.LastName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LastName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLastName2()
        {
            
                    
            // Set the LastName2 Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyContacts record retrieved from the database.
            // this.LastName2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LastName2Specified) {
                								
                // If the LastName2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyContactsView.LastName2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LastName2.Text = formattedValue;
                   
            } 
            
            else {
            
                // LastName2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LastName2.Text = VPropertyContactsView.LastName2.Format(VPropertyContactsView.LastName2.DefaultValue);
            		
            }
            
            // If the LastName2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LastName2.Text == null ||
                this.LastName2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LastName2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLinkID()
        {
            
                    
            // Set the LinkID Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyContacts record retrieved from the database.
            // this.LinkID is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LinkIDSpecified) {
                								
                // If the LinkID is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyContactsView.LinkID);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LinkID.Text = formattedValue;
                   
            } 
            
            else {
            
                // LinkID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LinkID.Text = VPropertyContactsView.LinkID.Format(VPropertyContactsView.LinkID.DefaultValue);
            		
            }
            
            // If the LinkID is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LinkID.Text == null ||
                this.LinkID.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LinkID.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPhoneNumber()
        {
            
                    
            // Set the PhoneNumber Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyContacts record retrieved from the database.
            // this.PhoneNumber is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PhoneNumberSpecified) {
                								
                // If the PhoneNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyContactsView.PhoneNumber);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PhoneNumber.Text = formattedValue;
                   
            } 
            
            else {
            
                // PhoneNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PhoneNumber.Text = VPropertyContactsView.PhoneNumber.Format(VPropertyContactsView.PhoneNumber.DefaultValue);
            		
            }
            
            // If the PhoneNumber is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PhoneNumber.Text == null ||
                this.PhoneNumber.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PhoneNumber.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPostCode()
        {
            
                    
            // Set the PostCode Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyContacts record retrieved from the database.
            // this.PostCode is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PostCodeSpecified) {
                								
                // If the PostCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyContactsView.PostCode);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PostCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // PostCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PostCode.Text = VPropertyContactsView.PostCode.Format(VPropertyContactsView.PostCode.DefaultValue);
            		
            }
            
            // If the PostCode is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PostCode.Text == null ||
                this.PostCode.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PostCode.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRegion()
        {
            
                    
            // Set the Region Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyContacts record retrieved from the database.
            // this.Region is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RegionSpecified) {
                								
                // If the Region is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyContactsView.Region);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Region.Text = formattedValue;
                   
            } 
            
            else {
            
                // Region is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Region.Text = VPropertyContactsView.Region.Format(VPropertyContactsView.Region.DefaultValue);
            		
            }
            
            // If the Region is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Region.Text == null ||
                this.Region.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Region.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTitle()
        {
            
                    
            // Set the Title Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyContacts record retrieved from the database.
            // this.Title is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Title0Specified) {
                								
                // If the Title is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyContactsView.Title0);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Title.Text = formattedValue;
                   
            } 
            
            else {
            
                // Title is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Title.Text = VPropertyContactsView.Title0.Format(VPropertyContactsView.Title0.DefaultValue);
            		
            }
            
            // If the Title is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Title.Text == null ||
                this.Title.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Title.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTrustName()
        {
            
                    
            // Set the TrustName Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyContacts record retrieved from the database.
            // this.TrustName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TrustNameSpecified) {
                								
                // If the TrustName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyContactsView.TrustName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TrustName.Text = formattedValue;
                   
            } 
            
            else {
            
                // TrustName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TrustName.Text = VPropertyContactsView.TrustName.Format(VPropertyContactsView.TrustName.DefaultValue);
            		
            }
            
            // If the TrustName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TrustName.Text == null ||
                this.TrustName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TrustName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetActiveLabel()
                  {
                  
                    
        }
                
        public virtual void SetAddress1Label()
                  {
                  
                    
        }
                
        public virtual void SetAddress2Label()
                  {
                  
                    
        }
                
        public virtual void SetAddress3Label()
                  {
                  
                    
        }
                
        public virtual void SetBankAccountLabel()
                  {
                  
                    
        }
                
        public virtual void SetCityLabel()
                  {
                  
                    
        }
                
        public virtual void SetCountryLabel()
                  {
                  
                    
        }
                
        public virtual void SeteMailLabel()
                  {
                  
                    
        }
                
        public virtual void SetFirstName2Label()
                  {
                  
                    
        }
                
        public virtual void SetFirstNameLabel()
                  {
                  
                    
        }
                
        public virtual void SetIrdNumberLabel()
                  {
                  
                    
        }
                
        public virtual void SetLastName2Label()
                  {
                  
                    
        }
                
        public virtual void SetLastNameLabel()
                  {
                  
                    
        }
                
        public virtual void SetLinkIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetPhoneNumberLabel()
                  {
                  
                    
        }
                
        public virtual void SetPostCodeLabel()
                  {
                  
                    
        }
                
        public virtual void SetRegionLabel()
                  {
                  
                    
        }
                
        public virtual void SetTitleLabel()
                  {
                  
                    
        }
                
        public virtual void SetTrustNameLabel()
                  {
                  
                    
        }
                
        public virtual void SetVPropertyContactsTabContainer()    
        
        {
                            
                   
            if (EvaluateFormula("URL(\"TabVisible\")").ToLower() == "true") 
                MiscUtils.FindControlRecursively(this, "VPropertyContactsTabContainer").Visible = true;
            else if (EvaluateFormula("URL(\"TabVisible\")").ToLower() == "false") 
                MiscUtils.FindControlRecursively(this, "VPropertyContactsTabContainer").Visible = false;
         
  
        }      
      
        public virtual void SetContactsRecordControl()           
        
        {        
            if (ContactsRecordControl.Visible)
            {
                ContactsRecordControl.LoadData();
                ContactsRecordControl.DataBind();
            }
        }
      
        public virtual void SetPropertiesRecordControl()           
        
        {        
            if (PropertiesRecordControl.Visible)
            {
                PropertiesRecordControl.LoadData();
                PropertiesRecordControl.DataBind();
            }
        }
      
        public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
        {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();
            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            
            
            if (includeDS)
            {
                
            }
            
            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            if (dataSourceForEvaluate == null)
                e.DataSource = this.DataSource;
            else
                e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
                
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
        
      

        public virtual void RegisterPostback()
        {
            
        }
    
        

        public virtual void SaveData()
        {
            // Saves the associated record in the database.
            // SaveData calls Validate and Get methods - so it may be more appropriate to
            // customize those methods.

            // 1. Load the existing record from the database. Since we save the entire record, this ensures 
            // that fields that are not displayed are also properly initialized.
            this.LoadData();
        
          
            // 2. Perform any custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.
            // This calls the Get() method for each of the user interface controls.
            this.GetUIData();
   
            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit yet.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
                
                // Set the DataChanged flag to True for the for the related panels so they get refreshed as well.
                ((VPropertyContactsTableControl)MiscUtils.GetParentControlObject(this, "VPropertyContactsTableControl")).DataChanged = true;
                ((VPropertyContactsTableControl)MiscUtils.GetParentControlObject(this, "VPropertyContactsTableControl")).ResetData = true;
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
            // For Master-Detail relationships, save data on the Detail table(s)            
          ContactsRecordControl recContactsRecordControl = (ContactsRecordControl)(MiscUtils.FindControlRecursively(this, "ContactsRecordControl"));
        recContactsRecordControl.SaveData();
        PropertiesRecordControl recPropertiesRecordControl = (PropertiesRecordControl)(MiscUtils.FindControlRecursively(this, "PropertiesRecordControl"));
        recPropertiesRecordControl.SaveData();
        
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetActive();
            GetAddress1();
            GetAddress2();
            GetAddress3();
            GetBankAccount();
            GetCity();
            GetCountry();
            GeteMail();
            GetFirstName();
            GetFirstName2();
            GetIrdNumber();
            GetLastName();
            GetLastName2();
            GetLinkID();
            GetPhoneNumber();
            GetPostCode();
            GetRegion();
            GetTitle();
            GetTrustName();
        }
        
        
        public virtual void GetActive()
        {
            
        }
                
        public virtual void GetAddress1()
        {
            
        }
                
        public virtual void GetAddress2()
        {
            
        }
                
        public virtual void GetAddress3()
        {
            
        }
                
        public virtual void GetBankAccount()
        {
            
        }
                
        public virtual void GetCity()
        {
            
        }
                
        public virtual void GetCountry()
        {
            
        }
                
        public virtual void GeteMail()
        {
            
        }
                
        public virtual void GetFirstName()
        {
            
        }
                
        public virtual void GetFirstName2()
        {
            
        }
                
        public virtual void GetIrdNumber()
        {
            
        }
                
        public virtual void GetLastName()
        {
            
        }
                
        public virtual void GetLastName2()
        {
            
        }
                
        public virtual void GetLinkID()
        {
            
        }
                
        public virtual void GetPhoneNumber()
        {
            
        }
                
        public virtual void GetPostCode()
        {
            
        }
                
        public virtual void GetRegion()
        {
            
        }
                
        public virtual void GetTitle()
        {
            
        }
                
        public virtual void GetTrustName()
        {
            
        }
                

      // To customize, override this method in VPropertyContactsTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersContactsRecordControl = false;
            hasFiltersContactsRecordControl = hasFiltersContactsRecordControl && false; // suppress warning
      
            bool hasFiltersPropertiesRecordControl = false;
            hasFiltersPropertiesRecordControl = hasFiltersPropertiesRecordControl && false; // suppress warning
      
            bool hasFiltersVPropertyContactsTableControl = false;
            hasFiltersVPropertyContactsTableControl = hasFiltersVPropertyContactsTableControl && false; // suppress warning
      
            return null;
        
        }
        
        
    
        public virtual void Validate()
        {
            // Add custom validation for any control within this panel.
            // Example.  If you have a State ASP:Textbox control
            // if (this.State.Text != "CA")
            //    throw new Exception("State must be CA (California).");
            // The Validate method is common across all controls within
            // this panel so you can validate multiple fields, but report
            // one error message.
            
            
            
        }

        public virtual void Delete()
        {
        
        }

        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    this.LoadData();
                    this.DataBind();
                }
                				
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
        
    
            // Save pagination state to session.
          
        }
        
        
    
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

        

            // Clear pagination state from session.
        
        }
        
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
        
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        
    
            // Load view state for pagination control.
                 
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
        

            // Load view state for pagination control.
               
            return base.SaveViewState();
        }

        
    
        // Generate set method for buttons
        
        public virtual void SetVPropertyContactsRowExpandCollapseRowButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void VPropertyContactsRowExpandCollapseRowButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                VPropertyContactsTableControl panelControl = (MiscUtils.GetParentControlObject(this, "VPropertyContactsTableControl") as VPropertyContactsTableControl);

          VPropertyContactsTableControlRow[] repeatedRows = panelControl.GetRecordControls();
          foreach (VPropertyContactsTableControlRow repeatedRow in repeatedRows)
          {
              System.Web.UI.Control altRow = (MiscUtils.FindControlRecursively(repeatedRow, "VPropertyContactsTableControlAltRow") as System.Web.UI.Control);
              if (altRow != null)
              {
                  if (sender == repeatedRow.VPropertyContactsRowExpandCollapseRowButton)
                      altRow.Visible = !altRow.Visible;
                  
                  if (altRow.Visible)
                  {
                   
                     repeatedRow.VPropertyContactsRowExpandCollapseRowButton.ImageUrl = "../Images/icon_expandcollapserow.gif";
                     repeatedRow.VPropertyContactsRowExpandCollapseRowButton.Attributes.Add("onmouseover", "");
                     repeatedRow.VPropertyContactsRowExpandCollapseRowButton.Attributes.Add("onmouseout", "");
                           
                  }
                  else
                  {
                   
                     repeatedRow.VPropertyContactsRowExpandCollapseRowButton.ImageUrl = "../Images/icon_expandcollapserow2.gif";
                     repeatedRow.VPropertyContactsRowExpandCollapseRowButton.Attributes.Add("onmouseover", "");
                     repeatedRow.VPropertyContactsRowExpandCollapseRowButton.Attributes.Add("onmouseout", "");
                   
                  }
            
              }
              else
              {
                  this.Page.Response.Redirect("../Shared/ConfigureCollapseExpandRowBtn.aspx");
              }
          }
          
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public VPropertyContactsRecord DataSource {
            get {
                return (VPropertyContactsRecord)(this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }
        

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }
    
        private int _TotalPages;
        public virtual int TotalPages {
            get {
                return (this._TotalPages);
            }
            set {
                this._TotalPages = value;
            }
        }
        
        private int _PageIndex;
        public virtual int PageIndex {
            get {
                return (this._PageIndex);
            }
            set {
                this._PageIndex = value;
            }
        }
        
        private bool _DisplayLastPage;
        public virtual bool DisplayLastPage {
            get {
                return (this._DisplayLastPage);
            }
            set {
                this._DisplayLastPage = value;
            }
        }
        
        
    
        private KeyValue selectedParentKeyValue;
        public KeyValue SelectedParentKeyValue
        {
            get
            {
                return this.selectedParentKeyValue;
            }
            set
            {
                this.selectedParentKeyValue = value;
            }
        }
       
#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal Active {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Active");
            }
        }
            
        public System.Web.UI.WebControls.Literal ActiveLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ActiveLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Address1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address1");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address1Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal Address2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address2");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal Address3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address3");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address3Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal BankAccount {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BankAccount");
            }
        }
            
        public System.Web.UI.WebControls.Literal BankAccountLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BankAccountLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal City {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "City");
            }
        }
            
        public System.Web.UI.WebControls.Literal CityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CityLabel");
            }
        }
        
        public ContactsRecordControl ContactsRecordControl {
            get {
                return (ContactsRecordControl)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactsRecordControl");
            }
        }
        
        public System.Web.UI.WebControls.Literal Country {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Country");
            }
        }
            
        public System.Web.UI.WebControls.Literal CountryLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CountryLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal eMail {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "eMail");
            }
        }
            
        public System.Web.UI.WebControls.Literal eMailLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "eMailLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal FirstName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirstName");
            }
        }
            
        public System.Web.UI.WebControls.Literal FirstName2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirstName2");
            }
        }
            
        public System.Web.UI.WebControls.Literal FirstName2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirstName2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal FirstNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirstNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal IrdNumber {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IrdNumber");
            }
        }
            
        public System.Web.UI.WebControls.Literal IrdNumberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IrdNumberLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LastName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastName");
            }
        }
            
        public System.Web.UI.WebControls.Literal LastName2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastName2");
            }
        }
            
        public System.Web.UI.WebControls.Literal LastName2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastName2Label");
            }
        }
        
        public System.Web.UI.WebControls.Literal LastNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal LinkID {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LinkID");
            }
        }
            
        public System.Web.UI.WebControls.Literal LinkIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LinkIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal PhoneNumber {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PhoneNumber");
            }
        }
            
        public System.Web.UI.WebControls.Literal PhoneNumberLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PhoneNumberLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal PostCode {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PostCode");
            }
        }
            
        public System.Web.UI.WebControls.Literal PostCodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PostCodeLabel");
            }
        }
        
        public PropertiesRecordControl PropertiesRecordControl {
            get {
                return (PropertiesRecordControl)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertiesRecordControl");
            }
        }
        
        public System.Web.UI.WebControls.Literal Region {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Region");
            }
        }
            
        public System.Web.UI.WebControls.Literal RegionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RegionLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title");
            }
        }
            
        public System.Web.UI.WebControls.Literal TitleLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TitleLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal TrustName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TrustName");
            }
        }
            
        public System.Web.UI.WebControls.Literal TrustNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TrustNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton VPropertyContactsRowExpandCollapseRowButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyContactsRowExpandCollapseRowButton");
            }
        }
        
        public AjaxControlToolkit.TabContainer VPropertyContactsTabContainer {
            get {
                return (AjaxControlToolkit.TabContainer)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyContactsTabContainer");
            }
        }
        
    #endregion

    #region "Helper Functions"
    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
    }

    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
    }

    public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
    {
        VPropertyContactsRecord rec = null;
             
            try {
                rec = this.GetRecord();
            }
            catch (Exception ) {
                // Do Nothing
            }
            
            if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                
                throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IPv5"));
                    
            }
        
            return EvaluateExpressions(url, arg, rec, bEncrypt);
        
    }


    public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
    {
    VPropertyContactsRecord rec = null;
    
          try {
               rec = this.GetRecord();
          }
          catch (Exception ) {
          // Do Nothing
          }

          if (rec == null && url.IndexOf("{") >= 0) {
          // Localization.
    
              throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IPv5"));
      
          }
    
          if (includeSession)
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt);
          }
          else
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt,includeSession);
          }
    
    }

        
        public virtual VPropertyContactsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            // Localization.
            
            throw new Exception(Page.GetResourceValue("Err:RetrieveRec", "IPv5"));
                
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  
// Base class for the VPropertyContactsTableControl control on the ShowVPropertyContactsTable page.
// Do not modify this class. Instead override any method in VPropertyContactsTableControl.
public class BaseVPropertyContactsTableControl : IPv5.UI.BaseApplicationTableControl
{
         
       public BaseVPropertyContactsTableControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
      
    
           // Setup the filter and search.
        
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.ContactIDFilter)) 				
                    initialVal = this.GetFromSession(this.ContactIDFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"ContactID\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.ContactIDFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.ContactIDFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.PropertyIDFilter)) 				
                    initialVal = this.GetFromSession(this.PropertyIDFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"PropertyID\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.PropertyIDFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.PropertyIDFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.VPropertyContactsSearch)) 				
                    initialVal = this.GetFromSession(this.VPropertyContactsSearch);
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.VPropertyContactsSearch.Text = initialVal;
                            
                    }
            }


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "10"));
            this.PageIndex = Convert.ToInt32(this.GetFromSession(this, "Page_Index", "0"));
                     
        }

        protected virtual void Control_Load(object sender, EventArgs e)
        {
        
            SaveControlsToSession_Ajax();
        
            // Setup the pagination events.
            
                    this.VPropertyContactsPagination.FirstPage.Click += VPropertyContactsPagination_FirstPage_Click;
                        
                    this.VPropertyContactsPagination.LastPage.Click += VPropertyContactsPagination_LastPage_Click;
                        
                    this.VPropertyContactsPagination.NextPage.Click += VPropertyContactsPagination_NextPage_Click;
                        
                    this.VPropertyContactsPagination.PageSizeButton.Click += VPropertyContactsPagination_PageSizeButton_Click;
                        
                    this.VPropertyContactsPagination.PreviousPage.Click += VPropertyContactsPagination_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
              this.Address1SortLabel.Click += Address1SortLabel_Click;
            
              this.Address2SortLabel.Click += Address2SortLabel_Click;
            
              this.Address3SortLabel.Click += Address3SortLabel_Click;
            
              this.FirstName2SortLabel.Click += FirstName2SortLabel_Click;
            
              this.IrdNumberSortLabel.Click += IrdNumberSortLabel_Click;
            
              this.LastName2SortLabel.Click += LastName2SortLabel_Click;
            
              this.LinkIDSortLabel.Click += LinkIDSortLabel_Click;
            
              this.PostCodeSortLabel.Click += PostCodeSortLabel_Click;
            
              this.TitleSortLabel.Click += TitleSortLabel_Click;
            
              this.TrustNameSortLabel.Click += TrustNameSortLabel_Click;
            
            // Setup the button events.
          
                    this.VPropertyContactsExportExcelButton.Click += VPropertyContactsExportExcelButton_Click;
                        
                    this.VPropertyContactsPDFButton.Click += VPropertyContactsPDFButton_Click;
                        
                    this.VPropertyContactsResetButton.Click += VPropertyContactsResetButton_Click;
                        
                    this.VPropertyContactsSearchButton.Click += VPropertyContactsSearchButton_Click;
                        
                    this.VPropertyContactsWordButton.Click += VPropertyContactsWordButton_Click;
                        
                    this.VPropertyContactsButtonsButton.Button.Click += VPropertyContactsButtonsButton_Click;
                        
                    this.VPropertyContactsFilterButton.Button.Click += VPropertyContactsFilterButton_Click;
                        
                    this.VPropertyContactsFiltersButton.Button.Click += VPropertyContactsFiltersButton_Click;
                        
            this.ContactIDFilter.SelectedIndexChanged += new EventHandler(ContactIDFilter_SelectedIndexChanged);
            
            this.PropertyIDFilter.SelectedIndexChanged += new EventHandler(PropertyIDFilter_SelectedIndexChanged);
                    
        
         //' Setup events for others
            AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "VPropertyContactsSearchSearchBoxText", "setSearchBoxText(\"" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "\", \"" + VPropertyContactsSearch.ClientID + "\");", true);
             
        }

        public virtual void LoadData()
        {
            // Read data from database. Returns an array of records that can be assigned
            // to the DataSource table control property.
            try {
                  CompoundFilter joinFilter = CreateCompoundJoinFilter();
                
                  // The WHERE clause will be empty when displaying all records in table.
                  WhereClause wc = CreateWhereClause();
                  if (wc != null && !wc.RunQuery) {
                        // Initialize an empty array of records
                      ArrayList alist = new ArrayList(0);
                      Type myrec = typeof(IPv5.Business.VPropertyContactsRecord);
                      this.DataSource = (VPropertyContactsRecord[])(alist.ToArray(myrec));
                      // Add records to the list if needed.
                      this.AddNewRecords();
                      this._TotalRecords = 0;
                      this._TotalPages = 0;
                      return;
                  }

                  // Call OrderBy to determine the order - either use the order defined
                  // on the Query Wizard, or specified by user (by clicking on column heading)

                  OrderBy orderBy = CreateOrderBy();

      
                // Get the pagesize from the pagesize control.
                this.GetPageSize();
                if (this.DisplayLastPage)
                {
                    int totalRecords = this._TotalRecords < 0? GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause()): this._TotalRecords;
                     
                        int totalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(totalRecords) / Convert.ToDouble(this.PageSize)));
                       
                    this.PageIndex = totalPages - 1;                
                }
                
                // Make sure PageIndex (current page) and PageSize are within bounds.
                if (this.PageIndex < 0)
                    this.PageIndex = 0;
                if (this.PageSize < 1)
                    this.PageSize = 1;
                
                
                // Retrieve the records and set the table DataSource.
                // Only PageSize records are fetched starting at PageIndex (zero based).
                if (this.AddNewRecord > 0) {
                    // Make sure to preserve the previously entered data on new rows.
                    ArrayList postdata = new ArrayList(0);
                    foreach (VPropertyContactsTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(IPv5.Business.VPropertyContactsRecord);
                    this.DataSource = (VPropertyContactsRecord[])(postdata.ToArray(myrec));
                } 
                else {
                    // Get the records from the database
                    
                        this.DataSource = GetRecords(joinFilter, wc, orderBy, this.PageIndex, this.PageSize);
                                          
                }
                
                // if the datasource contains no records contained in database, then load the last page.
                if (DbUtils.GetCreatedRecords(this.DataSource).Length == 0 && !this.DisplayLastPage)
                {
                      this.DisplayLastPage = true;
                      LoadData();
                }
                else
                {
                    // Add any new rows desired by the user.
                    this.AddNewRecords();
                    
    
                    // Initialize the page and grand totals. now
                
                }                 
                

    
            } catch (Exception ex) {
                // Report the error message to the end user
                    String msg = ex.Message;
                    if (ex.InnerException != null)
                        msg += " InnerException: " + ex.InnerException.Message;

                    throw new Exception(msg, ex.InnerException);
            }
        }
        
        public virtual VPropertyContactsRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(VPropertyContactsView.Column1, true);          
            // selCols.Add(VPropertyContactsView.Column2, true);          
            // selCols.Add(VPropertyContactsView.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return VPropertyContactsView.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                VPropertyContactsView databaseTable = new VPropertyContactsView();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(VPropertyContactsRecord)) as VPropertyContactsRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(VPropertyContactsView.Column1, true);          
            // selCols.Add(VPropertyContactsView.Column2, true);          
            // selCols.Add(VPropertyContactsView.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return VPropertyContactsView.GetRecordCount(join, where);
            else
            {
                VPropertyContactsView databaseTable = new VPropertyContactsView();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);        
                
                return (int)(databaseTable.GetRecordListCount(join, where.GetFilter(), null, null));
            }

        }
        
      
    
      public override void DataBind()
      {
          // The DataBind method binds the user interface controls to the values
          // from the database record for each row in the table.  To do this, it calls the
          // DataBind for each of the rows.
          // DataBind also populates any filters above the table, and sets the pagination
          // control to the correct number of records and the current page number.
         
          
          base.DataBind();
          

          this.ClearControlsFromSession();
          
          // Make sure that the DataSource is initialized.
          if (this.DataSource == null) {
              return;
          }
          
          //  LoadData for DataSource for chart and report if they exist
               

            // Setup the pagination controls.
            BindPaginationControls();

    
        
        // Bind the repeater with the list of records to expand the UI.
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyContactsTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            VPropertyContactsTableControlRow recControl = (VPropertyContactsTableControlRow)(repItem.FindControl("VPropertyContactsTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                SetAddress1SortLabel();
                SetAddress2SortLabel();
                SetAddress3SortLabel();
                SetContactIDFilter();
                SetContactIDLabel();
                SetFirstName2SortLabel();
                SetIrdNumberSortLabel();
                SetLastName2SortLabel();
                SetLinkIDSortLabel();
                SetPostCodeSortLabel();
                SetPropertyIDFilter();
                SetPropertyIDLabel();
                SetTitleSortLabel();
                SetTrustNameSortLabel();
                
                
                
                
                
                
                
                SetVPropertyContactsSearch();
                
                
                
                
                SetVPropertyContactsExportExcelButton();
              
                SetVPropertyContactsPDFButton();
              
                SetVPropertyContactsResetButton();
              
                SetVPropertyContactsSearchButton();
              
                SetVPropertyContactsWordButton();
              
                SetVPropertyContactsButtonsButton();
              
                SetVPropertyContactsFilterButton();
              
                SetVPropertyContactsFiltersButton();
              
            // setting the state of expand or collapse alternative rows
      
            bool expandFirstRow = true;
        VPropertyContactsTableControlRow[] recControls = this.GetRecordControls();
            for (int i = 0; i < recControls.Length; i++)
            {
                System.Web.UI.Control altRow = (MiscUtils.FindControlRecursively(recControls[i], "VPropertyContactsTableControlAltRow") as System.Web.UI.Control);
                if (altRow != null){
                    if (expandFirstRow && i == 0){
                        altRow.Visible = true;
                   
                         recControls[i].VPropertyContactsRowExpandCollapseRowButton.ImageUrl = "../Images/icon_expandcollapserow.gif";
                         recControls[i].VPropertyContactsRowExpandCollapseRowButton.Attributes.Add("onmouseover", "");
                         recControls[i].VPropertyContactsRowExpandCollapseRowButton.Attributes.Add("onmouseout", "");
                   
                    }
                    else{
                        altRow.Visible = false;
                   
                         recControls[i].VPropertyContactsRowExpandCollapseRowButton.ImageUrl = "../Images/icon_expandcollapserow2.gif";
                         recControls[i].VPropertyContactsRowExpandCollapseRowButton.Attributes.Add("onmouseover", "");
                         recControls[i].VPropertyContactsRowExpandCollapseRowButton.Attributes.Add("onmouseout", "");
                   
                    }
                }
            }
    
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetVPropertyContactsFiltersButton();
                     
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
    public virtual void AddWarningMessageOnClick() {
    
        if (this.TotalRecords > 10000)
          this.VPropertyContactsExportExcelButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm", "IPv5") + "'));");
        else
          this.VPropertyContactsExportExcelButton.Attributes.Remove("onClick");
      
    }
  

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"VPropertyContactsExportExcelButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"VPropertyContactsPDFButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"VPropertyContactsWordButton"));
                                
        }
        

        
          public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

          public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
          {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();

            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            if (includeDS)
            {
                
            }

            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
        
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
           
        public virtual void ResetControl()
        {


            
            this.ContactIDFilter.ClearSelection();
            
            this.PropertyIDFilter.ClearSelection();
            
            this.VPropertyContactsSearch.Text = "";
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
               
            }
                
            this.PageIndex = 0;
        }
        
        public virtual void ResetPageControl()
        {
            this.PageIndex = 0;
        }
        
        protected virtual void BindPaginationControls()
        {
            // Setup the pagination controls.   

            // Bind the pagination labels.
        
            if (DbUtils.GetCreatedRecords(this.DataSource).Length > 0)                      
                    
            {
                this.VPropertyContactsPagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.VPropertyContactsPagination.CurrentPage.Text = "0";
            }
            this.VPropertyContactsPagination.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for VPropertyContactsTableControl pagination.
        
            this.VPropertyContactsPagination.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.VPropertyContactsPagination.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.VPropertyContactsPagination.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.VPropertyContactsPagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.VPropertyContactsPagination.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.VPropertyContactsPagination.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.VPropertyContactsPagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.VPropertyContactsPagination.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (VPropertyContactsTableControlRow recCtl in this.GetRecordControls())
            {
        
                if (recCtl.Visible) {
                    recCtl.SaveData();
                }
          
            }

          
    
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
          
            // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            foreach (VPropertyContactsTableControlRow recCtl in this.GetRecordControls()){
                recCtl.IsNewRecord = false;
            }
                
        }
        
        public virtual CompoundFilter CreateCompoundJoinFilter()
        {
            CompoundFilter jFilter = new CompoundFilter();
        
           return jFilter;
        }      
        
    
        public virtual OrderBy CreateOrderBy()
        {
            // The CurrentSortOrder is initialized to the sort order on the 
            // Query Wizard.  It may be modified by the Click handler for any of
            // the column heading to sort or reverse sort by that column.
            // You can add your own sort order, or modify it on the Query Wizard.
            return this.CurrentSortOrder;
        }
         
        
        private string parentSelectedKeyValue;
        public string ParentSelectedKeyValue
        {
          get
          {
            return parentSelectedKeyValue;
          }
          set
          {
            parentSelectedKeyValue = value;
          }
        }

    
        public virtual WhereClause CreateWhereClause()
        {
            // This CreateWhereClause is used for loading the data.
            VPropertyContactsView.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            if (MiscUtils.IsValueSelected(this.ContactIDFilter)) {
                        
                wc.iAND(VPropertyContactsView.ContactID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.ContactIDFilter, this.GetFromSession(this.ContactIDFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.PropertyIDFilter)) {
                        
                wc.iAND(VPropertyContactsView.PropertyID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.PropertyIDFilter, this.GetFromSession(this.PropertyIDFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.VPropertyContactsSearch)) {
                if (this.VPropertyContactsSearch.Text == BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) ) {
                        this.VPropertyContactsSearch.Text = "";
                } else {
                  // Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                  if (this.VPropertyContactsSearch.Text.StartsWith("...")) {
                      this.VPropertyContactsSearch.Text = this.VPropertyContactsSearch.Text.Substring(3,this.VPropertyContactsSearch.Text.Length-3);
                  }
                  if (this.VPropertyContactsSearch.Text.EndsWith("...")) {
                      this.VPropertyContactsSearch.Text = this.VPropertyContactsSearch.Text.Substring(0,this.VPropertyContactsSearch.Text.Length-3);
                      // Strip the last word as well as it is likely only a partial word
                      int endindex = this.VPropertyContactsSearch.Text.Length - 1;
                      while (!Char.IsWhiteSpace(VPropertyContactsSearch.Text[endindex]) && endindex > 0) {
                          endindex--;
                      }
                      if (endindex > 0) {
                          this.VPropertyContactsSearch.Text = this.VPropertyContactsSearch.Text.Substring(0, endindex);
                      }
                  }
                }
                string formatedSearchText = MiscUtils.GetSelectedValue(this.VPropertyContactsSearch, this.GetFromSession(this.VPropertyContactsSearch));
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(this.VPropertyContactsSearch)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                  
                    WhereClause search = new WhereClause();
                    
        ColumnList cols = new ColumnList();
      
      cols.Add(VPropertyContactsView.Title0, true);
      
      cols.Add(VPropertyContactsView.FirstName, true);
      
      foreach(BaseColumn col in cols)
      {
      
          search.iOR(col, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(this.VPropertyContactsSearch, this.GetFromSession(this.VPropertyContactsSearch)), true, false);
        
      }
    
                    wc.iAND(search);
                  
                }
            }
                       
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            VPropertyContactsView.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String ContactIDFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "ContactIDFilter_Ajax"];
            if (MiscUtils.IsValueSelected(ContactIDFilterSelectedValue)) {

              
                wc.iAND(VPropertyContactsView.ContactID, BaseFilter.ComparisonOperator.EqualsTo, ContactIDFilterSelectedValue, false, false);
                      
      }
                      
      String PropertyIDFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "PropertyIDFilter_Ajax"];
            if (MiscUtils.IsValueSelected(PropertyIDFilterSelectedValue)) {

              
                wc.iAND(VPropertyContactsView.PropertyID, BaseFilter.ComparisonOperator.EqualsTo, PropertyIDFilterSelectedValue, false, false);
                      
      }
                      
            if (MiscUtils.IsValueSelected(searchText) && fromSearchControl == "VPropertyContactsSearch") {
                String formatedSearchText = searchText;
                // strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                if (searchText.StartsWith("...")) {
                    formatedSearchText = searchText.Substring(3,searchText.Length-3);
                }
                if (searchText.EndsWith("...")) {
                    formatedSearchText = searchText.Substring(0,searchText.Length-3);
                }
                // After stripping "...", trim any leading and trailing whitespaces 
                formatedSearchText = formatedSearchText.Trim();
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(searchText)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                  
                    WhereClause search = new WhereClause();
                    
                    if (StringUtils.InvariantLCase(AutoTypeAheadSearch).Equals("wordsstartingwithsearchstring")) {
                
        ColumnList cols = new ColumnList();
      
      cols.Add(VPropertyContactsView.Title0, true);
      
      cols.Add(VPropertyContactsView.FirstName, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(VPropertyContactsView.Title0, true);
      
      cols.Add(VPropertyContactsView.FirstName, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, formatedSearchText, true, false);
      }
    
                    } 
                    wc.iAND(search);
                  
                }
            }
                  

            return wc;
        }

        
        public virtual string[] GetAutoCompletionList_VPropertyContactsSearch(String prefixText,int count)
        {
            ArrayList resultList = new ArrayList();
            ArrayList wordList= new ArrayList();
            
            CompoundFilter filterJoin = CreateCompoundJoinFilter();    
            WhereClause wc = CreateWhereClause(prefixText,"VPropertyContactsSearch", "WordsStartingWithSearchString", "[^a-zA-Z0-9]");
            if(count==0) count = 10;
            IPv5.Business.VPropertyContactsRecord[] recordList  = VPropertyContactsView.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (VPropertyContactsRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(VPropertyContactsView.Title0);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(VPropertyContactsView.Title0.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, VPropertyContactsView.Title0.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(VPropertyContactsView.FirstName);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(VPropertyContactsView.FirstName.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, VPropertyContactsView.FirstName.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
                      
            }
              
            resultList.Sort();
            string[] result = new string[resultList.Count];
            Array.Copy(resultList.ToArray(), result, resultList.Count);
            return result;
        }
          
          
         public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
            return this.FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText,
                                              autoTypeAheadSearch, AutoTypeAheadWordSeparators, resultList, false);
        }          
          
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList, bool stripHTML)
        {
            if (stripHTML){
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText);
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem);
            }
            // Formats the result Item and adds it to the list of suggestions.
            int index  = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = resultItem.Substring(index);
                        }
                    }
                    else {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward);
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    }
                    else {
                        // Sanity check at end of the string
                        if (((index + prefixText.Length) >= resultItem.Length - 1)||(resultItem.Length - index < subStringBeginIndex)) {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, resultItem.Length - 1 - columnLength, resultItem.Length - 1, StringUtils.Direction.backward);
                        }
                        else if (index <= subStringBeginIndex) {
                            // Sanity check at beginning of the string
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward);
                        } 
                        else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both);
                        }
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }
                    else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        itemToAdd = resultItem.Substring(0, index);
                    } 
                    else {
                        // Truncate the string to show only columnLength has to be appended.
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward);
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase);
                if(prefixTextIndex < 0) return false;
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {                   
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);                   
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                }

                if (!string.IsNullOrEmpty(itemToAdd) && !resultList.Contains(itemToAdd)) {
                    
                    resultList.Add(itemToAdd);
          								
                    isAdded = true;
                }
            }
            return isAdded;
        }        
        
    
        protected virtual void GetPageSize()
        {
        
            if (this.VPropertyContactsPagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.VPropertyContactsPagination.PageSize.Text);
                } catch (Exception ) {
                }
            }
        }

        protected virtual void AddNewRecords()
        {
          
            ArrayList newRecordList = new ArrayList();
          
            System.Collections.Generic.List<Hashtable> newUIDataList = new System.Collections.Generic.List<Hashtable>();
            // Loop though all the record controls and if the record control
            // does not have a unique record id set, then create a record
            // and add to the list.
            if (!this.ResetData)
            {
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyContactsTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                VPropertyContactsTableControlRow recControl = (VPropertyContactsTableControlRow)(repItem.FindControl("VPropertyContactsTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      VPropertyContactsRecord rec = new VPropertyContactsRecord();
        
                        if (recControl.Active.Text != "") {
                            rec.Parse(recControl.Active.Text, VPropertyContactsView.Active);
                  }
                
                        if (recControl.Address1.Text != "") {
                            rec.Parse(recControl.Address1.Text, VPropertyContactsView.Address1);
                  }
                
                        if (recControl.Address2.Text != "") {
                            rec.Parse(recControl.Address2.Text, VPropertyContactsView.Address2);
                  }
                
                        if (recControl.Address3.Text != "") {
                            rec.Parse(recControl.Address3.Text, VPropertyContactsView.Address3);
                  }
                
                        if (recControl.BankAccount.Text != "") {
                            rec.Parse(recControl.BankAccount.Text, VPropertyContactsView.BankAccount);
                  }
                
                        if (recControl.City.Text != "") {
                            rec.Parse(recControl.City.Text, VPropertyContactsView.City);
                  }
                
                        if (recControl.Country.Text != "") {
                            rec.Parse(recControl.Country.Text, VPropertyContactsView.Country);
                  }
                
                        if (recControl.eMail.Text != "") {
                            rec.Parse(recControl.eMail.Text, VPropertyContactsView.eMail);
                  }
                
                        if (recControl.FirstName.Text != "") {
                            rec.Parse(recControl.FirstName.Text, VPropertyContactsView.FirstName);
                  }
                
                        if (recControl.FirstName2.Text != "") {
                            rec.Parse(recControl.FirstName2.Text, VPropertyContactsView.FirstName2);
                  }
                
                        if (recControl.IrdNumber.Text != "") {
                            rec.Parse(recControl.IrdNumber.Text, VPropertyContactsView.IrdNumber);
                  }
                
                        if (recControl.LastName.Text != "") {
                            rec.Parse(recControl.LastName.Text, VPropertyContactsView.LastName);
                  }
                
                        if (recControl.LastName2.Text != "") {
                            rec.Parse(recControl.LastName2.Text, VPropertyContactsView.LastName2);
                  }
                
                        if (recControl.LinkID.Text != "") {
                            rec.Parse(recControl.LinkID.Text, VPropertyContactsView.LinkID);
                  }
                
                        if (recControl.PhoneNumber.Text != "") {
                            rec.Parse(recControl.PhoneNumber.Text, VPropertyContactsView.PhoneNumber);
                  }
                
                        if (recControl.PostCode.Text != "") {
                            rec.Parse(recControl.PostCode.Text, VPropertyContactsView.PostCode);
                  }
                
                        if (recControl.Region.Text != "") {
                            rec.Parse(recControl.Region.Text, VPropertyContactsView.Region);
                  }
                
                        if (recControl.Title.Text != "") {
                            rec.Parse(recControl.Title.Text, VPropertyContactsView.Title0);
                  }
                
                        if (recControl.TrustName.Text != "") {
                            rec.Parse(recControl.TrustName.Text, VPropertyContactsView.TrustName);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new VPropertyContactsRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(IPv5.Business.VPropertyContactsRecord);
                this.DataSource = (VPropertyContactsRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
      
        // Create Set, WhereClause, and Populate Methods
        
        public virtual void SetAddress1SortLabel()
                  {
                  
                    
        }
                
        public virtual void SetAddress2SortLabel()
                  {
                  
                    
        }
                
        public virtual void SetAddress3SortLabel()
                  {
                  
                    
        }
                
        public virtual void SetContactIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetFirstName2SortLabel()
                  {
                  
                    
        }
                
        public virtual void SetIrdNumberSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetLastName2SortLabel()
                  {
                  
                    
        }
                
        public virtual void SetLinkIDSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetPostCodeSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetPropertyIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetTitleSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetTrustNameSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetContactIDFilter()
        {
            
            this.PopulateContactIDFilter(MiscUtils.GetSelectedValue(this.ContactIDFilter,  GetFromSession(this.ContactIDFilter)), 500);					
                                     
        }
            
        public virtual void SetPropertyIDFilter()
        {
            
            this.PopulatePropertyIDFilter(MiscUtils.GetSelectedValue(this.PropertyIDFilter,  GetFromSession(this.PropertyIDFilter)), 500);					
                                     
        }
            
        public virtual void SetVPropertyContactsSearch()
        {
                                            
            this.VPropertyContactsSearch.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "') {this.value='';this.className='Search_Input';}");
            this.VPropertyContactsSearch.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "';this.className='Search_InputHint';}");
                                   
        }
            
        // Get the filters' data for ContactIDFilter.
                
        protected virtual void PopulateContactIDFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.ContactIDFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_ContactIDFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ContactIDFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.ContactIDFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "IPv5"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(ContactsTable.LastName, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "IPv5");

            ContactsRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = ContactsTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (ContactsRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.ContactIDSpecified) 
                        {
                            cvalue = itemValue.ContactID.ToString();
                            if (counter < maxItems && this.ContactIDFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = VPropertyContactsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyContactsView.ContactID);
                                if(_isExpandableNonCompositeForeignKey && VPropertyContactsView.ContactID.IsApplyDisplayAs)
                                     fvalue = VPropertyContactsView.GetDFKA(itemValue, VPropertyContactsView.ContactID);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(ContactsTable.LastName);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ContactIDFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ContactIDFilter.Items.Add(newItem);

                                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                                }

                                counter += 1;
                            }
                        }
                    }
                    pageNum++;
                }
                while (itemValues.Length == maxItems && counter < maxItems);
            }
        
                      
            try
            {
      
                
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.ContactIDFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.ContactIDFilter.SelectedValue != null && this.ContactIDFilter.Items.FindByValue(this.ContactIDFilter.SelectedValue) == null)
                this.ContactIDFilter.SelectedValue = null;
                           
        }
            
        // Get the filters' data for PropertyIDFilter.
                
        protected virtual void PopulatePropertyIDFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.PropertyIDFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_PropertyIDFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_PropertyIDFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.PropertyIDFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "IPv5"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(PropertiesTable.CompanyName, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "IPv5");

            PropertiesRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = PropertiesTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (PropertiesRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.PropertyIDSpecified) 
                        {
                            cvalue = itemValue.PropertyID.ToString();
                            if (counter < maxItems && this.PropertyIDFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = VPropertyContactsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyContactsView.PropertyID);
                                if(_isExpandableNonCompositeForeignKey && VPropertyContactsView.PropertyID.IsApplyDisplayAs)
                                     fvalue = VPropertyContactsView.GetDFKA(itemValue, VPropertyContactsView.PropertyID);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(PropertiesTable.CompanyName);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.PropertyIDFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.PropertyIDFilter.Items.Add(newItem);

                                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                                }

                                counter += 1;
                            }
                        }
                    }
                    pageNum++;
                }
                while (itemValues.Length == maxItems && counter < maxItems);
            }
        
                      
            try
            {
      
                
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.PropertyIDFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.PropertyIDFilter.SelectedValue != null && this.PropertyIDFilter.Items.FindByValue(this.PropertyIDFilter.SelectedValue) == null)
                this.PropertyIDFilter.SelectedValue = null;
                           
        }
            
        public virtual WhereClause CreateWhereClause_ContactIDFilter()
        {
            // Create a where clause for the filter ContactIDFilter.
            // This function is called by the Populate method to load the items 
            // in the ContactIDFilterDropDownList
        
            WhereClause wc = new WhereClause();
            return wc;
            
        }
      
        public virtual WhereClause CreateWhereClause_PropertyIDFilter()
        {
            // Create a where clause for the filter PropertyIDFilter.
            // This function is called by the Populate method to load the items 
            // in the PropertyIDFilterDropDownList
        
            WhereClause wc = new WhereClause();
            return wc;
            
        }
      

    
        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    
                    this.LoadData();
                    this.DataBind();					
                    
                }
                                
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
        
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
            // Save filter controls to values to session.
        
            this.SaveToSession(this.ContactIDFilter, this.ContactIDFilter.SelectedValue);
                  
            this.SaveToSession(this.PropertyIDFilter, this.PropertyIDFilter.SelectedValue);
                  
            this.SaveToSession(this.VPropertyContactsSearch, this.VPropertyContactsSearch.Text);
                  
            
                    
            // Save pagination state to session.
         
    
            // Save table control properties to the session.
          
            if (this.CurrentSortOrder != null)
            {
                if ((this.CurrentSortOrder).GetType() != typeof(GeoOrderBy))
                {
                    this.SaveToSession(this, "Order_By", this.CurrentSortOrder.ToXmlString());
                }
            }
          
            this.SaveToSession(this, "Page_Index", this.PageIndex.ToString());
            this.SaveToSession(this, "Page_Size", this.PageSize.ToString());
          
        }
        
        
        protected  void SaveControlsToSession_Ajax()
        {
            // Save filter controls to values to session.
          
      this.SaveToSession("ContactIDFilter_Ajax", this.ContactIDFilter.SelectedValue);
              
      this.SaveToSession("PropertyIDFilter_Ajax", this.PropertyIDFilter.SelectedValue);
              
      this.SaveToSession("VPropertyContactsSearch_Ajax", this.VPropertyContactsSearch.Text);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.ContactIDFilter);
            this.RemoveFromSession(this.PropertyIDFilter);
            this.RemoveFromSession(this.VPropertyContactsSearch);
            
            // Clear pagination state from session.
         

    // Clear table properties from the session.
    this.RemoveFromSession(this, "Order_By");
    this.RemoveFromSession(this, "Page_Index");
    this.RemoveFromSession(this, "Page_Size");
    
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["VPropertyContactsTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("VPropertyContactsPagination");
            String PaginationType = "";
            if (Pagination != null){
              Control Summary = Pagination.FindControl("_Summary");
              if (Summary != null){
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination"){
                  PaginationType = "Infinite Pagination";
                }
                if (((System.Web.UI.WebControls.TextBox)(Summary)).Text == "Infinite Pagination Mobile"){
                  PaginationType = "Infinite Pagination Mobile";
              }
            }
            }
            
            if (!(PaginationType.Equals("Infinite Pagination"))) {
              if (!this.Page.ClientQueryString.Contains("InfiIframe") && PaginationType == "Infinite Pagination Mobile"){
                    this.ViewState["Page_Index"] = 0;
               }
	            string pageIndex = Convert.ToString(ViewState["Page_Index"]);
	            if (pageIndex != null) {
		            this.PageIndex = Convert.ToInt32(pageIndex);
	            }
            }
            
            string pageSize = Convert.ToString(ViewState["Page_Size"]);
            if ((pageSize != null)) {
	            this.PageSize = Convert.ToInt32(pageSize);
            }
            
          
            // Load view state for pagination control.
    
        }

        protected override object SaveViewState()
        {            
          
            if (this.CurrentSortOrder != null) {
                this.ViewState["VPropertyContactsTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetVPropertyContactsExportExcelButton()                
              
        {
        
   
        }
            
        public virtual void SetVPropertyContactsPDFButton()                
              
        {
        
   
        }
            
        public virtual void SetVPropertyContactsResetButton()                
              
        {
        
   
        }
            
        public virtual void SetVPropertyContactsSearchButton()                
              
        {
        
   
        }
            
        public virtual void SetVPropertyContactsWordButton()                
              
        {
        
   
        }
            
        public virtual void SetVPropertyContactsButtonsButton()                
              
        {
        
   
        }
            
        public virtual void SetVPropertyContactsFilterButton()                
              
        {
        
   
        }
            
        public virtual void SetVPropertyContactsFiltersButton()                
              
        {
                
         IThemeButtonWithArrow themeButtonVPropertyContactsFiltersButton = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "VPropertyContactsFiltersButton"));
         themeButtonVPropertyContactsFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
            if (MiscUtils.IsValueSelected(ContactIDFilter))
                themeButtonVPropertyContactsFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(PropertyIDFilter))
                themeButtonVPropertyContactsFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
   
        }
               
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void VPropertyContactsPagination_FirstPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex = 0;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void VPropertyContactsPagination_LastPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.DisplayLastPage = true;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void VPropertyContactsPagination_NextPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.PageIndex += 1;
            this.DataChanged = true;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for LinkButton
        public virtual void VPropertyContactsPagination_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.VPropertyContactsPagination.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.VPropertyContactsPagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void VPropertyContactsPagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            if (this.PageIndex > 0) {
                this.PageIndex -= 1;
                this.DataChanged = true;
            }
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        

        // Generate the event handling functions for sorting events.
        
        public virtual void Address1SortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by Address1 when clicked.
              
            // Get previous sorting state for Address1.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyContactsView.Address1);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Address1.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyContactsView.Address1, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by Address1, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void Address2SortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by Address2 when clicked.
              
            // Get previous sorting state for Address2.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyContactsView.Address2);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Address2.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyContactsView.Address2, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by Address2, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void Address3SortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by Address3 when clicked.
              
            // Get previous sorting state for Address3.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyContactsView.Address3);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Address3.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyContactsView.Address3, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by Address3, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void FirstName2SortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by FirstName2 when clicked.
              
            // Get previous sorting state for FirstName2.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyContactsView.FirstName2);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for FirstName2.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyContactsView.FirstName2, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by FirstName2, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void IrdNumberSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by IrdNumber when clicked.
              
            // Get previous sorting state for IrdNumber.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyContactsView.IrdNumber);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for IrdNumber.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyContactsView.IrdNumber, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by IrdNumber, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void LastName2SortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by LastName2 when clicked.
              
            // Get previous sorting state for LastName2.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyContactsView.LastName2);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for LastName2.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyContactsView.LastName2, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by LastName2, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void LinkIDSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by LinkID when clicked.
              
            // Get previous sorting state for LinkID.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyContactsView.LinkID);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for LinkID.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyContactsView.LinkID, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by LinkID, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void PostCodeSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by PostCode when clicked.
              
            // Get previous sorting state for PostCode.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyContactsView.PostCode);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for PostCode.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyContactsView.PostCode, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by PostCode, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void TitleSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by Title when clicked.
              
            // Get previous sorting state for Title.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyContactsView.Title0);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Title.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyContactsView.Title0, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by Title, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void TrustNameSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by TrustName when clicked.
              
            // Get previous sorting state for TrustName.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyContactsView.TrustName);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for TrustName.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyContactsView.TrustName, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by TrustName, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void VPropertyContactsExportExcelButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            
            // To customize the columns or the format, override this function in Section 1 of the page
            // and modify it to your liking.
            // Build the where clause based on the current filter and search criteria
            // Create the Order By clause based on the user's current sorting preference.
            
                WhereClause wc = null;
                wc = CreateWhereClause();
                OrderBy orderBy = null;
              
                orderBy = CreateOrderBy();
              
              bool done = false;
              object val = "";
              CompoundFilter join = CreateCompoundJoinFilter();
              
              // Read pageSize records at a time and write out the Excel file.
              int totalRowsReturned = 0;


              this.TotalRecords = VPropertyContactsView.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             VPropertyContactsView.Title0,
             VPropertyContactsView.FirstName,
             VPropertyContactsView.LastName,
             VPropertyContactsView.Address1,
             VPropertyContactsView.Address2,
             VPropertyContactsView.Address3,
             VPropertyContactsView.PostCode,
             VPropertyContactsView.TrustName,
             VPropertyContactsView.eMail,
             VPropertyContactsView.IrdNumber,
             VPropertyContactsView.Active,
             VPropertyContactsView.PhoneNumber,
             VPropertyContactsView.FirstName2,
             VPropertyContactsView.LastName2,
             VPropertyContactsView.Region,
             VPropertyContactsView.City,
             VPropertyContactsView.Country,
             VPropertyContactsView.LinkID,
             VPropertyContactsView.BankAccount,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(VPropertyContactsView.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(VPropertyContactsView.Instance, wc, orderBy, columns,join);

                //  Read pageSize records at a time and write out the CSV file.
                while (!done)
                {
                ArrayList recList = dataForCSV.GetRows(exportData.pageSize);
                if (recList == null)
                break; //we are done

                totalRowsReturned = recList.Count;
                foreach (BaseRecord rec in recList)
                {
                foreach (BaseColumn col in dataForCSV.ColumnList)
                {
                if (col == null)
                continue;

                if (!dataForCSV.IncludeInExport(col))
                continue;

                val = rec.GetValue(col).ToString();
                exportData.WriteColumnData(val, dataForCSV.IsString(col));
                }
                exportData.WriteNewRow();
                }

                //  If we already are below the pageSize, then we are done.
                if (totalRowsReturned < exportData.pageSize)
                {
                done = true;
                }
                }
                exportData.FinishExport(this.Page.Response);
              
              }
              else
              {
              // Create an instance of the ExportDataToExcel class with the table class, where clause and order by.
              ExportDataToExcel excelReport = new ExportDataToExcel(VPropertyContactsView.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(VPropertyContactsView.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(VPropertyContactsView.Title0, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyContactsView.FirstName, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyContactsView.LastName, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyContactsView.Address1, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyContactsView.Address2, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyContactsView.Address3, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyContactsView.PostCode, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyContactsView.TrustName, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyContactsView.eMail, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyContactsView.IrdNumber, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyContactsView.Active, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyContactsView.PhoneNumber, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyContactsView.FirstName2, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyContactsView.LastName2, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyContactsView.Region, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyContactsView.City, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyContactsView.Country, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyContactsView.LinkID, "0"));
             data.ColumnList.Add(new ExcelColumn(VPropertyContactsView.BankAccount, "Default"));


              //  First write out the Column Headers
              foreach (ExcelColumn col in data.ColumnList)
              {
              width = excelReport.GetExcelCellWidth(col);
              if (data.IncludeInExport(col))
              {
              excelReport.AddColumnToExcelBook(columnCounter, col.ToString(), excelReport.GetExcelDataType(col), width, excelReport.GetDisplayFormat(col));
              columnCounter++;
              }
              }
              
              while (!done)
              {
              ArrayList recList = data.GetRows(excelReport.pageSize);

              if (recList == null)
              {
              break;
              }
              totalRowsReturned = recList.Count;

              foreach (BaseRecord rec in recList)
              {
              excelReport.AddRowToExcelBook();
              columnCounter = 0;
              foreach (ExcelColumn col in data.ColumnList)
              {
              if (!data.IncludeInExport(col))
              continue;

              Boolean _isExpandableNonCompositeForeignKey = col.DisplayColumn.TableDefinition.IsExpandableNonCompositeForeignKey(col.DisplayColumn);
              if (_isExpandableNonCompositeForeignKey && col.DisplayColumn.IsApplyDisplayAs)
              {
                val = VPropertyContactsView.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
                if (String.IsNullOrEmpty(val as string))
                {
                  val = rec.Format(col.DisplayColumn);
                }
              }
              else
                val = excelReport.GetValueForExcelExport(col, rec);
              
              excelReport.AddCellToExcelRow(columnCounter, excelReport.GetExcelDataType(col), val, col.DisplayFormat);

              columnCounter++;
              }
              }

              // If we already are below the pageSize, then we are done.
              if (totalRowsReturned < excelReport.pageSize)
              {
              done = true;
              }
              }
              excelReport.SaveExcelBook(this.Page.Response);
              }
            
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void VPropertyContactsPDFButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                PDFReport report = new PDFReport();

                report.SpecificReportFileName = Page.Server.MapPath("ShowVPropertyContactsTable.VPropertyContactsPDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "vPropertyContacts";
                // If ShowVPropertyContactsTable.VPropertyContactsPDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(VPropertyContactsView.Title0.Name, ReportEnum.Align.Left, "${Title0}", ReportEnum.Align.Left, 15);
                 report.AddColumn(VPropertyContactsView.FirstName.Name, ReportEnum.Align.Left, "${FirstName}", ReportEnum.Align.Left, 24);
                 report.AddColumn(VPropertyContactsView.LastName.Name, ReportEnum.Align.Left, "${LastName}", ReportEnum.Align.Left, 24);
                 report.AddColumn(VPropertyContactsView.Address1.Name, ReportEnum.Align.Left, "${Address1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyContactsView.Address2.Name, ReportEnum.Align.Left, "${Address2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyContactsView.Address3.Name, ReportEnum.Align.Left, "${Address3}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyContactsView.PostCode.Name, ReportEnum.Align.Left, "${PostCode}", ReportEnum.Align.Left, 24);
                 report.AddColumn(VPropertyContactsView.TrustName.Name, ReportEnum.Align.Left, "${TrustName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyContactsView.eMail.Name, ReportEnum.Align.Left, "${eMail}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyContactsView.IrdNumber.Name, ReportEnum.Align.Left, "${IrdNumber}", ReportEnum.Align.Left, 15);
                 report.AddColumn(VPropertyContactsView.Active.Name, ReportEnum.Align.Left, "${Active}", ReportEnum.Align.Left, 15);
                 report.AddColumn(VPropertyContactsView.PhoneNumber.Name, ReportEnum.Align.Left, "${PhoneNumber}", ReportEnum.Align.Left, 24);
                 report.AddColumn(VPropertyContactsView.FirstName2.Name, ReportEnum.Align.Left, "${FirstName2}", ReportEnum.Align.Left, 24);
                 report.AddColumn(VPropertyContactsView.LastName2.Name, ReportEnum.Align.Left, "${LastName2}", ReportEnum.Align.Left, 24);
                 report.AddColumn(VPropertyContactsView.Region.Name, ReportEnum.Align.Left, "${Region}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyContactsView.City.Name, ReportEnum.Align.Left, "${City}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyContactsView.Country.Name, ReportEnum.Align.Left, "${Country}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyContactsView.LinkID.Name, ReportEnum.Align.Right, "${LinkID}", ReportEnum.Align.Right, 15);
                 report.AddColumn(VPropertyContactsView.BankAccount.Name, ReportEnum.Align.Left, "${BankAccount}", ReportEnum.Align.Left, 15);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "IPv5");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = VPropertyContactsView.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = VPropertyContactsView.GetRecordCount(joinFilter,whereClause);
                VPropertyContactsRecord[] records = null;
                
                do
                {
                    
                    records = VPropertyContactsView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( VPropertyContactsRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 report.AddData("${Title0}", record.Format(VPropertyContactsView.Title0), ReportEnum.Align.Left, 100);
                             report.AddData("${FirstName}", record.Format(VPropertyContactsView.FirstName), ReportEnum.Align.Left, 100);
                             report.AddData("${LastName}", record.Format(VPropertyContactsView.LastName), ReportEnum.Align.Left, 100);
                             report.AddData("${Address1}", record.Format(VPropertyContactsView.Address1), ReportEnum.Align.Left, 100);
                             report.AddData("${Address2}", record.Format(VPropertyContactsView.Address2), ReportEnum.Align.Left, 100);
                             report.AddData("${Address3}", record.Format(VPropertyContactsView.Address3), ReportEnum.Align.Left, 100);
                             report.AddData("${PostCode}", record.Format(VPropertyContactsView.PostCode), ReportEnum.Align.Left, 100);
                             report.AddData("${TrustName}", record.Format(VPropertyContactsView.TrustName), ReportEnum.Align.Left, 100);
                             report.AddData("${eMail}", record.Format(VPropertyContactsView.eMail), ReportEnum.Align.Left, 100);
                             report.AddData("${IrdNumber}", record.Format(VPropertyContactsView.IrdNumber), ReportEnum.Align.Left, 100);
                             report.AddData("${Active}", record.Format(VPropertyContactsView.Active), ReportEnum.Align.Left, 100);
                             report.AddData("${PhoneNumber}", record.Format(VPropertyContactsView.PhoneNumber), ReportEnum.Align.Left, 100);
                             report.AddData("${FirstName2}", record.Format(VPropertyContactsView.FirstName2), ReportEnum.Align.Left, 100);
                             report.AddData("${LastName2}", record.Format(VPropertyContactsView.LastName2), ReportEnum.Align.Left, 100);
                             report.AddData("${Region}", record.Format(VPropertyContactsView.Region), ReportEnum.Align.Left, 100);
                             report.AddData("${City}", record.Format(VPropertyContactsView.City), ReportEnum.Align.Left, 100);
                             report.AddData("${Country}", record.Format(VPropertyContactsView.Country), ReportEnum.Align.Left, 100);
                             report.AddData("${LinkID}", record.Format(VPropertyContactsView.LinkID), ReportEnum.Align.Right, 100);
                             report.AddData("${BankAccount}", record.Format(VPropertyContactsView.BankAccount), ReportEnum.Align.Left, 100);

                            report.WriteRow();
                        }
                        pageNum++;
                        recordCount += records.Length;
                    }
                }
                while (records != null && recordCount < totalRows && whereClause.RunQuery);
                	
                
                report.Close();
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(this.Page.Response, report.Title + ".pdf", report.ReportInByteArray, 0, true);
            
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void VPropertyContactsResetButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
              this.ContactIDFilter.ClearSelection();
            
              this.PropertyIDFilter.ClearSelection();
            
              this.VPropertyContactsSearch.Text = "";
            
              this.CurrentSortOrder.Reset();
              if (this.InSession(this, "Order_By"))
                  this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
              else
              {
                  this.CurrentSortOrder = new OrderBy(true, false);
                  
              }
                

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
                
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void VPropertyContactsSearchButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
          
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void VPropertyContactsWordButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("ShowVPropertyContactsTable.VPropertyContactsWordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "vPropertyContacts";
                // If ShowVPropertyContactsTable.VPropertyContactsWordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(VPropertyContactsView.Title0.Name, ReportEnum.Align.Left, "${Title0}", ReportEnum.Align.Left, 15);
                 report.AddColumn(VPropertyContactsView.FirstName.Name, ReportEnum.Align.Left, "${FirstName}", ReportEnum.Align.Left, 24);
                 report.AddColumn(VPropertyContactsView.LastName.Name, ReportEnum.Align.Left, "${LastName}", ReportEnum.Align.Left, 24);
                 report.AddColumn(VPropertyContactsView.Address1.Name, ReportEnum.Align.Left, "${Address1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyContactsView.Address2.Name, ReportEnum.Align.Left, "${Address2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyContactsView.Address3.Name, ReportEnum.Align.Left, "${Address3}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyContactsView.PostCode.Name, ReportEnum.Align.Left, "${PostCode}", ReportEnum.Align.Left, 24);
                 report.AddColumn(VPropertyContactsView.TrustName.Name, ReportEnum.Align.Left, "${TrustName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyContactsView.eMail.Name, ReportEnum.Align.Left, "${eMail}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyContactsView.IrdNumber.Name, ReportEnum.Align.Left, "${IrdNumber}", ReportEnum.Align.Left, 15);
                 report.AddColumn(VPropertyContactsView.Active.Name, ReportEnum.Align.Left, "${Active}", ReportEnum.Align.Left, 15);
                 report.AddColumn(VPropertyContactsView.PhoneNumber.Name, ReportEnum.Align.Left, "${PhoneNumber}", ReportEnum.Align.Left, 24);
                 report.AddColumn(VPropertyContactsView.FirstName2.Name, ReportEnum.Align.Left, "${FirstName2}", ReportEnum.Align.Left, 24);
                 report.AddColumn(VPropertyContactsView.LastName2.Name, ReportEnum.Align.Left, "${LastName2}", ReportEnum.Align.Left, 24);
                 report.AddColumn(VPropertyContactsView.Region.Name, ReportEnum.Align.Left, "${Region}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyContactsView.City.Name, ReportEnum.Align.Left, "${City}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyContactsView.Country.Name, ReportEnum.Align.Left, "${Country}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyContactsView.LinkID.Name, ReportEnum.Align.Right, "${LinkID}", ReportEnum.Align.Right, 15);
                 report.AddColumn(VPropertyContactsView.BankAccount.Name, ReportEnum.Align.Left, "${BankAccount}", ReportEnum.Align.Left, 15);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = VPropertyContactsView.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "IPv5");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = VPropertyContactsView.GetColumnList();
                VPropertyContactsRecord[] records = null;
                do
                {
                    records = VPropertyContactsView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( VPropertyContactsRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             report.AddData("${Title0}", record.Format(VPropertyContactsView.Title0), ReportEnum.Align.Left, 100);
                             report.AddData("${FirstName}", record.Format(VPropertyContactsView.FirstName), ReportEnum.Align.Left, 100);
                             report.AddData("${LastName}", record.Format(VPropertyContactsView.LastName), ReportEnum.Align.Left, 100);
                             report.AddData("${Address1}", record.Format(VPropertyContactsView.Address1), ReportEnum.Align.Left, 100);
                             report.AddData("${Address2}", record.Format(VPropertyContactsView.Address2), ReportEnum.Align.Left, 100);
                             report.AddData("${Address3}", record.Format(VPropertyContactsView.Address3), ReportEnum.Align.Left, 100);
                             report.AddData("${PostCode}", record.Format(VPropertyContactsView.PostCode), ReportEnum.Align.Left, 100);
                             report.AddData("${TrustName}", record.Format(VPropertyContactsView.TrustName), ReportEnum.Align.Left, 100);
                             report.AddData("${eMail}", record.Format(VPropertyContactsView.eMail), ReportEnum.Align.Left, 100);
                             report.AddData("${IrdNumber}", record.Format(VPropertyContactsView.IrdNumber), ReportEnum.Align.Left, 100);
                             report.AddData("${Active}", record.Format(VPropertyContactsView.Active), ReportEnum.Align.Left, 100);
                             report.AddData("${PhoneNumber}", record.Format(VPropertyContactsView.PhoneNumber), ReportEnum.Align.Left, 100);
                             report.AddData("${FirstName2}", record.Format(VPropertyContactsView.FirstName2), ReportEnum.Align.Left, 100);
                             report.AddData("${LastName2}", record.Format(VPropertyContactsView.LastName2), ReportEnum.Align.Left, 100);
                             report.AddData("${Region}", record.Format(VPropertyContactsView.Region), ReportEnum.Align.Left, 100);
                             report.AddData("${City}", record.Format(VPropertyContactsView.City), ReportEnum.Align.Left, 100);
                             report.AddData("${Country}", record.Format(VPropertyContactsView.Country), ReportEnum.Align.Left, 100);
                             report.AddData("${LinkID}", record.Format(VPropertyContactsView.LinkID), ReportEnum.Align.Right, 100);
                             report.AddData("${BankAccount}", record.Format(VPropertyContactsView.BankAccount), ReportEnum.Align.Left, 100);

                            report.WriteRow();
                        }
                        pageNum++;
                        recordCount += records.Length;
                    }
                }
                while (records != null && recordCount < totalRows && whereClause.RunQuery);
                report.save();
                BaseClasses.Utils.NetUtils.WriteResponseBinaryAttachment(this.Page.Response, report.Title + ".doc", report.ReportInByteArray, 0, true);
          
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void VPropertyContactsButtonsButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            //This method is initially empty to implement custom click handler.
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void VPropertyContactsFilterButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
          
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for Button
        public virtual void VPropertyContactsFiltersButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            //This method is initially empty to implement custom click handler.
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        


        // Generate the event handling functions for filter and search events.
        
        // event handler for FieldFilter
        protected virtual void ContactIDFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void PropertyIDFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = VPropertyContactsView.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
                }
                return (this._TotalRecords);
            }
            set {
                if (this.PageSize > 0) {
                  
                      this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
                          
                }
                this._TotalRecords = value;
            }
        }

      
      
        protected int _TotalPages = -1;
        public int TotalPages {
            get {
                if (_TotalPages < 0) 
                
                    this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalRecords) / Convert.ToDouble(this.PageSize)));
                  
                return this._TotalPages;
            }
            set {
                this._TotalPages = value;
            }
        }

        protected bool _DisplayLastPage;
        public bool DisplayLastPage {
            get {
                return this._DisplayLastPage;
            }
            set {
                this._DisplayLastPage = value;
            }
        }


        
        private OrderBy _CurrentSortOrder = null;
        public OrderBy CurrentSortOrder {
            get {
                return this._CurrentSortOrder;
            }
            set {
                this._CurrentSortOrder = value;
            }
        }
        
        public  VPropertyContactsRecord[] DataSource {
             
            get {
                return (VPropertyContactsRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public System.Web.UI.WebControls.LinkButton Address1SortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address1SortLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton Address2SortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address2SortLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton Address3SortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address3SortLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList ContactIDFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactIDFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal ContactIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton FirstName2SortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirstName2SortLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton IrdNumberSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IrdNumberSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton LastName2SortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastName2SortLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton LinkIDSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LinkIDSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton PostCodeSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PostCodeSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList PropertyIDFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyIDFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal PropertyIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton TitleSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TitleSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton TrustNameSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TrustNameSortLabel");
            }
        }
        
        public IPv5.UI.IThemeButtonWithArrow VPropertyContactsButtonsButton {
            get {
                return (IPv5.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyContactsButtonsButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton VPropertyContactsExportExcelButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyContactsExportExcelButton");
            }
        }
        
        public IPv5.UI.IThemeButton VPropertyContactsFilterButton {
            get {
                return (IPv5.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyContactsFilterButton");
            }
        }
        
        public IPv5.UI.IThemeButtonWithArrow VPropertyContactsFiltersButton {
            get {
                return (IPv5.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyContactsFiltersButton");
            }
        }
        
        public IPv5.UI.IPaginationModern VPropertyContactsPagination {
            get {
                return (IPv5.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyContactsPagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton VPropertyContactsPDFButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyContactsPDFButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton VPropertyContactsResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyContactsResetButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VPropertyContactsSearch {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyContactsSearch");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton VPropertyContactsSearchButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyContactsSearchButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal VPropertyContactsTitle {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyContactsTitle");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton VPropertyContactsWordButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyContactsWordButton");
            }
        }
        
#endregion

#region "Helper Functions"
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
        {
            return EvaluateExpressions(url, arg, null, bEncrypt);
        }
        
        public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
        {
            return EvaluateExpressions(url, arg, null, bEncrypt,includeSession);
        }
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
        {
            return EvaluateExpressions(url, arg, null, bEncrypt);
        }
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
        {
            return EvaluateExpressions(url, arg, null, bEncrypt);
        }
          
        public virtual VPropertyContactsTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual VPropertyContactsTableControlRow[] GetSelectedRecordControls()
        {
        
            return (VPropertyContactsTableControlRow[])((new ArrayList()).ToArray(Type.GetType("IPv5.UI.Controls.ShowVPropertyContactsTable.VPropertyContactsTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            VPropertyContactsTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IPv5"));
            }
            
            foreach (VPropertyContactsTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        // Localization.
                        throw new Exception(Page.GetResourceValue("Err:CannotDelRecs", "IPv5"));
                  
                    }
                    recCtl.Visible = false;
                
                } else {
                
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:CannotDelRecs", "IPv5"));
                  
                }
            }
        }

        public virtual VPropertyContactsTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "VPropertyContactsTableControlRow");
	          List<VPropertyContactsTableControlRow> list = new List<VPropertyContactsTableControlRow>();
	          foreach (VPropertyContactsTableControlRow recCtrl in recCtrls) {
		          list.Add(recCtrl);
	          }
	          return list.ToArray();
        }

        public new BaseApplicationPage Page 
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }
        
                

        
        
#endregion


    }
  
// Base class for the ContactsRecordControl control on the ShowVPropertyContactsTable page.
// Do not modify this class. Instead override any method in ContactsRecordControl.
public class BaseContactsRecordControl : IPv5.UI.BaseApplicationRecordControl
{
        public BaseContactsRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in ContactsRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in ContactsRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseMM_IP1%dbo.Contacts record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "ContactsRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new ContactsRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            ContactsRecord[] recList = ContactsTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = ContactsTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
        }

        public override void DataBind()
        {
            // The DataBind method binds the user interface controls to the values
            // from the database record.  To do this, it calls the Set methods for 
            // each of the field displayed on the webpage.  It is better to make 
            // changes in the Set methods, rather than making changes here.
            
            base.DataBind();
            
            this.ClearControlsFromSession();
            
            // Make sure that the DataSource is initialized.
            
            if (this.DataSource == null) {
             //This is to make sure all the controls will be invisible if no record is present in the cell
             
                return;
            }
              
            // LoadData for DataSource for chart and report if they exist
          
            // Store the checksum. The checksum is used to
            // ensure the record was not changed by another user.
            if (this.DataSource.GetCheckSumValue() != null)
                this.CheckSum = this.DataSource.GetCheckSumValue().Value;
            

            // Call the Set methods for each controls on the panel
        
                SetActive1();
                SetActiveLabel1();
                SetAddress12();
                SetAddress1Label2();
                SetAddress22();
                SetAddress2Label2();
                SetAddress32();
                SetAddress3Label2();
                SetBankAccount1();
                SetBankAccountLabel1();
                SeteMail1();
                SeteMailLabel1();
                SetFirstName1();
                SetFirstName21();
                SetFirstName2Label1();
                SetFirstNameLabel1();
                SetIrdNumber1();
                SetIrdNumberLabel1();
                SetLastName1();
                SetLastName21();
                SetLastName2Label1();
                SetLastNameLabel1();
                SetPhoneNumber1();
                SetPhoneNumberLabel1();
                SetPostCode2();
                SetPostCodeLabel2();
                SetTitle1();
                SetTitleLabel1();
                SetTrustName1();
                SetTrustNameLabel1();

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
                if (this.DataSource.GetID() != null)
                    this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
              
            }
            

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
            
        }
        
        
        public virtual void SetActive1()
        {
            
                    
            // Set the Active Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contacts record retrieved from the database.
            // this.Active1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ActiveSpecified) {
                								
                // If the Active is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContactsTable.Active);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Active1.Text = formattedValue;
                   
            } 
            
            else {
            
                // Active is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Active1.Text = ContactsTable.Active.Format(ContactsTable.Active.DefaultValue);
            		
            }
            
            // If the Active is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Active1.Text == null ||
                this.Active1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Active1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAddress12()
        {
            
                    
            // Set the Address1 Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contacts record retrieved from the database.
            // this.Address12 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address1Specified) {
                								
                // If the Address1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContactsTable.Address1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address12.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address12.Text = ContactsTable.Address1.Format(ContactsTable.Address1.DefaultValue);
            		
            }
            
            // If the Address1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Address12.Text == null ||
                this.Address12.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Address12.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAddress22()
        {
            
                    
            // Set the Address2 Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contacts record retrieved from the database.
            // this.Address22 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address2Specified) {
                								
                // If the Address2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContactsTable.Address2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address22.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address22.Text = ContactsTable.Address2.Format(ContactsTable.Address2.DefaultValue);
            		
            }
            
            // If the Address2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Address22.Text == null ||
                this.Address22.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Address22.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAddress32()
        {
            
                    
            // Set the Address3 Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contacts record retrieved from the database.
            // this.Address32 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address3Specified) {
                								
                // If the Address3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContactsTable.Address3);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address32.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address32.Text = ContactsTable.Address3.Format(ContactsTable.Address3.DefaultValue);
            		
            }
            
            // If the Address3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Address32.Text == null ||
                this.Address32.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Address32.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetBankAccount1()
        {
            
                    
            // Set the BankAccount Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contacts record retrieved from the database.
            // this.BankAccount1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.BankAccountSpecified) {
                								
                // If the BankAccount is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContactsTable.BankAccount);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.BankAccount1.Text = formattedValue;
                   
            } 
            
            else {
            
                // BankAccount is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.BankAccount1.Text = ContactsTable.BankAccount.Format(ContactsTable.BankAccount.DefaultValue);
            		
            }
            
            // If the BankAccount is NULL or blank, then use the value specified  
            // on Properties.
            if (this.BankAccount1.Text == null ||
                this.BankAccount1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.BankAccount1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SeteMail1()
        {
            
                    
            // Set the eMail Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contacts record retrieved from the database.
            // this.eMail1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.eMailSpecified) {
                								
                // If the eMail is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContactsTable.eMail);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.eMail1.Text = formattedValue;
                   
            } 
            
            else {
            
                // eMail is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.eMail1.Text = ContactsTable.eMail.Format(ContactsTable.eMail.DefaultValue);
            		
            }
            
            // If the eMail is NULL or blank, then use the value specified  
            // on Properties.
            if (this.eMail1.Text == null ||
                this.eMail1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.eMail1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetFirstName1()
        {
            
                    
            // Set the FirstName Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contacts record retrieved from the database.
            // this.FirstName1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FirstNameSpecified) {
                								
                // If the FirstName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContactsTable.FirstName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.FirstName1.Text = formattedValue;
                   
            } 
            
            else {
            
                // FirstName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FirstName1.Text = ContactsTable.FirstName.Format(ContactsTable.FirstName.DefaultValue);
            		
            }
            
            // If the FirstName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.FirstName1.Text == null ||
                this.FirstName1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.FirstName1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetFirstName21()
        {
            
                    
            // Set the FirstName2 Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contacts record retrieved from the database.
            // this.FirstName21 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FirstName2Specified) {
                								
                // If the FirstName2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContactsTable.FirstName2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.FirstName21.Text = formattedValue;
                   
            } 
            
            else {
            
                // FirstName2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FirstName21.Text = ContactsTable.FirstName2.Format(ContactsTable.FirstName2.DefaultValue);
            		
            }
            
            // If the FirstName2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.FirstName21.Text == null ||
                this.FirstName21.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.FirstName21.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetIrdNumber1()
        {
            
                    
            // Set the IrdNumber Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contacts record retrieved from the database.
            // this.IrdNumber1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.IrdNumberSpecified) {
                								
                // If the IrdNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContactsTable.IrdNumber);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.IrdNumber1.Text = formattedValue;
                   
            } 
            
            else {
            
                // IrdNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.IrdNumber1.Text = ContactsTable.IrdNumber.Format(ContactsTable.IrdNumber.DefaultValue);
            		
            }
            
            // If the IrdNumber is NULL or blank, then use the value specified  
            // on Properties.
            if (this.IrdNumber1.Text == null ||
                this.IrdNumber1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.IrdNumber1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLastName1()
        {
            
                    
            // Set the LastName Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contacts record retrieved from the database.
            // this.LastName1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LastNameSpecified) {
                								
                // If the LastName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContactsTable.LastName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LastName1.Text = formattedValue;
                   
            } 
            
            else {
            
                // LastName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LastName1.Text = ContactsTable.LastName.Format(ContactsTable.LastName.DefaultValue);
            		
            }
            
            // If the LastName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LastName1.Text == null ||
                this.LastName1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LastName1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLastName21()
        {
            
                    
            // Set the LastName2 Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contacts record retrieved from the database.
            // this.LastName21 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LastName2Specified) {
                								
                // If the LastName2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContactsTable.LastName2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LastName21.Text = formattedValue;
                   
            } 
            
            else {
            
                // LastName2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LastName21.Text = ContactsTable.LastName2.Format(ContactsTable.LastName2.DefaultValue);
            		
            }
            
            // If the LastName2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LastName21.Text == null ||
                this.LastName21.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LastName21.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPhoneNumber1()
        {
            
                    
            // Set the PhoneNumber Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contacts record retrieved from the database.
            // this.PhoneNumber1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PhoneNumberSpecified) {
                								
                // If the PhoneNumber is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContactsTable.PhoneNumber);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PhoneNumber1.Text = formattedValue;
                   
            } 
            
            else {
            
                // PhoneNumber is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PhoneNumber1.Text = ContactsTable.PhoneNumber.Format(ContactsTable.PhoneNumber.DefaultValue);
            		
            }
            
            // If the PhoneNumber is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PhoneNumber1.Text == null ||
                this.PhoneNumber1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PhoneNumber1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPostCode2()
        {
            
                    
            // Set the PostCode Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contacts record retrieved from the database.
            // this.PostCode2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PostCodeSpecified) {
                								
                // If the PostCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContactsTable.PostCode);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PostCode2.Text = formattedValue;
                   
            } 
            
            else {
            
                // PostCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PostCode2.Text = ContactsTable.PostCode.Format(ContactsTable.PostCode.DefaultValue);
            		
            }
            
            // If the PostCode is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PostCode2.Text == null ||
                this.PostCode2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PostCode2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTitle1()
        {
            
                    
            // Set the Title Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contacts record retrieved from the database.
            // this.Title1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Title0Specified) {
                								
                // If the Title is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContactsTable.Title0);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Title1.Text = formattedValue;
                   
            } 
            
            else {
            
                // Title is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Title1.Text = ContactsTable.Title0.Format(ContactsTable.Title0.DefaultValue);
            		
            }
            
            // If the Title is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Title1.Text == null ||
                this.Title1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Title1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTrustName1()
        {
            
                    
            // Set the TrustName Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contacts record retrieved from the database.
            // this.TrustName1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TrustNameSpecified) {
                								
                // If the TrustName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContactsTable.TrustName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TrustName1.Text = formattedValue;
                   
            } 
            
            else {
            
                // TrustName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TrustName1.Text = ContactsTable.TrustName.Format(ContactsTable.TrustName.DefaultValue);
            		
            }
            
            // If the TrustName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TrustName1.Text == null ||
                this.TrustName1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TrustName1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetActiveLabel1()
                  {
                  
                    
        }
                
        public virtual void SetAddress1Label2()
                  {
                  
                    
        }
                
        public virtual void SetAddress2Label2()
                  {
                  
                    
        }
                
        public virtual void SetAddress3Label2()
                  {
                  
                    
        }
                
        public virtual void SetBankAccountLabel1()
                  {
                  
                    
        }
                
        public virtual void SeteMailLabel1()
                  {
                  
                    
        }
                
        public virtual void SetFirstName2Label1()
                  {
                  
                    
        }
                
        public virtual void SetFirstNameLabel1()
                  {
                  
                    
        }
                
        public virtual void SetIrdNumberLabel1()
                  {
                  
                    
        }
                
        public virtual void SetLastName2Label1()
                  {
                  
                    
        }
                
        public virtual void SetLastNameLabel1()
                  {
                  
                    
        }
                
        public virtual void SetPhoneNumberLabel1()
                  {
                  
                    
        }
                
        public virtual void SetPostCodeLabel2()
                  {
                  
                    
        }
                
        public virtual void SetTitleLabel1()
                  {
                  
                    
        }
                
        public virtual void SetTrustNameLabel1()
                  {
                  
                    
        }
                
        public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
        {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();
            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            
            
            if (includeDS)
            {
                
            }
            
            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            if (dataSourceForEvaluate == null)
                e.DataSource = this.DataSource;
            else
                e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
                
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
        
      
        public virtual void ResetControl()
        {
          
        }
        

        public virtual void RegisterPostback()
        {
            
        }
    
        

        public virtual void SaveData()
        {
            // Saves the associated record in the database.
            // SaveData calls Validate and Get methods - so it may be more appropriate to
            // customize those methods.

            // 1. Load the existing record from the database. Since we save the entire record, this ensures 
            // that fields that are not displayed are also properly initialized.
            this.LoadData();
        
            // The checksum is used to ensure the record was not changed by another user.
            if (this.DataSource != null && this.DataSource.GetCheckSumValue() != null) {
                if (this.CheckSum != null && this.CheckSum != this.DataSource.GetCheckSumValue().Value) {
                    throw new Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "IPv5"));
                }
            }
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "ContactsRecordControlPanel");
            if ( (Panel != null && !Panel.Visible) || this.DataSource == null){
                return;
            }
          VPropertyContactsTableControlRow parentCtrl;
      
            parentCtrl = (VPropertyContactsTableControlRow)MiscUtils.GetParentControlObject(this, "VPropertyContactsTableControlRow");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "IPv5"));
        }
        
          
            // 2. Perform any custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.
            // This calls the Get() method for each of the user interface controls.
            this.GetUIData();
   
            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit yet.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
                
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
            this.CheckSum = "";
            // For Master-Detail relationships, save data on the Detail table(s)            
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetActive1();
            GetAddress12();
            GetAddress22();
            GetAddress32();
            GetBankAccount1();
            GeteMail1();
            GetFirstName1();
            GetFirstName21();
            GetIrdNumber1();
            GetLastName1();
            GetLastName21();
            GetPhoneNumber1();
            GetPostCode2();
            GetTitle1();
            GetTrustName1();
        }
        
        
        public virtual void GetActive1()
        {
            
        }
                
        public virtual void GetAddress12()
        {
            
        }
                
        public virtual void GetAddress22()
        {
            
        }
                
        public virtual void GetAddress32()
        {
            
        }
                
        public virtual void GetBankAccount1()
        {
            
        }
                
        public virtual void GeteMail1()
        {
            
        }
                
        public virtual void GetFirstName1()
        {
            
        }
                
        public virtual void GetFirstName21()
        {
            
        }
                
        public virtual void GetIrdNumber1()
        {
            
        }
                
        public virtual void GetLastName1()
        {
            
        }
                
        public virtual void GetLastName21()
        {
            
        }
                
        public virtual void GetPhoneNumber1()
        {
            
        }
                
        public virtual void GetPostCode2()
        {
            
        }
                
        public virtual void GetTitle1()
        {
            
        }
                
        public virtual void GetTrustName1()
        {
            
        }
                

      // To customize, override this method in ContactsRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersContactsRecordControl = false;
            hasFiltersContactsRecordControl = hasFiltersContactsRecordControl && false; // suppress warning
      
            bool hasFiltersPropertiesRecordControl = false;
            hasFiltersPropertiesRecordControl = hasFiltersPropertiesRecordControl && false; // suppress warning
      
            bool hasFiltersVPropertyContactsTableControl = false;
            hasFiltersVPropertyContactsTableControl = hasFiltersVPropertyContactsTableControl && false; // suppress warning
      
            WhereClause wc;
            ContactsTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
      KeyValue selectedRecordKeyValue = new KeyValue();
    
          KeyValue vPropertyContactsRecordObj = null;
          // make variable assignment here to avoid possible incorrect compiler warning
          KeyValue tmp = vPropertyContactsRecordObj;
          vPropertyContactsRecordObj = tmp;
        VPropertyContactsTableControlRow vPropertyContactsTableControlObjRow = (MiscUtils.GetParentControlObject(this, "VPropertyContactsTableControlRow") as VPropertyContactsTableControlRow);
          
              if (vPropertyContactsTableControlObjRow != null && vPropertyContactsTableControlObjRow.GetRecord() != null)
              {
              wc.iAND(ContactsTable.ContactID, BaseFilter.ComparisonOperator.EqualsTo, vPropertyContactsTableControlObjRow.GetRecord().ContactID.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["ContactsRecordControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
    
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            ContactsTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersContactsRecordControl = false;
            hasFiltersContactsRecordControl = hasFiltersContactsRecordControl && false; // suppress warning
      
            bool hasFiltersPropertiesRecordControl = false;
            hasFiltersPropertiesRecordControl = hasFiltersPropertiesRecordControl && false; // suppress warning
      
            bool hasFiltersVPropertyContactsTableControl = false;
            hasFiltersVPropertyContactsTableControl = hasFiltersVPropertyContactsTableControl && false; // suppress warning
      
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInVPropertyContactsTableControl = HttpContext.Current.Session["ContactsRecordControlWhereClause"] as string;
      
      if (selectedRecordInVPropertyContactsTableControl != null && KeyValue.IsXmlKey(selectedRecordInVPropertyContactsTableControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInVPropertyContactsTableControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(ContactsTable.ContactID))
      {
      wc.iAND(ContactsTable.ContactID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(ContactsTable.ContactID).ToString());
      }
    
      }
    
            // Adds clauses if values are selected in Filter controls which are configured in the page.
                
            return wc;
        }

        
        
         public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
            return this.FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText,
                                              autoTypeAheadSearch, AutoTypeAheadWordSeparators, resultList, false);
        }                                              
        
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList, bool stripHTML)
        {
            if (stripHTML){
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText);
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem);
            }
            // Formats the result Item and adds it to the list of suggestions.
            int index  = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = resultItem.Substring(index);
                        }
                    }
                    else {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward);
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    }
                    else {
                        // Sanity check at end of the string
                        if (((index + prefixText.Length) >= resultItem.Length - 1)||(resultItem.Length - index < subStringBeginIndex)) {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, resultItem.Length - 1 - columnLength, resultItem.Length - 1, StringUtils.Direction.backward);
                        }
                        else if (index <= subStringBeginIndex) {
                            // Sanity check at beginning of the string
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward);
                        } 
                        else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both);
                        }
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }
                    else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        itemToAdd = resultItem.Substring(0, index);
                    } 
                    else {
                        // Truncate the string to show only columnLength has to be appended.
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward);
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase);
                if(prefixTextIndex < 0) return false;
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {                   
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);                   
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                }

                if (!string.IsNullOrEmpty(itemToAdd) && !resultList.Contains(itemToAdd)) {
                    resultList.Add(itemToAdd);
                    isAdded = true;
                }
            }
            return isAdded;
        }
        
    
        public virtual void Validate()
        {
            // Add custom validation for any control within this panel.
            // Example.  If you have a State ASP:Textbox control
            // if (this.State.Text != "CA")
            //    throw new Exception("State must be CA (California).");
            // The Validate method is common across all controls within
            // this panel so you can validate multiple fields, but report
            // one error message.
            
            
            
        }

        public virtual void Delete()
        {
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pkValue = KeyValue.XmlToKey(this.RecordUniqueId);
          ContactsTable.DeleteRecord(pkValue);
          
        }

        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    this.LoadData();
                    this.DataBind();
                }
                				
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
        
    
            // Save pagination state to session.
          
        }
        
        
    
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

        

            // Clear pagination state from session.
        
        }
        
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
        
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        
    
            // Load view state for pagination control.
                 
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
        

            // Load view state for pagination control.
               
            return base.SaveViewState();
        }

        
        // Generate the event handling functions for pagination events.
            
      
        // Generate the event handling functions for filter and search events.
            
    
        // Generate set method for buttons
        
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseContactsRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseContactsRecordControl_Rec"] = value;
            }
        }
        
        public ContactsRecord DataSource {
            get {
                return (ContactsRecord)(this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }
        

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }
    
        private int _TotalPages;
        public virtual int TotalPages {
            get {
                return (this._TotalPages);
            }
            set {
                this._TotalPages = value;
            }
        }
        
        private int _PageIndex;
        public virtual int PageIndex {
            get {
                return (this._PageIndex);
            }
            set {
                this._PageIndex = value;
            }
        }
        
        private int _PageSize;
        public int PageSize {
          get {
            return this._PageSize;
          }
          set {
            this._PageSize = value;
          }
        }
      
        private int _TotalRecords;
        public int TotalRecords {
          get {
            return (this._TotalRecords);
          }
          set {
            if (this.PageSize > 0) {
              this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
            }
            this._TotalRecords = value;
          }
        }
        
        private bool _DisplayLastPage;
        public virtual bool DisplayLastPage {
            get {
                return (this._DisplayLastPage);
            }
            set {
                this._DisplayLastPage = value;
            }
        }
        
        
    
        private KeyValue selectedParentKeyValue;
        public KeyValue SelectedParentKeyValue
        {
            get
            {
                return this.selectedParentKeyValue;
            }
            set
            {
                this.selectedParentKeyValue = value;
            }
        }
       
#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal Active1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Active1");
            }
        }
            
        public System.Web.UI.WebControls.Literal ActiveLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ActiveLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal Address12 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address12");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address1Label2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address1Label2");
            }
        }
        
        public System.Web.UI.WebControls.Literal Address22 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address22");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address2Label2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address2Label2");
            }
        }
        
        public System.Web.UI.WebControls.Literal Address32 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address32");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address3Label2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address3Label2");
            }
        }
        
        public System.Web.UI.WebControls.Literal BankAccount1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BankAccount1");
            }
        }
            
        public System.Web.UI.WebControls.Literal BankAccountLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "BankAccountLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal eMail1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "eMail1");
            }
        }
            
        public System.Web.UI.WebControls.Literal eMailLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "eMailLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal FirstName1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirstName1");
            }
        }
            
        public System.Web.UI.WebControls.Literal FirstName21 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirstName21");
            }
        }
            
        public System.Web.UI.WebControls.Literal FirstName2Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirstName2Label1");
            }
        }
        
        public System.Web.UI.WebControls.Literal FirstNameLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirstNameLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal IrdNumber1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IrdNumber1");
            }
        }
            
        public System.Web.UI.WebControls.Literal IrdNumberLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "IrdNumberLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal LastName1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastName1");
            }
        }
            
        public System.Web.UI.WebControls.Literal LastName21 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastName21");
            }
        }
            
        public System.Web.UI.WebControls.Literal LastName2Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastName2Label1");
            }
        }
        
        public System.Web.UI.WebControls.Literal LastNameLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastNameLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal PhoneNumber1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PhoneNumber1");
            }
        }
            
        public System.Web.UI.WebControls.Literal PhoneNumberLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PhoneNumberLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal PostCode2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PostCode2");
            }
        }
            
        public System.Web.UI.WebControls.Literal PostCodeLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PostCodeLabel2");
            }
        }
        
        public System.Web.UI.WebControls.Literal Title1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title1");
            }
        }
            
        public System.Web.UI.WebControls.Literal TitleLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TitleLabel1");
            }
        }
        
        public System.Web.UI.WebControls.Literal TrustName1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TrustName1");
            }
        }
            
        public System.Web.UI.WebControls.Literal TrustNameLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TrustNameLabel1");
            }
        }
        
    #endregion

    #region "Helper Functions"
    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
    }

    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
    }

    public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
    {
        ContactsRecord rec = null;
             
            try {
                rec = this.GetRecord();
            }
            catch (Exception ) {
                // Do Nothing
            }
            
            if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                
                throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IPv5"));
                    
            }
        
            return EvaluateExpressions(url, arg, rec, bEncrypt);
        
    }


    public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
    {
    ContactsRecord rec = null;
    
          try {
               rec = this.GetRecord();
          }
          catch (Exception ) {
          // Do Nothing
          }

          if (rec == null && url.IndexOf("{") >= 0) {
          // Localization.
    
              throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IPv5"));
      
          }
    
          if (includeSession)
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt);
          }
          else
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt,includeSession);
          }
    
    }

        
        public virtual ContactsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return ContactsTable.GetRecord(this.RecordUniqueId, true);
              
            }
            
            // Localization.
            
            return null;
                
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  
// Base class for the PropertiesRecordControl control on the ShowVPropertyContactsTable page.
// Do not modify this class. Instead override any method in PropertiesRecordControl.
public class BasePropertiesRecordControl : IPv5.UI.BaseApplicationRecordControl
{
        public BasePropertiesRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in PropertiesRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in PropertiesRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseMM_IP1%dbo.Properties record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "PropertiesRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new PropertiesRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            PropertiesRecord[] recList = PropertiesTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = PropertiesTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
        }

        public override void DataBind()
        {
            // The DataBind method binds the user interface controls to the values
            // from the database record.  To do this, it calls the Set methods for 
            // each of the field displayed on the webpage.  It is better to make 
            // changes in the Set methods, rather than making changes here.
            
            base.DataBind();
            
            this.ClearControlsFromSession();
            
            // Make sure that the DataSource is initialized.
            
            if (this.DataSource == null) {
             //This is to make sure all the controls will be invisible if no record is present in the cell
             
                return;
            }
              
            // LoadData for DataSource for chart and report if they exist
          
            // Store the checksum. The checksum is used to
            // ensure the record was not changed by another user.
            if (this.DataSource.GetCheckSumValue() != null)
                this.CheckSum = this.DataSource.GetCheckSumValue().Value;
            

            // Call the Set methods for each controls on the panel
        
                SetAddress11();
                SetAddress1Label1();
                SetAddress21();
                SetAddress2Label1();
                SetAddress31();
                SetAddress3Label1();
                SetCompanyName();
                SetCompanyNameLabel();
                SetPostCode1();
                SetPostCodeLabel1();

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
                if (this.DataSource.GetID() != null)
                    this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
              
            }
            

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
            
        }
        
        
        public virtual void SetAddress11()
        {
            
                    
            // Set the Address1 Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Properties database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Properties record retrieved from the database.
            // this.Address11 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address1Specified) {
                								
                // If the Address1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(PropertiesTable.Address1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address11.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address11.Text = PropertiesTable.Address1.Format(PropertiesTable.Address1.DefaultValue);
            		
            }
            
            // If the Address1 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Address11.Text == null ||
                this.Address11.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Address11.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAddress21()
        {
            
                    
            // Set the Address2 Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Properties database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Properties record retrieved from the database.
            // this.Address21 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address2Specified) {
                								
                // If the Address2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(PropertiesTable.Address2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address21.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address21.Text = PropertiesTable.Address2.Format(PropertiesTable.Address2.DefaultValue);
            		
            }
            
            // If the Address2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Address21.Text == null ||
                this.Address21.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Address21.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAddress31()
        {
            
                    
            // Set the Address3 Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Properties database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Properties record retrieved from the database.
            // this.Address31 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address3Specified) {
                								
                // If the Address3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(PropertiesTable.Address3);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address31.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address31.Text = PropertiesTable.Address3.Format(PropertiesTable.Address3.DefaultValue);
            		
            }
            
            // If the Address3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Address31.Text == null ||
                this.Address31.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Address31.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCompanyName()
        {
            
                    
            // Set the CompanyName Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Properties database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Properties record retrieved from the database.
            // this.CompanyName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CompanyNameSpecified) {
                								
                // If the CompanyName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(PropertiesTable.CompanyName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CompanyName.Text = formattedValue;
                   
            } 
            
            else {
            
                // CompanyName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CompanyName.Text = PropertiesTable.CompanyName.Format(PropertiesTable.CompanyName.DefaultValue);
            		
            }
            
            // If the CompanyName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CompanyName.Text == null ||
                this.CompanyName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CompanyName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPostCode1()
        {
            
                    
            // Set the PostCode Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Properties database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Properties record retrieved from the database.
            // this.PostCode1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PostCodeSpecified) {
                								
                // If the PostCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(PropertiesTable.PostCode);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PostCode1.Text = formattedValue;
                   
            } 
            
            else {
            
                // PostCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PostCode1.Text = PropertiesTable.PostCode.Format(PropertiesTable.PostCode.DefaultValue);
            		
            }
            
            // If the PostCode is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PostCode1.Text == null ||
                this.PostCode1.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PostCode1.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAddress1Label1()
                  {
                  
                    
        }
                
        public virtual void SetAddress2Label1()
                  {
                  
                    
        }
                
        public virtual void SetAddress3Label1()
                  {
                  
                    
        }
                
        public virtual void SetCompanyNameLabel()
                  {
                  
                    
        }
                
        public virtual void SetPostCodeLabel1()
                  {
                  
                    
        }
                
        public BaseClasses.Data.DataSource.EvaluateFormulaDelegate EvaluateFormulaDelegate;

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS, FormulaEvaluator e)
        {
            if (e == null)
                e = new FormulaEvaluator();

            e.Variables.Clear();
            // add variables for formula evaluation
            if (variables != null)
            {
                System.Collections.Generic.IEnumerator<System.Collections.Generic.KeyValuePair<string, object>> enumerator = variables.GetEnumerator();
                while (enumerator.MoveNext())
                {
                    e.Variables.Add(enumerator.Current.Key, enumerator.Current.Value);
                }
            }
            
            
            if (includeDS)
            {
                
            }
            
            // All variables referred to in the formula are expected to be
            // properties of the DataSource.  For example, referring to
            // UnitPrice as a variable will refer to DataSource.UnitPrice
            if (dataSourceForEvaluate == null)
                e.DataSource = this.DataSource;
            else
                e.DataSource = dataSourceForEvaluate;

            // Define the calling control.  This is used to add other 
            // related table and record controls as variables.
            e.CallingControl = this;

            object resultObj = e.Evaluate(formula);
            if (resultObj == null)
                return "";
            
            if ( !string.IsNullOrEmpty(format) && (string.IsNullOrEmpty(formula) || formula.IndexOf("Format(") < 0) )
                return FormulaUtils.Format(resultObj, format);
            else
                return resultObj.ToString();
        }
                
        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables, bool includeDS)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, System.Collections.Generic.IDictionary<string, object> variables)
        {
          return EvaluateFormula(formula, dataSourceForEvaluate, format, variables, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, format, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, System.Collections.Generic.IDictionary<string, object> variables, FormulaEvaluator e)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, variables, true, e);
        }

        public virtual string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate)
        {
          return this.EvaluateFormula(formula, dataSourceForEvaluate, null, null, true, null);
        }

        public virtual string EvaluateFormula(string formula, bool includeDS)
        {
          return this.EvaluateFormula(formula, null, null, null, includeDS, null);
        }

        public virtual string EvaluateFormula(string formula)
        {
          return this.EvaluateFormula(formula, null, null, null, true, null);
        }
        
      
        public virtual void ResetControl()
        {
          
        }
        

        public virtual void RegisterPostback()
        {
            
        }
    
        

        public virtual void SaveData()
        {
            // Saves the associated record in the database.
            // SaveData calls Validate and Get methods - so it may be more appropriate to
            // customize those methods.

            // 1. Load the existing record from the database. Since we save the entire record, this ensures 
            // that fields that are not displayed are also properly initialized.
            this.LoadData();
        
            // The checksum is used to ensure the record was not changed by another user.
            if (this.DataSource != null && this.DataSource.GetCheckSumValue() != null) {
                if (this.CheckSum != null && this.CheckSum != this.DataSource.GetCheckSumValue().Value) {
                    throw new Exception(Page.GetResourceValue("Err:RecChangedByOtherUser", "IPv5"));
                }
            }
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "PropertiesRecordControlPanel");
            if ( (Panel != null && !Panel.Visible) || this.DataSource == null){
                return;
            }
          VPropertyContactsTableControlRow parentCtrl;
      
            parentCtrl = (VPropertyContactsTableControlRow)MiscUtils.GetParentControlObject(this, "VPropertyContactsTableControlRow");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "IPv5"));
        }
        
          
            // 2. Perform any custom validation.
            this.Validate();

            // 3. Set the values in the record with data from UI controls.
            // This calls the Get() method for each of the user interface controls.
            this.GetUIData();
   
            // 4. Save in the database.
            // We should not save the record if the data did not change. This
            // will save a database hit and avoid triggering any database triggers.
            
            if (this.DataSource.IsAnyValueChanged) {
                // Save record to database but do not commit yet.
                // Auto generated ids are available after saving for use by child (dependent) records.
                this.DataSource.Save();
                
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
            this.CheckSum = "";
            // For Master-Detail relationships, save data on the Detail table(s)            
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetAddress11();
            GetAddress21();
            GetAddress31();
            GetCompanyName();
            GetPostCode1();
        }
        
        
        public virtual void GetAddress11()
        {
            
        }
                
        public virtual void GetAddress21()
        {
            
        }
                
        public virtual void GetAddress31()
        {
            
        }
                
        public virtual void GetCompanyName()
        {
            
        }
                
        public virtual void GetPostCode1()
        {
            
        }
                

      // To customize, override this method in PropertiesRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersContactsRecordControl = false;
            hasFiltersContactsRecordControl = hasFiltersContactsRecordControl && false; // suppress warning
      
            bool hasFiltersPropertiesRecordControl = false;
            hasFiltersPropertiesRecordControl = hasFiltersPropertiesRecordControl && false; // suppress warning
      
            bool hasFiltersVPropertyContactsTableControl = false;
            hasFiltersVPropertyContactsTableControl = hasFiltersVPropertyContactsTableControl && false; // suppress warning
      
            WhereClause wc;
            PropertiesTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
      KeyValue selectedRecordKeyValue = new KeyValue();
    
          KeyValue vPropertyContactsRecordObj = null;
          // make variable assignment here to avoid possible incorrect compiler warning
          KeyValue tmp = vPropertyContactsRecordObj;
          vPropertyContactsRecordObj = tmp;
        VPropertyContactsTableControlRow vPropertyContactsTableControlObjRow = (MiscUtils.GetParentControlObject(this, "VPropertyContactsTableControlRow") as VPropertyContactsTableControlRow);
          
              if (vPropertyContactsTableControlObjRow != null && vPropertyContactsTableControlObjRow.GetRecord() != null)
              {
              wc.iAND(PropertiesTable.PropertyID, BaseFilter.ComparisonOperator.EqualsTo, vPropertyContactsTableControlObjRow.GetRecord().PropertyID.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["PropertiesRecordControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
    
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            PropertiesTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersContactsRecordControl = false;
            hasFiltersContactsRecordControl = hasFiltersContactsRecordControl && false; // suppress warning
      
            bool hasFiltersPropertiesRecordControl = false;
            hasFiltersPropertiesRecordControl = hasFiltersPropertiesRecordControl && false; // suppress warning
      
            bool hasFiltersVPropertyContactsTableControl = false;
            hasFiltersVPropertyContactsTableControl = hasFiltersVPropertyContactsTableControl && false; // suppress warning
      
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInVPropertyContactsTableControl = HttpContext.Current.Session["PropertiesRecordControlWhereClause"] as string;
      
      if (selectedRecordInVPropertyContactsTableControl != null && KeyValue.IsXmlKey(selectedRecordInVPropertyContactsTableControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInVPropertyContactsTableControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(PropertiesTable.PropertyID))
      {
      wc.iAND(PropertiesTable.PropertyID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(PropertiesTable.PropertyID).ToString());
      }
    
      }
    
            // Adds clauses if values are selected in Filter controls which are configured in the page.
                
            return wc;
        }

        
        
         public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList)
        {
            return this.FormatSuggestions(prefixText, resultItem, columnLength, AutoTypeAheadDisplayFoundText,
                                              autoTypeAheadSearch, AutoTypeAheadWordSeparators, resultList, false);
        }                                              
        
        public virtual bool FormatSuggestions(String prefixText, String resultItem,
                                              int columnLength, String AutoTypeAheadDisplayFoundText,
                                              String autoTypeAheadSearch, String AutoTypeAheadWordSeparators,
                                              ArrayList resultList, bool stripHTML)
        {
            if (stripHTML){
                prefixText = StringUtils.ConvertHTMLToPlainText(prefixText);
                resultItem = StringUtils.ConvertHTMLToPlainText(resultItem);
            }
            // Formats the result Item and adds it to the list of suggestions.
            int index  = resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).IndexOf(prefixText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture));
            String itemToAdd = null;
            bool isFound = false;
            bool isAdded = false;
            if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("wordsstartingwithsearchstring") && !(index == 0)) {
                // Expression to find word which contains AutoTypeAheadWordSeparators followed by prefixText
                System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex( AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                if (regex1.IsMatch(resultItem)) {
                    index = regex1.Match(resultItem).Index;
                    isFound = true;
                }
                //If the prefixText is found immediatly after white space then starting of the word is found so don not search any further
                if (resultItem[index].ToString() != " ") {
                    // Expression to find beginning of the word which contains AutoTypeAheadWordSeparators followed by prefixText
                    System.Text.RegularExpressions.Regex regex = new System.Text.RegularExpressions.Regex("\\S*" + AutoTypeAheadWordSeparators + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    if (regex.IsMatch(resultItem)) {
                        index = regex.Match(resultItem).Index;
                        isFound = true;
                    }
                }
            }
            // If autoTypeAheadSearch value is wordsstartingwithsearchstring then, extract the substring only if the prefixText is found at the 
            // beginning of the resultItem (index = 0) or a word in resultItem is found starts with prefixText. 
            if (index == 0 || isFound || StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring")) {
                if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atbeginningofmatchedstring")) {
                    // Expression to find beginning of the word which contains prefixText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\S*" + prefixText, System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                    //  Find the beginning of the word which contains prefexText
                    if (StringUtils.InvariantLCase(autoTypeAheadSearch).Equals("anywhereinstring") && regex1.IsMatch(resultItem)) {
                        index = regex1.Match(resultItem).Index;
                        isFound = true;
                    }
                    // Display string from the index till end of the string if, sub string from index till end of string is less than columnLength value.
                    if ((resultItem.Length - index) <= columnLength) {
                        if (index == 0) {
                            itemToAdd = resultItem;
                        } else {
                            itemToAdd = resultItem.Substring(index);
                        }
                    }
                    else {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index, index + columnLength, StringUtils.Direction.forward);
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("inmiddleofmatchedstring")) {
                    int subStringBeginIndex = (int)(columnLength / 2);
                    if (resultItem.Length <= columnLength) {
                        itemToAdd = resultItem;
                    }
                    else {
                        // Sanity check at end of the string
                        if (((index + prefixText.Length) >= resultItem.Length - 1)||(resultItem.Length - index < subStringBeginIndex)) {
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, resultItem.Length - 1 - columnLength, resultItem.Length - 1, StringUtils.Direction.backward);
                        }
                        else if (index <= subStringBeginIndex) {
                            // Sanity check at beginning of the string
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, 0, columnLength, StringUtils.Direction.forward);
                        } 
                        else {
                            // Display string containing text before the prefixText occures and text after the prefixText
                            itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - subStringBeginIndex, index - subStringBeginIndex + columnLength, StringUtils.Direction.both);
                        }
                    }
                }
                else if (StringUtils.InvariantLCase(AutoTypeAheadDisplayFoundText).Equals("atendofmatchedstring")) {
                     // Expression to find ending of the word which contains prefexText
                    System.Text.RegularExpressions.Regex regex1 = new System.Text.RegularExpressions.Regex("\\s", System.Text.RegularExpressions.RegexOptions.IgnoreCase); 
                    // Find the ending of the word which contains prefexText
                    if (regex1.IsMatch(resultItem, index + 1)) {
                        index = regex1.Match(resultItem, index + 1).Index;
                    }
                    else{
                        // If the word which contains prefexText is the last word in string, regex1.IsMatch returns false.
                        index = resultItem.Length;
                    }
                    
                    if (index > resultItem.Length) {
                        index = resultItem.Length;
                    }
                    // If text from beginning of the string till index is less than columnLength value then, display string from the beginning till index.
                    if (index <= columnLength) {
                        itemToAdd = resultItem.Substring(0, index);
                    } 
                    else {
                        // Truncate the string to show only columnLength has to be appended.
                        itemToAdd = StringUtils.GetSubstringWithWholeWords(resultItem, index - columnLength, index, StringUtils.Direction.backward);
                    }
                }
                
                // Remove newline character from itemToAdd
                int prefixTextIndex = itemToAdd.IndexOf(prefixText, StringComparison.CurrentCultureIgnoreCase);
                if(prefixTextIndex < 0) return false;
                // If itemToAdd contains any newline after the search text then show text only till newline
                System.Text.RegularExpressions.Regex regex2 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase);
                int newLineIndexAfterPrefix = -1;
                if (regex2.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexAfterPrefix = regex2.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexAfterPrefix > -1)) {                   
                    itemToAdd = itemToAdd.Substring(0, newLineIndexAfterPrefix);                   
                }
                // If itemToAdd contains any newline before search text then show text which comes after newline
                System.Text.RegularExpressions.Regex regex3 = new System.Text.RegularExpressions.Regex("(\r\n|\n)", System.Text.RegularExpressions.RegexOptions.IgnoreCase | System.Text.RegularExpressions.RegexOptions.RightToLeft );
                int newLineIndexBeforePrefix = -1;
                if (regex3.IsMatch(itemToAdd, prefixTextIndex)){
                    newLineIndexBeforePrefix = regex3.Match(itemToAdd, prefixTextIndex).Index;
                }
                if ((newLineIndexBeforePrefix > -1)) {
                    itemToAdd = itemToAdd.Substring(newLineIndexBeforePrefix +regex3.Match(itemToAdd, prefixTextIndex).Length);
                }

                if (!string.IsNullOrEmpty(itemToAdd) && !resultList.Contains(itemToAdd)) {
                    resultList.Add(itemToAdd);
                    isAdded = true;
                }
            }
            return isAdded;
        }
        
    
        public virtual void Validate()
        {
            // Add custom validation for any control within this panel.
            // Example.  If you have a State ASP:Textbox control
            // if (this.State.Text != "CA")
            //    throw new Exception("State must be CA (California).");
            // The Validate method is common across all controls within
            // this panel so you can validate multiple fields, but report
            // one error message.
            
            
            
        }

        public virtual void Delete()
        {
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pkValue = KeyValue.XmlToKey(this.RecordUniqueId);
          PropertiesTable.DeleteRecord(pkValue);
          
        }

        protected virtual void Control_PreRender(object sender, System.EventArgs e)
        {
            // PreRender event is raised just before page is being displayed.
            try {
                DbUtils.StartTransaction();
                this.RegisterPostback();
                if (!this.Page.ErrorOnPage && (this.Page.IsPageRefresh || this.DataChanged || this.ResetData)) {
                  
                
                    // Re-load the data and update the web page if necessary.
                    // This is typically done during a postback (filter, search button, sort, pagination button).
                    // In each of the other click handlers, simply set DataChanged to True to reload the data.
                    this.LoadData();
                    this.DataBind();
                }
                				
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            
        protected override void SaveControlsToSession()
        {
            base.SaveControlsToSession();
        
    
            // Save pagination state to session.
          
        }
        
        
    
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();

        

            // Clear pagination state from session.
        
        }
        
        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);
            string isNewRecord = (string)ViewState["IsNewRecord"];
            if (isNewRecord != null && isNewRecord.Length > 0) {
                this.IsNewRecord = Boolean.Parse(isNewRecord);
            }
        
            string myCheckSum = (string)ViewState["CheckSum"];
            if (myCheckSum != null && myCheckSum.Length > 0) {
                this.CheckSum = myCheckSum;
            }
        
    
            // Load view state for pagination control.
                 
        }

        protected override object SaveViewState()
        {
            ViewState["IsNewRecord"] = this.IsNewRecord.ToString();
            ViewState["CheckSum"] = this.CheckSum;
        

            // Load view state for pagination control.
               
            return base.SaveViewState();
        }

        
        // Generate the event handling functions for pagination events.
            
      
        // Generate the event handling functions for filter and search events.
            
    
        // Generate set method for buttons
        
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BasePropertiesRecordControl_Rec"];
            }
            set {
                this.ViewState["BasePropertiesRecordControl_Rec"] = value;
            }
        }
        
        public PropertiesRecord DataSource {
            get {
                return (PropertiesRecord)(this._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }
        

        private string _checkSum;
        public virtual string CheckSum {
            get {
                return (this._checkSum);
            }
            set {
                this._checkSum = value;
            }
        }
    
        private int _TotalPages;
        public virtual int TotalPages {
            get {
                return (this._TotalPages);
            }
            set {
                this._TotalPages = value;
            }
        }
        
        private int _PageIndex;
        public virtual int PageIndex {
            get {
                return (this._PageIndex);
            }
            set {
                this._PageIndex = value;
            }
        }
        
        private int _PageSize;
        public int PageSize {
          get {
            return this._PageSize;
          }
          set {
            this._PageSize = value;
          }
        }
      
        private int _TotalRecords;
        public int TotalRecords {
          get {
            return (this._TotalRecords);
          }
          set {
            if (this.PageSize > 0) {
              this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / Convert.ToDouble(this.PageSize)));
            }
            this._TotalRecords = value;
          }
        }
        
        private bool _DisplayLastPage;
        public virtual bool DisplayLastPage {
            get {
                return (this._DisplayLastPage);
            }
            set {
                this._DisplayLastPage = value;
            }
        }
        
        
    
        private KeyValue selectedParentKeyValue;
        public KeyValue SelectedParentKeyValue
        {
            get
            {
                return this.selectedParentKeyValue;
            }
            set
            {
                this.selectedParentKeyValue = value;
            }
        }
       
#region "Helper Properties"
        
        public System.Web.UI.WebControls.Literal Address11 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address11");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address1Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address1Label1");
            }
        }
        
        public System.Web.UI.WebControls.Literal Address21 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address21");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address2Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address2Label1");
            }
        }
        
        public System.Web.UI.WebControls.Literal Address31 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address31");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address3Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address3Label1");
            }
        }
        
        public System.Web.UI.WebControls.Literal CompanyName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CompanyName");
            }
        }
            
        public System.Web.UI.WebControls.Literal CompanyNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CompanyNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal PostCode1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PostCode1");
            }
        }
            
        public System.Web.UI.WebControls.Literal PostCodeLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PostCodeLabel1");
            }
        }
        
    #endregion

    #region "Helper Functions"
    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this);
    }

    public override string ModifyRedirectUrl(string url, string arg, bool bEncrypt,bool includeSession)
    {
        return this.Page.EvaluateExpressions(url, arg, bEncrypt, this,includeSession);
    }

    public override string EvaluateExpressions(string url, string arg, bool bEncrypt)
    {
        PropertiesRecord rec = null;
             
            try {
                rec = this.GetRecord();
            }
            catch (Exception ) {
                // Do Nothing
            }
            
            if (rec == null && url.IndexOf("{") >= 0) {
                // Localization.
                
                throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IPv5"));
                    
            }
        
            return EvaluateExpressions(url, arg, rec, bEncrypt);
        
    }


    public override string EvaluateExpressions(string url, string arg, bool bEncrypt,bool includeSession)
    {
    PropertiesRecord rec = null;
    
          try {
               rec = this.GetRecord();
          }
          catch (Exception ) {
          // Do Nothing
          }

          if (rec == null && url.IndexOf("{") >= 0) {
          // Localization.
    
              throw new Exception(Page.GetResourceValue("Err:RecDataSrcNotInitialized", "IPv5"));
      
          }
    
          if (includeSession)
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt);
          }
          else
          {
              return EvaluateExpressions(url, arg, rec, bEncrypt,includeSession);
          }
    
    }

        
        public virtual PropertiesRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return PropertiesTable.GetRecord(this.RecordUniqueId, true);
              
            }
            
            // Localization.
            
            return null;
                
        }

        public new BaseApplicationPage Page
        {
            get {
                return ((BaseApplicationPage)base.Page);
            }
        }

#endregion

}

  

#endregion
    
  
}

  