using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace MSBuildExtensionPack.DataSourceEntities
{
    /// <summary>
    /// Entity class, used across the solution. <see cref="BuildLog"/>
    /// </summary>
    //[DataContract]
    public partial class BuildLog : Framework.PropertyChangedNotifier, MSBuildExtensionPack.EntityContracts.IBuildLog, Framework.EntityContracts.IClone<BuildLog>
    {

        #region Storage Fields

        System.Int64 m_Id;

        System.Int64 m_BuildId;

        System.Int32 m_BuildEventCodeId;

        System.String m_Message;

        System.DateTime m_EventTime;

        #endregion Storage Fields

        #region constructors

        /// <summary>
        /// default constructor
        /// Initializes a new instance of the <see cref=" BuildLog"/> class.
        /// </summary>
        public BuildLog()
        {
            this.Id = default(long);
            this.BuildId = default(long);
            this.BuildEventCodeId = default(int);
            this.Message = null;
            this.EventTime = DateTime.Now;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref=" BuildLog"/> class with .Net value type parameters.
        /// </summary>
        /// <param name="id">property value of Id</param>
        /// <param name="buildId">property value of BuildId</param>
        /// <param name="buildEventCodeId">property value of BuildEventCodeId</param>
        /// <param name="message">property value of Message</param>
        /// <param name="eventTime">property value of EventTime</param>
        public BuildLog(
            System.Int64 id
            ,System.Int64 buildId
            ,System.Int32 buildEventCodeId
            ,System.String message
            ,System.DateTime eventTime
            )
        {
            this.m_Id = id;
            this.m_BuildId = buildId;
            this.m_BuildEventCodeId = buildEventCodeId;
            this.m_Message = message;
            this.m_EventTime = eventTime;
        }

        /// <summary>
        /// Initializes/clone a new instance of the <see cref=" BuildLog"/> class.
        /// </summary>
        /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IBuildLog"/></param>
        public BuildLog(MSBuildExtensionPack.EntityContracts.IBuildLog item)
        {
            MSBuildExtensionPack.EntityContracts.IBuildLogHelper.Copy<MSBuildExtensionPack.EntityContracts.IBuildLog, BuildLog>(item, this);
        }

        #endregion constructors

        #region properties

                [DataMember]
        [Display(Name = "Id", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog), ErrorMessageResourceName="Id_is_required")]        public System.Int64 Id
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
        [Display(Name = "BuildId", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog), ErrorMessageResourceName="BuildId_is_required")]        public System.Int64 BuildId
        {
            get
            {
                return m_BuildId;
            }
            set
            {
                m_BuildId = value;
                RaisePropertyChanged("BuildId");
            }
        }

                [DataMember]
        [Display(Name = "BuildEventCodeId", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog), ErrorMessageResourceName="BuildEventCodeId_is_required")]        public System.Int32 BuildEventCodeId
        {
            get
            {
                return m_BuildEventCodeId;
            }
            set
            {
                m_BuildEventCodeId = value;
                RaisePropertyChanged("BuildEventCodeId");
            }
        }

                [DataMember]
        [Display(Name = "Message", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]
        [StringLengthAttribute(1500, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog), ErrorMessageResourceName="The_length_of_Message_should_be_0_to_1500")]        public System.String Message
        {
            get
            {
                return m_Message;
            }
            set
            {
                m_Message = value;
                RaisePropertyChanged("Message");
            }
        }

                [DataMember]
        [Display(Name = "EventTime", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog), ErrorMessageResourceName="EventTime_is_required")]        public System.DateTime EventTime
        {
            get
            {
                return m_EventTime;
            }
            set
            {
                m_EventTime = value;
                RaisePropertyChanged("EventTime");
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
            return MSBuildExtensionPack.EntityContracts.IBuildLogHelper.ToString<BuildLog>(this);
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
            bool _retval = obj is BuildLog;
            if (_retval == true)
            {
                _retval = MSBuildExtensionPack.EntityContracts.IBuildLogHelper.Equals<BuildLog, BuildLog>(this, (BuildLog)obj);
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

        #region Method of BuildLog GetAClone()

        /// <summary>
        /// Gets the A clone.
        /// </summary>
        /// <returns>a new instance with same value</returns>
        public BuildLog GetAClone()
        {
            return MSBuildExtensionPack.EntityContracts.IBuildLogHelper.Clone<BuildLog, BuildLog>(this);
        }

        public BuildLog GetACloneWithoutIdentifier()
        {
            var cloned = GetAClone();

            return cloned;
        }

        #endregion Method of BuildLog GetAClone()

        #region Nested Views classes and their collection classes 3

        /// <summary>
        /// View "Default" class of <see cref="BuildLog"/>, used across the solution.
        /// </summary>
        public partial class Default :Framework.PropertyChangedNotifier, MSBuildExtensionPack.EntityContracts.IBuildLog, Framework.EntityContracts.IClone<Default>
        {

            #region Storage Fields

        System.String m_Build_1_Name;

        System.Int64 m_Id;

        System.Int32 m_Solution_1Id;

        System.String m_Solution_1_Name;

        System.Guid m_Organization_1_UniqueidentifierColumn;

        System.Guid m_Organization_1_UniqueIdentifier;

        System.Int64 m_Organization_1Id;

        System.String m_Organization_1_Name;

        System.Guid m_Organization_2_UniqueidentifierColumn;

        System.Int64 m_Organization_2Id;

        System.Guid m_Organization_2_UniqueIdentifier;

        System.String m_Organization_2_Name;

        System.String m_BuildEventCode_1_Name;

        System.Int64 m_BuildId;

        System.Int32 m_BuildEventCodeId;

        System.String m_Message;

        System.DateTime m_EventTime;

            #endregion Storage Fields

            #region Constructors

            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" BuildLog"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IBuildLog"/></param>
            public Default()
            {
                this.Build_1_Name = null;
                this.Id = default(long);
                this.Solution_1Id = default(int);
                this.Solution_1_Name = null;
                this.Organization_1_UniqueidentifierColumn = new Guid();
                this.Organization_1_UniqueIdentifier = new Guid();
                this.Organization_1Id = default(long);
                this.Organization_1_Name = null;
                this.Organization_2_UniqueidentifierColumn = new Guid();
                this.Organization_2Id = default(long);
                this.Organization_2_UniqueIdentifier = new Guid();
                this.Organization_2_Name = null;
                this.BuildEventCode_1_Name = null;
                this.BuildId = default(long);
                this.BuildEventCodeId = default(int);
                this.Message = null;
                this.EventTime = DateTime.Now;
            }
            /*
            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" BuildLog"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IBuildLog"/></param>
            public Default(MSBuildExtensionPack.EntityContracts.IBuildLog item)
            {
                MSBuildExtensionPack.EntityContracts.IBuildLogHelper.Copy<MSBuildExtensionPack.EntityContracts.IBuildLog, Default>(item, this);
            }
            */
            #endregion Constructors

            #region properties

                    [DataMember]
        [Display(Name = "Build_1_Name", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]        public System.String Build_1_Name
        {
            get
            {
                return m_Build_1_Name;
            }
            set
            {
                m_Build_1_Name = value;
                RaisePropertyChanged("Build_1_Name");
            }
        }

                    [DataMember]
        [Display(Name = "Id", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog), ErrorMessageResourceName="Id_is_required")]        public System.Int64 Id
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
        [Display(Name = "Solution_1Id", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]        public System.Int32 Solution_1Id
        {
            get
            {
                return m_Solution_1Id;
            }
            set
            {
                m_Solution_1Id = value;
                RaisePropertyChanged("Solution_1Id");
            }
        }

                    [DataMember]
        [Display(Name = "Solution_1_Name", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]        public System.String Solution_1_Name
        {
            get
            {
                return m_Solution_1_Name;
            }
            set
            {
                m_Solution_1_Name = value;
                RaisePropertyChanged("Solution_1_Name");
            }
        }

                    [DataMember]
        [Display(Name = "Organization_1_UniqueidentifierColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]        public System.Guid Organization_1_UniqueidentifierColumn
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
        [Display(Name = "Organization_1_UniqueIdentifier", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]        public System.Guid Organization_1_UniqueIdentifier
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
        [Display(Name = "Organization_1Id", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]        public System.Int64 Organization_1Id
        {
            get
            {
                return m_Organization_1Id;
            }
            set
            {
                m_Organization_1Id = value;
                RaisePropertyChanged("Organization_1Id");
            }
        }

                    [DataMember]
        [Display(Name = "Organization_1_Name", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]        public System.String Organization_1_Name
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
        [Display(Name = "Organization_2_UniqueidentifierColumn", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]        public System.Guid Organization_2_UniqueidentifierColumn
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
        [Display(Name = "Organization_2Id", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]        public System.Int64 Organization_2Id
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
        [Display(Name = "Organization_2_UniqueIdentifier", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]        public System.Guid Organization_2_UniqueIdentifier
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
        [Display(Name = "Organization_2_Name", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]        public System.String Organization_2_Name
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
        [Display(Name = "BuildEventCode_1_Name", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]        public System.String BuildEventCode_1_Name
        {
            get
            {
                return m_BuildEventCode_1_Name;
            }
            set
            {
                m_BuildEventCode_1_Name = value;
                RaisePropertyChanged("BuildEventCode_1_Name");
            }
        }

                    [DataMember]
        [Display(Name = "BuildId", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]        public System.Int64 BuildId
        {
            get
            {
                return m_BuildId;
            }
            set
            {
                m_BuildId = value;
                RaisePropertyChanged("BuildId");
            }
        }

                    [DataMember]
        [Display(Name = "BuildEventCodeId", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]        public System.Int32 BuildEventCodeId
        {
            get
            {
                return m_BuildEventCodeId;
            }
            set
            {
                m_BuildEventCodeId = value;
                RaisePropertyChanged("BuildEventCodeId");
            }
        }

                    [DataMember]
        [Display(Name = "Message", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]
        [StringLengthAttribute(1500, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog), ErrorMessageResourceName="The_length_of_Message_should_be_0_to_1500")]        public System.String Message
        {
            get
            {
                return m_Message;
            }
            set
            {
                m_Message = value;
                RaisePropertyChanged("Message");
            }
        }

                    [DataMember]
        [Display(Name = "EventTime", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog), ErrorMessageResourceName="EventTime_is_required")]        public System.DateTime EventTime
        {
            get
            {
                return m_EventTime;
            }
            set
            {
                m_EventTime = value;
                RaisePropertyChanged("EventTime");
            }
        }

            #endregion properties

            #region Method of BuildLog.Default  GetAClone()

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public Default GetAClone()
            {
                Default cloned = new Default();

            cloned.m_Build_1_Name = m_Build_1_Name;
            cloned.m_Id = m_Id;
            cloned.m_Solution_1Id = m_Solution_1Id;
            cloned.m_Solution_1_Name = m_Solution_1_Name;
            cloned.m_Organization_1_UniqueidentifierColumn = m_Organization_1_UniqueidentifierColumn;
            cloned.m_Organization_1_UniqueIdentifier = m_Organization_1_UniqueIdentifier;
            cloned.m_Organization_1Id = m_Organization_1Id;
            cloned.m_Organization_1_Name = m_Organization_1_Name;
            cloned.m_Organization_2_UniqueidentifierColumn = m_Organization_2_UniqueidentifierColumn;
            cloned.m_Organization_2Id = m_Organization_2Id;
            cloned.m_Organization_2_UniqueIdentifier = m_Organization_2_UniqueIdentifier;
            cloned.m_Organization_2_Name = m_Organization_2_Name;
            cloned.m_BuildEventCode_1_Name = m_BuildEventCode_1_Name;
            cloned.m_BuildId = m_BuildId;
            cloned.m_BuildEventCodeId = m_BuildEventCodeId;
            cloned.m_Message = m_Message;
            cloned.m_EventTime = m_EventTime;

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

            #endregion Method of BuildLog.Default  GetAClone()
        }

        /// <summary>
        /// View "Default" class of <see cref="BuildLog"/>, used across the solution.
        /// </summary>
        public partial class DefaultCollection
            :  List<Default>
        {
        }

        /// <summary>
        /// message definition of "Default", pass single entry, from database, to business logic layer. <see cref="BuildLog"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfDefault
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<Default>
        {
        }

        /// <summary>
        /// message definition of "Default", pass a collection of instances, from database, to business logic layer. <see cref="BuildLog"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfDefaultCollection
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<DefaultCollection>
        {
        }

        /// <summary>
        /// View "DefaultGroupedDataView" class of <see cref="BuildLog"/>, used across the solution.
        /// </summary>
        public partial class DefaultGroupedDataView :Framework.PropertyChangedNotifier, Framework.EntityContracts.IClone<DefaultGroupedDataView>
        {

            #region Storage Fields

        System.Int64 m_BuildId;

        System.Int32 m_BuildEventCodeId;

        System.Int64 m_CountPerFK;

        System.String m_Name;

        System.Int32 m_Solution_1Id;

        System.Int64 m_Organization_1Id;

        System.Int64 m_Organization_2Id;

            #endregion Storage Fields

            #region Constructors

            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" BuildLog"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IBuildLog"/></param>
            public DefaultGroupedDataView()
            {
                this.BuildId = default(long);
                this.BuildEventCodeId = default(int);
                this.CountPerFK = default(long);
                this.Name = null;
                this.Solution_1Id = default(int);
                this.Organization_1Id = default(long);
                this.Organization_2Id = default(long);
            }
            /*
            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" BuildLog"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IBuildLog"/></param>
            public DefaultGroupedDataView(MSBuildExtensionPack.EntityContracts.IBuildLog item)
            {
                MSBuildExtensionPack.EntityContracts.IBuildLogHelper.Copy<MSBuildExtensionPack.EntityContracts.IBuildLog, DefaultGroupedDataView>(item, this);
            }
            */
            #endregion Constructors

            #region properties

                    [DataMember]
        [Display(Name = "BuildId", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog), ErrorMessageResourceName="BuildId_is_required")]        public System.Int64 BuildId
        {
            get
            {
                return m_BuildId;
            }
            set
            {
                m_BuildId = value;
                RaisePropertyChanged("BuildId");
            }
        }

                    [DataMember]
        [Display(Name = "BuildEventCodeId", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog), ErrorMessageResourceName="BuildEventCodeId_is_required")]        public System.Int32 BuildEventCodeId
        {
            get
            {
                return m_BuildEventCodeId;
            }
            set
            {
                m_BuildEventCodeId = value;
                RaisePropertyChanged("BuildEventCodeId");
            }
        }

                    [DataMember]
        [Display(Name = "CountPerFK", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]        public System.Int64 CountPerFK
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
        [Display(Name = "Name", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]        public System.String Name
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
        [Display(Name = "Solution_1Id", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]        public System.Int32 Solution_1Id
        {
            get
            {
                return m_Solution_1Id;
            }
            set
            {
                m_Solution_1Id = value;
                RaisePropertyChanged("Solution_1Id");
            }
        }

                    [DataMember]
        [Display(Name = "Organization_1Id", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]        public System.Int64 Organization_1Id
        {
            get
            {
                return m_Organization_1Id;
            }
            set
            {
                m_Organization_1Id = value;
                RaisePropertyChanged("Organization_1Id");
            }
        }

                    [DataMember]
        [Display(Name = "Organization_2Id", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]        public System.Int64 Organization_2Id
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

            #endregion properties

            #region Method of BuildLog.DefaultGroupedDataView  GetAClone()

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public DefaultGroupedDataView GetAClone()
            {
                DefaultGroupedDataView cloned = new DefaultGroupedDataView();

            cloned.m_BuildId = m_BuildId;
            cloned.m_BuildEventCodeId = m_BuildEventCodeId;
            cloned.m_CountPerFK = m_CountPerFK;
            cloned.m_Name = m_Name;
            cloned.m_Solution_1Id = m_Solution_1Id;
            cloned.m_Organization_1Id = m_Organization_1Id;
            cloned.m_Organization_2Id = m_Organization_2Id;

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

            #endregion Method of BuildLog.DefaultGroupedDataView  GetAClone()
        }

        /// <summary>
        /// View "DefaultGroupedDataView" class of <see cref="BuildLog"/>, used across the solution.
        /// </summary>
        public partial class DefaultGroupedDataViewCollection
            :  List<DefaultGroupedDataView>
        {
        }

        /// <summary>
        /// message definition of "DefaultGroupedDataView", pass single entry, from database, to business logic layer. <see cref="BuildLog"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfDefaultGroupedDataView
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<DefaultGroupedDataView>
        {
        }

        /// <summary>
        /// message definition of "DefaultGroupedDataView", pass a collection of instances, from database, to business logic layer. <see cref="BuildLog"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfDefaultGroupedDataViewCollection
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<DefaultGroupedDataViewCollection>
        {
        }

        /// <summary>
        /// View "KeyInformation" class of <see cref="BuildLog"/>, used across the solution.
        /// </summary>
        public partial class KeyInformation :Framework.PropertyChangedNotifier, MSBuildExtensionPack.EntityContracts.IBuildLogIdentifier, Framework.EntityContracts.IClone<KeyInformation>
        {

            #region Storage Fields

        System.Int64 m_Id;

        System.Int32 m_BuildEventCodeId;

            #endregion Storage Fields

            #region Constructors

            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" BuildLog"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IBuildLog"/></param>
            public KeyInformation()
            {
                this.Id = default(long);
                this.BuildEventCodeId = default(int);
            }
            /*
            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" BuildLog"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IBuildLog"/></param>
            public KeyInformation(MSBuildExtensionPack.EntityContracts.IBuildLog item)
            {
                MSBuildExtensionPack.EntityContracts.IBuildLogHelper.Copy<MSBuildExtensionPack.EntityContracts.IBuildLog, KeyInformation>(item, this);
            }
            */
            #endregion Constructors

            #region properties

                    [DataMember]
        [Display(Name = "Id", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog), ErrorMessageResourceName="Id_is_required")]        public System.Int64 Id
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
        [Display(Name = "BuildEventCodeId", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildLog))]        public System.Int32 BuildEventCodeId
        {
            get
            {
                return m_BuildEventCodeId;
            }
            set
            {
                m_BuildEventCodeId = value;
                RaisePropertyChanged("BuildEventCodeId");
            }
        }

            #endregion properties

            #region Method of BuildLog.KeyInformation  GetAClone()

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public KeyInformation GetAClone()
            {
                KeyInformation cloned = new KeyInformation();

            cloned.m_Id = m_Id;
            cloned.m_BuildEventCodeId = m_BuildEventCodeId;

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

            #endregion Method of BuildLog.KeyInformation  GetAClone()
        }

        /// <summary>
        /// View "KeyInformation" class of <see cref="BuildLog"/>, used across the solution.
        /// </summary>
        public partial class KeyInformationCollection
            :  List<KeyInformation>
        {
        }

        /// <summary>
        /// message definition of "KeyInformation", pass single entry, from database, to business logic layer. <see cref="BuildLog"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfKeyInformation
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<KeyInformation>
        {
        }

        /// <summary>
        /// message definition of "KeyInformation", pass a collection of instances, from database, to business logic layer. <see cref="BuildLog"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfKeyInformationCollection
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<KeyInformationCollection>
        {
        }

        #endregion Nested Views classes and their collection classes 3
    }

/*
    /// <summary>
    /// a property defined when <see cref="BuildLog"/> is used in other classes.
    /// </summary>
    public interface WithEntityContractBuildLog
    {
        /// <summary>
        /// Gets or sets BuildLog.
        /// </summary>
        /// <value>
        /// The BuildLog
        /// </value>
        BuildLog BuildLog { get; set; }
    }
*/

    /// <summary>
    /// message definition, pass single entry, pulled from database, to business logic layer. <see cref="BuildLog"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
    /// </summary>
    public class DataAccessLayerMessageOfEntityBuildLog
        : Framework.DataSourceEntities.DataAccessLayerMessageBase<BuildLog>
    {
    }
}

