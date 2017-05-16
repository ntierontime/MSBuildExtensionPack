using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Linq;

namespace MSBuildExtensionPack.DALContracts
{
    /// <summary>
    /// There is one method for each entity class, which creates data access layer instance.
    /// </summary>
    public partial interface DataAccessLayerFactoryContract
//        <

//		TDALContractOfBuild, TCollectionOfBuild, TOfBuild, TIdentifierOfBuild


//		, TDALContractOfBuildEventCode, TCollectionOfBuildEventCode, TOfBuildEventCode, TIdentifierOfBuildEventCode


//		, TDALContractOfBuildLog, TCollectionOfBuildLog, TOfBuildLog, TIdentifierOfBuildLog


//		, TDALContractOfOrganization, TCollectionOfOrganization, TOfOrganization, TIdentifierOfOrganization


//		, TDALContractOfSolution, TCollectionOfSolution, TOfSolution, TIdentifierOfSolution


//        >


//            where TDALContractOfBuild : IBuildRepository<TCollectionOfBuild, TOfBuild, TIdentifierOfBuild>
//            where TCollectionOfBuild : IList<TOfBuild>, new()
//            where TOfBuild : MSBuildExtensionPack.EntityContracts.IBuild, new()
//            where TIdentifierOfBuild : MSBuildExtensionPack.EntityContracts.IBuildIdentifier, new()


//            where TDALContractOfBuildEventCode : IBuildEventCodeRepository<TCollectionOfBuildEventCode, TOfBuildEventCode, TIdentifierOfBuildEventCode>
//            where TCollectionOfBuildEventCode : IList<TOfBuildEventCode>, new()
//            where TOfBuildEventCode : MSBuildExtensionPack.EntityContracts.IBuildEventCode, new()
//            where TIdentifierOfBuildEventCode : MSBuildExtensionPack.EntityContracts.IBuildEventCodeIdentifier, new()


//            where TDALContractOfBuildLog : IBuildLogRepository<TCollectionOfBuildLog, TOfBuildLog, TIdentifierOfBuildLog>
//            where TCollectionOfBuildLog : IList<TOfBuildLog>, new()
//            where TOfBuildLog : MSBuildExtensionPack.EntityContracts.IBuildLog, new()
//            where TIdentifierOfBuildLog : MSBuildExtensionPack.EntityContracts.IBuildLogIdentifier, new()


//            where TDALContractOfOrganization : IOrganizationRepository<TCollectionOfOrganization, TOfOrganization, TIdentifierOfOrganization>
//            where TCollectionOfOrganization : IList<TOfOrganization>, new()
//            where TOfOrganization : MSBuildExtensionPack.EntityContracts.IOrganization, new()
//            where TIdentifierOfOrganization : MSBuildExtensionPack.EntityContracts.IOrganizationIdentifier, new()


//            where TDALContractOfSolution : ISolutionRepository<TCollectionOfSolution, TOfSolution, TIdentifierOfSolution>
//            where TCollectionOfSolution : IList<TOfSolution>, new()
//            where TOfSolution : MSBuildExtensionPack.EntityContracts.ISolution, new()
//            where TIdentifierOfSolution : MSBuildExtensionPack.EntityContracts.ISolutionIdentifier, new()


    {

        /// <summary>
        /// Creates the DAL instance of MSBuildExtensionPack.DALContracts.IBuildRepository for entity TDALContractOfBuild .
        /// </summary>
        /// <returns>one instance of data access layer class</returns>
        //TDALContractOfBuild CreateDALInstanceOfBuild();
		MSBuildExtensionPack.DALContracts.IBuildRepository CreateDALInstanceOfBuild();


        /// <summary>
        /// Creates the DAL instance of MSBuildExtensionPack.DALContracts.IBuildEventCodeRepository for entity TDALContractOfBuildEventCode .
        /// </summary>
        /// <returns>one instance of data access layer class</returns>
        //TDALContractOfBuildEventCode CreateDALInstanceOfBuildEventCode();
		MSBuildExtensionPack.DALContracts.IBuildEventCodeRepository CreateDALInstanceOfBuildEventCode();


        /// <summary>
        /// Creates the DAL instance of MSBuildExtensionPack.DALContracts.IBuildLogRepository for entity TDALContractOfBuildLog .
        /// </summary>
        /// <returns>one instance of data access layer class</returns>
        //TDALContractOfBuildLog CreateDALInstanceOfBuildLog();
		MSBuildExtensionPack.DALContracts.IBuildLogRepository CreateDALInstanceOfBuildLog();


        /// <summary>
        /// Creates the DAL instance of MSBuildExtensionPack.DALContracts.IOrganizationRepository for entity TDALContractOfOrganization .
        /// </summary>
        /// <returns>one instance of data access layer class</returns>
        //TDALContractOfOrganization CreateDALInstanceOfOrganization();
		MSBuildExtensionPack.DALContracts.IOrganizationRepository CreateDALInstanceOfOrganization();


        /// <summary>
        /// Creates the DAL instance of MSBuildExtensionPack.DALContracts.ISolutionRepository for entity TDALContractOfSolution .
        /// </summary>
        /// <returns>one instance of data access layer class</returns>
        //TDALContractOfSolution CreateDALInstanceOfSolution();
		MSBuildExtensionPack.DALContracts.ISolutionRepository CreateDALInstanceOfSolution();


	}
}