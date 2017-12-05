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
import * as Net from '../ApiControllerHttpClientBase';
import * as DataSourceEntities from '../DataSourceEntities/BuildLog';
import * as DataSourceEntitiesBuildEventCode from '../DataSourceEntities/BuildEventCode';
import * as CommonBLLEntities from '../CommonBLLEntities/BuildLog';
import * as ViewModelData from '../ViewModelData/BuildLog';

export class BuildLogApiControllerClient extends Net.ApiControllerHttpClientBase {
    public static ControllerNameString: string = "BuildLogApi";
    public get ControllerName(): string {
        return BuildLogApiControllerClient.ControllerNameString;
    }
    constructor(rootPath: string) {
        super(rootPath);

    }
    public static ActionName_InsertEntity: string = "InsertEntity";
    public InsertEntityAsync(input: DataSourceEntities.BuildLog): CommonBLLEntities.BuildLogResponseMessageBuiltIn {
        var url: string = super.GetHttpRequestUrl(BuildLogApiControllerClient.ActionName_InsertEntity, null);
        return super.Post<DataSourceEntities.BuildLog, CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, input);
    }
    public static ActionName_UpdateEntity: string = "UpdateEntity";
    public UpdateEntityAsync(input: DataSourceEntities.BuildLog): CommonBLLEntities.BuildLogResponseMessageBuiltIn {
        var url: string = super.GetHttpRequestUrl(BuildLogApiControllerClient.ActionName_UpdateEntity, null);
        return super.Put<DataSourceEntities.BuildLog, CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, input);
    }
    public static ActionName_DeleteByIdentifierEntity: string = "DeleteByIdentifierEntity";
    public DeleteByIdentifierEntityAsync(identifier: DataSourceEntities.BuildLogIdentifier): CommonBLLEntities.BuildLogResponseMessageBuiltIn {
        var url: string = super.GetHttpRequestUrl(BuildLogApiControllerClient.ActionName_DeleteByIdentifierEntity, null);
        return super.Post<DataSourceEntities.BuildLogIdentifier, CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, identifier);
    }

    public static ActionName_DeleteEntity: string = "DeleteEntity";
    public DeleteEntityAsync(input: DataSourceEntities.BuildLog): CommonBLLEntities.BuildLogResponseMessageBuiltIn {
        var url: string = super.GetHttpRequestUrl(BuildLogApiControllerClient.ActionName_DeleteEntity, null);
        return super.Post<DataSourceEntities.BuildLog, CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, input);
    }
    public static ActionName_DeleteByIdentifier: string = "DeleteByIdentifier";
    public DeleteByIdentifierAsync(id: null): CommonBLLEntities.BuildLogResponseMessageBuiltIn {
        var parameters: [string, string][];
        parameters.push(['id', '' + id]);
        var url: string = super.GetHttpRequestUrl(BuildLogApiControllerClient.ActionName_DeleteByIdentifier, parameters);
        return super.Delete<CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url);
    }
    public static ActionName_BatchInsert: string = "BatchInsert";
    public BatchInsertAsync(input: DataSourceEntities.BuildLog[]): CommonBLLEntities.BuildLogResponseMessageBuiltIn {
        var url: string = super.GetHttpRequestUrl(BuildLogApiControllerClient.ActionName_BatchInsert, null);
        return super.Post<DataSourceEntities.BuildLog[], CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, input);
    }
    public static ActionName_BatchUpdate: string = "BatchUpdate";
    public BatchUpdateAsync(input: DataSourceEntities.BuildLog[]): CommonBLLEntities.BuildLogResponseMessageBuiltIn {
        var url: string = super.GetHttpRequestUrl(BuildLogApiControllerClient.ActionName_BatchUpdate, null);
        return super.Put<DataSourceEntities.BuildLog[], CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, input);
    }
    public static ActionName_BatchDelete: string = "BatchDelete";
    public BatchDeleteAsync(input: DataSourceEntities.BuildLog[]): CommonBLLEntities.BuildLogResponseMessageBuiltIn {
        var url: string = super.GetHttpRequestUrl(BuildLogApiControllerClient.ActionName_BatchDelete, null);
        return super.Post<DataSourceEntities.BuildLog[], CommonBLLEntities.BuildLogResponseMessageBuiltIn>(url, input);
    }
    public static ActionName_GetCollectionOfNameValuePairOfAll: string = "GetCollectionOfNameValuePairOfAll";
    public GetCollectionOfNameValuePairOfAllAsync(currentIndex: number, pageSize: number, queryOrderByExpression: string): Framework.NameValuePair[] {
        var parameters: [string, string][];
        parameters.push(["currentIndex", currentIndex.toString()]);
        parameters.push(["pageSize", pageSize.toString()]);
        parameters.push(["queryOrderByExpression", queryOrderByExpression]);
        var url: string = super.GetHttpRequestUrl(BuildLogApiControllerClient.ActionName_GetCollectionOfNameValuePairOfAll, parameters);
        return super.Get<Framework.NameValuePair[]> (url);
    }
    public static ActionName_GetCollectionOfNameValuePairOfByFKOnly: string = "GetCollectionOfNameValuePairOfByFKOnly";
    public GetCollectionOfNameValuePairOfByFKOnlyAsync(isToCompareIdByFKOnlyOfBuild_1OfByFKOnly: boolean, valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly: number, isToCompareIdByFKOnlyOfSolution_1OfByFKOnly: boolean, valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly: number, isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly: boolean, valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly: number, isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly: boolean, valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly: number, isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly: boolean, valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly: number, currentIndex: number, pageSize: number, queryOrderByExpression: string): Framework.NameValuePair[] {
        var parameters: [string, string][];
        parameters.push(["isToCompareIdByFKOnlyOfBuild_1OfByFKOnly", isToCompareIdByFKOnlyOfBuild_1OfByFKOnly.toString()]);
        parameters.push(["valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly", valueToCompareIdByFKOnlyOfBuild_1OfByFKOnly.toString()]);
        parameters.push(["isToCompareIdByFKOnlyOfSolution_1OfByFKOnly", isToCompareIdByFKOnlyOfSolution_1OfByFKOnly.toString()]);
        parameters.push(["valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly", valueToCompareIdByFKOnlyOfSolution_1OfByFKOnly.toString()]);
        parameters.push(["isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly", isToCompareIdByFKOnlyOfOrganization_1OfByFKOnly.toString()]);
        parameters.push(["valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly", valueToCompareIdByFKOnlyOfOrganization_1OfByFKOnly.toString()]);
        parameters.push(["isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly", isToCompareIdByFKOnlyOfOrganization_2OfByFKOnly.toString()]);
        parameters.push(["valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly", valueToCompareIdByFKOnlyOfOrganization_2OfByFKOnly.toString()]);
        parameters.push(["isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly", isToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly.toString()]);
        parameters.push(["valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly", valueToCompareIdByFKOnlyOfBuildEventCode_1OfByFKOnly.toString()]);
        parameters.push(["currentIndex", currentIndex.toString()]);
        parameters.push(["pageSize", pageSize.toString()]);
        parameters.push(["queryOrderByExpression", queryOrderByExpression]);
        var url: string = super.GetHttpRequestUrl(BuildLogApiControllerClient.ActionName_GetCollectionOfNameValuePairOfByFKOnly, parameters);
        return super.Get<Framework.NameValuePair[]>(url);
    }
    public static ActionName_GetBuildLogItemVM: string = "GetBuildLogItemVM";
    public GetBuildLogItemVMAsync(id: number): ViewModelData.BuildLogItemVM {
        var parameters: [string, string][];
        parameters.push(["id", id.toString()]);
        var url: string = super.GetHttpRequestUrl(BuildLogApiControllerClient.ActionName_GetBuildLogItemVM, parameters);
        return super.Get<ViewModelData.BuildLogItemVM>(url);
    }
    public static ActionName_GetWPCommonOfBuildLogVM: string = "GetWPCommonOfBuildLogVM";
    public GetWPCommonOfBuildLogVMAsync(vm: ViewModelData.WPCommonOfBuildLogVM): ViewModelData.WPCommonOfBuildLogVM {
        var url: string = super.GetHttpRequestUrl(BuildLogApiControllerClient.ActionName_GetWPCommonOfBuildLogVM, null);
        return super.Post<ViewModelData.WPCommonOfBuildLogVM, ViewModelData.WPCommonOfBuildLogVM>(url, vm);
    }
    public static ActionName_GetWPEntityRelatedOfBuildLogVM: string = "GetWPEntityRelatedOfBuildLogVM";
    public GetWPEntityRelatedOfBuildLogVMAsync(id: number): ViewModelData.WPEntityRelatedOfBuildLogVM {
        var parameters: [string, string][];
        parameters.push(["id", id.toString()]);
        var url: string = super.GetHttpRequestUrl(BuildLogApiControllerClient.ActionName_GetWPEntityRelatedOfBuildLogVM, parameters);
        return super.Get<ViewModelData.WPEntityRelatedOfBuildLogVM>(url);
    }
    //public static ActionName_HeartBeat: string = "HeartBeat";
    //public HeartBeatAsync(): HttpResponse {
    //    var url: string = super.GetHttpRequestUrl(BuildLogApiControllerClient.ActionName_HeartBeat, null);
    //    var response = Client.Get(url);
    //    return response;
    //}
}