﻿
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// ShowServiceTypes.aspx page.  The Row or RecordControl classes are the 
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

  
namespace IPv5.UI.Controls.ShowServiceTypes
{
  

#region "Section 1: Place your customizations here."

    
public class SuppliersTableControlRow : BaseSuppliersTableControlRow
{
      
        // The BaseSuppliersTableControlRow implements code for a ROW within the
        // the SuppliersTableControl table.  The BaseSuppliersTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of SuppliersTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class SuppliersTableControl : BaseSuppliersTableControl
{
    // The BaseSuppliersTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The SuppliersTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  
public class ServiceTypesRecordControl : BaseServiceTypesRecordControl
{
      
        // The BaseServiceTypesRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the SuppliersTableControlRow control on the ShowServiceTypes page.
// Do not modify this class. Instead override any method in SuppliersTableControlRow.
public class BaseSuppliersTableControlRow : IPv5.UI.BaseApplicationRecordControl
{
        public BaseSuppliersTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in SuppliersTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in SuppliersTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.SuppliersRowDeleteButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "IPv5") + "\"));");            
        
              // Register the event handlers.

          
                    this.SuppliersRowDeleteButton.Click += SuppliersRowDeleteButton_Click;
                        
                    this.SuppliersRowEditButton.Click += SuppliersRowEditButton_Click;
                        
                    this.CityID.Click += CityID_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseMM_IP1%dbo.Suppliers record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = SuppliersTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseSuppliersTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new SuppliersRecord();
            
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
        
                SetAddress1();
                SetAddress1Label();
                SetAddress2();
                SetAddress2Label();
                SetCellPhone();
                SetCellPhoneLabel();
                SetCityID();
                SetCompanyName();
                SetContactName();
                SetContactNameLabel();
                SeteMail();
                SeteMailLabel();
                SetLandPhone();
                SetLandPhoneLabel();
                SetPostCode();
                SetPostCodeLabel();
                
                
                SetSuppliersRowDeleteButton();
              
                SetSuppliersRowEditButton();
              

      

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
        
        
        public virtual void SetAddress1()
        {
            
                    
            // Set the Address1 Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Suppliers database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Suppliers record retrieved from the database.
            // this.Address1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address1Specified) {
                								
                // If the Address1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(SuppliersTable.Address1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address1.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address1.Text = SuppliersTable.Address1.Format(SuppliersTable.Address1.DefaultValue);
            		
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
            // DatabaseMM_IP1%dbo.Suppliers database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Suppliers record retrieved from the database.
            // this.Address2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address2Specified) {
                								
                // If the Address2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(SuppliersTable.Address2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address2.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address2.Text = SuppliersTable.Address2.Format(SuppliersTable.Address2.DefaultValue);
            		
            }
            
            // If the Address2 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Address2.Text == null ||
                this.Address2.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Address2.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCellPhone()
        {
            
                    
            // Set the CellPhone Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Suppliers database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Suppliers record retrieved from the database.
            // this.CellPhone is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CellPhoneSpecified) {
                								
                // If the CellPhone is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(SuppliersTable.CellPhone);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CellPhone.Text = formattedValue;
                   
            } 
            
            else {
            
                // CellPhone is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CellPhone.Text = SuppliersTable.CellPhone.Format(SuppliersTable.CellPhone.DefaultValue);
            		
            }
            
            // If the CellPhone is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CellPhone.Text == null ||
                this.CellPhone.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CellPhone.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCityID()
        {
            
                    
            // Set the CityID LinkButton on the webpage with value from the
            // DatabaseMM_IP1%dbo.Suppliers database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Suppliers record retrieved from the database.
            // this.CityID is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CityIDSpecified) {
                								
                // If the CityID is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = SuppliersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(SuppliersTable.CityID);
               if(_isExpandableNonCompositeForeignKey &&SuppliersTable.CityID.IsApplyDisplayAs)
                                  
                     formattedValue = SuppliersTable.GetDFKA(this.DataSource.CityID.ToString(),SuppliersTable.CityID, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(SuppliersTable.CityID);
                                  
                                
                this.CityID.Text = formattedValue;
                
                  this.CityID.ToolTip = "Go to " + this.CityID.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // CityID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CityID.Text = SuppliersTable.CityID.Format(SuppliersTable.CityID.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetCompanyName()
        {
            
                    
            // Set the CompanyName Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Suppliers database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Suppliers record retrieved from the database.
            // this.CompanyName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CompanyNameSpecified) {
                								
                // If the CompanyName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(SuppliersTable.CompanyName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if(formattedValue != null){
                    int popupThreshold = (int)(100);
                              
                    int maxLength = formattedValue.Length;
                    int originalLength = maxLength;
                    if (maxLength >= (int)(100)){
                        // Truncate based on FieldMaxLength on Properties.
                        maxLength = (int)(100);
                        //First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue);
                        
                    }
                                
                              
                    // For fields values larger than the PopupTheshold on Properties, display a popup.
                    if (originalLength >= popupThreshold) {
                        String name = HttpUtility.HtmlEncode(SuppliersTable.CompanyName.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"IPv5.Business.SuppliersTable, IPv5.Business\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"CompanyName\\\", \\\"CompanyName\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "IPv5") + "\\\", " +
                        " false, 200," +
                            " 300, true, PopupDisplayWindowCallBackWith20);\", 500);'>" + NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, formattedValue.Length)));
                        if (maxLength == (int)(100))
                            {
                            formattedValue = formattedValue + "..." + "</a>";
                        }
                        else
                        {
                            formattedValue = formattedValue + "</a>";
                            
                        }
                    }
                    else{
                        if (maxLength == (int)(100)) {
                          formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,Math.Min(maxLength, formattedValue.Length)));
                          formattedValue = formattedValue + "...";
                        }
                        
                    }
                }
                
