import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import * as Framework from './Framework';
import * as FrameworkEntityContracts from './Framework.EntityContracts';

export class ApiControllerHttpClientBase {
    public static WebApiRootUrlAppSettingName: string = "WebApiRootUrl";
    RootPath: string;
    public ControllerName: string;
    protected static Client: HttpClient;// = new HttpClient(); need initialization
    constructor(rootPath: string) {
        this.RootPath = rootPath;
    }

    public static GetHttpRequestUrl(rootPath: string, controllerName: string, actionName: string, parameters: string): string {
        var retval: string = rootPath;
        if (controllerName != null && controllerName != '') {
            retval = retval + '/' + controllerName.trim();
        }
        if (actionName != null && actionName != '') {
            retval = retval + '/' + actionName.trim();
        }
        if (parameters != null && parameters != '') {
            retval = retval + '?' + parameters.trim();
        }
        return retval;
    }

    public GetHttpRequestUrl(actionName: string, parameters: [string, string][]): string {
        var parametersInList: string[] = [];
        parameters.forEach(function (kvPair) {
            parametersInList.push(kvPair[0] + '=' + kvPair[1]);
        });
        var parametersInString: string = parametersInList.join("&");
        return ApiControllerHttpClientBase.GetHttpRequestUrl(this.RootPath, this.ControllerName, actionName, parametersInString);
    }
}