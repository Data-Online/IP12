
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// GroupByVPropertyRentReviewsTable.aspx page.  The Row or RecordControl classes are the 
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
using IPv5.UI.Tools;


#endregion


namespace IPv5.UI.Controls.GroupByVPropertyRentReviewsTable
{
  

#region "Section 1: Place your customizations here."

    
public class VPropertyRentReviewsTableControlRow : BaseVPropertyRentReviewsTableControlRow
{

        // The BaseVPropertyRentReviewsTableControlRow implements code for a ROW within the
        // the VPropertyRentReviewsTableControl table.  The BaseVPropertyRentReviewsTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of VPropertyRentReviewsTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        public VPropertyRentReviewsTableControlRow()
        {
            #region "Code Customization"

            // The following line will be inserted inside the
            // constructor for page class.
            this.PreRender += new System.EventHandler(RecordControl_PreRender);

            #endregion
        }
        #region "Code Customization"

        /// <summary>
        /// Highlights the record in the PreRender event
        /// </summary>
        private void RecordControl_PreRender(object sender, System.EventArgs e)
        {
            // Compare value to determine if you want to highlight the background of the row.
            // For example, if ExpiryDate > 25, then, highlight.
            // Note: You can also check if the field value equals a certain string,
            // e.g, ExpiryDate.Text = "Yes". -- double.Parse(this.OverdueCount.Text)
            string applyToRow = "";
            // DateTime currentDate;
            try
            {
                applyToRow = CustomTools.SetCSSclass(Convert.ToDateTime(this.ExpiryDate.Text));
            }
            catch
            { }  // No date specified .. so just ignore.

            // Find the record row the field value is on.
            System.Web.UI.HtmlControls.HtmlTableRow recordRow;
            recordRow = (System.Web.UI.HtmlControls.HtmlTableRow)this.FindControl("MyTR");

            // For each cell, set the background color.
            foreach (System.Web.UI.HtmlControls.HtmlTableCell recordRowCell in recordRow.Cells)
            {
                // Override the record row background color -- since each data cell uses a 
                // style (by default: table_cell or table_cellr)
                recordRowCell.Attributes.Add("class", "alerts" + applyToRow);
            }
        }

        #endregion



    }



    public class VPropertyRentReviewsTableControl : BaseVPropertyRentReviewsTableControl
{
    // The BaseVPropertyRentReviewsTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The VPropertyRentReviewsTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the VPropertyRentReviewsTableControlRow control on the GroupByVPropertyRentReviewsTable page.
// Do not modify this class. Instead override any method in VPropertyRentReviewsTableControlRow.
public class BaseVPropertyRentReviewsTableControlRow : IPv5.UI.BaseApplicationRecordControl
{
        public BaseVPropertyRentReviewsTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in VPropertyRentReviewsTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in VPropertyRentReviewsTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
                    this.PropertyID.Click += PropertyID_Click;
                        
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseMM_IP1%dbo.vPropertyRentReviews record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // The RecordUniqueId is set the first time a record is loaded, and is
            // used during a PostBack to load the record.
            if (this.RecordUniqueId != null && this.RecordUniqueId.Length > 0) {
              
                this.DataSource = VPropertyRentReviewsView.GetRecord(this.RecordUniqueId, true);
              
                return;
            }
      
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseVPropertyRentReviewsTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new VPropertyRentReviewsRecord();
            
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
                SetAddress2();
                SetAddress3();
                SetCityID();
                SetCountryID();
                SetDescription();
                SetExpiryDate();
                SetPostCode();
                SetPropertyID();
                SetRegionID();

      

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
            // DatabaseMM_IP1%dbo.vPropertyRentReviews database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyRentReviews record retrieved from the database.
            // this.Address1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address1Specified) {
                								
                // If the Address1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyRentReviewsView.Address1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address1.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address1.Text = VPropertyRentReviewsView.Address1.Format(VPropertyRentReviewsView.Address1.DefaultValue);
            		
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
            // DatabaseMM_IP1%dbo.vPropertyRentReviews database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyRentReviews record retrieved from the database.
            // this.Address2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address2Specified) {
                								
                // If the Address2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyRentReviewsView.Address2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address2.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address2.Text = VPropertyRentReviewsView.Address2.Format(VPropertyRentReviewsView.Address2.DefaultValue);
            		
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
            // DatabaseMM_IP1%dbo.vPropertyRentReviews database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyRentReviews record retrieved from the database.
            // this.Address3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address3Specified) {
                								
                // If the Address3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyRentReviewsView.Address3);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address3.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address3.Text = VPropertyRentReviewsView.Address3.Format(VPropertyRentReviewsView.Address3.DefaultValue);
            		
            }
            
            // If the Address3 is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Address3.Text == null ||
                this.Address3.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Address3.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCityID()
        {
            
                    
            // Set the CityID Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyRentReviews database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyRentReviews record retrieved from the database.
            // this.CityID is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CityIDSpecified) {
                								
                // If the CityID is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = VPropertyRentReviewsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyRentReviewsView.CityID);
               if(_isExpandableNonCompositeForeignKey &&VPropertyRentReviewsView.CityID.IsApplyDisplayAs)
                                  
                     formattedValue = VPropertyRentReviewsView.GetDFKA(this.DataSource.CityID.ToString(),VPropertyRentReviewsView.CityID, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(VPropertyRentReviewsView.CityID);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CityID.Text = formattedValue;
                   
            } 
            
            else {
            
                // CityID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CityID.Text = VPropertyRentReviewsView.CityID.Format(VPropertyRentReviewsView.CityID.DefaultValue);
            		
            }
            
            // If the CityID is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CityID.Text == null ||
                this.CityID.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CityID.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCountryID()
        {
            
                    
            // Set the CountryID Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyRentReviews database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyRentReviews record retrieved from the database.
            // this.CountryID is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CountryIDSpecified) {
                								
                // If the CountryID is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = VPropertyRentReviewsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyRentReviewsView.CountryID);
               if(_isExpandableNonCompositeForeignKey &&VPropertyRentReviewsView.CountryID.IsApplyDisplayAs)
                                  
                     formattedValue = VPropertyRentReviewsView.GetDFKA(this.DataSource.CountryID.ToString(),VPropertyRentReviewsView.CountryID, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(VPropertyRentReviewsView.CountryID);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CountryID.Text = formattedValue;
                   
            } 
            
            else {
            
                // CountryID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CountryID.Text = VPropertyRentReviewsView.CountryID.Format(VPropertyRentReviewsView.CountryID.DefaultValue);
            		
            }
            
            // If the CountryID is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CountryID.Text == null ||
                this.CountryID.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CountryID.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetDescription()
        {
            
                    
            // Set the Description Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyRentReviews database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyRentReviews record retrieved from the database.
            // this.Description is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.DescriptionSpecified) {
                								
                // If the Description is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyRentReviewsView.Description);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                if(formattedValue != null){
                    int popupThreshold = (int)(10);
                              
                    int maxLength = formattedValue.Length;
                    int originalLength = maxLength;
                    if (maxLength >= (int)(15)){
                        // Truncate based on FieldMaxLength on Properties.
                        maxLength = (int)(15);
                        //First strip of all html tags:
                        formattedValue = StringUtils.ConvertHTMLToPlainText(formattedValue);
                        
                    }
                                
                              
                    // For fields values larger than the PopupTheshold on Properties, display a popup.
                    if (originalLength >= popupThreshold) {
                        String name = HttpUtility.HtmlEncode(VPropertyRentReviewsView.Description.Name);

                        if (!HttpUtility.HtmlEncode("%ISD_DEFAULT%").Equals("%ISD_DEFAULT%")) {
                           name = HttpUtility.HtmlEncode(this.Page.GetResourceValue("%ISD_DEFAULT%"));
                        }

                        formattedValue = "<a onclick=\'gPersist=true;\' class=\'truncatedText\' onmouseout=\'detailRolloverPopupClose();\' " +
                            "onmouseover=\'SaveMousePosition(event); delayRolloverPopup(\"PageMethods.GetRecordFieldValue(\\\"" + "NULL" + "\\\", \\\"IPv5.Business.VPropertyRentReviewsView, IPv5.Business\\\",\\\"" +
                              (HttpUtility.UrlEncode(this.DataSource.GetID().ToString())).Replace("\\","\\\\\\\\") + "\\\", \\\"Description\\\", \\\"Description\\\", \\\"" +NetUtils.EncodeStringForHtmlDisplay(name.Substring(0, name.Length)) + "\\\",\\\"" + Page.GetResourceValue("Btn:Close", "IPv5") + "\\\", " +
                        " false, 200," +
                            " 300, true, PopupDisplayWindowCallBackWith20);\", 500);'>" + NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0, Math.Min(maxLength, formattedValue.Length)));
                        if (maxLength == (int)(15))
                            {
                            formattedValue = formattedValue + "..." + "</a>";
                        }
                        else
                        {
                            formattedValue = formattedValue + "</a>";
                            
                        }
                    }
                    else{
                        if (maxLength == (int)(15)) {
                          formattedValue = NetUtils.EncodeStringForHtmlDisplay(formattedValue.Substring(0,Math.Min(maxLength, formattedValue.Length)));
                          formattedValue = formattedValue + "...";
                        }
                        
                    }
                }
                
