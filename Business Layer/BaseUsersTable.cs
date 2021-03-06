﻿// This class is "generated" and will be overwritten.
// Your customizations should be made in UsersTable.cs


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
/// The generated superclass for the <see cref="UsersTable"></see> class.
/// Provides access to the schema information and record data of a database table or view named DatabaseMM_IP1%dbo.Users.
/// </summary>
/// <remarks>
/// The connection details (name, location, etc.) of the database and table (or view) accessed by this class 
/// are resolved at runtime based on the connection string in the application's Web.Config file.
/// <para>
/// This class is not intended to be instantiated directly.  To obtain an instance of this class, use 
/// <see cref="UsersTable.Instance">UsersTable.Instance</see>.
/// </para>
/// </remarks>
/// <seealso cref="UsersTable"></seealso>
[SerializableAttribute()]
public class BaseUsersTable : PrimaryKeyTable, IUserIdentityTable
{

    private readonly string TableDefinitionString = UsersDefinition.GetXMLString();

#region "IUserTable Members"

	//Get the column that specifies the user's unique identifier
	public virtual BaseClasses.Data.BaseColumn UserId
	{
		get
		{
			return (BaseClasses.Data.BaseColumn)this.TableDefinition.ColumnList[0];
		}
	}

	//Use the "explicit interface member implementation" feature to make 
	//the IUserTable.UserIdColumn Interface property an alias for the virtual UserId property. 
	BaseClasses.Data.BaseColumn BaseClasses.IUserTable.UserIdColumn
	{
		get
		{
			return this.UserId;
		}
	}

	//Get a list of records that match the criteria specified in a filter
	public virtual ArrayList GetRecordList(
		string userId, 
		BaseClasses.Data.BaseFilter filter, 
		BaseClasses.Data.OrderBy orderBy, 
		int pageNumber, 
		int batchSize, 
		ref int totalRows)
	{
		if (userId != null)
		{
			filter = BaseFilter.CombineFilters(
				CompoundFilter.CompoundingOperators.And_Operator, 
				filter, 
				BaseFilter.CreateUserIdFilter(((IUserTable)this), userId));
		}
		BaseClasses.Data.BaseFilter join = null;
		return ((BaseClasses.ITable)this).GetRecordList(join, filter, null, orderBy, pageNumber, batchSize, ref totalRows);
	}

#endregion



#region "IUserIdentityTable Members"

	//Get the column that specifies the user's name
	public virtual BaseClasses.Data.BaseColumn UserName
	{
		get
		{
			return (BaseClasses.Data.BaseColumn)this.TableDefinition.ColumnList[1];
		}
	}

	//Use the "explicit interface member implementation" feature to make 
	//the IUserIdentityTable.UserNameColumn Interface property an alias for the virtual UserName property. 
	BaseClasses.Data.BaseColumn BaseClasses.IUserIdentityTable.UserNameColumn
	{
		get
		{
			return this.UserName;
		}
	}

	//Get the column that specifies the user's password
	public virtual BaseClasses.Data.BaseColumn UserPassword
	{
		get
		{
			return (BaseClasses.Data.BaseColumn)this.TableDefinition.ColumnList[2];
		}
	}

	//Use the "explicit interface member implementation" feature to make 
	//the IUserIdentityTable.UserPasswordColumn Interface property an alias for the virtual UserPassword property. 
	BaseClasses.Data.BaseColumn BaseClasses.IUserIdentityTable.UserPasswordColumn
	{
		get
		{
			return this.UserPassword;
		}
	}

	//Get the column that specifies the user's email address
	public virtual BaseClasses.Data.BaseColumn UserEmail
	{
		get
		{
			return (BaseClasses.Data.BaseColumn)this.TableDefinition.ColumnList[3];;
		}
	}

