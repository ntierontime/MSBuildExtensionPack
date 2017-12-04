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

export class BuildEventCodeRequestMessageBuiltIn extends FrameworkCommonBLLEntities.BusinessLogicLayerRequestMessageBase<BuildEventCodeDS.BuildEventCode[]>
{
    constructor(businessLogicLayerRequestTypes: FrameworkCommonBLLEntities.BusinessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey: string, businessLogicLayerRequestID: string, currentIndex: number, pageSize: number, queryOrderByExpression: string) {
        super(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID, currentIndex, pageSize, queryOrderByExpression);

    }
}

export class BuildEventCodeRequestMessageBuiltInOfIdentifier extends FrameworkCommonBLLEntities.BusinessLogicLayerRequestMessageBase<BuildEventCodeDS.BuildEventCodeIdentifier>
{
    constructor(businessLogicLayerRequestTypes: FrameworkCommonBLLEntities.BusinessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey: string, businessLogicLayerRequestID: string, currentIndex: number, pageSize: number, queryOrderByExpression: string) {
        super(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID, currentIndex, pageSize, queryOrderByExpression);

    }
}

export class BuildEventCodeResponseMessageBuiltIn extends FrameworkCommonBLLEntities.BusinessLogicLayerResponseMessageBase<BuildEventCodeDS.BuildEventCode[]>
{

}
export module BuildEventCodeResponseMessageBuiltIn {
    export class KeyInformation extends FrameworkCommonBLLEntities.BusinessLogicLayerResponseMessageBase<BuildEventCodeDS.BuildEventCode.KeyInformation[]>
    {
    }
}