                this.Description.Text = formattedValue;
                   
            } 
            
            else {
            
                // Description is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Description.Text = VPropertyRentReviewsView.Description.Format(VPropertyRentReviewsView.Description.DefaultValue);
            		
            }
            
            // If the Description is NULL or blank, then use the value specified  
            // on Properties.
            if (this.Description.Text == null ||
                this.Description.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.Description.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetExpiryDate()
        {
            
                    
            // Set the ExpiryDate Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyRentReviews database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyRentReviews record retrieved from the database.
            // this.ExpiryDate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ExpiryDateSpecified) {
                								
                // If the ExpiryDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyRentReviewsView.ExpiryDate, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ExpiryDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // ExpiryDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ExpiryDate.Text = VPropertyRentReviewsView.ExpiryDate.Format(VPropertyRentReviewsView.ExpiryDate.DefaultValue, @"d");
            		
            }
            
            // If the ExpiryDate is NULL or blank, then use the value specified  
            // on Properties.
            if (this.ExpiryDate.Text == null ||
                this.ExpiryDate.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.ExpiryDate.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPostCode()
        {
            
                    
            // Set the PostCode Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyRentReviews database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyRentReviews record retrieved from the database.
            // this.PostCode is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PostCodeSpecified) {
                								
                // If the PostCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyRentReviewsView.PostCode);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PostCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // PostCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PostCode.Text = VPropertyRentReviewsView.PostCode.Format(VPropertyRentReviewsView.PostCode.DefaultValue);
            		
            }
            
            // If the PostCode is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PostCode.Text == null ||
                this.PostCode.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PostCode.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetPropertyID()
        {
            
                    
            // Set the PropertyID LinkButton on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyRentReviews database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyRentReviews record retrieved from the database.
            // this.PropertyID is the ASP:LinkButton on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PropertyIDSpecified) {
                								
                // If the PropertyID is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = VPropertyRentReviewsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyRentReviewsView.PropertyID);
               if(_isExpandableNonCompositeForeignKey &&VPropertyRentReviewsView.PropertyID.IsApplyDisplayAs)
                                  
                     formattedValue = VPropertyRentReviewsView.GetDFKA(this.DataSource.PropertyID.ToString(),VPropertyRentReviewsView.PropertyID, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(VPropertyRentReviewsView.PropertyID);
                                  
                                
                this.PropertyID.Text = formattedValue;
                   
            } 
            
            else {
            
                // PropertyID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PropertyID.Text = VPropertyRentReviewsView.PropertyID.Format(VPropertyRentReviewsView.PropertyID.DefaultValue);
            		
            }
                               
        }
                
        public virtual void SetRegionID()
        {
            
                    
            // Set the RegionID Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyRentReviews database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyRentReviews record retrieved from the database.
            // this.RegionID is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RegionIDSpecified) {
                								
                // If the RegionID is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = VPropertyRentReviewsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyRentReviewsView.RegionID);
               if(_isExpandableNonCompositeForeignKey &&VPropertyRentReviewsView.RegionID.IsApplyDisplayAs)
                                  
                     formattedValue = VPropertyRentReviewsView.GetDFKA(this.DataSource.RegionID.ToString(),VPropertyRentReviewsView.RegionID, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(VPropertyRentReviewsView.RegionID);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RegionID.Text = formattedValue;
                   
            } 
            
            else {
            
                // RegionID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RegionID.Text = VPropertyRentReviewsView.RegionID.Format(VPropertyRentReviewsView.RegionID.DefaultValue);
            		
            }
            
            // If the RegionID is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RegionID.Text == null ||
                this.RegionID.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RegionID.Text = "&nbsp;";
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
                ((VPropertyRentReviewsTableControl)MiscUtils.GetParentControlObject(this, "VPropertyRentReviewsTableControl")).DataChanged = true;
                ((VPropertyRentReviewsTableControl)MiscUtils.GetParentControlObject(this, "VPropertyRentReviewsTableControl")).ResetData = true;
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
            GetAddress3();
            GetCityID();
            GetCountryID();
            GetDescription();
            GetExpiryDate();
            GetPostCode();
            GetPropertyID();
            GetRegionID();
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
                
        public virtual void GetCityID()
        {
            
        }
                
        public virtual void GetCountryID()
        {
            
        }
                
        public virtual void GetDescription()
        {
            
        }
                
        public virtual void GetExpiryDate()
        {
            
        }
                
        public virtual void GetPostCode()
        {
            
        }
                
        public virtual void GetPropertyID()
        {
            
        }
                
        public virtual void GetRegionID()
        {
            
        }
                

      // To customize, override this method in VPropertyRentReviewsTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersVPropertyRentReviewsTableControl = false;
            hasFiltersVPropertyRentReviewsTableControl = hasFiltersVPropertyRentReviewsTableControl && false; // suppress warning
      
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
          VPropertyRentReviewsView.DeleteRecord(pkValue);
          
              
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            ((VPropertyRentReviewsTableControl)MiscUtils.GetParentControlObject(this, "VPropertyRentReviewsTableControl")).DataChanged = true;
            ((VPropertyRentReviewsTableControl)MiscUtils.GetParentControlObject(this, "VPropertyRentReviewsTableControl")).ResetData = true;
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
        public virtual void PropertyID_Click(object sender, EventArgs args)
        {
              
            // The redirect URL is set on the Properties, Custom Properties or Actions.
            // The ModifyRedirectURL call resolves the parameters before the
            // Response.Redirect redirects the page to the URL.  
            // Any code after the Response.Redirect call will not be executed, since the page is
            // redirected to the URL.
            
            string url = @"../Properties/GroupByPropertiesTable.aspx?Properties={VPropertyRentReviewsTableControlRow:FV:PropertyID}";
            
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
                return (string)this.ViewState["BaseVPropertyRentReviewsTableControlRow_Rec"];
            }
            set {
                this.ViewState["BaseVPropertyRentReviewsTableControlRow_Rec"] = value;
            }
        }
        
        public VPropertyRentReviewsRecord DataSource {
            get {
                return (VPropertyRentReviewsRecord)(this._DataSource);
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
            
        public System.Web.UI.WebControls.Literal Address2 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address2");
            }
        }
            
        public System.Web.UI.WebControls.Literal Address3 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address3");
            }
        }
            
