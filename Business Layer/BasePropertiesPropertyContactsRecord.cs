// This class is "generated" and will be overwritten.
// Your customizations should be made in PropertiesPropertyContactsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IPv5.Business
{

/// <summary>
/// The generated superclass for the <see cref="PropertiesPropertyContactsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PropertiesPropertyContactsTable"></see> class.
/// </remarks>
/// <seealso cref="PropertiesPropertyContactsTable"></seealso>
/// <seealso cref="PropertiesPropertyContactsRecord"></seealso>
public class BasePropertiesPropertyContactsRecord : PrimaryKeyRecord
{

	public readonly static PropertiesPropertyContactsTable TableUtils = PropertiesPropertyContactsTable.Instance;

	// Constructors
 
	protected BasePropertiesPropertyContactsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.PropertiesPropertyContactsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.PropertiesPropertyContactsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.PropertiesPropertyContactsRecord_ReadRecord); 
	}

	protected BasePropertiesPropertyContactsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void PropertiesPropertyContactsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                PropertiesPropertyContactsRecord PropertiesPropertyContactsRec = (PropertiesPropertyContactsRecord)sender;
        if(PropertiesPropertyContactsRec != null && !PropertiesPropertyContactsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void PropertiesPropertyContactsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                PropertiesPropertyContactsRecord PropertiesPropertyContactsRec = (PropertiesPropertyContactsRecord)sender;
        Validate_Inserting();
        if(PropertiesPropertyContactsRec != null && !PropertiesPropertyContactsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void PropertiesPropertyContactsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                PropertiesPropertyContactsRecord PropertiesPropertyContactsRec = (PropertiesPropertyContactsRecord)sender;
        Validate_Updating();
        if(PropertiesPropertyContactsRec != null && !PropertiesPropertyContactsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's PropertiesPropertyContacts_.PropertyContactId field.
	/// </summary>
	public ColumnValue GetPropertyContactIdValue()
	{
		return this.GetValue(TableUtils.PropertyContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertiesPropertyContacts_.PropertyContactId field.
	/// </summary>
	public Int32 GetPropertyContactIdFieldValue()
	{
		return this.GetValue(TableUtils.PropertyContactIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertiesPropertyContacts_.PropertyContactId field.
	/// </summary>
	public void SetPropertyContactIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PropertyContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertiesPropertyContacts_.PropertyContactId field.
	/// </summary>
	public void SetPropertyContactIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.PropertyContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertiesPropertyContacts_.PropertyContactId field.
	/// </summary>
	public void SetPropertyContactIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertiesPropertyContacts_.PropertyContactId field.
	/// </summary>
	public void SetPropertyContactIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertiesPropertyContacts_.PropertyContactId field.
	/// </summary>
	public void SetPropertyContactIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyContactIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertiesPropertyContacts_.PropertyId field.
	/// </summary>
	public ColumnValue GetPropertyIdValue()
	{
		return this.GetValue(TableUtils.PropertyIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertiesPropertyContacts_.PropertyId field.
	/// </summary>
	public Int32 GetPropertyIdFieldValue()
	{
		return this.GetValue(TableUtils.PropertyIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertiesPropertyContacts_.PropertyId field.
	/// </summary>
	public void SetPropertyIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PropertyIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertiesPropertyContacts_.PropertyId field.
	/// </summary>
	public void SetPropertyIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.PropertyIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertiesPropertyContacts_.PropertyId field.
	/// </summary>
	public void SetPropertyIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertiesPropertyContacts_.PropertyId field.
	/// </summary>
	public void SetPropertyIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertiesPropertyContacts_.PropertyId field.
	/// </summary>
	public void SetPropertyIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertiesPropertyContacts_.ContactTypeId field.
	/// </summary>
	public ColumnValue GetContactTypeIdValue()
	{
		return this.GetValue(TableUtils.ContactTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertiesPropertyContacts_.ContactTypeId field.
	/// </summary>
	public Int32 GetContactTypeIdFieldValue()
	{
		return this.GetValue(TableUtils.ContactTypeIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertiesPropertyContacts_.ContactTypeId field.
	/// </summary>
	public void SetContactTypeIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ContactTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertiesPropertyContacts_.ContactTypeId field.
	/// </summary>
	public void SetContactTypeIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.ContactTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertiesPropertyContacts_.ContactTypeId field.
	/// </summary>
	public void SetContactTypeIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertiesPropertyContacts_.ContactTypeId field.
	/// </summary>
	public void SetContactTypeIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertiesPropertyContacts_.ContactTypeId field.
	/// </summary>
	public void SetContactTypeIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactTypeIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertiesPropertyContacts_.PropertiesPropertyContactsId field.
	/// </summary>
	public ColumnValue GetPropertiesPropertyContactsIdValue()
	{
		return this.GetValue(TableUtils.PropertiesPropertyContactsIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertiesPropertyContacts_.PropertiesPropertyContactsId field.
	/// </summary>
	public Int32 GetPropertiesPropertyContactsIdFieldValue()
	{
		return this.GetValue(TableUtils.PropertiesPropertyContactsIdColumn).ToInt32();
	}



#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertiesPropertyContacts_.PropertyContactId field.
	/// </summary>
	public Int32 PropertyContactId
	{
		get
		{
			return this.GetValue(TableUtils.PropertyContactIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PropertyContactIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PropertyContactIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PropertyContactIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertiesPropertyContacts_.PropertyContactId field.
	/// </summary>
	public string PropertyContactIdDefault
	{
		get
		{
			return TableUtils.PropertyContactIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertiesPropertyContacts_.PropertyId field.
	/// </summary>
	public Int32 PropertyId
	{
		get
		{
			return this.GetValue(TableUtils.PropertyIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PropertyIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PropertyIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PropertyIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertiesPropertyContacts_.PropertyId field.
	/// </summary>
	public string PropertyIdDefault
	{
		get
		{
			return TableUtils.PropertyIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertiesPropertyContacts_.ContactTypeId field.
	/// </summary>
	public Int32 ContactTypeId
	{
		get
		{
			return this.GetValue(TableUtils.ContactTypeIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ContactTypeIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ContactTypeIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ContactTypeIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertiesPropertyContacts_.ContactTypeId field.
	/// </summary>
	public string ContactTypeIdDefault
	{
		get
		{
			return TableUtils.ContactTypeIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertiesPropertyContacts_.PropertiesPropertyContactsId field.
	/// </summary>
	public Int32 PropertiesPropertyContactsId
	{
		get
		{
			return this.GetValue(TableUtils.PropertiesPropertyContactsIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PropertiesPropertyContactsIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PropertiesPropertyContactsIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PropertiesPropertyContactsIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertiesPropertyContacts_.PropertiesPropertyContactsId field.
	/// </summary>
	public string PropertiesPropertyContactsIdDefault
	{
		get
		{
			return TableUtils.PropertiesPropertyContactsIdColumn.DefaultValue;
		}
	}


#endregion
}

}
