﻿// This class is "generated" and will be overwritten.
// Your customizations should be made in RentReviewsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IPv5.Business
{

/// <summary>
/// The generated superclass for the <see cref="RentReviewsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="RentReviewsTable"></see> class.
/// </remarks>
/// <seealso cref="RentReviewsTable"></seealso>
/// <seealso cref="RentReviewsRecord"></seealso>
public class BaseRentReviewsRecord : PrimaryKeyRecord
{

	public readonly static RentReviewsTable TableUtils = RentReviewsTable.Instance;

	// Constructors
 
	protected BaseRentReviewsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.RentReviewsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.RentReviewsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.RentReviewsRecord_ReadRecord); 
	}

	protected BaseRentReviewsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void RentReviewsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                RentReviewsRecord RentReviewsRec = (RentReviewsRecord)sender;
        if(RentReviewsRec != null && !RentReviewsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void RentReviewsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                RentReviewsRecord RentReviewsRec = (RentReviewsRecord)sender;
        Validate_Inserting();
        if(RentReviewsRec != null && !RentReviewsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void RentReviewsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                RentReviewsRecord RentReviewsRec = (RentReviewsRecord)sender;
        Validate_Updating();
        if(RentReviewsRec != null && !RentReviewsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's RentReviews_.RentReviewID field.
	/// </summary>
	public ColumnValue GetRentReviewIDValue()
	{
		return this.GetValue(TableUtils.RentReviewIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RentReviews_.RentReviewID field.
	/// </summary>
	public Int32 GetRentReviewIDFieldValue()
	{
		return this.GetValue(TableUtils.RentReviewIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RentReviews_.ExpiryDate field.
	/// </summary>
	public ColumnValue GetExpiryDateValue()
	{
		return this.GetValue(TableUtils.ExpiryDateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RentReviews_.ExpiryDate field.
	/// </summary>
	public DateTime GetExpiryDateFieldValue()
	{
		return this.GetValue(TableUtils.ExpiryDateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RentReviews_.ExpiryDate field.
	/// </summary>
	public void SetExpiryDateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ExpiryDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RentReviews_.ExpiryDate field.
	/// </summary>
	public void SetExpiryDateFieldValue(string val)
	{
		this.SetString(val, TableUtils.ExpiryDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RentReviews_.ExpiryDate field.
	/// </summary>
	public void SetExpiryDateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ExpiryDateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RentReviews_.PropertyID field.
	/// </summary>
	public ColumnValue GetPropertyIDValue()
	{
		return this.GetValue(TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RentReviews_.PropertyID field.
	/// </summary>
	public Int32 GetPropertyIDFieldValue()
	{
		return this.GetValue(TableUtils.PropertyIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RentReviews_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RentReviews_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RentReviews_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RentReviews_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RentReviews_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RentReviews_.Description field.
	/// </summary>
	public ColumnValue GetDescriptionValue()
	{
		return this.GetValue(TableUtils.DescriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's RentReviews_.Description field.
	/// </summary>
	public string GetDescriptionFieldValue()
	{
		return this.GetValue(TableUtils.DescriptionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RentReviews_.Description field.
	/// </summary>
	public void SetDescriptionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DescriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RentReviews_.Description field.
	/// </summary>
	public void SetDescriptionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DescriptionColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's RentReviews_.RentReviewID field.
	/// </summary>
	public Int32 RentReviewID
	{
		get
		{
			return this.GetValue(TableUtils.RentReviewIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RentReviewIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RentReviewIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RentReviewIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RentReviews_.RentReviewID field.
	/// </summary>
	public string RentReviewIDDefault
	{
		get
		{
			return TableUtils.RentReviewIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RentReviews_.ExpiryDate field.
	/// </summary>
	public DateTime ExpiryDate
	{
		get
		{
			return this.GetValue(TableUtils.ExpiryDateColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ExpiryDateColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ExpiryDateSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ExpiryDateColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RentReviews_.ExpiryDate field.
	/// </summary>
	public string ExpiryDateDefault
	{
		get
		{
			return TableUtils.ExpiryDateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RentReviews_.PropertyID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's RentReviews_.PropertyID field.
	/// </summary>
	public string PropertyIDDefault
	{
		get
		{
			return TableUtils.PropertyIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's RentReviews_.Description field.
	/// </summary>
	public string Description
	{
		get
		{
			return this.GetValue(TableUtils.DescriptionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.DescriptionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool DescriptionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.DescriptionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's RentReviews_.Description field.
	/// </summary>
	public string DescriptionDefault
	{
		get
		{
			return TableUtils.DescriptionColumn.DefaultValue;
		}
	}


#endregion
}

}
