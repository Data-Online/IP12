// This class is "generated" and will be overwritten.
// Your customizations should be made in LinkTableRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IPv5.Business
{

/// <summary>
/// The generated superclass for the <see cref="LinkTableRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="LinkTableTable"></see> class.
/// </remarks>
/// <seealso cref="LinkTableTable"></seealso>
/// <seealso cref="LinkTableRecord"></seealso>
public class BaseLinkTableRecord : PrimaryKeyRecord
{

	public readonly static LinkTableTable TableUtils = LinkTableTable.Instance;

	// Constructors
 
	protected BaseLinkTableRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.LinkTableRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.LinkTableRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.LinkTableRecord_ReadRecord); 
	}

	protected BaseLinkTableRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void LinkTableRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                LinkTableRecord LinkTableRec = (LinkTableRecord)sender;
        if(LinkTableRec != null && !LinkTableRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void LinkTableRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                LinkTableRecord LinkTableRec = (LinkTableRecord)sender;
        Validate_Inserting();
        if(LinkTableRec != null && !LinkTableRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void LinkTableRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                LinkTableRecord LinkTableRec = (LinkTableRecord)sender;
        Validate_Updating();
        if(LinkTableRec != null && !LinkTableRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's LinkTable_.LinkID field.
	/// </summary>
	public ColumnValue GetLinkIDValue()
	{
		return this.GetValue(TableUtils.LinkIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinkTable_.LinkID field.
	/// </summary>
	public Int32 GetLinkIDFieldValue()
	{
		return this.GetValue(TableUtils.LinkIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinkTable_.PropertyID field.
	/// </summary>
	public ColumnValue GetPropertyIDValue()
	{
		return this.GetValue(TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinkTable_.PropertyID field.
	/// </summary>
	public Int32 GetPropertyIDFieldValue()
	{
		return this.GetValue(TableUtils.PropertyIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinkTable_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinkTable_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinkTable_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinkTable_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinkTable_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinkTable_.ContactID field.
	/// </summary>
	public ColumnValue GetContactIDValue()
	{
		return this.GetValue(TableUtils.ContactIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's LinkTable_.ContactID field.
	/// </summary>
	public Int32 GetContactIDFieldValue()
	{
		return this.GetValue(TableUtils.ContactIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinkTable_.ContactID field.
	/// </summary>
	public void SetContactIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ContactIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinkTable_.ContactID field.
	/// </summary>
	public void SetContactIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.ContactIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinkTable_.ContactID field.
	/// </summary>
	public void SetContactIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinkTable_.ContactID field.
	/// </summary>
	public void SetContactIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinkTable_.ContactID field.
	/// </summary>
	public void SetContactIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactIDColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's LinkTable_.LinkID field.
	/// </summary>
	public Int32 LinkID
	{
		get
		{
			return this.GetValue(TableUtils.LinkIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LinkIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LinkIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LinkIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinkTable_.LinkID field.
	/// </summary>
	public string LinkIDDefault
	{
		get
		{
			return TableUtils.LinkIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LinkTable_.PropertyID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's LinkTable_.PropertyID field.
	/// </summary>
	public string PropertyIDDefault
	{
		get
		{
			return TableUtils.PropertyIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's LinkTable_.ContactID field.
	/// </summary>
	public Int32 ContactID
	{
		get
		{
			return this.GetValue(TableUtils.ContactIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ContactIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ContactIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ContactIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's LinkTable_.ContactID field.
	/// </summary>
	public string ContactIDDefault
	{
		get
		{
			return TableUtils.ContactIDColumn.DefaultValue;
		}
	}


#endregion
}

}
