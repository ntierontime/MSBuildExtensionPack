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

export class BuildLogQueryCriteriaCommon {
    constructor(idCommonOfBuild_1: FrameworkEntityContracts.QueryNumberEqualsCriteria, idCommonOfSolution_1: FrameworkEntityContracts.QueryNumberEqualsCriteria, idCommonOfOrganization_1: FrameworkEntityContracts.QueryNumberEqualsCriteria, idCommonOfOrganization_2: FrameworkEntityContracts.QueryNumberEqualsCriteria, idCommonOfBuildEventCode_1: FrameworkEntityContracts.QueryNumberEqualsCriteria, eventTimeCommonOft: FrameworkEntityContracts.QuerySystemDateTimeRangeCriteria, messageCommonOft: FrameworkEntityContracts.QuerySystemStringContainsCriteria) {
        this.IdCommonOfBuild_1 = idCommonOfBuild_1;
        this.IdCommonOfSolution_1 = idCommonOfSolution_1;
        this.IdCommonOfOrganization_1 = idCommonOfOrganization_1;
        this.IdCommonOfOrganization_2 = idCommonOfOrganization_2;
        this.IdCommonOfBuildEventCode_1 = idCommonOfBuildEventCode_1;
        this.EventTimeCommonOft = eventTimeCommonOft;
        this.MessageCommonOft = messageCommonOft;
    }
    public IdCommonOfBuild_1: FrameworkEntityContracts.QueryNumberEqualsCriteria;
    public IdCommonOfSolution_1: FrameworkEntityContracts.QueryNumberEqualsCriteria;
    public IdCommonOfOrganization_1: FrameworkEntityContracts.QueryNumberEqualsCriteria;
    public IdCommonOfOrganization_2: FrameworkEntityContracts.QueryNumberEqualsCriteria;
    public IdCommonOfBuildEventCode_1: FrameworkEntityContracts.QueryNumberEqualsCriteria;
    public EventTimeCommonOft: FrameworkEntityContracts.QuerySystemDateTimeRangeCriteria;
    public MessageCommonOft: FrameworkEntityContracts.QuerySystemStringContainsCriteria;
}
export class BuildLogQueryCriteriaAll {
    constructor() {
    }
}

export class BuildLogQueryCriteriaByFKOnly {
    constructor(idCommonOfBuild_1: FrameworkEntityContracts.QueryNumberEqualsCriteria, idCommonOfSolution_1: FrameworkEntityContracts.QueryNumberEqualsCriteria, idCommonOfOrganization_1: FrameworkEntityContracts.QueryNumberEqualsCriteria, idCommonOfOrganization_2: FrameworkEntityContracts.QueryNumberEqualsCriteria, idCommonOfBuildEventCode_1: FrameworkEntityContracts.QueryNumberEqualsCriteria) {
        this.IdCommonOfBuild_1 = idCommonOfBuild_1;
        this.IdCommonOfSolution_1 = idCommonOfSolution_1;
        this.IdCommonOfOrganization_1 = idCommonOfOrganization_1;
        this.IdCommonOfOrganization_2 = idCommonOfOrganization_2;
        this.IdCommonOfBuildEventCode_1 = idCommonOfBuildEventCode_1;
    }
    public IdCommonOfBuild_1: FrameworkEntityContracts.QueryNumberEqualsCriteria;
    public IdCommonOfSolution_1: FrameworkEntityContracts.QueryNumberEqualsCriteria;
    public IdCommonOfOrganization_1: FrameworkEntityContracts.QueryNumberEqualsCriteria;
    public IdCommonOfOrganization_2: FrameworkEntityContracts.QueryNumberEqualsCriteria;
    public IdCommonOfBuildEventCode_1: FrameworkEntityContracts.QueryNumberEqualsCriteria;
}

export class BuildLogQueryCriteriaByIdentifier {
    constructor(idByIdentifierOft: FrameworkEntityContracts.QueryNumberEqualsCriteria) {
        this.IdByIdentifierOft = idByIdentifierOft;
    }
    public IdByIdentifierOft: FrameworkEntityContracts.QueryNumberEqualsCriteria;
}

