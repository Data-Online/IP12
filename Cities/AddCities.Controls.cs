
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// AddCities.aspx page.  The Row or RecordControl classes are the 
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

  
namespace IPv5.UI.Controls.AddCities
{
  

#region "Section 1: Place your customizations here."

    
public class ContractorsTableControlRow : BaseContractorsTableControlRow
{
      
        // The BaseContractorsTableControlRow implements code for a ROW within the
        // the ContractorsTableControl table.  The BaseContractorsTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of ContractorsTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class ContractorsTableControl : BaseContractorsTableControl
{
    // The BaseContractorsTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The ContractorsTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  
public class PropertyContactsTableControlRow : BasePropertyContactsTableControlRow
{
      
        // The BasePropertyContactsTableControlRow implements code for a ROW within the
        // the PropertyContactsTableControl table.  The BasePropertyContactsTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of PropertyContactsTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class PropertyContactsTableControl : BasePropertyContactsTableControl
{
    // The BasePropertyContactsTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The PropertyContactsTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  
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

  
public class CitiesRecordControl : BaseCitiesRecordControl
{
      
        // The BaseCitiesRecordControl implements the LoadData, DataBind and other
        // methods to load and display the data in a table control.

        // This is the ideal place to add your code customizations. For example, you can override the LoadData, 
        // CreateWhereClause, DataBind, SaveData, GetUIData, and Validate methods.
        
}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the ContractorsTableControlRow control on the AddCities page.
// Do not modify this class. Instead override any method in ContractorsTableControlRow.
public class BaseContractorsTableControlRow : IPv5.UI.BaseApplicationRecordControl
{
        public BaseContractorsTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in ContractorsTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in ContractorsTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.ContractorsRowDeleteButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "IPv5") + "\"));");            
        
              // Register the event handlers.

          
                    this.ContractorsRowDeleteButton.Click += ContractorsRowDeleteButton_Click;
                        
              this.Address12.TextChanged += Address12_TextChanged;
            
              this.Address22.TextChanged += Address22_TextChanged;
            
              this.CellPhone1.TextChanged += CellPhone1_TextChanged;
            
              this.CompanyName1.TextChanged += CompanyName1_TextChanged;
            
              this.ContactName1.TextChanged += ContactName1_TextChanged;
            
              this.ContractorID.TextChanged += ContractorID_TextChanged;
            
              this.eMail2.TextChanged += eMail2_TextChanged;
            
              this.LandPhone1.TextChanged += LandPhone1_TextChanged;
            
              this.PostCode2.TextChanged += PostCode2_TextChanged;
            
              this.ServiceTypeID1.TextChanged += ServiceTypeID1_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseMM_IP1%dbo.Contractors record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = ContractorsTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseContractorsTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new ContractorsRecord();
            
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
        
                SetAddress12();
                SetAddress1Label2();
                SetAddress22();
                SetAddress2Label2();
                SetCellPhone1();
                SetCellPhoneLabel1();
                SetCompanyName1();
                SetCompanyNameLabel2();
                SetContactName1();
                SetContactNameLabel1();
                SetContractorID();
                SetContractorIDLabel();
                
                
                SeteMail2();
                SeteMailLabel2();
                SetLandPhone1();
                SetLandPhoneLabel1();
                SetPostCode2();
                SetPostCodeLabel2();
                SetServiceTypeID1();
                SetServiceTypeIDLabel2();
                SetContractorsRowDeleteButton();
              

      

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
        
        
        public virtual void SetAddress12()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.Address12.ID))
            {
            
                this.Address12.Text = this.PreviousUIData[this.Address12.ID].ToString();
              
                return;
            }
            
                    
            // Set the Address1 TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contractors database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contractors record retrieved from the database.
            // this.Address12 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address1Specified) {
                								
                // If the Address1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContractorsTable.Address1);
                                
                this.Address12.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address12.Text = ContractorsTable.Address1.Format(ContractorsTable.Address1.DefaultValue);
            		
            }
            
              this.Address12.TextChanged += Address12_TextChanged;
                               
        }
                
        public virtual void SetAddress22()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.Address22.ID))
            {
            
                this.Address22.Text = this.PreviousUIData[this.Address22.ID].ToString();
              
                return;
            }
            
                    
            // Set the Address2 TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contractors database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contractors record retrieved from the database.
            // this.Address22 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address2Specified) {
                								
                // If the Address2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContractorsTable.Address2);
                                
                this.Address22.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address22.Text = ContractorsTable.Address2.Format(ContractorsTable.Address2.DefaultValue);
            		
            }
            
              this.Address22.TextChanged += Address22_TextChanged;
                               
        }
                
        public virtual void SetCellPhone1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CellPhone1.ID))
            {
            
                this.CellPhone1.Text = this.PreviousUIData[this.CellPhone1.ID].ToString();
              
                return;
            }
            
                    
            // Set the CellPhone TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contractors database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contractors record retrieved from the database.
            // this.CellPhone1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CellPhoneSpecified) {
                								
                // If the CellPhone is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContractorsTable.CellPhone);
                                
                this.CellPhone1.Text = formattedValue;
                   
            } 
            
            else {
            
                // CellPhone is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CellPhone1.Text = ContractorsTable.CellPhone.Format(ContractorsTable.CellPhone.DefaultValue);
            		
            }
            
              this.CellPhone1.TextChanged += CellPhone1_TextChanged;
                               
        }
                
        public virtual void SetCompanyName1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CompanyName1.ID))
            {
            
                this.CompanyName1.Text = this.PreviousUIData[this.CompanyName1.ID].ToString();
              
                return;
            }
            
                    
            // Set the CompanyName TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contractors database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contractors record retrieved from the database.
            // this.CompanyName1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CompanyNameSpecified) {
                								
                // If the CompanyName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContractorsTable.CompanyName);
                                
                this.CompanyName1.Text = formattedValue;
                   
            } 
            
            else {
            
                // CompanyName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CompanyName1.Text = ContractorsTable.CompanyName.Format(ContractorsTable.CompanyName.DefaultValue);
            		
            }
            
              this.CompanyName1.TextChanged += CompanyName1_TextChanged;
                               
        }
                
        public virtual void SetContactName1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ContactName1.ID))
            {
            
                this.ContactName1.Text = this.PreviousUIData[this.ContactName1.ID].ToString();
              
                return;
            }
            
                    
            // Set the ContactName TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contractors database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contractors record retrieved from the database.
            // this.ContactName1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ContactNameSpecified) {
                								
                // If the ContactName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContractorsTable.ContactName);
                                
                this.ContactName1.Text = formattedValue;
                   
            } 
            
            else {
            
                // ContactName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ContactName1.Text = ContractorsTable.ContactName.Format(ContractorsTable.ContactName.DefaultValue);
            		
            }
            
              this.ContactName1.TextChanged += ContactName1_TextChanged;
                               
        }
                
        public virtual void SetContractorID()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ContractorID.ID))
            {
            
                this.ContractorID.Text = this.PreviousUIData[this.ContractorID.ID].ToString();
              
                return;
            }
            
                    
            // Set the ContractorID TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contractors database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contractors record retrieved from the database.
            // this.ContractorID is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ContractorIDSpecified) {
                								
                // If the ContractorID is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContractorsTable.ContractorID);
                                
                this.ContractorID.Text = formattedValue;
                   
            } 
            
            else {
            
                // ContractorID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ContractorID.Text = ContractorsTable.ContractorID.Format(ContractorsTable.ContractorID.DefaultValue);
            		
            }
            
              this.ContractorID.TextChanged += ContractorID_TextChanged;
                               
        }
                
        public virtual void SeteMail2()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.eMail2.ID))
            {
            
                this.eMail2.Text = this.PreviousUIData[this.eMail2.ID].ToString();
              
                return;
            }
            
                    
            // Set the eMail TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contractors database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contractors record retrieved from the database.
            // this.eMail2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.eMailSpecified) {
                								
                // If the eMail is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContractorsTable.eMail);
                                
                this.eMail2.Text = formattedValue;
                   
            } 
            
            else {
            
                // eMail is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.eMail2.Text = ContractorsTable.eMail.Format(ContractorsTable.eMail.DefaultValue);
            		
            }
            
              this.eMail2.TextChanged += eMail2_TextChanged;
                               
        }
                
        public virtual void SetLandPhone1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.LandPhone1.ID))
            {
            
                this.LandPhone1.Text = this.PreviousUIData[this.LandPhone1.ID].ToString();
              
                return;
            }
            
                    
            // Set the LandPhone TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contractors database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contractors record retrieved from the database.
            // this.LandPhone1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LandPhoneSpecified) {
                								
                // If the LandPhone is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContractorsTable.LandPhone);
                                
                this.LandPhone1.Text = formattedValue;
                   
            } 
            
            else {
            
                // LandPhone is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LandPhone1.Text = ContractorsTable.LandPhone.Format(ContractorsTable.LandPhone.DefaultValue);
            		
            }
            
              this.LandPhone1.TextChanged += LandPhone1_TextChanged;
                               
        }
                
        public virtual void SetPostCode2()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.PostCode2.ID))
            {
            
                this.PostCode2.Text = this.PreviousUIData[this.PostCode2.ID].ToString();
              
                return;
            }
            
                    
            // Set the PostCode TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contractors database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contractors record retrieved from the database.
            // this.PostCode2 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PostCodeSpecified) {
                								
                // If the PostCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContractorsTable.PostCode);
                                
                this.PostCode2.Text = formattedValue;
                   
            } 
            
            else {
            
                // PostCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PostCode2.Text = ContractorsTable.PostCode.Format(ContractorsTable.PostCode.DefaultValue);
            		
            }
            
              this.PostCode2.TextChanged += PostCode2_TextChanged;
                               
        }
                
        public virtual void SetServiceTypeID1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ServiceTypeID1.ID))
            {
            
                this.ServiceTypeID1.Text = this.PreviousUIData[this.ServiceTypeID1.ID].ToString();
              
                return;
            }
            
                    
            // Set the ServiceTypeID TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.Contractors database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Contractors record retrieved from the database.
            // this.ServiceTypeID1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ServiceTypeIDSpecified) {
                								
                // If the ServiceTypeID is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(ContractorsTable.ServiceTypeID);
                                
                this.ServiceTypeID1.Text = formattedValue;
                   
            } 
            
            else {
            
                // ServiceTypeID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ServiceTypeID1.Text = ContractorsTable.ServiceTypeID.Format(ContractorsTable.ServiceTypeID.DefaultValue);
            		
            }
            
              this.ServiceTypeID1.TextChanged += ServiceTypeID1_TextChanged;
                               
        }
                
        public virtual void SetAddress1Label2()
                  {
                  
                    
        }
                
        public virtual void SetAddress2Label2()
                  {
                  
                    
        }
                
        public virtual void SetCellPhoneLabel1()
                  {
                  
                    
        }
                
        public virtual void SetCompanyNameLabel2()
                  {
                  
                    
        }
                
        public virtual void SetContactNameLabel1()
                  {
                  
                    
        }
                
        public virtual void SetContractorIDLabel()
                  {
                  
                    
        }
                
        public virtual void SeteMailLabel2()
                  {
                  
                    
        }
                
        public virtual void SetLandPhoneLabel1()
                  {
                  
                    
        }
                
        public virtual void SetPostCodeLabel2()
                  {
                  
                    
        }
                
        public virtual void SetServiceTypeIDLabel2()
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
        CitiesRecordControl parentCtrl;
      
            parentCtrl = (CitiesRecordControl)this.Page.FindControlRecursively("CitiesRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "IPv5"));
        }
        
          this.DataSource.CityID = parentCtrl.DataSource.CityID;
        
          
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
                ((ContractorsTableControl)MiscUtils.GetParentControlObject(this, "ContractorsTableControl")).DataChanged = true;
                ((ContractorsTableControl)MiscUtils.GetParentControlObject(this, "ContractorsTableControl")).ResetData = true;
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
        
            GetAddress12();
            GetAddress22();
            GetCellPhone1();
            GetCompanyName1();
            GetContactName1();
            GetContractorID();
            GeteMail2();
            GetLandPhone1();
            GetPostCode2();
            GetServiceTypeID1();
        }
        
        
        public virtual void GetAddress12()
        {
            
            // Retrieve the value entered by the user on the Address1 ASP:TextBox, and
            // save it into the Address1 field in DataSource DatabaseMM_IP1%dbo.Contractors record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.Address12.Text, ContractorsTable.Address1);							
                          
                      
        }
                
        public virtual void GetAddress22()
        {
            
            // Retrieve the value entered by the user on the Address2 ASP:TextBox, and
            // save it into the Address2 field in DataSource DatabaseMM_IP1%dbo.Contractors record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.Address22.Text, ContractorsTable.Address2);							
                          
                      
        }
                
        public virtual void GetCellPhone1()
        {
            
            // Retrieve the value entered by the user on the CellPhone ASP:TextBox, and
            // save it into the CellPhone field in DataSource DatabaseMM_IP1%dbo.Contractors record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CellPhone1.Text, ContractorsTable.CellPhone);							
                          
                      
        }
                
        public virtual void GetCompanyName1()
        {
            
            // Retrieve the value entered by the user on the CompanyName ASP:TextBox, and
            // save it into the CompanyName field in DataSource DatabaseMM_IP1%dbo.Contractors record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.CompanyName1.Text, ContractorsTable.CompanyName);							
                          
                      
        }
                
        public virtual void GetContactName1()
        {
            
            // Retrieve the value entered by the user on the ContactName ASP:TextBox, and
            // save it into the ContactName field in DataSource DatabaseMM_IP1%dbo.Contractors record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ContactName1.Text, ContractorsTable.ContactName);							
                          
                      
        }
                
        public virtual void GetContractorID()
        {
            
            // Retrieve the value entered by the user on the ContractorID ASP:TextBox, and
            // save it into the ContractorID field in DataSource DatabaseMM_IP1%dbo.Contractors record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ContractorID.Text, ContractorsTable.ContractorID);							
                          
                      
        }
                
        public virtual void GeteMail2()
        {
            
            // Retrieve the value entered by the user on the eMail ASP:TextBox, and
            // save it into the eMail field in DataSource DatabaseMM_IP1%dbo.Contractors record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.eMail2.Text, ContractorsTable.eMail);							
                          
                      
        }
                
        public virtual void GetLandPhone1()
        {
            
            // Retrieve the value entered by the user on the LandPhone ASP:TextBox, and
            // save it into the LandPhone field in DataSource DatabaseMM_IP1%dbo.Contractors record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LandPhone1.Text, ContractorsTable.LandPhone);							
                          
                      
        }
                
        public virtual void GetPostCode2()
        {
            
            // Retrieve the value entered by the user on the PostCode ASP:TextBox, and
            // save it into the PostCode field in DataSource DatabaseMM_IP1%dbo.Contractors record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.PostCode2.Text, ContractorsTable.PostCode);							
                          
                      
        }
                
        public virtual void GetServiceTypeID1()
        {
            
            // Retrieve the value entered by the user on the ServiceTypeID ASP:TextBox, and
            // save it into the ServiceTypeID field in DataSource DatabaseMM_IP1%dbo.Contractors record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.ServiceTypeID1.Text, ContractorsTable.ServiceTypeID);							
                          
                      
        }
                

      // To customize, override this method in ContractorsTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersCitiesRecordControl = false;
            hasFiltersCitiesRecordControl = hasFiltersCitiesRecordControl && false; // suppress warning
      
            bool hasFiltersContractorsTableControl = false;
            hasFiltersContractorsTableControl = hasFiltersContractorsTableControl && false; // suppress warning
      
            bool hasFiltersPropertyContactsTableControl = false;
            hasFiltersPropertyContactsTableControl = hasFiltersPropertyContactsTableControl && false; // suppress warning
      
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
          ContractorsTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((ContractorsTableControl)MiscUtils.GetParentControlObject(this, "ContractorsTableControl")).DataChanged = true;
            ((ContractorsTableControl)MiscUtils.GetParentControlObject(this, "ContractorsTableControl")).ResetData = true;
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
        
        public virtual void SetContractorsRowDeleteButton()                
              
        {
        
   
        }
            
        // event handler for ImageButton
        public virtual void ContractorsRowDeleteButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        ContractorsTableControl tc= ((ContractorsTableControl)MiscUtils.GetParentControlObject(this, "ContractorsTableControl"));
                if (tc != null){
                    if (!this.IsNewRecord){
                        tc.AddToDeletedRecordIds((ContractorsTableControlRow)this);
                    }
                    this.Visible = false;
                    tc.SetFormulaControls();                    
                }
              
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
            
            
        
        protected virtual void Address12_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void Address22_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CellPhone1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void CompanyName1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ContactName1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ContractorID_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void eMail2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void LandPhone1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void PostCode2_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void ServiceTypeID1_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseContractorsTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseContractorsTableControlRow_Rec"] = value;
            }
        }
        
        public ContractorsRecord DataSource {
            get {
                return (ContractorsRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.TextBox Address12 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address12");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address1Label2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address1Label2");
            }
        }
        
        public System.Web.UI.WebControls.TextBox Address22 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address22");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address2Label2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address2Label2");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CellPhone1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CellPhone1");
            }
        }
            
        public System.Web.UI.WebControls.Literal CellPhoneLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CellPhoneLabel1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox CompanyName1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CompanyName1");
            }
        }
            
        public System.Web.UI.WebControls.Literal CompanyNameLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CompanyNameLabel2");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ContactName1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactName1");
            }
        }
            
        public System.Web.UI.WebControls.Literal ContactNameLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactNameLabel1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ContractorID {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContractorID");
            }
        }
            
        public System.Web.UI.WebControls.Literal ContractorIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContractorIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ContractorsRecordRowSelection {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContractorsRecordRowSelection");
            }
        }              
            
        public System.Web.UI.WebControls.ImageButton ContractorsRowDeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContractorsRowDeleteButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox eMail2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "eMail2");
            }
        }
            
        public System.Web.UI.WebControls.Literal eMailLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "eMailLabel2");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LandPhone1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LandPhone1");
            }
        }
            
        public System.Web.UI.WebControls.Literal LandPhoneLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LandPhoneLabel1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox PostCode2 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PostCode2");
            }
        }
            
        public System.Web.UI.WebControls.Literal PostCodeLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PostCodeLabel2");
            }
        }
        
        public System.Web.UI.WebControls.TextBox ServiceTypeID1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServiceTypeID1");
            }
        }
            
        public System.Web.UI.WebControls.Literal ServiceTypeIDLabel2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServiceTypeIDLabel2");
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
        ContractorsRecord rec = null;
             
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
    ContractorsRecord rec = null;
    
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

        
        public virtual ContractorsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return ContractorsTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the ContractorsTableControl control on the AddCities page.
