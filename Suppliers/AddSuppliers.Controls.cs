
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// AddSuppliers.aspx page.  The Row or RecordControl classes are the 
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

  
namespace IPv5.UI.Controls.AddSuppliers
{
  

#region "Section 1: Place your customizations here."

    
public class SuppliersRecordControl : BaseSuppliersRecordControl
{
      
        // The BaseSuppliersRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the SuppliersRecordControl control on the AddSuppliers page.
// Do not modify this class. Instead override any method in SuppliersRecordControl.
public class BaseSuppliersRecordControl : IPv5.UI.BaseApplicationRecordControl
{
        public BaseSuppliersRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in SuppliersRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in SuppliersRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
                    this.CityIDAddRecordLink.Click += CityIDAddRecordLink_Click;
                        
                    this.ServiceTypeIDAddRecordLink.Click += ServiceTypeIDAddRecordLink_Click;
                        
              this.CityID.SelectedIndexChanged += CityID_SelectedIndexChanged;
            
              this.ServiceTypeID.SelectedIndexChanged += ServiceTypeID_SelectedIndexChanged;
            
              this.Address1.TextChanged += Address1_TextChanged;
            
              this.Address2.TextChanged += Address2_TextChanged;
            
              this.CellPhone.TextChanged += CellPhone_TextChanged;
            
              this.CompanyName.TextChanged += CompanyName_TextChanged;
            
              this.ContactName.TextChanged += ContactName_TextChanged;
            
              this.eMail.TextChanged += eMail_TextChanged;
            
              this.LandPhone.TextChanged += LandPhone_TextChanged;
            
              this.PostCode.TextChanged += PostCode_TextChanged;
            
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
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new SuppliersRecord();
            
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            SuppliersRecord[] recList = SuppliersTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = (SuppliersRecord)SuppliersRecord.Copy(recList[0], false);
                  
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
                
                SetCityIDLabel();
                SetCompanyName();
                SetCompanyNameLabel();
                SetContactName();
                SetContactNameLabel();
                SeteMail();
                SeteMailLabel();
                SetLandPhone();
                SetLandPhoneLabel();
                SetPostCode();
                SetPostCodeLabel();
                SetServiceTypeID();
                
                SetServiceTypeIDLabel();
                
                SetCityIDAddRecordLink();
              
                SetServiceTypeIDAddRecordLink();
              

      

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
            
                    
            // Set the Address1 TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.Suppliers database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Suppliers record retrieved from the database.
            // this.Address1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address1Specified) {
                								
                // If the Address1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(SuppliersTable.Address1);
                                
                this.Address1.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address1.Text = SuppliersTable.Address1.Format(SuppliersTable.Address1.DefaultValue);
            		
            }
            
              this.Address1.TextChanged += Address1_TextChanged;
                               
        }
                
        public virtual void SetAddress2()
        {
            
                    
            // Set the Address2 TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.Suppliers database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Suppliers record retrieved from the database.
            // this.Address2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address2Specified) {
                								
                // If the Address2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(SuppliersTable.Address2);
                                
                this.Address2.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address2.Text = SuppliersTable.Address2.Format(SuppliersTable.Address2.DefaultValue);
            		
            }
            
