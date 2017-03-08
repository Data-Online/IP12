
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// EditUsers_RolesTable.aspx page.  The Row or RecordControl classes are the 
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

  
namespace IPv5.UI.Controls.EditUsers_RolesTable
{
  

#region "Section 1: Place your customizations here."

    
public class Users_RolesTableControlRow : BaseUsers_RolesTableControlRow
{
      
        // The BaseUsers_RolesTableControlRow implements code for a ROW within the
        // the Users_RolesTableControl table.  The BaseUsers_RolesTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of Users_RolesTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class Users_RolesTableControl : BaseUsers_RolesTableControl
{
    // The BaseUsers_RolesTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The Users_RolesTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the Users_RolesTableControlRow control on the EditUsers_RolesTable page.
// Do not modify this class. Instead override any method in Users_RolesTableControlRow.
public class BaseUsers_RolesTableControlRow : IPv5.UI.BaseApplicationRecordControl
{
        public BaseUsers_RolesTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in Users_RolesTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in Users_RolesTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
        
              // Show confirmation message on Click
              this.Users_RolesRowDeleteButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteRecordConfirm", "IPv5") + "\"));");            
        
              // Register the event handlers.

          
                    this.RoleIDAddRecordLink.Click += RoleIDAddRecordLink_Click;
                        
                    this.UserId0AddRecordLink.Click += UserId0AddRecordLink_Click;
                        
                    this.Users_RolesRowDeleteButton.Click += Users_RolesRowDeleteButton_Click;
                        
                    this.Users_RolesRowEditButton.Click += Users_RolesRowEditButton_Click;
                        
                    this.Users_RolesRowViewButton.Click += Users_RolesRowViewButton_Click;
                        
              this.RoleID.SelectedIndexChanged += RoleID_SelectedIndexChanged;
            
              this.UserId0.SelectedIndexChanged += UserId0_SelectedIndexChanged;
            
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseMM_IP1%dbo.Users_Roles record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = Users_RolesTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseUsers_RolesTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new Users_RolesRecord();
            
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
        
                SetRoleID();
                
                SetRoleIDLabel();
                SetUserId0();
                
                SetUserIDLabel();
                
                
                
                
                SetRoleIDAddRecordLink();
              
                SetUserId0AddRecordLink();
              
                SetUsers_RolesRowDeleteButton();
              
                SetUsers_RolesRowEditButton();
              
                SetUsers_RolesRowViewButton();
              

      

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
        
        
        public virtual void SetRoleID()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.RoleID.ID))
            {
                if (this.PreviousUIData[this.RoleID.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.RoleID.ID].ToString();
            }
            
            
            // Set the RoleID DropDownList on the webpage with value from the
            // DatabaseMM_IP1%dbo.Users_Roles database record.
            
            // this.DataSource is the DatabaseMM_IP1%dbo.Users_Roles record retrieved from the database.
            // this.RoleID is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetRoleID();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.RoleIDSpecified)
            {
                            
                // If the RoleID is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.RoleID.ToString();
                
            }
            else
            {
                
                // RoleID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Users_RolesTable.RoleID.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateRoleIDDropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetUserId0()
        {
            				
        
        
            string selectedValue = null;
            
            // figure out the selectedValue
                  
            							
            // If selection was retrieved from UI previously, restore it
            if (this.PreviousUIData.ContainsKey(this.UserId0.ID))
            {
                if (this.PreviousUIData[this.UserId0.ID] == null)
                    selectedValue = null;
                else
                    selectedValue = this.PreviousUIData[this.UserId0.ID].ToString();
            }
            
            
            // Set the UserID DropDownList on the webpage with value from the
            // DatabaseMM_IP1%dbo.Users_Roles database record.
            
            // this.DataSource is the DatabaseMM_IP1%dbo.Users_Roles record retrieved from the database.
            // this.UserId0 is the ASP:DropDownList on the webpage.
            
            // You can modify this method directly, or replace it with a call to
            //     base.SetUserId0();
            // and add your own custom code before or after the call to the base function.

            
            if (this.DataSource != null && this.DataSource.UserId0Specified)
            {
                            
                // If the UserID is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
                selectedValue = this.DataSource.UserId0.ToString();
                
            }
            else
            {
                
                // UserID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
                if (this.DataSource != null && this.DataSource.IsCreated)
                    selectedValue = null;
                else
                    selectedValue = Users_RolesTable.UserId0.DefaultValue;
                				
            }			
                            
                  
            // Populate the item(s) to the control
            
            this.PopulateUserId0DropDownList(selectedValue, 100);              
                
                  
        }
                
        public virtual void SetRoleIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetUserIDLabel()
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
                ((Users_RolesTableControl)MiscUtils.GetParentControlObject(this, "Users_RolesTableControl")).DataChanged = true;
                ((Users_RolesTableControl)MiscUtils.GetParentControlObject(this, "Users_RolesTableControl")).ResetData = true;
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
        
            GetRoleID();
            GetUserId0();
        }
        
        
        public virtual void GetRoleID()
        {
         // Retrieve the value entered by the user on the RoleID ASP:DropDownList, and
            // save it into the RoleID field in DataSource DatabaseMM_IP1%dbo.Users_Roles record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.RoleID), Users_RolesTable.RoleID);			
                			 
        }
                
        public virtual void GetUserId0()
        {
         // Retrieve the value entered by the user on the UserID ASP:DropDownList, and
            // save it into the UserID field in DataSource DatabaseMM_IP1%dbo.Users_Roles record.
            
            // Custom validation should be performed in Validate, not here.
            
            this.DataSource.Parse(MiscUtils.GetValueSelectedPageRequest(this.UserId0), Users_RolesTable.UserId0);			
                			 
        }
                

      // To customize, override this method in Users_RolesTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersUsers_RolesTableControl = false;
            hasFiltersUsers_RolesTableControl = hasFiltersUsers_RolesTableControl && false; // suppress warning
      
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
          Users_RolesTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((Users_RolesTableControl)MiscUtils.GetParentControlObject(this, "Users_RolesTableControl")).DataChanged = true;
            ((Users_RolesTableControl)MiscUtils.GetParentControlObject(this, "Users_RolesTableControl")).ResetData = true;
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
        
        public virtual void SetRoleIDAddRecordLink()                
              
        {
        
              try
              {
                    string url = "../Roles/AddRoles.aspx";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "?RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("NewWindow") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(this.RoleID.ClientID) + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("RoleName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("RoleID");                      
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializeNewWindow(this, '" + url + "', false, event);";                  
                       
                    this.RoleIDAddRecordLink.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, RoleIDAddRecordLink_ClickRoleIDAddRecordLink_Click will be trigger when user click the button.
                }
                  
   
        }
            
        public virtual void SetUserId0AddRecordLink()                
              
        {
        
              try
              {
                    string url = "../Users/AddUsers.aspx";
              
                      
                    url = this.ModifyRedirectUrl(url, "", true);
                    
                    url = this.Page.ModifyRedirectUrl(url, "", true);                                  
                    
                    url = url + "?RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("NewWindow") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(this.UserId0.ClientID) + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("UserName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("UserID");                      
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializeNewWindow(this, '" + url + "', false, event);";                  
                       
                    this.UserId0AddRecordLink.Attributes["onClick"] = javascriptCall + "return false;";            
                }
                catch
                {
                    // do nothing.  If the code above fails, server side click event, UserId0AddRecordLink_ClickUserId0AddRecordLink_Click will be trigger when user click the button.
                }
                  
   
        }
            
        public virtual void SetUsers_RolesRowDeleteButton()                
              
        {
        
   
        }
            
        public virtual void SetUsers_RolesRowEditButton()                
              
        {
        
   
        }
            
        public virtual void SetUsers_RolesRowViewButton()                
              
        {
        
   
        }
            
        public virtual WhereClause CreateWhereClause_RoleIDDropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseMM_IP1%dbo.Roles table.
            // Examples:
            // wc.iAND(RolesTable.RoleName, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(RolesTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        public virtual WhereClause CreateWhereClause_UserId0DropDownList() 
        {
            // By default, we simply return a new WhereClause.
            // Add additional where clauses to restrict the items shown in the dropdown list.
            						
            // This WhereClause is for the DatabaseMM_IP1%dbo.Users table.
            // Examples:
            // wc.iAND(UsersTable.UserName0, BaseFilter.ComparisonOperator.EqualsTo, "XYZ");
            // wc.iAND(UsersTable.Active, BaseFilter.ComparisonOperator.EqualsTo, "1");
            
            WhereClause wc = new WhereClause();
            return wc;
            				
        }
        
        // Fill the RoleID list.
        protected virtual void PopulateRoleIDDropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.RoleID.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.RoleID.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "IPv5"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_RoleIDDropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_RoleIDDropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(RolesTable.RoleName, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the RoleIDDropDownList.
            RolesRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = RolesTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (RolesRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.RoleIDSpecified) 
                        {
                            cvalue = itemValue.RoleID.ToString().ToString();
                            if (counter < maxItems && this.RoleID.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Users_RolesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Users_RolesTable.RoleID);
                                if(_isExpandableNonCompositeForeignKey && Users_RolesTable.RoleID.IsApplyDisplayAs)
                                    fvalue = Users_RolesTable.GetDFKA(itemValue, Users_RolesTable.RoleID);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(RolesTable.RoleName);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.RoleID.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.RoleID.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.RoleID, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.RoleID, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseMM_IP1%dbo.Roles.RoleID = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(RolesTable.RoleID, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    RolesRecord[] rc = RolesTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        RolesRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.RoleIDSpecified)
                            cvalue = itemValue.RoleID.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = Users_RolesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Users_RolesTable.RoleID);
                        if(_isExpandableNonCompositeForeignKey && Users_RolesTable.RoleID.IsApplyDisplayAs)
                            fvalue = Users_RolesTable.GetDFKA(itemValue, Users_RolesTable.RoleID);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(RolesTable.RoleName);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.RoleID, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // Fill the UserId0 list.
        protected virtual void PopulateUserId0DropDownList(string selectedValue, int maxItems) 
        {
            		  					                
            this.UserId0.Items.Clear();
            
            // 1. Setup the static list items        
            
              // Add the Please Select item.
              this.UserId0.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:PleaseSelect", "IPv5"), "--PLEASE_SELECT--"));
            		  			
            // 2. Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_UserId0DropDownList function.
            // It is better to customize the where clause there.
            
                      
            WhereClause wc = CreateWhereClause_UserId0DropDownList();
                        
                
            // Create the ORDER BY clause to sort based on the displayed value.							
                
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(UsersTable.UserName0, OrderByItem.OrderDir.Asc);

            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();
            FormulaEvaluator evaluator = new FormulaEvaluator();

            // 3. Read a total of maxItems from the database and insert them into the UserId0DropDownList.
            UsersRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;	
                ArrayList listDuplicates = new ArrayList();

                do
                {
                    itemValues = UsersTable.GetRecords(wc, orderBy, pageNum, maxItems);
                    foreach (UsersRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.UserId0Specified) 
                        {
                            cvalue = itemValue.UserId0.ToString().ToString();
                            if (counter < maxItems && this.UserId0.Items.FindByValue(cvalue) == null)
                            {
                                     
                                Boolean _isExpandableNonCompositeForeignKey = Users_RolesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Users_RolesTable.UserId0);
                                if(_isExpandableNonCompositeForeignKey && Users_RolesTable.UserId0.IsApplyDisplayAs)
                                    fvalue = Users_RolesTable.GetDFKA(itemValue, Users_RolesTable.UserId0);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                    fvalue = itemValue.Format(UsersTable.UserName0);
                                    		

                                if (fvalue == null || fvalue.Trim() == "") 
                                    fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                    fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.UserId0.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.UserId0.Items.Add(newItem);

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
                !MiscUtils.SetSelectedValue(this.UserId0, selectedValue) &&
                !MiscUtils.SetSelectedDisplayText(this.UserId0, selectedValue))
            {

                // construct a whereclause to query a record with DatabaseMM_IP1%dbo.Users.UserID = selectedValue
                    
                CompoundFilter filter2 = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
                WhereClause whereClause2 = new WhereClause();
                filter2.AddFilter(new BaseClasses.Data.ColumnValueFilter(UsersTable.UserId0, selectedValue, BaseClasses.Data.BaseFilter.ComparisonOperator.EqualsTo, false));
                whereClause2.AddFilter(filter2, CompoundFilter.CompoundingOperators.And_Operator);

                // Execute the query
                try
                {
                    UsersRecord[] rc = UsersTable.GetRecords(whereClause2, new OrderBy(false, false), 0, 1);
                    System.Collections.Generic.IDictionary<string, object> vars = new System.Collections.Generic.Dictionary<string, object> ();
                    // if find a record, add it to the dropdown and set it as selected item
                    if (rc != null && rc.Length == 1)
                    {
                        UsersRecord itemValue = rc[0];
                        string cvalue = null;
                        string fvalue = null;                        
                        if (itemValue.UserId0Specified)
                            cvalue = itemValue.UserId0.ToString(); 
                        Boolean _isExpandableNonCompositeForeignKey = Users_RolesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Users_RolesTable.UserId0);
                        if(_isExpandableNonCompositeForeignKey && Users_RolesTable.UserId0.IsApplyDisplayAs)
                            fvalue = Users_RolesTable.GetDFKA(itemValue, Users_RolesTable.UserId0);
                        if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                            fvalue = itemValue.Format(UsersTable.UserName0);
                            					
                        if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;
                        MiscUtils.ResetSelectedItem(this.UserId0, new ListItem(fvalue, cvalue));                      
                    }
                }
                catch
                {
                }

                    					
            }					
                        
        }
                  
        // event handler for ImageButton
        public virtual void RoleIDAddRecordLink_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Roles/AddRoles.aspx";
            
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
      
                    url = url + "?RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("NewWindow") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(this.RoleID.ClientID) + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("RoleName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("RoleID");                      
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializeNewWindow(this, '" + url + "', false, event);";                  
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "RoleIDAddRecordLink_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void UserId0AddRecordLink_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Users/AddUsers.aspx";
            
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
      
                    url = url + "?RedirectStyle=" + (this.Page as BaseApplicationPage).Encrypt("NewWindow") + "&Target=" + (this.Page as BaseApplicationPage).Encrypt(this.UserId0.ClientID) + "&DFKA=" + (this.Page as BaseApplicationPage).Encrypt("UserName")+ "&IndexField=" + (this.Page as BaseApplicationPage).Encrypt("UserID");                      
                              
                string javascriptCall = "";
                
                    javascriptCall = "initializeNewWindow(this, '" + url + "', false, event);";                  
                AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "UserId0AddRecordLink_Click", javascriptCall, true);
        
            }
        
        }
            
            
        
        // event handler for ImageButton
        public virtual void Users_RolesRowDeleteButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
            if (!this.Page.IsPageRefresh) {
        Users_RolesTableControl tc= ((Users_RolesTableControl)MiscUtils.GetParentControlObject(this, "Users_RolesTableControl"));
                if (tc != null){
                    if (!this.IsNewRecord){
                        tc.AddToDeletedRecordIds((Users_RolesTableControlRow)this);
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
        public virtual void Users_RolesRowEditButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Users_Roles/EditUsers_Roles.aspx?Users_Roles={PK}";
            
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
            
            
        
        // event handler for ImageButton
        public virtual void Users_RolesRowViewButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Users_Roles/ShowUsers_Roles.aspx?Users_Roles={PK}";
            
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
            
            
        
        protected virtual void RoleID_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[RoleID.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[RoleID.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.RoleID.Items.Add(new ListItem(displayText, val));
	            this.RoleID.SelectedIndex = this.RoleID.Items.Count - 1;
	            this.Page.Session.Remove(RoleID.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(RoleID.ClientID + "_SelectedDisplayText");
            }
           						
        }
            
        protected virtual void UserId0_SelectedIndexChanged(object sender, EventArgs args)
        {
            // for the value inserted by quick add button or large list selector, 
            // the value is necessary to be inserted by this event during postback 
            string val = (string)(this.Page.Session[UserId0.ClientID + "_SelectedValue"]);
            string displayText = (string)(this.Page.Session[UserId0.ClientID + "_SelectedDisplayText"]);
            if (!string.IsNullOrEmpty(displayText) && !string.IsNullOrEmpty(val)) {
	            this.UserId0.Items.Add(new ListItem(displayText, val));
	            this.UserId0.SelectedIndex = this.UserId0.Items.Count - 1;
	            this.Page.Session.Remove(UserId0.ClientID + "_SelectedValue");
	            this.Page.Session.Remove(UserId0.ClientID + "_SelectedDisplayText");
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
                return (string)this.ViewState["BaseUsers_RolesTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseUsers_RolesTableControlRow_Rec"] = value;
            }
        }
        
        public Users_RolesRecord DataSource {
            get {
                return (Users_RolesRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.DropDownList RoleID {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RoleID");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton RoleIDAddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RoleIDAddRecordLink");
            }
        }
        
        public System.Web.UI.WebControls.Literal RoleIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RoleIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList UserId0 {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "UserId0");
            }
        }
            
        public System.Web.UI.WebControls.ImageButton UserId0AddRecordLink {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "UserId0AddRecordLink");
            }
        }
        
        public System.Web.UI.WebControls.Literal UserIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "UserIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox Users_RolesRecordRowSelection {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Users_RolesRecordRowSelection");
            }
        }              
            
        public System.Web.UI.WebControls.ImageButton Users_RolesRowDeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Users_RolesRowDeleteButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton Users_RolesRowEditButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Users_RolesRowEditButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton Users_RolesRowViewButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Users_RolesRowViewButton");
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
        Users_RolesRecord rec = null;
             
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
    Users_RolesRecord rec = null;
    
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

        
        public virtual Users_RolesRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return Users_RolesTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the Users_RolesTableControl control on the EditUsers_RolesTable page.
