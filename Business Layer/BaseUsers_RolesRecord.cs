// This class is "generated" and will be overwritten.
// Your customizations should be made in Users_RolesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IPv5.Business
{

/// <summary>
/// The generated superclass for the <see cref="Users_RolesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="Users_RolesTable"></see> class.
/// </remarks>
/// <seealso cref="Users_RolesTable"></seealso>
/// <seealso cref="Users_RolesRecord"></seealso>
public class BaseUsers_RolesRecord : PrimaryKeyRecord
{

	public readonly static Users_RolesTable TableUtils = Users_RolesTable.Instance;

	// Constructors
 
	protected BaseUsers_RolesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.Users_RolesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.Users_RolesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.Users_RolesRecord_ReadRecord); 
	}

	protected BaseUsers_RolesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void Users_RolesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                Users_RolesRecord Users_RolesRec = (Users_RolesRecord)sender;
        if(Users_RolesRec != null && !Users_RolesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void Users_RolesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                Users_RolesRecord Users_RolesRec = (Users_RolesRecord)sender;
        Validate_Inserting();
        if(Users_RolesRec != null && !Users_RolesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void Users_RolesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                Users_RolesRecord Users_RolesRec = (Users_RolesRecord)sender;
        Validate_Updating();
        if(Users_RolesRec != null && !Users_RolesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Users_Roles_.Users_RoleID field.
	/// </summary>
	public ColumnValue GetUsers_RoleIDValue()
	{
		return this.GetValue(TableUtils.Users_RoleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Users_Roles_.Users_RoleID field.
	/// </summary>
	public Int32 GetUsers_RoleIDFieldValue()
	{
		return this.GetValue(TableUtils.Users_RoleIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Users_Roles_.UserID field.
	/// </summary>
	public ColumnValue GetUserId0Value()
	{
		return this.GetValue(TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Users_Roles_.UserID field.
	/// </summary>
	public Int32 GetUserId0FieldValue()
	{
		return this.GetValue(TableUtils.UserId0Column).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Users_Roles_.UserID field.
	/// </summary>
	public void SetUserId0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Users_Roles_.UserID field.
	/// </summary>
	public void SetUserId0FieldValue(string val)
	{
		this.SetString(val, TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Users_Roles_.UserID field.
	/// </summary>
	public void SetUserId0FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Users_Roles_.UserID field.
	/// </summary>
	public void SetUserId0FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UserId0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Users_Roles_.UserID field.
	/// </summary>
	public void SetUserId0FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UserId0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Users_Roles_.RoleID field.
	/// </summary>
	public ColumnValue GetRoleIDValue()
	{
		return this.GetValue(TableUtils.RoleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Users_Roles_.RoleID field.
	/// </summary>
	public Int32 GetRoleIDFieldValue()
	{
		return this.GetValue(TableUtils.RoleIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Users_Roles_.RoleID field.
	/// </summary>
	public void SetRoleIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RoleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Users_Roles_.RoleID field.
	/// </summary>
	public void SetRoleIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.RoleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Users_Roles_.RoleID field.
	/// </summary>
	public void SetRoleIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RoleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Users_Roles_.RoleID field.
	/// </summary>
	public void SetRoleIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RoleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Users_Roles_.RoleID field.
	/// </summary>
	public void SetRoleIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RoleIDColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Users_Roles_.Users_RoleID field.
	/// </summary>
	public Int32 Users_RoleID
	{
		get
		{
			return this.GetValue(TableUtils.Users_RoleIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Users_RoleIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Users_RoleIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Users_RoleIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Users_Roles_.Users_RoleID field.
	/// </summary>
	public string Users_RoleIDDefault
	{
		get
		{
			return TableUtils.Users_RoleIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Users_Roles_.UserID field.
	/// </summary>
	public Int32 UserId0
	{
		get
		{
			return this.GetValue(TableUtils.UserId0Column).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.UserId0Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool UserId0Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.UserId0Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Users_Roles_.UserID field.
	/// </summary>
	public string UserId0Default
	{
		get
		{
			return TableUtils.UserId0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Users_Roles_.RoleID field.
	/// </summary>
	public Int32 RoleID
	{
		get
		{
			return this.GetValue(TableUtils.RoleIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RoleIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RoleIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RoleIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Users_Roles_.RoleID field.
	/// </summary>
	public string RoleIDDefault
	{
		get
		{
			return TableUtils.RoleIDColumn.DefaultValue;
		}
	}


#endregion
}

}
