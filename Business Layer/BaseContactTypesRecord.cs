// This class is "generated" and will be overwritten.
// Your customizations should be made in ContactTypesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IPv5.Business
{

/// <summary>
/// The generated superclass for the <see cref="ContactTypesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="ContactTypesTable"></see> class.
/// </remarks>
/// <seealso cref="ContactTypesTable"></seealso>
/// <seealso cref="ContactTypesRecord"></seealso>
public class BaseContactTypesRecord : PrimaryKeyRecord
{

	public readonly static ContactTypesTable TableUtils = ContactTypesTable.Instance;

	// Constructors
 
	protected BaseContactTypesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.ContactTypesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.ContactTypesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.ContactTypesRecord_ReadRecord); 
	}

	protected BaseContactTypesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void ContactTypesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                ContactTypesRecord ContactTypesRec = (ContactTypesRecord)sender;
        if(ContactTypesRec != null && !ContactTypesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void ContactTypesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                ContactTypesRecord ContactTypesRec = (ContactTypesRecord)sender;
        Validate_Inserting();
        if(ContactTypesRec != null && !ContactTypesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void ContactTypesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                ContactTypesRecord ContactTypesRec = (ContactTypesRecord)sender;
        Validate_Updating();
        if(ContactTypesRec != null && !ContactTypesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's ContactTypes_.ContactTypeID field.
	/// </summary>
	public ColumnValue GetContactTypeIDValue()
	{
		return this.GetValue(TableUtils.ContactTypeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ContactTypes_.ContactTypeID field.
	/// </summary>
	public Int32 GetContactTypeIDFieldValue()
	{
		return this.GetValue(TableUtils.ContactTypeIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ContactTypes_.ContactType field.
	/// </summary>
	public ColumnValue GetContactTypeValue()
	{
		return this.GetValue(TableUtils.ContactTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ContactTypes_.ContactType field.
	/// </summary>
	public string GetContactTypeFieldValue()
	{
		return this.GetValue(TableUtils.ContactTypeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ContactTypes_.ContactType field.
	/// </summary>
	public void SetContactTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ContactTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ContactTypes_.ContactType field.
	/// </summary>
	public void SetContactTypeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactTypeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's ContactTypes_.ContactTypeID field.
	/// </summary>
	public Int32 ContactTypeID
	{
		get
		{
			return this.GetValue(TableUtils.ContactTypeIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ContactTypeIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ContactTypeIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ContactTypeIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ContactTypes_.ContactTypeID field.
	/// </summary>
	public string ContactTypeIDDefault
	{
		get
		{
			return TableUtils.ContactTypeIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ContactTypes_.ContactType field.
	/// </summary>
	public string ContactType
	{
		get
		{
			return this.GetValue(TableUtils.ContactTypeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ContactTypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ContactTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ContactTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ContactTypes_.ContactType field.
	/// </summary>
	public string ContactTypeDefault
	{
		get
		{
			return TableUtils.ContactTypeColumn.DefaultValue;
		}
	}


#endregion
}

}
