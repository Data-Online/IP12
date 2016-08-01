
// This file implements the TableControl, TableControlRow, and RecordControl classes for the 
// ShowVPropertyTermExpiresTable2.aspx page.  The Row or RecordControl classes are the 
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

  
namespace IPv5.UI.Controls.ShowVPropertyTermExpiresTable2
{
  

#region "Section 1: Place your customizations here."

    
public class VPropertyTermExpiresTableControlRow : BaseVPropertyTermExpiresTableControlRow
{
      
        // The BaseVPropertyTermExpiresTableControlRow implements code for a ROW within the
        // the VPropertyTermExpiresTableControl table.  The BaseVPropertyTermExpiresTableControlRow implements the DataBind and SaveData methods.
        // The loading of data is actually performed by the LoadData method in the base class of VPropertyTermExpiresTableControl.

        // This is the ideal place to add your code customizations. For example, you can override the DataBind, 
        // SaveData, GetUIData, and Validate methods.
        
}

  

public class VPropertyTermExpiresTableControl : BaseVPropertyTermExpiresTableControl
{
    // The BaseVPropertyTermExpiresTableControl class implements the LoadData, DataBind, CreateWhereClause
    // and other methods to load and display the data in a table control.

    // This is the ideal place to add your code customizations. You can override the LoadData and CreateWhereClause,
    // The VPropertyTermExpiresTableControlRow class offers another place where you can customize
    // the DataBind, GetUIData, SaveData and Validate methods specific to each row displayed on the table.

}

  

#endregion

  

#region "Section 2: Do not modify this section."
    
    
// Base class for the VPropertyTermExpiresTableControlRow control on the ShowVPropertyTermExpiresTable2 page.
// Do not modify this class. Instead override any method in VPropertyTermExpiresTableControlRow.
public class BaseVPropertyTermExpiresTableControlRow : IPv5.UI.BaseApplicationRecordControl
{
        public BaseVPropertyTermExpiresTableControlRow()
        {
            this.Init += Control_Init;
            this.Load += Control_Load;
            this.PreRender += Control_PreRender;
            this.EvaluateFormulaDelegate = new DataSource.EvaluateFormulaDelegate(this.EvaluateFormula);
        }

        // To customize, override this method in VPropertyTermExpiresTableControlRow.
        protected virtual void Control_Init(object sender, System.EventArgs e)
        {
                
        }

        // To customize, override this method in VPropertyTermExpiresTableControlRow.
        protected virtual void Control_Load(object sender, System.EventArgs e)
        {      
                    
        
              // Register the event handlers.

          
        }