	//Use the "explicit interface member implementation" feature to make 
	//the IUserIdentityTable.UserEmailColumn Interface property an alias for the virtual UserEmail property. 
	BaseClasses.Data.BaseColumn BaseClasses.IUserIdentityTable.UserEmailColumn
	{
		get
		{
			return this.UserEmail;
		}
	}

	//Get a role table object
	public virtual BaseClasses.IUserRoleTable GetUserRoleTable()
	{
		return (BaseClasses.IUserRoleTable)Users_RolesTable.Instance;
	}

	//Get a list of records that match the user's name/password
	public virtual ArrayList GetRecordList(
		string userName, 
		string userPassword, 
		BaseClasses.Data.BaseFilter filter, 
		BaseClasses.Data.OrderBy orderBy, 
		int pageNumber, 
		int batchSize, 
		ref int totalRows)
	{
		//Set up a name/password filter   
		if ((userName != null) || (userPassword != null))
		{
			filter = BaseFilter.CombineFilters(
				CompoundFilter.CompoundingOperators.And_Operator,
				filter,
				BaseFilter.CreateUserAuthenticationFilter(((IUserIdentityTable)this), userName, userPassword));
		}
		BaseClasses.Data.BaseFilter join = null;
		return ((BaseClasses.ITable)this).GetRecordList(join, filter, null, orderBy, pageNumber, batchSize, ref totalRows);
	}

#endregion




    protected BaseUsersTable()
    {
        this.Initialize();
    }

    protected virtual void Initialize()
    {
        XmlTableDefinition def = new XmlTableDefinition(TableDefinitionString);
        this.TableDefinition = new TableDefinition();
        this.TableDefinition.TableClassName = System.Reflection.Assembly.CreateQualifiedName("IPv5.Business", "IPv5.Business.UsersTable");
        def.InitializeTableDefinition(this.TableDefinition);
        this.ConnectionName = def.GetConnectionName();
        this.RecordClassName = System.Reflection.Assembly.CreateQualifiedName("IPv5.Business", "IPv5.Business.UsersRecord");
        this.ApplicationName = "IPv5";
        this.DataAdapter = new UsersSqlTable();
        ((UsersSqlTable)this.DataAdapter).ConnectionName = this.ConnectionName;
		
        this.TableDefinition.AdapterMetaData = this.DataAdapter.AdapterMetaData;
        UserId0Column.CodeName = "UserId0";
        UserName0Column.CodeName = "UserName0";
        PasswordColumn.CodeName = "Password";
        eMailColumn.CodeName = "eMail";
        CreatedByColumn.CodeName = "CreatedBy";
        UpdatedByColumn.CodeName = "UpdatedBy";
        CreatedOnColumn.CodeName = "CreatedOn";
        UpdatedOnColumn.CodeName = "UpdatedOn";
        ActiveColumn.CodeName = "Active";
        PwdExpColumn.CodeName = "PwdExp";
        PwdExpColumn.Name = EvaluateFormula("\"Prompt for new Password\"");

        
    }
    
#region "Overriden methods"
	
#endregion    

#region "Properties for columns"

