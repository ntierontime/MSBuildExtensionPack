import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import * as Framework from './Framework';
import * as FrameworkCommonBLLEntities from './Framework.CommonBLLEntities';
import * as FrameworkEntityContracts from './Framework.EntityContracts';
import * as FrameworkViewModels from './Framework.ViewModels';

export class BuildEventCode {
    constructor() {

    }
    public Id: number;
    public EventCode: string;
    public Description: string;
}

export namespace BuildEventCode {
    export class KeyInformation {
        constructor() {
            this.Id = null;
            this.EventCode = null;
        }
        public Id: number;
        public EventCode: string;
    }
}

export class BuildEventCodeIdentifier {
    constructor(id: number) {
        this.Id = id;
    }
    public Id: number;
}

export class BuildEventCodeQueryCriteriaCommon {
    constructor(eventCodeCommonOft: FrameworkEntityContracts.QuerySystemStringContainsCriteria, descriptionCommonOft: FrameworkEntityContracts.QuerySystemStringContainsCriteria) {
        this.EventCodeCommonOft = eventCodeCommonOft;
        this.DescriptionCommonOft = descriptionCommonOft;
    }
    public EventCodeCommonOft: FrameworkEntityContracts.QuerySystemStringContainsCriteria;
    public DescriptionCommonOft: FrameworkEntityContracts.QuerySystemStringContainsCriteria;
}
export class BuildEventCodeQueryCriteriaAll {
    constructor() {
    }
}
export class BuildEventCodeQueryCriteriaByIdentifier {
    constructor(idByIdentifierOft: FrameworkEntityContracts.QueryNumberEqualsCriteria) {
        this.IdByIdentifierOft = idByIdentifierOft;
    }
    public IdByIdentifierOft: FrameworkEntityContracts.QueryNumberEqualsCriteria;
}

export class BuildEventCodeChainedQueryCriteriaCommon {
    constructor(eventCodeCommonOftOfCommon: FrameworkEntityContracts.QuerySystemStringContainsCriteria, descriptionCommonOftOfCommon: FrameworkEntityContracts.QuerySystemStringContainsCriteria) {
        this.BuildEventCodeQueryCriteriaCommon = new BuildEventCodeQueryCriteriaCommon(eventCodeCommonOftOfCommon, descriptionCommonOftOfCommon);
    }
    public BuildEventCodeQueryCriteriaCommon: BuildEventCodeQueryCriteriaCommon;
}

export class BuildEventCodeChainedQueryCriteriaAll {
    constructor(buildEventCodeQueryCriteriaAll: BuildEventCodeQueryCriteriaAll) {
        this.BuildEventCodeQueryCriteriaAll = buildEventCodeQueryCriteriaAll;
    }
    public BuildEventCodeQueryCriteriaAll: BuildEventCodeQueryCriteriaAll;
}

export class BuildEventCodeChainedQueryCriteriaByIdentifier {
    constructor(buildEventCodeQueryCriteriaByIdentifier: BuildEventCodeQueryCriteriaByIdentifier) {
        this.BuildEventCodeQueryCriteriaByIdentifier = buildEventCodeQueryCriteriaByIdentifier;
    }
    public BuildEventCodeQueryCriteriaByIdentifier: BuildEventCodeQueryCriteriaByIdentifier;
}

export class BuildEventCodeRequestMessageBuiltIn extends FrameworkCommonBLLEntities.BusinessLogicLayerRequestMessageBase<BuildEventCode[]>
{
    constructor(businessLogicLayerRequestTypes: FrameworkCommonBLLEntities.BusinessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey: string, businessLogicLayerRequestID: string, currentIndex: number, pageSize: number, queryOrderByExpression: string) {
        super(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID, currentIndex, pageSize, queryOrderByExpression);

    }
}

export class BuildEventCodeRequestMessageBuiltInOfIdentifier extends FrameworkCommonBLLEntities.BusinessLogicLayerRequestMessageBase<BuildEventCodeIdentifier>
{
    constructor(businessLogicLayerRequestTypes: FrameworkCommonBLLEntities.BusinessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey: string, businessLogicLayerRequestID: string, currentIndex: number, pageSize: number, queryOrderByExpression: string) {
        super(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID, currentIndex, pageSize, queryOrderByExpression);

    }
}

export class BuildEventCodeResponseMessageBuiltIn extends FrameworkCommonBLLEntities.BusinessLogicLayerResponseMessageBase<BuildEventCode[]>
{

}
export module BuildEventCodeResponseMessageBuiltIn {
    export class KeyInformation extends FrameworkCommonBLLEntities.BusinessLogicLayerResponseMessageBase<BuildEventCode.KeyInformation[]>
    {
    }
}

export class BuildEventCodeItemVM extends FrameworkViewModels.ViewModelItemBase<BuildEventCodeIdentifier, BuildEventCode>
{
}

export class WPCommonOfBuildEventCodeVM extends FrameworkViewModels.ViewModelBase<BuildEventCodeChainedQueryCriteriaCommon, BuildEventCode[]>
{
    constructor() {
        super();

    }
}

export class WPEntityRelatedOfBuildEventCodeVM extends FrameworkViewModels.ViewModelEntityRelatedBase<BuildEventCode, BuildEventCodeChainedQueryCriteriaByIdentifier>
{
    constructor(criteriaOfMasterEntity: BuildEventCodeChainedQueryCriteriaByIdentifier) {
        super(criteriaOfMasterEntity);
        //this.CriteriaOfFK_BuildLog_BuildEventCode = new BuildLogChainedQueryCriteriaByFKOnly();
    }
    //public CriteriaOfFK_BuildLog_BuildEventCode: MSBuildExtensionPackCommonBLLEntities.BuildLogChainedQueryCriteriaByFKOnly;
    public StatusOfFK_BuildLog_BuildEventCode: FrameworkCommonBLLEntities.BusinessLogicLayerResponseStatus;
    public StatusMessageOfFK_BuildLog_BuildEventCode: string;
    //public FK_BuildLog_BuildEventCode: MSBuildExtensionPackDataSourceEntities.BuildLog.Default[];
}