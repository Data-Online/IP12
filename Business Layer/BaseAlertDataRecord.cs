// This class is "generated" and will be overwritten.
// Your customizations should be made in AlertDataRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IPv5.Business
{

/// <summary>
/// The generated superclass for the <see cref="AlertDataRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="AlertDataTable"></see> class.
/// </remarks>
/// <seealso cref="AlertDataTable"></seealso>
/// <seealso cref="AlertDataRecord"></seealso>
public class BaseAlertDataRecord : PrimaryKeyRecord
{

	public readonly static AlertDataTable TableUtils = AlertDataTable.Instance;

	// Constructors
 
	protected BaseAlertDataRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.AlertDataRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.AlertDataRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.AlertDataRecord_ReadRecord); 
	}

	protected BaseAlertDataRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void AlertDataRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                AlertDataRecord AlertDataRec = (AlertDataRecord)sender;
        if(AlertDataRec != null && !AlertDataRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void AlertDataRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                AlertDataRecord AlertDataRec = (AlertDataRecord)sender;
        Validate_Inserting();
        if(AlertDataRec != null && !AlertDataRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void AlertDataRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                AlertDataRecord AlertDataRec = (AlertDataRecord)sender;
        Validate_Updating();
        if(AlertDataRec != null && !AlertDataRec.IsReadOnly ){
                }
    
    }

   //Evaluates Validate when->Inserting formulas specified at the data access layer
	protected virtual void Validate_Inserting()
	{
		string fullValidationMessage = "";
		string validationMessage = "";
		
		string formula = "";if (formula == "") formula = "";


		if(validationMessage != "" && validationMessage.ToLower() != "true")
            fullValidationMessage = fullValidationMessage + validationMessage + "\r\n"; 
		
        if(fullValidationMessage != "")
			throw new Exception(fullValidationMessage);
	}
 
	//Evaluates Validate when->Updating formulas specified at the data access layer
	protected virtual void Validate_Updating()
	{
		string fullValidationMessage = "";
		string validationMessage = "";
		
		string formula = "";if (formula == "") formula = "";


		if(validationMessage != "" && validationMessage.ToLower() != "true")
            fullValidationMessage = fullValidationMessage + validationMessage + "\r\n"; 
		
        if(fullValidationMessage != "")
			throw new Exception(fullValidationMessage);
	}
	public virtual string EvaluateFormula(string formula, BaseRecord  dataSourceForEvaluate, string format)
    {
        Data.BaseFormulaEvaluator e = new Data.BaseFormulaEvaluator();
        
        // All variables referred to in the formula are expected to be
        // properties of the DataSource.  For example, referring to
        // UnitPrice as a variable will refer to DataSource.UnitPrice
        e.DataSource = dataSourceForEvaluate;

        Object resultObj = e.Evaluate(formula);
        if(resultObj == null) 
			return "";
        return resultObj.ToString();
	}







#region "Convenience methods to get/set values of fields"

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertData_.AlertDataID field.
	/// </summary>
	public ColumnValue GetAlertDataIDValue()
	{
		return this.GetValue(TableUtils.AlertDataIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertData_.AlertDataID field.
	/// </summary>
	public Int32 GetAlertDataIDFieldValue()
	{
		return this.GetValue(TableUtils.AlertDataIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertData_.ViewName field.
	/// </summary>
	public ColumnValue GetViewNameValue()
	{
		return this.GetValue(TableUtils.ViewNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertData_.ViewName field.
	/// </summary>
	public string GetViewNameFieldValue()
	{
		return this.GetValue(TableUtils.ViewNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertData_.ViewName field.
	/// </summary>
	public void SetViewNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ViewNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertData_.ViewName field.
	/// </summary>
	public void SetViewNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ViewNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertData_.ViewDescription field.
	/// </summary>
	public ColumnValue GetViewDescriptionValue()
	{
		return this.GetValue(TableUtils.ViewDescriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertData_.ViewDescription field.
	/// </summary>
	public string GetViewDescriptionFieldValue()
	{
		return this.GetValue(TableUtils.ViewDescriptionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertData_.ViewDescription field.
	/// </summary>
	public void SetViewDescriptionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ViewDescriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertData_.ViewDescription field.
	/// </summary>
	public void SetViewDescriptionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ViewDescriptionColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's AlertData_.AlertDataID field.
	/// </summary>
	public Int32 AlertDataID
	{
		get
		{
			return this.GetValue(TableUtils.AlertDataIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AlertDataIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AlertDataIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AlertDataIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertData_.AlertDataID field.
	/// </summary>
	public string AlertDataIDDefault
	{
		get
		{
			return TableUtils.AlertDataIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AlertData_.ViewName field.
	/// </summary>
	public string ViewName
	{
		get
		{
			return this.GetValue(TableUtils.ViewNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ViewNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ViewNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ViewNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertData_.ViewName field.
	/// </summary>
	public string ViewNameDefault
	{
		get
		{
			return TableUtils.ViewNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AlertData_.ViewDescription field.
	/// </summary>
	public string ViewDescription
	{
		get
		{
			return this.GetValue(TableUtils.ViewDescriptionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ViewDescriptionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ViewDescriptionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ViewDescriptionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertData_.ViewDescription field.
	/// </summary>
	public string ViewDescriptionDefault
	{
		get
		{
			return TableUtils.ViewDescriptionColumn.DefaultValue;
		}
	}


#endregion
}

}
