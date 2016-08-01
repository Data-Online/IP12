// This class is "generated" and will be overwritten.
// Your customizations should be made in ServiceTypesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IPv5.Business
{

/// <summary>
/// The generated superclass for the <see cref="ServiceTypesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="ServiceTypesTable"></see> class.
/// </remarks>
/// <seealso cref="ServiceTypesTable"></seealso>
/// <seealso cref="ServiceTypesRecord"></seealso>
public class BaseServiceTypesRecord : PrimaryKeyRecord
{

	public readonly static ServiceTypesTable TableUtils = ServiceTypesTable.Instance;

	// Constructors
 
	protected BaseServiceTypesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.ServiceTypesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.ServiceTypesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.ServiceTypesRecord_ReadRecord); 
	}

	protected BaseServiceTypesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void ServiceTypesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                ServiceTypesRecord ServiceTypesRec = (ServiceTypesRecord)sender;
        if(ServiceTypesRec != null && !ServiceTypesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void ServiceTypesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                ServiceTypesRecord ServiceTypesRec = (ServiceTypesRecord)sender;
        Validate_Inserting();
        if(ServiceTypesRec != null && !ServiceTypesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void ServiceTypesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                ServiceTypesRecord ServiceTypesRec = (ServiceTypesRecord)sender;
        Validate_Updating();
        if(ServiceTypesRec != null && !ServiceTypesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's ServiceTypes_.ServiceTypeID field.
	/// </summary>
	public ColumnValue GetServiceTypeIDValue()
	{
		return this.GetValue(TableUtils.ServiceTypeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ServiceTypes_.ServiceTypeID field.
	/// </summary>
	public Int32 GetServiceTypeIDFieldValue()
	{
		return this.GetValue(TableUtils.ServiceTypeIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ServiceTypes_.ServiceType field.
	/// </summary>
	public ColumnValue GetServiceTypeValue()
	{
		return this.GetValue(TableUtils.ServiceTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's ServiceTypes_.ServiceType field.
	/// </summary>
	public string GetServiceTypeFieldValue()
	{
		return this.GetValue(TableUtils.ServiceTypeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ServiceTypes_.ServiceType field.
	/// </summary>
	public void SetServiceTypeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ServiceTypeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ServiceTypes_.ServiceType field.
	/// </summary>
	public void SetServiceTypeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServiceTypeColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's ServiceTypes_.ServiceTypeID field.
	/// </summary>
	public Int32 ServiceTypeID
	{
		get
		{
			return this.GetValue(TableUtils.ServiceTypeIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ServiceTypeIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ServiceTypeIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ServiceTypeIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ServiceTypes_.ServiceTypeID field.
	/// </summary>
	public string ServiceTypeIDDefault
	{
		get
		{
			return TableUtils.ServiceTypeIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's ServiceTypes_.ServiceType field.
	/// </summary>
	public string ServiceType
	{
		get
		{
			return this.GetValue(TableUtils.ServiceTypeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ServiceTypeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ServiceTypeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ServiceTypeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's ServiceTypes_.ServiceType field.
	/// </summary>
	public string ServiceTypeDefault
	{
		get
		{
			return TableUtils.ServiceTypeColumn.DefaultValue;
		}
	}


#endregion
}

}