        public System.Web.UI.WebControls.Literal CityID {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CityID");
            }
        }
            
        public System.Web.UI.WebControls.Literal CountryID {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CountryID");
            }
        }
            
        public System.Web.UI.WebControls.Literal Description {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Description");
            }
        }
            
        public System.Web.UI.WebControls.Literal ExpiryDate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExpiryDate");
            }
        }
            
        public System.Web.UI.WebControls.Literal PostCode {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PostCode");
            }
        }
            
        public System.Web.UI.WebControls.LinkButton PropertyID {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyID");
            }
        }
            
        public System.Web.UI.WebControls.Literal RegionID {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RegionID");
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
        VPropertyRentReviewsRecord rec = null;
             
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
    VPropertyRentReviewsRecord rec = null;
    
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

        
        public virtual VPropertyRentReviewsRecord GetRecord()
             
        {
        
            if (this.DataSource != null) {
                return this.DataSource;
            }
            
              if (this.RecordUniqueId != null) {
              
                return VPropertyRentReviewsView.GetRecord(this.RecordUniqueId, true);
              
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

  
// Base class for the VPropertyRentReviewsTableControl control on the GroupByVPropertyRentReviewsTable page.
// Do not modify this class. Instead override any method in VPropertyRentReviewsTableControl.
public class BaseVPropertyRentReviewsTableControl : IPv5.UI.BaseApplicationTableControl
{
         
       public BaseVPropertyRentReviewsTableControl()
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
                if  (this.InSession(this.CityIDFilter)) 				
                    initialVal = this.GetFromSession(this.CityIDFilter);
                
                else
                    
                    initialVal = EvaluateFormula("URL(\"CityID\")");
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.CityIDFilter.Items.Add(new ListItem(initialVal, initialVal));
                        
                    this.CityIDFilter.SelectedValue = initialVal;
                            
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
                if  (this.InSession(this.VPropertyRentReviewsSearch)) 				
                    initialVal = this.GetFromSession(this.VPropertyRentReviewsSearch);
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.VPropertyRentReviewsSearch.Text = initialVal;
                            
                    }
            }


      
      
            // Control Initializations.
            // Initialize the table's current sort order.

            if (this.InSession(this, "Order_By"))
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));         
            else
            {
                   
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(VPropertyRentReviewsView.CompanyName, OrderByItem.OrderDir.Asc);
              
        }



    // Setup default pagination settings.
    
            this.PageSize = Convert.ToInt32(this.GetFromSession(this, "Page_Size", "20"));
            this.PageIndex = Convert.ToInt32(this.GetFromSession(this, "Page_Index", "0"));
                     
        }

        protected virtual void Control_Load(object sender, EventArgs e)
        {
        
            SaveControlsToSession_Ajax();
        
            // Setup the pagination events.
            
                    this.VPropertyRentReviewsPagination.FirstPage.Click += VPropertyRentReviewsPagination_FirstPage_Click;
                        
                    this.VPropertyRentReviewsPagination.LastPage.Click += VPropertyRentReviewsPagination_LastPage_Click;
                        
                    this.VPropertyRentReviewsPagination.NextPage.Click += VPropertyRentReviewsPagination_NextPage_Click;
                        
                    this.VPropertyRentReviewsPagination.PageSizeButton.Click += VPropertyRentReviewsPagination_PageSizeButton_Click;
                        
                    this.VPropertyRentReviewsPagination.PreviousPage.Click += VPropertyRentReviewsPagination_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
              this.Address1Label.Click += Address1Label_Click;
            
              this.Address1SortLabel.Click += Address1SortLabel_Click;
            
              this.Address2SortLabel.Click += Address2SortLabel_Click;
            
              this.Address3SortLabel.Click += Address3SortLabel_Click;
            
              this.CityIDLabel.Click += CityIDLabel_Click;
            
              this.CityIDSortLabel.Click += CityIDSortLabel_Click;
            
              this.CompanyNameSortLabel.Click += CompanyNameSortLabel_Click;
            
              this.CountryIDLabel.Click += CountryIDLabel_Click;
            
              this.DescriptionLabel.Click += DescriptionLabel_Click;
            
              this.DescriptionSortLabel.Click += DescriptionSortLabel_Click;
            
              this.ExpiryDateLabel.Click += ExpiryDateLabel_Click;
            
              this.ExpiryDateSortLabel.Click += ExpiryDateSortLabel_Click;
            
              this.PostCodeLabel.Click += PostCodeLabel_Click;
            
              this.PostCodeSortLabel.Click += PostCodeSortLabel_Click;
            
              this.PropertyIDLabel.Click += PropertyIDLabel_Click;
            
              this.PropertyIDSortLabel.Click += PropertyIDSortLabel_Click;
            
              this.RegionIDLabel.Click += RegionIDLabel_Click;
            
              this.RentReviewIDSortLabel.Click += RentReviewIDSortLabel_Click;
            
            // Setup the button events.
          
                    this.VPropertyRentReviewsExportExcelButton.Click += VPropertyRentReviewsExportExcelButton_Click;
                        
                    this.VPropertyRentReviewsPDFButton.Click += VPropertyRentReviewsPDFButton_Click;
                        
                    this.VPropertyRentReviewsResetButton.Click += VPropertyRentReviewsResetButton_Click;
                        
                    this.VPropertyRentReviewsSearchButton.Click += VPropertyRentReviewsSearchButton_Click;
                        
                    this.VPropertyRentReviewsWordButton.Click += VPropertyRentReviewsWordButton_Click;
                        
                    this.VPropertyRentReviewsButtonsButton.Button.Click += VPropertyRentReviewsButtonsButton_Click;
                        
                    this.VPropertyRentReviewsFilterButton.Button.Click += VPropertyRentReviewsFilterButton_Click;
                        
                    this.VPropertyRentReviewsFiltersButton.Button.Click += VPropertyRentReviewsFiltersButton_Click;
                        
            this.CityIDFilter.SelectedIndexChanged += new EventHandler(CityIDFilter_SelectedIndexChanged);
            
            this.PropertyIDFilter.SelectedIndexChanged += new EventHandler(PropertyIDFilter_SelectedIndexChanged);
                    
        
         //' Setup events for others
            AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "VPropertyRentReviewsSearchSearchBoxText", "setSearchBoxText(\"" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "\", \"" + VPropertyRentReviewsSearch.ClientID + "\");", true);
             
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
                      Type myrec = typeof(IPv5.Business.VPropertyRentReviewsRecord);
                      this.DataSource = (VPropertyRentReviewsRecord[])(alist.ToArray(myrec));
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
                    foreach (VPropertyRentReviewsTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(IPv5.Business.VPropertyRentReviewsRecord);
                    this.DataSource = (VPropertyRentReviewsRecord[])(postdata.ToArray(myrec));
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
        
        public virtual VPropertyRentReviewsRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(VPropertyRentReviewsView.Column1, true);          
            // selCols.Add(VPropertyRentReviewsView.Column2, true);          
            // selCols.Add(VPropertyRentReviewsView.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return VPropertyRentReviewsView.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                VPropertyRentReviewsView databaseTable = new VPropertyRentReviewsView();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(VPropertyRentReviewsRecord)) as VPropertyRentReviewsRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(VPropertyRentReviewsView.Column1, true);          
            // selCols.Add(VPropertyRentReviewsView.Column2, true);          
            // selCols.Add(VPropertyRentReviewsView.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return VPropertyRentReviewsView.GetRecordCount(join, where);
            else
            {
                VPropertyRentReviewsView databaseTable = new VPropertyRentReviewsView();
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
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyRentReviewsTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            VPropertyRentReviewsTableControlRow recControl = (VPropertyRentReviewsTableControlRow)(repItem.FindControl("VPropertyRentReviewsTableControlRow"));
            recControl.DataSource = this.DataSource[index];            
            if (this.UIData.Count > index)
                recControl.PreviousUIData = this.UIData[index];
            recControl.DataBind();
            
           
            recControl.Visible = !this.InDeletedRecordIds(recControl);
        
            index++;
        }
           
    
            // Call the Set methods for each controls on the panel
        
                SetAddress1Label();
                SetAddress1SortLabel();
                SetAddress2SortLabel();
                SetAddress3SortLabel();
                SetCityIDFilter();
                SetCityIDLabel();
                SetCityIDLabel1();
                SetCityIDSortLabel();
                SetCompanyNameSortLabel();
                SetCountryIDLabel();
                SetDescriptionLabel();
                SetDescriptionSortLabel();
                SetDueNow();
                SetExpiryDateLabel();
                SetExpiryDateSortLabel();
                SetLiteral();
                SetNextMonth();
                SetOverdue();
                SetPostCodeLabel();
                SetPostCodeSortLabel();
                SetPropertyIDFilter();
                SetPropertyIDLabel();
                SetPropertyIDLabel1();
                SetPropertyIDSortLabel();
                SetRegionIDLabel();
                SetRentReviewIDSortLabel();
                
                
                
                
                
                
                
                SetVPropertyRentReviewsSearch();
                
                
                
                
                SetVPropertyRentReviewsExportExcelButton();
              
                SetVPropertyRentReviewsPDFButton();
              
                SetVPropertyRentReviewsResetButton();
              
                SetVPropertyRentReviewsSearchButton();
              
                SetVPropertyRentReviewsWordButton();
              
                SetVPropertyRentReviewsButtonsButton();
              
                SetVPropertyRentReviewsFilterButton();
              
                SetVPropertyRentReviewsFiltersButton();
              
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetVPropertyRentReviewsFiltersButton();
                     
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
    public virtual void AddWarningMessageOnClick() {
    
        if (this.TotalRecords > 10000)
          this.VPropertyRentReviewsExportExcelButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm", "IPv5") + "'));");
        else
          this.VPropertyRentReviewsExportExcelButton.Attributes.Remove("onClick");
      
    }
  
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(VPropertyRentReviewsView.CityID, this.DataSource);
            this.Page.PregetDfkaRecords(VPropertyRentReviewsView.CountryID, this.DataSource);
            this.Page.PregetDfkaRecords(VPropertyRentReviewsView.PropertyID, this.DataSource);
            this.Page.PregetDfkaRecords(VPropertyRentReviewsView.RegionID, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"VPropertyRentReviewsExportExcelButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"VPropertyRentReviewsPDFButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"VPropertyRentReviewsWordButton"));
                                
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


            
            this.CityIDFilter.ClearSelection();
            
            this.PropertyIDFilter.ClearSelection();
            
            this.VPropertyRentReviewsSearch.Text = "";
            
            this.CurrentSortOrder.Reset();
            if (this.InSession(this, "Order_By")) {
                this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
            }
            else {
            
                this.CurrentSortOrder = new OrderBy(true, false);
            
                this.CurrentSortOrder.Add(VPropertyRentReviewsView.CompanyName, OrderByItem.OrderDir.Asc);
                 
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
                this.VPropertyRentReviewsPagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.VPropertyRentReviewsPagination.CurrentPage.Text = "0";
            }
            this.VPropertyRentReviewsPagination.PageSize.Text = this.PageSize.ToString();
            this.VPropertyRentReviewsPagination.TotalPages.Text = this.TotalPages.ToString();
    
            // Bind the buttons for VPropertyRentReviewsTableControl pagination.
        
            this.VPropertyRentReviewsPagination.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.VPropertyRentReviewsPagination.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.VPropertyRentReviewsPagination.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.VPropertyRentReviewsPagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.VPropertyRentReviewsPagination.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.VPropertyRentReviewsPagination.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.VPropertyRentReviewsPagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.VPropertyRentReviewsPagination.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (VPropertyRentReviewsTableControlRow recCtl in this.GetRecordControls())
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
            foreach (VPropertyRentReviewsTableControlRow recCtl in this.GetRecordControls()){
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
            VPropertyRentReviewsView.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            if (MiscUtils.IsValueSelected(this.CityIDFilter)) {
                        
                wc.iAND(VPropertyRentReviewsView.CityID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.CityIDFilter, this.GetFromSession(this.CityIDFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.PropertyIDFilter)) {
                        
                wc.iAND(VPropertyRentReviewsView.PropertyID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.PropertyIDFilter, this.GetFromSession(this.PropertyIDFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.VPropertyRentReviewsSearch)) {
                if (this.VPropertyRentReviewsSearch.Text == BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) ) {
                        this.VPropertyRentReviewsSearch.Text = "";
                } else {
                  // Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                  if (this.VPropertyRentReviewsSearch.Text.StartsWith("...")) {
                      this.VPropertyRentReviewsSearch.Text = this.VPropertyRentReviewsSearch.Text.Substring(3,this.VPropertyRentReviewsSearch.Text.Length-3);
                  }
                  if (this.VPropertyRentReviewsSearch.Text.EndsWith("...")) {
                      this.VPropertyRentReviewsSearch.Text = this.VPropertyRentReviewsSearch.Text.Substring(0,this.VPropertyRentReviewsSearch.Text.Length-3);
                      // Strip the last word as well as it is likely only a partial word
                      int endindex = this.VPropertyRentReviewsSearch.Text.Length - 1;
                      while (!Char.IsWhiteSpace(VPropertyRentReviewsSearch.Text[endindex]) && endindex > 0) {
                          endindex--;
                      }
                      if (endindex > 0) {
                          this.VPropertyRentReviewsSearch.Text = this.VPropertyRentReviewsSearch.Text.Substring(0, endindex);
                      }
                  }
                }
                string formatedSearchText = MiscUtils.GetSelectedValue(this.VPropertyRentReviewsSearch, this.GetFromSession(this.VPropertyRentReviewsSearch));
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(this.VPropertyRentReviewsSearch)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                  
                    WhereClause search = new WhereClause();
                    
        ColumnList cols = new ColumnList();
      
      cols.Add(VPropertyRentReviewsView.CompanyName, true);
      
      cols.Add(VPropertyRentReviewsView.Address1, true);
      
      foreach(BaseColumn col in cols)
      {
      
          search.iOR(col, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(this.VPropertyRentReviewsSearch, this.GetFromSession(this.VPropertyRentReviewsSearch)), true, false);
        
      }
    
                    wc.iAND(search);
                  
                }
            }
                       
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            VPropertyRentReviewsView.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String CityIDFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "CityIDFilter_Ajax"];
            if (MiscUtils.IsValueSelected(CityIDFilterSelectedValue)) {

              
                wc.iAND(VPropertyRentReviewsView.CityID, BaseFilter.ComparisonOperator.EqualsTo, CityIDFilterSelectedValue, false, false);
                      
      }
                      
      String PropertyIDFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "PropertyIDFilter_Ajax"];
            if (MiscUtils.IsValueSelected(PropertyIDFilterSelectedValue)) {

              
                wc.iAND(VPropertyRentReviewsView.PropertyID, BaseFilter.ComparisonOperator.EqualsTo, PropertyIDFilterSelectedValue, false, false);
                      
      }
                      
            if (MiscUtils.IsValueSelected(searchText) && fromSearchControl == "VPropertyRentReviewsSearch") {
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
      
      cols.Add(VPropertyRentReviewsView.CompanyName, true);
      
      cols.Add(VPropertyRentReviewsView.Address1, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(VPropertyRentReviewsView.CompanyName, true);
      
      cols.Add(VPropertyRentReviewsView.Address1, true);
      
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

        
        public virtual string[] GetAutoCompletionList_VPropertyRentReviewsSearch(String prefixText,int count)
        {
            ArrayList resultList = new ArrayList();
            ArrayList wordList= new ArrayList();
            
            CompoundFilter filterJoin = CreateCompoundJoinFilter();    
            WhereClause wc = CreateWhereClause(prefixText,"VPropertyRentReviewsSearch", "WordsStartingWithSearchString", "[^a-zA-Z0-9]");
            if(count==0) count = 10;
            IPv5.Business.VPropertyRentReviewsRecord[] recordList  = VPropertyRentReviewsView.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (VPropertyRentReviewsRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(VPropertyRentReviewsView.CompanyName);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(VPropertyRentReviewsView.CompanyName.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, VPropertyRentReviewsView.CompanyName.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(VPropertyRentReviewsView.Address1);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(VPropertyRentReviewsView.Address1.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, VPropertyRentReviewsView.Address1.IsFullTextSearchable);
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
        
            if (this.VPropertyRentReviewsPagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.VPropertyRentReviewsPagination.PageSize.Text);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyRentReviewsTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                VPropertyRentReviewsTableControlRow recControl = (VPropertyRentReviewsTableControlRow)(repItem.FindControl("VPropertyRentReviewsTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      VPropertyRentReviewsRecord rec = new VPropertyRentReviewsRecord();
        
                        if (recControl.Address1.Text != "") {
                            rec.Parse(recControl.Address1.Text, VPropertyRentReviewsView.Address1);
                  }
                
                        if (recControl.Address2.Text != "") {
                            rec.Parse(recControl.Address2.Text, VPropertyRentReviewsView.Address2);
                  }
                
                        if (recControl.Address3.Text != "") {
                            rec.Parse(recControl.Address3.Text, VPropertyRentReviewsView.Address3);
                  }
                
                        if (recControl.CityID.Text != "") {
                            rec.Parse(recControl.CityID.Text, VPropertyRentReviewsView.CityID);
                  }
                
                        if (recControl.CountryID.Text != "") {
                            rec.Parse(recControl.CountryID.Text, VPropertyRentReviewsView.CountryID);
                  }
                
                        if (recControl.Description.Text != "") {
                            rec.Parse(recControl.Description.Text, VPropertyRentReviewsView.Description);
                  }
                
                        if (recControl.ExpiryDate.Text != "") {
                            rec.Parse(recControl.ExpiryDate.Text, VPropertyRentReviewsView.ExpiryDate);
                  }
                
                        if (recControl.PostCode.Text != "") {
                            rec.Parse(recControl.PostCode.Text, VPropertyRentReviewsView.PostCode);
                  }
                
                        if (recControl.PropertyID.Text != "") {
                            rec.Parse(recControl.PropertyID.Text, VPropertyRentReviewsView.PropertyID);
                  }
                
                        if (recControl.RegionID.Text != "") {
                            rec.Parse(recControl.RegionID.Text, VPropertyRentReviewsView.RegionID);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new VPropertyRentReviewsRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(IPv5.Business.VPropertyRentReviewsRecord);
                this.DataSource = (VPropertyRentReviewsRecord[])(finalList.ToArray(myrec));
              
            }
            
            // Add the existing UI data to this hash table
            if (newUIDataList.Count > 0)
                this.UIData.InsertRange(0, newUIDataList);
        }

        
        public void AddToDeletedRecordIds(VPropertyRentReviewsTableControlRow rec)
        {
            if (rec.IsNewRecord) {
                return;
            }

            if (this.DeletedRecordIds != null && this.DeletedRecordIds.Length > 0) {
                this.DeletedRecordIds += ",";
            }

            this.DeletedRecordIds += "[" + rec.RecordUniqueId + "]";
        }

        protected virtual bool InDeletedRecordIds(VPropertyRentReviewsTableControlRow rec)            
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
        
        public virtual void SetAddress1Label()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.Address1Label.Text = "Some value";
                    
                    
        }
                
        public virtual void SetAddress1SortLabel()
                  {
                  
                    
        }
                
        public virtual void SetAddress2SortLabel()
                  {
                  
                    
        }
                
        public virtual void SetAddress3SortLabel()
                  {
                  
                    
        }
                
        public virtual void SetCityIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetCityIDLabel1()
                  {
                  
                    
        }
                
        public virtual void SetCityIDSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetCompanyNameSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetCountryIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetDescriptionLabel()
                  {
                  
                    
        }
                
        public virtual void SetDescriptionSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetDueNow()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.DueNow.Text = "Some value";
                    
                    
        }
                
        public virtual void SetExpiryDateLabel()
                  {
                  
                    
        }
                
        public virtual void SetExpiryDateSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetLiteral()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.Literal.Text = "Some value";
                    
                    
        }
                
        public virtual void SetNextMonth()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.NextMonth.Text = "Some value";
                    
                    
        }
                
        public virtual void SetOverdue()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.Overdue.Text = "Some value";
                    
                    
        }
                
        public virtual void SetPostCodeLabel()
                  {
                  
                    
        }
                
        public virtual void SetPostCodeSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetPropertyIDLabel()
                  {
                  
                      //Code for the text property is generated inside the .aspx file. 
                      //To override this property you can uncomment the following property and add you own value.
                      //this.PropertyIDLabel.Text = "Some value";
                    
                    
        }
                
        public virtual void SetPropertyIDLabel1()
                  {
                  
                    
        }
                
        public virtual void SetPropertyIDSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetRegionIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetRentReviewIDSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetCityIDFilter()
        {
            
            this.PopulateCityIDFilter(MiscUtils.GetSelectedValue(this.CityIDFilter,  GetFromSession(this.CityIDFilter)), 500);					
                                     
        }
            
        public virtual void SetPropertyIDFilter()
        {
            
            this.PopulatePropertyIDFilter(MiscUtils.GetSelectedValue(this.PropertyIDFilter,  GetFromSession(this.PropertyIDFilter)), 500);					
                                     
        }
            
        public virtual void SetVPropertyRentReviewsSearch()
        {
                                            
            this.VPropertyRentReviewsSearch.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "') {this.value='';this.className='Search_Input';}");
            this.VPropertyRentReviewsSearch.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "';this.className='Search_InputHint';}");
                                   
        }
            
        // Get the filters' data for CityIDFilter.
                
        protected virtual void PopulateCityIDFilter(string selectedValue, int maxItems)
                    
        {
        
            
            //Setup the WHERE clause.
                        
            this.CityIDFilter.Items.Clear();
            WhereClause wc = this.CreateWhereClause_CityIDFilter();            
            			  			
            // Set up the WHERE and the ORDER BY clause by calling the CreateWhereClause_CityIDFilter function.
            // It is better to customize the where clause there.
             
            // Setup the static list items        
            
                // Add the All item.
                this.CityIDFilter.Items.Insert(0, new ListItem(this.Page.GetResourceValue("Txt:All", "IPv5"), "--ANY--"));
              
            OrderBy orderBy = new OrderBy(false, false);
                          orderBy.Add(CitiesTable.City, OrderByItem.OrderDir.Asc);


            System.Collections.Generic.IDictionary<string, object> variables = new System.Collections.Generic.Dictionary<string, object> ();

            
 
            string noValueFormat = Page.GetResourceValue("Txt:Other", "IPv5");

            CitiesRecord[] itemValues  = null;
            if (wc.RunQuery)
            {
                int counter = 0;
                int pageNum = 0;
                FormulaEvaluator evaluator = new FormulaEvaluator();
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
                            cvalue = itemValue.CityID.ToString();
                            if (counter < maxItems && this.CityIDFilter.Items.FindByValue(cvalue) == null)
                            {
                                    
                                Boolean _isExpandableNonCompositeForeignKey = VPropertyRentReviewsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyRentReviewsView.CityID);
                                if(_isExpandableNonCompositeForeignKey && VPropertyRentReviewsView.CityID.IsApplyDisplayAs)
                                     fvalue = VPropertyRentReviewsView.GetDFKA(itemValue, VPropertyRentReviewsView.CityID);
                                if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(fvalue)))
                                     fvalue = itemValue.Format(CitiesTable.City);
                                   					
                                if (fvalue == null || fvalue.Trim() == "") fvalue = cvalue;

                                if (fvalue == null) {
                                    fvalue = "";
                                }

                                fvalue = fvalue.Trim();

                                if ( fvalue.Length > 50 ) {
                                   fvalue = fvalue.Substring(0, 50) + "...";
                                }

                                ListItem dupItem = this.CityIDFilter.Items.FindByText(fvalue);
								
                                if (dupItem != null) {
                                    listDuplicates.Add(fvalue);
                                    if (!string.IsNullOrEmpty(dupItem.Value))
                                    {
                                        dupItem.Text = fvalue + " (ID " + dupItem.Value.Substring(0, Math.Min(dupItem.Value.Length,38)) + ")";
                                    }
                                }

                                ListItem newItem = new ListItem(fvalue, cvalue);
                                this.CityIDFilter.Items.Add(newItem);

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
                MiscUtils.SetSelectedValue(this.CityIDFilter, selectedValue);
                
            }
            catch
            {
            }
            
            
            if (this.CityIDFilter.SelectedValue != null && this.CityIDFilter.Items.FindByValue(this.CityIDFilter.SelectedValue) == null)
                this.CityIDFilter.SelectedValue = null;
                           
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
                                    
                                Boolean _isExpandableNonCompositeForeignKey = VPropertyRentReviewsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyRentReviewsView.PropertyID);
                                if(_isExpandableNonCompositeForeignKey && VPropertyRentReviewsView.PropertyID.IsApplyDisplayAs)
                                     fvalue = VPropertyRentReviewsView.GetDFKA(itemValue, VPropertyRentReviewsView.PropertyID);
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
            
        public virtual WhereClause CreateWhereClause_CityIDFilter()
        {
            // Create a where clause for the filter CityIDFilter.
            // This function is called by the Populate method to load the items 
            // in the CityIDFilterDropDownList
        
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
        
            this.SaveToSession(this.CityIDFilter, this.CityIDFilter.SelectedValue);
                  
            this.SaveToSession(this.PropertyIDFilter, this.PropertyIDFilter.SelectedValue);
                  
            this.SaveToSession(this.VPropertyRentReviewsSearch, this.VPropertyRentReviewsSearch.Text);
                  
            
                    
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
          
      this.SaveToSession("CityIDFilter_Ajax", this.CityIDFilter.SelectedValue);
              
      this.SaveToSession("PropertyIDFilter_Ajax", this.PropertyIDFilter.SelectedValue);
              
      this.SaveToSession("VPropertyRentReviewsSearch_Ajax", this.VPropertyRentReviewsSearch.Text);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.CityIDFilter);
            this.RemoveFromSession(this.PropertyIDFilter);
            this.RemoveFromSession(this.VPropertyRentReviewsSearch);
            
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

            string orderByStr = (string)ViewState["VPropertyRentReviewsTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("VPropertyRentReviewsPagination");
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
                this.ViewState["VPropertyRentReviewsTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
            this.ViewState["DeletedRecordIds"] = this.DeletedRecordIds;
        
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetVPropertyRentReviewsExportExcelButton()                
              
        {
        
   
        }
            
        public virtual void SetVPropertyRentReviewsPDFButton()                
              
        {
        
   
        }
            
        public virtual void SetVPropertyRentReviewsResetButton()                
              
        {
        
   
        }
            
        public virtual void SetVPropertyRentReviewsSearchButton()                
              
        {
        
   
        }
            
        public virtual void SetVPropertyRentReviewsWordButton()                
              
        {
        
   
        }
            
        public virtual void SetVPropertyRentReviewsButtonsButton()                
              
        {
        
   
        }
            
        public virtual void SetVPropertyRentReviewsFilterButton()                
              
        {
        
   
        }
            
        public virtual void SetVPropertyRentReviewsFiltersButton()                
              
        {
                
         IThemeButtonWithArrow themeButtonVPropertyRentReviewsFiltersButton = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "VPropertyRentReviewsFiltersButton"));
         themeButtonVPropertyRentReviewsFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
            if (MiscUtils.IsValueSelected(CityIDFilter))
                themeButtonVPropertyRentReviewsFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(PropertyIDFilter))
                themeButtonVPropertyRentReviewsFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
   
        }
               
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void VPropertyRentReviewsPagination_FirstPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void VPropertyRentReviewsPagination_LastPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void VPropertyRentReviewsPagination_NextPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void VPropertyRentReviewsPagination_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.VPropertyRentReviewsPagination.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.VPropertyRentReviewsPagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void VPropertyRentReviewsPagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
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
        
        public virtual void Address1Label_Click(object sender, EventArgs args)
        {
            //Sorts by Address1 when clicked.
              
            // Get previous sorting state for Address1.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyRentReviewsView.Address1);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Address1.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyRentReviewsView.Address1, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by Address1, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void Address1SortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by Address1 when clicked.
              
            // Get previous sorting state for Address1.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyRentReviewsView.Address1);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Address1.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyRentReviewsView.Address1, OrderByItem.OrderDir.Asc);
            
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
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyRentReviewsView.Address2);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Address2.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyRentReviewsView.Address2, OrderByItem.OrderDir.Asc);
            
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
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyRentReviewsView.Address3);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Address3.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyRentReviewsView.Address3, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by Address3, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void CityIDLabel_Click(object sender, EventArgs args)
        {
            //Sorts by CityID when clicked.
              
            // Get previous sorting state for CityID.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyRentReviewsView.CityID);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for CityID.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyRentReviewsView.CityID, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by CityID, so just reverse.
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
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyRentReviewsView.CityID);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for CityID.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyRentReviewsView.CityID, OrderByItem.OrderDir.Asc);
            
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
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyRentReviewsView.CompanyName);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for CompanyName.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyRentReviewsView.CompanyName, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by CompanyName, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void CountryIDLabel_Click(object sender, EventArgs args)
        {
            //Sorts by CountryID when clicked.
              
            // Get previous sorting state for CountryID.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyRentReviewsView.CountryID);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for CountryID.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyRentReviewsView.CountryID, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by CountryID, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void DescriptionLabel_Click(object sender, EventArgs args)
        {
            //Sorts by Description when clicked.
              
            // Get previous sorting state for Description.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyRentReviewsView.Description);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Description.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyRentReviewsView.Description, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by Description, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void DescriptionSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by Description when clicked.
              
            // Get previous sorting state for Description.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyRentReviewsView.Description);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Description.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyRentReviewsView.Description, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by Description, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void ExpiryDateLabel_Click(object sender, EventArgs args)
        {
            //Sorts by ExpiryDate when clicked.
              
            // Get previous sorting state for ExpiryDate.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyRentReviewsView.ExpiryDate);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for ExpiryDate.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyRentReviewsView.ExpiryDate, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by ExpiryDate, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void ExpiryDateSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by ExpiryDate when clicked.
              
            // Get previous sorting state for ExpiryDate.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyRentReviewsView.ExpiryDate);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for ExpiryDate.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyRentReviewsView.ExpiryDate, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by ExpiryDate, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void PostCodeLabel_Click(object sender, EventArgs args)
        {
            //Sorts by PostCode when clicked.
              
            // Get previous sorting state for PostCode.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyRentReviewsView.PostCode);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for PostCode.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyRentReviewsView.PostCode, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by PostCode, so just reverse.
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
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyRentReviewsView.PostCode);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for PostCode.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyRentReviewsView.PostCode, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by PostCode, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void PropertyIDLabel_Click(object sender, EventArgs args)
        {
            //Sorts by PropertyID when clicked.
              
            // Get previous sorting state for PropertyID.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyRentReviewsView.PropertyID);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for PropertyID.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyRentReviewsView.PropertyID, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by PropertyID, so just reverse.
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
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyRentReviewsView.PropertyID);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for PropertyID.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyRentReviewsView.PropertyID, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by PropertyID, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void RegionIDLabel_Click(object sender, EventArgs args)
        {
            //Sorts by RegionID when clicked.
              
            // Get previous sorting state for RegionID.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyRentReviewsView.RegionID);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for RegionID.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyRentReviewsView.RegionID, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by RegionID, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void RentReviewIDSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by RentReviewID when clicked.
              
            // Get previous sorting state for RentReviewID.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyRentReviewsView.RentReviewID);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for RentReviewID.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyRentReviewsView.RentReviewID, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by RentReviewID, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void VPropertyRentReviewsExportExcelButton_Click(object sender, ImageClickEventArgs args)
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


              this.TotalRecords = VPropertyRentReviewsView.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             VPropertyRentReviewsView.PropertyID,
             VPropertyRentReviewsView.Address1,
             VPropertyRentReviewsView.Address2,
             VPropertyRentReviewsView.Address3,
             VPropertyRentReviewsView.CityID,
             VPropertyRentReviewsView.RegionID,
             VPropertyRentReviewsView.CountryID,
             VPropertyRentReviewsView.PostCode,
             VPropertyRentReviewsView.ExpiryDate,
             VPropertyRentReviewsView.Description,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(VPropertyRentReviewsView.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(VPropertyRentReviewsView.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(VPropertyRentReviewsView.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(VPropertyRentReviewsView.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(VPropertyRentReviewsView.PropertyID, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyRentReviewsView.Address1, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyRentReviewsView.Address2, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyRentReviewsView.Address3, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyRentReviewsView.CityID, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyRentReviewsView.RegionID, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyRentReviewsView.CountryID, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyRentReviewsView.PostCode, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyRentReviewsView.ExpiryDate, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(VPropertyRentReviewsView.Description, "Default"));


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
                val = VPropertyRentReviewsView.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
        public virtual void VPropertyRentReviewsPDFButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                PDFReport report = new PDFReport();

                report.SpecificReportFileName = Page.Server.MapPath("GroupByVPropertyRentReviewsTable.VPropertyRentReviewsPDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "vPropertyRentReviews";
                // If GroupByVPropertyRentReviewsTable.VPropertyRentReviewsPDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(VPropertyRentReviewsView.PropertyID.Name, ReportEnum.Align.Left, "${PropertyID}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyRentReviewsView.Address1.Name, ReportEnum.Align.Left, "${Address1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyRentReviewsView.Address2.Name, ReportEnum.Align.Left, "${Address2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyRentReviewsView.Address3.Name, ReportEnum.Align.Left, "${Address3}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyRentReviewsView.CityID.Name, ReportEnum.Align.Left, "${CityID}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyRentReviewsView.RegionID.Name, ReportEnum.Align.Left, "${RegionID}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyRentReviewsView.CountryID.Name, ReportEnum.Align.Left, "${CountryID}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyRentReviewsView.PostCode.Name, ReportEnum.Align.Left, "${PostCode}", ReportEnum.Align.Left, 24);
                 report.AddColumn(VPropertyRentReviewsView.ExpiryDate.Name, ReportEnum.Align.Left, "${ExpiryDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(VPropertyRentReviewsView.Description.Name, ReportEnum.Align.Left, "${Description}", ReportEnum.Align.Left, 28);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "IPv5");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = VPropertyRentReviewsView.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = VPropertyRentReviewsView.GetRecordCount(joinFilter,whereClause);
                VPropertyRentReviewsRecord[] records = null;
                
                do
                {
                    
                    records = VPropertyRentReviewsView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( VPropertyRentReviewsRecord record in records)
                    
                        {
                            // AddData method takes four parameters   
                            // The 1st parameter represent the data format
                            // The 2nd parameter represent the data value
                            // The 3rd parameter represent the default alignment of column using the data
                            // The 4th parameter represent the maximum length of the data value being shown
                                                 if (BaseClasses.Utils.MiscUtils.IsNull(record.PropertyID)){
                                 report.AddData("${PropertyID}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = VPropertyRentReviewsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyRentReviewsView.PropertyID);
                                 _DFKA = VPropertyRentReviewsView.GetDFKA(record.PropertyID.ToString(), VPropertyRentReviewsView.PropertyID,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  VPropertyRentReviewsView.PropertyID.IsApplyDisplayAs){
                                     report.AddData("${PropertyID}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${PropertyID}", record.Format(VPropertyRentReviewsView.PropertyID), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${Address1}", record.Format(VPropertyRentReviewsView.Address1), ReportEnum.Align.Left, 100);
                             report.AddData("${Address2}", record.Format(VPropertyRentReviewsView.Address2), ReportEnum.Align.Left, 100);
                             report.AddData("${Address3}", record.Format(VPropertyRentReviewsView.Address3), ReportEnum.Align.Left, 100);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.CityID)){
                                 report.AddData("${CityID}", "",ReportEnum.Align.Left, 100);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = VPropertyRentReviewsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyRentReviewsView.CityID);
                                 _DFKA = VPropertyRentReviewsView.GetDFKA(record.CityID.ToString(), VPropertyRentReviewsView.CityID,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  VPropertyRentReviewsView.CityID.IsApplyDisplayAs){
                                     report.AddData("${CityID}", _DFKA,ReportEnum.Align.Left, 100);
                                 }else{
                                     report.AddData("${CityID}", record.Format(VPropertyRentReviewsView.CityID), ReportEnum.Align.Left, 100);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.RegionID)){
                                 report.AddData("${RegionID}", "",ReportEnum.Align.Left, 100);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = VPropertyRentReviewsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyRentReviewsView.RegionID);
                                 _DFKA = VPropertyRentReviewsView.GetDFKA(record.RegionID.ToString(), VPropertyRentReviewsView.RegionID,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  VPropertyRentReviewsView.RegionID.IsApplyDisplayAs){
                                     report.AddData("${RegionID}", _DFKA,ReportEnum.Align.Left, 100);
                                 }else{
                                     report.AddData("${RegionID}", record.Format(VPropertyRentReviewsView.RegionID), ReportEnum.Align.Left, 100);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.CountryID)){
                                 report.AddData("${CountryID}", "",ReportEnum.Align.Left, 100);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = VPropertyRentReviewsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyRentReviewsView.CountryID);
                                 _DFKA = VPropertyRentReviewsView.GetDFKA(record.CountryID.ToString(), VPropertyRentReviewsView.CountryID,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  VPropertyRentReviewsView.CountryID.IsApplyDisplayAs){
                                     report.AddData("${CountryID}", _DFKA,ReportEnum.Align.Left, 100);
                                 }else{
                                     report.AddData("${CountryID}", record.Format(VPropertyRentReviewsView.CountryID), ReportEnum.Align.Left, 100);
                                 }
                             }
                             report.AddData("${PostCode}", record.Format(VPropertyRentReviewsView.PostCode), ReportEnum.Align.Left, 100);
                             report.AddData("${ExpiryDate}", record.Format(VPropertyRentReviewsView.ExpiryDate), ReportEnum.Align.Left, 100);
                             report.AddData("${Description}", record.Format(VPropertyRentReviewsView.Description), ReportEnum.Align.Left, 15);

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
        public virtual void VPropertyRentReviewsResetButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
              this.CityIDFilter.ClearSelection();
            
              this.PropertyIDFilter.ClearSelection();
            
              this.VPropertyRentReviewsSearch.Text = "";
            
              this.CurrentSortOrder.Reset();
              if (this.InSession(this, "Order_By"))
                  this.CurrentSortOrder = OrderBy.FromXmlString(this.GetFromSession(this, "Order_By", null));
              else
              {
                  this.CurrentSortOrder = new OrderBy(true, false);
              
                  this.CurrentSortOrder.Add(VPropertyRentReviewsView.CompanyName, OrderByItem.OrderDir.Asc);          
                      
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
        public virtual void VPropertyRentReviewsSearchButton_Click(object sender, ImageClickEventArgs args)
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
        public virtual void VPropertyRentReviewsWordButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("GroupByVPropertyRentReviewsTable.VPropertyRentReviewsWordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "vPropertyRentReviews";
                // If GroupByVPropertyRentReviewsTable.VPropertyRentReviewsWordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(VPropertyRentReviewsView.PropertyID.Name, ReportEnum.Align.Left, "${PropertyID}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyRentReviewsView.Address1.Name, ReportEnum.Align.Left, "${Address1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyRentReviewsView.Address2.Name, ReportEnum.Align.Left, "${Address2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyRentReviewsView.Address3.Name, ReportEnum.Align.Left, "${Address3}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyRentReviewsView.CityID.Name, ReportEnum.Align.Left, "${CityID}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyRentReviewsView.RegionID.Name, ReportEnum.Align.Left, "${RegionID}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyRentReviewsView.CountryID.Name, ReportEnum.Align.Left, "${CountryID}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyRentReviewsView.PostCode.Name, ReportEnum.Align.Left, "${PostCode}", ReportEnum.Align.Left, 24);
                 report.AddColumn(VPropertyRentReviewsView.ExpiryDate.Name, ReportEnum.Align.Left, "${ExpiryDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(VPropertyRentReviewsView.Description.Name, ReportEnum.Align.Left, "${Description}", ReportEnum.Align.Left, 28);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = VPropertyRentReviewsView.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "IPv5");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = VPropertyRentReviewsView.GetColumnList();
                VPropertyRentReviewsRecord[] records = null;
                do
                {
                    records = VPropertyRentReviewsView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( VPropertyRentReviewsRecord record in records)
                        {
                            // AddData method takes four parameters
                            // The 1st parameter represents the data format
                            // The 2nd parameter represents the data value
                            // The 3rd parameter represents the default alignment of column using the data
                            // The 4th parameter represents the maximum length of the data value being shown
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.PropertyID)){
                                 report.AddData("${PropertyID}", "",ReportEnum.Align.Left);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = VPropertyRentReviewsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyRentReviewsView.PropertyID);
                                 _DFKA = VPropertyRentReviewsView.GetDFKA(record.PropertyID.ToString(), VPropertyRentReviewsView.PropertyID,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  VPropertyRentReviewsView.PropertyID.IsApplyDisplayAs){
                                     report.AddData("${PropertyID}", _DFKA,ReportEnum.Align.Left);
                                 }else{
                                     report.AddData("${PropertyID}", record.Format(VPropertyRentReviewsView.PropertyID), ReportEnum.Align.Left);
                                 }
                             }
                             report.AddData("${Address1}", record.Format(VPropertyRentReviewsView.Address1), ReportEnum.Align.Left, 100);
                             report.AddData("${Address2}", record.Format(VPropertyRentReviewsView.Address2), ReportEnum.Align.Left, 100);
                             report.AddData("${Address3}", record.Format(VPropertyRentReviewsView.Address3), ReportEnum.Align.Left, 100);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.CityID)){
                                 report.AddData("${CityID}", "",ReportEnum.Align.Left, 100);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = VPropertyRentReviewsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyRentReviewsView.CityID);
                                 _DFKA = VPropertyRentReviewsView.GetDFKA(record.CityID.ToString(), VPropertyRentReviewsView.CityID,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  VPropertyRentReviewsView.CityID.IsApplyDisplayAs){
                                     report.AddData("${CityID}", _DFKA,ReportEnum.Align.Left, 100);
                                 }else{
                                     report.AddData("${CityID}", record.Format(VPropertyRentReviewsView.CityID), ReportEnum.Align.Left, 100);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.RegionID)){
                                 report.AddData("${RegionID}", "",ReportEnum.Align.Left, 100);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = VPropertyRentReviewsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyRentReviewsView.RegionID);
                                 _DFKA = VPropertyRentReviewsView.GetDFKA(record.RegionID.ToString(), VPropertyRentReviewsView.RegionID,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  VPropertyRentReviewsView.RegionID.IsApplyDisplayAs){
                                     report.AddData("${RegionID}", _DFKA,ReportEnum.Align.Left, 100);
                                 }else{
                                     report.AddData("${RegionID}", record.Format(VPropertyRentReviewsView.RegionID), ReportEnum.Align.Left, 100);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.CountryID)){
                                 report.AddData("${CountryID}", "",ReportEnum.Align.Left, 100);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = VPropertyRentReviewsView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyRentReviewsView.CountryID);
                                 _DFKA = VPropertyRentReviewsView.GetDFKA(record.CountryID.ToString(), VPropertyRentReviewsView.CountryID,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  VPropertyRentReviewsView.CountryID.IsApplyDisplayAs){
                                     report.AddData("${CountryID}", _DFKA,ReportEnum.Align.Left, 100);
                                 }else{
                                     report.AddData("${CountryID}", record.Format(VPropertyRentReviewsView.CountryID), ReportEnum.Align.Left, 100);
                                 }
                             }
                             report.AddData("${PostCode}", record.Format(VPropertyRentReviewsView.PostCode), ReportEnum.Align.Left, 100);
                             report.AddData("${ExpiryDate}", record.Format(VPropertyRentReviewsView.ExpiryDate), ReportEnum.Align.Left, 100);
                             report.AddData("${Description}", record.Format(VPropertyRentReviewsView.Description), ReportEnum.Align.Left, 15);

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
        public virtual void VPropertyRentReviewsButtonsButton_Click(object sender, EventArgs args)
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
        public virtual void VPropertyRentReviewsFilterButton_Click(object sender, EventArgs args)
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
        public virtual void VPropertyRentReviewsFiltersButton_Click(object sender, EventArgs args)
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
        protected virtual void CityIDFilter_SelectedIndexChanged(object sender, EventArgs args)
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
                    _TotalRecords = VPropertyRentReviewsView.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  VPropertyRentReviewsRecord[] DataSource {
             
            get {
                return (VPropertyRentReviewsRecord[])(base._DataSource);
            }
            set {
                this._DataSource = value;
            }
        }

#region "Helper Properties"
        
        public System.Web.UI.WebControls.LinkButton Address1Label {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Address1Label");
            }
        }
        
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
        
        public System.Web.UI.WebControls.DropDownList CityIDFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CityIDFilter");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton CityIDLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CityIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal CityIDLabel1 {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CityIDLabel1");
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
        
        public System.Web.UI.WebControls.LinkButton CountryIDLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CountryIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton DescriptionLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DescriptionLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton DescriptionSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DescriptionSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal DueNow {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DueNow");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ExpiryDateLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExpiryDateLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ExpiryDateSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExpiryDateSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Literal {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Literal");
            }
        }
        
        public System.Web.UI.WebControls.Literal NextMonth {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "NextMonth");
            }
        }
        
        public System.Web.UI.WebControls.Literal Overdue {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Overdue");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton PostCodeLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PostCodeLabel");
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
        
        public System.Web.UI.WebControls.LinkButton PropertyIDLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyIDLabel");
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
        
        public System.Web.UI.WebControls.LinkButton RegionIDLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RegionIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton RentReviewIDSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RentReviewIDSortLabel");
            }
        }
        
        public IPv5.UI.IThemeButtonWithArrow VPropertyRentReviewsButtonsButton {
            get {
                return (IPv5.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyRentReviewsButtonsButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton VPropertyRentReviewsExportExcelButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyRentReviewsExportExcelButton");
            }
        }
        
        public IPv5.UI.IThemeButton VPropertyRentReviewsFilterButton {
            get {
                return (IPv5.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyRentReviewsFilterButton");
            }
        }
        
        public IPv5.UI.IThemeButtonWithArrow VPropertyRentReviewsFiltersButton {
            get {
                return (IPv5.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyRentReviewsFiltersButton");
            }
        }
        
        public IPv5.UI.IPaginationMedium VPropertyRentReviewsPagination {
            get {
                return (IPv5.UI.IPaginationMedium)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyRentReviewsPagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton VPropertyRentReviewsPDFButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyRentReviewsPDFButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton VPropertyRentReviewsResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyRentReviewsResetButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VPropertyRentReviewsSearch {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyRentReviewsSearch");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton VPropertyRentReviewsSearchButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyRentReviewsSearchButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal VPropertyRentReviewsTitle {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyRentReviewsTitle");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton VPropertyRentReviewsWordButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyRentReviewsWordButton");
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
                VPropertyRentReviewsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IPv5"));
                }

        VPropertyRentReviewsRecord rec = null;
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
                VPropertyRentReviewsTableControlRow recCtl = this.GetSelectedRecordControl();
                if (recCtl == null && url.IndexOf("{") >= 0) {
                    // Localization.
                    throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IPv5"));
                }

        VPropertyRentReviewsRecord rec = null;
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
          
        public virtual VPropertyRentReviewsTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual VPropertyRentReviewsTableControlRow[] GetSelectedRecordControls()
        {
        
            return (VPropertyRentReviewsTableControlRow[])((new ArrayList()).ToArray(Type.GetType("IPv5.UI.Controls.GroupByVPropertyRentReviewsTable.VPropertyRentReviewsTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            VPropertyRentReviewsTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IPv5"));
            }
            
            foreach (VPropertyRentReviewsTableControlRow recCtl in recordList)
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

        public virtual VPropertyRentReviewsTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "VPropertyRentReviewsTableControlRow");
	          List<VPropertyRentReviewsTableControlRow> list = new List<VPropertyRentReviewsTableControlRow>();
	          foreach (VPropertyRentReviewsTableControlRow recCtrl in recCtrls) {
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

  