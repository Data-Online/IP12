
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// ShowPropertyNotesGallery.aspx page.  The Row or RecordControl classes are the 
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

  
namespace IPv5.UI.Controls.ShowPropertyNotesGallery
{
  

#region "Section 1: Place your customizations here."

    
public class PropertyNotesTableControlRow : BasePropertyNotesTableControlRow
{
      
        // The BasePropertyNotesTableControlRow implements code for a ROW within the
        // the PropertyNotesTableControl table.  The BasePropertyNotesTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of PropertyNotesTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class PropertyNotesTableControl : BasePropertyNotesTableControl
{
    // The BasePropertyNotesTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The PropertyNotesTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the PropertyNotesTableControlRow control on the ShowPropertyNotesGallery page.
// Do not modify this class. Instead override any method in PropertyNotesTableControlRow.
public class BasePropertyNotesTableControlRow : IPv5.UI.BaseApplicationRecordControl
{
        public BasePropertyNotesTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in PropertyNotesTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in PropertyNotesTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.Notes.Click += Notes_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseMM_IP1%dbo.PropertyNotes record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = PropertyNotesTable.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BasePropertyNotesTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new PropertyNotesRecord();
            
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
              
            //This is to make sure all the controls will be invisible if no record is present in the cell
            
            // LoadData for DataSource for chart and report if they exist
          
            // Store the checksum. The checksum is used to
            // ensure the record was not changed by another user.
            if (this.DataSource.GetCheckSumValue() != null)
                this.CheckSum = this.DataSource.GetCheckSumValue().Value;
            

            // Call the Set methods for each controls on the panel
        
                SetNotes();
                SetPropertyID();

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
                if (this.DataSource.GetID() != null)
                    this.RecordUniqueId = this.DataSource.GetID().ToXmlString();
              
            }
            
                if (this.DataSource.GetID() == null)
                  this.IsNewRecord = false;
              

            // Now load data for each record and table child UI controls.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
            bool shouldResetControl = false;
            if (shouldResetControl) { }; // prototype usage to void compiler warnings
            
        }
        
        
        public virtual string GetImageWithOverlaidText(string imgFieldName, object otherFieldName, string redirectURL) {
        
            return this.Page.GetImageWithOverlaidText(imgFieldName, this.DataSource, otherFieldName, redirectURL);
        }
    
        public virtual void SetNotes()
        {
            
                    
            // Set the Notes LinkButton on the webpage with value from the
            // DatabaseMM_IP1%dbo.PropertyNotes database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.PropertyNotes record retrieved from the database.
            // this.Notes is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.NotesSpecified) {
                								
                // If the Notes is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(PropertyNotesTable.Notes);
                                
                this.Notes.Text = formattedValue;
                
                  this.Notes.ToolTip = "Go to " + this.Notes.Text.Replace("<wbr/>", "");
                   
            } 
            
            else {
            
                // Notes is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Notes.Text = PropertyNotesTable.Notes.Format(PropertyNotesTable.Notes.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetPropertyID()
        {
            
                    
            // Set the PropertyID Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.PropertyNotes database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.PropertyNotes record retrieved from the database.
            // this.PropertyID is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PropertyIDSpecified) {
                								
                // If the PropertyID is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = PropertyNotesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(PropertyNotesTable.PropertyID);
               if(_isExpandableNonCompositeForeignKey &&PropertyNotesTable.PropertyID.IsApplyDisplayAs)
                                  
                     formattedValue = PropertyNotesTable.GetDFKA(this.DataSource.PropertyID.ToString(),PropertyNotesTable.PropertyID, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(PropertyNotesTable.PropertyID);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PropertyID.Text = formattedValue;
                   
            } 
            
            else {
            
                // PropertyID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PropertyID.Text = PropertyNotesTable.PropertyID.Format(PropertyNotesTable.PropertyID.DefaultValue);
            		
            }
            
            // If the PropertyID is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PropertyID.Text == null ||
                this.PropertyID.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PropertyID.Text = "&nbsp;";
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
                ((PropertyNotesTableControl)MiscUtils.GetParentControlObject(this, "PropertyNotesTableControl")).DataChanged = true;
                ((PropertyNotesTableControl)MiscUtils.GetParentControlObject(this, "PropertyNotesTableControl")).ResetData = true;
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
        
            GetNotes();
            GetPropertyID();
        }
        
        
        public virtual void GetNotes()
        {
            
        }
                
        public virtual void GetPropertyID()
        {
            
        }
                

      // To customize, override this method in PropertyNotesTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersPropertyNotesTableControl = false;
            hasFiltersPropertyNotesTableControl = hasFiltersPropertyNotesTableControl && false; // suppress warning
      
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
          PropertyNotesTable.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((PropertyNotesTableControl)MiscUtils.GetParentControlObject(this, "PropertyNotesTableControl")).DataChanged = true;
            ((PropertyNotesTableControl)MiscUtils.GetParentControlObject(this, "PropertyNotesTableControl")).ResetData = true;
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
        
        // event handler for LinkButton
        public virtual void Notes_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../PropertyNotes/ShowPropertyNotes.aspx?PropertyNotes={PK}";
            
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
                return (string)this.ViewState["BasePropertyNotesTableControlRow_Rec"];
            }
            set {
                this.ViewState["BasePropertyNotesTableControlRow_Rec"] = value;
            }
        }
        
