// This class is "generated" and will be overwritten.
// Your customizations should be made in PropertyContactsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IPv5.Business
{

/// <summary>
/// The generated superclass for the <see cref="PropertyContactsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="PropertyContactsTable"></see> class.
/// </remarks>
/// <seealso cref="PropertyContactsTable"></seealso>
/// <seealso cref="PropertyContactsRecord"></seealso>
public class BasePropertyContactsRecord : PrimaryKeyRecord
{

	public readonly static PropertyContactsTable TableUtils = PropertyContactsTable.Instance;

	// Constructors
 
	protected BasePropertyContactsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.PropertyContactsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.PropertyContactsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.PropertyContactsRecord_ReadRecord); 
	}

	protected BasePropertyContactsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void PropertyContactsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                PropertyContactsRecord PropertyContactsRec = (PropertyContactsRecord)sender;
        if(PropertyContactsRec != null && !PropertyContactsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void PropertyContactsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                PropertyContactsRecord PropertyContactsRec = (PropertyContactsRecord)sender;
        Validate_Inserting();
        if(PropertyContactsRec != null && !PropertyContactsRec.IsReadOnly ){
               PropertyContactsRec.Parse(EvaluateFormula("UserID()",this,null),PropertyContactsTable.CreatedBy);
       PropertyContactsRec.Parse(EvaluateFormula("Now()",this,null),PropertyContactsTable.CreatedOn);
        }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void PropertyContactsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                PropertyContactsRecord PropertyContactsRec = (PropertyContactsRecord)sender;
        Validate_Updating();
        if(PropertyContactsRec != null && !PropertyContactsRec.IsReadOnly ){
               PropertyContactsRec.Parse(EvaluateFormula("UserID()",this,null),PropertyContactsTable.UpdatedBy);
       PropertyContactsRec.Parse(EvaluateFormula("Now()",this,null),PropertyContactsTable.UpdatedOn);
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
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.PropertyContactID field.
	/// </summary>
	public ColumnValue GetPropertyContactIDValue()
	{
		return this.GetValue(TableUtils.PropertyContactIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.PropertyContactID field.
	/// </summary>
	public Int32 GetPropertyContactIDFieldValue()
	{
		return this.GetValue(TableUtils.PropertyContactIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.Title field.
	/// </summary>
	public ColumnValue GetTitle0Value()
	{
		return this.GetValue(TableUtils.Title0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.Title field.
	/// </summary>
	public string GetTitle0FieldValue()
	{
		return this.GetValue(TableUtils.Title0Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.Title field.
	/// </summary>
	public void SetTitle0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Title0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.Title field.
	/// </summary>
	public void SetTitle0FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Title0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.FirstName field.
	/// </summary>
	public ColumnValue GetFirstNameValue()
	{
		return this.GetValue(TableUtils.FirstNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.FirstName field.
	/// </summary>
	public string GetFirstNameFieldValue()
	{
		return this.GetValue(TableUtils.FirstNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.FirstName field.
	/// </summary>
	public void SetFirstNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirstNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.FirstName field.
	/// </summary>
	public void SetFirstNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirstNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.LastName field.
	/// </summary>
	public ColumnValue GetLastNameValue()
	{
		return this.GetValue(TableUtils.LastNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.LastName field.
	/// </summary>
	public string GetLastNameFieldValue()
	{
		return this.GetValue(TableUtils.LastNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.LastName field.
	/// </summary>
	public void SetLastNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LastNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.LastName field.
	/// </summary>
	public void SetLastNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LastNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.Address1 field.
	/// </summary>
	public ColumnValue GetAddress1Value()
	{
		return this.GetValue(TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.Address1 field.
	/// </summary>
	public string GetAddress1FieldValue()
	{
		return this.GetValue(TableUtils.Address1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.Address2 field.
	/// </summary>
	public ColumnValue GetAddress2Value()
	{
		return this.GetValue(TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.Address2 field.
	/// </summary>
	public string GetAddress2FieldValue()
	{
		return this.GetValue(TableUtils.Address2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.Address3 field.
	/// </summary>
	public ColumnValue GetAddress3Value()
	{
		return this.GetValue(TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.Address3 field.
	/// </summary>
	public string GetAddress3FieldValue()
	{
		return this.GetValue(TableUtils.Address3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.CityID field.
	/// </summary>
	public ColumnValue GetCityIDValue()
	{
		return this.GetValue(TableUtils.CityIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.CityID field.
	/// </summary>
	public Int32 GetCityIDFieldValue()
	{
		return this.GetValue(TableUtils.CityIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CityID field.
	/// </summary>
	public void SetCityIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CityIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CityID field.
	/// </summary>
	public void SetCityIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.CityIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CityID field.
	/// </summary>
	public void SetCityIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CityID field.
	/// </summary>
	public void SetCityIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CityID field.
	/// </summary>
	public void SetCityIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.RegionID field.
	/// </summary>
	public ColumnValue GetRegionIDValue()
	{
		return this.GetValue(TableUtils.RegionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.RegionID field.
	/// </summary>
	public Int32 GetRegionIDFieldValue()
	{
		return this.GetValue(TableUtils.RegionIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.RegionID field.
	/// </summary>
	public void SetRegionIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RegionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.RegionID field.
	/// </summary>
	public void SetRegionIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.RegionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.RegionID field.
	/// </summary>
	public void SetRegionIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.RegionID field.
	/// </summary>
	public void SetRegionIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.RegionID field.
	/// </summary>
	public void SetRegionIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegionIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.CountryID field.
	/// </summary>
	public ColumnValue GetCountryIDValue()
	{
		return this.GetValue(TableUtils.CountryIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.CountryID field.
	/// </summary>
	public Int32 GetCountryIDFieldValue()
	{
		return this.GetValue(TableUtils.CountryIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CountryID field.
	/// </summary>
	public void SetCountryIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CountryIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CountryID field.
	/// </summary>
	public void SetCountryIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.CountryIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CountryID field.
	/// </summary>
	public void SetCountryIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CountryIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CountryID field.
	/// </summary>
	public void SetCountryIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CountryIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CountryID field.
	/// </summary>
	public void SetCountryIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CountryIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.PostCode field.
	/// </summary>
	public ColumnValue GetPostCodeValue()
	{
		return this.GetValue(TableUtils.PostCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.PostCode field.
	/// </summary>
	public string GetPostCodeFieldValue()
	{
		return this.GetValue(TableUtils.PostCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.PostCode field.
	/// </summary>
	public void SetPostCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PostCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.PostCode field.
	/// </summary>
	public void SetPostCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PostCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.eMail field.
	/// </summary>
	public ColumnValue GeteMailValue()
	{
		return this.GetValue(TableUtils.eMailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.eMail field.
	/// </summary>
	public string GeteMailFieldValue()
	{
		return this.GetValue(TableUtils.eMailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.eMail field.
	/// </summary>
	public void SeteMailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.eMailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.eMail field.
	/// </summary>
	public void SeteMailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.eMailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.PropertyID field.
	/// </summary>
	public ColumnValue GetPropertyIDValue()
	{
		return this.GetValue(TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.PropertyID field.
	/// </summary>
	public Int32 GetPropertyIDFieldValue()
	{
		return this.GetValue(TableUtils.PropertyIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.ContactTypeID field.
	/// </summary>
	public ColumnValue GetContactTypeIDValue()
	{
		return this.GetValue(TableUtils.ContactTypeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.ContactTypeID field.
	/// </summary>
	public Int32 GetContactTypeIDFieldValue()
	{
		return this.GetValue(TableUtils.ContactTypeIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.ContactTypeID field.
	/// </summary>
	public void SetContactTypeIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ContactTypeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.ContactTypeID field.
	/// </summary>
	public void SetContactTypeIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.ContactTypeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.ContactTypeID field.
	/// </summary>
	public void SetContactTypeIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactTypeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.ContactTypeID field.
	/// </summary>
	public void SetContactTypeIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactTypeIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.ContactTypeID field.
	/// </summary>
	public void SetContactTypeIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactTypeIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.CreatedBy field.
	/// </summary>
	public ColumnValue GetCreatedByValue()
	{
		return this.GetValue(TableUtils.CreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.CreatedBy field.
	/// </summary>
	public Int32 GetCreatedByFieldValue()
	{
		return this.GetValue(TableUtils.CreatedByColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CreatedBy field.
	/// </summary>
	public void SetCreatedByFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CreatedBy field.
	/// </summary>
	public void SetCreatedByFieldValue(string val)
	{
		this.SetString(val, TableUtils.CreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CreatedBy field.
	/// </summary>
	public void SetCreatedByFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CreatedBy field.
	/// </summary>
	public void SetCreatedByFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CreatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CreatedBy field.
	/// </summary>
	public void SetCreatedByFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CreatedByColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.UpdatedBy field.
	/// </summary>
	public ColumnValue GetUpdatedByValue()
	{
		return this.GetValue(TableUtils.UpdatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.UpdatedBy field.
	/// </summary>
	public Int32 GetUpdatedByFieldValue()
	{
		return this.GetValue(TableUtils.UpdatedByColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.UpdatedBy field.
	/// </summary>
	public void SetUpdatedByFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UpdatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.UpdatedBy field.
	/// </summary>
	public void SetUpdatedByFieldValue(string val)
	{
		this.SetString(val, TableUtils.UpdatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.UpdatedBy field.
	/// </summary>
	public void SetUpdatedByFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UpdatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.UpdatedBy field.
	/// </summary>
	public void SetUpdatedByFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UpdatedByColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.UpdatedBy field.
	/// </summary>
	public void SetUpdatedByFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UpdatedByColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.CreatedOn field.
	/// </summary>
	public ColumnValue GetCreatedOnValue()
	{
		return this.GetValue(TableUtils.CreatedOnColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.CreatedOn field.
	/// </summary>
	public DateTime GetCreatedOnFieldValue()
	{
		return this.GetValue(TableUtils.CreatedOnColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CreatedOn field.
	/// </summary>
	public void SetCreatedOnFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CreatedOnColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CreatedOn field.
	/// </summary>
	public void SetCreatedOnFieldValue(string val)
	{
		this.SetString(val, TableUtils.CreatedOnColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CreatedOn field.
	/// </summary>
	public void SetCreatedOnFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CreatedOnColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.UpdatedOn field.
	/// </summary>
	public ColumnValue GetUpdatedOnValue()
	{
		return this.GetValue(TableUtils.UpdatedOnColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.UpdatedOn field.
	/// </summary>
	public DateTime GetUpdatedOnFieldValue()
	{
		return this.GetValue(TableUtils.UpdatedOnColumn).ToDateTime();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.UpdatedOn field.
	/// </summary>
	public void SetUpdatedOnFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.UpdatedOnColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.UpdatedOn field.
	/// </summary>
	public void SetUpdatedOnFieldValue(string val)
	{
		this.SetString(val, TableUtils.UpdatedOnColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.UpdatedOn field.
	/// </summary>
	public void SetUpdatedOnFieldValue(DateTime val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.UpdatedOnColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.MobileNumber field.
	/// </summary>
	public ColumnValue GetMobileNumberValue()
	{
		return this.GetValue(TableUtils.MobileNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.MobileNumber field.
	/// </summary>
	public string GetMobileNumberFieldValue()
	{
		return this.GetValue(TableUtils.MobileNumberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.MobileNumber field.
	/// </summary>
	public void SetMobileNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MobileNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.MobileNumber field.
	/// </summary>
	public void SetMobileNumberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MobileNumberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.PhoneNumber field.
	/// </summary>
	public ColumnValue GetPhoneNumberValue()
	{
		return this.GetValue(TableUtils.PhoneNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's PropertyContacts_.PhoneNumber field.
	/// </summary>
	public string GetPhoneNumberFieldValue()
	{
		return this.GetValue(TableUtils.PhoneNumberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.PhoneNumber field.
	/// </summary>
	public void SetPhoneNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PhoneNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.PhoneNumber field.
	/// </summary>
	public void SetPhoneNumberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PhoneNumberColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyContacts_.PropertyContactID field.
	/// </summary>
	public Int32 PropertyContactID
	{
		get
		{
			return this.GetValue(TableUtils.PropertyContactIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PropertyContactIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PropertyContactIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PropertyContactIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.PropertyContactID field.
	/// </summary>
	public string PropertyContactIDDefault
	{
		get
		{
			return TableUtils.PropertyContactIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyContacts_.Title field.
	/// </summary>
	public string Title0
	{
		get
		{
			return this.GetValue(TableUtils.Title0Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.Title0Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool Title0Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.Title0Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.Title field.
	/// </summary>
	public string Title0Default
	{
		get
		{
			return TableUtils.Title0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyContacts_.FirstName field.
	/// </summary>
	public string FirstName
	{
		get
		{
			return this.GetValue(TableUtils.FirstNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirstNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirstNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirstNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.FirstName field.
	/// </summary>
	public string FirstNameDefault
	{
		get
		{
			return TableUtils.FirstNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyContacts_.LastName field.
	/// </summary>
	public string LastName
	{
		get
		{
			return this.GetValue(TableUtils.LastNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LastNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LastNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LastNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.LastName field.
	/// </summary>
	public string LastNameDefault
	{
		get
		{
			return TableUtils.LastNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyContacts_.Address1 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.Address1 field.
	/// </summary>
	public string Address1Default
	{
		get
		{
			return TableUtils.Address1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyContacts_.Address2 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.Address2 field.
	/// </summary>
	public string Address2Default
	{
		get
		{
			return TableUtils.Address2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyContacts_.Address3 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.Address3 field.
	/// </summary>
	public string Address3Default
	{
		get
		{
			return TableUtils.Address3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyContacts_.CityID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CityID field.
	/// </summary>
	public string CityIDDefault
	{
		get
		{
			return TableUtils.CityIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyContacts_.RegionID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.RegionID field.
	/// </summary>
	public string RegionIDDefault
	{
		get
		{
			return TableUtils.RegionIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyContacts_.CountryID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CountryID field.
	/// </summary>
	public string CountryIDDefault
	{
		get
		{
			return TableUtils.CountryIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyContacts_.PostCode field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.PostCode field.
	/// </summary>
	public string PostCodeDefault
	{
		get
		{
			return TableUtils.PostCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyContacts_.eMail field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.eMail field.
	/// </summary>
	public string eMailDefault
	{
		get
		{
			return TableUtils.eMailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyContacts_.PropertyID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.PropertyID field.
	/// </summary>
	public string PropertyIDDefault
	{
		get
		{
			return TableUtils.PropertyIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyContacts_.ContactTypeID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.ContactTypeID field.
	/// </summary>
	public string ContactTypeIDDefault
	{
		get
		{
			return TableUtils.ContactTypeIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyContacts_.CreatedBy field.
	/// </summary>
	public Int32 CreatedBy
	{
		get
		{
			return this.GetValue(TableUtils.CreatedByColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CreatedByColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CreatedBySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CreatedByColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CreatedBy field.
	/// </summary>
	public string CreatedByDefault
	{
		get
		{
			return TableUtils.CreatedByColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyContacts_.UpdatedBy field.
	/// </summary>
	public Int32 UpdatedBy
	{
		get
		{
			return this.GetValue(TableUtils.UpdatedByColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.UpdatedByColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool UpdatedBySpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.UpdatedByColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.UpdatedBy field.
	/// </summary>
	public string UpdatedByDefault
	{
		get
		{
			return TableUtils.UpdatedByColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyContacts_.CreatedOn field.
	/// </summary>
	public DateTime CreatedOn
	{
		get
		{
			return this.GetValue(TableUtils.CreatedOnColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.CreatedOnColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool CreatedOnSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.CreatedOnColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.CreatedOn field.
	/// </summary>
	public string CreatedOnDefault
	{
		get
		{
			return TableUtils.CreatedOnColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyContacts_.UpdatedOn field.
	/// </summary>
	public DateTime UpdatedOn
	{
		get
		{
			return this.GetValue(TableUtils.UpdatedOnColumn).ToDateTime();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.UpdatedOnColumn);
			
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool UpdatedOnSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.UpdatedOnColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.UpdatedOn field.
	/// </summary>
	public string UpdatedOnDefault
	{
		get
		{
			return TableUtils.UpdatedOnColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyContacts_.MobileNumber field.
	/// </summary>
	public string MobileNumber
	{
		get
		{
			return this.GetValue(TableUtils.MobileNumberColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.MobileNumberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool MobileNumberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.MobileNumberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.MobileNumber field.
	/// </summary>
	public string MobileNumberDefault
	{
		get
		{
			return TableUtils.MobileNumberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's PropertyContacts_.PhoneNumber field.
	/// </summary>
	public string PhoneNumber
	{
		get
		{
			return this.GetValue(TableUtils.PhoneNumberColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PhoneNumberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PhoneNumberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PhoneNumberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's PropertyContacts_.PhoneNumber field.
	/// </summary>
	public string PhoneNumberDefault
	{
		get
		{
			return TableUtils.PhoneNumberColumn.DefaultValue;
		}
	}


#endregion
}

}