// Do not modify this class. Instead override any method in Users_RolesTableControl.
public class BaseUsers_RolesTableControl : IPv5.UI.BaseApplicationTableControl
{
         
       public BaseUsers_RolesTableControl()
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
                if  (this.InSession(this.RoleIDFilter)) 				
                    initialVal = this.GetFromSession(this.RoleIDFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"RoleID\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.RoleIDFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.RoleIDFilter.SelectedValue = initialVal;
                            
                    }
            }
            if (!this.Page.IsPostBack)
            {
                string initialVal = "";
                if  (this.InSession(this.UserIDFilter)) 				
                    initialVal = this.GetFromSession(this.UserIDFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"UserId\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.UserIDFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.UserIDFilter.SelectedValue = initialVal;
                            
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
        
              // Show confirmation message on Click
              this.Users_RolesDeleteButton.Attributes.Add("onClick", "return (confirm(\"" + ((BaseApplicationPage)this.Page).GetResourceValue("DeleteConfirm", "IPv5") + "\"));");
            // Setup the pagination events.
            
                    this.Users_RolesPagination.FirstPage.Click += Users_RolesPagination_FirstPage_Click;
                        
                    this.Users_RolesPagination.LastPage.Click += Users_RolesPagination_LastPage_Click;
                        
                    this.Users_RolesPagination.NextPage.Click += Users_RolesPagination_NextPage_Click;
                        
                    this.Users_RolesPagination.PageSizeButton.Click += Users_RolesPagination_PageSizeButton_Click;
                        
                    this.Users_RolesPagination.PreviousPage.Click += Users_RolesPagination_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
              this.RoleIDSortLabel.Click += RoleIDSortLabel_Click;
            
              this.UserIDSortLabel.Click += UserIDSortLabel_Click;
            
            // Setup the button events.
          
                    this.Users_RolesAddButton.Click += Users_RolesAddButton_Click;
                        
                    this.Users_RolesDeleteButton.Click += Users_RolesDeleteButton_Click;
                        
                    this.Users_RolesResetButton.Click += Users_RolesResetButton_Click;
                        
                    this.Users_RolesSaveButton.Click += Users_RolesSaveButton_Click;
                        
                    this.Users_RolesButtonsButton.Button.Click += Users_RolesButtonsButton_Click;
                        
                    this.Users_RolesFilterButton.Button.Click += Users_RolesFilterButton_Click;
                        
                    this.Users_RolesFiltersButton.Button.Click += Users_RolesFiltersButton_Click;
                        
            this.RoleIDFilter.SelectedIndexChanged += new EventHandler(RoleIDFilter_SelectedIndexChanged);
            
            this.UserIDFilter.SelectedIndexChanged += new EventHandler(UserIDFilter_SelectedIndexChanged);
                    
        
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
                      Type myrec = typeof(IPv5.Business.Users_RolesRecord);
                      this.DataSource = (Users_RolesRecord[])(alist.ToArray(myrec));
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
                    foreach (Users_RolesTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(IPv5.Business.Users_RolesRecord);
                    this.DataSource = (Users_RolesRecord[])(postdata.ToArray(myrec));
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
        
        public virtual Users_RolesRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(Users_RolesTable.Column1, true);          
            // selCols.Add(Users_RolesTable.Column2, true);          
            // selCols.Add(Users_RolesTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return Users_RolesTable.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                Users_RolesTable databaseTable = new Users_RolesTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(Users_RolesRecord)) as Users_RolesRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(Users_RolesTable.Column1, true);          
            // selCols.Add(Users_RolesTable.Column2, true);          
            // selCols.Add(Users_RolesTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return Users_RolesTable.GetRecordCount(join, where);
            else
            {
                Users_RolesTable databaseTable = new Users_RolesTable();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Users_RolesTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            Users_RolesTableControlRow recControl = (Users_RolesTableControlRow)(repItem.FindControl("Users_RolesTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                SetRoleIDFilter();
                SetRoleIDLabel1();
                SetRoleIDSortLabel();
                SetUserIDFilter();
                SetUserIDLabel1();
                SetUserIDSortLabel();
                
                
                
                
                
                
                
                
                
                
                
                SetUsers_RolesAddButton();
              
                SetUsers_RolesDeleteButton();
              
                SetUsers_RolesResetButton();
              
                SetUsers_RolesSaveButton();
              
                SetUsers_RolesButtonsButton();
              
                SetUsers_RolesFilterButton();
              
                SetUsers_RolesFiltersButton();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetUsers_RolesFiltersButton();
                     
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(Users_RolesTable.RoleID, this.DataSource);
            this.Page.PregetDfkaRecords(Users_RolesTable.UserId0, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"Users_RolesSaveButton"));
                                
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


            
            this.RoleIDFilter.ClearSelection();
            
            this.UserIDFilter.ClearSelection();
            
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
                this.Users_RolesPagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.Users_RolesPagination.CurrentPage.Text = "0";
            }
            this.Users_RolesPagination.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for Users_RolesTableControl pagination.
        
            this.Users_RolesPagination.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Users_RolesPagination.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Users_RolesPagination.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Users_RolesPagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.Users_RolesPagination.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.Users_RolesPagination.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.Users_RolesPagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.Users_RolesPagination.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (Users_RolesTableControlRow recCtl in this.GetRecordControls())
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
            foreach (Users_RolesTableControlRow recCtl in this.GetRecordControls()){
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
            Users_RolesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            if (MiscUtils.IsValueSelected(this.RoleIDFilter)) {
                        
                wc.iAND(Users_RolesTable.RoleID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.RoleIDFilter, this.GetFromSession(this.RoleIDFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.UserIDFilter)) {
                        
                wc.iAND(Users_RolesTable.UserId0, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.UserIDFilter, this.GetFromSession(this.UserIDFilter)), false, false);
                    
            }
                           
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            Users_RolesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String RoleIDFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "RoleIDFilter_Ajax"];
            if (MiscUtils.IsValueSelected(RoleIDFilterSelectedValue)) {

              
                wc.iAND(Users_RolesTable.RoleID, BaseFilter.ComparisonOperator.EqualsTo, RoleIDFilterSelectedValue, false, false);
                      
      }
                      
      String UserIDFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "UserIDFilter_Ajax"];
            if (MiscUtils.IsValueSelected(UserIDFilterSelectedValue)) {

              
                wc.iAND(Users_RolesTable.UserId0, BaseFilter.ComparisonOperator.EqualsTo, UserIDFilterSelectedValue, false, false);
                      
      }
                      

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
        
            if (this.Users_RolesPagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.Users_RolesPagination.PageSize.Text);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Users_RolesTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Users_RolesTableControlRow recControl = (Users_RolesTableControlRow)(repItem.FindControl("Users_RolesTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      Users_RolesRecord rec = new Users_RolesRecord();
        
                        if (MiscUtils.IsValueSelected(recControl.RoleID)) {
                            rec.Parse(recControl.RoleID.SelectedItem.Value, Users_RolesTable.RoleID);
                        }
                        if (MiscUtils.IsValueSelected(recControl.UserId0)) {
                            rec.Parse(recControl.UserId0.SelectedItem.Value, Users_RolesTable.UserId0);
                        }
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new Users_RolesRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(IPv5.Business.Users_RolesRecord);
                this.DataSource = (Users_RolesRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(Users_RolesTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(Users_RolesTableControlRow rec)            
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
        
        public virtual void SetRoleIDLabel1()
                  {
                  
                    
        }
                
        public virtual void SetRoleIDSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetUserIDLabel1()
                  {
                  
                    
        }
                
        public virtual void SetUserIDSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetRoleIDFilter()
        {
            
            this.PopulateRoleIDFilter(MiscUtils.GetSelectedValue(this.RoleIDFilter,  GetFromSession(this.RoleIDFilter)), 500);					
                                     
        }
            
        public virtual void SetUserIDFilter()
        {
            
            this.PopulateUserIDFilter(MiscUtils.GetSelectedValue(this.UserIDFilter,  GetFromSession(this.UserIDFilter)), 500);					
                                     
        }
            
        // Get the filters' data for RoleIDFilter.
                
        protected virtual void PopulateRoleIDFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.RoleIDFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_RoleIDFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_RoleIDFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.RoleIDFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "IPv5"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(RolesTable.RoleName, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "IPv5");

            RolesRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = RolesTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (RolesRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.RoleIDSpecified) 
                        {
                            cvalue = itemValue.RoleID.ToString();
                            if (counter < maxItems && this.RoleIDFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = Users_RolesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Users_RolesTable.RoleID);
                                if(_isExpandableNonCompositeForeignKey && Users_RolesTable.RoleID.IsApplyDisplayAs)
                                     fvalue = Users_RolesTable.GetDFKA(itemValue, Users_RolesTable.RoleID);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(RolesTable.RoleName);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.RoleIDFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.RoleIDFilter.Items.Add(newItem);

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
                MiscUtils.SetSelectedValue(this.RoleIDFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.RoleIDFilter.SelectedValue != null && this.RoleIDFilter.Items.FindByValue(this.RoleIDFilter.SelectedValue) == null)
                this.RoleIDFilter.SelectedValue = null;
                           
        }
            
        // Get the filters' data for UserIDFilter.
                
        protected virtual void PopulateUserIDFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.UserIDFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_UserIDFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_UserIDFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.UserIDFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "IPv5"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(UsersTable.UserName0, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "IPv5");

            UsersRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
                ArrayList listDuplicates = new ArrayList();
                
                do
                {
                    
                    itemValues = UsersTable.GetRecords(wc, orderBy, pageNum, maxItems);
                                    
                    foreach (UsersRecord itemValue in itemValues) 
                    {
                        // Create the item and add to the list.
                        string cvalue = null;
                        string fvalue = null;
                        if (itemValue.UserId0Specified) 
                        {
                            cvalue = itemValue.UserId0.ToString();
                            if (counter < maxItems && this.UserIDFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = Users_RolesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(Users_RolesTable.UserId0);
                                if(_isExpandableNonCompositeForeignKey && Users_RolesTable.UserId0.IsApplyDisplayAs)
                                     fvalue = Users_RolesTable.GetDFKA(itemValue, Users_RolesTable.UserId0);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(UsersTable.UserName0);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.UserIDFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.UserIDFilter.Items.Add(newItem);

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
                MiscUtils.SetSelectedValue(this.UserIDFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.UserIDFilter.SelectedValue != null && this.UserIDFilter.Items.FindByValue(this.UserIDFilter.SelectedValue) == null)
                this.UserIDFilter.SelectedValue = null;
                           
        }
            
        public virtual WhereClause CreateWhereClause_RoleIDFilter()
        {
            // Create a where clause for the filter RoleIDFilter.
            // This function is called by the Populate method to load the items 
            // in the RoleIDFilterDropDownList
        
            WhereClause wc = new WhereClause();
            return wc;
            
        }
      
        public virtual WhereClause CreateWhereClause_UserIDFilter()
        {
            // Create a where clause for the filter UserIDFilter.
            // This function is called by the Populate method to load the items 
            // in the UserIDFilterDropDownList
        
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
            System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)this.FindControl("Users_RolesTableControlRepeater");
            if (rep == null || rep.Items.Count == 0) return; 			
            foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items) {
                // Loop through all rows in the table, set its DataSource and call DataBind().
                Users_RolesTableControlRow recControl = (Users_RolesTableControlRow)repItem.FindControl("Users_RolesTableControlRow");
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
        
            this.SaveToSession(this.RoleIDFilter, this.RoleIDFilter.SelectedValue);
                  
            this.SaveToSession(this.UserIDFilter, this.UserIDFilter.SelectedValue);
                  
            
                    
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
          
      this.SaveToSession("RoleIDFilter_Ajax", this.RoleIDFilter.SelectedValue);
              
      this.SaveToSession("UserIDFilter_Ajax", this.UserIDFilter.SelectedValue);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.RoleIDFilter);
            this.RemoveFromSession(this.UserIDFilter);
            
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

            string orderByStr = (string)ViewState["Users_RolesTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("Users_RolesPagination");
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
                this.ViewState["Users_RolesTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetUsers_RolesAddButton()                
              
        {
        
   
        }
            
        public virtual void SetUsers_RolesDeleteButton()                
              
        {
        
   
        }
            
        public virtual void SetUsers_RolesResetButton()                
              
        {
        
   
        }
            
        public virtual void SetUsers_RolesSaveButton()                
              
        {
        
                    this.Users_RolesSaveButton.Attributes.Add("onclick", "SubmitHRefOnce(this, \"" + this.Page.GetResourceValue("Txt:SaveRecord", "IPv5") + "\");");
                  
   
        }
            
        public virtual void SetUsers_RolesButtonsButton()                
              
        {
        
   
        }
            
        public virtual void SetUsers_RolesFilterButton()                
              
        {
        
   
        }
            
        public virtual void SetUsers_RolesFiltersButton()                
              
        {
                
         IThemeButtonWithArrow themeButtonUsers_RolesFiltersButton = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "Users_RolesFiltersButton"));
         themeButtonUsers_RolesFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
            if (MiscUtils.IsValueSelected(RoleIDFilter))
                themeButtonUsers_RolesFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(UserIDFilter))
                themeButtonUsers_RolesFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
   
        }
               
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void Users_RolesPagination_FirstPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void Users_RolesPagination_LastPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void Users_RolesPagination_NextPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void Users_RolesPagination_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.Users_RolesPagination.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.Users_RolesPagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void Users_RolesPagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
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
        
        public virtual void RoleIDSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by RoleID when clicked.
              
            // Get previous sorting state for RoleID.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Users_RolesTable.RoleID);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for RoleID.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Users_RolesTable.RoleID, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by RoleID, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void UserIDSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by UserID when clicked.
              
            // Get previous sorting state for UserID.
        
            OrderByItem sd = this.CurrentSortOrder.Find(Users_RolesTable.UserId0);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for UserID.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(Users_RolesTable.UserId0, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by UserID, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void Users_RolesAddButton_Click(object sender, ImageClickEventArgs args)
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
        public virtual void Users_RolesDeleteButton_Click(object sender, ImageClickEventArgs args)
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
            
            
        
        // event handler for ImageButton
        public virtual void Users_RolesResetButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
              this.RoleIDFilter.ClearSelection();
            
              this.UserIDFilter.ClearSelection();
            
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
        public virtual void Users_RolesSaveButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                
        
              if (!this.Page.IsPageRefresh)
              {
                  this.SaveData();
              }

          this.Page.CommitTransaction(sender);
          // Set IsNewRecord to False for all records - since everything has been saved and is no longer "new"
           
                foreach (Users_RolesTableControlRow recCtl in this.GetRecordControls()){
                     
                    recCtl.IsNewRecord = false;
                }
      
          // Set DeletedRecordsIds to Nothing since we have deleted all pending deletes.
          
                this.DeletedRecordIds = null;
            
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
        public virtual void Users_RolesButtonsButton_Click(object sender, EventArgs args)
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
        public virtual void Users_RolesFilterButton_Click(object sender, EventArgs args)
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
        public virtual void Users_RolesFiltersButton_Click(object sender, EventArgs args)
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
        protected virtual void RoleIDFilter_SelectedIndexChanged(object sender, EventArgs args)
        {
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            
           				
        }
            
        // event handler for FieldFilter
        protected virtual void UserIDFilter_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = Users_RolesTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  Users_RolesRecord[] DataSource {
             
            get {
                return (Users_RolesRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public System.Web.UI.WebControls.DropDownList RoleIDFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RoleIDFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal RoleIDLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RoleIDLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton RoleIDSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RoleIDSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList UserIDFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "UserIDFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal UserIDLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "UserIDLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton UserIDSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "UserIDSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton Users_RolesAddButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Users_RolesAddButton");
            }
        }
        
        public IPv5.UI.IThemeButtonWithArrow Users_RolesButtonsButton {
            get {
                return (IPv5.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Users_RolesButtonsButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton Users_RolesDeleteButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Users_RolesDeleteButton");
            }
        }
        
        public IPv5.UI.IThemeButton Users_RolesFilterButton {
            get {
                return (IPv5.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Users_RolesFilterButton");
            }
        }
        
        public IPv5.UI.IThemeButtonWithArrow Users_RolesFiltersButton {
            get {
                return (IPv5.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Users_RolesFiltersButton");
            }
        }
        
        public IPv5.UI.IPaginationModern Users_RolesPagination {
            get {
                return (IPv5.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Users_RolesPagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton Users_RolesResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Users_RolesResetButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton Users_RolesSaveButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Users_RolesSaveButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal Users_RolesTitle {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Users_RolesTitle");
            }
        }
        
        public System.Web.UI.WebControls.CheckBox Users_RolesToggleAll {
            get {
                return (System.Web.UI.WebControls.CheckBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Users_RolesToggleAll");
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
                Users_RolesTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IPv5"));
                }

        Users_RolesRecord rec = null;
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
                Users_RolesTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IPv5"));
                }

        Users_RolesRecord rec = null;
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
            foreach (Users_RolesTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.Users_RolesRecordRowSelection.Checked) {
                    return counter;
                }
                counter += 1;
            }
            return -1;
        }
        
        public virtual Users_RolesTableControlRow GetSelectedRecordControl()
        {
        Users_RolesTableControlRow[] selectedList = this.GetSelectedRecordControls();
            if (selectedList.Length == 0) {
            return null;
            }
            return selectedList[0];
          
        }

        public virtual Users_RolesTableControlRow[] GetSelectedRecordControls()
        {
        
            ArrayList selectedList = new ArrayList(25);
            foreach (Users_RolesTableControlRow recControl in this.GetRecordControls())
            {
                if (recControl.Users_RolesRecordRowSelection != null && recControl.Users_RolesRecordRowSelection.Checked) {
                    selectedList.Add(recControl);
                }
            }
            return (Users_RolesTableControlRow[])(selectedList.ToArray(Type.GetType("IPv5.UI.Controls.EditUsers_RolesTable.Users_RolesTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            Users_RolesTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IPv5"));
            }
            
            foreach (Users_RolesTableControlRow recCtl in recordList)
            {
                if (deferDeletion) {
                    if (!recCtl.IsNewRecord) {
                
                        this.AddToDeletedRecordIds(recCtl);
                  
                    }
                    recCtl.Visible = false;
                
                    recCtl.Users_RolesRecordRowSelection.Checked = false;
                
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

        public virtual Users_RolesTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "Users_RolesTableControlRow");
	          List<Users_RolesTableControlRow> list = new List<Users_RolesTableControlRow>();
	          foreach (Users_RolesTableControlRow recCtrl in recCtrls) {
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
  

#endregion
    
  
}

  