        public PropertyNotesRecord DataSource {
            get {
                return (PropertyNotesRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.LinkButton Notes {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Notes");
            }
        }
            
        public System.Web.UI.WebControls.Literal PropertyID {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyID");
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
        PropertyNotesRecord rec = null;
             
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
    PropertyNotesRecord rec = null;
    
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

        
        public virtual PropertyNotesRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return PropertyNotesTable.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the PropertyNotesTableControl control on the ShowPropertyNotesGallery page.
// Do not modify this class. Instead override any method in PropertyNotesTableControl.
public class BasePropertyNotesTableControl : IPv5.UI.BaseApplicationTableControl
{
         
       public BasePropertyNotesTableControl()
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
                if  (this.InSession(this.NotesFilter)) 				
                    initialVal = this.GetFromSession(this.NotesFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"Notes\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.NotesFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.NotesFilter.SelectedValue = initialVal;
                            
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
                if  (this.InSession(this.PropertyNotesSearch)) 				
                    initialVal = this.GetFromSession(this.PropertyNotesSearch);
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.PropertyNotesSearch.Text = initialVal;
                            
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


        this.VerticalColumns = Convert.ToInt32(this.GetFromSession(this, "Vertical_Columns", "3"));
      

    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "10"));
            this.PageIndex = Convert.ToInt32(this.GetFromSession(this, "Page_Index", "0"));
                     
        }

        protected virtual void Control_Load(object sender, EventArgs e)
        {
        
            SaveControlsToSession_Ajax();
        
            // Setup the pagination events.
            
                    this.PropertyNotesPagination.FirstPage.Click += PropertyNotesPagination_FirstPage_Click;
                        
                    this.PropertyNotesPagination.LastPage.Click += PropertyNotesPagination_LastPage_Click;
                        
                    this.PropertyNotesPagination.NextPage.Click += PropertyNotesPagination_NextPage_Click;
                        
                    this.PropertyNotesPagination.PageSizeButton.Click += PropertyNotesPagination_PageSizeButton_Click;
                        
                    this.PropertyNotesPagination.PreviousPage.Click += PropertyNotesPagination_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
              this.NotesSortLabel.Click += NotesSortLabel_Click;
            
              this.PropertyIDSortLabel.Click += PropertyIDSortLabel_Click;
            
            // Setup the button events.
          
                    this.PropertyNotesExportExcelButton.Click += PropertyNotesExportExcelButton_Click;
                        
                    this.PropertyNotesImportButton.Click += PropertyNotesImportButton_Click;
                        
                    this.PropertyNotesNewButton.Click += PropertyNotesNewButton_Click;
                        
                    this.PropertyNotesPDFButton.Click += PropertyNotesPDFButton_Click;
                        
                    this.PropertyNotesResetButton.Click += PropertyNotesResetButton_Click;
                        
                    this.PropertyNotesSearchButton.Click += PropertyNotesSearchButton_Click;
                        
                    this.PropertyNotesWordButton.Click += PropertyNotesWordButton_Click;
                        
                    this.PropertyNotesButtonsButton.Button.Click += PropertyNotesButtonsButton_Click;
                        
                    this.PropertyNotesFilterButton.Button.Click += PropertyNotesFilterButton_Click;
                        
                    this.PropertyNotesFiltersButton.Button.Click += PropertyNotesFiltersButton_Click;
                        
            this.NotesFilter.SelectedIndexChanged += new EventHandler(NotesFilter_SelectedIndexChanged);
            
            this.PropertyIDFilter.SelectedIndexChanged += new EventHandler(PropertyIDFilter_SelectedIndexChanged);
                    
        
         //' Setup events for others
            AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "PropertyNotesSearchSearchBoxText", "setSearchBoxText(\"" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "\", \"" + PropertyNotesSearch.ClientID + "\");", true);
             
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
                      Type myrec = typeof(IPv5.Business.PropertyNotesRecord);
                      this.DataSource = (PropertyNotesRecord[])(alist.ToArray(myrec));
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
                     
                        int totalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(totalRecords) / (Convert.ToDouble(this.PageSize * this.VerticalColumns))));
                       
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
                    foreach (PropertyNotesTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(IPv5.Business.PropertyNotesRecord);
                    this.DataSource = (PropertyNotesRecord[])(postdata.ToArray(myrec));
                } 
                else {
                    // Get the records from the database
                    
                        this.DataSource = GetRecords(joinFilter, wc, orderBy, this.PageIndex, (this.PageSize * this.VerticalColumns));
                                          
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
        
        public virtual PropertyNotesRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(PropertyNotesTable.Column1, true);          
            // selCols.Add(PropertyNotesTable.Column2, true);          
            // selCols.Add(PropertyNotesTable.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return PropertyNotesTable.GetRecords(join, where, orderBy, this.PageIndex, (this.PageSize * this.VerticalColumns));
                 
            }
            else
            {
                PropertyNotesTable databaseTable = new PropertyNotesTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(PropertyNotesRecord)) as PropertyNotesRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(PropertyNotesTable.Column1, true);          
            // selCols.Add(PropertyNotesTable.Column2, true);          
            // selCols.Add(PropertyNotesTable.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return PropertyNotesTable.GetRecordCount(join, where);
            else
            {
                PropertyNotesTable databaseTable = new PropertyNotesTable();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);        
                
