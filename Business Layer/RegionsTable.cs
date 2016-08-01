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
/// See <see cref="BaseRegionsTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseRegionsTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseRegionsTable"></seealso>
/// <seealso cref="BaseRegionsSqlTable"></seealso>
/// <seealso cref="RegionsSqlTable"></seealso>
/// <seealso cref="RegionsDefinition"></seealso>
/// <seealso cref="RegionsRecord"></seealso>
/// <seealso cref="BaseRegionsRecord"></seealso>
[SerializableAttribute()]
public class RegionsTable : BaseRegionsTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="RegionsTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="RegionsTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="RegionsTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(RegionsTable_SerializationHelper)); //No other values need to be added
    }

#region "Class RegionsTable_SerializationHelper"

    [SerializableAttribute()]
    private class RegionsTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return RegionsTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="RegionsTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="RegionsTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static RegionsTable Instance = new RegionsTable();

    public RegionsTable()
    {
    }


} // End class RegionsTable

}
