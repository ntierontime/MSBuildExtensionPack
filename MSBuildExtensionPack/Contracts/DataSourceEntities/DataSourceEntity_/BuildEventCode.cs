using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.ComponentModel.DataAnnotations;

namespace MSBuildExtensionPack.DataSourceEntities
{
    /// <summary>
    /// Entity class, used across the solution. <see cref="BuildEventCode"/>
    /// </summary>
    //[DataContract]
    public partial class BuildEventCode : Framework.PropertyChangedNotifier, MSBuildExtensionPack.EntityContracts.IBuildEventCode, Framework.EntityContracts.IClone<BuildEventCode>
    {

        #region Storage Fields

        System.Int32 m_Id;

        System.String m_EventCode;

        System.String m_Description;

        #endregion Storage Fields

        /// <summary>
        /// Initializes a new instance of the <see cref=" BuildEventCode"/> class.
        /// </summary>
        public BuildEventCode()
        {
            this.Id = default(int);
            this.EventCode = null;
            this.Description = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref=" BuildEventCode"/> class with .Net value type parameters.
        /// </summary>
        /// <param name="id">property value of Id</param>
        /// <param name="eventCode">property value of EventCode</param>
        /// <param name="description">property value of Description</param>
        public BuildEventCode(
            System.Int32 id
            ,System.String eventCode
            ,System.String description
            )
        {
            this.m_Id = id;
            this.m_EventCode = eventCode;
            this.m_Description = description;
        }

        /// <summary>
        /// Initializes/clone a new instance of the <see cref=" BuildEventCode"/> class.
        /// </summary>
        /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IBuildEventCode"/></param>
        public BuildEventCode(MSBuildExtensionPack.EntityContracts.IBuildEventCode item)
        {
            MSBuildExtensionPack.EntityContracts.IBuildEventCodeHelper.Copy<MSBuildExtensionPack.EntityContracts.IBuildEventCode, BuildEventCode>(item, this);
        }

        #region properties

                [DataMember]
        [Display(Name = "Id", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildEventCode))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildEventCode), ErrorMessageResourceName="Id_is_required")]        public System.Int32 Id
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
        [Display(Name = "EventCode", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildEventCode))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildEventCode), ErrorMessageResourceName="EventCode_is_required")]
        [StringLengthAttribute(100, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildEventCode), ErrorMessageResourceName="The_length_of_EventCode_should_be_0_to_100")]        public System.String EventCode
        {
            get
            {
                return m_EventCode;
            }
            set
            {
                m_EventCode = value;
                RaisePropertyChanged("EventCode");
            }
        }

                [DataMember]
        [Display(Name = "Description", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildEventCode))]
        [StringLengthAttribute(1500, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildEventCode), ErrorMessageResourceName="The_length_of_Description_should_be_0_to_1500")]        public System.String Description
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
            return MSBuildExtensionPack.EntityContracts.IBuildEventCodeHelper.ToString<BuildEventCode>(this);
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
            bool _retval = obj is BuildEventCode;
            if (_retval == true)
            {
                _retval = MSBuildExtensionPack.EntityContracts.IBuildEventCodeHelper.Equals<BuildEventCode, BuildEventCode>(this, (BuildEventCode)obj);
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

        #region Method of BuildEventCode GetAClone()

        /// <summary>
        /// Gets the A clone.
        /// </summary>
        /// <returns>a new instance with same value</returns>
        public BuildEventCode GetAClone()
        {
            return MSBuildExtensionPack.EntityContracts.IBuildEventCodeHelper.Clone<BuildEventCode, BuildEventCode>(this);
        }

        public BuildEventCode GetACloneWithoutIdentifier()
        {
            var cloned = GetAClone();

            return cloned;
        }

        #endregion Method of BuildEventCode GetAClone()

        #region Nested Views classes and their collection classes 1

        /// <summary>
        /// View "KeyInformation" class of <see cref="BuildEventCode"/>, used across the solution.
        /// </summary>
        public partial class KeyInformation :Framework.PropertyChangedNotifier, MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifier, Framework.EntityContracts.IClone<KeyInformation>
        {

            #region Storage Fields

        System.Int32 m_Id;

        System.String m_EventCode;

            #endregion Storage Fields

            #region Constructors

            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" BuildEventCode"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IBuildEventCode"/></param>
            public KeyInformation()
            {
                this.Id = default(int);
                this.EventCode = null;
            }
            /*
            /// <summary>
            /// Initializes/clone a new instance of the <see cref=" BuildEventCode"/> class.
            /// </summary>
            /// <param name="item">an entity instance with same contract of <see cref=" MSBuildExtensionPack.EntityContracts.IBuildEventCode"/></param>
            public KeyInformation(MSBuildExtensionPack.EntityContracts.IBuildEventCode item)
            {
                MSBuildExtensionPack.EntityContracts.IBuildEventCodeHelper.Copy<MSBuildExtensionPack.EntityContracts.IBuildEventCode, KeyInformation>(item, this);
            }
            */
            #endregion Constructors

            #region properties

                    [DataMember]
        [Display(Name = "Id", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildEventCode))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildEventCode), ErrorMessageResourceName="Id_is_required")]        public System.Int32 Id
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
        [Display(Name = "EventCode", ResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildEventCode))]
        [RequiredAttribute(ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildEventCode), ErrorMessageResourceName="EventCode_is_required")]
        [StringLengthAttribute(100, ErrorMessageResourceType = typeof(MSBuildExtensionPack.Resx.UIStringResourcePerEntityBuildEventCode), ErrorMessageResourceName="The_length_of_EventCode_should_be_0_to_100")]        public System.String EventCode
        {
            get
            {
                return m_EventCode;
            }
            set
            {
                m_EventCode = value;
                RaisePropertyChanged("EventCode");
            }
        }

            #endregion properties

            #region Method of BuildEventCode.KeyInformation  GetAClone()

            /// <summary>
            /// Gets the A clone.
            /// </summary>
            /// <returns>a new instance with same value</returns>
            public KeyInformation GetAClone()
            {
                KeyInformation cloned = new KeyInformation();

            cloned.m_Id = m_Id;
            cloned.m_EventCode = m_EventCode;

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

            #endregion Method of BuildEventCode.KeyInformation  GetAClone()
        }

        /// <summary>
        /// View "KeyInformation" class of <see cref="BuildEventCode"/>, used across the solution.
        /// </summary>
        public partial class KeyInformationCollection
            :  List<KeyInformation>
        {
        }

        /// <summary>
        /// message definition of "KeyInformation", pass single entry, from database, to business logic layer. <see cref="BuildEventCode"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfKeyInformation
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<KeyInformation>
        {
        }

        /// <summary>
        /// message definition of "KeyInformation", pass a collection of instances, from database, to business logic layer. <see cref="BuildEventCode"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
        /// </summary>
        public class DataAccessLayerMessageOfKeyInformationCollection
            : Framework.DataSourceEntities.DataAccessLayerMessageBase<KeyInformationCollection>
        {
        }

        #endregion Nested Views classes and their collection classes 1
    }

    /// <summary>
    /// message definition, pass single entry, pulled from database, to business logic layer. <see cref="BuildEventCode"/> and <see cref="Framework.DataAccessLayerMessageBase&lt;T&gt;"/>
    /// </summary>
    public class DataAccessLayerMessageOfEntityBuildEventCode
        : Framework.DataSourceEntities.DataAccessLayerMessageBase<BuildEventCode>
    {
    }
}

