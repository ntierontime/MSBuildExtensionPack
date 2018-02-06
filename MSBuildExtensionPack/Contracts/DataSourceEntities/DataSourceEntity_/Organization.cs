using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace MSBuildExtensionPack.DataSourceEntities
{
    /// <summary>
    /// Entity class, used across the solution. <see cref="Organization"/>
    /// </summary>
    //[DataContract]
    public partial class Organization : Framework.PropertyChangedNotifier, MSBuildExtensionPack.EntityContracts.IOrganization, Framework.EntityContracts.IClone<Organization>
    {

        #region Storage Fields

        System.Int64 m_Id;

        System.Int64 m_ParentId;

        System.String m_Name;

        System.Boolean m_IsSystemBuiltIn;

        System.Guid m_UniqueIdentifier;

        System.DateTime m_CreatedDateTime;

        System.String m_CharColumn;

        System.String m_VarcharColumn;

        System.String m_TextColumn;

        System.String m_NcharColumn;

        System.String m_NvarcharColumn;

        System.String m_NtextColumn;

        System.Boolean m_BitColumn;

        System.Byte[] m_BinaryColumn;

        System.Byte[] m_VarbinaryColumn;

        System.Byte[] m_ImageColumn;

        System.Byte m_TinyintColumn;

        System.Int16 m_SmallintColumn;

        System.Int32 m_IntColumn;

        System.Int64 m_BigintColumn;

        System.Decimal m_DecimalColumn;

        System.Decimal m_NumericColumn;

        System.Decimal m_SmallmoneyColumn;

        System.Decimal m_MoneyColumn;

        System.Single m_FloatColumn;

        System.Single m_RealColumn;

        System.DateTime m_DatetimeColumn;

        System.DateTime m_Datetime2Column;

        System.DateTime m_SmalldatetimeColumn;

        System.DateTime m_DateColumn;

        System.TimeSpan m_TimeColumn;

        System.Guid m_UniqueidentifierColumn;

        #endregion Storage Fields

        /// <summary>
        /// Initializes a new instance of the <see cref=" Organization"/> class.
        /// </summary>
        public Organization()
        {
            this.Id = default(long);
            this.ParentId = default(long);
            this.Name = null;
            this.IsSystemBuiltIn = true;
            this.UniqueIdentifier = new Guid();
            this.CreatedDateTime = DateTime.Now;
            this.CharColumn = null;
            this.VarcharColumn = null;
            this.TextColumn = null;
            this.NcharColumn = null;
            this.NvarcharColumn = null;
            this.NtextColumn = null;
            this.BitColumn = true;
            this.BinaryColumn = null;
            this.VarbinaryColumn = null;
            this.ImageColumn = null;
            this.TinyintColumn = default(byte);
            this.SmallintColumn = default(short);
            this.IntColumn = default(int);
            this.BigintColumn = default(long);
            this.DecimalColumn = default(decimal);
            this.NumericColumn = default(decimal);
            this.SmallmoneyColumn = default(decimal);
            this.MoneyColumn = default(decimal);
            this.FloatColumn = default(System.Single);
            this.RealColumn = default(System.Single);
            this.DatetimeColumn = DateTime.Now;
            this.Datetime2Column = DateTime.Now;
            this.SmalldatetimeColumn = DateTime.Now;
            this.DateColumn = DateTime.Now;
            this.TimeColumn = default(TimeSpan);
            this.UniqueidentifierColumn = new Guid();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref=" Organization"/> class with .Net value type parameters.
        /// </summary>
        /// <param name="id">property value of Id</param>
        /// <param name="parentId">property value of ParentId</param>
        /// <param name="name">property value of Name</param>
        /// <param name="isSystemBuiltIn">property value of IsSystemBuiltIn</param>
        /// <param name="uniqueIdentifier">property value of UniqueIdentifier</param>
        /// <param name="createdDateTime">property value of CreatedDateTime</param>
        /// <param name="charColumn">property value of CharColumn</param>
        /// <param name="varcharColumn">property value of VarcharColumn</param>
        /// <param name="textColumn">property value of TextColumn</param>
        /// <param name="ncharColumn">property value of NcharColumn</param>
        /// <param name="nvarcharColumn">property value of NvarcharColumn</param>
        /// <param name="ntextColumn">property value of NtextColumn</param>
        /// <param name="bitColumn">property value of BitColumn</param>
        /// <param name="binaryColumn">property value of BinaryColumn</param>
        /// <param name="varbinaryColumn">property value of VarbinaryColumn</param>
        /// <param name="imageColumn">property value of ImageColumn</param>
        /// <param name="tinyintColumn">property value of TinyintColumn</param>
        /// <param name="smallintColumn">property value of SmallintColumn</param>
        /// <param name="intColumn">property value of IntColumn</param>
        /// <param name="bigintColumn">property value of BigintColumn</param>
        /// <param name="decimalColumn">property value of DecimalColumn</param>
        /// <param name="numericColumn">property value of NumericColumn</param>
        /// <param name="smallmoneyColumn">property value of SmallmoneyColumn</param>
        /// <param name="moneyColumn">property value of MoneyColumn</param>
        /// <param name="floatColumn">property value of FloatColumn</param>
        /// <param name="realColumn">property value of RealColumn</param>
        /// <param name="datetimeColumn">property value of DatetimeColumn</param>
        /// <param name="datetime2Column">property value of Datetime2Column</param>
        /// <param name="smalldatetimeColumn">property value of SmalldatetimeColumn</param>
        /// <param name="dateColumn">property value of DateColumn</param>
        /// <param name="timeColumn">property value of TimeColumn</param>
        /// <param name="uniqueidentifierColumn">property value of UniqueidentifierColumn</param>
        public Organization(
            System.Int64 id
            ,System.Int64 parentId
            ,System.String name
            ,System.Boolean isSystemBuiltIn
            ,System.Guid uniqueIdentifier
            ,System.DateTime createdDateTime
            ,System.String charColumn
            ,System.String varcharColumn
            ,System.String textColumn
            ,System.String ncharColumn
            ,System.String nvarcharColumn
            ,System.String ntextColumn
            ,System.Boolean bitColumn
            ,System.Byte[] binaryColumn
            ,System.Byte[] varbinaryColumn
            ,System.Byte[] imageColumn
            ,System.Byte tinyintColumn
            ,System.Int16 smallintColumn
            ,System.Int32 intColumn
            ,System.Int64 bigintColumn
            ,System.Decimal decimalColumn
            ,System.Decimal numericColumn
            ,System.Decimal smallmoneyColumn
            ,System.Decimal moneyColumn
            ,System.Single floatColumn
            ,System.Single realColumn
            ,System.DateTime datetimeColumn
            ,System.DateTime datetime2Column
            ,System.DateTime smalldatetimeColumn
            ,System.DateTime dateColumn
            ,System.TimeSpan timeColumn
            ,System.Guid uniqueidentifierColumn
            )
        {
            this.m_Id = id;
            this.m_ParentId = parentId;
            this.m_Name = name;
            this.m_IsSystemBuiltIn = isSystemBuiltIn;
            this.m_UniqueIdentifier = uniqueIdentifier;
            this.m_CreatedDateTime = createdDateTime;
            this.m_CharColumn = charColumn;
            this.m_VarcharColumn = varcharColumn;
            this.m_TextColumn = textColumn;
            this.m_NcharColumn = ncharColumn;
            this.m_NvarcharColumn = nvarcharColumn;
            this.m_NtextColumn = ntextColumn;
            this.m_BitColumn = bitColumn;
            this.m_BinaryColumn = binaryColumn;
            this.m_VarbinaryColumn = varbinaryColumn;
            this.m_ImageColumn = imageColumn;
            this.m_TinyintColumn = tinyintColumn;
            this.m_SmallintColumn = smallintColumn;
            this.m_IntColumn = intColumn;
            this.m_BigintColumn = bigintColumn;
            this.m_DecimalColumn = decimalColumn;
            this.m_NumericColumn = numericColumn;
            this.m_SmallmoneyColumn = smallmoneyColumn;
            this.m_MoneyColumn = moneyColumn;
            this.m_FloatColumn = floatColumn;
            this.m_RealColumn = realColumn;
            this.m_DatetimeColumn = datetimeColumn;
            this.m_Datetime2Column = datetime2Column;
            this.m_SmalldatetimeColumn = smalldatetimeColumn;
            this.m_DateColumn = dateColumn;
            this.m_TimeColumn = timeColumn;
            this.m_UniqueidentifierColumn = uniqueidentifierColumn;
        }

        /// <summary>
        /// Initializes/clone a new instance of the <see cref=" Organization"/> class.
        /// </summary>
        /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IOrganization"/></param>
        public Organization(MSBuildExtensionPack.EntityContracts.IOrganization item)
        {
            MSBuildExtensionPack.EntityContracts.IOrganizationHelper.Copy<MSBuildExtensionPack.EntityContracts.IOrganization, Organization>(item, this);
        }

        #region properties

                [DataMember]
        [Display(Name = "Id", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="Id_is_required")]        public System.Int64 Id
        {
            get
            {
                return m_Id;
            }
            set
            {
                m_Id = value;
                RaisePropertyChanged("Id");
            }
        }

                [DataMember]
        [Display(Name = "ParentId", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="ParentId_is_required")]        public System.Int64 ParentId
        {
            get
            {
                return m_ParentId;
            }
            set
            {
                m_ParentId = value;
                RaisePropertyChanged("ParentId");
            }
        }

                [DataMember]
        [Display(Name = "Name", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="Name_is_required")]
        [StringLengthAttribute(50, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="The_length_of_Name_should_be_0_to_50")]        public System.String Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
                RaisePropertyChanged("Name");
            }
        }

                [DataMember]
        [Display(Name = "IsSystemBuiltIn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="IsSystemBuiltIn_is_required")]        public System.Boolean IsSystemBuiltIn
        {
            get
            {
                return m_IsSystemBuiltIn;
            }
            set
            {
                m_IsSystemBuiltIn = value;
                RaisePropertyChanged("IsSystemBuiltIn");
            }
        }

                [DataMember]
        [Display(Name = "UniqueIdentifier", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="UniqueIdentifier_is_required")]        public System.Guid UniqueIdentifier
        {
            get
            {
                return m_UniqueIdentifier;
            }
            set
            {
                m_UniqueIdentifier = value;
                RaisePropertyChanged("UniqueIdentifier");
            }
        }

                [DataMember]
        [Display(Name = "CreatedDateTime", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="CreatedDateTime_is_required")]        public System.DateTime CreatedDateTime
        {
            get
            {
                return m_CreatedDateTime;
            }
            set
            {
                m_CreatedDateTime = value;
                RaisePropertyChanged("CreatedDateTime");
            }
        }

                [DataMember]
        [Display(Name = "CharColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="CharColumn_is_required")]
        [StringLengthAttribute(10, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="The_length_of_CharColumn_should_be_0_to_10")]        public System.String CharColumn
        {
            get
            {
                return m_CharColumn;
            }
            set
            {
                m_CharColumn = value;
                RaisePropertyChanged("CharColumn");
            }
        }

                [DataMember]
        [Display(Name = "VarcharColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="VarcharColumn_is_required")]        public System.String VarcharColumn
        {
            get
            {
                return m_VarcharColumn;
            }
            set
            {
                m_VarcharColumn = value;
                RaisePropertyChanged("VarcharColumn");
            }
        }

                [DataMember]
        [Display(Name = "TextColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="TextColumn_is_required")]        public System.String TextColumn
        {
            get
            {
                return m_TextColumn;
            }
            set
            {
                m_TextColumn = value;
                RaisePropertyChanged("TextColumn");
            }
        }

                [DataMember]
        [Display(Name = "NcharColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="NcharColumn_is_required")]
        [StringLengthAttribute(1, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="The_length_of_NcharColumn_should_be_0_to_1")]        public System.String NcharColumn
        {
            get
            {
                return m_NcharColumn;
            }
            set
            {
                m_NcharColumn = value;
                RaisePropertyChanged("NcharColumn");
            }
        }

                [DataMember]
        [Display(Name = "NvarcharColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="NvarcharColumn_is_required")]        public System.String NvarcharColumn
        {
            get
            {
                return m_NvarcharColumn;
            }
            set
            {
                m_NvarcharColumn = value;
                RaisePropertyChanged("NvarcharColumn");
            }
        }

                [DataMember]
        [Display(Name = "NtextColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="NtextColumn_is_required")]        public System.String NtextColumn
        {
            get
            {
                return m_NtextColumn;
            }
            set
            {
                m_NtextColumn = value;
                RaisePropertyChanged("NtextColumn");
            }
        }

                [DataMember]
        [Display(Name = "BitColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="BitColumn_is_required")]        public System.Boolean BitColumn
        {
            get
            {
                return m_BitColumn;
            }
            set
            {
                m_BitColumn = value;
                RaisePropertyChanged("BitColumn");
            }
        }

                [DataMember]
        [Display(Name = "BinaryColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Byte[] BinaryColumn
        {
            get
            {
                return m_BinaryColumn;
            }
            set
            {
                m_BinaryColumn = value;
                RaisePropertyChanged("BinaryColumn");
            }
        }

                [DataMember]
        [Display(Name = "VarbinaryColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Byte[] VarbinaryColumn
        {
            get
            {
                return m_VarbinaryColumn;
            }
            set
            {
                m_VarbinaryColumn = value;
                RaisePropertyChanged("VarbinaryColumn");
            }
        }

                [DataMember]
        [Display(Name = "ImageColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Byte[] ImageColumn
        {
            get
            {
                return m_ImageColumn;
            }
            set
            {
                m_ImageColumn = value;
                RaisePropertyChanged("ImageColumn");
            }
        }

                [DataMember]
        [Display(Name = "TinyintColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="TinyintColumn_is_required")]        public System.Byte TinyintColumn
        {
            get
            {
                return m_TinyintColumn;
            }
            set
            {
                m_TinyintColumn = value;
                RaisePropertyChanged("TinyintColumn");
            }
        }

                [DataMember]
        [Display(Name = "SmallintColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="SmallintColumn_is_required")]        public System.Int16 SmallintColumn
        {
            get
            {
                return m_SmallintColumn;
            }
            set
            {
                m_SmallintColumn = value;
                RaisePropertyChanged("SmallintColumn");
            }
        }

                [DataMember]
        [Display(Name = "IntColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="IntColumn_is_required")]        public System.Int32 IntColumn
        {
            get
            {
                return m_IntColumn;
            }
            set
            {
                m_IntColumn = value;
                RaisePropertyChanged("IntColumn");
            }
        }

                [DataMember]
        [Display(Name = "BigintColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="BigintColumn_is_required")]        public System.Int64 BigintColumn
        {
            get
            {
                return m_BigintColumn;
            }
            set
            {
                m_BigintColumn = value;
                RaisePropertyChanged("BigintColumn");
            }
        }

                [DataMember]
        [Display(Name = "DecimalColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="DecimalColumn_is_required")]        public System.Decimal DecimalColumn
        {
            get
            {
                return m_DecimalColumn;
            }
            set
            {
                m_DecimalColumn = value;
                RaisePropertyChanged("DecimalColumn");
            }
        }

                [DataMember]
        [Display(Name = "NumericColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="NumericColumn_is_required")]        public System.Decimal NumericColumn
        {
            get
            {
                return m_NumericColumn;
            }
            set
            {
                m_NumericColumn = value;
                RaisePropertyChanged("NumericColumn");
            }
        }

                [DataMember]
        [Display(Name = "SmallmoneyColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="SmallmoneyColumn_is_required")]        public System.Decimal SmallmoneyColumn
        {
            get
            {
                return m_SmallmoneyColumn;
            }
            set
            {
                m_SmallmoneyColumn = value;
                RaisePropertyChanged("SmallmoneyColumn");
            }
        }

                [DataMember]
        [Display(Name = "MoneyColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="MoneyColumn_is_required")]        public System.Decimal MoneyColumn
        {
            get
            {
                return m_MoneyColumn;
            }
            set
            {
                m_MoneyColumn = value;
                RaisePropertyChanged("MoneyColumn");
            }
        }

                [DataMember]
        [Display(Name = "FloatColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="FloatColumn_is_required")]        public System.Single FloatColumn
        {
            get
            {
                return m_FloatColumn;
            }
            set
            {
                m_FloatColumn = value;
                RaisePropertyChanged("FloatColumn");
            }
        }

                [DataMember]
        [Display(Name = "RealColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="RealColumn_is_required")]        public System.Single RealColumn
        {
            get
            {
                return m_RealColumn;
            }
            set
            {
                m_RealColumn = value;
                RaisePropertyChanged("RealColumn");
            }
        }

                [DataMember]
        [Display(Name = "DatetimeColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="DatetimeColumn_is_required")]        public System.DateTime DatetimeColumn
        {
            get
            {
                return m_DatetimeColumn;
            }
            set
            {
                m_DatetimeColumn = value;
                RaisePropertyChanged("DatetimeColumn");
            }
        }

                [DataMember]
        [Display(Name = "Datetime2Column", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="Datetime2Column_is_required")]        public System.DateTime Datetime2Column
        {
            get
            {
                return m_Datetime2Column;
            }
            set
            {
                m_Datetime2Column = value;
                RaisePropertyChanged("Datetime2Column");
            }
        }

                [DataMember]
        [Display(Name = "SmalldatetimeColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="SmalldatetimeColumn_is_required")]        public System.DateTime SmalldatetimeColumn
        {
            get
            {
                return m_SmalldatetimeColumn;
            }
            set
            {
                m_SmalldatetimeColumn = value;
                RaisePropertyChanged("SmalldatetimeColumn");
            }
        }

                [DataMember]
        [Display(Name = "DateColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="DateColumn_is_required")]        public System.DateTime DateColumn
        {
            get
            {
                return m_DateColumn;
            }
            set
            {
                m_DateColumn = value;
                RaisePropertyChanged("DateColumn");
            }
        }

                [DataMember]
        [Display(Name = "TimeColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="TimeColumn_is_required")]        public System.TimeSpan TimeColumn
        {
            get
            {
                return m_TimeColumn;
            }
            set
            {
                m_TimeColumn = value;
                RaisePropertyChanged("TimeColumn");
            }
        }

                [DataMember]
        [Display(Name = "UniqueidentifierColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="UniqueidentifierColumn_is_required")]        public System.Guid UniqueidentifierColumn
        {
            get
            {
                return m_UniqueidentifierColumn;
            }
            set
            {
                m_UniqueidentifierColumn = value;
                RaisePropertyChanged("UniqueidentifierColumn");
            }
        }

        #endregion properties

        #region override methods

        /// <summary>
        /// Returns a <see cref="System.String"/> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            return MSBuildExtensionPack.EntityContracts.IOrganizationHelper.ToString<Organization>(this);
        }

        /// <summary>
        /// Determines whether the specified <see cref="System.Object"/> is equal to this instance.
        /// </summary>
        /// <param name="obj">The <see cref="System.Object"/> to compare with this instance.</param>
        /// <returns>
        ///   <c>true</c> if the specified <see cref="System.Object"/> is equal to this instance; otherwise, <c>false</c>.
        /// </returns>
        public override bool Equals(object obj)
        {
            bool _retval = obj is Organization;
            if (_retval == true)
            {
                _retval = MSBuildExtensionPack.EntityContracts.IOrganizationHelper.Equals<Organization, Organization>(this, (Organization)obj);
            }
            return _retval;
        }

        /// <summary>
        /// Returns a hash code for this instance.
        /// </summary>
        /// <returns>
        /// A hash code for this instance, suitable for use in hashing algorithms and data structures like a hash table.
        /// </returns>
        public override int GetHashCode()
        {
            return this.ToString().GetHashCode();
        }

        #endregion override methods

        #region Method of Organization GetAClone()

        /// <summary>
        /// Gets the A clone.
        /// </summary>
        /// <returns>a new instance with same value</returns>
        public Organization GetAClone()
        {
            return MSBuildExtensionPack.EntityContracts.IOrganizationHelper.Clone<Organization, Organization>(this);
        }

        public Organization GetACloneWithoutIdentifier()
        {
            var cloned = GetAClone();

            return cloned;
        }

        #endregion Method of Organization GetAClone()

        #region Nested Views classes and their collection classes 4

        /// <summary>
        /// View "Default" class of <see cref="Organization"/>, used across the solution.
        /// </summary>
        public partial class Default :Framework.PropertyChangedNotifier, MSBuildExtensionPack.EntityContracts.IOrganization, Framework.EntityContracts.IClone<Default>
        {

            #region Storage Fields

        System.Guid m_Organization_2_UniqueIdentifier;

        System.Guid m_Organization_2_UniqueidentifierColumn;

        System.String m_Organization_2_Name;

        System.Int64 m_Id;

        System.Int64 m_ParentId;

        System.String m_Name;

        System.Boolean m_IsSystemBuiltIn;

        System.Guid m_UniqueIdentifier;

        System.DateTime m_CreatedDateTime;

        System.String m_CharColumn;

        System.String m_VarcharColumn;

        System.String m_TextColumn;

        System.String m_NcharColumn;

        System.String m_NvarcharColumn;

        System.String m_NtextColumn;

        System.Boolean m_BitColumn;

        System.Byte[] m_BinaryColumn;

        System.Byte[] m_VarbinaryColumn;

        System.Byte[] m_ImageColumn;

        System.Byte m_TinyintColumn;

        System.Int16 m_SmallintColumn;

        System.Int32 m_IntColumn;

        System.Int64 m_BigintColumn;

        System.Decimal m_DecimalColumn;

        System.Decimal m_NumericColumn;

        System.Decimal m_SmallmoneyColumn;

        System.Decimal m_MoneyColumn;

        System.Single m_FloatColumn;

        System.Single m_RealColumn;

        System.DateTime m_DatetimeColumn;

        System.DateTime m_Datetime2Column;

        System.DateTime m_SmalldatetimeColumn;

        System.DateTime m_DateColumn;

        System.TimeSpan m_TimeColumn;

        System.Guid m_UniqueidentifierColumn;

            #endregion Storage Fields

            #region Constructors

            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" Organization"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IOrganization"/></param>
            public Default()
            {
                this.Organization_2_UniqueIdentifier = new Guid();
                this.Organization_2_UniqueidentifierColumn = new Guid();
                this.Organization_2_Name = null;
                this.Id = default(long);
                this.ParentId = default(long);
                this.Name = null;
                this.IsSystemBuiltIn = true;
                this.UniqueIdentifier = new Guid();
                this.CreatedDateTime = DateTime.Now;
                this.CharColumn = null;
                this.VarcharColumn = null;
                this.TextColumn = null;
                this.NcharColumn = null;
                this.NvarcharColumn = null;
                this.NtextColumn = null;
                this.BitColumn = true;
                this.BinaryColumn = null;
                this.VarbinaryColumn = null;
                this.ImageColumn = null;
                this.TinyintColumn = default(byte);
                this.SmallintColumn = default(short);
                this.IntColumn = default(int);
                this.BigintColumn = default(long);
                this.DecimalColumn = default(decimal);
                this.NumericColumn = default(decimal);
                this.SmallmoneyColumn = default(decimal);
                this.MoneyColumn = default(decimal);
                this.FloatColumn = default(System.Single);
                this.RealColumn = default(System.Single);
                this.DatetimeColumn = DateTime.Now;
                this.Datetime2Column = DateTime.Now;
                this.SmalldatetimeColumn = DateTime.Now;
                this.DateColumn = DateTime.Now;
                this.TimeColumn = default(TimeSpan);
                this.UniqueidentifierColumn = new Guid();
            }
            /*
            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" Organization"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IOrganization"/></param>
            public Default(MSBuildExtensionPack.EntityContracts.IOrganization item)
            {
                MSBuildExtensionPack.EntityContracts.IOrganizationHelper.Copy<MSBuildExtensionPack.EntityContracts.IOrganization, Default>(item, this);
            }
            */
            #endregion Constructors

            #region properties

                    [DataMember]
        [Display(Name = "Organization_2_UniqueIdentifier", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Guid Organization_2_UniqueIdentifier
        {
            get
            {
                return m_Organization_2_UniqueIdentifier;
            }
            set
            {
                m_Organization_2_UniqueIdentifier = value;
                RaisePropertyChanged("Organization_2_UniqueIdentifier");
            }
        }

                    [DataMember]
        [Display(Name = "Organization_2_UniqueidentifierColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Guid Organization_2_UniqueidentifierColumn
        {
            get
            {
                return m_Organization_2_UniqueidentifierColumn;
            }
            set
            {
                m_Organization_2_UniqueidentifierColumn = value;
                RaisePropertyChanged("Organization_2_UniqueidentifierColumn");
            }
        }

                    [DataMember]
        [Display(Name = "Organization_2_Name", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.String Organization_2_Name
        {
            get
            {
                return m_Organization_2_Name;
            }
            set
            {
                m_Organization_2_Name = value;
                RaisePropertyChanged("Organization_2_Name");
            }
        }

                    [DataMember]
        [Display(Name = "Id", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="Id_is_required")]        public System.Int64 Id
        {
            get
            {
                return m_Id;
            }
            set
            {
                m_Id = value;
                RaisePropertyChanged("Id");
            }
        }

                    [DataMember]
        [Display(Name = "ParentId", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="ParentId_is_required")]        public System.Int64 ParentId
        {
            get
            {
                return m_ParentId;
            }
            set
            {
                m_ParentId = value;
                RaisePropertyChanged("ParentId");
            }
        }

                    [DataMember]
        [Display(Name = "Name", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="Name_is_required")]
        [StringLengthAttribute(50, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="The_length_of_Name_should_be_0_to_50")]        public System.String Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
                RaisePropertyChanged("Name");
            }
        }

                    [DataMember]
        [Display(Name = "IsSystemBuiltIn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="IsSystemBuiltIn_is_required")]        public System.Boolean IsSystemBuiltIn
        {
            get
            {
                return m_IsSystemBuiltIn;
            }
            set
            {
                m_IsSystemBuiltIn = value;
                RaisePropertyChanged("IsSystemBuiltIn");
            }
        }

                    [DataMember]
        [Display(Name = "UniqueIdentifier", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="UniqueIdentifier_is_required")]        public System.Guid UniqueIdentifier
        {
            get
            {
                return m_UniqueIdentifier;
            }
            set
            {
                m_UniqueIdentifier = value;
                RaisePropertyChanged("UniqueIdentifier");
            }
        }

                    [DataMember]
        [Display(Name = "CreatedDateTime", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="CreatedDateTime_is_required")]        public System.DateTime CreatedDateTime
        {
            get
            {
                return m_CreatedDateTime;
            }
            set
            {
                m_CreatedDateTime = value;
                RaisePropertyChanged("CreatedDateTime");
            }
        }

                    [DataMember]
        [Display(Name = "CharColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="CharColumn_is_required")]
        [StringLengthAttribute(10, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="The_length_of_CharColumn_should_be_0_to_10")]        public System.String CharColumn
        {
            get
            {
                return m_CharColumn;
            }
            set
            {
                m_CharColumn = value;
                RaisePropertyChanged("CharColumn");
            }
        }

                    [DataMember]
        [Display(Name = "VarcharColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="VarcharColumn_is_required")]        public System.String VarcharColumn
        {
            get
            {
                return m_VarcharColumn;
            }
            set
            {
                m_VarcharColumn = value;
                RaisePropertyChanged("VarcharColumn");
            }
        }

                    [DataMember]
        [Display(Name = "TextColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="TextColumn_is_required")]        public System.String TextColumn
        {
            get
            {
                return m_TextColumn;
            }
            set
            {
                m_TextColumn = value;
                RaisePropertyChanged("TextColumn");
            }
        }

                    [DataMember]
        [Display(Name = "NcharColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="NcharColumn_is_required")]
        [StringLengthAttribute(1, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="The_length_of_NcharColumn_should_be_0_to_1")]        public System.String NcharColumn
        {
            get
            {
                return m_NcharColumn;
            }
            set
            {
                m_NcharColumn = value;
                RaisePropertyChanged("NcharColumn");
            }
        }

                    [DataMember]
        [Display(Name = "NvarcharColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="NvarcharColumn_is_required")]        public System.String NvarcharColumn
        {
            get
            {
                return m_NvarcharColumn;
            }
            set
            {
                m_NvarcharColumn = value;
                RaisePropertyChanged("NvarcharColumn");
            }
        }

                    [DataMember]
        [Display(Name = "NtextColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="NtextColumn_is_required")]        public System.String NtextColumn
        {
            get
            {
                return m_NtextColumn;
            }
            set
            {
                m_NtextColumn = value;
                RaisePropertyChanged("NtextColumn");
            }
        }

                    [DataMember]
        [Display(Name = "BitColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="BitColumn_is_required")]        public System.Boolean BitColumn
        {
            get
            {
                return m_BitColumn;
            }
            set
            {
                m_BitColumn = value;
                RaisePropertyChanged("BitColumn");
            }
        }

                    [DataMember]
        [Display(Name = "BinaryColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Byte[] BinaryColumn
        {
            get
            {
                return m_BinaryColumn;
            }
            set
            {
                m_BinaryColumn = value;
                RaisePropertyChanged("BinaryColumn");
            }
        }

                    [DataMember]
        [Display(Name = "VarbinaryColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Byte[] VarbinaryColumn
        {
            get
            {
                return m_VarbinaryColumn;
            }
            set
            {
                m_VarbinaryColumn = value;
                RaisePropertyChanged("VarbinaryColumn");
            }
        }

                    [DataMember]
        [Display(Name = "ImageColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Byte[] ImageColumn
        {
            get
            {
                return m_ImageColumn;
            }
            set
            {
                m_ImageColumn = value;
                RaisePropertyChanged("ImageColumn");
            }
        }

                    [DataMember]
        [Display(Name = "TinyintColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="TinyintColumn_is_required")]        public System.Byte TinyintColumn
        {
            get
            {
                return m_TinyintColumn;
            }
            set
            {
                m_TinyintColumn = value;
                RaisePropertyChanged("TinyintColumn");
            }
        }

                    [DataMember]
        [Display(Name = "SmallintColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="SmallintColumn_is_required")]        public System.Int16 SmallintColumn
        {
            get
            {
                return m_SmallintColumn;
            }
            set
            {
                m_SmallintColumn = value;
                RaisePropertyChanged("SmallintColumn");
            }
        }

                    [DataMember]
        [Display(Name = "IntColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="IntColumn_is_required")]        public System.Int32 IntColumn
        {
            get
            {
                return m_IntColumn;
            }
            set
            {
                m_IntColumn = value;
                RaisePropertyChanged("IntColumn");
            }
        }

                    [DataMember]
        [Display(Name = "BigintColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="BigintColumn_is_required")]        public System.Int64 BigintColumn
        {
            get
            {
                return m_BigintColumn;
            }
            set
            {
                m_BigintColumn = value;
                RaisePropertyChanged("BigintColumn");
            }
        }

                    [DataMember]
        [Display(Name = "DecimalColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="DecimalColumn_is_required")]        public System.Decimal DecimalColumn
        {
            get
            {
                return m_DecimalColumn;
            }
            set
            {
                m_DecimalColumn = value;
                RaisePropertyChanged("DecimalColumn");
            }
        }

                    [DataMember]
        [Display(Name = "NumericColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="NumericColumn_is_required")]        public System.Decimal NumericColumn
        {
            get
            {
                return m_NumericColumn;
            }
            set
            {
                m_NumericColumn = value;
                RaisePropertyChanged("NumericColumn");
            }
        }

                    [DataMember]
        [Display(Name = "SmallmoneyColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="SmallmoneyColumn_is_required")]        public System.Decimal SmallmoneyColumn
        {
            get
            {
                return m_SmallmoneyColumn;
            }
            set
            {
                m_SmallmoneyColumn = value;
                RaisePropertyChanged("SmallmoneyColumn");
            }
        }

                    [DataMember]
        [Display(Name = "MoneyColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="MoneyColumn_is_required")]        public System.Decimal MoneyColumn
        {
            get
            {
                return m_MoneyColumn;
            }
            set
            {
                m_MoneyColumn = value;
                RaisePropertyChanged("MoneyColumn");
            }
        }

                    [DataMember]
        [Display(Name = "FloatColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="FloatColumn_is_required")]        public System.Single FloatColumn
        {
            get
            {
                return m_FloatColumn;
            }
            set
            {
                m_FloatColumn = value;
                RaisePropertyChanged("FloatColumn");
            }
        }

                    [DataMember]
        [Display(Name = "RealColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="RealColumn_is_required")]        public System.Single RealColumn
        {
            get
            {
                return m_RealColumn;
            }
            set
            {
                m_RealColumn = value;
                RaisePropertyChanged("RealColumn");
            }
        }

                    [DataMember]
        [Display(Name = "DatetimeColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="DatetimeColumn_is_required")]        public System.DateTime DatetimeColumn
        {
            get
            {
                return m_DatetimeColumn;
            }
            set
            {
                m_DatetimeColumn = value;
                RaisePropertyChanged("DatetimeColumn");
            }
        }

                    [DataMember]
        [Display(Name = "Datetime2Column", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="Datetime2Column_is_required")]        public System.DateTime Datetime2Column
        {
            get
            {
                return m_Datetime2Column;
            }
            set
            {
                m_Datetime2Column = value;
                RaisePropertyChanged("Datetime2Column");
            }
        }

                    [DataMember]
        [Display(Name = "SmalldatetimeColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="SmalldatetimeColumn_is_required")]        public System.DateTime SmalldatetimeColumn
        {
            get
            {
                return m_SmalldatetimeColumn;
            }
            set
            {
                m_SmalldatetimeColumn = value;
                RaisePropertyChanged("SmalldatetimeColumn");
            }
        }

                    [DataMember]
        [Display(Name = "DateColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="DateColumn_is_required")]        public System.DateTime DateColumn
        {
            get
            {
                return m_DateColumn;
            }
            set
            {
                m_DateColumn = value;
                RaisePropertyChanged("DateColumn");
            }
        }

                    [DataMember]
        [Display(Name = "TimeColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="TimeColumn_is_required")]        public System.TimeSpan TimeColumn
        {
            get
            {
                return m_TimeColumn;
            }
            set
            {
                m_TimeColumn = value;
                RaisePropertyChanged("TimeColumn");
            }
        }

                    [DataMember]
        [Display(Name = "UniqueidentifierColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="UniqueidentifierColumn_is_required")]        public System.Guid UniqueidentifierColumn
        {
            get
            {
                return m_UniqueidentifierColumn;
            }
            set
            {
                m_UniqueidentifierColumn = value;
                RaisePropertyChanged("UniqueidentifierColumn");
            }
        }

            #endregion properties

            #region Method of Organization.Default  GetAClone()

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public Default GetAClone()
            {
                Default cloned = new Default();

            cloned.m_Organization_2_UniqueIdentifier = m_Organization_2_UniqueIdentifier;
            cloned.m_Organization_2_UniqueidentifierColumn = m_Organization_2_UniqueidentifierColumn;
            cloned.m_Organization_2_Name = m_Organization_2_Name;
            cloned.m_Id = m_Id;
            cloned.m_ParentId = m_ParentId;
            cloned.m_Name = m_Name;
            cloned.m_IsSystemBuiltIn = m_IsSystemBuiltIn;
            cloned.m_UniqueIdentifier = m_UniqueIdentifier;
            cloned.m_CreatedDateTime = m_CreatedDateTime;
            cloned.m_CharColumn = m_CharColumn;
            cloned.m_VarcharColumn = m_VarcharColumn;
            cloned.m_TextColumn = m_TextColumn;
            cloned.m_NcharColumn = m_NcharColumn;
            cloned.m_NvarcharColumn = m_NvarcharColumn;
            cloned.m_NtextColumn = m_NtextColumn;
            cloned.m_BitColumn = m_BitColumn;
            cloned.m_BinaryColumn = m_BinaryColumn;
            cloned.m_VarbinaryColumn = m_VarbinaryColumn;
            cloned.m_ImageColumn = m_ImageColumn;
            cloned.m_TinyintColumn = m_TinyintColumn;
            cloned.m_SmallintColumn = m_SmallintColumn;
            cloned.m_IntColumn = m_IntColumn;
            cloned.m_BigintColumn = m_BigintColumn;
            cloned.m_DecimalColumn = m_DecimalColumn;
            cloned.m_NumericColumn = m_NumericColumn;
            cloned.m_SmallmoneyColumn = m_SmallmoneyColumn;
            cloned.m_MoneyColumn = m_MoneyColumn;
            cloned.m_FloatColumn = m_FloatColumn;
            cloned.m_RealColumn = m_RealColumn;
            cloned.m_DatetimeColumn = m_DatetimeColumn;
            cloned.m_Datetime2Column = m_Datetime2Column;
            cloned.m_SmalldatetimeColumn = m_SmalldatetimeColumn;
            cloned.m_DateColumn = m_DateColumn;
            cloned.m_TimeColumn = m_TimeColumn;
            cloned.m_UniqueidentifierColumn = m_UniqueidentifierColumn;

                return cloned;
            }

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public Default GetACloneWithoutIdentifier()
            {
                Default cloned = GetAClone();

                return cloned;
            }

            #endregion Method of Organization.Default  GetAClone()
        }

        /// <summary>
        /// View "Default" class of <see cref="Organization"/>, used across the solution.
        /// </summary>
        public partial class DefaultCollection
            :  List<Default>
        {
        }

        /// <summary>
        /// message definition of "Default", pass single entry, from database, to business logic layer. <see cref="Organization"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfDefault
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<Default>
        {
        }

        /// <summary>
        /// message definition of "Default", pass a collection of instances, from database, to business logic layer. <see cref="Organization"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfDefaultCollection
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<DefaultCollection>
        {
        }

        /// <summary>
        /// View "DefaultWithPath" class of <see cref="Organization"/>, used across the solution.
        /// </summary>
        public partial class DefaultWithPath :Framework.PropertyChangedNotifier, MSBuildExtensionPack.EntityContracts.IOrganization, Framework.EntityContracts.IClone<DefaultWithPath>
        {

            #region Storage Fields

        System.Int64 m_Id;

        System.String m_RecursivePath__;

        System.Int64 m_ParentId;

        System.String m_Name;

        System.Boolean m_IsSystemBuiltIn;

        System.Guid m_UniqueIdentifier;

        System.DateTime m_CreatedDateTime;

        System.String m_CharColumn;

        System.String m_VarcharColumn;

        System.String m_TextColumn;

        System.String m_NcharColumn;

        System.String m_NvarcharColumn;

        System.String m_NtextColumn;

        System.Boolean m_BitColumn;

        System.Byte[] m_BinaryColumn;

        System.Byte[] m_VarbinaryColumn;

        System.Byte[] m_ImageColumn;

        System.Byte m_TinyintColumn;

        System.Int16 m_SmallintColumn;

        System.Int32 m_IntColumn;

        System.Int64 m_BigintColumn;

        System.Decimal m_DecimalColumn;

        System.Decimal m_NumericColumn;

        System.Decimal m_SmallmoneyColumn;

        System.Decimal m_MoneyColumn;

        System.Single m_FloatColumn;

        System.Single m_RealColumn;

        System.DateTime m_DatetimeColumn;

        System.DateTime m_Datetime2Column;

        System.DateTime m_SmalldatetimeColumn;

        System.DateTime m_DateColumn;

        System.TimeSpan m_TimeColumn;

        System.Guid m_UniqueidentifierColumn;

            #endregion Storage Fields

            #region Constructors

            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" Organization"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IOrganization"/></param>
            public DefaultWithPath()
            {
                this.Id = default(long);
                this.RecursivePath__ = null;
                this.ParentId = default(long);
                this.Name = null;
                this.IsSystemBuiltIn = true;
                this.UniqueIdentifier = new Guid();
                this.CreatedDateTime = DateTime.Now;
                this.CharColumn = null;
                this.VarcharColumn = null;
                this.TextColumn = null;
                this.NcharColumn = null;
                this.NvarcharColumn = null;
                this.NtextColumn = null;
                this.BitColumn = true;
                this.BinaryColumn = null;
                this.VarbinaryColumn = null;
                this.ImageColumn = null;
                this.TinyintColumn = default(byte);
                this.SmallintColumn = default(short);
                this.IntColumn = default(int);
                this.BigintColumn = default(long);
                this.DecimalColumn = default(decimal);
                this.NumericColumn = default(decimal);
                this.SmallmoneyColumn = default(decimal);
                this.MoneyColumn = default(decimal);
                this.FloatColumn = default(System.Single);
                this.RealColumn = default(System.Single);
                this.DatetimeColumn = DateTime.Now;
                this.Datetime2Column = DateTime.Now;
                this.SmalldatetimeColumn = DateTime.Now;
                this.DateColumn = DateTime.Now;
                this.TimeColumn = default(TimeSpan);
                this.UniqueidentifierColumn = new Guid();
            }
            /*
            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" Organization"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IOrganization"/></param>
            public DefaultWithPath(MSBuildExtensionPack.EntityContracts.IOrganization item)
            {
                MSBuildExtensionPack.EntityContracts.IOrganizationHelper.Copy<MSBuildExtensionPack.EntityContracts.IOrganization, DefaultWithPath>(item, this);
            }
            */
            #endregion Constructors

            #region properties

                    [DataMember]
        [Display(Name = "Id", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Int64 Id
        {
            get
            {
                return m_Id;
            }
            set
            {
                m_Id = value;
                RaisePropertyChanged("Id");
            }
        }

                    [DataMember]
        [Display(Name = "RecursivePath__", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.String RecursivePath__
        {
            get
            {
                return m_RecursivePath__;
            }
            set
            {
                m_RecursivePath__ = value;
                RaisePropertyChanged("RecursivePath__");
            }
        }

                    [DataMember]
        [Display(Name = "ParentId", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Int64 ParentId
        {
            get
            {
                return m_ParentId;
            }
            set
            {
                m_ParentId = value;
                RaisePropertyChanged("ParentId");
            }
        }

                    [DataMember]
        [Display(Name = "Name", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.String Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
                RaisePropertyChanged("Name");
            }
        }

                    [DataMember]
        [Display(Name = "IsSystemBuiltIn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Boolean IsSystemBuiltIn
        {
            get
            {
                return m_IsSystemBuiltIn;
            }
            set
            {
                m_IsSystemBuiltIn = value;
                RaisePropertyChanged("IsSystemBuiltIn");
            }
        }

                    [DataMember]
        [Display(Name = "UniqueIdentifier", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Guid UniqueIdentifier
        {
            get
            {
                return m_UniqueIdentifier;
            }
            set
            {
                m_UniqueIdentifier = value;
                RaisePropertyChanged("UniqueIdentifier");
            }
        }

                    [DataMember]
        [Display(Name = "CreatedDateTime", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.DateTime CreatedDateTime
        {
            get
            {
                return m_CreatedDateTime;
            }
            set
            {
                m_CreatedDateTime = value;
                RaisePropertyChanged("CreatedDateTime");
            }
        }

                    [DataMember]
        [Display(Name = "CharColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.String CharColumn
        {
            get
            {
                return m_CharColumn;
            }
            set
            {
                m_CharColumn = value;
                RaisePropertyChanged("CharColumn");
            }
        }

                    [DataMember]
        [Display(Name = "VarcharColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.String VarcharColumn
        {
            get
            {
                return m_VarcharColumn;
            }
            set
            {
                m_VarcharColumn = value;
                RaisePropertyChanged("VarcharColumn");
            }
        }

                    [DataMember]
        [Display(Name = "TextColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.String TextColumn
        {
            get
            {
                return m_TextColumn;
            }
            set
            {
                m_TextColumn = value;
                RaisePropertyChanged("TextColumn");
            }
        }

                    [DataMember]
        [Display(Name = "NcharColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.String NcharColumn
        {
            get
            {
                return m_NcharColumn;
            }
            set
            {
                m_NcharColumn = value;
                RaisePropertyChanged("NcharColumn");
            }
        }

                    [DataMember]
        [Display(Name = "NvarcharColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.String NvarcharColumn
        {
            get
            {
                return m_NvarcharColumn;
            }
            set
            {
                m_NvarcharColumn = value;
                RaisePropertyChanged("NvarcharColumn");
            }
        }

                    [DataMember]
        [Display(Name = "NtextColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.String NtextColumn
        {
            get
            {
                return m_NtextColumn;
            }
            set
            {
                m_NtextColumn = value;
                RaisePropertyChanged("NtextColumn");
            }
        }

                    [DataMember]
        [Display(Name = "BitColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Boolean BitColumn
        {
            get
            {
                return m_BitColumn;
            }
            set
            {
                m_BitColumn = value;
                RaisePropertyChanged("BitColumn");
            }
        }

                    [DataMember]
        [Display(Name = "BinaryColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Byte[] BinaryColumn
        {
            get
            {
                return m_BinaryColumn;
            }
            set
            {
                m_BinaryColumn = value;
                RaisePropertyChanged("BinaryColumn");
            }
        }

                    [DataMember]
        [Display(Name = "VarbinaryColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Byte[] VarbinaryColumn
        {
            get
            {
                return m_VarbinaryColumn;
            }
            set
            {
                m_VarbinaryColumn = value;
                RaisePropertyChanged("VarbinaryColumn");
            }
        }

                    [DataMember]
        [Display(Name = "ImageColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Byte[] ImageColumn
        {
            get
            {
                return m_ImageColumn;
            }
            set
            {
                m_ImageColumn = value;
                RaisePropertyChanged("ImageColumn");
            }
        }

                    [DataMember]
        [Display(Name = "TinyintColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Byte TinyintColumn
        {
            get
            {
                return m_TinyintColumn;
            }
            set
            {
                m_TinyintColumn = value;
                RaisePropertyChanged("TinyintColumn");
            }
        }

                    [DataMember]
        [Display(Name = "SmallintColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Int16 SmallintColumn
        {
            get
            {
                return m_SmallintColumn;
            }
            set
            {
                m_SmallintColumn = value;
                RaisePropertyChanged("SmallintColumn");
            }
        }

                    [DataMember]
        [Display(Name = "IntColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Int32 IntColumn
        {
            get
            {
                return m_IntColumn;
            }
            set
            {
                m_IntColumn = value;
                RaisePropertyChanged("IntColumn");
            }
        }

                    [DataMember]
        [Display(Name = "BigintColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Int64 BigintColumn
        {
            get
            {
                return m_BigintColumn;
            }
            set
            {
                m_BigintColumn = value;
                RaisePropertyChanged("BigintColumn");
            }
        }

                    [DataMember]
        [Display(Name = "DecimalColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Decimal DecimalColumn
        {
            get
            {
                return m_DecimalColumn;
            }
            set
            {
                m_DecimalColumn = value;
                RaisePropertyChanged("DecimalColumn");
            }
        }

                    [DataMember]
        [Display(Name = "NumericColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Decimal NumericColumn
        {
            get
            {
                return m_NumericColumn;
            }
            set
            {
                m_NumericColumn = value;
                RaisePropertyChanged("NumericColumn");
            }
        }

                    [DataMember]
        [Display(Name = "SmallmoneyColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Decimal SmallmoneyColumn
        {
            get
            {
                return m_SmallmoneyColumn;
            }
            set
            {
                m_SmallmoneyColumn = value;
                RaisePropertyChanged("SmallmoneyColumn");
            }
        }

                    [DataMember]
        [Display(Name = "MoneyColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Decimal MoneyColumn
        {
            get
            {
                return m_MoneyColumn;
            }
            set
            {
                m_MoneyColumn = value;
                RaisePropertyChanged("MoneyColumn");
            }
        }

                    [DataMember]
        [Display(Name = "FloatColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Single FloatColumn
        {
            get
            {
                return m_FloatColumn;
            }
            set
            {
                m_FloatColumn = value;
                RaisePropertyChanged("FloatColumn");
            }
        }

                    [DataMember]
        [Display(Name = "RealColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Single RealColumn
        {
            get
            {
                return m_RealColumn;
            }
            set
            {
                m_RealColumn = value;
                RaisePropertyChanged("RealColumn");
            }
        }

                    [DataMember]
        [Display(Name = "DatetimeColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.DateTime DatetimeColumn
        {
            get
            {
                return m_DatetimeColumn;
            }
            set
            {
                m_DatetimeColumn = value;
                RaisePropertyChanged("DatetimeColumn");
            }
        }

                    [DataMember]
        [Display(Name = "Datetime2Column", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.DateTime Datetime2Column
        {
            get
            {
                return m_Datetime2Column;
            }
            set
            {
                m_Datetime2Column = value;
                RaisePropertyChanged("Datetime2Column");
            }
        }

                    [DataMember]
        [Display(Name = "SmalldatetimeColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.DateTime SmalldatetimeColumn
        {
            get
            {
                return m_SmalldatetimeColumn;
            }
            set
            {
                m_SmalldatetimeColumn = value;
                RaisePropertyChanged("SmalldatetimeColumn");
            }
        }

                    [DataMember]
        [Display(Name = "DateColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.DateTime DateColumn
        {
            get
            {
                return m_DateColumn;
            }
            set
            {
                m_DateColumn = value;
                RaisePropertyChanged("DateColumn");
            }
        }

                    [DataMember]
        [Display(Name = "TimeColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.TimeSpan TimeColumn
        {
            get
            {
                return m_TimeColumn;
            }
            set
            {
                m_TimeColumn = value;
                RaisePropertyChanged("TimeColumn");
            }
        }

                    [DataMember]
        [Display(Name = "UniqueidentifierColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Guid UniqueidentifierColumn
        {
            get
            {
                return m_UniqueidentifierColumn;
            }
            set
            {
                m_UniqueidentifierColumn = value;
                RaisePropertyChanged("UniqueidentifierColumn");
            }
        }

            #endregion properties

            #region Method of Organization.DefaultWithPath  GetAClone()

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public DefaultWithPath GetAClone()
            {
                DefaultWithPath cloned = new DefaultWithPath();

            cloned.m_Id = m_Id;
            cloned.m_RecursivePath__ = m_RecursivePath__;
            cloned.m_ParentId = m_ParentId;
            cloned.m_Name = m_Name;
            cloned.m_IsSystemBuiltIn = m_IsSystemBuiltIn;
            cloned.m_UniqueIdentifier = m_UniqueIdentifier;
            cloned.m_CreatedDateTime = m_CreatedDateTime;
            cloned.m_CharColumn = m_CharColumn;
            cloned.m_VarcharColumn = m_VarcharColumn;
            cloned.m_TextColumn = m_TextColumn;
            cloned.m_NcharColumn = m_NcharColumn;
            cloned.m_NvarcharColumn = m_NvarcharColumn;
            cloned.m_NtextColumn = m_NtextColumn;
            cloned.m_BitColumn = m_BitColumn;
            cloned.m_BinaryColumn = m_BinaryColumn;
            cloned.m_VarbinaryColumn = m_VarbinaryColumn;
            cloned.m_ImageColumn = m_ImageColumn;
            cloned.m_TinyintColumn = m_TinyintColumn;
            cloned.m_SmallintColumn = m_SmallintColumn;
            cloned.m_IntColumn = m_IntColumn;
            cloned.m_BigintColumn = m_BigintColumn;
            cloned.m_DecimalColumn = m_DecimalColumn;
            cloned.m_NumericColumn = m_NumericColumn;
            cloned.m_SmallmoneyColumn = m_SmallmoneyColumn;
            cloned.m_MoneyColumn = m_MoneyColumn;
            cloned.m_FloatColumn = m_FloatColumn;
            cloned.m_RealColumn = m_RealColumn;
            cloned.m_DatetimeColumn = m_DatetimeColumn;
            cloned.m_Datetime2Column = m_Datetime2Column;
            cloned.m_SmalldatetimeColumn = m_SmalldatetimeColumn;
            cloned.m_DateColumn = m_DateColumn;
            cloned.m_TimeColumn = m_TimeColumn;
            cloned.m_UniqueidentifierColumn = m_UniqueidentifierColumn;

                return cloned;
            }

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public DefaultWithPath GetACloneWithoutIdentifier()
            {
                DefaultWithPath cloned = GetAClone();

                return cloned;
            }

            #endregion Method of Organization.DefaultWithPath  GetAClone()
        }

        /// <summary>
        /// View "DefaultWithPath" class of <see cref="Organization"/>, used across the solution.
        /// </summary>
        public partial class DefaultWithPathCollection
            :  List<DefaultWithPath>
        {
        }

        /// <summary>
        /// message definition of "DefaultWithPath", pass single entry, from database, to business logic layer. <see cref="Organization"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfDefaultWithPath
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<DefaultWithPath>
        {
        }

        /// <summary>
        /// message definition of "DefaultWithPath", pass a collection of instances, from database, to business logic layer. <see cref="Organization"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfDefaultWithPathCollection
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<DefaultWithPathCollection>
        {
        }

        /// <summary>
        /// View "DefaultGroupedDataView" class of <see cref="Organization"/>, used across the solution.
        /// </summary>
        public partial class DefaultGroupedDataView :Framework.PropertyChangedNotifier, Framework.EntityContracts.IClone<DefaultGroupedDataView>
        {

            #region Storage Fields

        System.Int64 m_ParentId;

        System.Int64 m_CountPerFK;

        System.String m_Name;

            #endregion Storage Fields

            #region Constructors

            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" Organization"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IOrganization"/></param>
            public DefaultGroupedDataView()
            {
                this.ParentId = default(long);
                this.CountPerFK = default(long);
                this.Name = null;
            }
            /*
            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" Organization"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IOrganization"/></param>
            public DefaultGroupedDataView(MSBuildExtensionPack.EntityContracts.IOrganization item)
            {
                MSBuildExtensionPack.EntityContracts.IOrganizationHelper.Copy<MSBuildExtensionPack.EntityContracts.IOrganization, DefaultGroupedDataView>(item, this);
            }
            */
            #endregion Constructors

            #region properties

                    [DataMember]
        [Display(Name = "ParentId", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="ParentId_is_required")]        public System.Int64 ParentId
        {
            get
            {
                return m_ParentId;
            }
            set
            {
                m_ParentId = value;
                RaisePropertyChanged("ParentId");
            }
        }

                    [DataMember]
        [Display(Name = "CountPerFK", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.Int64 CountPerFK
        {
            get
            {
                return m_CountPerFK;
            }
            set
            {
                m_CountPerFK = value;
                RaisePropertyChanged("CountPerFK");
            }
        }

                    [DataMember]
        [Display(Name = "Name", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]        public System.String Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
                RaisePropertyChanged("Name");
            }
        }

            #endregion properties

            #region Method of Organization.DefaultGroupedDataView  GetAClone()

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public DefaultGroupedDataView GetAClone()
            {
                DefaultGroupedDataView cloned = new DefaultGroupedDataView();

            cloned.m_ParentId = m_ParentId;
            cloned.m_CountPerFK = m_CountPerFK;
            cloned.m_Name = m_Name;

                return cloned;
            }

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public DefaultGroupedDataView GetACloneWithoutIdentifier()
            {
                DefaultGroupedDataView cloned = GetAClone();

                return cloned;
            }

            #endregion Method of Organization.DefaultGroupedDataView  GetAClone()
        }

        /// <summary>
        /// View "DefaultGroupedDataView" class of <see cref="Organization"/>, used across the solution.
        /// </summary>
        public partial class DefaultGroupedDataViewCollection
            :  List<DefaultGroupedDataView>
        {
        }

        /// <summary>
        /// message definition of "DefaultGroupedDataView", pass single entry, from database, to business logic layer. <see cref="Organization"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfDefaultGroupedDataView
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<DefaultGroupedDataView>
        {
        }

        /// <summary>
        /// message definition of "DefaultGroupedDataView", pass a collection of instances, from database, to business logic layer. <see cref="Organization"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfDefaultGroupedDataViewCollection
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<DefaultGroupedDataViewCollection>
        {
        }

        /// <summary>
        /// View "KeyInformation" class of <see cref="Organization"/>, used across the solution.
        /// </summary>
        public partial class KeyInformation :Framework.PropertyChangedNotifier, MSBuildExtensionPack.EntityContracts.IOrganizationIdentifier, Framework.EntityContracts.IClone<KeyInformation>
        {

            #region Storage Fields

        System.Int64 m_Id;

        System.String m_Name;

        System.Boolean m_IsSystemBuiltIn;

        System.Guid m_UniqueIdentifier;

        System.Boolean m_BitColumn;

        System.Guid m_UniqueidentifierColumn;

            #endregion Storage Fields

            #region Constructors

            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" Organization"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IOrganization"/></param>
            public KeyInformation()
            {
                this.Id = default(long);
                this.Name = null;
                this.IsSystemBuiltIn = true;
                this.UniqueIdentifier = new Guid();
                this.BitColumn = true;
                this.UniqueidentifierColumn = new Guid();
            }
            /*
            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" Organization"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IOrganization"/></param>
            public KeyInformation(MSBuildExtensionPack.EntityContracts.IOrganization item)
            {
                MSBuildExtensionPack.EntityContracts.IOrganizationHelper.Copy<MSBuildExtensionPack.EntityContracts.IOrganization, KeyInformation>(item, this);
            }
            */
            #endregion Constructors

            #region properties

                    [DataMember]
        [Display(Name = "Id", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="Id_is_required")]        public System.Int64 Id
        {
            get
            {
                return m_Id;
            }
            set
            {
                m_Id = value;
                RaisePropertyChanged("Id");
            }
        }

                    [DataMember]
        [Display(Name = "Name", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="Name_is_required")]
        [StringLengthAttribute(50, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="The_length_of_Name_should_be_0_to_50")]        public System.String Name
        {
            get
            {
                return m_Name;
            }
            set
            {
                m_Name = value;
                RaisePropertyChanged("Name");
            }
        }

                    [DataMember]
        [Display(Name = "IsSystemBuiltIn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="IsSystemBuiltIn_is_required")]        public System.Boolean IsSystemBuiltIn
        {
            get
            {
                return m_IsSystemBuiltIn;
            }
            set
            {
                m_IsSystemBuiltIn = value;
                RaisePropertyChanged("IsSystemBuiltIn");
            }
        }

                    [DataMember]
        [Display(Name = "UniqueIdentifier", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="UniqueIdentifier_is_required")]        public System.Guid UniqueIdentifier
        {
            get
            {
                return m_UniqueIdentifier;
            }
            set
            {
                m_UniqueIdentifier = value;
                RaisePropertyChanged("UniqueIdentifier");
            }
        }

                    [DataMember]
        [Display(Name = "BitColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="BitColumn_is_required")]        public System.Boolean BitColumn
        {
            get
            {
                return m_BitColumn;
            }
            set
            {
                m_BitColumn = value;
                RaisePropertyChanged("BitColumn");
            }
        }

                    [DataMember]
        [Display(Name = "UniqueidentifierColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityOrganization), ErrorMessageResourceName="UniqueidentifierColumn_is_required")]        public System.Guid UniqueidentifierColumn
        {
            get
            {
                return m_UniqueidentifierColumn;
            }
            set
            {
                m_UniqueidentifierColumn = value;
                RaisePropertyChanged("UniqueidentifierColumn");
            }
        }

            #endregion properties

            #region Method of Organization.KeyInformation  GetAClone()

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public KeyInformation GetAClone()
            {
                KeyInformation cloned = new KeyInformation();

            cloned.m_Id = m_Id;
            cloned.m_Name = m_Name;
            cloned.m_IsSystemBuiltIn = m_IsSystemBuiltIn;
            cloned.m_UniqueIdentifier = m_UniqueIdentifier;
            cloned.m_BitColumn = m_BitColumn;
            cloned.m_UniqueidentifierColumn = m_UniqueidentifierColumn;

                return cloned;
            }

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public KeyInformation GetACloneWithoutIdentifier()
            {
                KeyInformation cloned = GetAClone();

                return cloned;
            }

            #endregion Method of Organization.KeyInformation  GetAClone()
        }

        /// <summary>
        /// View "KeyInformation" class of <see cref="Organization"/>, used across the solution.
        /// </summary>
        public partial class KeyInformationCollection
            :  List<KeyInformation>
        {
        }

        /// <summary>
        /// message definition of "KeyInformation", pass single entry, from database, to business logic layer. <see cref="Organization"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfKeyInformation
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<KeyInformation>
        {
        }

        /// <summary>
        /// message definition of "KeyInformation", pass a collection of instances, from database, to business logic layer. <see cref="Organization"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfKeyInformationCollection
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<KeyInformationCollection>
        {
        }

        #endregion Nested Views classes and their collection classes 4
    }

    /// <summary>
    /// message definition, pass single entry, pulled from database, to business logic layer. <see cref="Organization"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
    /// </summary>
    public class DataAccessLayerMessageOfEntityOrganization
        : Framework.DataSourceEntities.DataAccessLayerMessageBase<Organization>
    {
    }
}