export class BuildLogChainedQueryCriteriaCommon {
    constructor(idCommonOfBuild_1: FrameworkEntityContracts.QueryNumberEqualsCriteria, idCommonOfSolution_1: FrameworkEntityContracts.QueryNumberEqualsCriteria, idCommonOfOrganization_1: FrameworkEntityContracts.QueryNumberEqualsCriteria, idCommonOfOrganization_2: FrameworkEntityContracts.QueryNumberEqualsCriteria, idCommonOfBuildEventCode_1: FrameworkEntityContracts.QueryNumberEqualsCriteria, eventTimeCommonOft: FrameworkEntityContracts.QuerySystemDateTimeRangeCriteria, messageCommonOft: FrameworkEntityContracts.QuerySystemStringContainsCriteria) {
        this.BuildLogQueryCriteriaCommon = new BuildLogQueryCriteriaCommon(idCommonOfBuild_1, idCommonOfSolution_1, idCommonOfOrganization_1, idCommonOfOrganization_2, idCommonOfBuildEventCode_1, eventTimeCommonOft, messageCommonOft);
    }
    public BuildLogQueryCriteriaCommon: BuildLogQueryCriteriaCommon;
}


export class BuildLogChainedQueryCriteriaAll {
    constructor(BuildLogQueryCriteriaAll: BuildLogQueryCriteriaAll) {
        this.BuildLogQueryCriteriaAll = BuildLogQueryCriteriaAll;
    }
    public BuildLogQueryCriteriaAll: BuildLogQueryCriteriaAll;
}

export class BuildLogChainedQueryCriteriaByIdentifier {
    constructor(BuildLogQueryCriteriaByIdentifier: BuildLogQueryCriteriaByIdentifier) {
        this.BuildLogQueryCriteriaByIdentifier = BuildLogQueryCriteriaByIdentifier;
    }
    public BuildLogQueryCriteriaByIdentifier: BuildLogQueryCriteriaByIdentifier;
}

export class BuildLogChainedQueryCriteriaByFKOnly {
    constructor(idByFKOnlyOfBuild_1OfByFKOnly: FrameworkEntityContracts.QueryNumberEqualsCriteria, idByFKOnlyOfSolution_1OfByFKOnly: FrameworkEntityContracts.QueryNumberEqualsCriteria, idByFKOnlyOfOrganization_1OfByFKOnly: FrameworkEntityContracts.QueryNumberEqualsCriteria, idByFKOnlyOfOrganization_2OfByFKOnly: FrameworkEntityContracts.QueryNumberEqualsCriteria, idByFKOnlyOfBuildEventCode_1OfByFKOnly: FrameworkEntityContracts.QueryNumberEqualsCriteria) {
        this.BuildLogQueryCriteriaByFKOnly  = new BuildLogQueryCriteriaByFKOnly(idByFKOnlyOfBuild_1OfByFKOnly, idByFKOnlyOfSolution_1OfByFKOnly, idByFKOnlyOfOrganization_1OfByFKOnly, idByFKOnlyOfOrganization_2OfByFKOnly, idByFKOnlyOfBuildEventCode_1OfByFKOnly);
    }

    public BuildLogQueryCriteriaByFKOnly: BuildLogQueryCriteriaByFKOnly;
}

export class BuildLogRequestMessageBuiltIn extends FrameworkCommonBLLEntities.BusinessLogicLayerRequestMessageBase<BuildLogDS.BuildLog[]>
{
    constructor(businessLogicLayerRequestTypes: FrameworkCommonBLLEntities.BusinessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey: string, businessLogicLayerRequestID: string, currentIndex: number, pageSize: number, queryOrderByExpression: string) {
        super(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID, currentIndex, pageSize, queryOrderByExpression);

    }
}

export class BuildLogRequestMessageBuiltInOfIdentifier extends FrameworkCommonBLLEntities.BusinessLogicLayerRequestMessageBase<BuildLogDS.BuildLogIdentifier>
{
    constructor(businessLogicLayerRequestTypes: FrameworkCommonBLLEntities.BusinessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey: string, businessLogicLayerRequestID: string, currentIndex: number, pageSize: number, queryOrderByExpression: string) {
        super(businessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey, businessLogicLayerRequestID, currentIndex, pageSize, queryOrderByExpression);

    }
}

export class BuildLogResponseMessageBuiltIn extends FrameworkCommonBLLEntities.BusinessLogicLayerResponseMessageBase<BuildLogDS.BuildLog[]>
{

}
export module BuildLogResponseMessageBuiltIn {
    export class Default extends FrameworkCommonBLLEntities.BusinessLogicLayerResponseMessageBase<BuildLogDS.BuildLog.Default[]>
    {
    }
    export class DefaultGroupedDataView extends FrameworkCommonBLLEntities.BusinessLogicLayerResponseMessageBase<BuildLogDS.BuildLog.DefaultGroupedDataView[]>
    {
    }
    export class KeyInformation extends FrameworkCommonBLLEntities.BusinessLogicLayerResponseMessageBase<BuildLogDS.BuildLog.KeyInformation[]>
    {
    }
}
