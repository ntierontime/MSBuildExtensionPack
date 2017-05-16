using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
#if (WINDOWS_PHONE || XAMARIN)
#else
using System.ComponentModel.DataAnnotations;
#endif

namespace MSBuildExtensionPack.DataSourceEntities
{
    /// <summary>
    /// Entity class, used across the solution. <see cref="Build"/>
    /// </summary>
    //[DataContract]
	public partial class Build  : Framework.PropertyChangedNotifier, MSBuildExtensionPack.EntityContracts.IBuild
	{ 





		#region Storage Fields

        System.Int64 m_Id;

        System.Int32 m_SolutionId;

        System.String m_Name;

        System.String m_Description;

        System.DateTime m_BuildStartTime;


		#endregion Storage Fields


    

		#region constructors

        /// <summary>
        /// default constructor
        /// Initializes a new instance of the <see cref=" Build"/> class.
        /// </summary>
		public Build()
		{
			this.Id = default(long);
			this.SolutionId = default(int);
			this.Name = null;
			this.Description = null;
			this.BuildStartTime = DateTime.Now;
		}

        /// <summary>
        /// Initializes a new instance of the <see cref=" Build"/> class with .Net value type parameters.
        /// </summary>
        /// <param name="id">property value of Id</param>
        /// <param name="solutionId">property value of SolutionId</param>
        /// <param name="name">property value of Name</param>
        /// <param name="description">property value of Description</param>
        /// <param name="buildStartTime">property value of BuildStartTime</param>
		public Build(
			System.Int64 id
			,System.Int32 solutionId
			,System.String name
			,System.String description
			,System.DateTime buildStartTime
			)
		{
			this.m_Id = id;
			this.m_SolutionId = solutionId;
			this.m_Name = name;
			this.m_Description = description;
			this.m_BuildStartTime = buildStartTime;
		}

        /// <summary>
        /// Initializes/clone a new instance of the <see cref=" Build"/> class.
        /// </summary>
        /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IBuild"/></param>
        public Build(MSBuildExtensionPack.EntityContracts.IBuild item)
        {
            MSBuildExtensionPack.EntityContracts.IBuildHelper.Copy<MSBuildExtensionPack.EntityContracts.IBuild, Build>(item, this);
        }


		#endregion constructors

		#region properties

				[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Id", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="Id_is_required")]
#endif
        public System.Int64 Id
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
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "SolutionId", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="SolutionId_is_required")]
#endif
        public System.Int32 SolutionId
        {
            get
            {
                return m_SolutionId;
            }
            set
            {
                m_SolutionId = value;
                RaisePropertyChanged("SolutionId");
            }
        }

