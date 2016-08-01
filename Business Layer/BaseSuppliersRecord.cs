// This class is "generated" and will be overwritten.
// Your customizations should be made in SuppliersRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IPv5.Business
{

/// <summary>
/// The generated superclass for the <see cref="SuppliersRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="SuppliersTable"></see> class.
/// </remarks>
/// <seealso cref="SuppliersTable"></seealso>
/// <seealso cref="SuppliersRecord"></seealso>
public class BaseSuppliersRecord : PrimaryKeyRecord
{

	public readonly static SuppliersTable TableUtils = SuppliersTable.Instance;

	// Constructors
 
	protected BaseSuppliersRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.SuppliersRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.SuppliersRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.SuppliersRecord_ReadRecord); 
	}

	protected BaseSuppliersRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void SuppliersRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                SuppliersRecord SuppliersRec = (SuppliersRecord)sender;
        if(SuppliersRec != null && !SuppliersRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void SuppliersRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                SuppliersRecord SuppliersRec = (SuppliersRecord)sender;
        Validate_Inserting();
        if(SuppliersRec != null && !SuppliersRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void SuppliersRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                SuppliersRecord SuppliersRec = (SuppliersRecord)sender;
        Validate_Updating();
        if(SuppliersRec != null && !SuppliersRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.SupplierID field.
	/// </summary>
	public ColumnValue GetSupplierIDValue()
	{
		return this.GetValue(TableUtils.SupplierIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.SupplierID field.
	/// </summary>
	public Int32 GetSupplierIDFieldValue()
	{
		return this.GetValue(TableUtils.SupplierIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.CompanyName field.
	/// </summary>
	public ColumnValue GetCompanyNameValue()
	{
		return this.GetValue(TableUtils.CompanyNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.CompanyName field.
	/// </summary>
	public string GetCompanyNameFieldValue()
	{
		return this.GetValue(TableUtils.CompanyNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.CompanyName field.
	/// </summary>
	public void SetCompanyNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CompanyNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.CompanyName field.
	/// </summary>
	public void SetCompanyNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CompanyNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.ContactName field.
	/// </summary>
	public ColumnValue GetContactNameValue()
	{
		return this.GetValue(TableUtils.ContactNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.ContactName field.
	/// </summary>
	public string GetContactNameFieldValue()
	{
		return this.GetValue(TableUtils.ContactNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.ContactName field.
	/// </summary>
	public void SetContactNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ContactNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.ContactName field.
	/// </summary>
	public void SetContactNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.Address1 field.
	/// </summary>
	public ColumnValue GetAddress1Value()
	{
		return this.GetValue(TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.Address1 field.
	/// </summary>
	public string GetAddress1FieldValue()
	{
		return this.GetValue(TableUtils.Address1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.Address2 field.
	/// </summary>
	public ColumnValue GetAddress2Value()
	{
		return this.GetValue(TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.Address2 field.
	/// </summary>
	public string GetAddress2FieldValue()
	{
		return this.GetValue(TableUtils.Address2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.CityID field.
	/// </summary>
	public ColumnValue GetCityIDValue()
	{
		return this.GetValue(TableUtils.CityIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.CityID field.
	/// </summary>
	public Int32 GetCityIDFieldValue()
	{
		return this.GetValue(TableUtils.CityIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.CityID field.
	/// </summary>
	public void SetCityIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CityIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.CityID field.
	/// </summary>
	public void SetCityIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.CityIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.CityID field.
	/// </summary>
	public void SetCityIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.CityID field.
	/// </summary>
	public void SetCityIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.CityID field.
	/// </summary>
	public void SetCityIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.PostCode field.
	/// </summary>
	public ColumnValue GetPostCodeValue()
	{
		return this.GetValue(TableUtils.PostCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.PostCode field.
	/// </summary>
	public string GetPostCodeFieldValue()
	{
		return this.GetValue(TableUtils.PostCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.PostCode field.
	/// </summary>
	public void SetPostCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PostCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.PostCode field.
	/// </summary>
	public void SetPostCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PostCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.LandPhone field.
	/// </summary>
	public ColumnValue GetLandPhoneValue()
	{
		return this.GetValue(TableUtils.LandPhoneColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.LandPhone field.
	/// </summary>
	public string GetLandPhoneFieldValue()
	{
		return this.GetValue(TableUtils.LandPhoneColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.LandPhone field.
	/// </summary>
	public void SetLandPhoneFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LandPhoneColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.LandPhone field.
	/// </summary>
	public void SetLandPhoneFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LandPhoneColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.CellPhone field.
	/// </summary>
	public ColumnValue GetCellPhoneValue()
	{
		return this.GetValue(TableUtils.CellPhoneColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.CellPhone field.
	/// </summary>
	public string GetCellPhoneFieldValue()
	{
		return this.GetValue(TableUtils.CellPhoneColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.CellPhone field.
	/// </summary>
	public void SetCellPhoneFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CellPhoneColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.CellPhone field.
	/// </summary>
	public void SetCellPhoneFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CellPhoneColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.eMail field.
	/// </summary>
	public ColumnValue GeteMailValue()
	{
		return this.GetValue(TableUtils.eMailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.eMail field.
	/// </summary>
	public string GeteMailFieldValue()
	{
		return this.GetValue(TableUtils.eMailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.eMail field.
	/// </summary>
	public void SeteMailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.eMailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.eMail field.
	/// </summary>
	public void SeteMailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.eMailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.ServiceTypeID field.
	/// </summary>
	public ColumnValue GetServiceTypeIDValue()
	{
		return this.GetValue(TableUtils.ServiceTypeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Suppliers_.ServiceTypeID field.
	/// </summary>
	public Int32 GetServiceTypeIDFieldValue()
	{
		return this.GetValue(TableUtils.ServiceTypeIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.ServiceTypeID field.
	/// </summary>
	public void SetServiceTypeIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ServiceTypeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.ServiceTypeID field.
	/// </summary>
	public void SetServiceTypeIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.ServiceTypeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.ServiceTypeID field.
	/// </summary>
	public void SetServiceTypeIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServiceTypeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.ServiceTypeID field.
	/// </summary>
	public void SetServiceTypeIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServiceTypeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.ServiceTypeID field.
	/// </summary>
	public void SetServiceTypeIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ServiceTypeIDColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Suppliers_.SupplierID field.
	/// </summary>
	public Int32 SupplierID
	{
		get
		{
			return this.GetValue(TableUtils.SupplierIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.SupplierIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool SupplierIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.SupplierIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.SupplierID field.
	/// </summary>
	public string SupplierIDDefault
	{
		get
		{
			return TableUtils.SupplierIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Suppliers_.CompanyName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.CompanyName field.
	/// </summary>
	public string CompanyNameDefault
	{
		get
		{
			return TableUtils.CompanyNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Suppliers_.ContactName field.
	/// </summary>
	public string ContactName
	{
		get
		{
			return this.GetValue(TableUtils.ContactNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ContactNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ContactNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ContactNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.ContactName field.
	/// </summary>
	public string ContactNameDefault
	{
		get
		{
			return TableUtils.ContactNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Suppliers_.Address1 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.Address1 field.
	/// </summary>
	public string Address1Default
	{
		get
		{
			return TableUtils.Address1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Suppliers_.Address2 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.Address2 field.
	/// </summary>
	public string Address2Default
	{
		get
		{
			return TableUtils.Address2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Suppliers_.CityID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.CityID field.
	/// </summary>
	public string CityIDDefault
	{
		get
		{
			return TableUtils.CityIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Suppliers_.PostCode field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.PostCode field.
	/// </summary>
	public string PostCodeDefault
	{
		get
		{
			return TableUtils.PostCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Suppliers_.LandPhone field.
	/// </summary>
	public string LandPhone
	{
		get
		{
			return this.GetValue(TableUtils.LandPhoneColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LandPhoneColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LandPhoneSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LandPhoneColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.LandPhone field.
	/// </summary>
	public string LandPhoneDefault
	{
		get
		{
			return TableUtils.LandPhoneColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Suppliers_.CellPhone field.
	/// </summary>
	public string CellPhone
	{
		get
		{
			return this.GetValue(TableUtils.CellPhoneColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CellPhoneColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CellPhoneSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CellPhoneColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.CellPhone field.
	/// </summary>
	public string CellPhoneDefault
	{
		get
		{
			return TableUtils.CellPhoneColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Suppliers_.eMail field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.eMail field.
	/// </summary>
	public string eMailDefault
	{
		get
		{
			return TableUtils.eMailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Suppliers_.ServiceTypeID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Suppliers_.ServiceTypeID field.
	/// </summary>
	public string ServiceTypeIDDefault
	{
		get
		{
			return TableUtils.ServiceTypeIDColumn.DefaultValue;
		}
	}


#endregion
}

}