    /// <summary>
    /// This is a convenience property that provides direct access to the table's Users_.UserID column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn UserId0Column
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[0];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Users_.UserID column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn UserId0
    {
        get
        {
            return UsersTable.Instance.UserId0Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Users_.UserName column object.
    /// </summary>
    public BaseClasses.Data.StringColumn UserName0Column
    {
        get
        {
            return (BaseClasses.Data.StringColumn)this.TableDefinition.ColumnList[1];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Users_.UserName column object.
    /// </summary>
    public static BaseClasses.Data.StringColumn UserName0
    {
        get
        {
            return UsersTable.Instance.UserName0Column;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Users_.Password column object.
    /// </summary>
    public BaseClasses.Data.PasswordColumn PasswordColumn
    {
        get
        {
            return (BaseClasses.Data.PasswordColumn)this.TableDefinition.ColumnList[2];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Users_.Password column object.
    /// </summary>
    public static BaseClasses.Data.PasswordColumn Password
    {
        get
        {
            return UsersTable.Instance.PasswordColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Users_.eMail column object.
    /// </summary>
    public BaseClasses.Data.EmailColumn eMailColumn
    {
        get
        {
            return (BaseClasses.Data.EmailColumn)this.TableDefinition.ColumnList[3];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Users_.eMail column object.
    /// </summary>
    public static BaseClasses.Data.EmailColumn eMail
    {
        get
        {
            return UsersTable.Instance.eMailColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Users_.CreatedBy column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn CreatedByColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[4];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Users_.CreatedBy column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn CreatedBy
    {
        get
        {
            return UsersTable.Instance.CreatedByColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Users_.UpdatedBy column object.
    /// </summary>
    public BaseClasses.Data.NumberColumn UpdatedByColumn
    {
        get
        {
            return (BaseClasses.Data.NumberColumn)this.TableDefinition.ColumnList[5];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Users_.UpdatedBy column object.
    /// </summary>
    public static BaseClasses.Data.NumberColumn UpdatedBy
    {
        get
        {
            return UsersTable.Instance.UpdatedByColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Users_.CreatedOn column object.
    /// </summary>
    public BaseClasses.Data.DateColumn CreatedOnColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[6];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Users_.CreatedOn column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn CreatedOn
    {
        get
        {
            return UsersTable.Instance.CreatedOnColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Users_.UpdatedOn column object.
    /// </summary>
    public BaseClasses.Data.DateColumn UpdatedOnColumn
    {
        get
        {
            return (BaseClasses.Data.DateColumn)this.TableDefinition.ColumnList[7];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Users_.UpdatedOn column object.
    /// </summary>
    public static BaseClasses.Data.DateColumn UpdatedOn
    {
        get
        {
            return UsersTable.Instance.UpdatedOnColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Users_.Active column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn ActiveColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[8];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Users_.Active column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn Active
    {
        get
        {
            return UsersTable.Instance.ActiveColumn;
        }
    }
    
    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Users_.PwdExp column object.
    /// </summary>
    public BaseClasses.Data.BooleanColumn PwdExpColumn
    {
        get
        {
            return (BaseClasses.Data.BooleanColumn)this.TableDefinition.ColumnList[9];
        }
    }
    

    
    /// <summary>
    /// This is a convenience property that provides direct access to the table's Users_.PwdExp column object.
    /// </summary>
    public static BaseClasses.Data.BooleanColumn PwdExp
    {
        get
        {
            return UsersTable.Instance.PwdExpColumn;
        }
    }
    
    


#endregion

    
#region "Shared helper methods"

    /// <summary>
    /// This is a shared function that can be used to get an array of UsersRecord records using a where clause.
    /// </summary>
    public static UsersRecord[] GetRecords(string where)
    {
        return GetRecords(where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get an array of UsersRecord records using a where clause.
    /// </summary>
    public static UsersRecord[] GetRecords(BaseFilter join, string where)
    {
        return GetRecords(join, where, null, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    

    /// <summary>
    /// This is a shared function that can be used to get an array of UsersRecord records using a where and order by clause.
    /// </summary>
    public static UsersRecord[] GetRecords(string where, OrderBy orderBy)
    {
        return GetRecords(where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }
    
     /// <summary>
    /// This is a shared function that can be used to get an array of UsersRecord records using a where and order by clause.
    /// </summary>
    public static UsersRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy)
    {
        return GetRecords(join, where, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MAX_BATCH_SIZE);
    }    
    
    /// <summary>
    /// This is a shared function that can be used to get an array of UsersRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static UsersRecord[] GetRecords(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = UsersTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (UsersRecord[])recList.ToArray(Type.GetType("IPv5.Business.UsersRecord"));
    }   
    
    /// <summary>
    /// This is a shared function that can be used to get an array of UsersRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static UsersRecord[] GetRecords(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }

        ArrayList recList = UsersTable.Instance.GetRecordList(join, whereFilter, null, orderBy, pageIndex, pageSize);

        return (UsersRecord[])recList.ToArray(Type.GetType("IPv5.Business.UsersRecord"));
    }   


    public static UsersRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = UsersTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (UsersRecord[])recList.ToArray(Type.GetType("IPv5.Business.UsersRecord"));
    }

    public static UsersRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize)
	{

        ArrayList recList = UsersTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize);

        return (UsersRecord[])recList.ToArray(Type.GetType("IPv5.Business.UsersRecord"));
    }


    public static UsersRecord[] GetRecords(
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{
        BaseClasses.Data.BaseFilter join = null;
        ArrayList recList = UsersTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (UsersRecord[])recList.ToArray(Type.GetType("IPv5.Business.UsersRecord"));
    }

    public static UsersRecord[] GetRecords(
        BaseFilter join,
		WhereClause where,
		OrderBy orderBy,
		int pageIndex,
		int pageSize,
		ref int totalRecords)
	{

        ArrayList recList = UsersTable.Instance.GetRecordList(join, where.GetFilter(), null, orderBy, pageIndex, pageSize, ref totalRecords);

        return (UsersRecord[])recList.ToArray(Type.GetType("IPv5.Business.UsersRecord"));
    }

    /// <summary>
    /// This is a shared function that can be used to get total number of records that will be returned using the where clause.
    /// </summary>
    public static int PostGetRecordCount(SqlBuilderColumnSelection selectCols, BaseFilter join, BaseFilter finalFilter)
    {
        return (int)UsersTable.Instance.GetCountResponseForPost(UsersTable.Instance.TableDefinition, selectCols, join, finalFilter);
    }

    /// <summary>
    /// This is a shared function that can be used to get an array of UsersRecord records using a where and order by clause clause with pagination.
    /// </summary>
    public static ArrayList PostGetRecordList(SqlBuilderColumnSelection requestedSelection, SqlBuilderColumnSelection workingSelection, SqlBuilderColumnSelection distinctSelection,
            BaseFilter join, BaseFilter filter, GroupBy groupBy, OrderBy sortOrder, int startIndex, int count, ref int totalCount, Boolean fromDataSource, 
			KeylessVirtualTable table = null, Boolean isGetColumnValues = false)
    {
        ArrayList recList = null;
        if (table == null)
        {
            recList = UsersTable.Instance.GetRecordListResponseForPost(UsersTable.Instance.TableDefinition, requestedSelection, workingSelection, distinctSelection,
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

        return (int)UsersTable.Instance.GetRecordListCount(null, whereFilter, null, null);
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

        return (int)UsersTable.Instance.GetRecordListCount(join, whereFilter, null, null);
    }

    
    public static int GetRecordCount(WhereClause where)
    {
        return (int)UsersTable.Instance.GetRecordListCount(null, where.GetFilter(), null, null);
    }
    
    public static int GetRecordCount(BaseFilter join, WhereClause where)
    {
        return (int)UsersTable.Instance.GetRecordListCount(join, where.GetFilter(), null, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a UsersRecord record using a where clause.
    /// </summary>
    public static UsersRecord GetRecord(string where)
    {
        OrderBy orderBy = null;
        return GetRecord(where, orderBy);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a UsersRecord record using a where clause.
    /// </summary>
    public static UsersRecord GetRecord(BaseFilter join, string where)
    {
        OrderBy orderBy = null;
        return GetRecord(join, where, orderBy);
    }


    /// <summary>
    /// This is a shared function that can be used to get a UsersRecord record using a where and order by clause.
    /// </summary>
    public static UsersRecord GetRecord(string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        BaseClasses.Data.BaseFilter join = null;  
        ArrayList recList = UsersTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        UsersRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (UsersRecord)recList[0];
        }

        return rec;
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a UsersRecord record using a where and order by clause.
    /// </summary>
    public static UsersRecord GetRecord(BaseFilter join, string where, OrderBy orderBy)
    {
        SqlFilter whereFilter = null;
        if (where != null && where.Trim() != "")
        {
           whereFilter = new SqlFilter(where);
        }
        
        ArrayList recList = UsersTable.Instance.GetRecordList(join, whereFilter, null, orderBy, BaseTable.MIN_PAGE_NUMBER, BaseTable.MIN_BATCH_SIZE);

        UsersRecord rec = null;
        if (recList.Count > 0)
        {
            rec = (UsersRecord)recList[0];
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

        return UsersTable.Instance.GetColumnValues(retCol, null, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

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

        return UsersTable.Instance.GetColumnValues(retCol, join, where.GetFilter(), null, orderBy, BaseTable.MIN_PAGE_NUMBER, maxItems);

    }
      
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where)
    {
        UsersRecord[] recs = GetRecords(where);
        return  UsersTable.Instance.CreateDataTable(recs, null);
    }

    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where)
    {
        UsersRecord[] recs = GetRecords(join, where);
        return  UsersTable.Instance.CreateDataTable(recs, null);
    }


    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy)
    {
        UsersRecord[] recs = GetRecords(where, orderBy);
        return  UsersTable.Instance.CreateDataTable(recs, null);
    }
   
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy)
    {
        UsersRecord[] recs = GetRecords(join, where, orderBy);
        return  UsersTable.Instance.CreateDataTable(recs, null);
    }
   
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        UsersRecord[] recs = GetRecords(where, orderBy, pageIndex, pageSize);
        return  UsersTable.Instance.CreateDataTable(recs, null);
    }
    
    /// <summary>
    /// This is a shared function that can be used to get a DataTable to bound with a data bound control using a where and order by clause with pagination.
    /// </summary>
    public static System.Data.DataTable GetDataTable(BaseFilter join, string where, OrderBy orderBy, int pageIndex, int pageSize)
    {
        UsersRecord[] recs = GetRecords(join, where, orderBy, pageIndex, pageSize);
        return  UsersTable.Instance.CreateDataTable(recs, null);
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
        UsersTable.Instance.DeleteRecordList(whereFilter);
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
        
        return  UsersTable.Instance.ExportRecordData(whereFilter);
    }
   
    public static string Export(WhereClause where)
    {
        BaseFilter whereFilter = null;
        if (where != null)
        {
            whereFilter = where.GetFilter();
        }

        return UsersTable.Instance.ExportRecordData(whereFilter);
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

        return UsersTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return UsersTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return UsersTable.Instance.GetColumnStatistics(colSel, null, where.GetFilter(), null, orderBy, pageIndex, pageSize);
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

        return UsersTable.Instance.GetColumnStatistics(colSel, join, where.GetFilter(), null, orderBy, pageIndex, pageSize);
    }

    /// <summary>
    ///  This method returns the columns in the table.
    /// </summary>
    public static BaseColumn[] GetColumns() 
    {
        return UsersTable.Instance.TableDefinition.Columns;
    }

    /// <summary>
    ///  This method returns the columnlist in the table.
    /// </summary>   
    public static ColumnList GetColumnList() 
    {
        return UsersTable.Instance.TableDefinition.ColumnList;
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    public static IRecord CreateNewRecord() 
    {
        return UsersTable.Instance.CreateRecord();
    }

    /// <summary>
    /// This method creates a new record and returns it to be edited.
    /// </summary>
    /// <param name="tempId">ID of the new record.</param>   
    public static IRecord CreateNewRecord(string tempId) 
    {
        return UsersTable.Instance.CreateRecord(tempId);
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
        BaseColumn column = UsersTable.Instance.TableDefinition.ColumnList.GetByUniqueName(uniqueColumnName);
        return column;
    }
    
    
    /// <summary>
    /// This method gets the specified column.
    /// </summary>
    /// <param name="name">name of the column to fetch.</param>
    public static BaseColumn GetColumnByName(string name)
    {
        BaseColumn column = UsersTable.Instance.TableDefinition.ColumnList.GetByInternalName(name);
        return column;
    } 

        //Convenience method for getting a record using a string-based record identifier
        public static UsersRecord GetRecord(string id, bool bMutable)
        {
            return (UsersRecord)UsersTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for getting a record using a KeyValue record identifier
        public static UsersRecord GetRecord(KeyValue id, bool bMutable)
        {
            return (UsersRecord)UsersTable.Instance.GetRecordData(id, bMutable);
        }

        //Convenience method for creating a record
        public KeyValue NewRecord(
        string UserName0Value, 
        string PasswordValue, 
        string eMailValue, 
        string CreatedByValue, 
        string UpdatedByValue, 
        string CreatedOnValue, 
        string UpdatedOnValue, 
        string ActiveValue, 
        string PwdExpValue
    )
        {
            IPrimaryKeyRecord rec = (IPrimaryKeyRecord)this.CreateRecord();
                    rec.SetString(UserName0Value, UserName0Column);
        rec.SetString(PasswordValue, PasswordColumn);
        rec.SetString(eMailValue, eMailColumn);
        rec.SetString(CreatedByValue, CreatedByColumn);
        rec.SetString(UpdatedByValue, UpdatedByColumn);
        rec.SetString(CreatedOnValue, CreatedOnColumn);
        rec.SetString(UpdatedOnValue, UpdatedOnColumn);
        rec.SetString(ActiveValue, ActiveColumn);
        rec.SetString(PwdExpValue, PwdExpColumn);


            rec.Create(); //update the DB so any DB-initialized fields (like autoincrement IDs) can be initialized

            return rec.GetID();
        }
        
        /// <summary>
		///  This method deletes a specified record
		/// </summary>
		/// <param name="kv">Keyvalue of the record to be deleted.</param>
		public static void DeleteRecord(KeyValue kv)
		{
			UsersTable.Instance.DeleteOneRecord(kv);
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
				UsersTable.GetRecord(kv, false);
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
            if (!(UsersTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                return UsersTable.Instance.TableDefinition.PrimaryKey.Columns;
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
            if (!(UsersTable.Instance.TableDefinition.PrimaryKey == null)) 
            {
                bool isCompositePrimaryKey = false;
                isCompositePrimaryKey = UsersTable.Instance.TableDefinition.PrimaryKey.IsCompositeKey;
                if ((isCompositePrimaryKey && key.GetType().IsArray)) 
                {
                    //  If the key is composite, then construct a key value.
                    kv = new KeyValue();
                    Array keyArray = ((Array)(key));
                    if (!(keyArray == null)) 
                    {
                        int length = keyArray.Length;
                        ColumnList pkColumns = UsersTable.Instance.TableDefinition.PrimaryKey.Columns;
                        int index = 0;
                        foreach (BaseColumn pkColumn in pkColumns) 
                        {
                            string keyString = ((keyArray.GetValue(index)).ToString());
                            if (UsersTable.Instance.TableDefinition.TableType == BaseClasses.Data.TableDefinition.TableTypes.Virtual)
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
                    kv = UsersTable.Instance.TableDefinition.PrimaryKey.ParseValue(((key).ToString()));
                }
            }
            return kv;
        }
        
        /// <summary>
        /// This method takes a record and a Column and returns an evaluated value of DFKA formula.
        /// </summary>
        public static string GetDFKA(BaseRecord rec, BaseColumn col)
		{
			ForeignKey fkColumn = UsersTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
			ForeignKey fkColumn = UsersTable.Instance.TableDefinition.GetExpandableNonCompositeForeignKey(col);
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
