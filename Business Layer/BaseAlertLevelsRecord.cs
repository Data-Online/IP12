// This class is "generated" and will be overwritten.
// Your customizations should be made in AlertLevelsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IPv5.Business
{

/// <summary>
/// The generated superclass for the <see cref="AlertLevelsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="AlertLevelsTable"></see> class.
/// </remarks>
/// <seealso cref="AlertLevelsTable"></seealso>
/// <seealso cref="AlertLevelsRecord"></seealso>
public class BaseAlertLevelsRecord : PrimaryKeyRecord
{

	public readonly static AlertLevelsTable TableUtils = AlertLevelsTable.Instance;

	// Constructors
 
	protected BaseAlertLevelsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.AlertLevelsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.AlertLevelsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.AlertLevelsRecord_ReadRecord); 
	}

	protected BaseAlertLevelsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void AlertLevelsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                AlertLevelsRecord AlertLevelsRec = (AlertLevelsRecord)sender;
        if(AlertLevelsRec != null && !AlertLevelsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void AlertLevelsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                AlertLevelsRecord AlertLevelsRec = (AlertLevelsRecord)sender;
        Validate_Inserting();
        if(AlertLevelsRec != null && !AlertLevelsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void AlertLevelsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                AlertLevelsRecord AlertLevelsRec = (AlertLevelsRecord)sender;
        Validate_Updating();
        if(AlertLevelsRec != null && !AlertLevelsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's AlertLevels_.AlertLevelID field.
	/// </summary>
	public ColumnValue GetAlertLevelIDValue()
	{
		return this.GetValue(TableUtils.AlertLevelIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertLevels_.AlertLevelID field.
	/// </summary>
	public Int32 GetAlertLevelIDFieldValue()
	{
		return this.GetValue(TableUtils.AlertLevelIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertLevels_.TriggerDays field.
	/// </summary>
	public ColumnValue GetTriggerDaysValue()
	{
		return this.GetValue(TableUtils.TriggerDaysColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertLevels_.TriggerDays field.
	/// </summary>
	public Int32 GetTriggerDaysFieldValue()
	{
		return this.GetValue(TableUtils.TriggerDaysColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.TriggerDays field.
	/// </summary>
	public void SetTriggerDaysFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TriggerDaysColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.TriggerDays field.
	/// </summary>
	public void SetTriggerDaysFieldValue(string val)
	{
		this.SetString(val, TableUtils.TriggerDaysColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.TriggerDays field.
	/// </summary>
	public void SetTriggerDaysFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TriggerDaysColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.TriggerDays field.
	/// </summary>
	public void SetTriggerDaysFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TriggerDaysColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.TriggerDays field.
	/// </summary>
	public void SetTriggerDaysFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TriggerDaysColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertLevels_.DueNowColour field.
	/// </summary>
	public ColumnValue GetDueNowColourValue()
	{
		return this.GetValue(TableUtils.DueNowColourColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertLevels_.DueNowColour field.
	/// </summary>
	public string GetDueNowColourFieldValue()
	{
		return this.GetValue(TableUtils.DueNowColourColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.DueNowColour field.
	/// </summary>
	public void SetDueNowColourFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DueNowColourColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.DueNowColour field.
	/// </summary>
	public void SetDueNowColourFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DueNowColourColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertLevels_.DueSoonColour field.
	/// </summary>
	public ColumnValue GetDueSoonColourValue()
	{
		return this.GetValue(TableUtils.DueSoonColourColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertLevels_.DueSoonColour field.
	/// </summary>
	public string GetDueSoonColourFieldValue()
	{
		return this.GetValue(TableUtils.DueSoonColourColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.DueSoonColour field.
	/// </summary>
	public void SetDueSoonColourFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DueSoonColourColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.DueSoonColour field.
	/// </summary>
	public void SetDueSoonColourFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DueSoonColourColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertLevels_.OverdueColour field.
	/// </summary>
	public ColumnValue GetOverdueColourValue()
	{
		return this.GetValue(TableUtils.OverdueColourColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertLevels_.OverdueColour field.
	/// </summary>
	public string GetOverdueColourFieldValue()
	{
		return this.GetValue(TableUtils.OverdueColourColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.OverdueColour field.
	/// </summary>
	public void SetOverdueColourFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OverdueColourColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.OverdueColour field.
	/// </summary>
	public void SetOverdueColourFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OverdueColourColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertLevels_.OverdueTriggerDays field.
	/// </summary>
	public ColumnValue GetOverdueTriggerDaysValue()
	{
		return this.GetValue(TableUtils.OverdueTriggerDaysColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertLevels_.OverdueTriggerDays field.
	/// </summary>
	public Int32 GetOverdueTriggerDaysFieldValue()
	{
		return this.GetValue(TableUtils.OverdueTriggerDaysColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.OverdueTriggerDays field.
	/// </summary>
	public void SetOverdueTriggerDaysFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.OverdueTriggerDaysColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.OverdueTriggerDays field.
	/// </summary>
	public void SetOverdueTriggerDaysFieldValue(string val)
	{
		this.SetString(val, TableUtils.OverdueTriggerDaysColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.OverdueTriggerDays field.
	/// </summary>
	public void SetOverdueTriggerDaysFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OverdueTriggerDaysColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.OverdueTriggerDays field.
	/// </summary>
	public void SetOverdueTriggerDaysFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OverdueTriggerDaysColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.OverdueTriggerDays field.
	/// </summary>
	public void SetOverdueTriggerDaysFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.OverdueTriggerDaysColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertLevels_.AlertDataID field.
	/// </summary>
	public ColumnValue GetAlertDataIDValue()
	{
		return this.GetValue(TableUtils.AlertDataIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's AlertLevels_.AlertDataID field.
	/// </summary>
	public Int32 GetAlertDataIDFieldValue()
	{
		return this.GetValue(TableUtils.AlertDataIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.AlertDataID field.
	/// </summary>
	public void SetAlertDataIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.AlertDataIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.AlertDataID field.
	/// </summary>
	public void SetAlertDataIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.AlertDataIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.AlertDataID field.
	/// </summary>
	public void SetAlertDataIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AlertDataIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.AlertDataID field.
	/// </summary>
	public void SetAlertDataIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AlertDataIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.AlertDataID field.
	/// </summary>
	public void SetAlertDataIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.AlertDataIDColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's AlertLevels_.AlertLevelID field.
	/// </summary>
	public Int32 AlertLevelID
	{
		get
		{
			return this.GetValue(TableUtils.AlertLevelIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.AlertLevelIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool AlertLevelIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.AlertLevelIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.AlertLevelID field.
	/// </summary>
	public string AlertLevelIDDefault
	{
		get
		{
			return TableUtils.AlertLevelIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AlertLevels_.TriggerDays field.
	/// </summary>
	public Int32 TriggerDays
	{
		get
		{
			return this.GetValue(TableUtils.TriggerDaysColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TriggerDaysColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TriggerDaysSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TriggerDaysColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.TriggerDays field.
	/// </summary>
	public string TriggerDaysDefault
	{
		get
		{
			return TableUtils.TriggerDaysColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AlertLevels_.DueNowColour field.
	/// </summary>
	public string DueNowColour
	{
		get
		{
			return this.GetValue(TableUtils.DueNowColourColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DueNowColourColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DueNowColourSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DueNowColourColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.DueNowColour field.
	/// </summary>
	public string DueNowColourDefault
	{
		get
		{
			return TableUtils.DueNowColourColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AlertLevels_.DueSoonColour field.
	/// </summary>
	public string DueSoonColour
	{
		get
		{
			return this.GetValue(TableUtils.DueSoonColourColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DueSoonColourColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DueSoonColourSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DueSoonColourColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.DueSoonColour field.
	/// </summary>
	public string DueSoonColourDefault
	{
		get
		{
			return TableUtils.DueSoonColourColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AlertLevels_.OverdueColour field.
	/// </summary>
	public string OverdueColour
	{
		get
		{
			return this.GetValue(TableUtils.OverdueColourColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OverdueColourColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OverdueColourSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OverdueColourColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.OverdueColour field.
	/// </summary>
	public string OverdueColourDefault
	{
		get
		{
			return TableUtils.OverdueColourColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AlertLevels_.OverdueTriggerDays field.
	/// </summary>
	public Int32 OverdueTriggerDays
	{
		get
		{
			return this.GetValue(TableUtils.OverdueTriggerDaysColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.OverdueTriggerDaysColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool OverdueTriggerDaysSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.OverdueTriggerDaysColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.OverdueTriggerDays field.
	/// </summary>
	public string OverdueTriggerDaysDefault
	{
		get
		{
			return TableUtils.OverdueTriggerDaysColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's AlertLevels_.AlertDataID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's AlertLevels_.AlertDataID field.
	/// </summary>
	public string AlertDataIDDefault
	{
		get
		{
			return TableUtils.AlertDataIDColumn.DefaultValue;
		}
	}


#endregion
}

}