				[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Name", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="Name_is_required")]
		[StringLengthAttribute(100, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="The_length_of_Name_should_be_0_to_100")]
#endif
        public System.String Name
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
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Description", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
		[StringLengthAttribute(1500, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="The_length_of_Description_should_be_0_to_1500")]
#endif
        public System.String Description
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
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "BuildStartTime", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="BuildStartTime_is_required")]
#endif
        public System.DateTime BuildStartTime
        {
            get
            {
                return m_BuildStartTime;
            }
            set
            {
                m_BuildStartTime = value;
                RaisePropertyChanged("BuildStartTime");
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
            return MSBuildExtensionPack.EntityContracts.IBuildHelper.ToString<Build>(this);
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
            bool _retval = obj is Build;
            if (_retval == true)
            {
                _retval = MSBuildExtensionPack.EntityContracts.IBuildHelper.Equals<Build, Build>(this, (Build)obj);
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

		#region Method of Build GetAClone()

        /// <summary>
        /// Gets the A clone.
        /// </summary>
        /// <returns>a new instance with same value</returns>
        public Build GetAClone()
        {
            return MSBuildExtensionPack.EntityContracts.IBuildHelper.Clone<Build, Build>(this);
        }


		#endregion Method of Build GetAClone()

		#region Nested Views classes and their collection classes 4


        /// <summary>
        /// View "Default" class of <see cref="Build"/>, used across the solution. 
        /// </summary>
		public partial class Default :Framework.PropertyChangedNotifier, MSBuildExtensionPack.EntityContracts.IBuild, Framework.EntityContracts.IClone<Default>
		{

			#region Storage Fields

        System.String m_Solution_1_Name;

        System.Int64 m_Id;

        System.Int64 m_Organization_1Id;

        System.Guid m_Organization_1_UniqueIdentifier;

        System.Guid m_Organization_1_UniqueidentifierColumn;

        System.String m_Organization_1_Name;

        System.Int64 m_Organization_2Id;

        System.Guid m_Organization_2_UniqueIdentifier;

        System.Guid m_Organization_2_UniqueidentifierColumn;

        System.String m_Organization_2_Name;

        System.Int32 m_SolutionId;

        System.String m_Name;

        System.String m_Description;

        System.DateTime m_BuildStartTime;


			#endregion Storage Fields

			#region Constructors

			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" Build"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IBuild"/></param>
			public Default()
			{
				this.Solution_1_Name = null;
				this.Id = default(long);
				this.Organization_1Id = default(long);
				this.Organization_1_UniqueIdentifier = new Guid();
				this.Organization_1_UniqueidentifierColumn = new Guid();
				this.Organization_1_Name = null;
				this.Organization_2Id = default(long);
				this.Organization_2_UniqueIdentifier = new Guid();
				this.Organization_2_UniqueidentifierColumn = new Guid();
				this.Organization_2_Name = null;
				this.SolutionId = default(int);
				this.Name = null;
				this.Description = null;
				this.BuildStartTime = DateTime.Now;
			}
			/*
			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" Build"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IBuild"/></param>
			public Default(MSBuildExtensionPack.EntityContracts.IBuild item)
			{
				MSBuildExtensionPack.EntityContracts.IBuildHelper.Copy<MSBuildExtensionPack.EntityContracts.IBuild, Default>(item, this);
			}
			*/
			#endregion Constructors


			#region properties

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Solution_1_Name", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
#endif
        public System.String Solution_1_Name
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
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Id", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="Id_is_required")]
#endif
        public System.Int64 Id
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
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Organization_1Id", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
#endif
        public System.Int64 Organization_1Id
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
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Organization_1_UniqueIdentifier", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
#endif
        public System.Guid Organization_1_UniqueIdentifier
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
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Organization_1_UniqueidentifierColumn", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
#endif
        public System.Guid Organization_1_UniqueidentifierColumn
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
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Organization_1_Name", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
#endif
        public System.String Organization_1_Name
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
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Organization_2Id", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
#endif
        public System.Int64 Organization_2Id
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
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Organization_2_UniqueIdentifier", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
#endif
        public System.Guid Organization_2_UniqueIdentifier
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
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Organization_2_UniqueidentifierColumn", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
#endif
        public System.Guid Organization_2_UniqueidentifierColumn
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
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Organization_2_Name", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
#endif
        public System.String Organization_2_Name
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
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "SolutionId", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
#endif
        public System.Int32 SolutionId
        {
            get
            {
                return m_SolutionId;
            }
            set
            {
                m_SolutionId = value;
                RaisePropertyChanged("SolutionId");
            }
        }

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Name", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="Name_is_required")]
		[StringLengthAttribute(100, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="The_length_of_Name_should_be_0_to_100")]
#endif
        public System.String Name
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
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Description", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
		[StringLengthAttribute(1500, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="The_length_of_Description_should_be_0_to_1500")]
#endif
        public System.String Description
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
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "BuildStartTime", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="BuildStartTime_is_required")]
#endif
        public System.DateTime BuildStartTime
        {
            get
            {
                return m_BuildStartTime;
            }
            set
            {
                m_BuildStartTime = value;
                RaisePropertyChanged("BuildStartTime");
            }
        }


			#endregion properties

            #region Method of Build.Default  GetAClone()

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public Default GetAClone()
            {
                Default cloned = new Default();

			cloned.m_Solution_1_Name = m_Solution_1_Name;
			cloned.m_Id = m_Id;
			cloned.m_Organization_1Id = m_Organization_1Id;
			cloned.m_Organization_1_UniqueIdentifier = m_Organization_1_UniqueIdentifier;
			cloned.m_Organization_1_UniqueidentifierColumn = m_Organization_1_UniqueidentifierColumn;
			cloned.m_Organization_1_Name = m_Organization_1_Name;
			cloned.m_Organization_2Id = m_Organization_2Id;
			cloned.m_Organization_2_UniqueIdentifier = m_Organization_2_UniqueIdentifier;
			cloned.m_Organization_2_UniqueidentifierColumn = m_Organization_2_UniqueidentifierColumn;
			cloned.m_Organization_2_Name = m_Organization_2_Name;
			cloned.m_SolutionId = m_SolutionId;
			cloned.m_Name = m_Name;
			cloned.m_Description = m_Description;
			cloned.m_BuildStartTime = m_BuildStartTime;

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

            #endregion Method of Build.Default  GetAClone()
		}

        /// <summary>
        /// View "Default" class of <see cref="Build"/>, used across the solution. 
        /// </summary>
		public partial class DefaultCollection
			:  List<Default>
		{ 
		}

        /// <summary>
        /// message definition of "Default", pass single entry, from database, to business logic layer. <see cref="Build"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfDefault
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<Default>
		{
		}

        /// <summary>
        /// message definition of "Default", pass a collection of instances, from database, to business logic layer. <see cref="Build"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfDefaultCollection
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<DefaultCollection>
		{
		}


        /// <summary>
        /// View "DefaultGroupedDataView" class of <see cref="Build"/>, used across the solution. 
        /// </summary>
		public partial class DefaultGroupedDataView :Framework.PropertyChangedNotifier, Framework.EntityContracts.IClone<DefaultGroupedDataView>
		{

			#region Storage Fields

        System.Int32 m_SolutionId;

        System.Int64 m_Organization_1Id;

        System.Int64 m_CountPerFK;

        System.String m_Name;

        System.Int64 m_Organization_2Id;


			#endregion Storage Fields

			#region Constructors

			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" Build"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IBuild"/></param>
			public DefaultGroupedDataView()
			{
				this.SolutionId = default(int);
				this.Organization_1Id = default(long);
				this.CountPerFK = default(long);
				this.Name = null;
				this.Organization_2Id = default(long);
			}
			/*
			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" Build"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IBuild"/></param>
			public DefaultGroupedDataView(MSBuildExtensionPack.EntityContracts.IBuild item)
			{
				MSBuildExtensionPack.EntityContracts.IBuildHelper.Copy<MSBuildExtensionPack.EntityContracts.IBuild, DefaultGroupedDataView>(item, this);
			}
			*/
			#endregion Constructors


			#region properties

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "SolutionId", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="SolutionId_is_required")]
#endif
        public System.Int32 SolutionId
        {
            get
            {
                return m_SolutionId;
            }
            set
            {
                m_SolutionId = value;
                RaisePropertyChanged("SolutionId");
            }
        }

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Organization_1Id", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
#endif
        public System.Int64 Organization_1Id
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
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "CountPerFK", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
#endif
        public System.Int64 CountPerFK
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
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Name", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
#endif
        public System.String Name
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
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Organization_2Id", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
#endif
        public System.Int64 Organization_2Id
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

            #region Method of Build.DefaultGroupedDataView  GetAClone()

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public DefaultGroupedDataView GetAClone()
            {
                DefaultGroupedDataView cloned = new DefaultGroupedDataView();

			cloned.m_SolutionId = m_SolutionId;
			cloned.m_Organization_1Id = m_Organization_1Id;
			cloned.m_CountPerFK = m_CountPerFK;
			cloned.m_Name = m_Name;
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

            #endregion Method of Build.DefaultGroupedDataView  GetAClone()
		}

        /// <summary>
        /// View "DefaultGroupedDataView" class of <see cref="Build"/>, used across the solution. 
        /// </summary>
		public partial class DefaultGroupedDataViewCollection
			:  List<DefaultGroupedDataView>
		{ 
		}

        /// <summary>
        /// message definition of "DefaultGroupedDataView", pass single entry, from database, to business logic layer. <see cref="Build"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfDefaultGroupedDataView
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<DefaultGroupedDataView>
		{
		}

        /// <summary>
        /// message definition of "DefaultGroupedDataView", pass a collection of instances, from database, to business logic layer. <see cref="Build"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfDefaultGroupedDataViewCollection
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<DefaultGroupedDataViewCollection>
		{
		}


        /// <summary>
        /// View "UpdateNameRequest" class of <see cref="Build"/>, used across the solution. 
        /// </summary>
		public partial class UpdateNameRequest :Framework.PropertyChangedNotifier, MSBuildExtensionPack.EntityContracts.IBuildIdentifier, Framework.EntityContracts.IClone<UpdateNameRequest>
		{

			#region Storage Fields

        System.Int64 m_Id;

        System.String m_Name;


			#endregion Storage Fields

			#region Constructors

			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" Build"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IBuild"/></param>
			public UpdateNameRequest()
			{
				this.Id = default(long);
				this.Name = null;
			}
			/*
			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" Build"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IBuild"/></param>
			public UpdateNameRequest(MSBuildExtensionPack.EntityContracts.IBuild item)
			{
				MSBuildExtensionPack.EntityContracts.IBuildHelper.Copy<MSBuildExtensionPack.EntityContracts.IBuild, UpdateNameRequest>(item, this);
			}
			*/
			#endregion Constructors


			#region properties

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Id", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="Id_is_required")]
#endif
        public System.Int64 Id
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
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Name", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="Name_is_required")]
		[StringLengthAttribute(100, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="The_length_of_Name_should_be_0_to_100")]
#endif
        public System.String Name
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

            #region Method of Build.UpdateNameRequest  GetAClone()

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public UpdateNameRequest GetAClone()
            {
                UpdateNameRequest cloned = new UpdateNameRequest();

			cloned.m_Id = m_Id;
			cloned.m_Name = m_Name;

                return cloned;
            }

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public UpdateNameRequest GetACloneWithoutIdentifier()
            {
                UpdateNameRequest cloned = GetAClone();

                return cloned;
            }

            #endregion Method of Build.UpdateNameRequest  GetAClone()
		}

        /// <summary>
        /// View "UpdateNameRequest" class of <see cref="Build"/>, used across the solution. 
        /// </summary>
		public partial class UpdateNameRequestCollection
			:  List<UpdateNameRequest>
		{ 
		}

        /// <summary>
        /// message definition of "UpdateNameRequest", pass single entry, from database, to business logic layer. <see cref="Build"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfUpdateNameRequest
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<UpdateNameRequest>
		{
		}

        /// <summary>
        /// message definition of "UpdateNameRequest", pass a collection of instances, from database, to business logic layer. <see cref="Build"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfUpdateNameRequestCollection
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<UpdateNameRequestCollection>
		{
		}


        /// <summary>
        /// View "KeyInformation" class of <see cref="Build"/>, used across the solution. 
        /// </summary>
		public partial class KeyInformation :Framework.PropertyChangedNotifier, MSBuildExtensionPack.EntityContracts.IBuildIdentifier, Framework.EntityContracts.IClone<KeyInformation>
		{

			#region Storage Fields

        System.Int64 m_Id;

        System.String m_Name;


			#endregion Storage Fields

			#region Constructors

			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" Build"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IBuild"/></param>
			public KeyInformation()
			{
				this.Id = default(long);
				this.Name = null;
			}
			/*
			/// <summary>
			/// Initializes/clone a new instance of the <see cref=" Build"/> class.
			/// </summary>
			/// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IBuild"/></param>
			public KeyInformation(MSBuildExtensionPack.EntityContracts.IBuild item)
			{
				MSBuildExtensionPack.EntityContracts.IBuildHelper.Copy<MSBuildExtensionPack.EntityContracts.IBuild, KeyInformation>(item, this);
			}
			*/
			#endregion Constructors


			#region properties

					[DataMember]
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Id", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="Id_is_required")]
#endif
        public System.Int64 Id
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
#if (WINDOWS_PHONE || XAMARIN)

#else
		[Display(Name = "Name", ResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild))]
		[RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="Name_is_required")]
		[StringLengthAttribute(100, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resources.UIStringResourcePerEntityBuild), ErrorMessageResourceName="The_length_of_Name_should_be_0_to_100")]
