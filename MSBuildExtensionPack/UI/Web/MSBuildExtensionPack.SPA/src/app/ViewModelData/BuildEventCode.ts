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
import * as DataSourceEntities from '../DataSourceEntities/BuildEventCode';
import * as DataSourceEntitiesBuildLog from '../DataSourceEntities/BuildLog';
import * as CommonBLLEntities from '../CommonBLLEntities/BuildEventCode';
import * as CommonBLLEntitiesBuildLog from '../CommonBLLEntities/BuildLog';

export class BuildEventCodeItemVM extends FrameworkViewModels.ViewModelItemBase<DataSourceEntities.BuildEventCodeIdentifier, DataSourceEntities.BuildEventCode>
{
}

export class WPCommonOfBuildEventCodeVM extends FrameworkViewModels.ViewModelBase<CommonBLLEntities.BuildEventCodeChainedQueryCriteriaCommon, DataSourceEntities.BuildEventCode[]>
{
    constructor() {
        super();

    }
}

export class WPEntityRelatedOfBuildEventCodeVM extends FrameworkViewModels.ViewModelEntityRelatedBase<DataSourceEntities.BuildEventCode, CommonBLLEntities.BuildEventCodeChainedQueryCriteriaByIdentifier>
{
    constructor(criteriaOfMasterEntity: CommonBLLEntities.BuildEventCodeChainedQueryCriteriaByIdentifier) {
        super(criteriaOfMasterEntity);
        this.CriteriaOfFK_BuildLog_BuildEventCode = new CommonBLLEntitiesBuildLog.BuildLogChainedQueryCriteriaByFKOnly(
            new FrameworkEntityContracts.QueryNumberEqualsCriteria(false, null), new FrameworkEntityContracts.QueryNumberEqualsCriteria(false, null), new FrameworkEntityContracts.QueryNumberEqualsCriteria(false, null), new FrameworkEntityContracts.QueryNumberEqualsCriteria(false, null), new FrameworkEntityContracts.QueryNumberEqualsCriteria(false, null)
        );
    }
    public CriteriaOfFK_BuildLog_BuildEventCode: CommonBLLEntitiesBuildLog.BuildLogChainedQueryCriteriaByFKOnly;
    public StatusOfFK_BuildLog_BuildEventCode: FrameworkCommonBLLEntities.BusinessLogicLayerResponseStatus;
    public StatusMessageOfFK_BuildLog_BuildEventCode: string;
    public FK_BuildLog_BuildEventCode: DataSourceEntitiesBuildLog.BuildLog.Default[];
}