                this.CompanyName.Text = formattedValue;
                   
            } 
            
            else {
            
                // CompanyName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CompanyName.Text = SuppliersTable.CompanyName.Format(SuppliersTable.CompanyName.DefaultValue);
            		
            }
            
            // If the CompanyName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CompanyName.Text == null ||
                this.CompanyName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CompanyName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetContactName()
        {
            
                    
            // Set the ContactName Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Suppliers database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Suppliers record retrieved from the database.
            // this.ContactName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ContactNameSpecified) {
                								
                // If the ContactName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(SuppliersTable.ContactName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ContactName.Text = formattedValue;
                   
            } 
            
            else {
            
                // ContactName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ContactName.Text = SuppliersTable.ContactName.Format(SuppliersTable.ContactName.DefaultValue);
            		
            }
            
            // If the ContactName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ContactName.Text == null ||
                this.ContactName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ContactName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SeteMail()
        {
            
                    
            // Set the eMail Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Suppliers database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Suppliers record retrieved from the database.
            // this.eMail is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.eMailSpecified) {
                								
                // If the eMail is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(SuppliersTable.eMail);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.eMail.Text = formattedValue;
                   
            } 
            
            else {
            
                // eMail is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.eMail.Text = SuppliersTable.eMail.Format(SuppliersTable.eMail.DefaultValue);
            		
            }
            
            // If the eMail is NULL or blank, then use the value specified  
            // on Properties.
            if (this.eMail.Text == null ||
                this.eMail.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.eMail.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetLandPhone()
        {
            
                    
            // Set the LandPhone Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Suppliers database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Suppliers record retrieved from the database.
            // this.LandPhone is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LandPhoneSpecified) {
                								
                // If the LandPhone is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(SuppliersTable.LandPhone);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.LandPhone.Text = formattedValue;
                   
            } 
            
            else {
            
                // LandPhone is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LandPhone.Text = SuppliersTable.LandPhone.Format(SuppliersTable.LandPhone.DefaultValue);
            		
            }
            
            // If the LandPhone is NULL or blank, then use the value specified  
            // on Properties.
            if (this.LandPhone.Text == null ||
                this.LandPhone.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.LandPhone.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPostCode()
        {
            
                    
            // Set the PostCode Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.Suppliers database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Suppliers record retrieved from the database.
            // this.PostCode is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PostCodeSpecified) {
                								
                // If the PostCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(SuppliersTable.PostCode);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PostCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // PostCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PostCode.Text = SuppliersTable.PostCode.Format(SuppliersTable.PostCode.DefaultValue);
            		
            }
            
            // If the PostCode is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PostCode.Text == null ||
                this.PostCode.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PostCode.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetAddress1Label()
                  {
                  
                    
        }
                
        public virtual void SetAddress2Label()
                  {
                  
                    
        }
                
        public virtual void SetCellPhoneLabel()
                  {
                  
                    
        }
                
        public virtual void SetContactNameLabel()
                  {
                  
                    
        }
                
        public virtual void SeteMailLabel()
                  {
                  
                    
        }
                
        public virtual void SetLandPhoneLabel()
                  {
                  
                    
        }
                
        public virtual void SetPostCodeLabel()
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
        ServiceTypesRecordControl parentCtrl;
      
            parentCtrl = (ServiceTypesRecordControl)this.Page.FindControlRecursively("ServiceTypesRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "IPv5"));
        }
        
          this.DataSource.ServiceTypeID = parentCtrl.DataSource.ServiceTypeID;
        
          
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
                ((SuppliersTableControl)MiscUtils.GetParentControlObject(this, "SuppliersTableControl")).DataChanged = true;
                ((SuppliersTableControl)MiscUtils.GetParentControlObject(this, "SuppliersTableControl")).ResetData = true;
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
        
            GetAddress1();
            GetAddress2();
            GetCellPhone();
            GetCityID();
            GetCompanyName();
            GetContactName();
            GeteMail();
            GetLandPhone();
            GetPostCode();
        }
        
        
        public virtual void GetAddress1()
        {
            
        }
                
        public virtual void GetAddress2()
        {
            
        }
                
        public virtual void GetCellPhone()
        {
            
        }
                
        public virtual void GetCityID()
        {
            
        }
                
        public virtual void GetCompanyName()
        {
            
        }
                
        public virtual void GetContactName()
        {
            
        }
                
        public virtual void GeteMail()
        {
            
        }
                
        public virtual void GetLandPhone()
        {
            
        }
                
        public virtual void GetPostCode()
        {
            
        }
                

      // To customize, override this method in SuppliersTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersServiceTypesRecordControl = false;
            hasFiltersServiceTypesRecordControl = hasFiltersServiceTypesRecordControl && false; // suppress warning
      
            bool hasFiltersSuppliersTableControl = false;
            hasFiltersSuppliersTableControl = hasFiltersSuppliersTableControl && false; // suppress warning
      
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
        
            if (this.IsNewRecord) {
                return;
            }

            KeyValue pkValue = KeyValue.XmlToKey(this.RecordUniqueId);
          SuppliersTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((SuppliersTableControl)MiscUtils.GetParentControlObject(this, "SuppliersTableControl")).DataChanged = true;
            ((SuppliersTableControl)MiscUtils.GetParentControlObject(this, "SuppliersTableControl")).ResetData = true;
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
        
        public virtual void SetSuppliersRowDeleteButton()                
              
        {
        
   
        }
            
        public virtual void SetSuppliersRowEditButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void SuppliersRowDeleteButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
                this.Delete();
              
            }
      this.Page.CommitTransaction(sender);
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
        public virtual void SuppliersRowEditButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Suppliers/EditSuppliers.aspx?Suppliers={PK}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
        // event handler for LinkButton
        public virtual void CityID_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Cities/ShowCities.aspx?Cities={SuppliersTableControlRow:FV:CityID}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
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
  

        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseSuppliersTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseSuppliersTableControlRow_Rec"] = value;
            }
        }
        
        public SuppliersRecord DataSource {
            get {
                return (SuppliersRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal CellPhone {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CellPhone");
            }
        }
            
        public System.Web.UI.WebControls.Literal CellPhoneLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CellPhoneLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton CityID {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CityID");
            }
        }
            
        public System.Web.UI.WebControls.Literal CompanyName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CompanyName");
            }
        }
            
        public System.Web.UI.WebControls.Literal ContactName {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactName");
            }
        }
            
        public System.Web.UI.WebControls.Literal ContactNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactNameLabel");
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
        
        public System.Web.UI.WebControls.Literal LandPhone {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LandPhone");
            }
        }
            
        public System.Web.UI.WebControls.Literal LandPhoneLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LandPhoneLabel");
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
        
        public System.Web.UI.WebControls.ImageButton SuppliersRowDeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SuppliersRowDeleteButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SuppliersRowEditButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SuppliersRowEditButton");
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
        SuppliersRecord rec = null;
             
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
    SuppliersRecord rec = null;
    
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

        
        public virtual SuppliersRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return SuppliersTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the SuppliersTableControl control on the ShowServiceTypes page.
