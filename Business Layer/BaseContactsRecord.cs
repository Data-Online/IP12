// This class is "generated" and will be overwritten.
// Your customizations should be made in ContactsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IPv5.Business
{

/// <summary>
/// The generated superclass for the <see cref="ContactsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="ContactsTable"></see> class.
/// </remarks>
/// <seealso cref="ContactsTable"></seealso>
/// <seealso cref="ContactsRecord"></seealso>
public class BaseContactsRecord : PrimaryKeyRecord
{

	public readonly static ContactsTable TableUtils = ContactsTable.Instance;

	// Constructors
 
	protected BaseContactsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.ContactsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.ContactsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.ContactsRecord_ReadRecord); 
	}

	protected BaseContactsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void ContactsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                ContactsRecord ContactsRec = (ContactsRecord)sender;
        if(ContactsRec != null && !ContactsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void ContactsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                ContactsRecord ContactsRec = (ContactsRecord)sender;
        Validate_Inserting();
        if(ContactsRec != null && !ContactsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void ContactsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                ContactsRecord ContactsRec = (ContactsRecord)sender;
        Validate_Updating();
        if(ContactsRec != null && !ContactsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.ContactID field.
	/// </summary>
	public ColumnValue GetContactIDValue()
	{
		return this.GetValue(TableUtils.ContactIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.ContactID field.
	/// </summary>
	public Int32 GetContactIDFieldValue()
	{
		return this.GetValue(TableUtils.ContactIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.Title field.
	/// </summary>
	public ColumnValue GetTitle0Value()
	{
		return this.GetValue(TableUtils.Title0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.Title field.
	/// </summary>
	public string GetTitle0FieldValue()
	{
		return this.GetValue(TableUtils.Title0Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Title field.
	/// </summary>
	public void SetTitle0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Title0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Title field.
	/// </summary>
	public void SetTitle0FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Title0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.FirstName field.
	/// </summary>
	public ColumnValue GetFirstNameValue()
	{
		return this.GetValue(TableUtils.FirstNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.FirstName field.
	/// </summary>
	public string GetFirstNameFieldValue()
	{
		return this.GetValue(TableUtils.FirstNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.FirstName field.
	/// </summary>
	public void SetFirstNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirstNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.FirstName field.
	/// </summary>
	public void SetFirstNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirstNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.LastName field.
	/// </summary>
	public ColumnValue GetLastNameValue()
	{
		return this.GetValue(TableUtils.LastNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.LastName field.
	/// </summary>
	public string GetLastNameFieldValue()
	{
		return this.GetValue(TableUtils.LastNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.LastName field.
	/// </summary>
	public void SetLastNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LastNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.LastName field.
	/// </summary>
	public void SetLastNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LastNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.eMail field.
	/// </summary>
	public ColumnValue GeteMailValue()
	{
		return this.GetValue(TableUtils.eMailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.eMail field.
	/// </summary>
	public string GeteMailFieldValue()
	{
		return this.GetValue(TableUtils.eMailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.eMail field.
	/// </summary>
	public void SeteMailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.eMailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.eMail field.
	/// </summary>
	public void SeteMailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.eMailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.Address1 field.
	/// </summary>
	public ColumnValue GetAddress1Value()
	{
		return this.GetValue(TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.Address1 field.
	/// </summary>
	public string GetAddress1FieldValue()
	{
		return this.GetValue(TableUtils.Address1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.Address2 field.
	/// </summary>
	public ColumnValue GetAddress2Value()
	{
		return this.GetValue(TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.Address2 field.
	/// </summary>
	public string GetAddress2FieldValue()
	{
		return this.GetValue(TableUtils.Address2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.Address3 field.
	/// </summary>
	public ColumnValue GetAddress3Value()
	{
		return this.GetValue(TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.Address3 field.
	/// </summary>
	public string GetAddress3FieldValue()
	{
		return this.GetValue(TableUtils.Address3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.CityID field.
	/// </summary>
	public ColumnValue GetCityIDValue()
	{
		return this.GetValue(TableUtils.CityIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.CityID field.
	/// </summary>
	public Int32 GetCityIDFieldValue()
	{
		return this.GetValue(TableUtils.CityIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.CityID field.
	/// </summary>
	public void SetCityIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CityIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.CityID field.
	/// </summary>
	public void SetCityIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.CityIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.CityID field.
	/// </summary>
	public void SetCityIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.CityID field.
	/// </summary>
	public void SetCityIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.CityID field.
	/// </summary>
	public void SetCityIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.RegionID field.
	/// </summary>
	public ColumnValue GetRegionIDValue()
	{
		return this.GetValue(TableUtils.RegionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.RegionID field.
	/// </summary>
	public Int32 GetRegionIDFieldValue()
	{
		return this.GetValue(TableUtils.RegionIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.RegionID field.
	/// </summary>
	public void SetRegionIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RegionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.RegionID field.
	/// </summary>
	public void SetRegionIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.RegionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.RegionID field.
	/// </summary>
	public void SetRegionIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.RegionID field.
	/// </summary>
	public void SetRegionIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegionIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.RegionID field.
	/// </summary>
	public void SetRegionIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegionIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.PostCode field.
	/// </summary>
	public ColumnValue GetPostCodeValue()
	{
		return this.GetValue(TableUtils.PostCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.PostCode field.
	/// </summary>
	public string GetPostCodeFieldValue()
	{
		return this.GetValue(TableUtils.PostCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PostCode field.
	/// </summary>
	public void SetPostCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PostCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PostCode field.
	/// </summary>
	public void SetPostCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PostCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.CountryID field.
	/// </summary>
	public ColumnValue GetCountryIDValue()
	{
		return this.GetValue(TableUtils.CountryIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.CountryID field.
	/// </summary>
	public Int32 GetCountryIDFieldValue()
	{
		return this.GetValue(TableUtils.CountryIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.CountryID field.
	/// </summary>
	public void SetCountryIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CountryIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.CountryID field.
	/// </summary>
	public void SetCountryIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.CountryIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.CountryID field.
	/// </summary>
	public void SetCountryIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CountryIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.CountryID field.
	/// </summary>
	public void SetCountryIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CountryIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.CountryID field.
	/// </summary>
	public void SetCountryIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CountryIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.TrustName field.
	/// </summary>
	public ColumnValue GetTrustNameValue()
	{
		return this.GetValue(TableUtils.TrustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.TrustName field.
	/// </summary>
	public string GetTrustNameFieldValue()
	{
		return this.GetValue(TableUtils.TrustNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.TrustName field.
	/// </summary>
	public void SetTrustNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TrustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.TrustName field.
	/// </summary>
	public void SetTrustNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TrustNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.IrdNumber field.
	/// </summary>
	public ColumnValue GetIrdNumberValue()
	{
		return this.GetValue(TableUtils.IrdNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.IrdNumber field.
	/// </summary>
	public string GetIrdNumberFieldValue()
	{
		return this.GetValue(TableUtils.IrdNumberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.IrdNumber field.
	/// </summary>
	public void SetIrdNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IrdNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.IrdNumber field.
	/// </summary>
	public void SetIrdNumberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IrdNumberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.Active field.
	/// </summary>
	public ColumnValue GetActiveValue()
	{
		return this.GetValue(TableUtils.ActiveColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.Active field.
	/// </summary>
	public bool GetActiveFieldValue()
	{
		return this.GetValue(TableUtils.ActiveColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Active field.
	/// </summary>
	public void SetActiveFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ActiveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Active field.
	/// </summary>
	public void SetActiveFieldValue(string val)
	{
		this.SetString(val, TableUtils.ActiveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Active field.
	/// </summary>
	public void SetActiveFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ActiveColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.PhoneNumber field.
	/// </summary>
	public ColumnValue GetPhoneNumberValue()
	{
		return this.GetValue(TableUtils.PhoneNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.PhoneNumber field.
	/// </summary>
	public string GetPhoneNumberFieldValue()
	{
		return this.GetValue(TableUtils.PhoneNumberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PhoneNumber field.
	/// </summary>
	public void SetPhoneNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PhoneNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PhoneNumber field.
	/// </summary>
	public void SetPhoneNumberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PhoneNumberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.FirstName2 field.
	/// </summary>
	public ColumnValue GetFirstName2Value()
	{
		return this.GetValue(TableUtils.FirstName2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.FirstName2 field.
	/// </summary>
	public string GetFirstName2FieldValue()
	{
		return this.GetValue(TableUtils.FirstName2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.FirstName2 field.
	/// </summary>
	public void SetFirstName2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirstName2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.FirstName2 field.
	/// </summary>
	public void SetFirstName2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirstName2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.LastName2 field.
	/// </summary>
	public ColumnValue GetLastName2Value()
	{
		return this.GetValue(TableUtils.LastName2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.LastName2 field.
	/// </summary>
	public string GetLastName2FieldValue()
	{
		return this.GetValue(TableUtils.LastName2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.LastName2 field.
	/// </summary>
	public void SetLastName2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LastName2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.LastName2 field.
	/// </summary>
	public void SetLastName2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LastName2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.BankAccount field.
	/// </summary>
	public ColumnValue GetBankAccountValue()
	{
		return this.GetValue(TableUtils.BankAccountColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's Contacts_.BankAccount field.
	/// </summary>
	public string GetBankAccountFieldValue()
	{
		return this.GetValue(TableUtils.BankAccountColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.BankAccount field.
	/// </summary>
	public void SetBankAccountFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BankAccountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.BankAccount field.
	/// </summary>
	public void SetBankAccountFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BankAccountColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.ContactID field.
	/// </summary>
	public Int32 ContactID
	{
		get
		{
			return this.GetValue(TableUtils.ContactIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ContactIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ContactIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ContactIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.ContactID field.
	/// </summary>
	public string ContactIDDefault
	{
		get
		{
			return TableUtils.ContactIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.Title field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Title field.
	/// </summary>
	public string Title0Default
	{
		get
		{
			return TableUtils.Title0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.FirstName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.FirstName field.
	/// </summary>
	public string FirstNameDefault
	{
		get
		{
			return TableUtils.FirstNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.LastName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.LastName field.
	/// </summary>
	public string LastNameDefault
	{
		get
		{
			return TableUtils.LastNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.eMail field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.eMail field.
	/// </summary>
	public string eMailDefault
	{
		get
		{
			return TableUtils.eMailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.Address1 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Address1 field.
	/// </summary>
	public string Address1Default
	{
		get
		{
			return TableUtils.Address1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.Address2 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Address2 field.
	/// </summary>
	public string Address2Default
	{
		get
		{
			return TableUtils.Address2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.Address3 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Address3 field.
	/// </summary>
	public string Address3Default
	{
		get
		{
			return TableUtils.Address3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.CityID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.CityID field.
	/// </summary>
	public string CityIDDefault
	{
		get
		{
			return TableUtils.CityIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.RegionID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.RegionID field.
	/// </summary>
	public string RegionIDDefault
	{
		get
		{
			return TableUtils.RegionIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.PostCode field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PostCode field.
	/// </summary>
	public string PostCodeDefault
	{
		get
		{
			return TableUtils.PostCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.CountryID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.CountryID field.
	/// </summary>
	public string CountryIDDefault
	{
		get
		{
			return TableUtils.CountryIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.TrustName field.
	/// </summary>
	public string TrustName
	{
		get
		{
			return this.GetValue(TableUtils.TrustNameColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.TrustNameColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool TrustNameSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.TrustNameColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.TrustName field.
	/// </summary>
	public string TrustNameDefault
	{
		get
		{
			return TableUtils.TrustNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.IrdNumber field.
	/// </summary>
	public string IrdNumber
	{
		get
		{
			return this.GetValue(TableUtils.IrdNumberColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.IrdNumberColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool IrdNumberSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.IrdNumberColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.IrdNumber field.
	/// </summary>
	public string IrdNumberDefault
	{
		get
		{
			return TableUtils.IrdNumberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.Active field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.Active field.
	/// </summary>
	public string ActiveDefault
	{
		get
		{
			return TableUtils.ActiveColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.PhoneNumber field.
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
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.PhoneNumber field.
	/// </summary>
	public string PhoneNumberDefault
	{
		get
		{
			return TableUtils.PhoneNumberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.FirstName2 field.
	/// </summary>
	public string FirstName2
	{
		get
		{
			return this.GetValue(TableUtils.FirstName2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.FirstName2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool FirstName2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.FirstName2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.FirstName2 field.
	/// </summary>
	public string FirstName2Default
	{
		get
		{
			return TableUtils.FirstName2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.LastName2 field.
	/// </summary>
	public string LastName2
	{
		get
		{
			return this.GetValue(TableUtils.LastName2Column).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LastName2Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LastName2Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LastName2Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.LastName2 field.
	/// </summary>
	public string LastName2Default
	{
		get
		{
			return TableUtils.LastName2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's Contacts_.BankAccount field.
	/// </summary>
	public string BankAccount
	{
		get
		{
			return this.GetValue(TableUtils.BankAccountColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.BankAccountColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool BankAccountSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.BankAccountColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's Contacts_.BankAccount field.
	/// </summary>
	public string BankAccountDefault
	{
		get
		{
			return TableUtils.BankAccountColumn.DefaultValue;
		}
	}


#endregion
}

}
