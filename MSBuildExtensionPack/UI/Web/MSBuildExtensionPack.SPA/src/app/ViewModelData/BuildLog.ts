import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import * as Framework from '../Framework';
import * as FrameworkCommonBLLEntities from '../Framework.CommonBLLEntities';
import * as FrameworkEntityContracts from '../Framework.EntityContracts';
import * as FrameworkViewModels from '../Framework.ViewModels';
import * as DataSourceEntities from '../DataSourceEntities/BuildLog';
import * as DataSourceEntitiesBuildEventCode from '../DataSourceEntities/BuildEventCode';
import * as CommonBLLEntities from '../CommonBLLEntities/BuildLog';
import * as CommonBLLEntitiesBuildEventCode from '../CommonBLLEntities/BuildEventCode';


export class BuildLogItemVM extends FrameworkViewModels.ViewModelItemBase<DataSourceEntities.BuildLogIdentifier, DataSourceEntities.BuildLog.Default>
{
    public NameValueCollectionOfMSBuildExtensionPack_Organization: Framework.NameValuePair[];
    public NameValueCollectionOfMSBuildExtensionPack_BuildEventCode: Framework.NameValuePair[];
}


export class WPCommonOfBuildLogVM extends FrameworkViewModels.ViewModelBase<CommonBLLEntities.BuildLogChainedQueryCriteriaCommon, DataSourceEntities.BuildLog.Default[]>
{
    constructor() {
        super();

    }
    public NameValueCollectionOfMSBuildExtensionPack_Organization: Framework.NameValuePair[];
    public NameValueCollectionOfMSBuildExtensionPack_BuildEventCode: Framework.NameValuePair[];
}

export class WPEntityRelatedOfBuildLogVM extends FrameworkViewModels.ViewModelEntityRelatedBase<DataSourceEntities.BuildLog.Default, CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier>
{
    constructor() {
        super(null);

    }

    //public CriteriaOfBuild_1: MSBuildExtensionPack.CommonBLLEntities.BuildChainedQueryCriteriaByIdentifier;
    //public StatusOfBuild_1: Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus;
    //public StatusMessageOfBuild_1: string;
    //public Build_1: MSBuildExtensionPack.DataSourceEntities.Build.KeyInformation;
    //public CriteriaOfSolution_1: MSBuildExtensionPack.CommonBLLEntities.SolutionChainedQueryCriteriaByIdentifier;
    //public StatusOfSolution_1: Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus;
    //public StatusMessageOfSolution_1: string;
    //public Solution_1: MSBuildExtensionPack.DataSourceEntities.Solution.KeyInformation;
    //public CriteriaOfOrganization_1: MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaByIdentifier;
    //public StatusOfOrganization_1: Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus;
    //public StatusMessageOfOrganization_1: string;
    //public Organization_1: MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation;
    //public CriteriaOfOrganization_2: MSBuildExtensionPack.CommonBLLEntities.OrganizationChainedQueryCriteriaByIdentifier;
    //public StatusOfOrganization_2: Framework.CommonBLLEntities.BusinessLogicLayerResponseStatus;
    //public StatusMessageOfOrganization_2: string;
    //public Organization_2: MSBuildExtensionPack.DataSourceEntities.Organization.KeyInformation;
    public CriteriaOfBuildEventCode_1: CommonBLLEntitiesBuildEventCode.BuildEventCodeChainedQueryCriteriaByIdentifier;
    public StatusOfBuildEventCode_1: FrameworkCommonBLLEntities.BusinessLogicLayerResponseStatus;
    public StatusMessageOfBuildEventCode_1: string;
    public BuildEventCode_1: DataSourceEntitiesBuildEventCode.BuildEventCode.KeyInformation;
}