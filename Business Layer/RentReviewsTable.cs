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
/// See <see cref="BaseRentReviewsTable"></see> for additional information.
/// </summary>
/// <remarks>
/// See <see cref="BaseRentReviewsTable"></see> for additional information.
/// <para>
/// This class is implemented using the Singleton design pattern.
/// </para>
/// </remarks>
/// <seealso cref="BaseRentReviewsTable"></seealso>
/// <seealso cref="BaseRentReviewsSqlTable"></seealso>
/// <seealso cref="RentReviewsSqlTable"></seealso>
/// <seealso cref="RentReviewsDefinition"></seealso>
/// <seealso cref="RentReviewsRecord"></seealso>
/// <seealso cref="BaseRentReviewsRecord"></seealso>
[SerializableAttribute()]
public class RentReviewsTable : BaseRentReviewsTable, System.Runtime.Serialization.ISerializable, ISingleton
{

#region "ISerializable Members"

    /// <summary>
    /// Overridden to use the <see cref="RentReviewsTable_SerializationHelper"></see> class 
    /// for deserialization of <see cref="RentReviewsTable"></see> data.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="RentReviewsTable"></see> class is implemented using the Singleton design pattern, 
    /// this method must be overridden to prevent additional instances from being created during deserialization.
    /// </remarks>
    void System.Runtime.Serialization.ISerializable.GetObjectData(
        System.Runtime.Serialization.SerializationInfo info, 
        System.Runtime.Serialization.StreamingContext context)
    {
        info.SetType(typeof(RentReviewsTable_SerializationHelper)); //No other values need to be added
    }

#region "Class RentReviewsTable_SerializationHelper"

    [SerializableAttribute()]
    private class RentReviewsTable_SerializationHelper: System.Runtime.Serialization.IObjectReference
    {
        //Method called after this object is deserialized
        public virtual object GetRealObject(System.Runtime.Serialization.StreamingContext context)
        {
            return RentReviewsTable.Instance;
        }
    }

#endregion

#endregion

    /// <summary>
    /// References the only instance of the <see cref="RentReviewsTable"></see> class.
    /// </summary>
    /// <remarks>
    /// Since the <see cref="RentReviewsTable"></see> class is implemented using the Singleton design pattern, 
    /// this field is the only way to access an instance of the class.
    /// </remarks>
    public readonly static RentReviewsTable Instance = new RentReviewsTable();

    public RentReviewsTable()
    {
    }


} // End class RentReviewsTable

}
