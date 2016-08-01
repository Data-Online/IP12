// This class is "generated" and will be overwritten.
// Your customizations should be made in CountriesRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IPv5.Business
{

/// <summary>
/// The generated superclass for the <see cref="CountriesRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="CountriesTable"></see> class.
/// </remarks>
/// <seealso cref="CountriesTable"></seealso>
/// <seealso cref="CountriesRecord"></seealso>
public class BaseCountriesRecord : PrimaryKeyRecord
{

	public readonly static CountriesTable TableUtils = CountriesTable.Instance;

	// Constructors
 
	protected BaseCountriesRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.CountriesRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.CountriesRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.CountriesRecord_ReadRecord); 
	}

	protected BaseCountriesRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void CountriesRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                CountriesRecord CountriesRec = (CountriesRecord)sender;
        if(CountriesRec != null && !CountriesRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void CountriesRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                CountriesRecord CountriesRec = (CountriesRecord)sender;
        Validate_Inserting();
        if(CountriesRec != null && !CountriesRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void CountriesRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                CountriesRecord CountriesRec = (CountriesRecord)sender;
        Validate_Updating();
        if(CountriesRec != null && !CountriesRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Countries_.CountryID field.
	/// </summary>
	public ColumnValue GetCountryIDValue()
	{
		return this.GetValue(TableUtils.CountryIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Countries_.CountryID field.
	/// </summary>
	public Int32 GetCountryIDFieldValue()
	{
		return this.GetValue(TableUtils.CountryIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Countries_.Country field.
	/// </summary>
	public ColumnValue GetCountryValue()
	{
		return this.GetValue(TableUtils.CountryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Countries_.Country field.
	/// </summary>
	public string GetCountryFieldValue()
	{
		return this.GetValue(TableUtils.CountryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.Country field.
	/// </summary>
	public void SetCountryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CountryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.Country field.
	/// </summary>
	public void SetCountryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CountryColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Countries_.CountryID field.
	/// </summary>
	public Int32 CountryID
	{
		get
		{
			return this.GetValue(TableUtils.CountryIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CountryIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CountryIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CountryIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.CountryID field.
	/// </summary>
	public string CountryIDDefault
	{
		get
		{
			return TableUtils.CountryIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Countries_.Country field.
	/// </summary>
	public string Country
	{
		get
		{
			return this.GetValue(TableUtils.CountryColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CountryColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CountrySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CountryColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Countries_.Country field.
	/// </summary>
	public string CountryDefault
	{
		get
		{
			return TableUtils.CountryColumn.DefaultValue;
		}
	}


#endregion
}

}
