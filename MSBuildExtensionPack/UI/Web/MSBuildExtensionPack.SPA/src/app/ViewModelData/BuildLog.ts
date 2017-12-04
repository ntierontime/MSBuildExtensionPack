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
import * as BuildLogDS from '../DataSourceEntities/BuildLog';
import * as CommonBLLEntities from '../CommonBLLEntities/BuildLog';

export class BuildLogItemVM extends FrameworkViewModels.ViewModelItemBase<BuildLogDS.BuildLogIdentifier, BuildLogDS.BuildLog.Default>
{
}

export class WPCommonOfBuildLogVM extends FrameworkViewModels.ViewModelBase<CommonBLLEntities.BuildLogChainedQueryCriteriaCommon, BuildLogDS.BuildLog.Default[]>
{
    constructor() {
        super();

    }
}

export class WPEntityRelatedOfBuildLogVM extends FrameworkViewModels.ViewModelEntityRelatedBase<BuildLogDS.BuildLog.Default, CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier>
{
    constructor(criteriaOfMasterEntity: CommonBLLEntities.BuildLogChainedQueryCriteriaByIdentifier) {
        super(criteriaOfMasterEntity);
        this.CriteriaOfFK_BuildLog_BuildLog = new CommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly();
    }
    //public CriteriaOfFK_BuildLog_BuildLog: MSBuildExtensionPackCommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly;
    public StatusOfFK_BuildLog_BuildLog: FrameworkCommonBLLEntities.BusinessLogicLayerResponseStatus;
    public StatusMessageOfFK_BuildLog_BuildLog: string;
    //public FK_BuildLog_BuildLog: MSBuildExtensionPackDataSourceEntities.BuildLog.Default[];
}