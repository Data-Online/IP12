// This class is "generated" and will be overwritten.
// Your customizations should be made in RolesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IPv5.Business
{

/// <summary>
/// The generated superclass for the <see cref="RolesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="RolesTable"></see> class.
/// </remarks>
/// <seealso cref="RolesTable"></seealso>
/// <seealso cref="RolesRecord"></seealso>
public class BaseRolesRecord : PrimaryKeyRecord
{

	public readonly static RolesTable TableUtils = RolesTable.Instance;

	// Constructors
 
	protected BaseRolesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.RolesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.RolesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.RolesRecord_ReadRecord); 
	}

	protected BaseRolesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void RolesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                RolesRecord RolesRec = (RolesRecord)sender;
        if(RolesRec != null && !RolesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void RolesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                RolesRecord RolesRec = (RolesRecord)sender;
        Validate_Inserting();
        if(RolesRec != null && !RolesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void RolesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                RolesRecord RolesRec = (RolesRecord)sender;
        Validate_Updating();
        if(RolesRec != null && !RolesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Roles_.RoleID field.
	/// </summary>
	public ColumnValue GetRoleIDValue()
	{
		return this.GetValue(TableUtils.RoleIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Roles_.RoleID field.
	/// </summary>
	public Int32 GetRoleIDFieldValue()
	{
		return this.GetValue(TableUtils.RoleIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Roles_.RoleName field.
	/// </summary>
	public ColumnValue GetRoleNameValue()
	{
		return this.GetValue(TableUtils.RoleNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Roles_.RoleName field.
	/// </summary>
	public string GetRoleNameFieldValue()
	{
		return this.GetValue(TableUtils.RoleNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Roles_.RoleName field.
	/// </summary>
	public void SetRoleNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RoleNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Roles_.RoleName field.
	/// </summary>
	public void SetRoleNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RoleNameColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Roles_.RoleID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Roles_.RoleID field.
	/// </summary>
	public string RoleIDDefault
	{
		get
		{
			return TableUtils.RoleIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Roles_.RoleName field.
	/// </summary>
	public string RoleName
	{
		get
		{
			return this.GetValue(TableUtils.RoleNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RoleNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RoleNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RoleNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Roles_.RoleName field.
	/// </summary>
	public string RoleNameDefault
	{
		get
		{
			return TableUtils.RoleNameColumn.DefaultValue;
		}
	}


#endregion
}

}
