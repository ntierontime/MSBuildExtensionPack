using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace MSBuildExtensionPack.DataSourceEntities
{
    /// <summary>
    /// Entity class, used across the solution. <see cref="Solution"/>
    /// </summary>
    //[DataContract]
    public partial class Solution : Framework.PropertyChangedNotifier, MSBuildExtensionPack.EntityContracts.ISolution, Framework.EntityContracts.IClone<Solution>
    {

        #region Storage Fields

        System.Int32 m_Id;

        System.String m_ExternalParentId;

        System.String m_Name;

        System.String m_Description;

        System.Nullable<System.Int64> m_OrganizationId;

        #endregion Storage Fields

        #region constructors

        /// <summary>
        /// default constructor
        /// Initializes a new instance of the <see cref=" Solution"/> class.
        /// </summary>
        public Solution()
        {
            this.Id = default(int);
            this.ExternalParentId = null;
            this.Name = null;
            this.Description = null;
            this.OrganizationId = default(long);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref=" Solution"/> class with .Net value type parameters.
        /// </summary>
        /// <param name="id">property value of Id</param>
        /// <param name="externalParentId">property value of ExternalParentId</param>
        /// <param name="name">property value of Name</param>
        /// <param name="description">property value of Description</param>
        /// <param name="organizationId">property value of OrganizationId</param>
        public Solution(
            System.Int32 id
            ,System.String externalParentId
            ,System.String name
            ,System.String description
            ,System.Nullable<System.Int64> organizationId
            )
        {
            this.m_Id = id;
            this.m_ExternalParentId = externalParentId;
            this.m_Name = name;
            this.m_Description = description;
            this.m_OrganizationId = organizationId;
        }

        /// <summary>
        /// Initializes/clone a new instance of the <see cref=" Solution"/> class.
        /// </summary>
        /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.ISolution"/></param>
        public Solution(MSBuildExtensionPack.EntityContracts.ISolution item)
        {
            MSBuildExtensionPack.EntityContracts.ISolutionHelper.Copy<MSBuildExtensionPack.EntityContracts.ISolution, Solution>(item, this);
        }

        #endregion constructors

        #region properties

                [DataMember]
        [Display(Name = "Id", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution), ErrorMessageResourceName="Id_is_required")]        public System.Int32 Id
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
        [Display(Name = "ExternalParentId", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]
        [StringLengthAttribute(100, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution), ErrorMessageResourceName="The_length_of_ExternalParentId_should_be_0_to_100")]        public System.String ExternalParentId
        {
            get
            {
                return m_ExternalParentId;
            }
            set
            {
                m_ExternalParentId = value;
                RaisePropertyChanged("ExternalParentId");
            }
        }

                [DataMember]
        [Display(Name = "Name", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution), ErrorMessageResourceName="Name_is_required")]
        [StringLengthAttribute(100, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution), ErrorMessageResourceName="The_length_of_Name_should_be_0_to_100")]        public System.String Name
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
        [Display(Name = "Description", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]
        [StringLengthAttribute(1500, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution), ErrorMessageResourceName="The_length_of_Description_should_be_0_to_1500")]        public System.String Description
        {
            get
            {
                return m_Description;
            }
            set
            {
                m_Description = value;
                RaisePropertyChanged("Description");
            }
        }

                [DataMember]
        [Display(Name = "OrganizationId", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]        public System.Nullable<System.Int64> OrganizationId
        {
            get
            {
                return m_OrganizationId;
            }
            set
            {
                m_OrganizationId = value;
                RaisePropertyChanged("OrganizationId");
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
            return MSBuildExtensionPack.EntityContracts.ISolutionHelper.ToString<Solution>(this);
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
            bool _retval = obj is Solution;
            if (_retval == true)
            {
                _retval = MSBuildExtensionPack.EntityContracts.ISolutionHelper.Equals<Solution, Solution>(this, (Solution)obj);
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

        #region Method of Solution GetAClone()

        /// <summary>
        /// Gets the A clone.
        /// </summary>
        /// <returns>a new instance with same value</returns>
        public Solution GetAClone()
        {
            return MSBuildExtensionPack.EntityContracts.ISolutionHelper.Clone<Solution, Solution>(this);
        }

        public Solution GetACloneWithoutIdentifier()
        {
            var cloned = GetAClone();

            return cloned;
        }

        #endregion Method of Solution GetAClone()

        #region Nested Views classes and their collection classes 3

        /// <summary>
        /// View "Default" class of <see cref="Solution"/>, used across the solution.
        /// </summary>
        public partial class Default :Framework.PropertyChangedNotifier, MSBuildExtensionPack.EntityContracts.ISolution, Framework.EntityContracts.IClone<Default>
        {

            #region Storage Fields

        System.Guid m_Organization_1_UniqueIdentifier;

        System.Guid m_Organization_1_UniqueidentifierColumn;

        System.String m_Organization_1_Name;

        System.Int32 m_Id;

        System.Int64 m_Organization_2Id;

        System.Guid m_Organization_2_UniqueIdentifier;

        System.Guid m_Organization_2_UniqueidentifierColumn;

        System.String m_Organization_2_Name;

        System.String m_ExternalParentId;

        System.String m_Name;

        System.String m_Description;

        System.Nullable<System.Int64> m_OrganizationId;

            #endregion Storage Fields

            #region Constructors

            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" Solution"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.ISolution"/></param>
            public Default()
            {
                this.Organization_1_UniqueIdentifier = new Guid();
                this.Organization_1_UniqueidentifierColumn = new Guid();
                this.Organization_1_Name = null;
                this.Id = default(int);
                this.Organization_2Id = default(long);
                this.Organization_2_UniqueIdentifier = new Guid();
                this.Organization_2_UniqueidentifierColumn = new Guid();
                this.Organization_2_Name = null;
                this.ExternalParentId = null;
                this.Name = null;
                this.Description = null;
                this.OrganizationId = default(long);
            }
            /*
            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" Solution"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.ISolution"/></param>
            public Default(MSBuildExtensionPack.EntityContracts.ISolution item)
            {
                MSBuildExtensionPack.EntityContracts.ISolutionHelper.Copy<MSBuildExtensionPack.EntityContracts.ISolution, Default>(item, this);
            }
            */
            #endregion Constructors

            #region properties

                    [DataMember]
        [Display(Name = "Organization_1_UniqueIdentifier", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]        public System.Guid Organization_1_UniqueIdentifier
        {
            get
            {
                return m_Organization_1_UniqueIdentifier;
            }
            set
            {
                m_Organization_1_UniqueIdentifier = value;
                RaisePropertyChanged("Organization_1_UniqueIdentifier");
            }
        }

                    [DataMember]
        [Display(Name = "Organization_1_UniqueidentifierColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]        public System.Guid Organization_1_UniqueidentifierColumn
        {
            get
            {
                return m_Organization_1_UniqueidentifierColumn;
            }
            set
            {
                m_Organization_1_UniqueidentifierColumn = value;
                RaisePropertyChanged("Organization_1_UniqueidentifierColumn");
            }
        }

                    [DataMember]
        [Display(Name = "Organization_1_Name", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]        public System.String Organization_1_Name
        {
            get
            {
                return m_Organization_1_Name;
            }
            set
            {
                m_Organization_1_Name = value;
                RaisePropertyChanged("Organization_1_Name");
            }
        }

                    [DataMember]
        [Display(Name = "Id", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution), ErrorMessageResourceName="Id_is_required")]        public System.Int32 Id
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
        [Display(Name = "Organization_2Id", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]        public System.Int64 Organization_2Id
        {
            get
            {
                return m_Organization_2Id;
            }
            set
            {
                m_Organization_2Id = value;
                RaisePropertyChanged("Organization_2Id");
            }
        }

                    [DataMember]
        [Display(Name = "Organization_2_UniqueIdentifier", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]        public System.Guid Organization_2_UniqueIdentifier
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
        [Display(Name = "Organization_2_UniqueidentifierColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]        public System.Guid Organization_2_UniqueidentifierColumn
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
        [Display(Name = "Organization_2_Name", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]        public System.String Organization_2_Name
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
        [Display(Name = "ExternalParentId", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]
        [StringLengthAttribute(100, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution), ErrorMessageResourceName="The_length_of_ExternalParentId_should_be_0_to_100")]        public System.String ExternalParentId
        {
            get
            {
                return m_ExternalParentId;
            }
            set
            {
                m_ExternalParentId = value;
                RaisePropertyChanged("ExternalParentId");
            }
        }

                    [DataMember]
        [Display(Name = "Name", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution), ErrorMessageResourceName="Name_is_required")]
        [StringLengthAttribute(100, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution), ErrorMessageResourceName="The_length_of_Name_should_be_0_to_100")]        public System.String Name
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
        [Display(Name = "Description", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]
        [StringLengthAttribute(1500, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution), ErrorMessageResourceName="The_length_of_Description_should_be_0_to_1500")]        public System.String Description
        {
            get
            {
                return m_Description;
            }
            set
            {
                m_Description = value;
                RaisePropertyChanged("Description");
            }
        }

                    [DataMember]
        [Display(Name = "OrganizationId", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]        public System.Nullable<System.Int64> OrganizationId
        {
            get
            {
                return m_OrganizationId;
            }
            set
            {
                m_OrganizationId = value;
                RaisePropertyChanged("OrganizationId");
            }
        }

            #endregion properties

            #region Method of Solution.Default  GetAClone()

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public Default GetAClone()
            {
                Default cloned = new Default();

            cloned.m_Organization_1_UniqueIdentifier = m_Organization_1_UniqueIdentifier;
            cloned.m_Organization_1_UniqueidentifierColumn = m_Organization_1_UniqueidentifierColumn;
            cloned.m_Organization_1_Name = m_Organization_1_Name;
            cloned.m_Id = m_Id;
            cloned.m_Organization_2Id = m_Organization_2Id;
            cloned.m_Organization_2_UniqueIdentifier = m_Organization_2_UniqueIdentifier;
            cloned.m_Organization_2_UniqueidentifierColumn = m_Organization_2_UniqueidentifierColumn;
            cloned.m_Organization_2_Name = m_Organization_2_Name;
            cloned.m_ExternalParentId = m_ExternalParentId;
            cloned.m_Name = m_Name;
            cloned.m_Description = m_Description;
            cloned.m_OrganizationId = m_OrganizationId;

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

            #endregion Method of Solution.Default  GetAClone()
        }

        /// <summary>
        /// View "Default" class of <see cref="Solution"/>, used across the solution.
        /// </summary>
        public partial class DefaultCollection
            :  List<Default>
        {
        }

        /// <summary>
        /// message definition of "Default", pass single entry, from database, to business logic layer. <see cref="Solution"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfDefault
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<Default>
        {
        }

        /// <summary>
        /// message definition of "Default", pass a collection of instances, from database, to business logic layer. <see cref="Solution"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfDefaultCollection
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<DefaultCollection>
        {
        }

        /// <summary>
        /// View "DefaultGroupedDataView" class of <see cref="Solution"/>, used across the solution.
        /// </summary>
        public partial class DefaultGroupedDataView :Framework.PropertyChangedNotifier, Framework.EntityContracts.IClone<DefaultGroupedDataView>
        {

            #region Storage Fields

        System.Nullable<System.Int64> m_OrganizationId;

        System.Int64 m_Organization_2Id;

        System.Int64 m_CountPerFK;

        System.String m_Name;

            #endregion Storage Fields

            #region Constructors

            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" Solution"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.ISolution"/></param>
            public DefaultGroupedDataView()
            {
                this.OrganizationId = default(long);
                this.Organization_2Id = default(long);
                this.CountPerFK = default(long);
                this.Name = null;
            }
            /*
            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" Solution"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.ISolution"/></param>
            public DefaultGroupedDataView(MSBuildExtensionPack.EntityContracts.ISolution item)
            {
                MSBuildExtensionPack.EntityContracts.ISolutionHelper.Copy<MSBuildExtensionPack.EntityContracts.ISolution, DefaultGroupedDataView>(item, this);
            }
            */
            #endregion Constructors

            #region properties

                    [DataMember]
        [Display(Name = "OrganizationId", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]        public System.Nullable<System.Int64> OrganizationId
        {
            get
            {
                return m_OrganizationId;
            }
            set
            {
                m_OrganizationId = value;
                RaisePropertyChanged("OrganizationId");
            }
        }

                    [DataMember]
        [Display(Name = "Organization_2Id", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]        public System.Int64 Organization_2Id
        {
            get
            {
                return m_Organization_2Id;
            }
            set
            {
                m_Organization_2Id = value;
                RaisePropertyChanged("Organization_2Id");
            }
        }

                    [DataMember]
        [Display(Name = "CountPerFK", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]        public System.Int64 CountPerFK
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
        [Display(Name = "Name", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]        public System.String Name
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

            #region Method of Solution.DefaultGroupedDataView  GetAClone()

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public DefaultGroupedDataView GetAClone()
            {
                DefaultGroupedDataView cloned = new DefaultGroupedDataView();

            cloned.m_OrganizationId = m_OrganizationId;
            cloned.m_Organization_2Id = m_Organization_2Id;
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

            #endregion Method of Solution.DefaultGroupedDataView  GetAClone()
        }

        /// <summary>
        /// View "DefaultGroupedDataView" class of <see cref="Solution"/>, used across the solution.
        /// </summary>
        public partial class DefaultGroupedDataViewCollection
            :  List<DefaultGroupedDataView>
        {
        }

        /// <summary>
        /// message definition of "DefaultGroupedDataView", pass single entry, from database, to business logic layer. <see cref="Solution"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfDefaultGroupedDataView
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<DefaultGroupedDataView>
        {
        }

        /// <summary>
        /// message definition of "DefaultGroupedDataView", pass a collection of instances, from database, to business logic layer. <see cref="Solution"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfDefaultGroupedDataViewCollection
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<DefaultGroupedDataViewCollection>
        {
        }

        /// <summary>
        /// View "KeyInformation" class of <see cref="Solution"/>, used across the solution.
        /// </summary>
        public partial class KeyInformation :Framework.PropertyChangedNotifier, MSBuildExtensionPack.EntityContracts.ISolutionIdentifier, Framework.EntityContracts.IClone<KeyInformation>
        {

            #region Storage Fields

        System.Int32 m_Id;

        System.String m_Name;

            #endregion Storage Fields

            #region Constructors

            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" Solution"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.ISolution"/></param>
            public KeyInformation()
            {
                this.Id = default(int);
                this.Name = null;
            }
            /*
            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" Solution"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.ISolution"/></param>
            public KeyInformation(MSBuildExtensionPack.EntityContracts.ISolution item)
            {
                MSBuildExtensionPack.EntityContracts.ISolutionHelper.Copy<MSBuildExtensionPack.EntityContracts.ISolution, KeyInformation>(item, this);
            }
            */
            #endregion Constructors

            #region properties

                    [DataMember]
        [Display(Name = "Id", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution), ErrorMessageResourceName="Id_is_required")]        public System.Int32 Id
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
        [Display(Name = "Name", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution), ErrorMessageResourceName="Name_is_required")]
        [StringLengthAttribute(100, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntitySolution), ErrorMessageResourceName="The_length_of_Name_should_be_0_to_100")]        public System.String Name
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

            #region Method of Solution.KeyInformation  GetAClone()

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public KeyInformation GetAClone()
            {
                KeyInformation cloned = new KeyInformation();

            cloned.m_Id = m_Id;
            cloned.m_Name = m_Name;

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

            #endregion Method of Solution.KeyInformation  GetAClone()
        }

        /// <summary>
        /// View "KeyInformation" class of <see cref="Solution"/>, used across the solution.
        /// </summary>
        public partial class KeyInformationCollection
            :  List<KeyInformation>
        {
        }

        /// <summary>
        /// message definition of "KeyInformation", pass single entry, from database, to business logic layer. <see cref="Solution"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfKeyInformation
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<KeyInformation>
        {
        }

        /// <summary>
        /// message definition of "KeyInformation", pass a collection of instances, from database, to business logic layer. <see cref="Solution"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfKeyInformationCollection
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<KeyInformationCollection>
        {
        }

        #endregion Nested Views classes and their collection classes 3
    }

/*
    /// <summary>
    /// a property defined when <see cref="Solution"/> is used in other classes.
    /// </summary>
    public interface WithEntityContractSolution
    {
        /// <summary>
        /// Gets or sets Solution.
        /// </summary>
        /// <value>
        /// The Solution
        /// </value>
        Solution Solution { get; set; }
    }
*/

    /// <summary>
    /// message definition, pass single entry, pulled from database, to business logic layer. <see cref="Solution"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
    /// </summary>
    public class DataAccessLayerMessageOfEntitySolution
        : Framework.DataSourceEntities.DataAccessLayerMessageBase<Solution>
    {
    }
}

