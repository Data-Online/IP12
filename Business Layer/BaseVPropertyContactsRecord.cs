// This class is "generated" and will be overwritten.
// Your customizations should be made in VPropertyContactsRecord.vb

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IPv5.Business
{

/// <summary>
/// The generated superclass for the <see cref="VPropertyContactsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="VPropertyContactsView"></see> class.
/// </remarks>
/// <seealso cref="VPropertyContactsView"></seealso>
/// <seealso cref="VPropertyContactsRecord"></seealso>
public class BaseVPropertyContactsRecord : KeylessRecord
{

	public readonly static VPropertyContactsView TableUtils = VPropertyContactsView.Instance;

	// Constructors
 
	protected BaseVPropertyContactsRecord() : base(TableUtils)
	{
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.VPropertyContactsRecord_ReadRecord); 
        this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.VPropertyContactsRecord_InsertingRecord);     
	}

	protected BaseVPropertyContactsRecord(KeylessRecord record) : base(record, TableUtils)
	{
	}
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void VPropertyContactsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                VPropertyContactsRecord VPropertyContactsRec = (VPropertyContactsRecord)sender;
        if(VPropertyContactsRec != null && !VPropertyContactsRec.IsReadOnly ){
                }
    
    }
    
    	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void VPropertyContactsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                VPropertyContactsRecord VPropertyContactsRec = (VPropertyContactsRecord)sender;
        Validate_Inserting();
        if(VPropertyContactsRec != null && !VPropertyContactsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.PropertyID field.
	/// </summary>
	public ColumnValue GetPropertyIDValue()
	{
		return this.GetValue(TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.PropertyID field.
	/// </summary>
	public Int32 GetPropertyIDFieldValue()
	{
		return this.GetValue(TableUtils.PropertyIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.PropertyID field.
	/// </summary>
	public void SetPropertyIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.Title field.
	/// </summary>
	public ColumnValue GetTitle0Value()
	{
		return this.GetValue(TableUtils.Title0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.Title field.
	/// </summary>
	public string GetTitle0FieldValue()
	{
		return this.GetValue(TableUtils.Title0Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Title field.
	/// </summary>
	public void SetTitle0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Title0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Title field.
	/// </summary>
	public void SetTitle0FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Title0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.FirstName field.
	/// </summary>
	public ColumnValue GetFirstNameValue()
	{
		return this.GetValue(TableUtils.FirstNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.FirstName field.
	/// </summary>
	public string GetFirstNameFieldValue()
	{
		return this.GetValue(TableUtils.FirstNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.FirstName field.
	/// </summary>
	public void SetFirstNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirstNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.FirstName field.
	/// </summary>
	public void SetFirstNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirstNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.LastName field.
	/// </summary>
	public ColumnValue GetLastNameValue()
	{
		return this.GetValue(TableUtils.LastNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.LastName field.
	/// </summary>
	public string GetLastNameFieldValue()
	{
		return this.GetValue(TableUtils.LastNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.LastName field.
	/// </summary>
	public void SetLastNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LastNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.LastName field.
	/// </summary>
	public void SetLastNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LastNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.Address1 field.
	/// </summary>
	public ColumnValue GetAddress1Value()
	{
		return this.GetValue(TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.Address1 field.
	/// </summary>
	public string GetAddress1FieldValue()
	{
		return this.GetValue(TableUtils.Address1Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address1Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Address1 field.
	/// </summary>
	public void SetAddress1FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address1Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.Address2 field.
	/// </summary>
	public ColumnValue GetAddress2Value()
	{
		return this.GetValue(TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.Address2 field.
	/// </summary>
	public string GetAddress2FieldValue()
	{
		return this.GetValue(TableUtils.Address2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Address2 field.
	/// </summary>
	public void SetAddress2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.Address3 field.
	/// </summary>
	public ColumnValue GetAddress3Value()
	{
		return this.GetValue(TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.Address3 field.
	/// </summary>
	public string GetAddress3FieldValue()
	{
		return this.GetValue(TableUtils.Address3Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Address3Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Address3 field.
	/// </summary>
	public void SetAddress3FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Address3Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.PostCode field.
	/// </summary>
	public ColumnValue GetPostCodeValue()
	{
		return this.GetValue(TableUtils.PostCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.PostCode field.
	/// </summary>
	public string GetPostCodeFieldValue()
	{
		return this.GetValue(TableUtils.PostCodeColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.PostCode field.
	/// </summary>
	public void SetPostCodeFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PostCodeColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.PostCode field.
	/// </summary>
	public void SetPostCodeFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PostCodeColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.TrustName field.
	/// </summary>
	public ColumnValue GetTrustNameValue()
	{
		return this.GetValue(TableUtils.TrustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.TrustName field.
	/// </summary>
	public string GetTrustNameFieldValue()
	{
		return this.GetValue(TableUtils.TrustNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.TrustName field.
	/// </summary>
	public void SetTrustNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.TrustNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.TrustName field.
	/// </summary>
	public void SetTrustNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.TrustNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.eMail field.
	/// </summary>
	public ColumnValue GeteMailValue()
	{
		return this.GetValue(TableUtils.eMailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.eMail field.
	/// </summary>
	public string GeteMailFieldValue()
	{
		return this.GetValue(TableUtils.eMailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.eMail field.
	/// </summary>
	public void SeteMailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.eMailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.eMail field.
	/// </summary>
	public void SeteMailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.eMailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.IrdNumber field.
	/// </summary>
	public ColumnValue GetIrdNumberValue()
	{
		return this.GetValue(TableUtils.IrdNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.IrdNumber field.
	/// </summary>
	public string GetIrdNumberFieldValue()
	{
		return this.GetValue(TableUtils.IrdNumberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.IrdNumber field.
	/// </summary>
	public void SetIrdNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.IrdNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.IrdNumber field.
	/// </summary>
	public void SetIrdNumberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.IrdNumberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.Active field.
	/// </summary>
	public ColumnValue GetActiveValue()
	{
		return this.GetValue(TableUtils.ActiveColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.Active field.
	/// </summary>
	public bool GetActiveFieldValue()
	{
		return this.GetValue(TableUtils.ActiveColumn).ToBoolean();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Active field.
	/// </summary>
	public void SetActiveFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ActiveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Active field.
	/// </summary>
	public void SetActiveFieldValue(string val)
	{
		this.SetString(val, TableUtils.ActiveColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Active field.
	/// </summary>
	public void SetActiveFieldValue(bool val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ActiveColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.PhoneNumber field.
	/// </summary>
	public ColumnValue GetPhoneNumberValue()
	{
		return this.GetValue(TableUtils.PhoneNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.PhoneNumber field.
	/// </summary>
	public string GetPhoneNumberFieldValue()
	{
		return this.GetValue(TableUtils.PhoneNumberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.PhoneNumber field.
	/// </summary>
	public void SetPhoneNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PhoneNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.PhoneNumber field.
	/// </summary>
	public void SetPhoneNumberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PhoneNumberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.FirstName2 field.
	/// </summary>
	public ColumnValue GetFirstName2Value()
	{
		return this.GetValue(TableUtils.FirstName2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.FirstName2 field.
	/// </summary>
	public string GetFirstName2FieldValue()
	{
		return this.GetValue(TableUtils.FirstName2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.FirstName2 field.
	/// </summary>
	public void SetFirstName2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirstName2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.FirstName2 field.
	/// </summary>
	public void SetFirstName2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirstName2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.LastName2 field.
	/// </summary>
	public ColumnValue GetLastName2Value()
	{
		return this.GetValue(TableUtils.LastName2Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.LastName2 field.
	/// </summary>
	public string GetLastName2FieldValue()
	{
		return this.GetValue(TableUtils.LastName2Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.LastName2 field.
	/// </summary>
	public void SetLastName2FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LastName2Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.LastName2 field.
	/// </summary>
	public void SetLastName2FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LastName2Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.Region field.
	/// </summary>
	public ColumnValue GetRegionValue()
	{
		return this.GetValue(TableUtils.RegionColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.Region field.
	/// </summary>
	public string GetRegionFieldValue()
	{
		return this.GetValue(TableUtils.RegionColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Region field.
	/// </summary>
	public void SetRegionFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.RegionColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Region field.
	/// </summary>
	public void SetRegionFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.RegionColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.City field.
	/// </summary>
	public ColumnValue GetCityValue()
	{
		return this.GetValue(TableUtils.CityColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.City field.
	/// </summary>
	public string GetCityFieldValue()
	{
		return this.GetValue(TableUtils.CityColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.City field.
	/// </summary>
	public void SetCityFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CityColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.City field.
	/// </summary>
	public void SetCityFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CityColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.Country field.
	/// </summary>
	public ColumnValue GetCountryValue()
	{
		return this.GetValue(TableUtils.CountryColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.Country field.
	/// </summary>
	public string GetCountryFieldValue()
	{
		return this.GetValue(TableUtils.CountryColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Country field.
	/// </summary>
	public void SetCountryFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.CountryColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Country field.
	/// </summary>
	public void SetCountryFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.CountryColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.LinkID field.
	/// </summary>
	public ColumnValue GetLinkIDValue()
	{
		return this.GetValue(TableUtils.LinkIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.LinkID field.
	/// </summary>
	public Int32 GetLinkIDFieldValue()
	{
		return this.GetValue(TableUtils.LinkIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.LinkID field.
	/// </summary>
	public void SetLinkIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LinkIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.LinkID field.
	/// </summary>
	public void SetLinkIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.LinkIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.LinkID field.
	/// </summary>
	public void SetLinkIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LinkIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.LinkID field.
	/// </summary>
	public void SetLinkIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LinkIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.LinkID field.
	/// </summary>
	public void SetLinkIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LinkIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.ContactID field.
	/// </summary>
	public ColumnValue GetContactIDValue()
	{
		return this.GetValue(TableUtils.ContactIDColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.ContactID field.
	/// </summary>
	public Int32 GetContactIDFieldValue()
	{
		return this.GetValue(TableUtils.ContactIDColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.ContactID field.
	/// </summary>
	public void SetContactIDFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ContactIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.ContactID field.
	/// </summary>
	public void SetContactIDFieldValue(string val)
	{
		this.SetString(val, TableUtils.ContactIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.ContactID field.
	/// </summary>
	public void SetContactIDFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.ContactID field.
	/// </summary>
	public void SetContactIDFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactIDColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.ContactID field.
	/// </summary>
	public void SetContactIDFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactIDColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.BankAccount field.
	/// </summary>
	public ColumnValue GetBankAccountValue()
	{
		return this.GetValue(TableUtils.BankAccountColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's VPropertyContacts_.BankAccount field.
	/// </summary>
	public string GetBankAccountFieldValue()
	{
		return this.GetValue(TableUtils.BankAccountColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.BankAccount field.
	/// </summary>
	public void SetBankAccountFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.BankAccountColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.BankAccount field.
	/// </summary>
	public void SetBankAccountFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.BankAccountColumn);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyContacts_.PropertyID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.PropertyID field.
	/// </summary>
	public string PropertyIDDefault
	{
		get
		{
			return TableUtils.PropertyIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyContacts_.Title field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Title field.
	/// </summary>
	public string Title0Default
	{
		get
		{
			return TableUtils.Title0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyContacts_.FirstName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.FirstName field.
	/// </summary>
	public string FirstNameDefault
	{
		get
		{
			return TableUtils.FirstNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyContacts_.LastName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.LastName field.
	/// </summary>
	public string LastNameDefault
	{
		get
		{
			return TableUtils.LastNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyContacts_.Address1 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Address1 field.
	/// </summary>
	public string Address1Default
	{
		get
		{
			return TableUtils.Address1Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyContacts_.Address2 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Address2 field.
	/// </summary>
	public string Address2Default
	{
		get
		{
			return TableUtils.Address2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyContacts_.Address3 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Address3 field.
	/// </summary>
	public string Address3Default
	{
		get
		{
			return TableUtils.Address3Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyContacts_.PostCode field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.PostCode field.
	/// </summary>
	public string PostCodeDefault
	{
		get
		{
			return TableUtils.PostCodeColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyContacts_.TrustName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.TrustName field.
	/// </summary>
	public string TrustNameDefault
	{
		get
		{
			return TableUtils.TrustNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyContacts_.eMail field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.eMail field.
	/// </summary>
	public string eMailDefault
	{
		get
		{
			return TableUtils.eMailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyContacts_.IrdNumber field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.IrdNumber field.
	/// </summary>
	public string IrdNumberDefault
	{
		get
		{
			return TableUtils.IrdNumberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyContacts_.Active field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Active field.
	/// </summary>
	public string ActiveDefault
	{
		get
		{
			return TableUtils.ActiveColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyContacts_.PhoneNumber field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.PhoneNumber field.
	/// </summary>
	public string PhoneNumberDefault
	{
		get
		{
			return TableUtils.PhoneNumberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyContacts_.FirstName2 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.FirstName2 field.
	/// </summary>
	public string FirstName2Default
	{
		get
		{
			return TableUtils.FirstName2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyContacts_.LastName2 field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.LastName2 field.
	/// </summary>
	public string LastName2Default
	{
		get
		{
			return TableUtils.LastName2Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyContacts_.Region field.
	/// </summary>
	public string Region
	{
		get
		{
			return this.GetValue(TableUtils.RegionColumn).ToString();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.RegionColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool RegionSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.RegionColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Region field.
	/// </summary>
	public string RegionDefault
	{
		get
		{
			return TableUtils.RegionColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyContacts_.City field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.City field.
	/// </summary>
	public string CityDefault
	{
		get
		{
			return TableUtils.CityColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyContacts_.Country field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.Country field.
	/// </summary>
	public string CountryDefault
	{
		get
		{
			return TableUtils.CountryColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyContacts_.LinkID field.
	/// </summary>
	public Int32 LinkID
	{
		get
		{
			return this.GetValue(TableUtils.LinkIDColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.LinkIDColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool LinkIDSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.LinkIDColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.LinkID field.
	/// </summary>
	public string LinkIDDefault
	{
		get
		{
			return TableUtils.LinkIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyContacts_.ContactID field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.ContactID field.
	/// </summary>
	public string ContactIDDefault
	{
		get
		{
			return TableUtils.ContactIDColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's VPropertyContacts_.BankAccount field.
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
	/// This is a convenience method that allows direct modification of the value of the record's VPropertyContacts_.BankAccount field.
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