              this.Address2.TextChanged += Address2_TextChanged;
                               
        }
                
        public virtual void SetCellPhone()
        {
            
                    
            // Set the CellPhone TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.Suppliers database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Suppliers record retrieved from the database.
            // this.CellPhone is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CellPhoneSpecified) {
                								
                // If the CellPhone is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(SuppliersTable.CellPhone);
                                
                this.CellPhone.Text = formattedValue;
                   
            } 
            
            else {
            
                // CellPhone is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CellPhone.Text = SuppliersTable.CellPhone.Format(SuppliersTable.CellPhone.DefaultValue);
            		
            }
            
              this.CellPhone.TextChanged += CellPhone_TextChanged;
                               
        }
                
        public virtual void SetCityID()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the CityID DropDownList on the webpage with value from the
            // DatabaseMM_IP1%dbo.Suppliers database record.
            
            // this.DataSource is the DatabaseMM_IP1%dbo.Suppliers record retrieved from the database.
            // this.CityID is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetCityID();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.CityIDSpecified)
            {
                            
                // If the CityID is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.CityID.ToString();
                
            }
            else
            {
                
                // CityID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = SuppliersTable.CityID.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateCityIDDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetCompanyName()
        {
            
                    
            // Set the CompanyName TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.Suppliers database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Suppliers record retrieved from the database.
            // this.CompanyName is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CompanyNameSpecified) {
                								
                // If the CompanyName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(SuppliersTable.CompanyName);
                                
                this.CompanyName.Text = formattedValue;
                   
            } 
            
            else {
            
                // CompanyName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CompanyName.Text = SuppliersTable.CompanyName.Format(SuppliersTable.CompanyName.DefaultValue);
            		
            }
            
              this.CompanyName.TextChanged += CompanyName_TextChanged;
                               
        }
                
        public virtual void SetContactName()
        {
            
                    
            // Set the ContactName TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.Suppliers database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Suppliers record retrieved from the database.
            // this.ContactName is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ContactNameSpecified) {
                								
                // If the ContactName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(SuppliersTable.ContactName);
                                
                this.ContactName.Text = formattedValue;
                   
            } 
            
            else {
            
                // ContactName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ContactName.Text = SuppliersTable.ContactName.Format(SuppliersTable.ContactName.DefaultValue);
            		
            }
            
              this.ContactName.TextChanged += ContactName_TextChanged;
                               
        }
                
        public virtual void SeteMail()
        {
            
                    
            // Set the eMail TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.Suppliers database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Suppliers record retrieved from the database.
            // this.eMail is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.eMailSpecified) {
                								
                // If the eMail is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(SuppliersTable.eMail);
                                
                this.eMail.Text = formattedValue;
                   
            } 
            
            else {
            
                // eMail is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.eMail.Text = SuppliersTable.eMail.Format(SuppliersTable.eMail.DefaultValue);
            		
            }
            
              this.eMail.TextChanged += eMail_TextChanged;
                               
        }
                
        public virtual void SetLandPhone()
        {
            
                    
            // Set the LandPhone TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.Suppliers database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Suppliers record retrieved from the database.
            // this.LandPhone is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LandPhoneSpecified) {
                								
                // If the LandPhone is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(SuppliersTable.LandPhone);
                                
                this.LandPhone.Text = formattedValue;
                   
            } 
            
            else {
            
                // LandPhone is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LandPhone.Text = SuppliersTable.LandPhone.Format(SuppliersTable.LandPhone.DefaultValue);
            		
            }
            
              this.LandPhone.TextChanged += LandPhone_TextChanged;
                               
        }
                
        public virtual void SetPostCode()
        {
            
                    
            // Set the PostCode TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.Suppliers database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Suppliers record retrieved from the database.
            // this.PostCode is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PostCodeSpecified) {
                								
                // If the PostCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(SuppliersTable.PostCode);
                                
                this.PostCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // PostCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PostCode.Text = SuppliersTable.PostCode.Format(SuppliersTable.PostCode.DefaultValue);
            		
            }
            
              this.PostCode.TextChanged += PostCode_TextChanged;
                               
        }
                
        public virtual void SetServiceTypeID()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            
            
            // Set the ServiceTypeID DropDownList on the webpage with value from the
            // DatabaseMM_IP1%dbo.Suppliers database record.
            
            // this.DataSource is the DatabaseMM_IP1%dbo.Suppliers record retrieved from the database.
            // this.ServiceTypeID is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetServiceTypeID();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ServiceTypeIDSpecified)
            {
                            
                // If the ServiceTypeID is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ServiceTypeID.ToString();
                
            }
            else
            {
                
                // ServiceTypeID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = SuppliersTable.ServiceTypeID.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateServiceTypeIDDropDownList(selectedValue, 100);              
                
                  
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
                
        public virtual void SetCityIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetCompanyNameLabel()
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
                
        public virtual void SetServiceTypeIDLabel()
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
        
            GetAddress1();
            GetAddress2();
            GetCellPhone();
            GetCityID();
            GetCompanyName();
            GetContactName();
            GeteMail();
            GetLandPhone();
            GetPostCode();
            GetServiceTypeID();
        }
        
        
        public virtual void GetAddress1()
        {
            
            // Retrieve the value entered by the user on the Address1 ASP:TextBox, and
            // save it into the Address1 field in DataSource DatabaseMM_IP1%dbo.Suppliers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.Address1.Text, SuppliersTable.Address1);							
                          
                      
        }
                
        public virtual void GetAddress2()
        {
            
            // Retrieve the value entered by the user on the Address2 ASP:TextBox, and
            // save it into the Address2 field in DataSource DatabaseMM_IP1%dbo.Suppliers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.Address2.Text, SuppliersTable.Address2);							
                          
                      
        }
                
        public virtual void GetCellPhone()
        {
            
            // Retrieve the value entered by the user on the CellPhone ASP:TextBox, and
            // save it into the CellPhone field in DataSource DatabaseMM_IP1%dbo.Suppliers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CellPhone.Text, SuppliersTable.CellPhone);							
                          
                      
        }
                
        public virtual void GetCityID()
        {
         // Retrieve the value entered by the user on the CityID ASP:DropDownList, and
            // save it into the CityID field in DataSource DatabaseMM_IP1%dbo.Suppliers record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.CityID), SuppliersTable.CityID);			
                			 
        }
                
        public virtual void GetCompanyName()
        {
            
            // Retrieve the value entered by the user on the CompanyName ASP:TextBox, and
            // save it into the CompanyName field in DataSource DatabaseMM_IP1%dbo.Suppliers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CompanyName.Text, SuppliersTable.CompanyName);							
                          
                      
        }
                
        public virtual void GetContactName()
        {
            
            // Retrieve the value entered by the user on the ContactName ASP:TextBox, and
            // save it into the ContactName field in DataSource DatabaseMM_IP1%dbo.Suppliers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ContactName.Text, SuppliersTable.ContactName);							
                          
                      
        }
                
        public virtual void GeteMail()
        {
            
            // Retrieve the value entered by the user on the eMail ASP:TextBox, and
            // save it into the eMail field in DataSource DatabaseMM_IP1%dbo.Suppliers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.eMail.Text, SuppliersTable.eMail);							
                          
                      
        }
                
        public virtual void GetLandPhone()
        {
            
            // Retrieve the value entered by the user on the LandPhone ASP:TextBox, and
            // save it into the LandPhone field in DataSource DatabaseMM_IP1%dbo.Suppliers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LandPhone.Text, SuppliersTable.LandPhone);							
                          
                      
        }
                
        public virtual void GetPostCode()
        {
            
            // Retrieve the value entered by the user on the PostCode ASP:TextBox, and
            // save it into the PostCode field in DataSource DatabaseMM_IP1%dbo.Suppliers record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.PostCode.Text, SuppliersTable.PostCode);							
                          
                      
        }
                
        public virtual void GetServiceTypeID()
        {
         // Retrieve the value entered by the user on the ServiceTypeID ASP:DropDownList, and
            // save it into the ServiceTypeID field in DataSource DatabaseMM_IP1%dbo.Suppliers record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ServiceTypeID), SuppliersTable.ServiceTypeID);			
                			 
        }
                

      // To customize, override this method in SuppliersRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersSuppliersRecordControl = false;
            hasFiltersSuppliersRecordControl = hasFiltersSuppliersRecordControl && false; // suppress warning
      
            WhereClause wc;
            SuppliersTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

            
            // Retrieve the record id from the URL parameter.
            string recId = this.Page.Request.QueryString["Suppliers"];
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
              
            recId = ((BaseApplicationPage)(this.Page)).Decrypt(recId);
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
                       
            HttpContext.Current.Session["QueryString in AddSuppliers"] = recId;
              
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(SuppliersTable.SupplierID, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(SuppliersTable.SupplierID));
             
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(SuppliersTable.SupplierID, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
                
            return wc;
            
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            SuppliersTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersSuppliersRecordControl = false;
            hasFiltersSuppliersRecordControl = hasFiltersSuppliersRecordControl && false; // suppress warning
      
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
          SuppliersTable.DeleteRecord(pkValue);
          
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
        
        public virtual void SetCityIDAddRecordLink()                
              
        {
        
              try
              {
                    string url = "../Cities/AddCities.aspx";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "?RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("NewWindow") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(this.CityID.ClientID) + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("= Cities.City")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("CityID");                      
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializeNewWindow(this, '" + url + "', false, event);";                  
                       
                    this.CityIDAddRecordLink.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, CityIDAddRecordLink_ClickCityIDAddRecordLink_Click will be trigger when user click the button.
                }
                  
   
        }
            
        public virtual void SetServiceTypeIDAddRecordLink()                
              
        {
        
              try
              {
                    string url = "../ServiceTypes/AddServiceTypes.aspx";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "?RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("NewWindow") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(this.ServiceTypeID.ClientID) + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("ServiceType")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("ServiceTypeID");                      
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializeNewWindow(this, '" + url + "', false, event);";                  
                       
                    this.ServiceTypeIDAddRecordLink.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, ServiceTypeIDAddRecordLink_ClickServiceTypeIDAddRecordLink_Click will be trigger when user click the button.
                }
                  
   
        }
            
        public virtual WhereClause CreateWhereClause_CityIDDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseMM_IP1%dbo.Cities table.
            // Examples:
            // wc.iAND(CitiesTable.CityID, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(CitiesTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_ServiceTypeIDDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseMM_IP1%dbo.ServiceTypes table.
            // Examples:
            // wc.iAND(ServiceTypesTable.ServiceType, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(ServiceTypesTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        // Fill the CityID list.
        protected virtual void PopulateCityIDDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.CityID.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.CityID.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "IPv5"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_CityIDDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_CityIDDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CitiesTable.City, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the CityIDDropDownList.
            CitiesRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = CitiesTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (CitiesRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.CityIDSpecified) 
                        {
                            cvalue = itemValue.CityID.ToString().ToString();
                            if (counter < maxItems && this.CityID.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = SuppliersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(SuppliersTable.CityID);
                                if(_isExpandableNonCompositeForeignKey && SuppliersTable.CityID.IsApplyDisplayAs)
                                    fvalue = SuppliersTable.GetDFKA(itemValue, SuppliersTable.CityID);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(CitiesTable.CityID);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.CityID.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.CityID.Items.Add(newItem);

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
                        
                                        
            // 4. Set the selected value (insert if not already present).
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.CityID, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.CityID, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseMM_IP1%dbo.Cities.CityID = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(CitiesTable.CityID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    CitiesRecord[] rc = CitiesTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        CitiesRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.CityIDSpecified)
                            cvalue = itemValue.CityID.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = SuppliersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(SuppliersTable.CityID);
                        if(_isExpandableNonCompositeForeignKey && SuppliersTable.CityID.IsApplyDisplayAs)
                            fvalue = SuppliersTable.GetDFKA(itemValue, SuppliersTable.CityID);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(CitiesTable.CityID);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.CityID, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the ServiceTypeID list.
        protected virtual void PopulateServiceTypeIDDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.ServiceTypeID.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.ServiceTypeID.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "IPv5"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ServiceTypeIDDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_ServiceTypeIDDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(ServiceTypesTable.ServiceType, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the ServiceTypeIDDropDownList.
            ServiceTypesRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = ServiceTypesTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (ServiceTypesRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.ServiceTypeIDSpecified) 
                        {
                            cvalue = itemValue.ServiceTypeID.ToString().ToString();
                            if (counter < maxItems && this.ServiceTypeID.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = SuppliersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(SuppliersTable.ServiceTypeID);
                                if(_isExpandableNonCompositeForeignKey && SuppliersTable.ServiceTypeID.IsApplyDisplayAs)
                                    fvalue = SuppliersTable.GetDFKA(itemValue, SuppliersTable.ServiceTypeID);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(ServiceTypesTable.ServiceType);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ServiceTypeID.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ServiceTypeID.Items.Add(newItem);

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
                        
                                        
            // 4. Set the selected value (insert if not already present).
              
            if (selectedValue != null &&
                selectedValue.Trim() != "" &&
                !MiscUtils.SetSelectedValue(this.ServiceTypeID, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ServiceTypeID, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseMM_IP1%dbo.ServiceTypes.ServiceTypeID = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(ServiceTypesTable.ServiceTypeID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    ServiceTypesRecord[] rc = ServiceTypesTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        ServiceTypesRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.ServiceTypeIDSpecified)
                            cvalue = itemValue.ServiceTypeID.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = SuppliersTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(SuppliersTable.ServiceTypeID);
                        if(_isExpandableNonCompositeForeignKey && SuppliersTable.ServiceTypeID.IsApplyDisplayAs)
                            fvalue = SuppliersTable.GetDFKA(itemValue, SuppliersTable.ServiceTypeID);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(ServiceTypesTable.ServiceType);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ServiceTypeID, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // event handler for ImageButton
        public virtual void CityIDAddRecordLink_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Cities/AddCities.aspx";
            
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
      
                    url = url + "?RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("NewWindow") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(this.CityID.ClientID) + "&Formula=" + (this.Page as BaseApplicationPage).Encrypt("= Cities.City")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("CityID");                      
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializeNewWindow(this, '" + url + "', false, event);";                  
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "CityIDAddRecordLink_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void ServiceTypeIDAddRecordLink_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../ServiceTypes/AddServiceTypes.aspx";
            
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
      
                    url = url + "?RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("NewWindow") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(this.ServiceTypeID.ClientID) + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("ServiceType")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("ServiceTypeID");                      
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializeNewWindow(this, '" + url + "', false, event);";                  
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "ServiceTypeIDAddRecordLink_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
        protected virtual void CityID_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[CityID.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[CityID.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.CityID.Items.Add(new ListItem(displayText, val));
	            this.CityID.SelectedIndex = this.CityID.Items.Count - 1;
	            this.Page.Session.Remove(CityID.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(CityID.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void ServiceTypeID_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[ServiceTypeID.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[ServiceTypeID.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.ServiceTypeID.Items.Add(new ListItem(displayText, val));
	            this.ServiceTypeID.SelectedIndex = this.ServiceTypeID.Items.Count - 1;
	            this.Page.Session.Remove(ServiceTypeID.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(ServiceTypeID.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void Address1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void Address2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CellPhone_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CompanyName_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ContactName_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void eMail_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void LandPhone_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void PostCode_TextChanged(object sender, EventArgs args)
        {
                    
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
                return (string)this.ViewState["BaseSuppliersRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseSuppliersRecordControl_Rec"] = value;
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
        
        public System.Web.UI.WebControls.TextBox Address1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address1");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address1Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address1Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox Address2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address2");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address2Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address2Label");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CellPhone {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CellPhone");
            }
        }
            
        public System.Web.UI.WebControls.Literal CellPhoneLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CellPhoneLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList CityID {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CityID");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton CityIDAddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CityIDAddRecordLink");
            }
        }
        
        public System.Web.UI.WebControls.Literal CityIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CityIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CompanyName {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CompanyName");
            }
        }
            
        public System.Web.UI.WebControls.Literal CompanyNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CompanyNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ContactName {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactName");
            }
        }
            
        public System.Web.UI.WebControls.Literal ContactNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox eMail {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "eMail");
            }
        }
            
        public System.Web.UI.WebControls.Literal eMailLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "eMailLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LandPhone {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LandPhone");
            }
        }
            
        public System.Web.UI.WebControls.Literal LandPhoneLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LandPhoneLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox PostCode {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PostCode");
            }
        }
            
        public System.Web.UI.WebControls.Literal PostCodeLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PostCodeLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList ServiceTypeID {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServiceTypeID");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton ServiceTypeIDAddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServiceTypeIDAddRecordLink");
            }
        }
        
        public System.Web.UI.WebControls.Literal ServiceTypeIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServiceTypeIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal SuppliersTitle {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SuppliersTitle");
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
            
            return new SuppliersRecord();
            
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

  