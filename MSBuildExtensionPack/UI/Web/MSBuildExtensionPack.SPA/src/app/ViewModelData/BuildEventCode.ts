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
import * as BuildEventCodeDS from '../DataSourceEntities/BuildEventCode';
import * as CommonBLLEntities from '../CommonBLLEntities/BuildEventCode';

export class BuildEventCodeItemVM extends FrameworkViewModels.ViewModelItemBase<BuildEventCodeDS.BuildEventCodeIdentifier, BuildEventCodeDS.BuildEventCode>
{
}

export class WPCommonOfBuildEventCodeVM extends FrameworkViewModels.ViewModelBase<CommonBLLEntities.BuildEventCodeChainedQueryCriteriaCommon, BuildEventCodeDS.BuildEventCode[]>
{
    constructor() {
        super();

    }
}

export class WPEntityRelatedOfBuildEventCodeVM extends FrameworkViewModels.ViewModelEntityRelatedBase<BuildEventCodeDS.BuildEventCode, CommonBLLEntities.BuildEventCodeChainedQueryCriteriaByIdentifier>
{
    constructor(criteriaOfMasterEntity: CommonBLLEntities.BuildEventCodeChainedQueryCriteriaByIdentifier) {
        super(criteriaOfMasterEntity);
        //this.CriteriaOfFK_BuildLog_BuildEventCode = new BuildLogChainedQueryCriteriaByFKOnly();
    }
    //public CriteriaOfFK_BuildLog_BuildEventCode: MSBuildExtensionPackCommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly;
    public StatusOfFK_BuildLog_BuildEventCode: FrameworkCommonBLLEntities.BusinessLogicLayerResponseStatus;
    public StatusMessageOfFK_BuildLog_BuildEventCode: string;
    //public FK_BuildLog_BuildEventCode: MSBuildExtensionPackDataSourceEntities.BuildLog.Default[];
}