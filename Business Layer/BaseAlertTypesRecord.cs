// This class is "generated" and will be overwritten.
// Your customizations should be made in AlertTypesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IPv5.Business
{

/// <summary>
/// The generated superclass for the <see cref="AlertTypesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="AlertTypesTable"></see> class.
/// </remarks>
/// <seealso cref="AlertTypesTable"></seealso>
/// <seealso cref="AlertTypesRecord"></seealso>
public class BaseAlertTypesRecord : PrimaryKeyRecord
{

	public readonly static AlertTypesTable TableUtils = AlertTypesTable.Instance;

	// Constructors
 
	protected BaseAlertTypesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.AlertTypesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.AlertTypesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.AlertTypesRecord_ReadRecord); 
	}

	protected BaseAlertTypesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void AlertTypesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                AlertTypesRecord AlertTypesRec = (AlertTypesRecord)sender;
        if(AlertTypesRec != null && !AlertTypesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void AlertTypesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                AlertTypesRecord AlertTypesRec = (AlertTypesRecord)sender;
        Validate_Inserting();
        if(AlertTypesRec != null && !AlertTypesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void AlertTypesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                AlertTypesRecord AlertTypesRec = (AlertTypesRecord)sender;
        Validate_Updating();
        if(AlertTypesRec != null && !AlertTypesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's AlertTypes_.AlertTypesID field.
	/// </summary>
	public ColumnValue GetAlertTypesIDValue()
	{
		return this.GetValue(TableUtils.AlertTypesIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertTypes_.AlertTypesID field.
	/// </summary>
	public Int32 GetAlertTypesIDFieldValue()
	{
		return this.GetValue(TableUtils.AlertTypesIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertTypes_.Text field.
	/// </summary>
	public ColumnValue GetText0Value()
	{
		return this.GetValue(TableUtils.Text0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertTypes_.Text field.
	/// </summary>
	public string GetText0FieldValue()
	{
		return this.GetValue(TableUtils.Text0Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertTypes_.Text field.
	/// </summary>
	public void SetText0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Text0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertTypes_.Text field.
	/// </summary>
	public void SetText0FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Text0Column);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's AlertTypes_.AlertTypesID field.
	/// </summary>
	public Int32 AlertTypesID
	{
		get
		{
			return this.GetValue(TableUtils.AlertTypesIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AlertTypesIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AlertTypesIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AlertTypesIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertTypes_.AlertTypesID field.
	/// </summary>
	public string AlertTypesIDDefault
	{
		get
		{
			return TableUtils.AlertTypesIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AlertTypes_.Text field.
	/// </summary>
	public string Text0
	{
		get
		{
			return this.GetValue(TableUtils.Text0Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Text0Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Text0Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Text0Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertTypes_.Text field.
	/// </summary>
	public string Text0Default
	{
		get
		{
			return TableUtils.Text0Column.DefaultValue;
		}
	}


#endregion
}

}
