using System;
using System.Runtime.Serialization;

namespace MSBuildExtensionPack.EntityContracts
{
    /// <summary>
    /// definition of Organization with parameters of .Net value type.
    /// </summary>
	public partial interface IOrganization : IOrganizationIdentifier
	{ 

        System.Int64 ParentId { get; set; }


        System.String Name { get; set; }


        System.Boolean IsSystemBuiltIn { get; set; }


        System.Guid UniqueIdentifier { get; set; }


        System.DateTime CreatedDateTime { get; set; }


        System.String CharColumn { get; set; }


        System.String VarcharColumn { get; set; }


        System.String TextColumn { get; set; }


        System.String NcharColumn { get; set; }


        System.String NvarcharColumn { get; set; }


        System.String NtextColumn { get; set; }


        System.Boolean BitColumn { get; set; }


        System.Byte[] BinaryColumn { get; set; }


        System.Byte[] VarbinaryColumn { get; set; }


        System.Byte[] ImageColumn { get; set; }


        System.Byte TinyintColumn { get; set; }


        System.Int16 SmallintColumn { get; set; }


        System.Int32 IntColumn { get; set; }


        System.Int64 BigintColumn { get; set; }


        System.Decimal DecimalColumn { get; set; }


        System.Decimal NumericColumn { get; set; }


        System.Decimal SmallmoneyColumn { get; set; }


        System.Decimal MoneyColumn { get; set; }


        System.Single FloatColumn { get; set; }


        System.Single RealColumn { get; set; }


        System.DateTime DatetimeColumn { get; set; }


        System.DateTime Datetime2Column { get; set; }


        System.DateTime SmalldatetimeColumn { get; set; }


        System.DateTime DateColumn { get; set; }


        System.TimeSpan TimeColumn { get; set; }


        System.Guid UniqueidentifierColumn { get; set; }

	}

    /// <summary>
    /// a property defined when <see cref="WithEntityContractOrganization"/> is used in other classes.
    /// </summary>
    /// <typeparam name="T">a type inherits from <see cref="WithEntityContractOrganization"/></typeparam>
	public partial interface WithEntityContractOrganization<T>
        where T : IOrganization
    {
        /// <summary>
        /// Gets or sets the Organization
        /// </summary>
        /// <value>
        /// The Organization
        /// </value>
        T Organization { get; set; }
    }
}

