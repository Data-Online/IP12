﻿// This class is "generated" and will be overwritten.
// Your customizations should be made in VPropertyDirectorsView.cs


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
/// The generated superclass for the <see cref="VPropertyDirectorsView"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseMM_IP1%dbo.vPropertyDirectors.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="VPropertyDirectorsView.Instance">VPropertyDirectorsView.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="VPropertyDirectorsView"></seealso>
[SerializableAttribute()]
public class BaseVPropertyDirectorsView : PrimaryKeyTable
{

    private readonly string TableDefinitionString = VPropertyDirectorsDefinition.GetXMLString();







    protected BaseVPropertyDirectorsView()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("IPv5.Business", "IPv5.Business.VPropertyDirectorsView");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("IPv5.Business", "IPv5.Business.VPropertyDirectorsRecord");
        this.ApplicationName = "IPv5";
        this.DataAdapter = new VPropertyDirectorsSqlView();
        ((VPropertyDirectorsSqlView)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        CompanyNameColumn.CodeName = "CompanyName";
        Title0Column.CodeName = "Title0";
        FirstNameColumn.CodeName = "FirstName";
        LastNameColumn.CodeName = "LastName";
        eMailColumn.CodeName = "eMail";
        Address1Column.CodeName = "Address1";
        Address2Column.CodeName = "Address2";
        Address3Column.CodeName = "Address3";
        CityColumn.CodeName = "City";
        RegionColumn.CodeName = "Region";
        PostCodeColumn.CodeName = "PostCode";
        CountryColumn.CodeName = "Country";
        ContactIDColumn.CodeName = "ContactID";
        PropertyIDColumn.CodeName = "PropertyID";
        ID0Column.CodeName = "ID0";

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.CompanyName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CompanyNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.CompanyName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn CompanyName
    {
        get
        {
            return VPropertyDirectorsView.Instance.CompanyNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.Title column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Title0Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.Title column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Title0
    {
        get
        {
            return VPropertyDirectorsView.Instance.Title0Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.FirstName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn FirstNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.FirstName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn FirstName
    {
        get
        {
            return VPropertyDirectorsView.Instance.FirstNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.LastName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn LastNameColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.LastName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn LastName
    {
        get
        {
            return VPropertyDirectorsView.Instance.LastNameColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.eMail column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn eMailColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.eMail column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn eMail
    {
        get
        {
            return VPropertyDirectorsView.Instance.eMailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.Address1 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address1Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.Address1 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address1
    {
        get
        {
            return VPropertyDirectorsView.Instance.Address1Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.Address2 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address2Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.Address2 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address2
    {
        get
        {
            return VPropertyDirectorsView.Instance.Address2Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.Address3 column object.
    /// </summary>
    public BaseClasses.Data.StringColumn Address3Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.Address3 column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Address3
    {
        get
        {
            return VPropertyDirectorsView.Instance.Address3Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.City column object.
    /// </summary>
    public BaseClasses.Data.StringColumn CityColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.City column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn City
    {
        get
        {
            return VPropertyDirectorsView.Instance.CityColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.Region column object.
    /// </summary>
    public BaseClasses.Data.StringColumn RegionColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.Region column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn Region
    {
        get
        {
            return VPropertyDirectorsView.Instance.RegionColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.PostCode column object.
    /// </summary>
    public BaseClasses.Data.StringColumn PostCodeColumn
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[10];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.PostCode column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn PostCode
    {
        get
        {
            return VPropertyDirectorsView.Instance.PostCodeColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.Country column object.
    /// </summary>
    public BaseClasses.Data.CountryColumn CountryColumn
    {
        get
        {
            return (BaseClasses.Data.CountryColumn)this.TableDefinition.ColumnList[11];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.Country column object.
    /// </summary>
    public static BaseClasses.Data.CountryColumn Country
    {
        get
        {
            return VPropertyDirectorsView.Instance.CountryColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.ContactID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ContactIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[12];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.ContactID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ContactID
    {
        get
        {
            return VPropertyDirectorsView.Instance.ContactIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.PropertyID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn PropertyIDColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[13];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.PropertyID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn PropertyID
    {
        get
        {
            return VPropertyDirectorsView.Instance.PropertyIDColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.ID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn ID0Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[14];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's vPropertyDirectors_.ID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn ID0
    {
        get
        {
            return VPropertyDirectorsView.Instance.ID0Column;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of VPropertyDirectorsRecord records using a where clause.
    /// </summary>
    public static VPropertyDirectorsRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of VPropertyDirectorsRecord records using a where clause.
    /// </summary>
    public static VPropertyDirectorsRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of VPropertyDirectorsRecord records using a where and order by clause.
    /// </summary>
    public static VPropertyDirectorsRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of VPropertyDirectorsRecord records using a where and order by clause.
    /// </summary>
    public static VPropertyDirectorsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of VPropertyDirectorsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static VPropertyDirectorsRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = VPropertyDirectorsView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (VPropertyDirectorsRecord[])recList.ToArray(Type.GetType("IPv5.Business.VPropertyDirectorsRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of VPropertyDirectorsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static VPropertyDirectorsRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = VPropertyDirectorsView.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (VPropertyDirectorsRecord[])recList.ToArray(Type.GetType("IPv5.Business.VPropertyDirectorsRecord"));
    }   


    public static VPropertyDirectorsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = VPropertyDirectorsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (VPropertyDirectorsRecord[])recList.ToArray(Type.GetType("IPv5.Business.VPropertyDirectorsRecord"));
    }

    public static VPropertyDirectorsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = VPropertyDirectorsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (VPropertyDirectorsRecord[])recList.ToArray(Type.GetType("IPv5.Business.VPropertyDirectorsRecord"));
    }


    public static VPropertyDirectorsRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = VPropertyDirectorsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (VPropertyDirectorsRecord[])recList.ToArray(Type.GetType("IPv5.Business.VPropertyDirectorsRecord"));
    }

    public static VPropertyDirectorsRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = VPropertyDirectorsView.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (VPropertyDirectorsRecord[])recList.ToArray(Type.GetType("IPv5.Business.VPropertyDirectorsRecord"));
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int PostGetRecordCount(SqlBuilderColumnSelection selectCols, BaseFilter join, BaseFilter finalFilter)
    {
        return (int)VPropertyDirectorsView.Instance.GetCountResponseForPost(VPropertyDirectorsView.Instance.TableDefinition, selectCols, join, finalFilter);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of VPropertyDirectorsRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static ArrayList PostGetRecordList(SqlBuilderColumnSelection requestedSelection, SqlBuilderColumnSelection workingSelection, SqlBuilderColumnSelection distinctSelection,
            BaseFilter join, BaseFilter filter, GroupBy groupBy, OrderBy sortOrder, int startIndex, int count, ref int totalCount, Boolean fromDataSource, 
			KeylessVirtualTable table = null, Boolean isGetColumnValues = false)
    {
        ArrayList recList = null;
        if (table == null)
        {
            recList = VPropertyDirectorsView.Instance.GetRecordListResponseForPost(VPropertyDirectorsView.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection,
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

        return (int)VPropertyDirectorsView.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)VPropertyDirectorsView.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)VPropertyDirectorsView.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)VPropertyDirectorsView.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a VPropertyDirectorsRecord record using a where clause.
    /// </summary>
    public static VPropertyDirectorsRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a VPropertyDirectorsRecord record using a where clause.
    /// </summary>
    public static VPropertyDirectorsRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a VPropertyDirectorsRecord record using a where and order by clause.
    /// </summary>
    public static VPropertyDirectorsRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = VPropertyDirectorsView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        VPropertyDirectorsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (VPropertyDirectorsRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a VPropertyDirectorsRecord record using a where and order by clause.
    /// </summary>
    public static VPropertyDirectorsRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = VPropertyDirectorsView.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        VPropertyDirectorsRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (VPropertyDirectorsRecord)recList[0];
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

        return VPropertyDirectorsView.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return VPropertyDirectorsView.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        VPropertyDirectorsRecord[] recs = GetRecords(where);
        return  VPropertyDirectorsView.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        VPropertyDirectorsRecord[] recs = GetRecords(join, where);
        return  VPropertyDirectorsView.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        VPropertyDirectorsRecord[] recs = GetRecords(where, orderBy);
        return  VPropertyDirectorsView.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        VPropertyDirectorsRecord[] recs = GetRecords(join, where, orderBy);
        return  VPropertyDirectorsView.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        VPropertyDirectorsRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  VPropertyDirectorsView.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        VPropertyDirectorsRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  VPropertyDirectorsView.Instance.CreateDataTable(recs, null);
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
        VPropertyDirectorsView.Instance.DeleteRecordList(whereFilter);
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
        
        return  VPropertyDirectorsView.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return VPropertyDirectorsView.Instance.ExportRecordData(whereFilter);
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

        return VPropertyDirectorsView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return VPropertyDirectorsView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return VPropertyDirectorsView.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return VPropertyDirectorsView.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return VPropertyDirectorsView.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return VPropertyDirectorsView.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return VPropertyDirectorsView.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return VPropertyDirectorsView.Instance.CreateRecord(tempId);
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
        BaseColumn column = VPropertyDirectorsView.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = VPropertyDirectorsView.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static VPropertyDirectorsRecord GetRecord(string id, bool bMutable)
        {
            return (VPropertyDirectorsRecord)VPropertyDirectorsView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static VPropertyDirectorsRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (VPropertyDirectorsRecord)VPropertyDirectorsView.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string CompanyNameValue, 
        string Title0Value, 
        string FirstNameValue, 
        string LastNameValue, 
        string eMailValue, 
        string Address1Value, 
        string Address2Value, 
        string Address3Value, 
        string CityValue, 
        string RegionValue, 
        string PostCodeValue, 
        string CountryValue, 
        string ContactIDValue, 
        string PropertyIDValue, 
        string ID0Value
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(CompanyNameValue, CompanyNameColumn);
        rec.SetString(Title0Value, Title0Column);
        rec.SetString(FirstNameValue, FirstNameColumn);
        rec.SetString(LastNameValue, LastNameColumn);
        rec.SetString(eMailValue, eMailColumn);
        rec.SetString(Address1Value, Address1Column);
        rec.SetString(Address2Value, Address2Column);
        rec.SetString(Address3Value, Address3Column);
        rec.SetString(CityValue, CityColumn);
        rec.SetString(RegionValue, RegionColumn);
        rec.SetString(PostCodeValue, PostCodeColumn);
        rec.SetString(CountryValue, CountryColumn);
        rec.SetString(ContactIDValue, ContactIDColumn);
        rec.SetString(PropertyIDValue, PropertyIDColumn);
        rec.SetString(ID0Value, ID0Column);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			VPropertyDirectorsView.Instance.DeleteOneRecord(kv);
		}

		/// <summary>
		/// This method checks if record exist in the database using the keyvalue provided.
		/// </summary>
		/// <param name="kv">Key value of the record.</param>
		public static bool DoesRecordExist(KeyValue kv)
		{
			bool recordExist = true;
			try
			{
				VPropertyDirectorsView.GetRecord(kv, false);
			}
			catch (Exception)
			{
				recordExist = false;
			}
			return recordExist;
		}

        /// <summary>
        ///  This method returns all the primary columns in the table.
        /// </summary>
        public static ColumnList GetPrimaryKeyColumns() 
        {
            if (!(VPropertyDirectorsView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return VPropertyDirectorsView.Instance.TableDefinition.PrimaryKey.Columns;
            }
            else 
            {
                return null;
            }
        }

        /// <summary>
        /// This method takes a key and returns a keyvalue.
        /// </summary>
        /// <param name="key">key could be array of primary key values in case of composite primary key or a string containing single primary key value in case of non-composite primary key.</param>
        public static KeyValue GetKeyValue(object key) 
        {
            KeyValue kv = null;
            if (!(VPropertyDirectorsView.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = VPropertyDirectorsView.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = VPropertyDirectorsView.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (VPropertyDirectorsView.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
                            {
                                kv.AddElement(pkColumn.UniqueName, keyString);
                            }
                            else 
                            {
                                kv.AddElement(pkColumn.InternalName, keyString);
                            }

                            index = (index + 1);
                        }
                    }
                }
                else 
                {
                    //  If the key is not composite, then get the key value.
                    kv = VPropertyDirectorsView.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = VPropertyDirectorsView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = VPropertyDirectorsView.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