// Do not modify this class. Instead override any method in ContractorsTableControl.
public class BaseContractorsTableControl : IPv5.UI.BaseApplicationTableControl
{
         
       public BaseContractorsTableControl()
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
        
              // Show confirmation message on Click
              this.ContractorsDeleteButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteConfirm", "IPv5") + "\"));");
            // Setup the pagination events.
            
                    this.ContractorsPagination.FirstPage.Click += ContractorsPagination_FirstPage_Click;
                        
                    this.ContractorsPagination.LastPage.Click += ContractorsPagination_LastPage_Click;
                        
                    this.ContractorsPagination.NextPage.Click += ContractorsPagination_NextPage_Click;
                        
                    this.ContractorsPagination.PageSizeButton.Click += ContractorsPagination_PageSizeButton_Click;
                        
                    this.ContractorsPagination.PreviousPage.Click += ContractorsPagination_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
              this.Address1SortLabel2.Click += Address1SortLabel2_Click;
            
              this.Address2SortLabel2.Click += Address2SortLabel2_Click;
            
              this.CellPhoneSortLabel1.Click += CellPhoneSortLabel1_Click;
            
              this.CompanyNameSortLabel1.Click += CompanyNameSortLabel1_Click;
            
              this.ContactNameSortLabel1.Click += ContactNameSortLabel1_Click;
            
              this.ContractorIDSortLabel.Click += ContractorIDSortLabel_Click;
            
              this.eMailSortLabel2.Click += eMailSortLabel2_Click;
            
              this.LandPhoneSortLabel1.Click += LandPhoneSortLabel1_Click;
            
              this.PostCodeSortLabel2.Click += PostCodeSortLabel2_Click;
            
              this.ServiceTypeIDSortLabel1.Click += ServiceTypeIDSortLabel1_Click;
            
            // Setup the button events.
          
                    this.ContractorsAddButton.Click += ContractorsAddButton_Click;
                        
                    this.ContractorsDeleteButton.Click += ContractorsDeleteButton_Click;
                        
                    this.ContractorsButtonsButton.Button.Click += ContractorsButtonsButton_Click;
                        
                    this.ContractorsFiltersButton.Button.Click += ContractorsFiltersButton_Click;
                                
        
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
                      Type myrec = typeof(IPv5.Business.ContractorsRecord);
                      this.DataSource = (ContractorsRecord[])(alist.ToArray(myrec));
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
                    foreach (ContractorsTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(IPv5.Business.ContractorsRecord);
                    this.DataSource = (ContractorsRecord[])(postdata.ToArray(myrec));
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
        
        public virtual ContractorsRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(ContractorsTable.Column1, true);          
            // selCols.Add(ContractorsTable.Column2, true);          
            // selCols.Add(ContractorsTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return ContractorsTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                ContractorsTable databaseTable = new ContractorsTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(ContractorsRecord)) as ContractorsRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(ContractorsTable.Column1, true);          
            // selCols.Add(ContractorsTable.Column2, true);          
            // selCols.Add(ContractorsTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return ContractorsTable.GetRecordCount(join, where);
            else
            {
                ContractorsTable databaseTable = new ContractorsTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContractorsTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            ContractorsTableControlRow recControl = (ContractorsTableControlRow)(repItem.FindControl("ContractorsTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                SetAddress1SortLabel2();
                SetAddress2SortLabel2();
                SetCellPhoneSortLabel1();
                SetCompanyNameSortLabel1();
                SetContactNameSortLabel1();
                SetContractorIDSortLabel();
                
                
                
                
                
                
                
                SeteMailSortLabel2();
                SetLandPhoneSortLabel1();
                SetPostCodeSortLabel2();
                SetServiceTypeIDSortLabel1();
                SetContractorsAddButton();
              
                SetContractorsDeleteButton();
              
                SetContractorsButtonsButton();
              
                SetContractorsFiltersButton();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetContractorsFiltersButton();
                     
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        

        public virtual void RegisterPostback()
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
                this.ContractorsPagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.ContractorsPagination.CurrentPage.Text = "0";
            }
            this.ContractorsPagination.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for ContractorsTableControl pagination.
        
            this.ContractorsPagination.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.ContractorsPagination.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.ContractorsPagination.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.ContractorsPagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.ContractorsPagination.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.ContractorsPagination.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.ContractorsPagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.ContractorsPagination.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (ContractorsTableControlRow recCtl in this.GetRecordControls())
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
            foreach (ContractorsTableControlRow recCtl in this.GetRecordControls()){
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
            ContractorsTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    IPv5.UI.Controls.AddCities.CitiesRecordControl citiesRecordControlObj = (MiscUtils.FindControlRecursively(this.Page , "CitiesRecordControl") as IPv5.UI.Controls.AddCities.CitiesRecordControl);
          
              if (citiesRecordControlObj != null && citiesRecordControlObj.GetRecord() != null && citiesRecordControlObj.GetRecord().IsCreated)
              {
              wc.iAND(ContractorsTable.CityID, BaseFilter.ComparisonOperator.EqualsTo, citiesRecordControlObj.GetRecord().CityID.ToString());
              selectedRecordKeyValue.AddElement(ContractorsTable.CityID.InternalName, citiesRecordControlObj.GetRecord().CityID.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["ContractorsTableControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
         
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            ContractorsTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInCitiesRecordControl = HttpContext.Current.Session["ContractorsTableControlWhereClause"] as string;
      
      if (selectedRecordInCitiesRecordControl != null && KeyValue.IsXmlKey(selectedRecordInCitiesRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInCitiesRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(ContractorsTable.CityID))
      {
      wc.iAND(ContractorsTable.CityID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(ContractorsTable.CityID).ToString());
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
        
            if (this.ContractorsPagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.ContractorsPagination.PageSize.Text);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContractorsTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                ContractorsTableControlRow recControl = (ContractorsTableControlRow)(repItem.FindControl("ContractorsTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      ContractorsRecord rec = new ContractorsRecord();
        
                        if (recControl.Address12.Text != "") {
                            rec.Parse(recControl.Address12.Text, ContractorsTable.Address1);
                  }
                
                        if (recControl.Address22.Text != "") {
                            rec.Parse(recControl.Address22.Text, ContractorsTable.Address2);
                  }
                
                        if (recControl.CellPhone1.Text != "") {
                            rec.Parse(recControl.CellPhone1.Text, ContractorsTable.CellPhone);
                  }
                
                        if (recControl.CompanyName1.Text != "") {
                            rec.Parse(recControl.CompanyName1.Text, ContractorsTable.CompanyName);
                  }
                
                        if (recControl.ContactName1.Text != "") {
                            rec.Parse(recControl.ContactName1.Text, ContractorsTable.ContactName);
                  }
                
                        if (recControl.ContractorID.Text != "") {
                            rec.Parse(recControl.ContractorID.Text, ContractorsTable.ContractorID);
                  }
                
                        if (recControl.eMail2.Text != "") {
                            rec.Parse(recControl.eMail2.Text, ContractorsTable.eMail);
                  }
                
                        if (recControl.LandPhone1.Text != "") {
                            rec.Parse(recControl.LandPhone1.Text, ContractorsTable.LandPhone);
                  }
                
                        if (recControl.PostCode2.Text != "") {
                            rec.Parse(recControl.PostCode2.Text, ContractorsTable.PostCode);
                  }
                
                        if (recControl.ServiceTypeID1.Text != "") {
                            rec.Parse(recControl.ServiceTypeID1.Text, ContractorsTable.ServiceTypeID);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new ContractorsRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(IPv5.Business.ContractorsRecord);
                this.DataSource = (ContractorsRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(ContractorsTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(ContractorsTableControlRow rec)            
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
        
        public virtual void SetAddress1SortLabel2()
                  {
                  
                    
        }
                
        public virtual void SetAddress2SortLabel2()
                  {
                  
                    
        }
                
        public virtual void SetCellPhoneSortLabel1()
                  {
                  
                    
        }
                
        public virtual void SetCompanyNameSortLabel1()
                  {
                  
                    
        }
                
        public virtual void SetContactNameSortLabel1()
                  {
                  
                    
        }
                
        public virtual void SetContractorIDSortLabel()
                  {
                  
                    
        }
                
        public virtual void SeteMailSortLabel2()
                  {
                  
                    
        }
                
        public virtual void SetLandPhoneSortLabel1()
                  {
                  
                    
        }
                
        public virtual void SetPostCodeSortLabel2()
                  {
                  
                    
        }
                
        public virtual void SetServiceTypeIDSortLabel1()
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
                    bool added = (this.AddNewRecord > 0);
                    this.LoadData();
                    this.DataBind();					
                    
                    if (added) this.SetFocusToAddedRow();
                }
                                
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            protected virtual void SetFocusToAddedRow()
            {
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("ContractorsTableControlRepeater");
            if (rep == null || rep.Items.Count == 0) return; 			
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items) {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                ContractorsTableControlRow recControl = (ContractorsTableControlRow)repItem.FindControl("ContractorsTableControlRow");
                if(recControl.IsNewRecord) {
                    foreach (Control field in recControl.Controls) {
                    if (field.Visible && this.Page.IsControlEditable(field, false)) {
                        //set focus on the first editable field in the new row
                        field.Focus();
                        UpdatePanel updPan = (UpdatePanel)this.Page.FindControlRecursively("UpdatePanel1");
                        if (updPan != null) updPan.Update();
                        return;
                        }
                    }
                    return;
                }
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

            string orderByStr = (string)ViewState["ContractorsTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("ContractorsPagination");
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
                this.ViewState["ContractorsTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetContractorsAddButton()                
              
        {
        
   
        }
            
        public virtual void SetContractorsDeleteButton()                
              
        {
        
   
        }
            
        public virtual void SetContractorsButtonsButton()                
              
        {
        
   
        }
            
        public virtual void SetContractorsFiltersButton()                
              
        {
                
         IThemeButtonWithArrow themeButtonContractorsFiltersButton = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "ContractorsFiltersButton"));
         themeButtonContractorsFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
   
        }
               
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void ContractorsPagination_FirstPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void ContractorsPagination_LastPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void ContractorsPagination_NextPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void ContractorsPagination_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.ContractorsPagination.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.ContractorsPagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void ContractorsPagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
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
        
        public virtual void Address1SortLabel2_Click(object sender, EventArgs args)
        {
            //Sorts by Address1 when clicked.
              
            // Get previous sorting state for Address1.
        
            OrderByItem sd = this.CurrentSortOrder.Find(ContractorsTable.Address1);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Address1.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(ContractorsTable.Address1, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by Address1, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void Address2SortLabel2_Click(object sender, EventArgs args)
        {
            //Sorts by Address2 when clicked.
              
            // Get previous sorting state for Address2.
        
            OrderByItem sd = this.CurrentSortOrder.Find(ContractorsTable.Address2);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Address2.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(ContractorsTable.Address2, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by Address2, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void CellPhoneSortLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by CellPhone when clicked.
              
            // Get previous sorting state for CellPhone.
        
            OrderByItem sd = this.CurrentSortOrder.Find(ContractorsTable.CellPhone);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for CellPhone.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(ContractorsTable.CellPhone, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by CellPhone, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void CompanyNameSortLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by CompanyName when clicked.
              
            // Get previous sorting state for CompanyName.
        
            OrderByItem sd = this.CurrentSortOrder.Find(ContractorsTable.CompanyName);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for CompanyName.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(ContractorsTable.CompanyName, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by CompanyName, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void ContactNameSortLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by ContactName when clicked.
              
            // Get previous sorting state for ContactName.
        
            OrderByItem sd = this.CurrentSortOrder.Find(ContractorsTable.ContactName);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for ContactName.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(ContractorsTable.ContactName, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by ContactName, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void ContractorIDSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by ContractorID when clicked.
              
            // Get previous sorting state for ContractorID.
        
            OrderByItem sd = this.CurrentSortOrder.Find(ContractorsTable.ContractorID);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for ContractorID.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(ContractorsTable.ContractorID, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by ContractorID, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void eMailSortLabel2_Click(object sender, EventArgs args)
        {
            //Sorts by eMail when clicked.
              
            // Get previous sorting state for eMail.
        
            OrderByItem sd = this.CurrentSortOrder.Find(ContractorsTable.eMail);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for eMail.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(ContractorsTable.eMail, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by eMail, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void LandPhoneSortLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by LandPhone when clicked.
              
            // Get previous sorting state for LandPhone.
        
            OrderByItem sd = this.CurrentSortOrder.Find(ContractorsTable.LandPhone);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for LandPhone.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(ContractorsTable.LandPhone, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by LandPhone, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void PostCodeSortLabel2_Click(object sender, EventArgs args)
        {
            //Sorts by PostCode when clicked.
              
            // Get previous sorting state for PostCode.
        
            OrderByItem sd = this.CurrentSortOrder.Find(ContractorsTable.PostCode);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for PostCode.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(ContractorsTable.PostCode, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by PostCode, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void ServiceTypeIDSortLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by ServiceTypeID when clicked.
              
            // Get previous sorting state for ServiceTypeID.
        
            OrderByItem sd = this.CurrentSortOrder.Find(ContractorsTable.ServiceTypeID);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for ServiceTypeID.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(ContractorsTable.ServiceTypeID, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by ServiceTypeID, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void ContractorsAddButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            this.AddNewRecord = 1;
            this.DataChanged = true;
      
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
        public virtual void ContractorsDeleteButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
                this.DeleteSelectedRecords(true);
                this.SetFormulaControls();
          
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
            
            
        
        // event handler for Button
        public virtual void ContractorsButtonsButton_Click(object sender, EventArgs args)
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
        public virtual void ContractorsFiltersButton_Click(object sender, EventArgs args)
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
                    _TotalRecords = ContractorsTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  ContractorsRecord[] DataSource {
             
            get {
                return (ContractorsRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public System.Web.UI.WebControls.LinkButton Address1SortLabel2 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address1SortLabel2");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton Address2SortLabel2 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address2SortLabel2");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton CellPhoneSortLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CellPhoneSortLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton CompanyNameSortLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CompanyNameSortLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ContactNameSortLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactNameSortLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ContractorIDSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContractorIDSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ContractorsAddButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContractorsAddButton");
            }
        }
        
        public IPv5.UI.IThemeButtonWithArrow ContractorsButtonsButton {
            get {
                return (IPv5.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContractorsButtonsButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton ContractorsDeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContractorsDeleteButton");
            }
        }
        
        public IPv5.UI.IThemeButtonWithArrow ContractorsFiltersButton {
            get {
                return (IPv5.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContractorsFiltersButton");
            }
        }
        
        public IPv5.UI.IPaginationModern ContractorsPagination {
            get {
                return (IPv5.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContractorsPagination");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox ContractorsToggleAll {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContractorsToggleAll");
            }
        }              
            
        public System.Web.UI.WebControls.LinkButton eMailSortLabel2 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "eMailSortLabel2");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton LandPhoneSortLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LandPhoneSortLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton PostCodeSortLabel2 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PostCodeSortLabel2");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ServiceTypeIDSortLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServiceTypeIDSortLabel1");
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
                ContractorsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IPv5"));
                }

        ContractorsRecord rec = null;
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
                ContractorsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IPv5"));
                }

        ContractorsRecord rec = null;
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
          
        public virtual int GetSelectedRecordIndex()
        {
            int counter = 0;
            foreach (ContractorsTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.ContractorsRecordRowSelection.Checked) {
                    return counter;
                }
                counter += 1;
            }
            return -1;
        }
        
        public virtual ContractorsTableControlRow GetSelectedRecordControl()
        {
        ContractorsTableControlRow[] selectedList = this.GetSelectedRecordControls();
            if (selectedList.Length == 0) {
            return null;
            }
            return selectedList[0];
          
        }

        public virtual ContractorsTableControlRow[] GetSelectedRecordControls()
        {
        
            ArrayList selectedList = new ArrayList(25);
            foreach (ContractorsTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.ContractorsRecordRowSelection != null && recControl.ContractorsRecordRowSelection.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (ContractorsTableControlRow[])(selectedList.ToArray(Type.GetType("IPv5.UI.Controls.AddCities.ContractorsTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            ContractorsTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IPv5"));
            }
            
            foreach (ContractorsTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                    recCtl.ContractorsRecordRowSelection.Checked = false;
                
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

        public virtual ContractorsTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "ContractorsTableControlRow");
	          List<ContractorsTableControlRow> list = new List<ContractorsTableControlRow>();
	          foreach (ContractorsTableControlRow recCtrl in recCtrls) {
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
  
// Base class for the PropertyContactsTableControlRow control on the AddCities page.
// Do not modify this class. Instead override any method in PropertyContactsTableControlRow.
public class BasePropertyContactsTableControlRow : IPv5.UI.BaseApplicationRecordControl
{
        public BasePropertyContactsTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in PropertyContactsTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in PropertyContactsTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.PropertyContactsRowDeleteButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "IPv5") + "\"));");            
        
              // Register the event handlers.

          
                    this.ContactTypeIDAddRecordLink.Click += ContactTypeIDAddRecordLink_Click;
                        
                    this.CountryIDAddRecordLink.Click += CountryIDAddRecordLink_Click;
                        
                    this.PropertyContactsRowDeleteButton.Click += PropertyContactsRowDeleteButton_Click;
                        
                    this.PropertyIDAddRecordLink.Click += PropertyIDAddRecordLink_Click;
                        
                    this.RegionIDAddRecordLink.Click += RegionIDAddRecordLink_Click;
                        
              this.ContactTypeID.SelectedIndexChanged += ContactTypeID_SelectedIndexChanged;
            
              this.CountryID.SelectedIndexChanged += CountryID_SelectedIndexChanged;
            
              this.PropertyID.SelectedIndexChanged += PropertyID_SelectedIndexChanged;
            
              this.RegionID.SelectedIndexChanged += RegionID_SelectedIndexChanged;
            
              this.Address11.TextChanged += Address11_TextChanged;
            
              this.Address21.TextChanged += Address21_TextChanged;
            
              this.Address3.TextChanged += Address3_TextChanged;
            
              this.eMail1.TextChanged += eMail1_TextChanged;
            
              this.FirstName.TextChanged += FirstName_TextChanged;
            
              this.LastName.TextChanged += LastName_TextChanged;
            
              this.PostCode1.TextChanged += PostCode1_TextChanged;
            
              this.Title.TextChanged += Title_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseMM_IP1%dbo.PropertyContacts record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = PropertyContactsTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BasePropertyContactsTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new PropertyContactsRecord();
            
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
                SetAddress3();
                SetAddress3Label();
                SetContactTypeID();
                
                SetContactTypeIDLabel();
                SetCountryID();
                
                SetCountryIDLabel();
                SeteMail1();
                SeteMailLabel1();
                SetFirstName();
                SetFirstNameLabel();
                SetLastName();
                SetLastNameLabel();
                SetPostCode1();
                SetPostCodeLabel1();
                
                
                SetPropertyID();
                
                SetPropertyIDLabel();
                SetRegionID();
                
                SetRegionIDLabel();
                SetTitle();
                SetTitleLabel();
                SetContactTypeIDAddRecordLink();
              
                SetCountryIDAddRecordLink();
              
                SetPropertyContactsRowDeleteButton();
              
                SetPropertyIDAddRecordLink();
              
                SetRegionIDAddRecordLink();
              

      

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
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.Address11.ID))
            {
            
                this.Address11.Text = this.PreviousUIData[this.Address11.ID].ToString();
              
                return;
            }
            
                    
            // Set the Address1 TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.PropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.PropertyContacts record retrieved from the database.
            // this.Address11 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address1Specified) {
                								
                // If the Address1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(PropertyContactsTable.Address1);
                                
                this.Address11.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address11.Text = PropertyContactsTable.Address1.Format(PropertyContactsTable.Address1.DefaultValue);
            		
            }
            
              this.Address11.TextChanged += Address11_TextChanged;
                               
        }
                
        public virtual void SetAddress21()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.Address21.ID))
            {
            
                this.Address21.Text = this.PreviousUIData[this.Address21.ID].ToString();
              
                return;
            }
            
                    
            // Set the Address2 TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.PropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.PropertyContacts record retrieved from the database.
            // this.Address21 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address2Specified) {
                								
                // If the Address2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(PropertyContactsTable.Address2);
                                
                this.Address21.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address21.Text = PropertyContactsTable.Address2.Format(PropertyContactsTable.Address2.DefaultValue);
            		
            }
            
              this.Address21.TextChanged += Address21_TextChanged;
                               
        }
                
        public virtual void SetAddress3()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.Address3.ID))
            {
            
                this.Address3.Text = this.PreviousUIData[this.Address3.ID].ToString();
              
                return;
            }
            
                    
            // Set the Address3 TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.PropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.PropertyContacts record retrieved from the database.
            // this.Address3 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address3Specified) {
                								
                // If the Address3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(PropertyContactsTable.Address3);
                                
                this.Address3.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address3.Text = PropertyContactsTable.Address3.Format(PropertyContactsTable.Address3.DefaultValue);
            		
            }
            
              this.Address3.TextChanged += Address3_TextChanged;
                               
        }
                
        public virtual void SetContactTypeID()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ContactTypeID.ID))
            {
                if (this.PreviousUIData[this.ContactTypeID.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.ContactTypeID.ID].ToString();
            }
            
            
            // Set the ContactTypeID DropDownList on the webpage with value from the
            // DatabaseMM_IP1%dbo.PropertyContacts database record.
            
            // this.DataSource is the DatabaseMM_IP1%dbo.PropertyContacts record retrieved from the database.
            // this.ContactTypeID is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetContactTypeID();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.ContactTypeIDSpecified)
            {
                            
                // If the ContactTypeID is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.ContactTypeID.ToString();
                
            }
            else
            {
                
                // ContactTypeID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = PropertyContactsTable.ContactTypeID.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateContactTypeIDDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetCountryID()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CountryID.ID))
            {
                if (this.PreviousUIData[this.CountryID.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.CountryID.ID].ToString();
            }
            
            
            // Set the CountryID DropDownList on the webpage with value from the
            // DatabaseMM_IP1%dbo.PropertyContacts database record.
            
            // this.DataSource is the DatabaseMM_IP1%dbo.PropertyContacts record retrieved from the database.
            // this.CountryID is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetCountryID();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.CountryIDSpecified)
            {
                            
                // If the CountryID is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.CountryID.ToString();
                
            }
            else
            {
                
                // CountryID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = PropertyContactsTable.CountryID.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateCountryIDDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SeteMail1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.eMail1.ID))
            {
            
                this.eMail1.Text = this.PreviousUIData[this.eMail1.ID].ToString();
              
                return;
            }
            
                    
            // Set the eMail TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.PropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.PropertyContacts record retrieved from the database.
            // this.eMail1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.eMailSpecified) {
                								
                // If the eMail is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(PropertyContactsTable.eMail);
                                
                this.eMail1.Text = formattedValue;
                   
            } 
            
            else {
            
                // eMail is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.eMail1.Text = PropertyContactsTable.eMail.Format(PropertyContactsTable.eMail.DefaultValue);
            		
            }
            
              this.eMail1.TextChanged += eMail1_TextChanged;
                               
        }
                
        public virtual void SetFirstName()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.FirstName.ID))
            {
            
                this.FirstName.Text = this.PreviousUIData[this.FirstName.ID].ToString();
              
                return;
            }
            
                    
            // Set the FirstName TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.PropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.PropertyContacts record retrieved from the database.
            // this.FirstName is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.FirstNameSpecified) {
                								
                // If the FirstName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(PropertyContactsTable.FirstName);
                                
                this.FirstName.Text = formattedValue;
                   
            } 
            
            else {
            
                // FirstName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.FirstName.Text = PropertyContactsTable.FirstName.Format(PropertyContactsTable.FirstName.DefaultValue);
            		
            }
            
              this.FirstName.TextChanged += FirstName_TextChanged;
                               
        }
                
        public virtual void SetLastName()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.LastName.ID))
            {
            
                this.LastName.Text = this.PreviousUIData[this.LastName.ID].ToString();
              
                return;
            }
            
                    
            // Set the LastName TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.PropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.PropertyContacts record retrieved from the database.
            // this.LastName is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.LastNameSpecified) {
                								
                // If the LastName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(PropertyContactsTable.LastName);
                                
                this.LastName.Text = formattedValue;
                   
            } 
            
            else {
            
                // LastName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.LastName.Text = PropertyContactsTable.LastName.Format(PropertyContactsTable.LastName.DefaultValue);
            		
            }
            
              this.LastName.TextChanged += LastName_TextChanged;
                               
        }
                
        public virtual void SetPostCode1()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.PostCode1.ID))
            {
            
                this.PostCode1.Text = this.PreviousUIData[this.PostCode1.ID].ToString();
              
                return;
            }
            
                    
            // Set the PostCode TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.PropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.PropertyContacts record retrieved from the database.
            // this.PostCode1 is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PostCodeSpecified) {
                								
                // If the PostCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(PropertyContactsTable.PostCode);
                                
                this.PostCode1.Text = formattedValue;
                   
            } 
            
            else {
            
                // PostCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PostCode1.Text = PropertyContactsTable.PostCode.Format(PropertyContactsTable.PostCode.DefaultValue);
            		
            }
            
              this.PostCode1.TextChanged += PostCode1_TextChanged;
                               
        }
                
        public virtual void SetPropertyID()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.PropertyID.ID))
            {
                if (this.PreviousUIData[this.PropertyID.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.PropertyID.ID].ToString();
            }
            
            
            // Set the PropertyID DropDownList on the webpage with value from the
            // DatabaseMM_IP1%dbo.PropertyContacts database record.
            
            // this.DataSource is the DatabaseMM_IP1%dbo.PropertyContacts record retrieved from the database.
            // this.PropertyID is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetPropertyID();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.PropertyIDSpecified)
            {
                            
                // If the PropertyID is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.PropertyID.ToString();
                
            }
            else
            {
                
                // PropertyID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = PropertyContactsTable.PropertyID.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulatePropertyIDDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetRegionID()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RegionID.ID))
            {
                if (this.PreviousUIData[this.RegionID.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.RegionID.ID].ToString();
            }
            
            
            // Set the RegionID DropDownList on the webpage with value from the
            // DatabaseMM_IP1%dbo.PropertyContacts database record.
            
            // this.DataSource is the DatabaseMM_IP1%dbo.PropertyContacts record retrieved from the database.
            // this.RegionID is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetRegionID();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.RegionIDSpecified)
            {
                            
                // If the RegionID is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.RegionID.ToString();
                
            }
            else
            {
                
                // RegionID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = PropertyContactsTable.RegionID.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateRegionIDDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetTitle()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.Title.ID))
            {
            
                this.Title.Text = this.PreviousUIData[this.Title.ID].ToString();
              
                return;
            }
            
                    
            // Set the Title TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.PropertyContacts database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.PropertyContacts record retrieved from the database.
            // this.Title is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Title0Specified) {
                								
                // If the Title is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(PropertyContactsTable.Title0);
                                
                this.Title.Text = formattedValue;
                   
            } 
            
            else {
            
                // Title is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Title.Text = PropertyContactsTable.Title0.Format(PropertyContactsTable.Title0.DefaultValue);
            		
            }
            
              this.Title.TextChanged += Title_TextChanged;
                               
        }
                
        public virtual void SetAddress1Label1()
                  {
                  
                    
        }
                
        public virtual void SetAddress2Label1()
                  {
                  
                    
        }
                
        public virtual void SetAddress3Label()
                  {
                  
                    
        }
                
        public virtual void SetContactTypeIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetCountryIDLabel()
                  {
                  
                    
        }
                
        public virtual void SeteMailLabel1()
                  {
                  
                    
        }
                
        public virtual void SetFirstNameLabel()
                  {
                  
                    
        }
                
        public virtual void SetLastNameLabel()
                  {
                  
                    
        }
                
        public virtual void SetPostCodeLabel1()
                  {
                  
                    
        }
                
        public virtual void SetPropertyIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetRegionIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetTitleLabel()
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
        CitiesRecordControl parentCtrl;
      
            parentCtrl = (CitiesRecordControl)this.Page.FindControlRecursively("CitiesRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "IPv5"));
        }
        
          this.DataSource.CityID = parentCtrl.DataSource.CityID;
        
          
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
                ((PropertyContactsTableControl)MiscUtils.GetParentControlObject(this, "PropertyContactsTableControl")).DataChanged = true;
                ((PropertyContactsTableControl)MiscUtils.GetParentControlObject(this, "PropertyContactsTableControl")).ResetData = true;
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
            GetAddress3();
            GetContactTypeID();
            GetCountryID();
            GeteMail1();
            GetFirstName();
            GetLastName();
            GetPostCode1();
            GetPropertyID();
            GetRegionID();
            GetTitle();
        }
        
        
        public virtual void GetAddress11()
        {
            
            // Retrieve the value entered by the user on the Address1 ASP:TextBox, and
            // save it into the Address1 field in DataSource DatabaseMM_IP1%dbo.PropertyContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.Address11.Text, PropertyContactsTable.Address1);							
                          
                      
        }
                
        public virtual void GetAddress21()
        {
            
            // Retrieve the value entered by the user on the Address2 ASP:TextBox, and
            // save it into the Address2 field in DataSource DatabaseMM_IP1%dbo.PropertyContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.Address21.Text, PropertyContactsTable.Address2);							
                          
                      
        }
                
        public virtual void GetAddress3()
        {
            
            // Retrieve the value entered by the user on the Address3 ASP:TextBox, and
            // save it into the Address3 field in DataSource DatabaseMM_IP1%dbo.PropertyContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.Address3.Text, PropertyContactsTable.Address3);							
                          
                      
        }
                
        public virtual void GetContactTypeID()
        {
         // Retrieve the value entered by the user on the ContactTypeID ASP:DropDownList, and
            // save it into the ContactTypeID field in DataSource DatabaseMM_IP1%dbo.PropertyContacts record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.ContactTypeID), PropertyContactsTable.ContactTypeID);			
                			 
        }
                
        public virtual void GetCountryID()
        {
         // Retrieve the value entered by the user on the CountryID ASP:DropDownList, and
            // save it into the CountryID field in DataSource DatabaseMM_IP1%dbo.PropertyContacts record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.CountryID), PropertyContactsTable.CountryID);			
                			 
        }
                
        public virtual void GeteMail1()
        {
            
            // Retrieve the value entered by the user on the eMail ASP:TextBox, and
            // save it into the eMail field in DataSource DatabaseMM_IP1%dbo.PropertyContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.eMail1.Text, PropertyContactsTable.eMail);							
                          
                      
        }
                
        public virtual void GetFirstName()
        {
            
            // Retrieve the value entered by the user on the FirstName ASP:TextBox, and
            // save it into the FirstName field in DataSource DatabaseMM_IP1%dbo.PropertyContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.FirstName.Text, PropertyContactsTable.FirstName);							
                          
                      
        }
                
        public virtual void GetLastName()
        {
            
            // Retrieve the value entered by the user on the LastName ASP:TextBox, and
            // save it into the LastName field in DataSource DatabaseMM_IP1%dbo.PropertyContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.LastName.Text, PropertyContactsTable.LastName);							
                          
                      
        }
                
        public virtual void GetPostCode1()
        {
            
            // Retrieve the value entered by the user on the PostCode ASP:TextBox, and
            // save it into the PostCode field in DataSource DatabaseMM_IP1%dbo.PropertyContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.PostCode1.Text, PropertyContactsTable.PostCode);							
                          
                      
        }
                
        public virtual void GetPropertyID()
        {
         // Retrieve the value entered by the user on the PropertyID ASP:DropDownList, and
            // save it into the PropertyID field in DataSource DatabaseMM_IP1%dbo.PropertyContacts record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.PropertyID), PropertyContactsTable.PropertyID);			
                			 
        }
                
        public virtual void GetRegionID()
        {
         // Retrieve the value entered by the user on the RegionID ASP:DropDownList, and
            // save it into the RegionID field in DataSource DatabaseMM_IP1%dbo.PropertyContacts record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.RegionID), PropertyContactsTable.RegionID);			
                			 
        }
                
        public virtual void GetTitle()
        {
            
            // Retrieve the value entered by the user on the Title ASP:TextBox, and
            // save it into the Title field in DataSource DatabaseMM_IP1%dbo.PropertyContacts record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.Title.Text, PropertyContactsTable.Title0);							
                          
                      
        }
                

      // To customize, override this method in PropertyContactsTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersCitiesRecordControl = false;
            hasFiltersCitiesRecordControl = hasFiltersCitiesRecordControl && false; // suppress warning
      
            bool hasFiltersContractorsTableControl = false;
            hasFiltersContractorsTableControl = hasFiltersContractorsTableControl && false; // suppress warning
      
            bool hasFiltersPropertyContactsTableControl = false;
            hasFiltersPropertyContactsTableControl = hasFiltersPropertyContactsTableControl && false; // suppress warning
      
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
          PropertyContactsTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((PropertyContactsTableControl)MiscUtils.GetParentControlObject(this, "PropertyContactsTableControl")).DataChanged = true;
            ((PropertyContactsTableControl)MiscUtils.GetParentControlObject(this, "PropertyContactsTableControl")).ResetData = true;
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
        
        public virtual void SetContactTypeIDAddRecordLink()                
              
        {
        
              try
              {
                    string url = "../ContactTypes/AddContactTypes.aspx";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "?RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("NewWindow") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(this.ContactTypeID.ClientID) + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("ContactType")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("ContactTypeID");                      
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializeNewWindow(this, '" + url + "', false, event);";                  
                       
                    this.ContactTypeIDAddRecordLink.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, ContactTypeIDAddRecordLink_ClickContactTypeIDAddRecordLink_Click will be trigger when user click the button.
                }
                  
   
        }
            
        public virtual void SetCountryIDAddRecordLink()                
              
        {
        
              try
              {
                    string url = "../Countries/AddCountries.aspx";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "?RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("NewWindow") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(this.CountryID.ClientID) + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("Country")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("CountryID");                      
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializeNewWindow(this, '" + url + "', false, event);";                  
                       
                    this.CountryIDAddRecordLink.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, CountryIDAddRecordLink_ClickCountryIDAddRecordLink_Click will be trigger when user click the button.
                }
                  
   
        }
            
        public virtual void SetPropertyContactsRowDeleteButton()                
              
        {
        
   
        }
            
        public virtual void SetPropertyIDAddRecordLink()                
              
        {
        
              try
              {
                    string url = "../Properties/AddProperties.aspx";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "?RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("NewWindow") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(this.PropertyID.ClientID) + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("CompanyName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("PropertyID");                      
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializeNewWindow(this, '" + url + "', false, event);";                  
                       
                    this.PropertyIDAddRecordLink.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, PropertyIDAddRecordLink_ClickPropertyIDAddRecordLink_Click will be trigger when user click the button.
                }
                  
   
        }
            
        public virtual void SetRegionIDAddRecordLink()                
              
        {
        
              try
              {
                    string url = "../Regions/AddRegions.aspx";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "?RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("NewWindow") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(this.RegionID.ClientID) + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("Region")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("RegionID");                      
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializeNewWindow(this, '" + url + "', false, event);";                  
                       
                    this.RegionIDAddRecordLink.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, RegionIDAddRecordLink_ClickRegionIDAddRecordLink_Click will be trigger when user click the button.
                }
                  
   
        }
            
        public virtual WhereClause CreateWhereClause_ContactTypeIDDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseMM_IP1%dbo.ContactTypes table.
            // Examples:
            // wc.iAND(ContactTypesTable.ContactType, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(ContactTypesTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_CountryIDDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseMM_IP1%dbo.Countries table.
            // Examples:
            // wc.iAND(CountriesTable.Country, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(CountriesTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_PropertyIDDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseMM_IP1%dbo.Properties table.
            // Examples:
            // wc.iAND(PropertiesTable.CompanyName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(PropertiesTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_RegionIDDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseMM_IP1%dbo.Regions table.
            // Examples:
            // wc.iAND(RegionsTable.Region, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(RegionsTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        // Fill the ContactTypeID list.
        protected virtual void PopulateContactTypeIDDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.ContactTypeID.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.ContactTypeID.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "IPv5"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_ContactTypeIDDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_ContactTypeIDDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(ContactTypesTable.ContactType, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the ContactTypeIDDropDownList.
            ContactTypesRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = ContactTypesTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (ContactTypesRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.ContactTypeIDSpecified) 
                        {
                            cvalue = itemValue.ContactTypeID.ToString().ToString();
                            if (counter < maxItems && this.ContactTypeID.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = PropertyContactsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(PropertyContactsTable.ContactTypeID);
                                if(_isExpandableNonCompositeForeignKey && PropertyContactsTable.ContactTypeID.IsApplyDisplayAs)
                                    fvalue = PropertyContactsTable.GetDFKA(itemValue, PropertyContactsTable.ContactTypeID);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(ContactTypesTable.ContactType);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.ContactTypeID.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.ContactTypeID.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.ContactTypeID, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.ContactTypeID, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseMM_IP1%dbo.ContactTypes.ContactTypeID = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(ContactTypesTable.ContactTypeID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    ContactTypesRecord[] rc = ContactTypesTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        ContactTypesRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.ContactTypeIDSpecified)
                            cvalue = itemValue.ContactTypeID.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = PropertyContactsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(PropertyContactsTable.ContactTypeID);
                        if(_isExpandableNonCompositeForeignKey && PropertyContactsTable.ContactTypeID.IsApplyDisplayAs)
                            fvalue = PropertyContactsTable.GetDFKA(itemValue, PropertyContactsTable.ContactTypeID);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(ContactTypesTable.ContactType);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.ContactTypeID, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the CountryID list.
        protected virtual void PopulateCountryIDDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.CountryID.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.CountryID.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "IPv5"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_CountryIDDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_CountryIDDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CountriesTable.Country, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the CountryIDDropDownList.
            CountriesRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = CountriesTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (CountriesRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.CountryIDSpecified) 
                        {
                            cvalue = itemValue.CountryID.ToString().ToString();
                            if (counter < maxItems && this.CountryID.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = PropertyContactsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(PropertyContactsTable.CountryID);
                                if(_isExpandableNonCompositeForeignKey && PropertyContactsTable.CountryID.IsApplyDisplayAs)
                                    fvalue = PropertyContactsTable.GetDFKA(itemValue, PropertyContactsTable.CountryID);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(CountriesTable.Country);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.CountryID.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.CountryID.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.CountryID, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.CountryID, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseMM_IP1%dbo.Countries.CountryID = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(CountriesTable.CountryID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    CountriesRecord[] rc = CountriesTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        CountriesRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.CountryIDSpecified)
                            cvalue = itemValue.CountryID.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = PropertyContactsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(PropertyContactsTable.CountryID);
                        if(_isExpandableNonCompositeForeignKey && PropertyContactsTable.CountryID.IsApplyDisplayAs)
                            fvalue = PropertyContactsTable.GetDFKA(itemValue, PropertyContactsTable.CountryID);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(CountriesTable.Country);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.CountryID, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the PropertyID list.
        protected virtual void PopulatePropertyIDDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.PropertyID.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.PropertyID.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "IPv5"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_PropertyIDDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_PropertyIDDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(PropertiesTable.CompanyName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the PropertyIDDropDownList.
            PropertiesRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
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
                            cvalue = itemValue.PropertyID.ToString().ToString();
                            if (counter < maxItems && this.PropertyID.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = PropertyContactsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(PropertyContactsTable.PropertyID);
                                if(_isExpandableNonCompositeForeignKey && PropertyContactsTable.PropertyID.IsApplyDisplayAs)
                                    fvalue = PropertyContactsTable.GetDFKA(itemValue, PropertyContactsTable.PropertyID);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(PropertiesTable.CompanyName);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.PropertyID.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.PropertyID.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.PropertyID, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.PropertyID, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseMM_IP1%dbo.Properties.PropertyID = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(PropertiesTable.PropertyID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    PropertiesRecord[] rc = PropertiesTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        PropertiesRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.PropertyIDSpecified)
                            cvalue = itemValue.PropertyID.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = PropertyContactsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(PropertyContactsTable.PropertyID);
                        if(_isExpandableNonCompositeForeignKey && PropertyContactsTable.PropertyID.IsApplyDisplayAs)
                            fvalue = PropertyContactsTable.GetDFKA(itemValue, PropertyContactsTable.PropertyID);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(PropertiesTable.CompanyName);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.PropertyID, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the RegionID list.
        protected virtual void PopulateRegionIDDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.RegionID.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.RegionID.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "IPv5"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_RegionIDDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_RegionIDDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(RegionsTable.Region, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the RegionIDDropDownList.
            RegionsRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = RegionsTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (RegionsRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.RegionIDSpecified) 
                        {
                            cvalue = itemValue.RegionID.ToString().ToString();
                            if (counter < maxItems && this.RegionID.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = PropertyContactsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(PropertyContactsTable.RegionID);
                                if(_isExpandableNonCompositeForeignKey && PropertyContactsTable.RegionID.IsApplyDisplayAs)
                                    fvalue = PropertyContactsTable.GetDFKA(itemValue, PropertyContactsTable.RegionID);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(RegionsTable.Region);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.RegionID.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.RegionID.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.RegionID, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.RegionID, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseMM_IP1%dbo.Regions.RegionID = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(RegionsTable.RegionID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    RegionsRecord[] rc = RegionsTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        RegionsRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.RegionIDSpecified)
                            cvalue = itemValue.RegionID.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = PropertyContactsTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(PropertyContactsTable.RegionID);
                        if(_isExpandableNonCompositeForeignKey && PropertyContactsTable.RegionID.IsApplyDisplayAs)
                            fvalue = PropertyContactsTable.GetDFKA(itemValue, PropertyContactsTable.RegionID);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(RegionsTable.Region);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.RegionID, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // event handler for ImageButton
        public virtual void ContactTypeIDAddRecordLink_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../ContactTypes/AddContactTypes.aspx";
            
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
      
                    url = url + "?RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("NewWindow") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(this.ContactTypeID.ClientID) + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("ContactType")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("ContactTypeID");                      
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializeNewWindow(this, '" + url + "', false, event);";                  
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "ContactTypeIDAddRecordLink_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void CountryIDAddRecordLink_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Countries/AddCountries.aspx";
            
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
      
                    url = url + "?RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("NewWindow") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(this.CountryID.ClientID) + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("Country")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("CountryID");                      
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializeNewWindow(this, '" + url + "', false, event);";                  
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "CountryIDAddRecordLink_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void PropertyContactsRowDeleteButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        PropertyContactsTableControl tc= ((PropertyContactsTableControl)MiscUtils.GetParentControlObject(this, "PropertyContactsTableControl"));
                if (tc != null){
                    if (!this.IsNewRecord){
                        tc.AddToDeletedRecordIds((PropertyContactsTableControlRow)this);
                    }
                    this.Visible = false;
                    tc.SetFormulaControls();                    
                }
              
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
        public virtual void PropertyIDAddRecordLink_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Properties/AddProperties.aspx";
            
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
      
                    url = url + "?RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("NewWindow") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(this.PropertyID.ClientID) + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("CompanyName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("PropertyID");                      
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializeNewWindow(this, '" + url + "', false, event);";                  
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "PropertyIDAddRecordLink_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void RegionIDAddRecordLink_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Regions/AddRegions.aspx";
            
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
      
                    url = url + "?RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("NewWindow") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(this.RegionID.ClientID) + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("Region")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("RegionID");                      
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializeNewWindow(this, '" + url + "', false, event);";                  
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "RegionIDAddRecordLink_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
        protected virtual void ContactTypeID_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[ContactTypeID.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[ContactTypeID.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.ContactTypeID.Items.Add(new ListItem(displayText, val));
	            this.ContactTypeID.SelectedIndex = this.ContactTypeID.Items.Count - 1;
	            this.Page.Session.Remove(ContactTypeID.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(ContactTypeID.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void CountryID_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[CountryID.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[CountryID.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.CountryID.Items.Add(new ListItem(displayText, val));
	            this.CountryID.SelectedIndex = this.CountryID.Items.Count - 1;
	            this.Page.Session.Remove(CountryID.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(CountryID.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void PropertyID_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[PropertyID.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[PropertyID.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.PropertyID.Items.Add(new ListItem(displayText, val));
	            this.PropertyID.SelectedIndex = this.PropertyID.Items.Count - 1;
	            this.Page.Session.Remove(PropertyID.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(PropertyID.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void RegionID_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[RegionID.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[RegionID.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.RegionID.Items.Add(new ListItem(displayText, val));
	            this.RegionID.SelectedIndex = this.RegionID.Items.Count - 1;
	            this.Page.Session.Remove(RegionID.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(RegionID.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void Address11_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void Address21_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void Address3_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void eMail1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void FirstName_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void LastName_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void PostCode1_TextChanged(object sender, EventArgs args)
        {
                    
              }
            
        protected virtual void Title_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BasePropertyContactsTableControlRow_Rec"];
            }
            set {
                this.ViewState["BasePropertyContactsTableControlRow_Rec"] = value;
            }
        }
        
        public PropertyContactsRecord DataSource {
            get {
                return (PropertyContactsRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.TextBox Address11 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address11");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address1Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address1Label1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox Address21 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address21");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address2Label1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address2Label1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox Address3 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address3");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address3Label {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address3Label");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList ContactTypeID {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactTypeID");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton ContactTypeIDAddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactTypeIDAddRecordLink");
            }
        }
        
        public System.Web.UI.WebControls.Literal ContactTypeIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactTypeIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList CountryID {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CountryID");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton CountryIDAddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CountryIDAddRecordLink");
            }
        }
        
        public System.Web.UI.WebControls.Literal CountryIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CountryIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox eMail1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "eMail1");
            }
        }
            
        public System.Web.UI.WebControls.Literal eMailLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "eMailLabel1");
            }
        }
        
        public System.Web.UI.WebControls.TextBox FirstName {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirstName");
            }
        }
            
        public System.Web.UI.WebControls.Literal FirstNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirstNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox LastName {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastName");
            }
        }
            
        public System.Web.UI.WebControls.Literal LastNameLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastNameLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox PostCode1 {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PostCode1");
            }
        }
            
        public System.Web.UI.WebControls.Literal PostCodeLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PostCodeLabel1");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox PropertyContactsRecordRowSelection {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyContactsRecordRowSelection");
            }
        }              
            
        public System.Web.UI.WebControls.ImageButton PropertyContactsRowDeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyContactsRowDeleteButton");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList PropertyID {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyID");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton PropertyIDAddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyIDAddRecordLink");
            }
        }
        
        public System.Web.UI.WebControls.Literal PropertyIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList RegionID {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RegionID");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton RegionIDAddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RegionIDAddRecordLink");
            }
        }
        
        public System.Web.UI.WebControls.Literal RegionIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RegionIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.TextBox Title {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Title");
            }
        }
            
        public System.Web.UI.WebControls.Literal TitleLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TitleLabel");
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
        PropertyContactsRecord rec = null;
             
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
    PropertyContactsRecord rec = null;
    
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

        
        public virtual PropertyContactsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return PropertyContactsTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the PropertyContactsTableControl control on the AddCities page.
// Do not modify this class. Instead override any method in PropertyContactsTableControl.
public class BasePropertyContactsTableControl : IPv5.UI.BaseApplicationTableControl
{
         
       public BasePropertyContactsTableControl()
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
        
              // Show confirmation message on Click
              this.PropertyContactsDeleteButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteConfirm", "IPv5") + "\"));");
            // Setup the pagination events.
            
                    this.PropertyContactsPagination.FirstPage.Click += PropertyContactsPagination_FirstPage_Click;
                        
                    this.PropertyContactsPagination.LastPage.Click += PropertyContactsPagination_LastPage_Click;
                        
                    this.PropertyContactsPagination.NextPage.Click += PropertyContactsPagination_NextPage_Click;
                        
                    this.PropertyContactsPagination.PageSizeButton.Click += PropertyContactsPagination_PageSizeButton_Click;
                        
                    this.PropertyContactsPagination.PreviousPage.Click += PropertyContactsPagination_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
              this.Address1SortLabel1.Click += Address1SortLabel1_Click;
            
              this.Address2SortLabel1.Click += Address2SortLabel1_Click;
            
              this.Address3SortLabel.Click += Address3SortLabel_Click;
            
              this.ContactTypeIDSortLabel.Click += ContactTypeIDSortLabel_Click;
            
              this.eMailSortLabel1.Click += eMailSortLabel1_Click;
            
              this.FirstNameSortLabel.Click += FirstNameSortLabel_Click;
            
              this.LastNameSortLabel.Click += LastNameSortLabel_Click;
            
              this.PostCodeSortLabel1.Click += PostCodeSortLabel1_Click;
            
              this.PropertyIDSortLabel.Click += PropertyIDSortLabel_Click;
            
              this.TitleSortLabel.Click += TitleSortLabel_Click;
            
            // Setup the button events.
          
                    this.PropertyContactsAddButton.Click += PropertyContactsAddButton_Click;
                        
                    this.PropertyContactsDeleteButton.Click += PropertyContactsDeleteButton_Click;
                        
                    this.PropertyContactsButtonsButton.Button.Click += PropertyContactsButtonsButton_Click;
                        
                    this.PropertyContactsFiltersButton.Button.Click += PropertyContactsFiltersButton_Click;
                                
        
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
                      Type myrec = typeof(IPv5.Business.PropertyContactsRecord);
                      this.DataSource = (PropertyContactsRecord[])(alist.ToArray(myrec));
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
                    foreach (PropertyContactsTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(IPv5.Business.PropertyContactsRecord);
                    this.DataSource = (PropertyContactsRecord[])(postdata.ToArray(myrec));
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
        
        public virtual PropertyContactsRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(PropertyContactsTable.Column1, true);          
            // selCols.Add(PropertyContactsTable.Column2, true);          
            // selCols.Add(PropertyContactsTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return PropertyContactsTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                PropertyContactsTable databaseTable = new PropertyContactsTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(PropertyContactsRecord)) as PropertyContactsRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(PropertyContactsTable.Column1, true);          
            // selCols.Add(PropertyContactsTable.Column2, true);          
            // selCols.Add(PropertyContactsTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return PropertyContactsTable.GetRecordCount(join, where);
            else
            {
                PropertyContactsTable databaseTable = new PropertyContactsTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyContactsTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            PropertyContactsTableControlRow recControl = (PropertyContactsTableControlRow)(repItem.FindControl("PropertyContactsTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                SetAddress1SortLabel1();
                SetAddress2SortLabel1();
                SetAddress3SortLabel();
                SetContactTypeIDSortLabel();
                SeteMailSortLabel1();
                SetFirstNameSortLabel();
                SetLastNameSortLabel();
                SetPostCodeSortLabel1();
                
                
                
                
                
                
                
                SetPropertyIDSortLabel();
                SetTitleSortLabel();
                SetPropertyContactsAddButton();
              
                SetPropertyContactsDeleteButton();
              
                SetPropertyContactsButtonsButton();
              
                SetPropertyContactsFiltersButton();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetPropertyContactsFiltersButton();
                     
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(PropertyContactsTable.ContactTypeID, this.DataSource);
            this.Page.PregetDfkaRecords(PropertyContactsTable.CountryID, this.DataSource);
            this.Page.PregetDfkaRecords(PropertyContactsTable.PropertyID, this.DataSource);
            this.Page.PregetDfkaRecords(PropertyContactsTable.RegionID, this.DataSource);
        }
        

        public virtual void RegisterPostback()
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
                this.PropertyContactsPagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.PropertyContactsPagination.CurrentPage.Text = "0";
            }
            this.PropertyContactsPagination.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for PropertyContactsTableControl pagination.
        
            this.PropertyContactsPagination.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.PropertyContactsPagination.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.PropertyContactsPagination.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.PropertyContactsPagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.PropertyContactsPagination.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.PropertyContactsPagination.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.PropertyContactsPagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.PropertyContactsPagination.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (PropertyContactsTableControlRow recCtl in this.GetRecordControls())
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
            foreach (PropertyContactsTableControlRow recCtl in this.GetRecordControls()){
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
            PropertyContactsTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
      KeyValue selectedRecordKeyValue = new KeyValue();
    IPv5.UI.Controls.AddCities.CitiesRecordControl citiesRecordControlObj = (MiscUtils.FindControlRecursively(this.Page , "CitiesRecordControl") as IPv5.UI.Controls.AddCities.CitiesRecordControl);
          
              if (citiesRecordControlObj != null && citiesRecordControlObj.GetRecord() != null && citiesRecordControlObj.GetRecord().IsCreated)
              {
              wc.iAND(PropertyContactsTable.CityID, BaseFilter.ComparisonOperator.EqualsTo, citiesRecordControlObj.GetRecord().CityID.ToString());
              selectedRecordKeyValue.AddElement(PropertyContactsTable.CityID.InternalName, citiesRecordControlObj.GetRecord().CityID.ToString());
              }
              else
              {
              wc.RunQuery = false;
              return wc;
              }
            
      HttpContext.Current.Session["PropertyContactsTableControlWhereClause"] = selectedRecordKeyValue.ToXmlString();
         
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            PropertyContactsTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
      string selectedRecordInCitiesRecordControl = HttpContext.Current.Session["PropertyContactsTableControlWhereClause"] as string;
      
      if (selectedRecordInCitiesRecordControl != null && KeyValue.IsXmlKey(selectedRecordInCitiesRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInCitiesRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(PropertyContactsTable.CityID))
      {
      wc.iAND(PropertyContactsTable.CityID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(PropertyContactsTable.CityID).ToString());
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
        
            if (this.PropertyContactsPagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.PropertyContactsPagination.PageSize.Text);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyContactsTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                PropertyContactsTableControlRow recControl = (PropertyContactsTableControlRow)(repItem.FindControl("PropertyContactsTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      PropertyContactsRecord rec = new PropertyContactsRecord();
        
                        if (recControl.Address11.Text != "") {
                            rec.Parse(recControl.Address11.Text, PropertyContactsTable.Address1);
                  }
                
                        if (recControl.Address21.Text != "") {
                            rec.Parse(recControl.Address21.Text, PropertyContactsTable.Address2);
                  }
                
                        if (recControl.Address3.Text != "") {
                            rec.Parse(recControl.Address3.Text, PropertyContactsTable.Address3);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.ContactTypeID)) {
                            rec.Parse(recControl.ContactTypeID.SelectedItem.Value, PropertyContactsTable.ContactTypeID);
                        }
                        if (MiscUtils.IsValueSelected(recControl.CountryID)) {
                            rec.Parse(recControl.CountryID.SelectedItem.Value, PropertyContactsTable.CountryID);
                        }
                        if (recControl.eMail1.Text != "") {
                            rec.Parse(recControl.eMail1.Text, PropertyContactsTable.eMail);
                  }
                
                        if (recControl.FirstName.Text != "") {
                            rec.Parse(recControl.FirstName.Text, PropertyContactsTable.FirstName);
                  }
                
                        if (recControl.LastName.Text != "") {
                            rec.Parse(recControl.LastName.Text, PropertyContactsTable.LastName);
                  }
                
                        if (recControl.PostCode1.Text != "") {
                            rec.Parse(recControl.PostCode1.Text, PropertyContactsTable.PostCode);
                  }
                
                        if (MiscUtils.IsValueSelected(recControl.PropertyID)) {
                            rec.Parse(recControl.PropertyID.SelectedItem.Value, PropertyContactsTable.PropertyID);
                        }
                        if (MiscUtils.IsValueSelected(recControl.RegionID)) {
                            rec.Parse(recControl.RegionID.SelectedItem.Value, PropertyContactsTable.RegionID);
                        }
                        if (recControl.Title.Text != "") {
                            rec.Parse(recControl.Title.Text, PropertyContactsTable.Title0);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new PropertyContactsRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(IPv5.Business.PropertyContactsRecord);
                this.DataSource = (PropertyContactsRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(PropertyContactsTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(PropertyContactsTableControlRow rec)            
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
        
        public virtual void SetAddress1SortLabel1()
                  {
                  
                    
        }
                
        public virtual void SetAddress2SortLabel1()
                  {
                  
                    
        }
                
        public virtual void SetAddress3SortLabel()
                  {
                  
                    
        }
                
        public virtual void SetContactTypeIDSortLabel()
                  {
                  
                    
        }
                
        public virtual void SeteMailSortLabel1()
                  {
                  
                    
        }
                
        public virtual void SetFirstNameSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetLastNameSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetPostCodeSortLabel1()
                  {
                  
                    
        }
                
        public virtual void SetPropertyIDSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetTitleSortLabel()
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
                    bool added = (this.AddNewRecord > 0);
                    this.LoadData();
                    this.DataBind();					
                    
                    if (added) this.SetFocusToAddedRow();
                }
                                
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            protected virtual void SetFocusToAddedRow()
            {
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("PropertyContactsTableControlRepeater");
            if (rep == null || rep.Items.Count == 0) return; 			
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items) {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                PropertyContactsTableControlRow recControl = (PropertyContactsTableControlRow)repItem.FindControl("PropertyContactsTableControlRow");
                if(recControl.IsNewRecord) {
                    foreach (Control field in recControl.Controls) {
                    if (field.Visible && this.Page.IsControlEditable(field, false)) {
                        //set focus on the first editable field in the new row
                        field.Focus();
                        UpdatePanel updPan = (UpdatePanel)this.Page.FindControlRecursively("UpdatePanel1");
                        if (updPan != null) updPan.Update();
                        return;
                        }
                    }
                    return;
                }
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

            string orderByStr = (string)ViewState["PropertyContactsTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("PropertyContactsPagination");
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
                this.ViewState["PropertyContactsTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetPropertyContactsAddButton()                
              
        {
        
   
        }
            
        public virtual void SetPropertyContactsDeleteButton()                
              
        {
        
   
        }
            
        public virtual void SetPropertyContactsButtonsButton()                
              
        {
        
   
        }
            
        public virtual void SetPropertyContactsFiltersButton()                
              
        {
                
         IThemeButtonWithArrow themeButtonPropertyContactsFiltersButton = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "PropertyContactsFiltersButton"));
         themeButtonPropertyContactsFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
   
        }
               
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void PropertyContactsPagination_FirstPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void PropertyContactsPagination_LastPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void PropertyContactsPagination_NextPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void PropertyContactsPagination_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.PropertyContactsPagination.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.PropertyContactsPagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void PropertyContactsPagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
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
        
        public virtual void Address1SortLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by Address1 when clicked.
              
            // Get previous sorting state for Address1.
        
            OrderByItem sd = this.CurrentSortOrder.Find(PropertyContactsTable.Address1);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Address1.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(PropertyContactsTable.Address1, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by Address1, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void Address2SortLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by Address2 when clicked.
              
            // Get previous sorting state for Address2.
        
            OrderByItem sd = this.CurrentSortOrder.Find(PropertyContactsTable.Address2);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Address2.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(PropertyContactsTable.Address2, OrderByItem.OrderDir.Asc);
            
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
        
            OrderByItem sd = this.CurrentSortOrder.Find(PropertyContactsTable.Address3);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Address3.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(PropertyContactsTable.Address3, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by Address3, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void ContactTypeIDSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by ContactTypeID when clicked.
              
            // Get previous sorting state for ContactTypeID.
        
            OrderByItem sd = this.CurrentSortOrder.Find(PropertyContactsTable.ContactTypeID);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for ContactTypeID.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(PropertyContactsTable.ContactTypeID, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by ContactTypeID, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void eMailSortLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by eMail when clicked.
              
            // Get previous sorting state for eMail.
        
            OrderByItem sd = this.CurrentSortOrder.Find(PropertyContactsTable.eMail);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for eMail.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(PropertyContactsTable.eMail, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by eMail, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void FirstNameSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by FirstName when clicked.
              
            // Get previous sorting state for FirstName.
        
            OrderByItem sd = this.CurrentSortOrder.Find(PropertyContactsTable.FirstName);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for FirstName.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(PropertyContactsTable.FirstName, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by FirstName, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void LastNameSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by LastName when clicked.
              
            // Get previous sorting state for LastName.
        
            OrderByItem sd = this.CurrentSortOrder.Find(PropertyContactsTable.LastName);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for LastName.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(PropertyContactsTable.LastName, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by LastName, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void PostCodeSortLabel1_Click(object sender, EventArgs args)
        {
            //Sorts by PostCode when clicked.
              
            // Get previous sorting state for PostCode.
        
            OrderByItem sd = this.CurrentSortOrder.Find(PropertyContactsTable.PostCode);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for PostCode.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(PropertyContactsTable.PostCode, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by PostCode, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void PropertyIDSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by PropertyID when clicked.
              
            // Get previous sorting state for PropertyID.
        
            OrderByItem sd = this.CurrentSortOrder.Find(PropertyContactsTable.PropertyID);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for PropertyID.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(PropertyContactsTable.PropertyID, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by PropertyID, so just reverse.
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
        
            OrderByItem sd = this.CurrentSortOrder.Find(PropertyContactsTable.Title0);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Title.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(PropertyContactsTable.Title0, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by Title, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void PropertyContactsAddButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            this.AddNewRecord = 1;
            this.DataChanged = true;
      
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
        public virtual void PropertyContactsDeleteButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
                this.DeleteSelectedRecords(true);
                this.SetFormulaControls();
          
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
            
            
        
        // event handler for Button
        public virtual void PropertyContactsButtonsButton_Click(object sender, EventArgs args)
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
        public virtual void PropertyContactsFiltersButton_Click(object sender, EventArgs args)
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
                    _TotalRecords = PropertyContactsTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  PropertyContactsRecord[] DataSource {
             
            get {
                return (PropertyContactsRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public System.Web.UI.WebControls.LinkButton Address1SortLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address1SortLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton Address2SortLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address2SortLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton Address3SortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address3SortLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ContactTypeIDSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ContactTypeIDSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton eMailSortLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "eMailSortLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton FirstNameSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "FirstNameSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton LastNameSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "LastNameSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton PostCodeSortLabel1 {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PostCodeSortLabel1");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton PropertyContactsAddButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyContactsAddButton");
            }
        }
        
        public IPv5.UI.IThemeButtonWithArrow PropertyContactsButtonsButton {
            get {
                return (IPv5.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyContactsButtonsButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton PropertyContactsDeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyContactsDeleteButton");
            }
        }
        
        public IPv5.UI.IThemeButtonWithArrow PropertyContactsFiltersButton {
            get {
                return (IPv5.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyContactsFiltersButton");
            }
        }
        
        public IPv5.UI.IPaginationModern PropertyContactsPagination {
            get {
                return (IPv5.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyContactsPagination");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox PropertyContactsToggleAll {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyContactsToggleAll");
            }
        }              
            
        public System.Web.UI.WebControls.LinkButton PropertyIDSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyIDSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton TitleSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TitleSortLabel");
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
                PropertyContactsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IPv5"));
                }

        PropertyContactsRecord rec = null;
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
                PropertyContactsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IPv5"));
                }

        PropertyContactsRecord rec = null;
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
          
        public virtual int GetSelectedRecordIndex()
        {
            int counter = 0;
            foreach (PropertyContactsTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.PropertyContactsRecordRowSelection.Checked) {
                    return counter;
                }
                counter += 1;
            }
            return -1;
        }
        
        public virtual PropertyContactsTableControlRow GetSelectedRecordControl()
        {
        PropertyContactsTableControlRow[] selectedList = this.GetSelectedRecordControls();
            if (selectedList.Length == 0) {
            return null;
            }
            return selectedList[0];
          
        }

        public virtual PropertyContactsTableControlRow[] GetSelectedRecordControls()
        {
        
            ArrayList selectedList = new ArrayList(25);
            foreach (PropertyContactsTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.PropertyContactsRecordRowSelection != null && recControl.PropertyContactsRecordRowSelection.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (PropertyContactsTableControlRow[])(selectedList.ToArray(Type.GetType("IPv5.UI.Controls.AddCities.PropertyContactsTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            PropertyContactsTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IPv5"));
            }
            
            foreach (PropertyContactsTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                    recCtl.PropertyContactsRecordRowSelection.Checked = false;
                
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

        public virtual PropertyContactsTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "PropertyContactsTableControlRow");
	          List<PropertyContactsTableControlRow> list = new List<PropertyContactsTableControlRow>();
	          foreach (PropertyContactsTableControlRow recCtrl in recCtrls) {
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
  
// Base class for the SuppliersTableControlRow control on the AddCities page.
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

          
                    this.ServiceTypeIDAddRecordLink.Click += ServiceTypeIDAddRecordLink_Click;
                        
                    this.SuppliersRowDeleteButton.Click += SuppliersRowDeleteButton_Click;
                        
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
                
                
                SetServiceTypeIDAddRecordLink();
              
                SetSuppliersRowDeleteButton();
              

      

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
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.Address1.ID))
            {
            
                this.Address1.Text = this.PreviousUIData[this.Address1.ID].ToString();
              
                return;
            }
            
                    
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
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.Address2.ID))
            {
            
                this.Address2.Text = this.PreviousUIData[this.Address2.ID].ToString();
              
                return;
            }
            
                    
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
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CellPhone.ID))
            {
            
                this.CellPhone.Text = this.PreviousUIData[this.CellPhone.ID].ToString();
              
                return;
            }
            
                    
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
                
        public virtual void SetCompanyName()
        {
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.CompanyName.ID))
            {
            
                this.CompanyName.Text = this.PreviousUIData[this.CompanyName.ID].ToString();
              
                return;
            }
            
                    
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
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ContactName.ID))
            {
            
                this.ContactName.Text = this.PreviousUIData[this.ContactName.ID].ToString();
              
                return;
            }
            
                    
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
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.eMail.ID))
            {
            
                this.eMail.Text = this.PreviousUIData[this.eMail.ID].ToString();
              
                return;
            }
            
                    
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
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.LandPhone.ID))
            {
            
                this.LandPhone.Text = this.PreviousUIData[this.LandPhone.ID].ToString();
              
                return;
            }
            
                    
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
            
            // If data was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.PostCode.ID))
            {
            
                this.PostCode.Text = this.PreviousUIData[this.PostCode.ID].ToString();
              
                return;
            }
            
                    
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
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.ServiceTypeID.ID))
            {
                if (this.PreviousUIData[this.ServiceTypeID.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.ServiceTypeID.ID].ToString();
            }
            
            
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
        CitiesRecordControl parentCtrl;
      
            parentCtrl = (CitiesRecordControl)this.Page.FindControlRecursively("CitiesRecordControl");
          
        if (parentCtrl != null && parentCtrl.DataSource == null) {
        // Load the record if it is not loaded yet.
        parentCtrl.LoadData();
        }
        if (parentCtrl == null || parentCtrl.DataSource == null) {
        // Get the error message from the application resource file.
        throw new Exception(Page.GetResourceValue("Err:NoParentRecId", "IPv5"));
        }
        
          this.DataSource.CityID = parentCtrl.DataSource.CityID;
        
          
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
                

      // To customize, override this method in SuppliersTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersCitiesRecordControl = false;
            hasFiltersCitiesRecordControl = hasFiltersCitiesRecordControl && false; // suppress warning
      
            bool hasFiltersContractorsTableControl = false;
            hasFiltersContractorsTableControl = hasFiltersContractorsTableControl && false; // suppress warning
      
            bool hasFiltersPropertyContactsTableControl = false;
            hasFiltersPropertyContactsTableControl = hasFiltersPropertyContactsTableControl && false; // suppress warning
      
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
            
        public virtual void SetSuppliersRowDeleteButton()                
              
        {
        
   
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
            
            
        
        // event handler for ImageButton
        public virtual void SuppliersRowDeleteButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        SuppliersTableControl tc= ((SuppliersTableControl)MiscUtils.GetParentControlObject(this, "SuppliersTableControl"));
                if (tc != null){
                    if (!this.IsNewRecord){
                        tc.AddToDeletedRecordIds((SuppliersTableControlRow)this);
                    }
                    this.Visible = false;
                    tc.SetFormulaControls();                    
                }
              
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
        
        public System.Web.UI.WebControls.CheckBox SuppliersRecordRowSelection {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SuppliersRecordRowSelection");
            }
        }              
            
        public System.Web.UI.WebControls.ImageButton SuppliersRowDeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SuppliersRowDeleteButton");
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

  
// Base class for the SuppliersTableControl control on the AddCities page.
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
        
              // Show confirmation message on Click
              this.SuppliersDeleteButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteConfirm", "IPv5") + "\"));");
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
            
              this.CompanyNameSortLabel.Click += CompanyNameSortLabel_Click;
            
              this.ContactNameSortLabel.Click += ContactNameSortLabel_Click;
            
              this.eMailSortLabel.Click += eMailSortLabel_Click;
            
              this.LandPhoneSortLabel.Click += LandPhoneSortLabel_Click;
            
              this.PostCodeSortLabel.Click += PostCodeSortLabel_Click;
            
              this.ServiceTypeIDSortLabel.Click += ServiceTypeIDSortLabel_Click;
            
            // Setup the button events.
          
                    this.SuppliersAddButton.Click += SuppliersAddButton_Click;
                        
                    this.SuppliersDeleteButton.Click += SuppliersDeleteButton_Click;
                        
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
                SetCompanyNameSortLabel();
                SetContactNameSortLabel();
                SeteMailSortLabel();
                SetLandPhoneSortLabel();
                SetPostCodeSortLabel();
                SetServiceTypeIDSortLabel();
                
                
                
                
                
                
                
                SetSuppliersAddButton();
              
                SetSuppliersDeleteButton();
              
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

        
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(SuppliersTable.ServiceTypeID, this.DataSource);
        }
        

        public virtual void RegisterPostback()
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
    IPv5.UI.Controls.AddCities.CitiesRecordControl citiesRecordControlObj = (MiscUtils.FindControlRecursively(this.Page , "CitiesRecordControl") as IPv5.UI.Controls.AddCities.CitiesRecordControl);
          
              if (citiesRecordControlObj != null && citiesRecordControlObj.GetRecord() != null && citiesRecordControlObj.GetRecord().IsCreated)
              {
              wc.iAND(SuppliersTable.CityID, BaseFilter.ComparisonOperator.EqualsTo, citiesRecordControlObj.GetRecord().CityID.ToString());
              selectedRecordKeyValue.AddElement(SuppliersTable.CityID.InternalName, citiesRecordControlObj.GetRecord().CityID.ToString());
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
            
      string selectedRecordInCitiesRecordControl = HttpContext.Current.Session["SuppliersTableControlWhereClause"] as string;
      
      if (selectedRecordInCitiesRecordControl != null && KeyValue.IsXmlKey(selectedRecordInCitiesRecordControl))
      {
      KeyValue selectedRecordKeyValue = KeyValue.XmlToKey(selectedRecordInCitiesRecordControl);
      
      if (selectedRecordKeyValue != null && selectedRecordKeyValue.ContainsColumn(SuppliersTable.CityID))
      {
      wc.iAND(SuppliersTable.CityID, BaseFilter.ComparisonOperator.EqualsTo, selectedRecordKeyValue.GetColumnValue(SuppliersTable.CityID).ToString());
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
                
                        if (MiscUtils.IsValueSelected(recControl.ServiceTypeID)) {
                            rec.Parse(recControl.ServiceTypeID.SelectedItem.Value, SuppliersTable.ServiceTypeID);
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
                
        public virtual void SetServiceTypeIDSortLabel()
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
                    bool added = (this.AddNewRecord > 0);
                    this.LoadData();
                    this.DataBind();					
                    
                    if (added) this.SetFocusToAddedRow();
                }
                                
            } catch (Exception ex) {
                BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
            } finally {
                DbUtils.EndTransaction();
            }
        }
        
            protected virtual void SetFocusToAddedRow()
            {
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("SuppliersTableControlRepeater");
            if (rep == null || rep.Items.Count == 0) return; 			
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items) {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                SuppliersTableControlRow recControl = (SuppliersTableControlRow)repItem.FindControl("SuppliersTableControlRow");
                if(recControl.IsNewRecord) {
                    foreach (Control field in recControl.Controls) {
                    if (field.Visible && this.Page.IsControlEditable(field, false)) {
                        //set focus on the first editable field in the new row
                        field.Focus();
                        UpdatePanel updPan = (UpdatePanel)this.Page.FindControlRecursively("UpdatePanel1");
                        if (updPan != null) updPan.Update();
                        return;
                        }
                    }
                    return;
                }
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
        
        public virtual void SetSuppliersAddButton()                
              
        {
        
   
        }
            
        public virtual void SetSuppliersDeleteButton()                
              
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
            
        public virtual void ServiceTypeIDSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by ServiceTypeID when clicked.
              
            // Get previous sorting state for ServiceTypeID.
        
            OrderByItem sd = this.CurrentSortOrder.Find(SuppliersTable.ServiceTypeID);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for ServiceTypeID.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(SuppliersTable.ServiceTypeID, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by ServiceTypeID, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void SuppliersAddButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            this.AddNewRecord = 1;
            this.DataChanged = true;
      
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
        public virtual void SuppliersDeleteButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        
                this.DeleteSelectedRecords(true);
                this.SetFormulaControls();
          
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
        
        public System.Web.UI.WebControls.LinkButton ServiceTypeIDSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ServiceTypeIDSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SuppliersAddButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SuppliersAddButton");
            }
        }
        
        public IPv5.UI.IThemeButtonWithArrow SuppliersButtonsButton {
            get {
                return (IPv5.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SuppliersButtonsButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton SuppliersDeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SuppliersDeleteButton");
            }
        }
        
        public IPv5.UI.IThemeButtonWithArrow SuppliersFiltersButton {
            get {
                return (IPv5.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SuppliersFiltersButton");
            }
        }
        
        public IPv5.UI.IPaginationModern SuppliersPagination {
            get {
                return (IPv5.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SuppliersPagination");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox SuppliersToggleAll {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "SuppliersToggleAll");
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
          
        public virtual int GetSelectedRecordIndex()
        {
            int counter = 0;
            foreach (SuppliersTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SuppliersRecordRowSelection.Checked) {
                    return counter;
                }
                counter += 1;
            }
            return -1;
        }
        
        public virtual SuppliersTableControlRow GetSelectedRecordControl()
        {
        SuppliersTableControlRow[] selectedList = this.GetSelectedRecordControls();
            if (selectedList.Length == 0) {
            return null;
            }
            return selectedList[0];
          
        }

        public virtual SuppliersTableControlRow[] GetSelectedRecordControls()
        {
        
            ArrayList selectedList = new ArrayList(25);
            foreach (SuppliersTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.SuppliersRecordRowSelection != null && recControl.SuppliersRecordRowSelection.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (SuppliersTableControlRow[])(selectedList.ToArray(Type.GetType("IPv5.UI.Controls.AddCities.SuppliersTableControlRow")));
          
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
                
                    recCtl.SuppliersRecordRowSelection.Checked = false;
                
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
  
// Base class for the CitiesRecordControl control on the AddCities page.
// Do not modify this class. Instead override any method in CitiesRecordControl.
public class BaseCitiesRecordControl : IPv5.UI.BaseApplicationRecordControl
{
        public BaseCitiesRecordControl()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in CitiesRecordControl.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
        
            
            string url = "";
            if (url == null) url = ""; //avoid warning on VS
            // Setup the filter and search events.
                
        }

        // To customize, override this method in CitiesRecordControl.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Setup the pagination events.	  
                     
        
              // Register the event handlers.

          
              this.City.TextChanged += City_TextChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseMM_IP1%dbo.Cities record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = CitiesTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // This is the first time a record is being retrieved from the database.
            // So create a Where Clause based on the staic Where clause specified
            // on the Query wizard and the dynamic part specified by the end user
            // on the search and filter controls (if any).
            
            WhereClause wc = this.CreateWhereClause();
            
            // If there is no Where clause, then simply create a new, blank record.
            
            if (wc == null || !(wc.RunQuery)) {
                this.DataSource = new CitiesRecord();
            
                return;
            }
          
            // Retrieve the record from the database.  It is possible
            CitiesRecord[] recList = CitiesTable.GetRecords(wc, null, 0, 2);
            if (recList.Length == 0) {
                // There is no data for this Where clause.
                wc.RunQuery = false;
                
                return;
            }
            
            // Set DataSource based on record retrieved from the database.
            this.DataSource = (CitiesRecord)CitiesRecord.Copy(recList[0], false);
                  
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
        
                
                SetCity();
                SetCityLabel();

      

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
            ContractorsTableControl recContractorsTableControl = (ContractorsTableControl)(MiscUtils.FindControlRecursively(this.Page, "ContractorsTableControl"));
        
          if (shouldResetControl || this.Page.IsPageRefresh)
          {
             recContractorsTableControl.ResetControl();
          }
                  
        this.Page.SetControl("ContractorsTableControl");
        PropertyContactsTableControl recPropertyContactsTableControl = (PropertyContactsTableControl)(MiscUtils.FindControlRecursively(this.Page, "PropertyContactsTableControl"));
        
          if (shouldResetControl || this.Page.IsPageRefresh)
          {
             recPropertyContactsTableControl.ResetControl();
          }
                  
        this.Page.SetControl("PropertyContactsTableControl");
        SuppliersTableControl recSuppliersTableControl = (SuppliersTableControl)(MiscUtils.FindControlRecursively(this.Page, "SuppliersTableControl"));
        
          if (shouldResetControl || this.Page.IsPageRefresh)
          {
             recSuppliersTableControl.ResetControl();
          }
                  
        this.Page.SetControl("SuppliersTableControl");
        
        }
        
        
        public virtual void SetCity()
        {
            
                    
            // Set the City TextBox on the webpage with value from the
            // DatabaseMM_IP1%dbo.Cities database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.Cities record retrieved from the database.
            // this.City is the ASP:TextBox on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CitySpecified) {
                								
                // If the City is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(CitiesTable.City);
                                
                this.City.Text = formattedValue;
                   
            } 
            
            else {
            
                // City is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.City.Text = CitiesTable.City.Format(CitiesTable.City.DefaultValue);
            		
            }
            
              this.City.TextChanged += City_TextChanged;
                               
        }
                
        public virtual void SetCityLabel()
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
          ContractorsTableControl recContractorsTableControl = (ContractorsTableControl)(MiscUtils.FindControlRecursively(this.Page, "ContractorsTableControl"));
        recContractorsTableControl.SaveData();
          PropertyContactsTableControl recPropertyContactsTableControl = (PropertyContactsTableControl)(MiscUtils.FindControlRecursively(this.Page, "PropertyContactsTableControl"));
        recPropertyContactsTableControl.SaveData();
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
        
            GetCity();
        }
        
        
        public virtual void GetCity()
        {
            
            // Retrieve the value entered by the user on the City ASP:TextBox, and
            // save it into the City field in DataSource DatabaseMM_IP1%dbo.Cities record.
            
            // Custom validation should be performed in Validate, not here.
                    
            // Save the value to data source
            this.DataSource.Parse(this.City.Text, CitiesTable.City);							
                          
                      
        }
                

      // To customize, override this method in CitiesRecordControl.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersCitiesRecordControl = false;
            hasFiltersCitiesRecordControl = hasFiltersCitiesRecordControl && false; // suppress warning
      
            bool hasFiltersContractorsTableControl = false;
            hasFiltersContractorsTableControl = hasFiltersContractorsTableControl && false; // suppress warning
      
            bool hasFiltersPropertyContactsTableControl = false;
            hasFiltersPropertyContactsTableControl = hasFiltersPropertyContactsTableControl && false; // suppress warning
      
            bool hasFiltersSuppliersTableControl = false;
            hasFiltersSuppliersTableControl = hasFiltersSuppliersTableControl && false; // suppress warning
      
            WhereClause wc;
            CitiesTable.Instance.InnerFilter = null;
            wc = new WhereClause();
            
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

            
            // Retrieve the record id from the URL parameter.
            string recId = this.Page.Request.QueryString["Cities"];
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
              
            recId = ((BaseApplicationPage)(this.Page)).Decrypt(recId);
            if (recId == null || recId.Length == 0) {
                
                return null;
                
            }
                       
            HttpContext.Current.Session["QueryString in AddCities"] = recId;
              
            if (KeyValue.IsXmlKey(recId)) {
                // Keys are typically passed as XML structures to handle composite keys.
                // If XML, then add a Where clause based on the Primary Key in the XML.
                KeyValue pkValue = KeyValue.XmlToKey(recId);
            
          wc.iAND(CitiesTable.CityID, BaseFilter.ComparisonOperator.EqualsTo, pkValue.GetColumnValueString(CitiesTable.CityID));
             
            }
            else {
                // The URL parameter contains the actual value, not an XML structure.
            
          wc.iAND(CitiesTable.CityID, BaseFilter.ComparisonOperator.EqualsTo, recId);
             
            }
                
            return wc;
            
        }
        
        
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            CitiesTable.Instance.InnerFilter = null;
            WhereClause wc= new WhereClause();
        
            bool hasFiltersCitiesRecordControl = false;
            hasFiltersCitiesRecordControl = hasFiltersCitiesRecordControl && false; // suppress warning
      
            bool hasFiltersContractorsTableControl = false;
            hasFiltersContractorsTableControl = hasFiltersContractorsTableControl && false; // suppress warning
      
            bool hasFiltersPropertyContactsTableControl = false;
            hasFiltersPropertyContactsTableControl = hasFiltersPropertyContactsTableControl && false; // suppress warning
      
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
          CitiesTable.DeleteRecord(pkValue);
          
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
        
        protected virtual void City_TextChanged(object sender, EventArgs args)
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
                return (string)this.ViewState["BaseCitiesRecordControl_Rec"];
            }
            set {
                this.ViewState["BaseCitiesRecordControl_Rec"] = value;
            }
        }
        
        public CitiesRecord DataSource {
            get {
                return (CitiesRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal CitiesTitle {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CitiesTitle");
            }
        }
        
        public System.Web.UI.WebControls.TextBox City {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "City");
            }
        }
            
        public System.Web.UI.WebControls.Literal CityLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CityLabel");
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
        CitiesRecord rec = null;
             
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
    CitiesRecord rec = null;
    
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

        
        public virtual CitiesRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
            return new CitiesRecord();
            
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

  