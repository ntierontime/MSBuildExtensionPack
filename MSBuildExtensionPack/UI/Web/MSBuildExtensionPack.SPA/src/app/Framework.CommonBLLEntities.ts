import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import * as Framework from './Framework';
import * as FrameworkEntityContracts from './Framework.EntityContracts';

export enum BusinessLogicLayerRequestTypes {
    Create,
    Update,
    Delete,
    Replace,
    Copy,
    Search
}
export enum BusinessLogicLayerResponseStatus {
    Received,
    Pending,
    BeingProcessed,
    Rejected,
    Accepted,
    Succeeded,
    OnHold,
    Failed,
    UIProcessReady,
    RequestError,
    MessageOK,
    NoValueFromDataSource,
    MessageErrorDetected,
    YouHaveNoPermissionToView,
    YouHaveNoPermissionToInsert,
    YouHaveNoPermissionToUpdate,
    YouHaveNoPermissionToDelete
}

export class BusinessLogicLayerRequestMessageBase<TQueryCriteria>
{
    constructor(businessLogicLayerRequestTypes: BusinessLogicLayerRequestTypes, businessLogicLayerRequestTypeKey: string, businessLogicLayerRequestID: string, currentIndex: number, pageSize: number, queryOrderByExpression: string) {
        this.BusinessLogicLayerRequestID = businessLogicLayerRequestID;
        this.BusinessLogicLayerRequestTypeKey = businessLogicLayerRequestTypeKey;
        this.BusinessLogicLayerRequestTypes = businessLogicLayerRequestTypes;
        this.QueryPagingSetting = new FrameworkEntityContracts.QueryPagingSetting(currentIndex, pageSize);
        //this.QueryOrderBySettingCollection = new FrameworkEntityContracts.QueryOrderBySettingCollection(queryOrderByExpression);
    }
    public BusinessLogicLayerRequestTypes: BusinessLogicLayerRequestTypes;
    public BusinessLogicLayerRequestTypeKey: string;
    public BusinessLogicLayerRequestID: string;
    public Critieria: TQueryCriteria;
    public QueryOrderBySettingCollection: FrameworkEntityContracts.QueryOrderBySetting[];
    public QueryPagingSetting: FrameworkEntityContracts.QueryPagingSetting;
    public StatusChange_DatePeriodId_Later: number;
    public StatusChange_DatePeriodId_Ealier: number;
    public StatusChange_TimePeriodId_Later: number;
    public StatusChange_timePeriodId_Ealier: number;
    public DataServiceType: Framework.DataServiceTypes;
    //public ToString(): string {
    //    return string.Format("ID:{4};Key:{5};RequestType:{0};Type:{1};Paging:{2};Order:{3}", this.BusinessLogicLayerRequestTypes,/*typeof*/TQueryCriteria, this.QueryPagingSetting != null ? this.QueryPagingSetting.ToString() : "", this.QueryOrderBySettingCollection != null ? this.QueryOrderBySettingCollection.GetOrderByExpression() : "", this.BusinessLogicLayerRequestID, this.BusinessLogicLayerRequestTypeKey);
}

export class BusinessLogicLayerResponseMessageBase<TResponse> {
    constructor() {
    }
    public BusinessLogicLayerResponseStatus: BusinessLogicLayerResponseStatus;
    public QueryPagingResult: FrameworkEntityContracts.QueryPagingResult;
    public ServerErrorMessage: string;
    public BusinessLogicLayerRequestID: string;
    public BusinessLogicLayerResponseID: string;
    public Message: TResponse;
    public DataStreamServiceResult: Framework.DataStreamServiceResult;
    //public GetStatusMessage(): string {
    //    return Framework.Resx.UIStringResource.ResourceManager.GetString(this.BusinessLogicLayerResponseStatus.ToString());
    //}
    //public ToString(): string {
    //    return string.Format("ResponseStatus:{0};PagingResult:{1}", this.BusinessLogicLayerResponseStatus, this.QueryPagingResult != null ? this.QueryPagingResult.ToString() : "", this.BusinessLogicLayerRequestID, this.BusinessLogicLayerResponseID,/*typeof*/TResponse);
    //}
}
export class BusinessLogicLayerResponseMessageNameValuePairCollection extends BusinessLogicLayerResponseMessageBase<Framework.NameValuePair[]>
{

}
export class BusinessLogicLayerResponseMessageRssItemCollection extends BusinessLogicLayerResponseMessageBase<Framework.RssItem[]>
{

}
export class BusinessLogicLayerResponseMessageInteger extends BusinessLogicLayerResponseMessageBase<number>
{

}
export class BusinessLogicLayerResponseMessageBoolean extends BusinessLogicLayerResponseMessageBase<boolean>
{

}