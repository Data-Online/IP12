// This class is "generated" and will be overwritten.
// Your customizations should be made in VPropertyContactsView.cs

using System;
using System.Data;
using System.Collections;
using System.Runtime;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;
using IPv5.Data;

namespace IPv5.Business
{

/// <summary>
/// The generated superclass for the <see cref="VPropertyContactsView"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseMM_IP1%dbo.vPropertyContacts.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="VPropertyContactsView.Instance">VPropertyContactsView.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="VPropertyContactsView"></seealso>
[SerializableAttribute()]
public class BaseVPropertyContactsView : KeylessTable
{

	private readonly string TableDefinitionString = VPropertyContactsDefinition.GetXMLString();







	protected BaseVPropertyContactsView()
	{
		this.Initialize();
	}

	protected virtual void Initialize()
	{
		XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
		this.TableDefinition = new TableDefinition();
		this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("IPv5.Business", "IPv5.Business.VPropertyContactsView");
		def.InitializeTableDefinition(this.TableDefinition);
		this.ConnectionName = def.GetConnectionName();
		this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("IPv5.Business", "IPv5.Business.VPropertyContactsRecord");
		this.ApplicationName = "IPv5";
		this.DataAdapter = new VPropertyContactsSqlView();
		((VPropertyContactsSqlView)this.DataAdapter).ConnectionName = this.ConnectionName;
		
		this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        PropertyIDColumn.CodeName = "PropertyID";
        Title0Column.CodeName = "Title0";
        FirstNameColumn.CodeName = "FirstName";
        LastNameColumn.CodeName = "LastName";
        Address1Column.CodeName = "Address1";
        Address2Column.CodeName = "Address2";
        Address3Column.CodeName = "Address3";
        PostCodeColumn.CodeName = "PostCode";
        TrustNameColumn.CodeName = "TrustName";
        eMailColumn.CodeName = "eMail";
        IrdNumberColumn.CodeName = "IrdNumber";
        ActiveColumn.CodeName = "Active";
        PhoneNumberColumn.CodeName = "PhoneNumber";
        FirstName2Column.CodeName = "FirstName2";
        LastName2Column.CodeName = "LastName2";
        RegionColumn.CodeName = "Region";
        CityColumn.CodeName = "City";
        CountryColumn.CodeName = "Country";
        LinkIDColumn.CodeName = "LinkID";
        ContactIDColumn.CodeName = "ContactID";
        BankAccountColumn.CodeName = "BankAccount";
		
	}

#region "Overriden methods"
    
#endregion

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.PropertyID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn PropertyIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.PropertyID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn PropertyID
    {
        get
        {
            return VPropertyContactsView.Instance.PropertyIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.Title column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Title0Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.Title column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Title0
    {
        get
        {
            return VPropertyContactsView.Instance.Title0Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.FirstName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn FirstNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.FirstName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn FirstName
    {
        get
        {
            return VPropertyContactsView.Instance.FirstNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.LastName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn LastNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.LastName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn LastName
    {
        get
        {
            return VPropertyContactsView.Instance.LastNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.Address1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.Address1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address1
    {
        get
        {
            return VPropertyContactsView.Instance.Address1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.Address2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.Address2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address2
    {
        get
        {
            return VPropertyContactsView.Instance.Address2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.Address3 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address3Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.Address3 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address3
    {
        get
        {
            return VPropertyContactsView.Instance.Address3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.PostCode column object.
    /// </summary>
    public BaseClasses.Data.StringColumn PostCodeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.PostCode column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn PostCode
    {
        get
        {
            return VPropertyContactsView.Instance.PostCodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.TrustName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn TrustNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.TrustName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn TrustName
    {
        get
        {
            return VPropertyContactsView.Instance.TrustNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.eMail column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn eMailColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.eMail column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn eMail
    {
        get
        {
            return VPropertyContactsView.Instance.eMailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.IrdNumber column object.
    /// </summary>
    public BaseClasses.Data.StringColumn IrdNumberColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.IrdNumber column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn IrdNumber
    {
        get
        {
            return VPropertyContactsView.Instance.IrdNumberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.Active column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ActiveColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.Active column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn Active
    {
        get
        {
            return VPropertyContactsView.Instance.ActiveColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.PhoneNumber column object.
    /// </summary>
    public BaseClasses.Data.StringColumn PhoneNumberColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.PhoneNumber column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn PhoneNumber
    {
        get
        {
            return VPropertyContactsView.Instance.PhoneNumberColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.FirstName2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn FirstName2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.FirstName2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn FirstName2
    {
        get
        {
            return VPropertyContactsView.Instance.FirstName2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.LastName2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn LastName2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.LastName2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn LastName2
    {
        get
        {
            return VPropertyContactsView.Instance.LastName2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.Region column object.
    /// </summary>
    public BaseClasses.Data.StringColumn RegionColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[15];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.Region column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Region
    {
        get
        {
            return VPropertyContactsView.Instance.RegionColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.City column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CityColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[16];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.City column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn City
    {
        get
        {
            return VPropertyContactsView.Instance.CityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.Country column object.
    /// </summary>
    public BaseClasses.Data.CountryColumn CountryColumn
    {
        get
        {
            return (BaseClasses.Data.CountryColumn)this.TableDefinition.ColumnList[17];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.Country column object.
    /// </summary>
    public static BaseClasses.Data.CountryColumn Country
    {
        get
        {
            return VPropertyContactsView.Instance.CountryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.LinkID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn LinkIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[18];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.LinkID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn LinkID
    {
        get
        {
            return VPropertyContactsView.Instance.LinkIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.ContactID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ContactIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[19];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.ContactID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ContactID
    {
        get
        {
            return VPropertyContactsView.Instance.ContactIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.BankAccount column object.
    /// </summary>
    public BaseClasses.Data.StringColumn BankAccountColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[20];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's VPropertyContacts_.BankAccount column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn BankAccount
    {
        get
        {
            return VPropertyContactsView.Instance.BankAccountColumn;
        }
    }
    
    


#endregion

#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of VPropertyContactsRecord records using a where clause.
    /// </summary>
    public static VPropertyContactsRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of VPropertyContactsRecord records using a where clause.
    /// </summary>
    public static VPropertyContactsRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of VPropertyContactsRecord records using a where and order by clause.
    /// </summary>
    public static VPropertyContactsRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of VPropertyContactsRecord records using a where and order by clause.
    /// </summary>
    public static VPropertyContactsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of VPropertyContactsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static VPropertyContactsRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = VPropertyContactsView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (VPropertyContactsRecord[])recList.ToArray(Type.GetType("IPv5.Business.VPropertyContactsRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of VPropertyContactsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static VPropertyContactsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = VPropertyContactsView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (VPropertyContactsRecord[])recList.ToArray(Type.GetType("IPv5.Business.VPropertyContactsRecord"));
    }   


    public static VPropertyContactsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = VPropertyContactsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (VPropertyContactsRecord[])recList.ToArray(Type.GetType("IPv5.Business.VPropertyContactsRecord"));
    }

    public static VPropertyContactsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = VPropertyContactsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (VPropertyContactsRecord[])recList.ToArray(Type.GetType("IPv5.Business.VPropertyContactsRecord"));
    }


    public static VPropertyContactsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = VPropertyContactsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (VPropertyContactsRecord[])recList.ToArray(Type.GetType("IPv5.Business.VPropertyContactsRecord"));
    }

    public static VPropertyContactsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = VPropertyContactsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (VPropertyContactsRecord[])recList.ToArray(Type.GetType("IPv5.Business.VPropertyContactsRecord"));
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int PostGetRecordCount(SqlBuilderColumnSelection selectCols, BaseFilter join, BaseFilter finalFilter)
    {
        return (int)VPropertyContactsView.Instance.GetCountResponseForPost(VPropertyContactsView.Instance.TableDefinition, selectCols, join, finalFilter);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of VPropertyContactsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static ArrayList PostGetRecordList(SqlBuilderColumnSelection requestedSelection, SqlBuilderColumnSelection workingSelection, SqlBuilderColumnSelection distinctSelection,
            BaseFilter join, BaseFilter filter, GroupBy groupBy, OrderBy sortOrder, int startIndex, int count, ref int totalCount, Boolean fromDataSource, 
			KeylessVirtualTable table = null, Boolean isGetColumnValues = false)
    {
        ArrayList recList = null;
        if (table == null)
        {
            recList = VPropertyContactsView.Instance.GetRecordListResponseForPost(VPropertyContactsView.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection,
                                                                join, filter, groupBy, sortOrder, startIndex, count, ref totalCount, fromDataSource, isGetColumnValues);
        }
        else if (table != null)
        {
            recList = table.GetDataSourceResponseForPost(requestedSelection, workingSelection, distinctSelection, join, filter, 
                groupBy, sortOrder, startIndex, count, ref totalCount, true);
        }

		return recList;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int GetRecordCount(string where)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        return (int)VPropertyContactsView.Instance.GetRecordListCount(null, whereFilter, null, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int GetRecordCount(BaseFilter join, string where)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        return (int)VPropertyContactsView.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)VPropertyContactsView.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)VPropertyContactsView.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a VPropertyContactsRecord record using a where clause.
    /// </summary>
    public static VPropertyContactsRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a VPropertyContactsRecord record using a where clause.
    /// </summary>
    public static VPropertyContactsRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a VPropertyContactsRecord record using a where and order by clause.
    /// </summary>
    public static VPropertyContactsRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = VPropertyContactsView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        VPropertyContactsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (VPropertyContactsRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a VPropertyContactsRecord record using a where and order by clause.
    /// </summary>
    public static VPropertyContactsRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = VPropertyContactsView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        VPropertyContactsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (VPropertyContactsRecord)recList[0];
        }

        return rec;
    }


    public static String[] GetValues(
		BaseColumn col,
		WhereClause where,
		OrderBy orderBy,
		int maxItems)
	{

        // Create the filter list.
        SqlBuilderColumnSelection retCol = new SqlBuilderColumnSelection(false, true);
        retCol.AddColumn(col);

        return VPropertyContactsView.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }

    public static String[] GetValues(
		BaseColumn col,
		BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int maxItems)
	{

        // Create the filter list.
        SqlBuilderColumnSelection retCol = new SqlBuilderColumnSelection(false, true);
        retCol.AddColumn(col);

        return VPropertyContactsView.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        VPropertyContactsRecord[] recs = GetRecords(where);
        return  VPropertyContactsView.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        VPropertyContactsRecord[] recs = GetRecords(join, where);
        return  VPropertyContactsView.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        VPropertyContactsRecord[] recs = GetRecords(where, orderBy);
        return  VPropertyContactsView.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        VPropertyContactsRecord[] recs = GetRecords(join, where, orderBy);
        return  VPropertyContactsView.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        VPropertyContactsRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  VPropertyContactsView.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        VPropertyContactsRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  VPropertyContactsView.Instance.CreateDataTable(recs, null);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to delete records using a where clause.
    /// </summary>
    public static void DeleteRecords(string where)
    {
        if (where == null || where.Trim() == "")
        {
           return;
        }
        
        SqlFilter whereFilter = new SqlFilter(where);
        VPropertyContactsView.Instance.DeleteRecordList(whereFilter);
    }
    
    /// <summary>
    /// This is a shared function that can be used to export records using a where clause.
    /// </summary>
    public static string Export(string where)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        return  VPropertyContactsView.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return VPropertyContactsView.Instance.ExportRecordData(whereFilter);
    }
    
	public static string GetSum(
		BaseColumn col,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Sum);

        return VPropertyContactsView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }
    
	public static string GetSum(
		BaseColumn col,
		BaseFilter join, 
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Sum);

        return VPropertyContactsView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }    
    
    public static string GetCount(
		BaseColumn col,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Count);

        return VPropertyContactsView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }
    
    public static string GetCount(
		BaseColumn col,
		BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        SqlBuilderColumnSelection colSel = new SqlBuilderColumnSelection(false, false);
        colSel.AddColumn(col, SqlBuilderColumnOperation.OperationType.Count);

        return VPropertyContactsView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return VPropertyContactsView.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return VPropertyContactsView.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return VPropertyContactsView.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return VPropertyContactsView.Instance.CreateRecord(tempId);
    }

    /// <summary>
    /// This method checks if column is editable.
    /// </summary>
    /// <param name="columnName">Name of the column to check.</param>
    public static bool isReadOnlyColumn(string columnName) 
    {
        BaseColumn column = GetColumn(columnName);
        if (!(column == null)) 
        {
            return column.IsValuesReadOnly;
        }
        else 
        {
            return true;
        }
    }

    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="uniqueColumnName">Unique name of the column to fetch.</param>
    public static BaseColumn GetColumn(string uniqueColumnName) 
    {
        BaseColumn column = VPropertyContactsView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = VPropertyContactsView.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = VPropertyContactsView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
			if (fkColumn == null)
				return null;
			String _DFKA = fkColumn.PrimaryKeyDisplayColumns;
			if (_DFKA.Trim().StartsWith("="))
            {
                // if the formula is in the format of "= <Primary table>.<Field name>, then pull out the data from the rec object instead of doing formula evaluation 
                string tableCodeName = fkColumn.PrimaryKeyTableDefinition.TableCodeName;
                string column = _DFKA.Trim('=').Trim();
                if (column.StartsWith(tableCodeName + ".", StringComparison.InvariantCultureIgnoreCase))
                {
                    column = column.Substring(tableCodeName.Length + 1);
                }

                foreach (BaseColumn c in fkColumn.PrimaryKeyTableDefinition.Columns)
                {
                    if (column == c.CodeName)
                    {
                        return rec.Format(c);
                    }
                }
                            
				String tableName = fkColumn.PrimaryKeyTableDefinition.TableCodeName;
				return EvaluateFormula(_DFKA, rec, null, tableName);
			}
			else
				return null;
		}

		/// <summary>
        /// This method takes a keyValue and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
		public static string GetDFKA(String keyValue, BaseColumn col, String formatPattern)
		{
		    if (keyValue == null)
				return null;
			ForeignKey fkColumn = VPropertyContactsView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
			if (fkColumn == null)
				return null;
			String _DFKA = fkColumn.PrimaryKeyDisplayColumns;
			if (_DFKA.Trim().StartsWith("="))
            {
				String tableName = fkColumn.PrimaryKeyTableDefinition.TableCodeName;
				PrimaryKeyTable t = (PrimaryKeyTable)DatabaseObjects.GetTableObject(tableName);
				BaseRecord rec = null;
				
				if (t != null)
				{
					try
					{
						rec = (BaseRecord)t.GetRecordData(keyValue, false);
					}
					catch
					{
						rec = null;
					}
				}
				if( rec == null)
					return "";

                // if the formula is in the format of "= <Primary table>.<Field name>, then pull out the data from the rec object instead of doing formula evaluation 
                string tableCodeName = fkColumn.PrimaryKeyTableDefinition.TableCodeName;
                string column = _DFKA.Trim('=').Trim();
                if (column.StartsWith(tableCodeName + ".", StringComparison.InvariantCultureIgnoreCase))
                {
                    column = column.Substring(tableCodeName.Length + 1);
                }

                foreach (BaseColumn c in fkColumn.PrimaryKeyTableDefinition.Columns)
                {
                    if (column == c.CodeName)
                    {
                        return rec.Format(c);
                    }
                }	            
				return EvaluateFormula(_DFKA, rec, null, tableName);
			}
			else
				return null;
		}

		/// <summary>
        /// Evaluates the formula
        /// </summary>
		public static string EvaluateFormula(string formula, BaseClasses.Data.BaseRecord dataSourceForEvaluate, string format, string name)
		{
			BaseFormulaEvaluator e = new BaseFormulaEvaluator();
			if(dataSourceForEvaluate != null)
				e.Evaluator.Variables.Add(name, dataSourceForEvaluate);
			e.DataSource = dataSourceForEvaluate;
	        object resultObj = e.Evaluate(formula);
	
		    if (resultObj == null)
			    return "";
	        if (!string.IsNullOrEmpty(format))
	            return BaseFormulaUtils.Format(resultObj, format);
		    else
            return resultObj.ToString();
		}
		
		/// <summary>
        /// Evaluates the formula
        /// </summary>
		public static string EvaluateFormula(string formula)
		{
			return EvaluateFormula(formula,null,null,null);
		}
#endregion
}

}