// Do not modify this class. Instead override any method in SuppliersTableControl.
public class BaseSuppliersTableControl : IPv5.UI.BaseApplicationTableControl
{
         
       public BaseSuppliersTableControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
      
    
           // Setup the filter and search.
        


      
      
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
            
                    this.SuppliersPagination.FirstPage.Click += SuppliersPagination_FirstPage_Click;
                        
                    this.SuppliersPagination.LastPage.Click += SuppliersPagination_LastPage_Click;
                        
                    this.SuppliersPagination.NextPage.Click += SuppliersPagination_NextPage_Click;
                        
                    this.SuppliersPagination.PageSizeButton.Click += SuppliersPagination_PageSizeButton_Click;
                        
                    this.SuppliersPagination.PreviousPage.Click += SuppliersPagination_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
              this.Address1SortLabel.Click += Address1SortLabel_Click;
            
              this.Address2SortLabel.Click += Address2SortLabel_Click;
            
              this.CellPhoneSortLabel.Click += CellPhoneSortLabel_Click;
            
              this.CityIDSortLabel.Click += CityIDSortLabel_Click;
            
              this.CompanyNameSortLabel.Click += CompanyNameSortLabel_Click;
            
              this.ContactNameSortLabel.Click += ContactNameSortLabel_Click;
            
              this.eMailSortLabel.Click += eMailSortLabel_Click;
            
              this.LandPhoneSortLabel.Click += LandPhoneSortLabel_Click;
            
              this.PostCodeSortLabel.Click += PostCodeSortLabel_Click;
            
            // Setup the button events.
          
                    this.SuppliersExportExcelButton.Click += SuppliersExportExcelButton_Click;
                        
                    this.SuppliersImportButton.Click += SuppliersImportButton_Click;
                        
                    this.SuppliersNewButton.Click += SuppliersNewButton_Click;
                        
                    this.SuppliersPDFButton.Click += SuppliersPDFButton_Click;
                        
                    this.SuppliersWordButton.Click += SuppliersWordButton_Click;
                        
                    this.SuppliersButtonsButton.Button.Click += SuppliersButtonsButton_Click;
                        
