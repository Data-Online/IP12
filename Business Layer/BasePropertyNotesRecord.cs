﻿// This class is "generated" and will be overwritten.
// Your customizations should be made in PropertyNotesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IPv5.Business
{

/// <summary>
/// The generated superclass for the <see cref="PropertyNotesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PropertyNotesTable"></see> class.
/// </remarks>
/// <seealso cref="PropertyNotesTable"></seealso>
/// <seealso cref="PropertyNotesRecord"></seealso>
public class BasePropertyNotesRecord : PrimaryKeyRecord
{

	public readonly static PropertyNotesTable TableUtils = PropertyNotesTable.Instance;

	// Constructors
 
	protected BasePropertyNotesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.PropertyNotesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.PropertyNotesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.PropertyNotesRecord_ReadRecord); 
	}

	protected BasePropertyNotesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void PropertyNotesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                PropertyNotesRecord PropertyNotesRec = (PropertyNotesRecord)sender;
        if(PropertyNotesRec != null && !PropertyNotesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void PropertyNotesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                PropertyNotesRecord PropertyNotesRec = (PropertyNotesRecord)sender;
        Validate_Inserting();
        if(PropertyNotesRec != null && !PropertyNotesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void PropertyNotesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                PropertyNotesRecord PropertyNotesRec = (PropertyNotesRecord)sender;
        Validate_Updating();
        if(PropertyNotesRec != null && !PropertyNotesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's PropertyNotes_.NoteID field.
	/// </summary>
	public ColumnValue GetNoteIDValue()
	{
		return this.GetValue(TableUtils.NoteIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyNotes_.NoteID field.
	/// </summary>
	public Int32 GetNoteIDFieldValue()
	{
		return this.GetValue(TableUtils.NoteIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyNotes_.PropertyID field.
	/// </summary>
	public ColumnValue GetPropertyIDValue()
	{
		return this.GetValue(TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyNotes_.PropertyID field.
	/// </summary>
	public Int32 GetPropertyIDFieldValue()
	{
		return this.GetValue(TableUtils.PropertyIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyNotes_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyNotes_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyNotes_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyNotes_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyNotes_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyNotes_.Notes field.
	/// </summary>
	public ColumnValue GetNotesValue()
	{
		return this.GetValue(TableUtils.NotesColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyNotes_.Notes field.
	/// </summary>
	public string GetNotesFieldValue()
	{
		return this.GetValue(TableUtils.NotesColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyNotes_.Notes field.
	/// </summary>
	public void SetNotesFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.NotesColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyNotes_.Notes field.
	/// </summary>
	public void SetNotesFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.NotesColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyNotes_.DateRecorded field.
	/// </summary>
	public ColumnValue GetDateRecordedValue()
	{
		return this.GetValue(TableUtils.DateRecordedColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyNotes_.DateRecorded field.
	/// </summary>
	public DateTime GetDateRecordedFieldValue()
	{
		return this.GetValue(TableUtils.DateRecordedColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyNotes_.DateRecorded field.
	/// </summary>
	public void SetDateRecordedFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DateRecordedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyNotes_.DateRecorded field.
	/// </summary>
	public void SetDateRecordedFieldValue(string val)
	{
		this.SetString(val, TableUtils.DateRecordedColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyNotes_.DateRecorded field.
	/// </summary>
	public void SetDateRecordedFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DateRecordedColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyNotes_.NoteID field.
	/// </summary>
	public Int32 NoteID
	{
		get
		{
			return this.GetValue(TableUtils.NoteIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NoteIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NoteIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NoteIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyNotes_.NoteID field.
	/// </summary>
	public string NoteIDDefault
	{
		get
		{
			return TableUtils.NoteIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyNotes_.PropertyID field.
	/// </summary>
	public Int32 PropertyID
	{
		get
		{
			return this.GetValue(TableUtils.PropertyIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PropertyIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PropertyIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PropertyIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyNotes_.PropertyID field.
	/// </summary>
	public string PropertyIDDefault
	{
		get
		{
			return TableUtils.PropertyIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyNotes_.Notes field.
	/// </summary>
	public string Notes
	{
		get
		{
			return this.GetValue(TableUtils.NotesColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.NotesColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool NotesSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.NotesColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyNotes_.Notes field.
	/// </summary>
	public string NotesDefault
	{
		get
		{
			return TableUtils.NotesColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyNotes_.DateRecorded field.
	/// </summary>
	public DateTime DateRecorded
	{
		get
		{
			return this.GetValue(TableUtils.DateRecordedColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DateRecordedColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DateRecordedSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DateRecordedColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyNotes_.DateRecorded field.
	/// </summary>
	public string DateRecordedDefault
	{
		get
		{
			return TableUtils.DateRecordedColumn.DefaultValue;
		}
	}


#endregion
}

}
