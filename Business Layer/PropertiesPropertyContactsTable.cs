// This is a "safe" class, meaning that it is created once 
// and never overwritten. Any custom code you add to this class 
// will be preserved when you regenerate your application.
//
// Typical customizations that may be done in this class include
//  - adding custom event handlers
//  - overriding base class methods

using System;
using System.Data.SqlTypes;
using BaseClasses;
using BaseClasses.Data;
using BaseClasses.Data.SqlProvider;

namespace IPv5.Business
{

/// <summary>
/// Provides access to the schema information and record data of a database table (or view).
/// See <see cref="BasePropertiesPropertyContactsTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BasePropertiesPropertyContactsTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BasePropertiesPropertyContactsTable"></seealso>
/// <seealso cref="BasePropertiesPropertyContactsSqlTable"></seealso>
/// <seealso cref="PropertiesPropertyContactsSqlTable"></seealso>
/// <seealso cref="PropertiesPropertyContactsDefinition"></seealso>
/// <seealso cref="PropertiesPropertyContactsRecord"></seealso>
/// <seealso cref="BasePropertiesPropertyContactsRecord"></seealso>
[SerializableAttribute()]
public class PropertiesPropertyContactsTable : BasePropertiesPropertyContactsTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="PropertiesPropertyContactsTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="PropertiesPropertyContactsTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="PropertiesPropertyContactsTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(PropertiesPropertyContactsTable_SerializationHelper)); //No other values need to be added
    }

#region "Class PropertiesPropertyContactsTable_SerializationHelper"

    [SerializableAttribute()]
    private class PropertiesPropertyContactsTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return PropertiesPropertyContactsTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="PropertiesPropertyContactsTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="PropertiesPropertyContactsTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static PropertiesPropertyContactsTable Instance = new PropertiesPropertyContactsTable();

    public PropertiesPropertyContactsTable()
    {
    }


} // End class PropertiesPropertyContactsTable

}