                    this.SuppliersFiltersButton.Button.Click += SuppliersFiltersButton_Click;
                                
        
         //' Setup events for others
               
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
                      Type myrec = typeof(IPv5.Business.SuppliersRecord);
                      this.DataSource = (SuppliersRecord[])(alist.ToArray(myrec));
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
                    foreach (SuppliersTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(IPv5.Business.SuppliersRecord);
                    this.DataSource = (SuppliersRecord[])(postdata.ToArray(myrec));
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
        
        public virtual SuppliersRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(SuppliersTable.Column1, true);          
            // selCols.Add(SuppliersTable.Column2, true);          
            // selCols.Add(SuppliersTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return SuppliersTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                SuppliersTable databaseTable = new SuppliersTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(SuppliersRecord)) as SuppliersRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(SuppliersTable.Column1, true);          
            // selCols.Add(SuppliersTable.Column2, true);          
            // selCols.Add(SuppliersTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return SuppliersTable.GetRecordCount(join, where);
            else
            {
                SuppliersTable databaseTable = new SuppliersTable();
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
          
            // Improve performance by prefetching display as records.
            this.PreFetchForeignKeyValues();     

            // Setup the pagination controls.
            BindPaginationControls();

    
        
        // Bind the repeater with the list of records to expand the UI.
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SuppliersTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            SuppliersTableControlRow recControl = (SuppliersTableControlRow)(repItem.FindControl("SuppliersTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                SetAddress1SortLabel();
                SetAddress2SortLabel();
                SetCellPhoneSortLabel();
                SetCityIDSortLabel();
                SetCompanyNameSortLabel();
                SetContactNameSortLabel();
                SeteMailSortLabel();
                SetLandPhoneSortLabel();
                SetPostCodeSortLabel();
                
                
                
                
                
                
                
                
                
                SetSuppliersExportExcelButton();
              
                SetSuppliersImportButton();
              
                SetSuppliersNewButton();
              
                SetSuppliersPDFButton();
              
                SetSuppliersWordButton();
              
                SetSuppliersButtonsButton();
              
                SetSuppliersFiltersButton();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetSuppliersFiltersButton();
                     
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
    public virtual void AddWarningMessageOnClick() {
    
        if (this.TotalRecords > 10000)
          this.SuppliersExportExcelButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm", "IPv5") + "'));");
        else
          this.SuppliersExportExcelButton.Attributes.Remove("onClick");
      
    }
  
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(SuppliersTable.CityID, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"SuppliersExportExcelButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"SuppliersPDFButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"SuppliersWordButton"));
                                
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
                this.SuppliersPagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.SuppliersPagination.CurrentPage.Text = "0";
            }
            this.SuppliersPagination.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for SuppliersTableControl pagination.
        
            this.SuppliersPagination.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.SuppliersPagination.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.SuppliersPagination.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.SuppliersPagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.SuppliersPagination.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.SuppliersPagination.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.SuppliersPagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.SuppliersPagination.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (SuppliersTableControlRow recCtl in this.GetRecordControls())
            {
        
                if (this.InDeletedRecordIds(recCtl)) {
                    // Delete any pending deletes. 
                    recCtl.Delete();
                }
                else {
                    if (recCtl.Visible) {
                        recCtl.SaveData();
                    }
                }
          
            }

          
    
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
          
            // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
            foreach (SuppliersTableControlRow recCtl in this.GetRecordControls()){
                recCtl.IsNewRecord = false;
            }
      
            // Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
            this.DeletedRecordIds = null;
                
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
            SuppliersTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    IPv5.UI.Controls.ShowServiceTypes.ServiceTypesRecordControl serviceTypesRecordControlObj = (MiscUtils.FindControlRecursively(this.Page , "ServiceTypesRecordControl") as IPv5.UI.Controls.ShowServiceTypes.ServiceTypesRecordControl);
          
              if (serviceTypesRecordControlObj != null && serviceTypesRecordControlObj.GetRecord() != null && serviceTypesRecordControlObj.GetRecord().IsCreated)
              {
              wc.iAND(SuppliersTable.ServiceTypeID, BaseFilter.ComparisonOperator.EqualsTo, serviceTypesRecordControlObj.GetRecord().ServiceTypeID.ToString());
              selectedRecordKeyValue.AddElement(SuppliersTable.ServiceTypeID.InternalName, serviceTypesRecordControlObj.GetRecord().ServiceTypeID.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["SuppliersTableControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
         
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            SuppliersTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInServiceTypesRecordControl = HttpContext.Current.Session["SuppliersTableControlWhereClause"] as string;
      
      if (selectedRecordInServiceTypesRecordControl != null && KeyValue.IsXmlKey(selectedRecordInServiceTypesRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInServiceTypesRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(SuppliersTable.ServiceTypeID))
      {
      wc.iAND(SuppliersTable.ServiceTypeID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(SuppliersTable.ServiceTypeID).ToString());
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
        
    
        protected virtual void GetPageSize()
        {
        
            if (this.SuppliersPagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.SuppliersPagination.PageSize.Text);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SuppliersTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                SuppliersTableControlRow recControl = (SuppliersTableControlRow)(repItem.FindControl("SuppliersTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      SuppliersRecord rec = new SuppliersRecord();
        
                        if (recControl.Address1.Text != "") {
                            rec.Parse(recControl.Address1.Text, SuppliersTable.Address1);
                  }
                
                        if (recControl.Address2.Text != "") {
                            rec.Parse(recControl.Address2.Text, SuppliersTable.Address2);
                  }
                
                        if (recControl.CellPhone.Text != "") {
                            rec.Parse(recControl.CellPhone.Text, SuppliersTable.CellPhone);
                  }
                
                        if (recControl.CityID.Text != "") {
                            rec.Parse(recControl.CityID.Text, SuppliersTable.CityID);
                  }
                
                        if (recControl.CompanyName.Text != "") {
                            rec.Parse(recControl.CompanyName.Text, SuppliersTable.CompanyName);
                  }
                
                        if (recControl.ContactName.Text != "") {
                            rec.Parse(recControl.ContactName.Text, SuppliersTable.ContactName);
                  }
                
                        if (recControl.eMail.Text != "") {
                            rec.Parse(recControl.eMail.Text, SuppliersTable.eMail);
                  }
                
                        if (recControl.LandPhone.Text != "") {
                            rec.Parse(recControl.LandPhone.Text, SuppliersTable.LandPhone);
                  }
                
                        if (recControl.PostCode.Text != "") {
                            rec.Parse(recControl.PostCode.Text, SuppliersTable.PostCode);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new SuppliersRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(IPv5.Business.SuppliersRecord);
                this.DataSource = (SuppliersRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(SuppliersTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(SuppliersTableControlRow rec)            
        {
            if (this.DeletedRecordIds == null || this.DeletedRecordIds.Length == 0) {
                return (false);
            }

            return (this.DeletedRecordIds.IndexOf("[" + rec.RecordUniqueId + "]") >= 0);
        }

        private String _DeletedRecordIds;
        public String DeletedRecordIds {
            get {
                return (this._DeletedRecordIds);
            }
            set {
                this._DeletedRecordIds = value;
            }
        }
        
      
        // Create Set, WhereClause, and Populate Methods
        
        public virtual void SetAddress1SortLabel()
                  {
                  
                    
        }
                
        public virtual void SetAddress2SortLabel()
                  {
                  
                    
        }
                
        public virtual void SetCellPhoneSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetCityIDSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetCompanyNameSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetContactNameSortLabel()
                  {
                  
                    
        }
                
        public virtual void SeteMailSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetLandPhoneSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetPostCodeSortLabel()
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
            // Save filter controls to values to session.
        
            
                    
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
          
            this.SaveToSession(this, "DeletedRecordIds", this.DeletedRecordIds);
        
        }
        
        
        protected  void SaveControlsToSession_Ajax()
        {
            // Save filter controls to values to session.
          
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            
            // Clear pagination state from session.
         

    // Clear table properties from the session.
    this.RemoveFromSession(this, "Order_By");
    this.RemoveFromSession(this, "Page_Index");
    this.RemoveFromSession(this, "Page_Size");
    
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["SuppliersTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("SuppliersPagination");
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
    
            this.DeletedRecordIds = (string)this.ViewState["DeletedRecordIds"];
        
        }

        protected override object SaveViewState()
        {            
          
            if (this.CurrentSortOrder != null) {
                this.ViewState["SuppliersTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetSuppliersExportExcelButton()                
              
        {
        
   
        }
            
        public virtual void SetSuppliersImportButton()                
              
        {
        							
                    this.SuppliersImportButton.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=Suppliers" ;
                    this.SuppliersImportButton.Attributes["onClick"] = "window.open('" + this.Page.EncryptUrlParameter(this.SuppliersImportButton.PostBackUrl) + "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;";
                        
   
        }
            
        public virtual void SetSuppliersNewButton()                
              
        {
        
   
        }
            
        public virtual void SetSuppliersPDFButton()                
              
        {
        
   
        }
            
        public virtual void SetSuppliersWordButton()                
              
        {
        
   
        }
            
        public virtual void SetSuppliersButtonsButton()                
              
        {
        
   
        }
            
        public virtual void SetSuppliersFiltersButton()                
              
        {
                
         IThemeButtonWithArrow themeButtonSuppliersFiltersButton = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "SuppliersFiltersButton"));
         themeButtonSuppliersFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
   
        }
               
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void SuppliersPagination_FirstPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void SuppliersPagination_LastPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void SuppliersPagination_NextPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void SuppliersPagination_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.SuppliersPagination.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.SuppliersPagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void SuppliersPagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
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
        
            OrderByItem sd = this.CurrentSortOrder.Find(SuppliersTable.Address1);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Address1.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(SuppliersTable.Address1, OrderByItem.OrderDir.Asc);
            
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
        
            OrderByItem sd = this.CurrentSortOrder.Find(SuppliersTable.Address2);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Address2.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(SuppliersTable.Address2, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by Address2, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void CellPhoneSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by CellPhone when clicked.
              
            // Get previous sorting state for CellPhone.
        
            OrderByItem sd = this.CurrentSortOrder.Find(SuppliersTable.CellPhone);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for CellPhone.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(SuppliersTable.CellPhone, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by CellPhone, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void CityIDSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by CityID when clicked.
              
            // Get previous sorting state for CityID.
        
            OrderByItem sd = this.CurrentSortOrder.Find(SuppliersTable.CityID);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for CityID.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(SuppliersTable.CityID, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by CityID, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void CompanyNameSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by CompanyName when clicked.
              
            // Get previous sorting state for CompanyName.
        
            OrderByItem sd = this.CurrentSortOrder.Find(SuppliersTable.CompanyName);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for CompanyName.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(SuppliersTable.CompanyName, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by CompanyName, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void ContactNameSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by ContactName when clicked.
              
            // Get previous sorting state for ContactName.
        
            OrderByItem sd = this.CurrentSortOrder.Find(SuppliersTable.ContactName);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for ContactName.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(SuppliersTable.ContactName, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by ContactName, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void eMailSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by eMail when clicked.
              
            // Get previous sorting state for eMail.
        
            OrderByItem sd = this.CurrentSortOrder.Find(SuppliersTable.eMail);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for eMail.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(SuppliersTable.eMail, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by eMail, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void LandPhoneSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by LandPhone when clicked.
              
            // Get previous sorting state for LandPhone.
        
            OrderByItem sd = this.CurrentSortOrder.Find(SuppliersTable.LandPhone);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for LandPhone.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(SuppliersTable.LandPhone, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by LandPhone, so just reverse.
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
        
            OrderByItem sd = this.CurrentSortOrder.Find(SuppliersTable.PostCode);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for PostCode.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(SuppliersTable.PostCode, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by PostCode, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void SuppliersExportExcelButton_Click(object sender, ImageClickEventArgs args)
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


              this.TotalRecords = SuppliersTable.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             SuppliersTable.CompanyName,
             SuppliersTable.ContactName,
             SuppliersTable.Address1,
             SuppliersTable.Address2,
             SuppliersTable.CityID,
             SuppliersTable.PostCode,
             SuppliersTable.LandPhone,
             SuppliersTable.CellPhone,
             SuppliersTable.eMail,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(SuppliersTable.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(SuppliersTable.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(SuppliersTable.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(SuppliersTable.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(SuppliersTable.CompanyName, "Default"));
             data.ColumnList.Add(new ExcelColumn(SuppliersTable.ContactName, "Default"));
             data.ColumnList.Add(new ExcelColumn(SuppliersTable.Address1, "Default"));
             data.ColumnList.Add(new ExcelColumn(SuppliersTable.Address2, "Default"));
             data.ColumnList.Add(new ExcelColumn(SuppliersTable.CityID, "Default"));
             data.ColumnList.Add(new ExcelColumn(SuppliersTable.PostCode, "Default"));
             data.ColumnList.Add(new ExcelColumn(SuppliersTable.LandPhone, "Default"));
             data.ColumnList.Add(new ExcelColumn(SuppliersTable.CellPhone, "Default"));
             data.ColumnList.Add(new ExcelColumn(SuppliersTable.eMail, "Default"));


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
                val = SuppliersTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
        public virtual void SuppliersImportButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
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
        public virtual void SuppliersNewButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Suppliers/AddSuppliers.aspx";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"])) 
                url += "?RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void SuppliersPDFButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                PDFReport report = new PDFReport();

                report.SpecificReportFileName = Page.Server.MapPath("ShowServiceTypes.SuppliersPDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "Suppliers";
                // If ShowServiceTypes.SuppliersPDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(SuppliersTable.CompanyName.Name, ReportEnum.Align.Left, "${CompanyName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(SuppliersTable.ContactName.Name, ReportEnum.Align.Left, "${ContactName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(SuppliersTable.Address1.Name, ReportEnum.Align.Left, "${Address1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(SuppliersTable.Address2.Name, ReportEnum.Align.Left, "${Address2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(SuppliersTable.CityID.Name, ReportEnum.Align.Left, "${CityID}", ReportEnum.Align.Left, 15);
                 report.AddColumn(SuppliersTable.PostCode.Name, ReportEnum.Align.Left, "${PostCode}", ReportEnum.Align.Left, 20);
                 report.AddColumn(SuppliersTable.LandPhone.Name, ReportEnum.Align.Left, "${LandPhone}", ReportEnum.Align.Left, 24);
                 report.AddColumn(SuppliersTable.CellPhone.Name, ReportEnum.Align.Left, "${CellPhone}", ReportEnum.Align.Left, 24);
                 report.AddColumn(SuppliersTable.eMail.Name, ReportEnum.Align.Left, "${eMail}", ReportEnum.Align.Left, 28);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "IPv5");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = SuppliersTable.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = SuppliersTable.GetRecordCount(joinFilter,whereClause);
                SuppliersRecord[] records = null;
                
                do
                {
                    
                    records = SuppliersTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( SuppliersRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 report.AddData("${CompanyName}", record.Format(SuppliersTable.CompanyName), ReportEnum.Align.Left, 100);
                             report.AddData("${ContactName}", record.Format(SuppliersTable.ContactName), ReportEnum.Align.Left, 100);
                             report.AddData("${Address1}", record.Format(SuppliersTable.Address1), ReportEnum.Align.Left, 100);
                             report.AddData("${Address2}", record.Format(SuppliersTable.Address2), ReportEnum.Align.Left, 100);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.CityID)){
                                 report.AddData("${CityID}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = SuppliersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(SuppliersTable.CityID);
                                 _DFKA = SuppliersTable.GetDFKA(record.CityID.ToString(), SuppliersTable.CityID,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  SuppliersTable.CityID.IsApplyDisplayAs){
                                     report.AddData("${CityID}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${CityID}", record.Format(SuppliersTable.CityID), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${PostCode}", record.Format(SuppliersTable.PostCode), ReportEnum.Align.Left, 100);
                             report.AddData("${LandPhone}", record.Format(SuppliersTable.LandPhone), ReportEnum.Align.Left, 100);
                             report.AddData("${CellPhone}", record.Format(SuppliersTable.CellPhone), ReportEnum.Align.Left, 100);
                             report.AddData("${eMail}", record.Format(SuppliersTable.eMail), ReportEnum.Align.Left, 100);

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
        public virtual void SuppliersWordButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("ShowServiceTypes.SuppliersWordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "Suppliers";
                // If ShowServiceTypes.SuppliersWordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(SuppliersTable.CompanyName.Name, ReportEnum.Align.Left, "${CompanyName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(SuppliersTable.ContactName.Name, ReportEnum.Align.Left, "${ContactName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(SuppliersTable.Address1.Name, ReportEnum.Align.Left, "${Address1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(SuppliersTable.Address2.Name, ReportEnum.Align.Left, "${Address2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(SuppliersTable.CityID.Name, ReportEnum.Align.Left, "${CityID}", ReportEnum.Align.Left, 15);
                 report.AddColumn(SuppliersTable.PostCode.Name, ReportEnum.Align.Left, "${PostCode}", ReportEnum.Align.Left, 20);
                 report.AddColumn(SuppliersTable.LandPhone.Name, ReportEnum.Align.Left, "${LandPhone}", ReportEnum.Align.Left, 24);
                 report.AddColumn(SuppliersTable.CellPhone.Name, ReportEnum.Align.Left, "${CellPhone}", ReportEnum.Align.Left, 24);
                 report.AddColumn(SuppliersTable.eMail.Name, ReportEnum.Align.Left, "${eMail}", ReportEnum.Align.Left, 28);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = SuppliersTable.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "IPv5");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = SuppliersTable.GetColumnList();
                SuppliersRecord[] records = null;
                do
                {
                    records = SuppliersTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( SuppliersRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             report.AddData("${CompanyName}", record.Format(SuppliersTable.CompanyName), ReportEnum.Align.Left, 100);
                             report.AddData("${ContactName}", record.Format(SuppliersTable.ContactName), ReportEnum.Align.Left, 100);
                             report.AddData("${Address1}", record.Format(SuppliersTable.Address1), ReportEnum.Align.Left, 100);
                             report.AddData("${Address2}", record.Format(SuppliersTable.Address2), ReportEnum.Align.Left, 100);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.CityID)){
                                 report.AddData("${CityID}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = SuppliersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(SuppliersTable.CityID);
                                 _DFKA = SuppliersTable.GetDFKA(record.CityID.ToString(), SuppliersTable.CityID,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  SuppliersTable.CityID.IsApplyDisplayAs){
                                     report.AddData("${CityID}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${CityID}", record.Format(SuppliersTable.CityID), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${PostCode}", record.Format(SuppliersTable.PostCode), ReportEnum.Align.Left, 100);
                             report.AddData("${LandPhone}", record.Format(SuppliersTable.LandPhone), ReportEnum.Align.Left, 100);
                             report.AddData("${CellPhone}", record.Format(SuppliersTable.CellPhone), ReportEnum.Align.Left, 100);
                             report.AddData("${eMail}", record.Format(SuppliersTable.eMail), ReportEnum.Align.Left, 100);

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
        public virtual void SuppliersButtonsButton_Click(object sender, EventArgs args)
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
        public virtual void SuppliersFiltersButton_Click(object sender, EventArgs args)
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
        
    
        // Generate the event handling functions for others
        	  

        protected int _TotalRecords = -1;
        public int TotalRecords 
        {
            get {
                if (_TotalRecords < 0)
                {
                    _TotalRecords = SuppliersTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  SuppliersRecord[] DataSource {
             
            get {
                return (SuppliersRecord[])(base._DataSource);
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
        
        public System.Web.UI.WebControls.LinkButton CellPhoneSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CellPhoneSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton CityIDSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CityIDSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton CompanyNameSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CompanyNameSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ContactNameSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactNameSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton eMailSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "eMailSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton LandPhoneSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LandPhoneSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton PostCodeSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PostCodeSortLabel");
            }
        }
        
        public IPv5.UI.IThemeButtonWithArrow SuppliersButtonsButton {
            get {
                return (IPv5.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SuppliersButtonsButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SuppliersExportExcelButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SuppliersExportExcelButton");
            }
        }
        
        public IPv5.UI.IThemeButtonWithArrow SuppliersFiltersButton {
            get {
                return (IPv5.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SuppliersFiltersButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SuppliersImportButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SuppliersImportButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SuppliersNewButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SuppliersNewButton");
            }
        }
        
        public IPv5.UI.IPaginationModern SuppliersPagination {
            get {
                return (IPv5.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SuppliersPagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SuppliersPDFButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SuppliersPDFButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SuppliersWordButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SuppliersWordButton");
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
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                SuppliersTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IPv5"));
                }

        SuppliersRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                return EvaluateExpressions(url, arg, rec, bEncrypt);
             
            }
            return url;
        }
        
        
        public override string EvaluateExpressions(string url, string arg, bool bEncrypt, bool includeSession)
        {
            bool needToProcess = AreAnyUrlParametersForMe(url, arg);
            if (needToProcess) {
                SuppliersTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IPv5"));
                }

        SuppliersRecord rec = null;
                if (recCtl != null) {
                    rec = recCtl.GetRecord();
                }
                
                if (includeSession)
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt);
                }
                else
                {
                    return EvaluateExpressions(url, arg, rec, bEncrypt,false);
                }
             
            }
            return url;
        }
          
        public virtual SuppliersTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual SuppliersTableControlRow[] GetSelectedRecordControls()
        {
        
            return (SuppliersTableControlRow[])((new ArrayList()).ToArray(Type.GetType("IPv5.UI.Controls.ShowServiceTypes.SuppliersTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            SuppliersTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IPv5"));
            }
            
            foreach (SuppliersTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                } else {
                
                    recCtl.Delete();
                    // Setting the DataChanged to True results in the page being refreshed with
                    // the most recent data from the database.  This happens in PreRender event
                    // based on the current sort, search and filter criteria.
                    this.DataChanged = true;
                    this.ResetData = true;
                  
                }
            }
        }

        public virtual SuppliersTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "SuppliersTableControlRow");
	          List<SuppliersTableControlRow> list = new List<SuppliersTableControlRow>();
	          foreach (SuppliersTableControlRow recCtrl in recCtrls) {
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
  
// Base class for the ServiceTypesRecordControl control on the ShowServiceTypes page.
// Do not modify this class. Instead override any method in ServiceTypesRecordControl.
public class BaseServiceTypesRecordControl : IPv5.UI.BaseApplicationRecordControl
{
        public BaseServiceTypesRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in ServiceTypesRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in ServiceTypesRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
                    this.ServiceTypesDialogEditButton.Click += ServiceTypesDialogEditButton_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseMM_IP1%dbo.ServiceTypes record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = ServiceTypesTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "ServiceTypesRecordControlPanel");
            if (Panel != null){
                Panel.Visible = true;
            }
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new ServiceTypesRecord();
            
                if (Panel != null){
                    Panel.Visible = false;
                }
              
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            ServiceTypesRecord[] recList = ServiceTypesTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                if (Panel != null){
                    Panel.Visible = false;
                }
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = ServiceTypesTable.GetRecord(recList[0].GetID().ToXmlString(), true);
                  
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
        
                SetServiceType();
                SetServiceTypeLabel();
                
                
                SetServiceTypesDialogEditButton();
              

      

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
            SuppliersTableControl recSuppliersTableControl = (SuppliersTableControl)(MiscUtils.FindControlRecursively(this.Page, "SuppliersTableControl"));
        
          if (shouldResetControl || this.Page.IsPageRefresh)
          {
             recSuppliersTableControl.ResetControl();
          }
                  
        this.Page.SetControl("SuppliersTableControl");
        
        }
        
        
        public virtual void SetServiceType()
        {
            
                    
            // Set the ServiceType Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.ServiceTypes database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.ServiceTypes record retrieved from the database.
            // this.ServiceType is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ServiceTypeSpecified) {
                								
                // If the ServiceType is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ServiceTypesTable.ServiceType);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ServiceType.Text = formattedValue;
                   
            } 
            
            else {
            
                // ServiceType is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ServiceType.Text = ServiceTypesTable.ServiceType.Format(ServiceTypesTable.ServiceType.DefaultValue);
            		
            }
            
            // If the ServiceType is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ServiceType.Text == null ||
                this.ServiceType.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ServiceType.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetServiceTypeLabel()
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
        
            System.Web.UI.WebControls.Panel Panel = (System.Web.UI.WebControls.Panel)MiscUtils.FindControlRecursively(this, "ServiceTypesRecordControlPanel");
            if ( (Panel != null && !Panel.Visible) || this.DataSource == null){
                return;
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
          SuppliersTableControl recSuppliersTableControl = (SuppliersTableControl)(MiscUtils.FindControlRecursively(this.Page, "SuppliersTableControl"));
        recSuppliersTableControl.SaveData();
          
        }

        public virtual void GetUIData()
        {
            // The GetUIData method retrieves the updated values from the user interface 
            // controls into a database record in preparation for saving or updating.
            // To do this, it calls the Get methods for each of the field displayed on 
            // the webpage.  It is better to make changes in the Get methods, rather 
            // than making changes here.
      
            // Call the Get methods for each of the user interface controls.
        
            GetServiceType();
        }
        
        
        public virtual void GetServiceType()
        {
            
        }
                

      // To customize, override this method in ServiceTypesRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersServiceTypesRecordControl = false;
            hasFiltersServiceTypesRecordControl = hasFiltersServiceTypesRecordControl && false; // suppress warning
      
            bool hasFiltersSuppliersTableControl = false;
            hasFiltersSuppliersTableControl = hasFiltersSuppliersTableControl && false; // suppress warning
      
            WhereClause wc;
            ServiceTypesTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

              
            // Retrieve the record id from the URL parameter.
              
            string recId = ((BaseApplicationPage)(this.Page)).Decrypt(this.Page.Request.QueryString["ServiceTypes"]);
                
            if (recId == null || recId.Length == 0) {
                // Get the error message from the application resource file.
                throw new Exception(Page.GetResourceValue("Err:UrlParamMissing", "IPv5").Replace("{URL}", "ServiceTypes"));
            }
            HttpContext.Current.Session["QueryString in ShowServiceTypes"] = recId;
                  
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(ServiceTypesTable.ServiceTypeID, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(ServiceTypesTable.ServiceTypeID));
          
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(ServiceTypesTable.ServiceTypeID, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
              
            return wc;
          
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            ServiceTypesTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersServiceTypesRecordControl = false;
            hasFiltersServiceTypesRecordControl = hasFiltersServiceTypesRecordControl && false; // suppress warning
      
            bool hasFiltersSuppliersTableControl = false;
            hasFiltersSuppliersTableControl = hasFiltersSuppliersTableControl && false; // suppress warning
      
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
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
          ServiceTypesTable.DeleteRecord(pkValue);
          
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
        
        public virtual void SetServiceTypesDialogEditButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void ServiceTypesDialogEditButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../ServiceTypes/EditServiceTypes.aspx?ServiceTypes={PK}";
            
            if (!string.IsNullOrEmpty(this.Page.Request["RedirectStyle"]))
                url += "&RedirectStyle=" + this.Page.Request["RedirectStyle"];
            
        bool shouldRedirect = true;
        string target = null;
        if (target == null) target = ""; // avoid warning on VS
      
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
                url = this.ModifyRedirectUrl(url, "",true);
                url = this.Page.ModifyRedirectUrl(url, "",true);
              
            } catch (Exception ex) {
                  // Upon error, rollback the transaction
                  this.Page.RollBackTransaction(sender);
                  shouldRedirect = false;
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
                DbUtils.EndTransaction();
            }
            if (shouldRedirect) {
                this.Page.ShouldSaveControlsToSession = true;
      this.Page.Response.Redirect(url);
        
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
  

        
        public String RecordUniqueId {
            get {
                return (string)this.ViewState["BaseServiceTypesRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseServiceTypesRecordControl_Rec"] = value;
            }
        }
        
        public ServiceTypesRecord DataSource {
            get {
                return (ServiceTypesRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal ServiceType {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServiceType");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServiceTypeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServiceTypeLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ServiceTypesDialogEditButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServiceTypesDialogEditButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal ServiceTypesTitle {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServiceTypesTitle");
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
        ServiceTypesRecord rec = null;
             
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
    ServiceTypesRecord rec = null;
    
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

        
        public virtual ServiceTypesRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return ServiceTypesTable.GetRecord(this.RecordUniqueId, true);
              
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

  

#endregion
    
  
}

  