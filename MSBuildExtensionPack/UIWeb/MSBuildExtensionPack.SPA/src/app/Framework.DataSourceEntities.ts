import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import * as Framework from './Framework';
import * as FrameworkEntityContracts from './Framework.EntityContracts';

    export class DataAccessLayerMessageBase<T>
    {
        public DataAccessLayerMessageStatus: DataAccessLayerMessageStatus;
        public Result: T;
        public QueryPagingResult: FrameworkEntityContracts.QueryPagingResult;
        public OriginalValue: T;
        public MessageSourceComponent: string;
        public MessageSourceFunction: string;
        public Message: string;
    }
    export class DataAccessLayerMessageOfInteger extends DataAccessLayerMessageBase<number>
    {

    }
    export class DataAccessLayerMessageOfBoolean extends DataAccessLayerMessageBase<boolean>
    {

    }
    export class DataAccessLayerMessageOfNameValuePairEntityCollection extends DataAccessLayerMessageBase<Framework.NameValuePair[]>
    {

    }
    export class DataAccessLayerMessageOfNameValuePairEntity extends DataAccessLayerMessageBase<Framework.NameValuePair>
    {

    }
    export class DataAccessLayerMessageOfRssItemCollection extends DataAccessLayerMessageBase<Framework.RssItem[]>
    {

    }
    export class DataAccessLayerMessageRssItem extends DataAccessLayerMessageBase<Framework.RssItem>
    {

    }
    export enum DataAccessLayerMessageStatus {
        Success,
        Fail,
        SuccessButNoResult
    }



