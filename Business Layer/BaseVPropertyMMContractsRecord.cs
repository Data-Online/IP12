// This class is "generated" and will be overwritten.
// Your customizations should be made in VPropertyMMContractsRecord.vb

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IPv5.Business
{

/// <summary>
/// The generated superclass for the <see cref="VPropertyMMContractsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="VPropertyMMContractsView"></see> class.
/// </remarks>
/// <seealso cref="VPropertyMMContractsView"></seealso>
/// <seealso cref="VPropertyMMContractsRecord"></seealso>
public class BaseVPropertyMMContractsRecord : KeylessRecord
{

	public readonly static VPropertyMMContractsView TableUtils = VPropertyMMContractsView.Instance;

	// Constructors
 
	protected BaseVPropertyMMContractsRecord() : base(TableUtils)
	{
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.VPropertyMMContractsRecord_ReadRecord); 
        this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.VPropertyMMContractsRecord_InsertingRecord);     
	}

	protected BaseVPropertyMMContractsRecord(KeylessRecord record) : base(record, TableUtils)
	{
	}
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void VPropertyMMContractsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                VPropertyMMContractsRecord VPropertyMMContractsRec = (VPropertyMMContractsRecord)sender;
        if(VPropertyMMContractsRec != null && !VPropertyMMContractsRec.IsReadOnly ){
                }
    
    }
    
    	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void VPropertyMMContractsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                VPropertyMMContractsRecord VPropertyMMContractsRec = (VPropertyMMContractsRecord)sender;
        Validate_Inserting();
        if(VPropertyMMContractsRec != null && !VPropertyMMContractsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.PropertyID field.
	/// </summary>
	public ColumnValue GetPropertyIDValue()
	{
		return this.GetValue(TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.PropertyID field.
	/// </summary>
	public Int32 GetPropertyIDFieldValue()
	{
		return this.GetValue(TableUtils.PropertyIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.CompanyName field.
	/// </summary>
	public ColumnValue GetCompanyNameValue()
	{
		return this.GetValue(TableUtils.CompanyNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.CompanyName field.
	/// </summary>
	public string GetCompanyNameFieldValue()
	{
		return this.GetValue(TableUtils.CompanyNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.CompanyName field.
	/// </summary>
	public void SetCompanyNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CompanyNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.CompanyName field.
	/// </summary>
	public void SetCompanyNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CompanyNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.Address1 field.
	/// </summary>
	public ColumnValue GetAddress1Value()
	{
		return this.GetValue(TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.Address1 field.
	/// </summary>
	public string GetAddress1FieldValue()
	{
		return this.GetValue(TableUtils.Address1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.Address2 field.
	/// </summary>
	public ColumnValue GetAddress2Value()
	{
		return this.GetValue(TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.Address2 field.
	/// </summary>
	public string GetAddress2FieldValue()
	{
		return this.GetValue(TableUtils.Address2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.Address3 field.
	/// </summary>
	public ColumnValue GetAddress3Value()
	{
		return this.GetValue(TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.Address3 field.
	/// </summary>
	public string GetAddress3FieldValue()
	{
		return this.GetValue(TableUtils.Address3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.CityID field.
	/// </summary>
	public ColumnValue GetCityIDValue()
	{
		return this.GetValue(TableUtils.CityIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.CityID field.
	/// </summary>
	public Int32 GetCityIDFieldValue()
	{
		return this.GetValue(TableUtils.CityIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.CityID field.
	/// </summary>
	public void SetCityIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CityIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.CityID field.
	/// </summary>
	public void SetCityIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.CityIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.CityID field.
	/// </summary>
	public void SetCityIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.CityID field.
	/// </summary>
	public void SetCityIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.CityID field.
	/// </summary>
	public void SetCityIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.RegionID field.
	/// </summary>
	public ColumnValue GetRegionIDValue()
	{
		return this.GetValue(TableUtils.RegionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.RegionID field.
	/// </summary>
	public Int32 GetRegionIDFieldValue()
	{
		return this.GetValue(TableUtils.RegionIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.RegionID field.
	/// </summary>
	public void SetRegionIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RegionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.RegionID field.
	/// </summary>
	public void SetRegionIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.RegionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.RegionID field.
	/// </summary>
	public void SetRegionIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.RegionID field.
	/// </summary>
	public void SetRegionIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.RegionID field.
	/// </summary>
	public void SetRegionIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegionIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.CountryID field.
	/// </summary>
	public ColumnValue GetCountryIDValue()
	{
		return this.GetValue(TableUtils.CountryIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.CountryID field.
	/// </summary>
	public Int32 GetCountryIDFieldValue()
	{
		return this.GetValue(TableUtils.CountryIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.CountryID field.
	/// </summary>
	public void SetCountryIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CountryIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.CountryID field.
	/// </summary>
	public void SetCountryIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.CountryIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.CountryID field.
	/// </summary>
	public void SetCountryIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CountryIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.CountryID field.
	/// </summary>
	public void SetCountryIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CountryIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.CountryID field.
	/// </summary>
	public void SetCountryIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CountryIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.PostCode field.
	/// </summary>
	public ColumnValue GetPostCodeValue()
	{
		return this.GetValue(TableUtils.PostCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.PostCode field.
	/// </summary>
	public string GetPostCodeFieldValue()
	{
		return this.GetValue(TableUtils.PostCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.PostCode field.
	/// </summary>
	public void SetPostCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PostCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.PostCode field.
	/// </summary>
	public void SetPostCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PostCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.ExpiryDate field.
	/// </summary>
	public ColumnValue GetExpiryDateValue()
	{
		return this.GetValue(TableUtils.ExpiryDateColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.ExpiryDate field.
	/// </summary>
	public DateTime GetExpiryDateFieldValue()
	{
		return this.GetValue(TableUtils.ExpiryDateColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.ExpiryDate field.
	/// </summary>
	public void SetExpiryDateFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ExpiryDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.ExpiryDate field.
	/// </summary>
	public void SetExpiryDateFieldValue(string val)
	{
		this.SetString(val, TableUtils.ExpiryDateColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.ExpiryDate field.
	/// </summary>
	public void SetExpiryDateFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ExpiryDateColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.Description field.
	/// </summary>
	public ColumnValue GetDescriptionValue()
	{
		return this.GetValue(TableUtils.DescriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.Description field.
	/// </summary>
	public string GetDescriptionFieldValue()
	{
		return this.GetValue(TableUtils.DescriptionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.Description field.
	/// </summary>
	public void SetDescriptionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.DescriptionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.Description field.
	/// </summary>
	public void SetDescriptionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.DescriptionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.MMContractID field.
	/// </summary>
	public ColumnValue GetMMContractIDValue()
	{
		return this.GetValue(TableUtils.MMContractIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyMMContracts_.MMContractID field.
	/// </summary>
	public Int32 GetMMContractIDFieldValue()
	{
		return this.GetValue(TableUtils.MMContractIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.MMContractID field.
	/// </summary>
	public void SetMMContractIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MMContractIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.MMContractID field.
	/// </summary>
	public void SetMMContractIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.MMContractIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.MMContractID field.
	/// </summary>
	public void SetMMContractIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MMContractIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.MMContractID field.
	/// </summary>
	public void SetMMContractIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MMContractIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.MMContractID field.
	/// </summary>
	public void SetMMContractIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MMContractIDColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyMMContracts_.PropertyID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.PropertyID field.
	/// </summary>
	public string PropertyIDDefault
	{
		get
		{
			return TableUtils.PropertyIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyMMContracts_.CompanyName field.
	/// </summary>
	public string CompanyName
	{
		get
		{
			return this.GetValue(TableUtils.CompanyNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CompanyNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CompanyNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CompanyNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.CompanyName field.
	/// </summary>
	public string CompanyNameDefault
	{
		get
		{
			return TableUtils.CompanyNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyMMContracts_.Address1 field.
	/// </summary>
	public string Address1
	{
		get
		{
			return this.GetValue(TableUtils.Address1Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Address1Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Address1Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Address1Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.Address1 field.
	/// </summary>
	public string Address1Default
	{
		get
		{
			return TableUtils.Address1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyMMContracts_.Address2 field.
	/// </summary>
	public string Address2
	{
		get
		{
			return this.GetValue(TableUtils.Address2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Address2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Address2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Address2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.Address2 field.
	/// </summary>
	public string Address2Default
	{
		get
		{
			return TableUtils.Address2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyMMContracts_.Address3 field.
	/// </summary>
	public string Address3
	{
		get
		{
			return this.GetValue(TableUtils.Address3Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Address3Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Address3Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Address3Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.Address3 field.
	/// </summary>
	public string Address3Default
	{
		get
		{
			return TableUtils.Address3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyMMContracts_.CityID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.CityID field.
	/// </summary>
	public string CityIDDefault
	{
		get
		{
			return TableUtils.CityIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyMMContracts_.RegionID field.
	/// </summary>
	public Int32 RegionID
	{
		get
		{
			return this.GetValue(TableUtils.RegionIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RegionIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RegionIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RegionIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.RegionID field.
	/// </summary>
	public string RegionIDDefault
	{
		get
		{
			return TableUtils.RegionIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyMMContracts_.CountryID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.CountryID field.
	/// </summary>
	public string CountryIDDefault
	{
		get
		{
			return TableUtils.CountryIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyMMContracts_.PostCode field.
	/// </summary>
	public string PostCode
	{
		get
		{
			return this.GetValue(TableUtils.PostCodeColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PostCodeColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PostCodeSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PostCodeColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.PostCode field.
	/// </summary>
	public string PostCodeDefault
	{
		get
		{
			return TableUtils.PostCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyMMContracts_.ExpiryDate field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.ExpiryDate field.
	/// </summary>
	public string ExpiryDateDefault
	{
		get
		{
			return TableUtils.ExpiryDateColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyMMContracts_.Description field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.Description field.
	/// </summary>
	public string DescriptionDefault
	{
		get
		{
			return TableUtils.DescriptionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyMMContracts_.MMContractID field.
	/// </summary>
	public Int32 MMContractID
	{
		get
		{
			return this.GetValue(TableUtils.MMContractIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MMContractIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MMContractIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MMContractIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyMMContracts_.MMContractID field.
	/// </summary>
	public string MMContractIDDefault
	{
		get
		{
			return TableUtils.MMContractIDColumn.DefaultValue;
		}
	}


#endregion

}

}
