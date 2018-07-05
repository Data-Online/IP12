// This class is "generated" and will be overwritten.
// Your customizations should be made in VPropertiesPropertyContactsRecord.cs

using System;
using System.Collections;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IPv5.Business
{

/// <summary>
/// The generated superclass for the <see cref="VPropertiesPropertyContactsRecord"></see> class.
/// </summary>
/// <remarks>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, 
/// use the methods of the <see cref="VPropertiesPropertyContactsView"></see> class.
/// </remarks>
/// <seealso cref="VPropertiesPropertyContactsView"></seealso>
/// <seealso cref="VPropertiesPropertyContactsRecord"></seealso>
public class BaseVPropertiesPropertyContactsRecord : PrimaryKeyRecord
{

	public readonly static VPropertiesPropertyContactsView TableUtils = VPropertiesPropertyContactsView.Instance;

	// Constructors
 
	protected BaseVPropertiesPropertyContactsRecord() : base(TableUtils)
	{
		this.InsertingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.InsertingRecordEventHandler(this.VPropertiesPropertyContactsRecord_InsertingRecord); 
		this.UpdatingRecord += 
			new BaseClasses.IRecordWithTriggerEvents.UpdatingRecordEventHandler(this.VPropertiesPropertyContactsRecord_UpdatingRecord); 
		this.ReadRecord +=
            new BaseClasses.IRecordWithTriggerEvents.ReadRecordEventHandler(this.VPropertiesPropertyContactsRecord_ReadRecord); 
	}

	protected BaseVPropertiesPropertyContactsRecord(PrimaryKeyRecord record) : base(record, TableUtils)
	{
	}
	
	
	//Audit Trail methods
	
	//Evaluates Initialize when->Reading record formulas specified at the data access layer
    protected virtual void VPropertiesPropertyContactsRecord_ReadRecord(Object sender,System.EventArgs e)
    {
        //Apply Initialize->Reading record formula only if validation is successful.
                VPropertiesPropertyContactsRecord VPropertiesPropertyContactsRec = (VPropertiesPropertyContactsRecord)sender;
        if(VPropertiesPropertyContactsRec != null && !VPropertiesPropertyContactsRec.IsReadOnly ){
                }
    
    }
        
	//Evaluates Initialize when->Inserting formulas specified at the data access layer
    protected virtual void VPropertiesPropertyContactsRecord_InsertingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Inserting formula only if validation is successful.
                VPropertiesPropertyContactsRecord VPropertiesPropertyContactsRec = (VPropertiesPropertyContactsRecord)sender;
        Validate_Inserting();
        if(VPropertiesPropertyContactsRec != null && !VPropertiesPropertyContactsRec.IsReadOnly ){
                }
    
    }
    
    //Evaluates Initialize when->Updating formulas specified at the data access layer
    protected virtual void VPropertiesPropertyContactsRecord_UpdatingRecord(Object sender,System.ComponentModel.CancelEventArgs e)
    {
        //Apply Initialize->Updating formula only if validation is successful.
                VPropertiesPropertyContactsRecord VPropertiesPropertyContactsRec = (VPropertiesPropertyContactsRecord)sender;
        Validate_Updating();
        if(VPropertiesPropertyContactsRec != null && !VPropertiesPropertyContactsRec.IsReadOnly ){
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
	/// This is a convenience method that provides direct access to the value of the record's vPropertiesPropertyContacts_.Title field.
	/// </summary>
	public ColumnValue GetTitle0Value()
	{
		return this.GetValue(TableUtils.Title0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vPropertiesPropertyContacts_.Title field.
	/// </summary>
	public string GetTitle0FieldValue()
	{
		return this.GetValue(TableUtils.Title0Column).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.Title field.
	/// </summary>
	public void SetTitle0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.Title0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.Title field.
	/// </summary>
	public void SetTitle0FieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.Title0Column);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vPropertiesPropertyContacts_.FirstName field.
	/// </summary>
	public ColumnValue GetFirstNameValue()
	{
		return this.GetValue(TableUtils.FirstNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vPropertiesPropertyContacts_.FirstName field.
	/// </summary>
	public string GetFirstNameFieldValue()
	{
		return this.GetValue(TableUtils.FirstNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.FirstName field.
	/// </summary>
	public void SetFirstNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.FirstNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.FirstName field.
	/// </summary>
	public void SetFirstNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.FirstNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vPropertiesPropertyContacts_.LastName field.
	/// </summary>
	public ColumnValue GetLastNameValue()
	{
		return this.GetValue(TableUtils.LastNameColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vPropertiesPropertyContacts_.LastName field.
	/// </summary>
	public string GetLastNameFieldValue()
	{
		return this.GetValue(TableUtils.LastNameColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.LastName field.
	/// </summary>
	public void SetLastNameFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.LastNameColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.LastName field.
	/// </summary>
	public void SetLastNameFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.LastNameColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vPropertiesPropertyContacts_.eMail field.
	/// </summary>
	public ColumnValue GeteMailValue()
	{
		return this.GetValue(TableUtils.eMailColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vPropertiesPropertyContacts_.eMail field.
	/// </summary>
	public string GeteMailFieldValue()
	{
		return this.GetValue(TableUtils.eMailColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.eMail field.
	/// </summary>
	public void SeteMailFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.eMailColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.eMail field.
	/// </summary>
	public void SeteMailFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.eMailColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vPropertiesPropertyContacts_.MobileNumber field.
	/// </summary>
	public ColumnValue GetMobileNumberValue()
	{
		return this.GetValue(TableUtils.MobileNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vPropertiesPropertyContacts_.MobileNumber field.
	/// </summary>
	public string GetMobileNumberFieldValue()
	{
		return this.GetValue(TableUtils.MobileNumberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.MobileNumber field.
	/// </summary>
	public void SetMobileNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.MobileNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.MobileNumber field.
	/// </summary>
	public void SetMobileNumberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.MobileNumberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vPropertiesPropertyContacts_.PhoneNumber field.
	/// </summary>
	public ColumnValue GetPhoneNumberValue()
	{
		return this.GetValue(TableUtils.PhoneNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vPropertiesPropertyContacts_.PhoneNumber field.
	/// </summary>
	public string GetPhoneNumberFieldValue()
	{
		return this.GetValue(TableUtils.PhoneNumberColumn).ToString();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.PhoneNumber field.
	/// </summary>
	public void SetPhoneNumberFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PhoneNumberColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.PhoneNumber field.
	/// </summary>
	public void SetPhoneNumberFieldValue(string val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PhoneNumberColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vPropertiesPropertyContacts_.PropertyContactId field.
	/// </summary>
	public ColumnValue GetPropertyContactIdValue()
	{
		return this.GetValue(TableUtils.PropertyContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vPropertiesPropertyContacts_.PropertyContactId field.
	/// </summary>
	public Int32 GetPropertyContactIdFieldValue()
	{
		return this.GetValue(TableUtils.PropertyContactIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.PropertyContactId field.
	/// </summary>
	public void SetPropertyContactIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PropertyContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.PropertyContactId field.
	/// </summary>
	public void SetPropertyContactIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.PropertyContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.PropertyContactId field.
	/// </summary>
	public void SetPropertyContactIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.PropertyContactId field.
	/// </summary>
	public void SetPropertyContactIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyContactIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.PropertyContactId field.
	/// </summary>
	public void SetPropertyContactIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyContactIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vPropertiesPropertyContacts_.PropertyId field.
	/// </summary>
	public ColumnValue GetPropertyIdValue()
	{
		return this.GetValue(TableUtils.PropertyIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vPropertiesPropertyContacts_.PropertyId field.
	/// </summary>
	public Int32 GetPropertyIdFieldValue()
	{
		return this.GetValue(TableUtils.PropertyIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.PropertyId field.
	/// </summary>
	public void SetPropertyIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.PropertyIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.PropertyId field.
	/// </summary>
	public void SetPropertyIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.PropertyIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.PropertyId field.
	/// </summary>
	public void SetPropertyIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.PropertyId field.
	/// </summary>
	public void SetPropertyIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.PropertyId field.
	/// </summary>
	public void SetPropertyIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.PropertyIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vPropertiesPropertyContacts_.ContactTypeId field.
	/// </summary>
	public ColumnValue GetContactTypeIdValue()
	{
		return this.GetValue(TableUtils.ContactTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vPropertiesPropertyContacts_.ContactTypeId field.
	/// </summary>
	public Int32 GetContactTypeIdFieldValue()
	{
		return this.GetValue(TableUtils.ContactTypeIdColumn).ToInt32();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.ContactTypeId field.
	/// </summary>
	public void SetContactTypeIdFieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ContactTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.ContactTypeId field.
	/// </summary>
	public void SetContactTypeIdFieldValue(string val)
	{
		this.SetString(val, TableUtils.ContactTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.ContactTypeId field.
	/// </summary>
	public void SetContactTypeIdFieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.ContactTypeId field.
	/// </summary>
	public void SetContactTypeIdFieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactTypeIdColumn);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.ContactTypeId field.
	/// </summary>
	public void SetContactTypeIdFieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ContactTypeIdColumn);
	}
	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vPropertiesPropertyContacts_.ID field.
	/// </summary>
	public ColumnValue GetID0Value()
	{
		return this.GetValue(TableUtils.ID0Column);
	}

	/// <summary>
	/// This is a convenience method that provides direct access to the value of the record's vPropertiesPropertyContacts_.ID field.
	/// </summary>
	public Int64 GetID0FieldValue()
	{
		return this.GetValue(TableUtils.ID0Column).ToInt64();
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.ID field.
	/// </summary>
	public void SetID0FieldValue(ColumnValue val)
	{
		this.SetValue(val, TableUtils.ID0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.ID field.
	/// </summary>
	public void SetID0FieldValue(string val)
	{
		this.SetString(val, TableUtils.ID0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.ID field.
	/// </summary>
	public void SetID0FieldValue(double val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ID0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.ID field.
	/// </summary>
	public void SetID0FieldValue(decimal val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ID0Column);
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.ID field.
	/// </summary>
	public void SetID0FieldValue(long val)
	{
		ColumnValue cv = new ColumnValue(val);
		this.SetValue(cv, TableUtils.ID0Column);
	}


#endregion

#region "Convenience methods to get field names"

	/// <summary>
	/// This is a property that provides direct access to the value of the record's vPropertiesPropertyContacts_.Title field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.Title field.
	/// </summary>
	public string Title0Default
	{
		get
		{
			return TableUtils.Title0Column.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vPropertiesPropertyContacts_.FirstName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.FirstName field.
	/// </summary>
	public string FirstNameDefault
	{
		get
		{
			return TableUtils.FirstNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vPropertiesPropertyContacts_.LastName field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.LastName field.
	/// </summary>
	public string LastNameDefault
	{
		get
		{
			return TableUtils.LastNameColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vPropertiesPropertyContacts_.eMail field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.eMail field.
	/// </summary>
	public string eMailDefault
	{
		get
		{
			return TableUtils.eMailColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vPropertiesPropertyContacts_.MobileNumber field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.MobileNumber field.
	/// </summary>
	public string MobileNumberDefault
	{
		get
		{
			return TableUtils.MobileNumberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vPropertiesPropertyContacts_.PhoneNumber field.
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
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.PhoneNumber field.
	/// </summary>
	public string PhoneNumberDefault
	{
		get
		{
			return TableUtils.PhoneNumberColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vPropertiesPropertyContacts_.PropertyContactId field.
	/// </summary>
	public Int32 PropertyContactId
	{
		get
		{
			return this.GetValue(TableUtils.PropertyContactIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PropertyContactIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PropertyContactIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PropertyContactIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.PropertyContactId field.
	/// </summary>
	public string PropertyContactIdDefault
	{
		get
		{
			return TableUtils.PropertyContactIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vPropertiesPropertyContacts_.PropertyId field.
	/// </summary>
	public Int32 PropertyId
	{
		get
		{
			return this.GetValue(TableUtils.PropertyIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.PropertyIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool PropertyIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.PropertyIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.PropertyId field.
	/// </summary>
	public string PropertyIdDefault
	{
		get
		{
			return TableUtils.PropertyIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vPropertiesPropertyContacts_.ContactTypeId field.
	/// </summary>
	public Int32 ContactTypeId
	{
		get
		{
			return this.GetValue(TableUtils.ContactTypeIdColumn).ToInt32();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ContactTypeIdColumn);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ContactTypeIdSpecified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ContactTypeIdColumn);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.ContactTypeId field.
	/// </summary>
	public string ContactTypeIdDefault
	{
		get
		{
			return TableUtils.ContactTypeIdColumn.DefaultValue;
		}
	}
	/// <summary>
	/// This is a property that provides direct access to the value of the record's vPropertiesPropertyContacts_.ID field.
	/// </summary>
	public Int64 ID0
	{
		get
		{
			return this.GetValue(TableUtils.ID0Column).ToInt64();
		}
		set
		{
			ColumnValue cv = new ColumnValue(value);
			this.SetValue(cv, TableUtils.ID0Column);
		}
	}


	/// <summary>
	/// This is a convenience method that can be used to determine that the column is set.
	/// </summary>
	public bool ID0Specified
	{
		get
		{
			ColumnValue val = this.GetValue(TableUtils.ID0Column);
            if (val == null || val.IsNull)
            {
                return false;
            }
            return true;
		}
	}

	/// <summary>
	/// This is a convenience method that allows direct modification of the value of the record's vPropertiesPropertyContacts_.ID field.
	/// </summary>
	public string ID0Default
	{
		get
		{
			return TableUtils.ID0Column.DefaultValue;
		}
	}


#endregion
}

}