        public virtual void LoadData()  
        {
            // Load the data from the database into the DataSource DatabaseMM_IP1%dbo.vPropertyTermExpires record.
            // It is better to make changes to functions called by LoadData such as
            // CreateWhereClause, rather than making changes here.
            
        
            // Since this is a row in the table, the data for this row is loaded by the 
            // LoadData method of the BaseVPropertyTermExpiresTableControl when the data for the entire
            // table is loaded.
            
            this.DataSource = new VPropertyTermExpiresRecord();
            
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
        
                SetAddress1();
                SetAddress1Label();
                SetAddress2();
                SetAddress2Label();
                SetAddress3();
                SetAddress3Label();
                SetCityID();
                SetCityIDLabel();
                SetCompanyName();
                SetCompanyNameLabel();
                SetCountryID();
                SetCountryIDLabel();
                SetDescription();
                SetDescriptionLabel();
                SetExpiryDate();
                SetExpiryDateLabel();
                SetPostCode();
                SetPostCodeLabel();
                SetPropertyID();
                SetPropertyIDLabel();
                SetRegionID();
                SetRegionIDLabel();
                SetTermExpireID();
                SetTermExpireIDLabel();

      

            this.IsNewRecord = true;
          
            if (this.DataSource.IsCreated) {
                this.IsNewRecord = false;
              
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
            // DatabaseMM_IP1%dbo.vPropertyTermExpires database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyTermExpires record retrieved from the database.
            // this.Address1 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address1Specified) {
                								
                // If the Address1 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyTermExpiresView.Address1);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address1.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address1 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address1.Text = VPropertyTermExpiresView.Address1.Format(VPropertyTermExpiresView.Address1.DefaultValue);
            		
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
            // DatabaseMM_IP1%dbo.vPropertyTermExpires database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyTermExpires record retrieved from the database.
            // this.Address2 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address2Specified) {
                								
                // If the Address2 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyTermExpiresView.Address2);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address2.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address2 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address2.Text = VPropertyTermExpiresView.Address2.Format(VPropertyTermExpiresView.Address2.DefaultValue);
            		
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
            // DatabaseMM_IP1%dbo.vPropertyTermExpires database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyTermExpires record retrieved from the database.
            // this.Address3 is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.Address3Specified) {
                								
                // If the Address3 is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyTermExpiresView.Address3);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Address3.Text = formattedValue;
                   
            } 
            
            else {
            
                // Address3 is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Address3.Text = VPropertyTermExpiresView.Address3.Format(VPropertyTermExpiresView.Address3.DefaultValue);
            		
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
            // DatabaseMM_IP1%dbo.vPropertyTermExpires database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyTermExpires record retrieved from the database.
            // this.CityID is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CityIDSpecified) {
                								
                // If the CityID is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = VPropertyTermExpiresView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyTermExpiresView.CityID);
               if(_isExpandableNonCompositeForeignKey &&VPropertyTermExpiresView.CityID.IsApplyDisplayAs)
                                  
                     formattedValue = VPropertyTermExpiresView.GetDFKA(this.DataSource.CityID.ToString(),VPropertyTermExpiresView.CityID, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(VPropertyTermExpiresView.CityID);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CityID.Text = formattedValue;
                   
            } 
            
            else {
            
                // CityID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CityID.Text = VPropertyTermExpiresView.CityID.Format(VPropertyTermExpiresView.CityID.DefaultValue);
            		
            }
            
            // If the CityID is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CityID.Text == null ||
                this.CityID.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CityID.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCompanyName()
        {
            
                    
            // Set the CompanyName Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyTermExpires database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyTermExpires record retrieved from the database.
            // this.CompanyName is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CompanyNameSpecified) {
                								
                // If the CompanyName is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyTermExpiresView.CompanyName);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CompanyName.Text = formattedValue;
                   
            } 
            
            else {
            
                // CompanyName is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CompanyName.Text = VPropertyTermExpiresView.CompanyName.Format(VPropertyTermExpiresView.CompanyName.DefaultValue);
            		
            }
            
            // If the CompanyName is NULL or blank, then use the value specified  
            // on Properties.
            if (this.CompanyName.Text == null ||
                this.CompanyName.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.CompanyName.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetCountryID()
        {
            
                    
            // Set the CountryID Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyTermExpires database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyTermExpires record retrieved from the database.
            // this.CountryID is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.CountryIDSpecified) {
                								
                // If the CountryID is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = VPropertyTermExpiresView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyTermExpiresView.CountryID);
               if(_isExpandableNonCompositeForeignKey &&VPropertyTermExpiresView.CountryID.IsApplyDisplayAs)
                                  
                     formattedValue = VPropertyTermExpiresView.GetDFKA(this.DataSource.CountryID.ToString(),VPropertyTermExpiresView.CountryID, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(VPropertyTermExpiresView.CountryID);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.CountryID.Text = formattedValue;
                   
            } 
            
            else {
            
                // CountryID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.CountryID.Text = VPropertyTermExpiresView.CountryID.Format(VPropertyTermExpiresView.CountryID.DefaultValue);
            		
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
            // DatabaseMM_IP1%dbo.vPropertyTermExpires database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyTermExpires record retrieved from the database.
            // this.Description is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.DescriptionSpecified) {
                								
                // If the Description is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyTermExpiresView.Description);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.Description.Text = formattedValue;
                   
            } 
            
            else {
            
                // Description is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.Description.Text = VPropertyTermExpiresView.Description.Format(VPropertyTermExpiresView.Description.DefaultValue);
            		
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
            // DatabaseMM_IP1%dbo.vPropertyTermExpires database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyTermExpires record retrieved from the database.
            // this.ExpiryDate is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.ExpiryDateSpecified) {
                								
                // If the ExpiryDate is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyTermExpiresView.ExpiryDate, @"d");
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.ExpiryDate.Text = formattedValue;
                   
            } 
            
            else {
            
                // ExpiryDate is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.ExpiryDate.Text = VPropertyTermExpiresView.ExpiryDate.Format(VPropertyTermExpiresView.ExpiryDate.DefaultValue, @"d");
            		
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
            // DatabaseMM_IP1%dbo.vPropertyTermExpires database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyTermExpires record retrieved from the database.
            // this.PostCode is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PostCodeSpecified) {
                								
                // If the PostCode is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyTermExpiresView.PostCode);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PostCode.Text = formattedValue;
                   
            } 
            
            else {
            
                // PostCode is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PostCode.Text = VPropertyTermExpiresView.PostCode.Format(VPropertyTermExpiresView.PostCode.DefaultValue);
            		
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
            
                    
            // Set the PropertyID Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyTermExpires database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyTermExpires record retrieved from the database.
            // this.PropertyID is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.PropertyIDSpecified) {
                								
                // If the PropertyID is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = VPropertyTermExpiresView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyTermExpiresView.PropertyID);
               if(_isExpandableNonCompositeForeignKey &&VPropertyTermExpiresView.PropertyID.IsApplyDisplayAs)
                                  
                     formattedValue = VPropertyTermExpiresView.GetDFKA(this.DataSource.PropertyID.ToString(),VPropertyTermExpiresView.PropertyID, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(VPropertyTermExpiresView.PropertyID);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.PropertyID.Text = formattedValue;
                   
            } 
            
            else {
            
                // PropertyID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.PropertyID.Text = VPropertyTermExpiresView.PropertyID.Format(VPropertyTermExpiresView.PropertyID.DefaultValue);
            		
            }
            
            // If the PropertyID is NULL or blank, then use the value specified  
            // on Properties.
            if (this.PropertyID.Text == null ||
                this.PropertyID.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.PropertyID.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetRegionID()
        {
            
                    
            // Set the RegionID Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyTermExpires database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyTermExpires record retrieved from the database.
            // this.RegionID is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.RegionIDSpecified) {
                								
                // If the RegionID is non-NULL, then format the value.
                // The Format method will return the Display Foreign Key As (DFKA) value
               string formattedValue = "";
               Boolean _isExpandableNonCompositeForeignKey = VPropertyTermExpiresView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyTermExpiresView.RegionID);
               if(_isExpandableNonCompositeForeignKey &&VPropertyTermExpiresView.RegionID.IsApplyDisplayAs)
                                  
                     formattedValue = VPropertyTermExpiresView.GetDFKA(this.DataSource.RegionID.ToString(),VPropertyTermExpiresView.RegionID, null);
                                    
               if ((!_isExpandableNonCompositeForeignKey) || (String.IsNullOrEmpty(formattedValue)))
                     formattedValue = this.DataSource.Format(VPropertyTermExpiresView.RegionID);
                                  
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.RegionID.Text = formattedValue;
                   
            } 
            
            else {
            
                // RegionID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.RegionID.Text = VPropertyTermExpiresView.RegionID.Format(VPropertyTermExpiresView.RegionID.DefaultValue);
            		
            }
            
            // If the RegionID is NULL or blank, then use the value specified  
            // on Properties.
            if (this.RegionID.Text == null ||
                this.RegionID.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.RegionID.Text = "&nbsp;";
            }
                                     
        }
                
        public virtual void SetTermExpireID()
        {
            
                    
            // Set the TermExpireID Literal on the webpage with value from the
            // DatabaseMM_IP1%dbo.vPropertyTermExpires database record.

            // this.DataSource is the DatabaseMM_IP1%dbo.vPropertyTermExpires record retrieved from the database.
            // this.TermExpireID is the ASP:Literal on the webpage.
                  
            if (this.DataSource != null && this.DataSource.TermExpireIDSpecified) {
                								
                // If the TermExpireID is non-NULL, then format the value.
                // The Format method will use the Display Format
               string formattedValue = this.DataSource.Format(VPropertyTermExpiresView.TermExpireID);
                                
                formattedValue = HttpUtility.HtmlEncode(formattedValue);
                this.TermExpireID.Text = formattedValue;
                   
            } 
            
            else {
            
                // TermExpireID is NULL in the database, so use the Default Value.  
                // Default Value could also be NULL.
        
              this.TermExpireID.Text = VPropertyTermExpiresView.TermExpireID.Format(VPropertyTermExpiresView.TermExpireID.DefaultValue);
            		
            }
            
            // If the TermExpireID is NULL or blank, then use the value specified  
            // on Properties.
            if (this.TermExpireID.Text == null ||
                this.TermExpireID.Text.Trim().Length == 0) {
                // Set the value specified on the Properties.
                this.TermExpireID.Text = "&nbsp;";
            }
                                     
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
                
        public virtual void SetCityIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetCompanyNameLabel()
                  {
                  
                    
        }
                
        public virtual void SetCountryIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetDescriptionLabel()
                  {
                  
                    
        }
                
        public virtual void SetExpiryDateLabel()
                  {
                  
                    
        }
                
        public virtual void SetPostCodeLabel()
                  {
                  
                    
        }
                
        public virtual void SetPropertyIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetRegionIDLabel()
                  {
                  
                    
        }
                
        public virtual void SetTermExpireIDLabel()
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
                
                // add datasource as variables for formula evaluation
                  VPropertyTermExpiresTableControl panel;
                panel = (VPropertyTermExpiresTableControl)(this.GetParentTableControl());
                  
                e.Variables.Add("VPropertyTermExpiresCountQuery", panel.VPropertyTermExpiresCountQuery);                                                       
                        
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
                ((VPropertyTermExpiresTableControl)MiscUtils.GetParentControlObject(this, "VPropertyTermExpiresTableControl")).DataChanged = true;
                ((VPropertyTermExpiresTableControl)MiscUtils.GetParentControlObject(this, "VPropertyTermExpiresTableControl")).ResetData = true;
            }
            
      
            // update session or cookie by formula
             		  
      
            // Setting the DataChanged to True results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
            this.ResetData = true;
            
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
            GetCompanyName();
            GetCountryID();
            GetDescription();
            GetExpiryDate();
            GetPostCode();
            GetPropertyID();
            GetRegionID();
            GetTermExpireID();
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
                
        public virtual void GetCompanyName()
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
                
        public virtual void GetTermExpireID()
        {
            
        }
                

      // To customize, override this method in VPropertyTermExpiresTableControlRow.
      
        public virtual WhereClause CreateWhereClause()
         
        {
    
            bool hasFiltersVPropertyTermExpiresTableControl = false;
            hasFiltersVPropertyTermExpiresTableControl = hasFiltersVPropertyTermExpiresTableControl && false; // suppress warning
      
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
        
  
        private Hashtable _PreviousUIData = new Hashtable();
        public virtual Hashtable PreviousUIData {
            get {
                return this._PreviousUIData;
            }
            set {
                this._PreviousUIData = value;
            }
        }
  

        
        public VPropertyTermExpiresRecord DataSource {
            get {
                return (VPropertyTermExpiresRecord)(this._DataSource);
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
        
        public System.Web.UI.WebControls.Literal CityID {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CityID");
            }
        }
            
        public System.Web.UI.WebControls.Literal CityIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CityIDLabel");
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
        
        public System.Web.UI.WebControls.Literal CountryID {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CountryID");
            }
        }
            
        public System.Web.UI.WebControls.Literal CountryIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CountryIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal Description {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "Description");
            }
        }
            
        public System.Web.UI.WebControls.Literal DescriptionLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DescriptionLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal ExpiryDate {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExpiryDate");
            }
        }
            
        public System.Web.UI.WebControls.Literal ExpiryDateLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExpiryDateLabel");
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
        
        public System.Web.UI.WebControls.Literal PropertyID {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyID");
            }
        }
            
        public System.Web.UI.WebControls.Literal PropertyIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "PropertyIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal RegionID {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RegionID");
            }
        }
            
        public System.Web.UI.WebControls.Literal RegionIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "RegionIDLabel");
            }
        }
        
        public System.Web.UI.WebControls.Literal TermExpireID {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TermExpireID");
            }
        }
            
        public System.Web.UI.WebControls.Literal TermExpireIDLabel {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TermExpireIDLabel");
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
        VPropertyTermExpiresRecord rec = null;
             
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
    VPropertyTermExpiresRecord rec = null;
    
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

        
        public virtual VPropertyTermExpiresRecord GetRecord()
             
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

  
// Base class for the VPropertyTermExpiresTableControl control on the ShowVPropertyTermExpiresTable2 page.
// Do not modify this class. Instead override any method in VPropertyTermExpiresTableControl.
public class BaseVPropertyTermExpiresTableControl : IPv5.UI.BaseApplicationTableControl
{
         
       public BaseVPropertyTermExpiresTableControl()
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
                if  (this.InSession(this.VPropertyTermExpiresSearch)) 				
                    initialVal = this.GetFromSession(this.VPropertyTermExpiresSearch);
                
                if(StringUtils.InvariantEquals(initialVal, "Search for", true) || StringUtils.InvariantEquals(initialVal, BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null), true))
                {
                initialVal = "";
                }
              
                if (initialVal != null && initialVal != "")		
                {
                        
                    this.VPropertyTermExpiresSearch.Text = initialVal;
                            
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
            
                    this.VPropertyTermExpiresPagination.FirstPage.Click += VPropertyTermExpiresPagination_FirstPage_Click;
                        
                    this.VPropertyTermExpiresPagination.LastPage.Click += VPropertyTermExpiresPagination_LastPage_Click;
                        
                    this.VPropertyTermExpiresPagination.NextPage.Click += VPropertyTermExpiresPagination_NextPage_Click;
                        
                    this.VPropertyTermExpiresPagination.PageSizeButton.Click += VPropertyTermExpiresPagination_PageSizeButton_Click;
                        
                    this.VPropertyTermExpiresPagination.PreviousPage.Click += VPropertyTermExpiresPagination_PreviousPage_Click;
                        

            string url =""; //to avoid warning in VS as its not being used
            if(url == null) url=""; //to avoid warning in VS as its not being used
        
       // Setup the sorting events.
        
              this.Address1SortLabel.Click += Address1SortLabel_Click;
            
              this.Address2SortLabel.Click += Address2SortLabel_Click;
            
              this.Address3SortLabel.Click += Address3SortLabel_Click;
            
              this.CityIDSortLabel.Click += CityIDSortLabel_Click;
            
              this.CompanyNameSortLabel.Click += CompanyNameSortLabel_Click;
            
              this.DescriptionSortLabel.Click += DescriptionSortLabel_Click;
            
              this.ExpiryDateSortLabel.Click += ExpiryDateSortLabel_Click;
            
              this.PostCodeSortLabel.Click += PostCodeSortLabel_Click;
            
              this.PropertyIDSortLabel.Click += PropertyIDSortLabel_Click;
            
              this.TermExpireIDSortLabel.Click += TermExpireIDSortLabel_Click;
            
            // Setup the button events.
          
                    this.VPropertyTermExpiresExportExcelButton.Click += VPropertyTermExpiresExportExcelButton_Click;
                        
                    this.VPropertyTermExpiresPDFButton.Click += VPropertyTermExpiresPDFButton_Click;
                        
                    this.VPropertyTermExpiresResetButton.Click += VPropertyTermExpiresResetButton_Click;
                        
                    this.VPropertyTermExpiresSearchButton.Click += VPropertyTermExpiresSearchButton_Click;
                        
                    this.VPropertyTermExpiresWordButton.Click += VPropertyTermExpiresWordButton_Click;
                        
                    this.VPropertyTermExpiresButtonsButton.Button.Click += VPropertyTermExpiresButtonsButton_Click;
                        
                    this.VPropertyTermExpiresFilterButton.Button.Click += VPropertyTermExpiresFilterButton_Click;
                        
                    this.VPropertyTermExpiresFiltersButton.Button.Click += VPropertyTermExpiresFiltersButton_Click;
                        
            this.CityIDFilter.SelectedIndexChanged += new EventHandler(CityIDFilter_SelectedIndexChanged);
            
            this.PropertyIDFilter.SelectedIndexChanged += new EventHandler(PropertyIDFilter_SelectedIndexChanged);
                    
        
         //' Setup events for others
            AjaxControlToolkit.ToolkitScriptManager.RegisterStartupScript(this, this.GetType(), "VPropertyTermExpiresSearchSearchBoxText", "setSearchBoxText(\"" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "\", \"" + VPropertyTermExpiresSearch.ClientID + "\");", true);
             
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
                      Type myrec = typeof(IPv5.Business.VPropertyTermExpiresRecord);
                      this.DataSource = (VPropertyTermExpiresRecord[])(alist.ToArray(myrec));
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
                    foreach (VPropertyTermExpiresTableControlRow rc in this.GetRecordControls()) {
                        if (!rc.IsNewRecord) {
                            rc.DataSource = rc.GetRecord();
                            rc.GetUIData();
                            postdata.Add(rc.DataSource);
                            UIData.Add(rc.PreservedUIData());
                        }
                    }
                    Type myrec = typeof(IPv5.Business.VPropertyTermExpiresRecord);
                    this.DataSource = (VPropertyTermExpiresRecord[])(postdata.ToArray(myrec));
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
        
        public virtual VPropertyTermExpiresRecord[] GetRecords(BaseFilter join, WhereClause where, OrderBy orderBy, int pageIndex, int pageSize)
        {    
            // by default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               
    
            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecordCount as well
            // selCols.Add(VPropertyTermExpiresView.Column1, true);          
            // selCols.Add(VPropertyTermExpiresView.Column2, true);          
            // selCols.Add(VPropertyTermExpiresView.Column3, true);          
            

            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                  
            {
              
                return VPropertyTermExpiresView.GetRecords(join, where, orderBy, this.PageIndex, this.PageSize);
                 
            }
            else
            {
                VPropertyTermExpiresView databaseTable = new VPropertyTermExpiresView();
                databaseTable.SelectedColumns.Clear();
                databaseTable.SelectedColumns.AddRange(selCols);
                
            
                
                ArrayList recList; 
                orderBy.ExpandForeignKeyColums = false;
                recList = databaseTable.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
                return (recList.ToArray(typeof(VPropertyTermExpiresRecord)) as VPropertyTermExpiresRecord[]);
            }            
            
        }
        
        
        public virtual int GetRecordCount(BaseFilter join, WhereClause where)
        {

            // By default, Select * will be executed to get a list of records.  If you want to run Select Distinct with certain column only, add the column to selCols
            ColumnList selCols = new ColumnList();                 
               


            // If you want to specify certain columns to be in the select statement, you can write code similar to the following:
            // However, if you don't specify PK, row button click might show an error message.
            // And make sure you write similar code in GetRecords as well
            // selCols.Add(VPropertyTermExpiresView.Column1, true);          
            // selCols.Add(VPropertyTermExpiresView.Column2, true);          
            // selCols.Add(VPropertyTermExpiresView.Column3, true);          


            // If the parameters doesn't specify specific columns in the Select statement, then run Select *
            // Alternatively, if the parameters specifies to include PK, also run Select *
            
            if (selCols.Count == 0)                 
                     
            
                return VPropertyTermExpiresView.GetRecordCount(join, where);
            else
            {
                VPropertyTermExpiresView databaseTable = new VPropertyTermExpiresView();
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
          
                  LoadData_VPropertyTermExpiresCountQuery();
       
            // Improve performance by prefetching display as records.
            this.PreFetchForeignKeyValues();     

            // Setup the pagination controls.
            BindPaginationControls();

    
        
        // Bind the repeater with the list of records to expand the UI.
        
        System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyTermExpiresTableControlRepeater"));
        if (rep == null){return;}
        rep.DataSource = this.DataSource;
        rep.DataBind();
        
        int index = 0;
        
        foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
        {
        
            // Loop through all rows in the table, set its DataSource and call DataBind().
            VPropertyTermExpiresTableControlRow recControl = (VPropertyTermExpiresTableControlRow)(repItem.FindControl("VPropertyTermExpiresTableControlRow"));
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
                SetCityIDFilter();
                SetCityIDLabel1();
                SetCityIDSortLabel();
                SetCompanyNameSortLabel();
                SetDescriptionSortLabel();
                SetExpiryDateSortLabel();
                SetPostCodeSortLabel();
                SetPropertyIDFilter();
                SetPropertyIDLabel1();
                SetPropertyIDSortLabel();
                SetTermExpireIDSortLabel();
                
                
                
                
                
                
                
                
                
                SetVPropertyTermExpiresSearch();
                
                
                
                
                SetVPropertyTermExpiresExportExcelButton();
              
                SetVPropertyTermExpiresPDFButton();
              
                SetVPropertyTermExpiresResetButton();
              
                SetVPropertyTermExpiresSearchButton();
              
                SetVPropertyTermExpiresWordButton();
              
                SetVPropertyTermExpiresButtonsButton();
              
                SetVPropertyTermExpiresFilterButton();
              
                SetVPropertyTermExpiresFiltersButton();
              
                  // Update session indicate which row is selected
                  bool shouldResetControl = true;
                  
                  if (rep.Items.Count > 0){
                  VPropertyTermExpiresTableControlRow recControl = (VPropertyTermExpiresTableControlRow)(rep.Items[0].FindControl("VPropertyTermExpiresTableControlRow"));
                  
                  string keyValueInSession = this.GetFromSession(this, "selectedRowID", null);
                  if (keyValueInSession != null){
                  
                  foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                  {
                  
                  KeyValue keyValue = new KeyValue();
                  VPropertyTermExpiresTableControlRow row = (VPropertyTermExpiresTableControlRow)(repItem.FindControl("VPropertyTermExpiresTableControlRow"));
                  
                  if (keyValueInSession == keyValue.ToXmlString() && KeyValue.XmlToKey(keyValueInSession) != null)
                  shouldResetControl = false;
                  }
                  }

                  if (shouldResetControl){
                  // Reset Session for ChildPanel's CreateWhereClause
                  KeyValue keyValue = new KeyValue();
                  

                  this.SaveToSession(this, "selectedRowID", keyValue.ToXmlString());
                  keyValueInSession = keyValue.ToXmlString();
                  }

                  // Update image for update panels button
                  
                  foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                  {
                  
                  KeyValue keyValue = new KeyValue();
                  VPropertyTermExpiresTableControlRow row = (VPropertyTermExpiresTableControlRow)(repItem.FindControl("VPropertyTermExpiresTableControlRow"));
                     
                  // if keyvalue of this row is same as session or if both keyval of this row and the keyval in session are both null,
                  // then mark this row
                  
                  if (keyValueInSession == keyValue.ToXmlString() || (keyValue.Count == 0  && keyValueInSession == null)){
                  
                  break;
                  
                  }
                  }
                  
                  }
                
           else
           {
              RemoveFromSession(this, "selectedRowID");
           }
            
            // setting the state of expand or collapse alternative rows
      
            // Load data for each record and table UI control.
            // Ordering is important because child controls get 
            // their parent ids from their parent UI controls.
                
        SetVPropertyTermExpiresCountChart();
        
      
            // this method calls the set method for controls with special formula like running total, sum, rank, etc
            SetFormulaControls();
            
             
              SetVPropertyTermExpiresFiltersButton();
                     
        }
        
        
        public virtual void SetFormulaControls()
        {
            // this method calls Set methods for the control that has special formula
        

    }

        
    public virtual void AddWarningMessageOnClick() {
    
        if (this.TotalRecords > 10000)
          this.VPropertyTermExpiresExportExcelButton.Attributes.Add("onClick", "return (confirm('" + ((BaseApplicationPage)this.Page).GetResourceValue("ExportConfirm", "IPv5") + "'));");
        else
          this.VPropertyTermExpiresExportExcelButton.Attributes.Remove("onClick");
      
    }
  
        public void PreFetchForeignKeyValues() {
            if (this.DataSource == null) {
                return;
            }
          
            this.Page.PregetDfkaRecords(VPropertyTermExpiresView.CityID, this.DataSource);
            this.Page.PregetDfkaRecords(VPropertyTermExpiresView.CountryID, this.DataSource);
            this.Page.PregetDfkaRecords(VPropertyTermExpiresView.PropertyID, this.DataSource);
            this.Page.PregetDfkaRecords(VPropertyTermExpiresView.RegionID, this.DataSource);
        }
        

        public virtual void RegisterPostback()
        {
        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"VPropertyTermExpiresExportExcelButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"VPropertyTermExpiresPDFButton"));
                        
              this.Page.RegisterPostBackTrigger(MiscUtils.FindControlRecursively(this,"VPropertyTermExpiresWordButton"));
                                
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
                
                // add datasource as variables for formula evaluation
                    
                if (VPropertyTermExpiresCountQuery != null) e.Variables.Add("VPropertyTermExpiresCountQuery", VPropertyTermExpiresCountQuery);                                                       
                    
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
            
            this.VPropertyTermExpiresSearch.Text = "";
            
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
                this.VPropertyTermExpiresPagination.CurrentPage.Text = (this.PageIndex + 1).ToString();
            } 
            else
            {
                this.VPropertyTermExpiresPagination.CurrentPage.Text = "0";
            }
            this.VPropertyTermExpiresPagination.PageSize.Text = this.PageSize.ToString();
    
            // Bind the buttons for VPropertyTermExpiresTableControl pagination.
        
            this.VPropertyTermExpiresPagination.FirstPage.Enabled = !(this.PageIndex == 0);
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.VPropertyTermExpiresPagination.LastPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.VPropertyTermExpiresPagination.LastPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.VPropertyTermExpiresPagination.LastPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            if (this._TotalPages < 0)             // if the total pages is not determined yet, enable last and next buttons
                this.VPropertyTermExpiresPagination.NextPage.Enabled = true;
            else if (this._TotalPages == 0)          // if the total pages is determined and it is 0, enable last and next buttons
                this.VPropertyTermExpiresPagination.NextPage.Enabled = false;            
            else                                     // if the total pages is the last page, disable last and next buttons
                this.VPropertyTermExpiresPagination.NextPage.Enabled = !(this.PageIndex == this.TotalPages - 1);            
          
            this.VPropertyTermExpiresPagination.PreviousPage.Enabled = !(this.PageIndex == 0);    
        }
 
        public virtual void SaveData()
        {
            // Save the data from the entire table.  Calls each row's Save Data
            // to save their data.  This function is called by the Click handler of the
            // Save button.  The button handler should Start/Commit/End a transaction.
              
            foreach (VPropertyTermExpiresTableControlRow recCtl in this.GetRecordControls())
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
            foreach (VPropertyTermExpiresTableControlRow recCtl in this.GetRecordControls()){
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
            VPropertyTermExpiresView.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
    
            // CreateWhereClause() Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
        
            if (MiscUtils.IsValueSelected(this.CityIDFilter)) {
                        
                wc.iAND(VPropertyTermExpiresView.CityID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.CityIDFilter, this.GetFromSession(this.CityIDFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.PropertyIDFilter)) {
                        
                wc.iAND(VPropertyTermExpiresView.PropertyID, BaseFilter.ComparisonOperator.EqualsTo, MiscUtils.GetSelectedValue(this.PropertyIDFilter, this.GetFromSession(this.PropertyIDFilter)), false, false);
                    
            }
                      
            if (MiscUtils.IsValueSelected(this.VPropertyTermExpiresSearch)) {
                if (this.VPropertyTermExpiresSearch.Text == BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) ) {
                        this.VPropertyTermExpiresSearch.Text = "";
                } else {
                  // Strip "..." from begin and ending of the search text, otherwise the search will return 0 values as in database "..." is not stored.
                  if (this.VPropertyTermExpiresSearch.Text.StartsWith("...")) {
                      this.VPropertyTermExpiresSearch.Text = this.VPropertyTermExpiresSearch.Text.Substring(3,this.VPropertyTermExpiresSearch.Text.Length-3);
                  }
                  if (this.VPropertyTermExpiresSearch.Text.EndsWith("...")) {
                      this.VPropertyTermExpiresSearch.Text = this.VPropertyTermExpiresSearch.Text.Substring(0,this.VPropertyTermExpiresSearch.Text.Length-3);
                      // Strip the last word as well as it is likely only a partial word
                      int endindex = this.VPropertyTermExpiresSearch.Text.Length - 1;
                      while (!Char.IsWhiteSpace(VPropertyTermExpiresSearch.Text[endindex]) && endindex > 0) {
                          endindex--;
                      }
                      if (endindex > 0) {
                          this.VPropertyTermExpiresSearch.Text = this.VPropertyTermExpiresSearch.Text.Substring(0, endindex);
                      }
                  }
                }
                string formatedSearchText = MiscUtils.GetSelectedValue(this.VPropertyTermExpiresSearch, this.GetFromSession(this.VPropertyTermExpiresSearch));
                // After stripping "..." see if the search text is null or empty.
                if (MiscUtils.IsValueSelected(this.VPropertyTermExpiresSearch)) {
                      
                    // These clauses are added depending on operator and fields selected in Control's property page, bindings tab.
                  
                    WhereClause search = new WhereClause();
                    
        ColumnList cols = new ColumnList();
      
      cols.Add(VPropertyTermExpiresView.CompanyName, true);
      
      cols.Add(VPropertyTermExpiresView.Address1, true);
      
      foreach(BaseColumn col in cols)
      {
      
          search.iOR(col, BaseFilter.ComparisonOperator.Contains, MiscUtils.GetSelectedValue(this.VPropertyTermExpiresSearch, this.GetFromSession(this.VPropertyTermExpiresSearch)), true, false);
        
      }
    
                    wc.iAND(search);
                  
                }
            }
                       
            return wc;
        }
        
         
        public virtual WhereClause CreateWhereClause(String searchText, String fromSearchControl, String AutoTypeAheadSearch, String AutoTypeAheadWordSeparators)
        {
            // This CreateWhereClause is used for loading list of suggestions for Auto Type-Ahead feature.
            VPropertyTermExpiresView.Instance.InnerFilter = null;
            WhereClause wc = new WhereClause();
        
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design time.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.
            
            String appRelativeVirtualPath = (String)HttpContext.Current.Session["AppRelativeVirtualPath"];
            
            // Adds clauses if values are selected in Filter controls which are configured in the page.
          
      String CityIDFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "CityIDFilter_Ajax"];
            if (MiscUtils.IsValueSelected(CityIDFilterSelectedValue)) {

              
                wc.iAND(VPropertyTermExpiresView.CityID, BaseFilter.ComparisonOperator.EqualsTo, CityIDFilterSelectedValue, false, false);
                      
      }
                      
      String PropertyIDFilterSelectedValue = (String)HttpContext.Current.Session[HttpContext.Current.Session.SessionID + appRelativeVirtualPath + "PropertyIDFilter_Ajax"];
            if (MiscUtils.IsValueSelected(PropertyIDFilterSelectedValue)) {

              
                wc.iAND(VPropertyTermExpiresView.PropertyID, BaseFilter.ComparisonOperator.EqualsTo, PropertyIDFilterSelectedValue, false, false);
                      
      }
                      
            if (MiscUtils.IsValueSelected(searchText) && fromSearchControl == "VPropertyTermExpiresSearch") {
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
      
      cols.Add(VPropertyTermExpiresView.CompanyName, true);
      
      cols.Add(VPropertyTermExpiresView.Address1, true);
      
      foreach(BaseColumn col in cols)
      {
      
                  search.iOR(col, BaseFilter.ComparisonOperator.Starts_With, formatedSearchText, true, false);
                  search.iOR(col, BaseFilter.ComparisonOperator.Contains, AutoTypeAheadWordSeparators + formatedSearchText, true, false);
                
      }
    
                    } else {
                        
        ColumnList cols = new ColumnList();
      
      cols.Add(VPropertyTermExpiresView.CompanyName, true);
      
      cols.Add(VPropertyTermExpiresView.Address1, true);
      
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

        
        public virtual string[] GetAutoCompletionList_VPropertyTermExpiresSearch(String prefixText,int count)
        {
            ArrayList resultList = new ArrayList();
            ArrayList wordList= new ArrayList();
            
            CompoundFilter filterJoin = CreateCompoundJoinFilter();    
            WhereClause wc = CreateWhereClause(prefixText,"VPropertyTermExpiresSearch", "WordsStartingWithSearchString", "[^a-zA-Z0-9]");
            if(count==0) count = 10;
            IPv5.Business.VPropertyTermExpiresRecord[] recordList  = VPropertyTermExpiresView.GetRecords(filterJoin, wc, null, 0, count, ref count);
            String resultItem = "";
            if (resultItem == "") resultItem = "";
            foreach (VPropertyTermExpiresRecord rec in recordList ){
                // Exit the loop if recordList count has reached AutoTypeAheadListSize.
                if (resultList.Count >= count) {
                    break;
                }
                // If the field is configured to Display as Foreign key, Format() method returns the 
                // Display as Forien Key value instead of original field value.
                // Since search had to be done in multiple fields (selected in Control's page property, binding tab) in a record,
                // We need to find relevent field to display which matches the prefixText and is not already present in the result list.
        
                resultItem = rec.Format(VPropertyTermExpiresView.CompanyName);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(VPropertyTermExpiresView.CompanyName.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, VPropertyTermExpiresView.CompanyName.IsFullTextSearchable);
                        if (isAdded) {
                            continue;
                        }
                    }
                }
      
                resultItem = rec.Format(VPropertyTermExpiresView.Address1);
  
                if (resultItem != null) {
                    string prText = prefixText;
                    if(VPropertyTermExpiresView.Address1.IsFullTextSearchable) {
                        FullTextExpression ft = new FullTextExpression();
                        prText = ft.GetFirstNonExcludedTerm(prText);
                    }
                    if (!string.IsNullOrEmpty(prText) && resultItem.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture).Contains(prText.ToUpper(System.Threading.Thread.CurrentThread.CurrentCulture))) {
                        bool isAdded = FormatSuggestions(prText, resultItem, 50, "AtBeginningOfMatchedString", "WordsStartingWithSearchString", "[^a-zA-Z0-9]", resultList, VPropertyTermExpiresView.Address1.IsFullTextSearchable);
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
        
            if (this.VPropertyTermExpiresPagination.PageSize.Text.Length > 0) {
                try {
                    // this.PageSize = Convert.ToInt32(this.VPropertyTermExpiresPagination.PageSize.Text);
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
              System.Web.UI.WebControls.Repeater rep = (System.Web.UI.WebControls.Repeater)(BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyTermExpiresTableControlRepeater"));
              if (rep == null){return;}
              
                foreach (System.Web.UI.WebControls.RepeaterItem repItem in rep.Items)
                {
                
                // Loop through all rows in the table, set its DataSource and call DataBind().
                VPropertyTermExpiresTableControlRow recControl = (VPropertyTermExpiresTableControlRow)(repItem.FindControl("VPropertyTermExpiresTableControlRow"));
      
            if (recControl.Visible && recControl.IsNewRecord) {
      VPropertyTermExpiresRecord rec = new VPropertyTermExpiresRecord();
        
                        if (recControl.Address1.Text != "") {
                            rec.Parse(recControl.Address1.Text, VPropertyTermExpiresView.Address1);
                  }
                
                        if (recControl.Address2.Text != "") {
                            rec.Parse(recControl.Address2.Text, VPropertyTermExpiresView.Address2);
                  }
                
                        if (recControl.Address3.Text != "") {
                            rec.Parse(recControl.Address3.Text, VPropertyTermExpiresView.Address3);
                  }
                
                        if (recControl.CityID.Text != "") {
                            rec.Parse(recControl.CityID.Text, VPropertyTermExpiresView.CityID);
                  }
                
                        if (recControl.CompanyName.Text != "") {
                            rec.Parse(recControl.CompanyName.Text, VPropertyTermExpiresView.CompanyName);
                  }
                
                        if (recControl.CountryID.Text != "") {
                            rec.Parse(recControl.CountryID.Text, VPropertyTermExpiresView.CountryID);
                  }
                
                        if (recControl.Description.Text != "") {
                            rec.Parse(recControl.Description.Text, VPropertyTermExpiresView.Description);
                  }
                
                        if (recControl.ExpiryDate.Text != "") {
                            rec.Parse(recControl.ExpiryDate.Text, VPropertyTermExpiresView.ExpiryDate);
                  }
                
                        if (recControl.PostCode.Text != "") {
                            rec.Parse(recControl.PostCode.Text, VPropertyTermExpiresView.PostCode);
                  }
                
                        if (recControl.PropertyID.Text != "") {
                            rec.Parse(recControl.PropertyID.Text, VPropertyTermExpiresView.PropertyID);
                  }
                
                        if (recControl.RegionID.Text != "") {
                            rec.Parse(recControl.RegionID.Text, VPropertyTermExpiresView.RegionID);
                  }
                
                        if (recControl.TermExpireID.Text != "") {
                            rec.Parse(recControl.TermExpireID.Text, VPropertyTermExpiresView.TermExpireID);
                  }
                
              newUIDataList.Add(recControl.PreservedUIData());
              newRecordList.Add(rec);
            }
          }
        }
    
            // Add any new record to the list.
            for (int count = 1; count <= this.AddNewRecord; count++) {
              
                newRecordList.Insert(0, new VPropertyTermExpiresRecord());
                newUIDataList.Insert(0, new Hashtable());
              
            }
            this.AddNewRecord = 0;

            // Finally, add any new records to the DataSource.
            if (newRecordList.Count > 0) {
              
                ArrayList finalList = new ArrayList(this.DataSource);
                finalList.InsertRange(0, newRecordList);

                Type myrec = typeof(IPv5.Business.VPropertyTermExpiresRecord);
                this.DataSource = (VPropertyTermExpiresRecord[])(finalList.ToArray(myrec));
              
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
                
        public virtual void SetCityIDLabel1()
                  {
                  
                    
        }
                
        public virtual void SetCityIDSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetCompanyNameSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetDescriptionSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetExpiryDateSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetPostCodeSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetPropertyIDLabel1()
                  {
                  
                    
        }
                
        public virtual void SetPropertyIDSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetTermExpireIDSortLabel()
                  {
                  
                    
        }
                
        public virtual void SetVPropertyTermExpiresCountChart()           
                
        {
                
            if (!VPropertyTermExpiresCountQuery.DataChanged) return;
          
            System.Web.UI.DataVisualization.Charting.Chart chartControl = VPropertyTermExpiresCountChart;
            
            // clear ChartAreas, Legends, Series, and Titles.  Otherwise, exception happens during postback
            chartControl.ChartAreas.Clear();
            chartControl.Legends.Clear();
            chartControl.Series.Clear();
            chartControl.Titles.Clear();
            
            // collect data to be displayed on the chart
            
            string[] indexArray = VPropertyTermExpiresCountQuery.GetComposedStringColumn("ExpiryDate", EvaluateFormulaDelegate, EvaluateFormula("Resource(\"Txt:RemainderLabel\")"));
            
            decimal[] valueArray = VPropertyTermExpiresCountQuery.GetComposedDecimalColumn("VPropertyTermExpiresCount", EvaluateFormulaDelegate,true);
              
            // define redirect URL
            string[] legendURL = VPropertyTermExpiresCountQuery.GetComposedStringColumn("\"../vPropertyTermExpires/ShowVPropertyTermExpiresTable.aspx?ExpiryDate=\" + ExpiryDate.ToShortDateString() + \"&ExpiryDateFrom=\" + ExpiryDate.ToShortDateString() + \"&ExpiryDateTo=\" + ExpiryDate.ToShortDateString()", EvaluateFormulaDelegate, "");
            string[] dataPointURL = VPropertyTermExpiresCountQuery.GetComposedStringColumn("\"../vPropertyTermExpires/ShowVPropertyTermExpiresTable.aspx?ExpiryDate=\" + ExpiryDate.ToShortDateString() + \"&ExpiryDateFrom=\" + ExpiryDate.ToShortDateString() + \"&ExpiryDateTo=\" + ExpiryDate.ToShortDateString()", EvaluateFormulaDelegate, "");
          
          
            
            // Reverse the index and value in order to show smallest first              
                
            // -1 because we want to leave the remainder label at last                  
            if (indexArray != null) Array.Reverse(indexArray, 0, indexArray.Length - 1);
            if (valueArray != null) Array.Reverse(valueArray, 0, valueArray.Length - 1);
            if (legendURL != null) Array.Reverse(legendURL, 0, legendURL.Length - 1);
            if (dataPointURL != null) Array.Reverse(dataPointURL, 0, dataPointURL.Length - 1);
                
            // define the chart properties based on the setting you have set on the Properties Windows and the Application Generation Option Dialog.          
            int barThickness = 33;
            string chartType = "Pie";
            bool usePalette = true;
            System.Web.UI.DataVisualization.Charting.ChartColorPalette palette = (System.Web.UI.DataVisualization.Charting.ChartColorPalette)(System.Web.UI.DataVisualization.Charting.ChartColorPalette.Parse(typeof(System.Web.UI.DataVisualization.Charting.ChartColorPalette), "Pastel"));
            System.Drawing.Color color = System.Drawing.ColorTranslator.FromHtml("Blue");
            System.Drawing.Color backGroundColor = System.Drawing.ColorTranslator.FromHtml("White");
            System.Drawing.Color gridColor = System.Drawing.ColorTranslator.FromHtml("LightGray");
            string fontFamily = "Arial";
            System.Drawing.Color fontColor = System.Drawing.ColorTranslator.FromHtml("Black");
            System.Drawing.Color internalLabelColor = System.Drawing.ColorTranslator.FromHtml("Black");
            string showInsideBar = "Value at bar end";
            string title = "";
            string indexAxisTitle = "";
            string valueAxisTitle = EvaluateFormula("\"Expiration Date\"");
            int labelAngle = -50;
            
            bool generatePercentage = false;
                        
            string labelFormat = "0";
            string chartTitleFontSize = "";
            string axisTitleFontSize = "";
            string scaleFontSize = "";
            string labelInsideFontSize = "";
            string customProperties = "";
            
            System.Collections.Generic.List<object> args = new System.Collections.Generic.List<object>();
            args.Add(chartControl);
            args.Add(indexArray);
            args.Add(valueArray);
            args.Add(legendURL);
            args.Add(dataPointURL);
            args.Add(barThickness);
            args.Add(chartType);
            args.Add(usePalette);
            args.Add(palette);
            args.Add(color);
            args.Add(backGroundColor);
            args.Add(gridColor);
            args.Add(fontFamily);
            args.Add(fontColor);
            args.Add(internalLabelColor);
            args.Add(showInsideBar);
            args.Add(title);
            args.Add(indexAxisTitle);
            args.Add(valueAxisTitle);
            args.Add(labelAngle);
            args.Add(generatePercentage);
            args.Add(labelFormat);
            args.Add(chartTitleFontSize);
            args.Add(axisTitleFontSize);
            args.Add(scaleFontSize);
            args.Add(labelInsideFontSize);
            args.Add(customProperties);
            
            this.Page.InitializeChartControl(args.ToArray());
            
        }      
      
        public virtual WhereClause CreateWhereClause_VPropertyTermExpiresCountQuery()
        
        {
            WhereClause wc = new WhereClause();
            // Compose the WHERE clause consist of:
            // 1. Static clause defined at design tithis.
            // 2. User selected search criteria.
            // 3. User selected filter criteria.

          
            // Get the static clause defined at design time on the Query Wizard
            WhereClause qc = this.CreateQueryClause_VPropertyTermExpiresCountQuery();
            if (qc != null) {
                wc.iAND(qc);
            }
                      
            return wc;
        }
      
        public virtual WhereClause CreateQueryClause_VPropertyTermExpiresCountQuery()
        
        {
          
            // Create a where clause for the Static clause defined at design time.
            CompoundFilter filter = new CompoundFilter(CompoundFilter.CompoundingOperators.And_Operator, null);
            WhereClause whereClause = new WhereClause();
            
            if (EvaluateFormula("EndOfCurrentQuarter()", false) != "")filter.AddFilter(new BaseClasses.Data.ColumnValueFilter(BaseClasses.Data.BaseTable.CreateInstance(@"IPv5.Business.VPropertyTermExpiresView, IPv5.Business").TableDefinition.ColumnList.GetByUniqueName(@"VPropertyTermExpires_.ExpiryDate"), EvaluateFormula("EndOfCurrentQuarter()", false), BaseClasses.Data.BaseFilter.ComparisonOperator.Less_Than_Or_Equal, false));
         if (EvaluateFormula("EndOfCurrentQuarter()", false) == "--PLEASE_SELECT--" || EvaluateFormula("EndOfCurrentQuarter()", false) == "--ANY--") whereClause.RunQuery = false;

            whereClause.AddFilter(filter, CompoundFilter.CompoundingOperators.And_Operator);
    
            return whereClause;
        }
          
        public virtual void LoadData_VPropertyTermExpiresCountQuery()
        
        {
          
              if (!(this.ResetData || this.DataChanged || _VPropertyTermExpiresCountQuery.DataChanged) && this.Page.IsPostBack  && this.Page.Request["__EVENTTARGET"] != "isd_geo_location") return;
        
              _VPropertyTermExpiresCountQuery.DataChanged = true;
          
              this._VPropertyTermExpiresCountQuery.Initialize("VPropertyTermExpiresCountQuery", VPropertyTermExpiresView.Instance, 5, 0);
            
               
              // Add the primary key of the record
              WhereClause wc = CreateWhereClause_VPropertyTermExpiresCountQuery();
              this._VPropertyTermExpiresCountQuery.WhereClause.iAND(wc);                      
          
              // Define selects
          
              this._VPropertyTermExpiresCountQuery.AddSelectItem(new SelectItem(VPropertyTermExpiresView.ExpiryDate, VPropertyTermExpiresView.Instance, false, "", ""));
              
                    this._VPropertyTermExpiresCountQuery.AddSelectItem(new SelectItem(SelectItem.Operation.COUNT, new SelectItem(SelectItem.ItemType.AllColumns, VPropertyTermExpiresView.Instance, "VPropertyTermExpiresCount", ""), "VPropertyTermExpiresCount"));
              
              // Define joins if there are any
          
              this._VPropertyTermExpiresCountQuery.AddAggregateOrderBy("VPropertyTermExpiresCount", OrderByItem.OrderDir.Desc);
              
              this._VPropertyTermExpiresCountQuery.LoadData(false, this._VPropertyTermExpiresCountQuery.PageSize, this._VPropertyTermExpiresCountQuery.PageIndex);                       
                        
        }
      
        private DataSource _VPropertyTermExpiresCountQuery = new DataSource();
        public DataSource VPropertyTermExpiresCountQuery
        {
            get
            {
                return _VPropertyTermExpiresCountQuery;
             }
        }
      
        public virtual void SetCityIDFilter()
        {
            
            this.PopulateCityIDFilter(MiscUtils.GetSelectedValue(this.CityIDFilter,  GetFromSession(this.CityIDFilter)), 500);					
                                     
        }
            
        public virtual void SetPropertyIDFilter()
        {
            
            this.PopulatePropertyIDFilter(MiscUtils.GetSelectedValue(this.PropertyIDFilter,  GetFromSession(this.PropertyIDFilter)), 500);					
                                     
        }
            
        public virtual void SetVPropertyTermExpiresSearch()
        {
                                            
            this.VPropertyTermExpiresSearch.Attributes.Add("onfocus", "if(this.value=='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "') {this.value='';this.className='Search_Input';}");
            this.VPropertyTermExpiresSearch.Attributes.Add("onblur", "if(this.value=='') {this.value='" + BaseClasses.Resources.AppResources.GetResourceValue("Txt:SearchForEllipsis", null) + "';this.className='Search_InputHint';}");
                                   
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
                                    
                                Boolean _isExpandableNonCompositeForeignKey = VPropertyTermExpiresView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyTermExpiresView.CityID);
                                if(_isExpandableNonCompositeForeignKey && VPropertyTermExpiresView.CityID.IsApplyDisplayAs)
                                     fvalue = VPropertyTermExpiresView.GetDFKA(itemValue, VPropertyTermExpiresView.CityID);
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
                                    
                                Boolean _isExpandableNonCompositeForeignKey = VPropertyTermExpiresView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyTermExpiresView.PropertyID);
                                if(_isExpandableNonCompositeForeignKey && VPropertyTermExpiresView.PropertyID.IsApplyDisplayAs)
                                     fvalue = VPropertyTermExpiresView.GetDFKA(itemValue, VPropertyTermExpiresView.PropertyID);
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
                  
            this.SaveToSession(this.VPropertyTermExpiresSearch, this.VPropertyTermExpiresSearch.Text);
                  
            
                    
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
          
      this.SaveToSession("CityIDFilter_Ajax", this.CityIDFilter.SelectedValue);
              
      this.SaveToSession("PropertyIDFilter_Ajax", this.PropertyIDFilter.SelectedValue);
              
      this.SaveToSession("VPropertyTermExpiresSearch_Ajax", this.VPropertyTermExpiresSearch.Text);
              
           HttpContext.Current.Session["AppRelativeVirtualPath"] = this.Page.AppRelativeVirtualPath;
         
        }
        
        
        protected override void ClearControlsFromSession()
        {
            base.ClearControlsFromSession();
            // Clear filter controls values from the session.
        
            this.RemoveFromSession(this.CityIDFilter);
            this.RemoveFromSession(this.PropertyIDFilter);
            this.RemoveFromSession(this.VPropertyTermExpiresSearch);
            
            // Clear pagination state from session.
         

    // Clear table properties from the session.
    this.RemoveFromSession(this, "Order_By");
    this.RemoveFromSession(this, "Page_Index");
    this.RemoveFromSession(this, "Page_Size");
    
        }

        protected override void LoadViewState(object savedState)
        {
            base.LoadViewState(savedState);

            string orderByStr = (string)ViewState["VPropertyTermExpiresTableControl_OrderBy"];
          
            if (orderByStr != null && orderByStr.Length > 0) {
                this.CurrentSortOrder = BaseClasses.Data.OrderBy.FromXmlString(orderByStr);
            }
          
            else {
                this.CurrentSortOrder = new OrderBy(true, false);
            }
          

            Control Pagination = this.FindControl("VPropertyTermExpiresPagination");
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
                this.ViewState["VPropertyTermExpiresTableControl_OrderBy"] = this.CurrentSortOrder.ToXmlString();
            }
          

    this.ViewState["Page_Index"] = this.PageIndex;
    this.ViewState["Page_Size"] = this.PageSize;
    
    
            // Load view state for pagination control.
              
            return (base.SaveViewState());
        }

        // Generate set method for buttons
        
        public virtual void SetVPropertyTermExpiresExportExcelButton()                
              
        {
        
   
        }
            
        public virtual void SetVPropertyTermExpiresPDFButton()                
              
        {
        
   
        }
            
        public virtual void SetVPropertyTermExpiresResetButton()                
              
        {
        
   
        }
            
        public virtual void SetVPropertyTermExpiresSearchButton()                
              
        {
        
   
        }
            
        public virtual void SetVPropertyTermExpiresWordButton()                
              
        {
        
   
        }
            
        public virtual void SetVPropertyTermExpiresButtonsButton()                
              
        {
        
   
        }
            
        public virtual void SetVPropertyTermExpiresFilterButton()                
              
        {
        
   
        }
            
        public virtual void SetVPropertyTermExpiresFiltersButton()                
              
        {
                
         IThemeButtonWithArrow themeButtonVPropertyTermExpiresFiltersButton = (IThemeButtonWithArrow)(MiscUtils.FindControlRecursively(this, "VPropertyTermExpiresFiltersButton"));
         themeButtonVPropertyTermExpiresFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonExpandArrow.png";
    
      
            if (MiscUtils.IsValueSelected(CityIDFilter))
                themeButtonVPropertyTermExpiresFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
            if (MiscUtils.IsValueSelected(PropertyIDFilter))
                themeButtonVPropertyTermExpiresFiltersButton.ArrowImage.ImageUrl = "../Images/ButtonCheckmark.png";
        
   
        }
               
        
        // Generate the event handling functions for pagination events.
        
        // event handler for ImageButton
        public virtual void VPropertyTermExpiresPagination_FirstPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void VPropertyTermExpiresPagination_LastPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void VPropertyTermExpiresPagination_NextPage_Click(object sender, ImageClickEventArgs args)
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
        public virtual void VPropertyTermExpiresPagination_PageSizeButton_Click(object sender, EventArgs args)
        {
              
            try {
                
            this.DataChanged = true;
      
            this.PageSize = this.VPropertyTermExpiresPagination.GetCurrentPageSize();
      
            this.PageIndex = Convert.ToInt32(this.VPropertyTermExpiresPagination.CurrentPage.Text) - 1;
      
            } catch (Exception ex) {
                  this.Page.ErrorOnPage = true;

            // Report the error message to the end user
            BaseClasses.Utils.MiscUtils.RegisterJScriptAlert(this, "BUTTON_CLICK_MESSAGE", ex.Message);
    
            } finally {
    
            }
    
        }
            
            
        
        // event handler for ImageButton
        public virtual void VPropertyTermExpiresPagination_PreviousPage_Click(object sender, ImageClickEventArgs args)
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
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyTermExpiresView.Address1);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Address1.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyTermExpiresView.Address1, OrderByItem.OrderDir.Asc);
            
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
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyTermExpiresView.Address2);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Address2.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyTermExpiresView.Address2, OrderByItem.OrderDir.Asc);
            
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
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyTermExpiresView.Address3);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Address3.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyTermExpiresView.Address3, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by Address3, so just reverse.
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
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyTermExpiresView.CityID);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for CityID.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyTermExpiresView.CityID, OrderByItem.OrderDir.Asc);
            
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
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyTermExpiresView.CompanyName);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for CompanyName.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyTermExpiresView.CompanyName, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by CompanyName, so just reverse.
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
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyTermExpiresView.Description);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for Description.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyTermExpiresView.Description, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by Description, so just reverse.
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
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyTermExpiresView.ExpiryDate);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for ExpiryDate.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyTermExpiresView.ExpiryDate, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by ExpiryDate, so just reverse.
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
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyTermExpiresView.PostCode);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for PostCode.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyTermExpiresView.PostCode, OrderByItem.OrderDir.Asc);
            
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
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyTermExpiresView.PropertyID);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for PropertyID.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyTermExpiresView.PropertyID, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by PropertyID, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            
        public virtual void TermExpireIDSortLabel_Click(object sender, EventArgs args)
        {
            //Sorts by TermExpireID when clicked.
              
            // Get previous sorting state for TermExpireID.
        
            OrderByItem sd = this.CurrentSortOrder.Find(VPropertyTermExpiresView.TermExpireID);
            if (sd == null || (this.CurrentSortOrder.Items != null && this.CurrentSortOrder.Items.Length > 1)) {
                // First time sort, so add sort order for TermExpireID.
                this.CurrentSortOrder.Reset();

    
              //If default sort order was GeoProximity, create new CurrentSortOrder of OrderBy type
              if ((this.CurrentSortOrder).GetType() == typeof(GeoOrderBy)) this.CurrentSortOrder = new OrderBy(true, false);

              this.CurrentSortOrder.Add(VPropertyTermExpiresView.TermExpireID, OrderByItem.OrderDir.Asc);
            
            } else {
                // Previously sorted by TermExpireID, so just reverse.
                sd.Reverse();
            }
        

            // Setting the DataChanged to true results in the page being refreshed with
            // the most recent data from the database.  This happens in PreRender event
            // based on the current sort, search and filter criteria.
            this.DataChanged = true;
              
        }
            

        // Generate the event handling functions for button events.
        
        // event handler for ImageButton
        public virtual void VPropertyTermExpiresExportExcelButton_Click(object sender, ImageClickEventArgs args)
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


              this.TotalRecords = VPropertyTermExpiresView.GetRecordCount(join, wc);
              if (this.TotalRecords > 10000)
              {
              
                // Add each of the columns in order of export.
                BaseColumn[] columns = new BaseColumn[] {
                             VPropertyTermExpiresView.PropertyID,
             VPropertyTermExpiresView.CompanyName,
             VPropertyTermExpiresView.Address1,
             VPropertyTermExpiresView.Address2,
             VPropertyTermExpiresView.Address3,
             VPropertyTermExpiresView.CityID,
             VPropertyTermExpiresView.RegionID,
             VPropertyTermExpiresView.CountryID,
             VPropertyTermExpiresView.PostCode,
             VPropertyTermExpiresView.ExpiryDate,
             VPropertyTermExpiresView.Description,
             VPropertyTermExpiresView.TermExpireID,
             null};
                ExportDataToCSV exportData = new ExportDataToCSV(VPropertyTermExpiresView.Instance,wc,orderBy,columns);
                exportData.StartExport(this.Page.Response, true);

                DataForExport dataForCSV = new DataForExport(VPropertyTermExpiresView.Instance, wc, orderBy, columns,join);

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
              ExportDataToExcel excelReport = new ExportDataToExcel(VPropertyTermExpiresView.Instance, wc, orderBy);
              // Add each of the columns in order of export.
              // To customize the data type, change the second parameter of the new ExcelColumn to be
              // a format string from Excel's Format Cell menu. For example "dddd, mmmm dd, yyyy h:mm AM/PM;@", "#,##0.00"

              if (this.Page.Response == null)
              return;

              excelReport.CreateExcelBook();

              int width = 0;
              int columnCounter = 0;
              DataForExport data = new DataForExport(VPropertyTermExpiresView.Instance, wc, orderBy, null,join);
                           data.ColumnList.Add(new ExcelColumn(VPropertyTermExpiresView.PropertyID, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyTermExpiresView.CompanyName, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyTermExpiresView.Address1, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyTermExpiresView.Address2, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyTermExpiresView.Address3, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyTermExpiresView.CityID, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyTermExpiresView.RegionID, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyTermExpiresView.CountryID, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyTermExpiresView.PostCode, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyTermExpiresView.ExpiryDate, "Short Date"));
             data.ColumnList.Add(new ExcelColumn(VPropertyTermExpiresView.Description, "Default"));
             data.ColumnList.Add(new ExcelColumn(VPropertyTermExpiresView.TermExpireID, "0"));


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
                val = VPropertyTermExpiresView.GetDFKA(rec.GetValue(col.DisplayColumn).ToString(), col.DisplayColumn, null) as string;
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
        public virtual void VPropertyTermExpiresPDFButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                PDFReport report = new PDFReport();

                report.SpecificReportFileName = Page.Server.MapPath("ShowVPropertyTermExpiresTable2.VPropertyTermExpiresPDFButton.report");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "vPropertyTermExpires";
                // If ShowVPropertyTermExpiresTable2.VPropertyTermExpiresPDFButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.   
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(VPropertyTermExpiresView.PropertyID.Name, ReportEnum.Align.Left, "${PropertyID}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyTermExpiresView.CompanyName.Name, ReportEnum.Align.Left, "${CompanyName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyTermExpiresView.Address1.Name, ReportEnum.Align.Left, "${Address1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyTermExpiresView.Address2.Name, ReportEnum.Align.Left, "${Address2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyTermExpiresView.Address3.Name, ReportEnum.Align.Left, "${Address3}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyTermExpiresView.CityID.Name, ReportEnum.Align.Left, "${CityID}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyTermExpiresView.RegionID.Name, ReportEnum.Align.Left, "${RegionID}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyTermExpiresView.CountryID.Name, ReportEnum.Align.Left, "${CountryID}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyTermExpiresView.PostCode.Name, ReportEnum.Align.Left, "${PostCode}", ReportEnum.Align.Left, 24);
                 report.AddColumn(VPropertyTermExpiresView.ExpiryDate.Name, ReportEnum.Align.Left, "${ExpiryDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(VPropertyTermExpiresView.Description.Name, ReportEnum.Align.Left, "${Description}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyTermExpiresView.TermExpireID.Name, ReportEnum.Align.Right, "${TermExpireID}", ReportEnum.Align.Right, 15);

  
                int rowsPerQuery = 5000;
                int recordCount = 0;
                                
                report.Page = Page.GetResourceValue("Txt:Page", "IPv5");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                
                ColumnList columns = VPropertyTermExpiresView.GetColumnList();
                
                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                
                int pageNum = 0;
                int totalRows = VPropertyTermExpiresView.GetRecordCount(joinFilter,whereClause);
                VPropertyTermExpiresRecord[] records = null;
                
                do
                {
                    
                    records = VPropertyTermExpiresView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                     if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( VPropertyTermExpiresRecord record in records)
                    
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
                                 _isExpandableNonCompositeForeignKey = VPropertyTermExpiresView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyTermExpiresView.PropertyID);
                                 _DFKA = VPropertyTermExpiresView.GetDFKA(record.PropertyID.ToString(), VPropertyTermExpiresView.PropertyID,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  VPropertyTermExpiresView.PropertyID.IsApplyDisplayAs){
                                     report.AddData("${PropertyID}", _DFKA,ReportEnum.Align.Left, 100);
                                 }else{
                                     report.AddData("${PropertyID}", record.Format(VPropertyTermExpiresView.PropertyID), ReportEnum.Align.Left, 100);
                                 }
                             }
                             report.AddData("${CompanyName}", record.Format(VPropertyTermExpiresView.CompanyName), ReportEnum.Align.Left, 100);
                             report.AddData("${Address1}", record.Format(VPropertyTermExpiresView.Address1), ReportEnum.Align.Left, 100);
                             report.AddData("${Address2}", record.Format(VPropertyTermExpiresView.Address2), ReportEnum.Align.Left, 100);
                             report.AddData("${Address3}", record.Format(VPropertyTermExpiresView.Address3), ReportEnum.Align.Left, 100);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.CityID)){
                                 report.AddData("${CityID}", "",ReportEnum.Align.Left, 100);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = VPropertyTermExpiresView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyTermExpiresView.CityID);
                                 _DFKA = VPropertyTermExpiresView.GetDFKA(record.CityID.ToString(), VPropertyTermExpiresView.CityID,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  VPropertyTermExpiresView.CityID.IsApplyDisplayAs){
                                     report.AddData("${CityID}", _DFKA,ReportEnum.Align.Left, 100);
                                 }else{
                                     report.AddData("${CityID}", record.Format(VPropertyTermExpiresView.CityID), ReportEnum.Align.Left, 100);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.RegionID)){
                                 report.AddData("${RegionID}", "",ReportEnum.Align.Left, 100);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = VPropertyTermExpiresView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyTermExpiresView.RegionID);
                                 _DFKA = VPropertyTermExpiresView.GetDFKA(record.RegionID.ToString(), VPropertyTermExpiresView.RegionID,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  VPropertyTermExpiresView.RegionID.IsApplyDisplayAs){
                                     report.AddData("${RegionID}", _DFKA,ReportEnum.Align.Left, 100);
                                 }else{
                                     report.AddData("${RegionID}", record.Format(VPropertyTermExpiresView.RegionID), ReportEnum.Align.Left, 100);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.CountryID)){
                                 report.AddData("${CountryID}", "",ReportEnum.Align.Left, 100);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = VPropertyTermExpiresView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyTermExpiresView.CountryID);
                                 _DFKA = VPropertyTermExpiresView.GetDFKA(record.CountryID.ToString(), VPropertyTermExpiresView.CountryID,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  VPropertyTermExpiresView.CountryID.IsApplyDisplayAs){
                                     report.AddData("${CountryID}", _DFKA,ReportEnum.Align.Left, 100);
                                 }else{
                                     report.AddData("${CountryID}", record.Format(VPropertyTermExpiresView.CountryID), ReportEnum.Align.Left, 100);
                                 }
                             }
                             report.AddData("${PostCode}", record.Format(VPropertyTermExpiresView.PostCode), ReportEnum.Align.Left, 100);
                             report.AddData("${ExpiryDate}", record.Format(VPropertyTermExpiresView.ExpiryDate), ReportEnum.Align.Left, 100);
                             report.AddData("${Description}", record.Format(VPropertyTermExpiresView.Description), ReportEnum.Align.Left, 100);
                             report.AddData("${TermExpireID}", record.Format(VPropertyTermExpiresView.TermExpireID), ReportEnum.Align.Right, 100);

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
        public virtual void VPropertyTermExpiresResetButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                
              this.CityIDFilter.ClearSelection();
            
              this.PropertyIDFilter.ClearSelection();
            
              this.VPropertyTermExpiresSearch.Text = "";
            
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
        public virtual void VPropertyTermExpiresSearchButton_Click(object sender, ImageClickEventArgs args)
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
        public virtual void VPropertyTermExpiresWordButton_Click(object sender, ImageClickEventArgs args)
        {
              
            try {
                // Enclose all database retrieval/update code within a Transaction boundary
                DbUtils.StartTransaction();
                

                WordReport report = new WordReport();

                report.SpecificReportFileName = Page.Server.MapPath("ShowVPropertyTermExpiresTable2.VPropertyTermExpiresWordButton.word");
                // report.Title replaces the value tag of page header and footer containing ${ReportTitle}
                report.Title = "vPropertyTermExpires";
                // If ShowVPropertyTermExpiresTable2.VPropertyTermExpiresWordButton.report specifies a valid report template,
                // AddColumn methods will generate a report template.
                // Each AddColumn method-call specifies a column
                // The 1st parameter represents the text of the column header
                // The 2nd parameter represents the horizontal alignment of the column header
                // The 3rd parameter represents the text format of the column detail
                // The 4th parameter represents the horizontal alignment of the column detail
                // The 5th parameter represents the relative width of the column
                 report.AddColumn(VPropertyTermExpiresView.PropertyID.Name, ReportEnum.Align.Left, "${PropertyID}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyTermExpiresView.CompanyName.Name, ReportEnum.Align.Left, "${CompanyName}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyTermExpiresView.Address1.Name, ReportEnum.Align.Left, "${Address1}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyTermExpiresView.Address2.Name, ReportEnum.Align.Left, "${Address2}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyTermExpiresView.Address3.Name, ReportEnum.Align.Left, "${Address3}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyTermExpiresView.CityID.Name, ReportEnum.Align.Left, "${CityID}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyTermExpiresView.RegionID.Name, ReportEnum.Align.Left, "${RegionID}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyTermExpiresView.CountryID.Name, ReportEnum.Align.Left, "${CountryID}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyTermExpiresView.PostCode.Name, ReportEnum.Align.Left, "${PostCode}", ReportEnum.Align.Left, 24);
                 report.AddColumn(VPropertyTermExpiresView.ExpiryDate.Name, ReportEnum.Align.Left, "${ExpiryDate}", ReportEnum.Align.Left, 20);
                 report.AddColumn(VPropertyTermExpiresView.Description.Name, ReportEnum.Align.Left, "${Description}", ReportEnum.Align.Left, 28);
                 report.AddColumn(VPropertyTermExpiresView.TermExpireID.Name, ReportEnum.Align.Right, "${TermExpireID}", ReportEnum.Align.Right, 15);

                WhereClause whereClause = null;
                whereClause = CreateWhereClause();
            
                OrderBy orderBy = CreateOrderBy();
                BaseFilter joinFilter = CreateCompoundJoinFilter();
                

                int rowsPerQuery = 5000;
                int pageNum = 0;
                int recordCount = 0;
                int totalRows = VPropertyTermExpiresView.GetRecordCount(joinFilter,whereClause);

                report.Page = Page.GetResourceValue("Txt:Page", "IPv5");
                report.ApplicationPath = this.Page.MapPath(Page.Request.ApplicationPath);

                ColumnList columns = VPropertyTermExpiresView.GetColumnList();
                VPropertyTermExpiresRecord[] records = null;
                do
                {
                    records = VPropertyTermExpiresView.GetRecords(joinFilter,whereClause, orderBy, pageNum, rowsPerQuery);
                    if (records != null && records.Length > 0 && whereClause.RunQuery)
                    {
                        foreach ( VPropertyTermExpiresRecord record in records)
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
                                 _isExpandableNonCompositeForeignKey = VPropertyTermExpiresView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyTermExpiresView.PropertyID);
                                 _DFKA = VPropertyTermExpiresView.GetDFKA(record.PropertyID.ToString(), VPropertyTermExpiresView.PropertyID,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  VPropertyTermExpiresView.PropertyID.IsApplyDisplayAs){
                                     report.AddData("${PropertyID}", _DFKA,ReportEnum.Align.Left, 100);
                                 }else{
                                     report.AddData("${PropertyID}", record.Format(VPropertyTermExpiresView.PropertyID), ReportEnum.Align.Left, 100);
                                 }
                             }
                             report.AddData("${CompanyName}", record.Format(VPropertyTermExpiresView.CompanyName), ReportEnum.Align.Left, 100);
                             report.AddData("${Address1}", record.Format(VPropertyTermExpiresView.Address1), ReportEnum.Align.Left, 100);
                             report.AddData("${Address2}", record.Format(VPropertyTermExpiresView.Address2), ReportEnum.Align.Left, 100);
                             report.AddData("${Address3}", record.Format(VPropertyTermExpiresView.Address3), ReportEnum.Align.Left, 100);
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.CityID)){
                                 report.AddData("${CityID}", "",ReportEnum.Align.Left, 100);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = VPropertyTermExpiresView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyTermExpiresView.CityID);
                                 _DFKA = VPropertyTermExpiresView.GetDFKA(record.CityID.ToString(), VPropertyTermExpiresView.CityID,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  VPropertyTermExpiresView.CityID.IsApplyDisplayAs){
                                     report.AddData("${CityID}", _DFKA,ReportEnum.Align.Left, 100);
                                 }else{
                                     report.AddData("${CityID}", record.Format(VPropertyTermExpiresView.CityID), ReportEnum.Align.Left, 100);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.RegionID)){
                                 report.AddData("${RegionID}", "",ReportEnum.Align.Left, 100);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = VPropertyTermExpiresView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyTermExpiresView.RegionID);
                                 _DFKA = VPropertyTermExpiresView.GetDFKA(record.RegionID.ToString(), VPropertyTermExpiresView.RegionID,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  VPropertyTermExpiresView.RegionID.IsApplyDisplayAs){
                                     report.AddData("${RegionID}", _DFKA,ReportEnum.Align.Left, 100);
                                 }else{
                                     report.AddData("${RegionID}", record.Format(VPropertyTermExpiresView.RegionID), ReportEnum.Align.Left, 100);
                                 }
                             }
                             if (BaseClasses.Utils.MiscUtils.IsNull(record.CountryID)){
                                 report.AddData("${CountryID}", "",ReportEnum.Align.Left, 100);
                             }else{
                                 Boolean _isExpandableNonCompositeForeignKey;
                                 String _DFKA = "";
                                 _isExpandableNonCompositeForeignKey = VPropertyTermExpiresView.Instance.TableDefinition.IsExpandableNonCompositeForeignKey(VPropertyTermExpiresView.CountryID);
                                 _DFKA = VPropertyTermExpiresView.GetDFKA(record.CountryID.ToString(), VPropertyTermExpiresView.CountryID,null);
                                 if (_isExpandableNonCompositeForeignKey &&  ( _DFKA  != null)  &&  VPropertyTermExpiresView.CountryID.IsApplyDisplayAs){
                                     report.AddData("${CountryID}", _DFKA,ReportEnum.Align.Left, 100);
                                 }else{
                                     report.AddData("${CountryID}", record.Format(VPropertyTermExpiresView.CountryID), ReportEnum.Align.Left, 100);
                                 }
                             }
                             report.AddData("${PostCode}", record.Format(VPropertyTermExpiresView.PostCode), ReportEnum.Align.Left, 100);
                             report.AddData("${ExpiryDate}", record.Format(VPropertyTermExpiresView.ExpiryDate), ReportEnum.Align.Left, 100);
                             report.AddData("${Description}", record.Format(VPropertyTermExpiresView.Description), ReportEnum.Align.Left, 100);
                             report.AddData("${TermExpireID}", record.Format(VPropertyTermExpiresView.TermExpireID), ReportEnum.Align.Right, 100);

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
        public virtual void VPropertyTermExpiresButtonsButton_Click(object sender, EventArgs args)
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
        public virtual void VPropertyTermExpiresFilterButton_Click(object sender, EventArgs args)
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
        public virtual void VPropertyTermExpiresFiltersButton_Click(object sender, EventArgs args)
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
                    _TotalRecords = VPropertyTermExpiresView.GetRecordCount(CreateCompoundJoinFilter(), CreateWhereClause());
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
        
        public  VPropertyTermExpiresRecord[] DataSource {
             
            get {
                return (VPropertyTermExpiresRecord[])(base._DataSource);
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
        
        public System.Web.UI.WebControls.DropDownList CityIDFilter {
            get {
                return (System.Web.UI.WebControls.DropDownList)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "CityIDFilter");
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
        
        public System.Web.UI.WebControls.LinkButton DescriptionSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "DescriptionSortLabel");
            }
        }
        
        public System.Web.UI.WebControls.LinkButton ExpiryDateSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "ExpiryDateSortLabel");
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
        
        public System.Web.UI.WebControls.LinkButton TermExpireIDSortLabel {
            get {
                return (System.Web.UI.WebControls.LinkButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "TermExpireIDSortLabel");
            }
        }
        
        public IPv5.UI.IThemeButtonWithArrow VPropertyTermExpiresButtonsButton {
            get {
                return (IPv5.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyTermExpiresButtonsButton");
            }
        }
        
        public System.Web.UI.DataVisualization.Charting.Chart VPropertyTermExpiresCountChart {
            get {
                return (System.Web.UI.DataVisualization.Charting.Chart)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyTermExpiresCountChart");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton VPropertyTermExpiresExportExcelButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyTermExpiresExportExcelButton");
            }
        }
        
        public IPv5.UI.IThemeButton VPropertyTermExpiresFilterButton {
            get {
                return (IPv5.UI.IThemeButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyTermExpiresFilterButton");
            }
        }
        
        public IPv5.UI.IThemeButtonWithArrow VPropertyTermExpiresFiltersButton {
            get {
                return (IPv5.UI.IThemeButtonWithArrow)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyTermExpiresFiltersButton");
            }
        }
        
        public IPv5.UI.IPaginationModern VPropertyTermExpiresPagination {
            get {
                return (IPv5.UI.IPaginationModern)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyTermExpiresPagination");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton VPropertyTermExpiresPDFButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyTermExpiresPDFButton");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton VPropertyTermExpiresResetButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyTermExpiresResetButton");
            }
        }
        
        public System.Web.UI.WebControls.TextBox VPropertyTermExpiresSearch {
            get {
                return (System.Web.UI.WebControls.TextBox)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyTermExpiresSearch");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton VPropertyTermExpiresSearchButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyTermExpiresSearchButton");
            }
        }
        
        public System.Web.UI.WebControls.Literal VPropertyTermExpiresTitle {
            get {
                return (System.Web.UI.WebControls.Literal)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyTermExpiresTitle");
            }
        }
        
        public System.Web.UI.WebControls.ImageButton VPropertyTermExpiresWordButton {
            get {
                return (System.Web.UI.WebControls.ImageButton)BaseClasses.Utils.MiscUtils.FindControlRecursively(this, "VPropertyTermExpiresWordButton");
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
          
        public virtual VPropertyTermExpiresTableControlRow GetSelectedRecordControl()
        {
        
            return null;
          
        }

        public virtual VPropertyTermExpiresTableControlRow[] GetSelectedRecordControls()
        {
        
            return (VPropertyTermExpiresTableControlRow[])((new ArrayList()).ToArray(Type.GetType("IPv5.UI.Controls.ShowVPropertyTermExpiresTable2.VPropertyTermExpiresTableControlRow")));
          
        }

        public virtual void DeleteSelectedRecords(bool deferDeletion)
        {
            VPropertyTermExpiresTableControlRow[] recordList = this.GetSelectedRecordControls();
            if (recordList.Length == 0) {
                // Localization.
                throw new Exception(Page.GetResourceValue("Err:NoRecSelected", "IPv5"));
            }
            
            foreach (VPropertyTermExpiresTableControlRow recCtl in recordList)
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

        public virtual VPropertyTermExpiresTableControlRow[] GetRecordControls()
        {
            Control[] recCtrls = BaseClasses.Utils.MiscUtils.FindControlsRecursively(this, "VPropertyTermExpiresTableControlRow");
	          List<VPropertyTermExpiresTableControlRow> list = new List<VPropertyTermExpiresTableControlRow>();
	          foreach (VPropertyTermExpiresTableControlRow recCtrl in recCtrls) {
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

  