                return (int)(databaseTable.GetRecordListCount(join, where.GetFilter(), null, null));
            }

        }
        
      
      public virtual PropertyNotesRecord[] CopyArray(int index, PropertyNotesRecord[,] recs, int columns)
      {
        PropertyNotesRecord[] recsCopy = new PropertyNotesRecord[columns];
        for (int counter = 0; counter <= columns - 1; counter++)
        {
            recsCopy[counter] = recs[index, counter];
        }
        return recsCopy;
      }

      public virtual int CalculateRows(int dataSourceLength, int columns, int pageSize)
      {
        return BaseClasses.Utils.MiscUtils.CalculateRows(dataSourceLength, columns, pageSize);
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

    
        
            int pageSize = this.PageSize;

            int rows = CalculateRows(DataSource.Length, this.VerticalColumns, pageSize);
            PropertyNotesRecord[,] recs = new PropertyNotesRecord[Convert.ToInt32(rows - 1) + 1, this.VerticalColumns];

            int hColumns = 0;
            for (int counter = 0; counter <= Convert.ToInt32(rows - 1); counter++)
            {
              for (int innerCounter = 0; innerCounter <= this.VerticalColumns - 1; innerCounter++)
              {
                if (DataSource.Length > hColumns)
                {
                  recs[counter, innerCounter] = DataSource[hColumns];
                  hColumns += 1;
                }
              }
            }
            
            PropertyNotesRecord[] HColDataSource = new PropertyNotesRecord[Convert.ToInt32(rows)];

            // Bind the repeater with the list of records to expand the UI.
            
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyNotesTableControlRepeater");
              if (rep == null)
                return;
              rep.DataSource = HColDataSource;
              rep.DataBind();

              int index = 0;
              int remainingDLength = DataSource.Length;
              foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
              {
            
            
              // Loop through all rows in the table, set its DataSource and call DataBind().

              if (remainingDLength > this.VerticalColumns)
              {
                remainingDLength = remainingDLength - this.VerticalColumns;
              }

              PropertyNotesRecord[] VColDataSource = new PropertyNotesRecord[this.VerticalColumns];

              System.Web.UI.WebControls.Repeater repControl = (System.Web.UI.WebControls.Repeater)repItem.FindControl("PropertyNotesTableControlCellRepeater");
              if (repControl == null)
                  break;
              repControl.DataSource = VColDataSource;
              repControl.DataBind();

              PropertyNotesRecord[] recsCopy = CopyArray(index, recs, this.VerticalColumns);
              int indexInnerRep = 0;
              foreach (System.Web.UI.WebControls.RepeaterItem innerRepItem in repControl.Items) {
                PropertyNotesTableControlRow recControl = (PropertyNotesTableControlRow)innerRepItem.FindControl("PropertyNotesTableControlRow");
                recControl.DataSource = recsCopy[indexInnerRep];
                if (this.UIData.Count > indexInnerRep) {
                  recControl.PreviousUIData = this.UIData[indexInnerRep];
                }
                if (recControl.DataSource != null){
                  recControl.DataBind();
                  
                    recControl.Visible = !this.InDeletedRecordIds(recControl);
                  
                }else{
                  recControl.DataBind();
                  recControl.IsNewRecord = false;
                }
                indexInnerRep += 1;
              }
              index += 1;
            }
      
    
            // Call the Set methods for each controls on the panel
        
                SetNotesFilter();
                SetNotesLabel1();
                SetNotesSortLabel();
                SetPropertyIDFilter();
                SetPropertyIDLabel1();
                SetPropertyIDSortLabel();
                
                
                
                
                
                
                
                
                
                SetPropertyNotesSearch();
                
                
                
                
                SetPropertyNotesExportExcelButton();
              
                SetPropertyNotesImportButton();
              
                SetPropertyNotesNewButton();
              
                SetPropertyNotesPDFButton();
              
                SetPropertyNotesResetButton();
              
                SetPropertyNotesSearchButton();
              
                SetPropertyNotesWordButton();
              
                SetPropertyNotesButtonsButton();
              
                SetPropertyNotesFilterButton();
              
                SetPropertyNotesFiltersButton();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetPropertyNotesFiltersButton();
                     
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
    public virtual void AddWarningMessageOnClick() {
    
        if (this.TotalRecords > 10000)
          this.PropertyNotesExportExcelButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm", "IPv5") + "'));");
        else
          this.PropertyNotesExportExcelButton.Attributes.Remove("onClick");
      
    }
  
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(PropertyNotesTable.PropertyID, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"PropertyNotesExportExcelButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"PropertyNotesPDFButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"PropertyNotesWordButton"));
                                
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


            
            this.NotesFilter.ClearSelection();
            
            this.PropertyIDFilter.ClearSelection();
            
            this.PropertyNotesSearch.Text = "";
            
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
                this.PropertyNotesPagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.PropertyNotesPagination.CurrentPage.Text = "0";
            }
            this.PropertyNotesPagination.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for PropertyNotesTableControl pagination.
        
            this.PropertyNotesPagination.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.PropertyNotesPagination.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.PropertyNotesPagination.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.PropertyNotesPagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.PropertyNotesPagination.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.PropertyNotesPagination.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.PropertyNotesPagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.PropertyNotesPagination.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (PropertyNotesTableControlRow recCtl in this.GetRecordControls())
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
            foreach (PropertyNotesTableControlRow recCtl in this.GetRecordControls()){
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
            PropertyNotesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            if (MiscUtils.IsValueSelected(this.NotesFilter)) {
                        
                wc.iAND(PropertyNotesTable.Notes, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.NotesFilter, this.GetFromSession(this.NotesFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.PropertyIDFilter)) {
                        
                wc.iAND(PropertyNotesTable.PropertyID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.PropertyIDFilter, this.GetFromSession(this.PropertyIDFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.PropertyNotesSearch)) {
                if (this.PropertyNotesSearch.Text == BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) ) {
                        this.PropertyNotesSearch.Text = "";
                } else {
                  // Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                  if (this.PropertyNotesSearch.Text.StartsWith("...")) {
                      this.PropertyNotesSearch.Text = this.PropertyNotesSearch.Text.Substring(3,this.PropertyNotesSearch.Text.Length-3);
                  }
                  if (this.PropertyNotesSearch.Text.EndsWith("...")) {
                      this.PropertyNotesSearch.Text = this.PropertyNotesSearch.Text.Substring(0,this.PropertyNotesSearch.Text.Length-3);
                      // Strip the last word as well as it is likely only a partial word
                      int endindex = this.PropertyNotesSearch.Text.Length - 1;
                      while (!Char.IsWhiteSpace(PropertyNotesSearch.Text[endindex]) && endindex > 0) {
                          endindex--;
                      }
                      if (endindex > 0) {
                          this.PropertyNotesSearch.Text = this.PropertyNotesSearch.Text.Substring(0, endindex);
                      }
                  }
                }
                string formatedSearchText = MiscUtils.GetSelectedValue(this.PropertyNotesSearch, this.GetFromSession(this.PropertyNotesSearch));
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(this.PropertyNotesSearch)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                  
                    WhereClause search = new WhereClause();
                    
        ColumnList cols = new ColumnList();
      
      cols.Add(PropertyNotesTable.Notes, true);
      
      foreach(BaseColumn col in cols)
      {
      
          search.iOR(col, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(this.PropertyNotesSearch, this.GetFromSession(this.PropertyNotesSearch)), true, false);
        
      }
    
                    wc.iAND(search);
                  
                }
            }
                       
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            PropertyNotesTable.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String NotesFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "NotesFilter_Ajax"];
            if (MiscUtils.IsValueSelected(NotesFilterSelectedValue)) {

              
                wc.iAND(PropertyNotesTable.Notes, BaseFilter.ComparisonOperator.EqualsTo, NotesFilterSelectedValue, false, false);
                      
      }
                      
      String PropertyIDFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "PropertyIDFilter_Ajax"];
            if (MiscUtils.IsValueSelected(PropertyIDFilterSelectedValue)) {

              
                wc.iAND(PropertyNotesTable.PropertyID, BaseFilter.ComparisonOperator.EqualsTo, PropertyIDFilterSelectedValue, false, false);
                      
      }
                      
            if (MiscUtils.IsValueSelected(searchText) && fromSearchControl == "PropertyNotesSearch") {
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
      
      cols.Add(PropertyNotesTable.Notes, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(PropertyNotesTable.Notes, true);
      
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

        
        public virtual string[] GetAutoCompletionList_PropertyNotesSearch(String prefixText,int count)
        {
            ArrayList resultList = new ArrayList();
            ArrayList wordList= new ArrayList();
            
            CompoundFilter filterJoin = CreateCompoundJoinFilter();    
            WhereClause wc = CreateWhereClause(prefixText,"PropertyNotesSearch", "WordsStartingWithSearchString", "[^a-zA-Z0-9]");
            if(count==0) count = 10;
            IPv5.Business.PropertyNotesRecord[] recordList  = PropertyNotesTable.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (PropertyNotesRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(PropertyNotesTable.Notes);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(PropertyNotesTable.Notes.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, PropertyNotesTable.Notes.IsFullTextSearchable);
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
        
            if (this.PropertyNotesPagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.PropertyNotesPagination.PageSize.Text);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyNotesTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                
                  System.Web.UI.WebControls.Repeater repControl = (System.Web.UI.WebControls.Repeater)(repItem.FindControl("PropertyNotesTableControlCellRepeater"));
                  if (repControl == null) break;
                  foreach (System.Web.UI.WebControls.RepeaterItem innerRepItem in repControl.Items)
                  {
                    PropertyNotesTableControlRow recControl = (PropertyNotesTableControlRow)(innerRepItem.FindControl("PropertyNotesTableControlRow"));
                  
                    if (recControl.Visible && recControl.IsNewRecord) {
      PropertyNotesRecord rec = new PropertyNotesRecord();
        
                        if (recControl.Notes.Text != "") {
                            rec.Parse(recControl.Notes.Text, PropertyNotesTable.Notes);
                  }
                
                        if (recControl.PropertyID.Text != "") {
                            rec.Parse(recControl.PropertyID.Text, PropertyNotesTable.PropertyID);
                  }
                
                      newUIDataList.Add(recControl.PreservedUIData());
                      newRecordList.Add(rec);
                    }
                  }
                }
       
            }
      
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new PropertyNotesRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(IPv5.Business.PropertyNotesRecord);
                this.DataSource = (PropertyNotesRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(PropertyNotesTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(PropertyNotesTableControlRow rec)            
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
        
        public virtual void SetNotesLabel1()
                  {
                  
                    
        }
                
        public virtual void SetNotesSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetPropertyIDLabel1()
                  {
                  
                    
        }
                
        public virtual void SetPropertyIDSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetNotesFilter()
        {
            
            this.PopulateNotesFilter(MiscUtils.GetSelectedValue(this.NotesFilter,  GetFromSession(this.NotesFilter)), 500);					
                                     
        }
            
        public virtual void SetPropertyIDFilter()
        {
            
            this.PopulatePropertyIDFilter(MiscUtils.GetSelectedValue(this.PropertyIDFilter,  GetFromSession(this.PropertyIDFilter)), 500);					
                                     
        }
            
        public virtual void SetPropertyNotesSearch()
        {
                                            
            this.PropertyNotesSearch.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "') {this.value='';this.className='Search_Input';}");
            this.PropertyNotesSearch.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "';this.className='Search_InputHint';}");
                                   
        }
            
        // Get the filters' data for NotesFilter.
                
        protected virtual void PopulateNotesFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.NotesFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_NotesFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_NotesFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.NotesFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "IPv5"), "--ANY--"));
              
            
            
            OrderBy orderBy = new OrderBy(false, false);
            orderBy.Add(PropertyNotesTable.Notes, OrderByItem.OrderDir.Asc);                
            
            
            string[] values = new string[0];
            if (wc.RunQuery)
            {
            
                values = PropertyNotesTable.GetValues(PropertyNotesTable.Notes, wc, orderBy, maxItems);
            
            }
            
            ArrayList listDuplicates = new ArrayList();
            foreach (string cvalue in values)
            {
            // Create the item and add to the list.
            string fvalue;
            if ( PropertyNotesTable.Notes.IsColumnValueTypeBoolean()) {
                    fvalue = cvalue;
                }else {
                    fvalue = PropertyNotesTable.Notes.Format(cvalue);
                }
                if (fvalue == null) {
                    fvalue = "";
                }

                fvalue = fvalue.Trim();

                if ( fvalue.Length > 50 ) {
                    fvalue = fvalue.Substring(0, 50) + "...";
                }

                ListItem dupItem = this.NotesFilter.Items.FindByText(fvalue);
								
                if (dupItem != null) {
                    listDuplicates.Add(fvalue);
                    if (!string.IsNullOrEmpty(dupItem.Value))
                    {
                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                    }
                }

                ListItem newItem = new ListItem(fvalue, cvalue);
                this.NotesFilter.Items.Add(newItem);

                if (listDuplicates.Contains(fvalue) &&  !string.IsNullOrEmpty(cvalue)) {
                    newItem.Text = fvalue + " (ID " + cvalue.Substring(0, Math.Min(cvalue.Length,38)) + ")";
                }
            }

                          
            try
            {
      
                
                // Set the selected value.
                MiscUtils.SetSelectedValue(this.NotesFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.NotesFilter.SelectedValue != null && this.NotesFilter.Items.FindByValue(this.NotesFilter.SelectedValue) == null)
                this.NotesFilter.SelectedValue = null;
                           
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
                                    
                                Boolean _isExpandableNonCompositeForeignKey = PropertyNotesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(PropertyNotesTable.PropertyID);
                                if(_isExpandableNonCompositeForeignKey && PropertyNotesTable.PropertyID.IsApplyDisplayAs)
                                     fvalue = PropertyNotesTable.GetDFKA(itemValue, PropertyNotesTable.PropertyID);
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
            
        public virtual WhereClause CreateWhereClause_NotesFilter()
        {
            // Create a where clause for the filter NotesFilter.
            // This function is called by the Populate method to load the items 
            // in the NotesFilterDropDownList
        
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
        
            this.SaveToSession(this.NotesFilter, this.NotesFilter.SelectedValue);
                  
            this.SaveToSession(this.PropertyIDFilter, this.PropertyIDFilter.SelectedValue);
                  
            this.SaveToSession(this.PropertyNotesSearch, this.PropertyNotesSearch.Text);
                  
            
                    
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
          
            this.SaveToSession(this, "Vertical_Columns", this.VerticalColumns.ToString());
          
            this.SaveToSession(this, "DeletedRecordIds", this.DeletedRecordIds);
        
        }
        
        
        protected  void SaveControlsToSession_Ajax()
        {
            // Save filter controls to values to session.
          
      this.SaveToSession("NotesFilter_Ajax", this.NotesFilter.SelectedValue);
              
      this.SaveToSession("PropertyIDFilter_Ajax", this.PropertyIDFilter.SelectedValue);
              
      this.SaveToSession("PropertyNotesSearch_Ajax", this.PropertyNotesSearch.Text);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.NotesFilter);
            this.RemoveFromSession(this.PropertyIDFilter);
            this.RemoveFromSession(this.PropertyNotesSearch);
            
            // Clear pagination state from session.
         

    // Clear table properties from the session.
    this.RemoveFromSession(this, "Order_By");
    this.RemoveFromSession(this, "Page_Index");
    this.RemoveFromSession(this, "Page_Size");
    
      this.RemoveFromSession(this, "Vertical_Columns");
    
            this.RemoveFromSession(this, "DeletedRecordIds");
            
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["PropertyNotesTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("PropertyNotesPagination");
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
            
          
            if (ViewState["Vertical_Columns"] != null) {
              this.VerticalColumns = (int)ViewState["Vertical_Columns"];
            }
          
            // Load view state for pagination control.
    
            this.DeletedRecordIds = (string)this.ViewState["DeletedRecordIds"];
        
        }

        protected override object SaveViewState()
        {            
          
            if (this.CurrentSortOrder != null) {
                this.ViewState["PropertyNotesTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
      this.ViewState["Vertical_Columns"] = this.VerticalColumns;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetPropertyNotesExportExcelButton()                
              
        {
        
   
        }
            
        public virtual void SetPropertyNotesImportButton()                
              
        {
        							
                    this.PropertyNotesImportButton.PostBackUrl = "../Shared/SelectFileToImport.aspx?TableName=PropertyNotes" ;
                    this.PropertyNotesImportButton.Attributes["onClick"] = "window.open('" + this.Page.EncryptUrlParameter(this.PropertyNotesImportButton.PostBackUrl) + "','importWindow', 'width=700, height=500,top=' +(screen.availHeight-500)/2 + ',left=' + (screen.availWidth-700)/2+ ', resizable=yes, scrollbars=yes,modal=yes'); return false;";
                        
   
        }
            
        public virtual void SetPropertyNotesNewButton()                
              
        {
        
   
        }
            
        public virtual void SetPropertyNotesPDFButton()                
              
        {
        
   
        }
            
        public virtual void SetPropertyNotesResetButton()                
              
        {
        
   
        }
            
        public virtual void SetPropertyNotesSearchButton()                
              
        {
        
   
        }
            
        public virtual void SetPropertyNotesWordButton()                
              
        {
        
   
        }
            
        public virtual void SetPropertyNotesButtonsButton()                
              
        {
        
   
        }
            
        public virtual void SetPropertyNotesFilterButton()                
              
        {
        
   
        }
            
        public virtual void SetPropertyNotesFiltersButton()                
              
        {
                
         IThemeButtonWithArrow themeButtonPropertyNotesFiltersButton = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "PropertyNotesFiltersButton"));
         themeButtonPropertyNotesFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
            if (MiscUtils.IsValueSelected(NotesFilter))
                themeButtonPropertyNotesFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(PropertyIDFilter))
                themeButtonPropertyNotesFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
   
        }
               
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void PropertyNotesPagination_FirstPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void PropertyNotesPagination_LastPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void PropertyNotesPagination_NextPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void PropertyNotesPagination_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.PropertyNotesPagination.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.PropertyNotesPagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void PropertyNotesPagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
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
        
        public virtual void NotesSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by Notes when clicked.
              
            // Get previous sorting state for Notes.
        
            OrderByItem sd = this.CurrentSortOrder.Find(PropertyNotesTable.Notes);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Notes.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(PropertyNotesTable.Notes, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by Notes, so just reverse.
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
        
            OrderByItem sd = this.CurrentSortOrder.Find(PropertyNotesTable.PropertyID);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for PropertyID.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(PropertyNotesTable.PropertyID, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by PropertyID, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void PropertyNotesExportExcelButton_Click(object sender, ImageClickEventArgs args)
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


              this.TotalRecords = PropertyNotesTable.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             PropertyNotesTable.PropertyID,
             PropertyNotesTable.Notes,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(PropertyNotesTable.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(PropertyNotesTable.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(PropertyNotesTable.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(PropertyNotesTable.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(PropertyNotesTable.PropertyID, "Default"));
             data.ColumnList.Add(new ExcelColumn(PropertyNotesTable.Notes, "Default"));


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
                val = PropertyNotesTable.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
        public virtual void PropertyNotesImportButton_Click(object sender, ImageClickEventArgs args)
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
        public virtual void PropertyNotesNewButton_Click(object sender, ImageClickEventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../PropertyNotes/AddPropertyNotes.aspx";
            
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
        public virtual void PropertyNotesPDFButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                PDFReport report = new PDFReport();

                report.SpecificReportFileName = Page.Server.MapPath("ShowPropertyNotesGallery.PropertyNotesPDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "PropertyNotes";
                // If ShowPropertyNotesGallery.PropertyNotesPDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(PropertyNotesTable.PropertyID.Name, ReportEnum.Align.Left, "${PropertyID}", ReportEnum.Align.Left, 28);
                 report.AddColumn(PropertyNotesTable.Notes.Name, ReportEnum.Align.Left, "${Notes}", ReportEnum.Align.Left, 28);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "IPv5");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = PropertyNotesTable.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = PropertyNotesTable.GetRecordCount(joinFilter,whereClause);
                PropertyNotesRecord[] records = null;
                
                do
                {
                    
                    records = PropertyNotesTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( PropertyNotesRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 if (BaseClasses.Utils.MiscUtils.IsNull(record.PropertyID)){
                                 report.AddData("${PropertyID}", "",ReportEnum.Align.Left, 100);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = PropertyNotesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(PropertyNotesTable.PropertyID);
                                 _DFKA = PropertyNotesTable.GetDFKA(record.PropertyID.ToString(), PropertyNotesTable.PropertyID,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  PropertyNotesTable.PropertyID.IsApplyDisplayAs){
                                     report.AddData("${PropertyID}", _DFKA,ReportEnum.Align.Left, 100);
                                 }else{
                                     report.AddData("${PropertyID}", record.Format(PropertyNotesTable.PropertyID), ReportEnum.Align.Left, 100);
                                 }
                             }
                             report.AddData("${Notes}", record.Format(PropertyNotesTable.Notes), ReportEnum.Align.Left);

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
        public virtual void PropertyNotesResetButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
              this.NotesFilter.ClearSelection();
            
              this.PropertyIDFilter.ClearSelection();
            
              this.PropertyNotesSearch.Text = "";
            
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
        public virtual void PropertyNotesSearchButton_Click(object sender, ImageClickEventArgs args)
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
        public virtual void PropertyNotesWordButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("ShowPropertyNotesGallery.PropertyNotesWordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "PropertyNotes";
                // If ShowPropertyNotesGallery.PropertyNotesWordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(PropertyNotesTable.PropertyID.Name, ReportEnum.Align.Left, "${PropertyID}", ReportEnum.Align.Left, 28);
                 report.AddColumn(PropertyNotesTable.Notes.Name, ReportEnum.Align.Left, "${Notes}", ReportEnum.Align.Left, 28);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = PropertyNotesTable.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "IPv5");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = PropertyNotesTable.GetColumnList();
                PropertyNotesRecord[] records = null;
                do
                {
                    records = PropertyNotesTable.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( PropertyNotesRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.PropertyID)){
                                 report.AddData("${PropertyID}", "",ReportEnum.Align.Left, 100);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = PropertyNotesTable.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(PropertyNotesTable.PropertyID);
                                 _DFKA = PropertyNotesTable.GetDFKA(record.PropertyID.ToString(), PropertyNotesTable.PropertyID,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  PropertyNotesTable.PropertyID.IsApplyDisplayAs){
                                     report.AddData("${PropertyID}", _DFKA,ReportEnum.Align.Left, 100);
                                 }else{
                                     report.AddData("${PropertyID}", record.Format(PropertyNotesTable.PropertyID), ReportEnum.Align.Left, 100);
                                 }
                             }
                             report.AddData("${Notes}", record.Format(PropertyNotesTable.Notes), ReportEnum.Align.Left);

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
        public virtual void PropertyNotesButtonsButton_Click(object sender, EventArgs args)
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
        public virtual void PropertyNotesFilterButton_Click(object sender, EventArgs args)
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
        public virtual void PropertyNotesFiltersButton_Click(object sender, EventArgs args)
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
        protected virtual void NotesFilter_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = PropertyNotesTable.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
                }
                return (this._TotalRecords);
            }
            set {
                if (this.PageSize > 0) {
                  
                      this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(value) / (Convert.ToDouble(this.PageSize) * Convert.ToDouble(this.VerticalColumns))));
                          
                }
                this._TotalRecords = value;
            }
        }

      
        private int _VerticalColumns;
        public int VerticalColumns
        {
            get {
                return _VerticalColumns;
            }
            set {
                this._VerticalColumns = value;
            }
        }
      
      
        protected int _TotalPages = -1;
        public int TotalPages {
            get {
                if (_TotalPages < 0) 
                
                    this.TotalPages = Convert.ToInt32(Math.Ceiling(Convert.ToDouble(TotalRecords) / (Convert.ToDouble(this.PageSize) * Convert.ToDouble(this.VerticalColumns))));
                  
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
        
        public  PropertyNotesRecord[] DataSource {
             
            get {
                return (PropertyNotesRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public System.Web.UI.WebControls.DropDownList NotesFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NotesFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal NotesLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NotesLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton NotesSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NotesSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.DropDownList PropertyIDFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyIDFilter");
            }
        }
        
        public System.Web.UI.WebControls.Literal PropertyIDLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyIDLabel1");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton PropertyIDSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyIDSortLabel");
            }
        }
        
        public IPv5.UI.IThemeButtonWithArrow PropertyNotesButtonsButton {
            get {
                return (IPv5.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyNotesButtonsButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton PropertyNotesExportExcelButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyNotesExportExcelButton");
            }
        }
        
        public IPv5.UI.IThemeButton PropertyNotesFilterButton {
            get {
                return (IPv5.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyNotesFilterButton");
            }
        }
        
        public IPv5.UI.IThemeButtonWithArrow PropertyNotesFiltersButton {
            get {
                return (IPv5.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyNotesFiltersButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton PropertyNotesImportButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyNotesImportButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton PropertyNotesNewButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyNotesNewButton");
            }
        }
        
        public IPv5.UI.IPaginationModern PropertyNotesPagination {
            get {
                return (IPv5.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyNotesPagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton PropertyNotesPDFButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyNotesPDFButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton PropertyNotesResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyNotesResetButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox PropertyNotesSearch {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyNotesSearch");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton PropertyNotesSearchButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyNotesSearchButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal PropertyNotesTitle {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyNotesTitle");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton PropertyNotesWordButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyNotesWordButton");
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
                PropertyNotesTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IPv5"));
                }

        PropertyNotesRecord rec = null;
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
                PropertyNotesTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IPv5"));
                }

        PropertyNotesRecord rec = null;
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
          
        public virtual PropertyNotesTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual PropertyNotesTableControlRow[] GetSelectedRecordControls()
        {
        
            return (PropertyNotesTableControlRow[])((new ArrayList()).ToArray(Type.GetType("IPv5.UI.Controls.ShowPropertyNotesGallery.PropertyNotesTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            PropertyNotesTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IPv5"));
            }
            
            foreach (PropertyNotesTableControlRow recCtl in recordList)
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

        public virtual PropertyNotesTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "PropertyNotesTableControlRow");
	          List<PropertyNotesTableControlRow> list = new List<PropertyNotesTableControlRow>();
	          foreach (PropertyNotesTableControlRow recCtrl in recCtrls) {
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

  