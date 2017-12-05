import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse, HttpErrorResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import * as Framework from './Framework';
import * as FrameworkEntityContracts from './Framework.EntityContracts';
import * as FrameworkViewModels from './Framework.ViewModels';
//we may need angular client
// https://codingthesmartway.com/angular-4-3-httpclient-accessing-rest-web-services-with-angular/
// $ npm install -g @angular/cli@latest
// ??$ ng new nghttp01

@Injectable()
export class ApiControllerHttpClientBase {
    public static WebApiRootUrlAppSettingName: string = "WebApiRootUrl";
    public RootPath: string;
    public ControllerName: string;
    public Client: HttpClient;// = new HttpClient(); need initialization
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
    //public GetHttpRequestUrl(actionName: string): string {
    //    return ApiControllerHttpClientBase.GetHttpRequestUrl(this.RootPath, this.ControllerName, actionName, null);
    //}
    // https://blog.mariusschulz.com/2016/12/09/typescript-2-1-async-await-for-es3-es5
    // https://medium.com/@bluepnume/learn-about-promises-before-you-start-using-async-await-eb148164a9c8
    // this is not an async method
    public Get<TResponse>(url: string): TResponse {
        this.Client.get<TResponse>(url).subscribe(
            data => {
                console.log(data);
                return data;
            },
            err => {
                console.log('error when in ' + url);
                return null;
            });
        return null;
    }

    //public GetItemViewModel<TViewMode>(url: string): TViewMode {
    //    this.Client.get<TViewMode>(url).subscribe(
    //        data => {
    //            console.log(data);
    //            return data;
    //        },
    //        err => {
    //            console.log('error when in ' + url);
    //            return null;
    //        });
    //    return null;
    //}

    public GetEntityRelated<TViewModel>(url: string): TViewModel {
        this.Client.get<TViewModel>(url).subscribe(
            data => {
                console.log(data);
                return data;
            },
            err => {
                console.log('error when in ' + url);
                return null;
            });
        return null;
    }

    public Post<TRequest, TResponse>(url: string, vm: TRequest): TResponse {
        this.Client.post<TResponse>(url, vm).subscribe(
            res => {
                console.log(res);
                return res;
            },
            (err: HttpErrorResponse) => {
                console.log(err.error);
                console.log(err.name);
                console.log(err.message);
                console.log(err.status);
                return null;
            });
        return null;
    }

    public Put<TRequest, TResponse>(url: string, request: TRequest): TResponse {
        this.Client.put<TResponse>(url, request).subscribe(
            res => {
                console.log(res);
                return res;
            },
            (err: HttpErrorResponse) => {
                console.log(err.error);
                console.log(err.name);
                console.log(err.message);
                console.log(err.status);
                return null;
            });
        return null;
    }
    public Delete<TResponse>(url: string): TResponse {
        this.Client.delete<TResponse>(url).subscribe(
            res => {
                console.log(res);
                return res;
            },
            (err: HttpErrorResponse) => {
                console.log(err.error);
                console.log(err.name);
                console.log(err.message);
                console.log(err.status);
                return null;
            });
        return null;
    }
}