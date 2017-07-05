using System;
using System.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace MSBuildExtensionPack.EntityFrameworkDAL
{
    /// <summary>
    /// a factory class, can create all data access layer class instances for each entity.
    /// </summary>
    public class EFDataAccessLayerFactory
        : MSBuildExtensionPack.DALContracts.DataAccessLayerFactoryContract
	{
        #region constructors

        /// <summary>
        /// default constructor
        /// </summary>
        public EFDataAccessLayerFactory()
        {
        }

        #endregion constructors

		#region Entity related


        /// <summary>
        /// method to create an data access layer class instance of <see cref="MSBuildExtensionPack.DALContracts.IBuildRepository"/>
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildExtensionPack.DALContracts.IBuildRepository"/>.</returns>
        public MSBuildExtensionPack.DALContracts.IBuildRepository CreateDALInstanceOfBuild()
        {
            return new MSBuildExtensionPack.EntityFrameworkDAL.BuildRepository(new MSBuildExtensionPack.EntityFrameworkContext.MSBuildExtensionPackEntities());
        }



        /// <summary>
        /// method to create an data access layer class instance of <see cref="MSBuildExtensionPack.DALContracts.IBuildEventCodeRepository"/>
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildExtensionPack.DALContracts.IBuildEventCodeRepository"/>.</returns>
        public MSBuildExtensionPack.DALContracts.IBuildEventCodeRepository CreateDALInstanceOfBuildEventCode()
        {
            return new MSBuildExtensionPack.EntityFrameworkDAL.BuildEventCodeRepository(new MSBuildExtensionPack.EntityFrameworkContext.MSBuildExtensionPackEntities());
        }



        /// <summary>
        /// method to create an data access layer class instance of <see cref="MSBuildExtensionPack.DALContracts.IBuildLogRepository"/>
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildExtensionPack.DALContracts.IBuildLogRepository"/>.</returns>
        public MSBuildExtensionPack.DALContracts.IBuildLogRepository CreateDALInstanceOfBuildLog()
        {
            return new MSBuildExtensionPack.EntityFrameworkDAL.BuildLogRepository(new MSBuildExtensionPack.EntityFrameworkContext.MSBuildExtensionPackEntities());
        }



        /// <summary>
        /// method to create an data access layer class instance of <see cref="MSBuildExtensionPack.DALContracts.IOrganizationRepository"/>
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildExtensionPack.DALContracts.IOrganizationRepository"/>.</returns>
        public MSBuildExtensionPack.DALContracts.IOrganizationRepository CreateDALInstanceOfOrganization()
        {
            return new MSBuildExtensionPack.EntityFrameworkDAL.OrganizationRepository(new MSBuildExtensionPack.EntityFrameworkContext.MSBuildExtensionPackEntities());
        }



        /// <summary>
        /// method to create an data access layer class instance of <see cref="MSBuildExtensionPack.DALContracts.ISolutionRepository"/>
        /// </summary>
        /// <returns>a new instance of <see cref="MSBuildExtensionPack.DALContracts.ISolutionRepository"/>.</returns>
        public MSBuildExtensionPack.DALContracts.ISolutionRepository CreateDALInstanceOfSolution()
        {
            return new MSBuildExtensionPack.EntityFrameworkDAL.SolutionRepository(new MSBuildExtensionPack.EntityFrameworkContext.MSBuildExtensionPackEntities());
        }



		#endregion Entity related
    }

    /// <summary>
    /// singlton class of <see cref="EFDataAccessLayerFactory"/>
    /// </summary>
    public class EFDataAccessLayerFactorySingleton : Framework.Singleton<EFDataAccessLayerFactory>
    {
    }
}