#endif
        public System.String Name
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

            #region Method of Build.KeyInformation  GetAClone()

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

            #endregion Method of Build.KeyInformation  GetAClone()
		}

        /// <summary>
        /// View "KeyInformation" class of <see cref="Build"/>, used across the solution. 
        /// </summary>
		public partial class KeyInformationCollection
			:  List<KeyInformation>
		{ 
		}

        /// <summary>
        /// message definition of "KeyInformation", pass single entry, from database, to business logic layer. <see cref="Build"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfKeyInformation
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<KeyInformation>
		{
		}

        /// <summary>
        /// message definition of "KeyInformation", pass a collection of instances, from database, to business logic layer. <see cref="Build"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
		public class DataAccessLayerMessageOfKeyInformationCollection
			: Framework.DataSourceEntities.DataAccessLayerMessageBase<KeyInformationCollection>
		{
		}




		#endregion Nested Views classes and their collection classes 4

	}



/*
    /// <summary>
    /// a property defined when <see cref="Build"/> is used in other classes.
    /// </summary>
	public interface WithEntityContractBuild
	{ 
        /// <summary>
        /// Gets or sets Build.
        /// </summary>
        /// <value>
        /// The Build
        /// </value>
		Build Build { get; set; }
	}
*/

    /// <summary>
    /// message definition, pass single entry, pulled from database, to business logic layer. <see cref="Build"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
    /// </summary>
    public class DataAccessLayerMessageOfEntityBuild
        : Framework.DataSourceEntities.DataAccessLayerMessageBase<Build>
    {
    }
}

