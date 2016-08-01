// This class is "generated" and will be overwritten.
// Your customizations should be made in CitiesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IPv5.Business
{

/// <summary>
/// The generated superclass for the <see cref="CitiesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="CitiesTable"></see> class.
/// </remarks>
/// <seealso cref="CitiesTable"></seealso>
/// <seealso cref="CitiesRecord"></seealso>
public class BaseCitiesRecord : PrimaryKeyRecord
{

	public readonly static CitiesTable TableUtils = CitiesTable.Instance;

	// Constructors
 
	protected BaseCitiesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.CitiesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.CitiesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.CitiesRecord_ReadRecord); 
	}

	protected BaseCitiesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void CitiesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                CitiesRecord CitiesRec = (CitiesRecord)sender;
        if(CitiesRec != null && !CitiesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void CitiesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                CitiesRecord CitiesRec = (CitiesRecord)sender;
        Validate_Inserting();
        if(CitiesRec != null && !CitiesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void CitiesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                CitiesRecord CitiesRec = (CitiesRecord)sender;
        Validate_Updating();
        if(CitiesRec != null && !CitiesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Cities_.CityID field.
	/// </summary>
	public ColumnValue GetCityIDValue()
	{
		return this.GetValue(TableUtils.CityIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Cities_.CityID field.
	/// </summary>
	public Int32 GetCityIDFieldValue()
	{
		return this.GetValue(TableUtils.CityIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Cities_.City field.
	/// </summary>
	public ColumnValue GetCityValue()
	{
		return this.GetValue(TableUtils.CityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Cities_.City field.
	/// </summary>
	public string GetCityFieldValue()
	{
		return this.GetValue(TableUtils.CityColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Cities_.City field.
	/// </summary>
	public void SetCityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Cities_.City field.
	/// </summary>
	public void SetCityFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Cities_.CityID field.
	/// </summary>
	public Int32 CityID
	{
		get
		{
			return this.GetValue(TableUtils.CityIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CityIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CityIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CityIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Cities_.CityID field.
	/// </summary>
	public string CityIDDefault
	{
		get
		{
			return TableUtils.CityIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Cities_.City field.
	/// </summary>
	public string City
	{
		get
		{
			return this.GetValue(TableUtils.CityColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CityColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CitySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CityColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Cities_.City field.
	/// </summary>
	public string CityDefault
	{
		get
		{
			return TableUtils.CityColumn.DefaultValue;
		}
	}


#endregion
}

}
