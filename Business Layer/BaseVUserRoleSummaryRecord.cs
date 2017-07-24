// This class is "generated" and will be overwritten.
// Your customizations should be made in VUserRoleSummaryRecord.vb

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IPv5.Business
{

/// <summary>
/// The generated superclass for the <see cref="VUserRoleSummaryRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="VUserRoleSummaryView"></see> class.
/// </remarks>
/// <seealso cref="VUserRoleSummaryView"></seealso>
/// <seealso cref="VUserRoleSummaryRecord"></seealso>
public class BaseVUserRoleSummaryRecord : KeylessRecord
{

	public readonly static VUserRoleSummaryView TableUtils = VUserRoleSummaryView.Instance;

	// Constructors
 
	protected BaseVUserRoleSummaryRecord() : base(TableUtils)
	{
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.VUserRoleSummaryRecord_ReadRecord); 
        this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.VUserRoleSummaryRecord_InsertingRecord);     
	}

	protected BaseVUserRoleSummaryRecord(KeylessRecord record) : base(record, TableUtils)
	{
	}
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void VUserRoleSummaryRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                VUserRoleSummaryRecord VUserRoleSummaryRec = (VUserRoleSummaryRecord)sender;
        if(VUserRoleSummaryRec != null && !VUserRoleSummaryRec.IsReadOnly ){
                }
    
    }
    
    	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void VUserRoleSummaryRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                VUserRoleSummaryRecord VUserRoleSummaryRec = (VUserRoleSummaryRecord)sender;
        Validate_Inserting();
        if(VUserRoleSummaryRec != null && !VUserRoleSummaryRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's vUserRoleSummary_.Active field.
	/// </summary>
	public ColumnValue GetActiveValue()
	{
		return this.GetValue(TableUtils.ActiveColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vUserRoleSummary_.Active field.
	/// </summary>
	public bool GetActiveFieldValue()
	{
		return this.GetValue(TableUtils.ActiveColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vUserRoleSummary_.Active field.
	/// </summary>
	public void SetActiveFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ActiveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vUserRoleSummary_.Active field.
	/// </summary>
	public void SetActiveFieldValue(string val)
	{
		this.SetString(val, TableUtils.ActiveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vUserRoleSummary_.Active field.
	/// </summary>
	public void SetActiveFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ActiveColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vUserRoleSummary_.PwdExp field.
	/// </summary>
	public ColumnValue GetPwdExpValue()
	{
		return this.GetValue(TableUtils.PwdExpColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vUserRoleSummary_.PwdExp field.
	/// </summary>
	public bool GetPwdExpFieldValue()
	{
		return this.GetValue(TableUtils.PwdExpColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vUserRoleSummary_.PwdExp field.
	/// </summary>
	public void SetPwdExpFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PwdExpColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vUserRoleSummary_.PwdExp field.
	/// </summary>
	public void SetPwdExpFieldValue(string val)
	{
		this.SetString(val, TableUtils.PwdExpColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vUserRoleSummary_.PwdExp field.
	/// </summary>
	public void SetPwdExpFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PwdExpColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vUserRoleSummary_.RoleName field.
	/// </summary>
	public ColumnValue GetRoleNameValue()
	{
		return this.GetValue(TableUtils.RoleNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vUserRoleSummary_.RoleName field.
	/// </summary>
	public string GetRoleNameFieldValue()
	{
		return this.GetValue(TableUtils.RoleNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vUserRoleSummary_.RoleName field.
	/// </summary>
	public void SetRoleNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RoleNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vUserRoleSummary_.RoleName field.
	/// </summary>
	public void SetRoleNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RoleNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vUserRoleSummary_.eMail field.
	/// </summary>
	public ColumnValue GeteMailValue()
	{
		return this.GetValue(TableUtils.eMailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vUserRoleSummary_.eMail field.
	/// </summary>
	public string GeteMailFieldValue()
	{
		return this.GetValue(TableUtils.eMailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vUserRoleSummary_.eMail field.
	/// </summary>
	public void SeteMailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.eMailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vUserRoleSummary_.eMail field.
	/// </summary>
	public void SeteMailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.eMailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vUserRoleSummary_.UserName field.
	/// </summary>
	public ColumnValue GetUserName0Value()
	{
		return this.GetValue(TableUtils.UserName0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vUserRoleSummary_.UserName field.
	/// </summary>
	public string GetUserName0FieldValue()
	{
		return this.GetValue(TableUtils.UserName0Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vUserRoleSummary_.UserName field.
	/// </summary>
	public void SetUserName0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UserName0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vUserRoleSummary_.UserName field.
	/// </summary>
	public void SetUserName0FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UserName0Column);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's vUserRoleSummary_.Active field.
	/// </summary>
	public bool Active
	{
		get
		{
			return this.GetValue(TableUtils.ActiveColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.ActiveColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ActiveSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ActiveColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vUserRoleSummary_.Active field.
	/// </summary>
	public string ActiveDefault
	{
		get
		{
			return TableUtils.ActiveColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vUserRoleSummary_.PwdExp field.
	/// </summary>
	public bool PwdExp
	{
		get
		{
			return this.GetValue(TableUtils.PwdExpColumn).ToBoolean();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
	   		this.SetValue(cv, TableUtils.PwdExpColumn);
		}
	}
	
	

	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PwdExpSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PwdExpColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vUserRoleSummary_.PwdExp field.
	/// </summary>
	public string PwdExpDefault
	{
		get
		{
			return TableUtils.PwdExpColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vUserRoleSummary_.RoleName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vUserRoleSummary_.RoleName field.
	/// </summary>
	public string RoleNameDefault
	{
		get
		{
			return TableUtils.RoleNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vUserRoleSummary_.eMail field.
	/// </summary>
	public string eMail
	{
		get
		{
			return this.GetValue(TableUtils.eMailColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.eMailColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool eMailSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.eMailColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vUserRoleSummary_.eMail field.
	/// </summary>
	public string eMailDefault
	{
		get
		{
			return TableUtils.eMailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vUserRoleSummary_.UserName field.
	/// </summary>
	public string UserName0
	{
		get
		{
			return this.GetValue(TableUtils.UserName0Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.UserName0Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool UserName0Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.UserName0Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vUserRoleSummary_.UserName field.
	/// </summary>
	public string UserName0Default
	{
		get
		{
			return TableUtils.UserName0Column.DefaultValue;
		}
	}


#endregion

}

}
