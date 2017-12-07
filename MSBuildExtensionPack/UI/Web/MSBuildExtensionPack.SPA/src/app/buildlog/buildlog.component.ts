import { Component, OnInit } from '@angular/core';
import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse, HttpErrorResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';

import * as Framework from '../Framework';
import * as FrameworkCommonBLLEntities from '../Framework.CommonBLLEntities';
import * as FrameworkEntityContracts from '../Framework.EntityContracts';
import * as FrameworkViewModels from '../Framework.ViewModels';
import * as DataSourceEntities from '../DataSourceEntities/BuildLog';
import * as CommonBLLEntities from '../CommonBLLEntities/BuildLog';
import * as ViewModelData from '../ViewModelData/BuildLog';

@Component({
  selector: 'cm-buildlog',
  templateUrl: './buildlog.component.html',
  styleUrls: ['./buildlog.component.css']
})
export class BuildlogComponent extends FrameworkViewModels.ViewModelBaseWithResultAndUIElement<CommonBLLEntities.BuildLogChainedQueryCriteriaCommon, DataSourceEntities.BuildLog.Default[]> implements OnInit {

  constructor(private http: HttpClient) {
    super();
    //this.WebApiClient = new WebApi.BuildLogApiControllerClient("localhost:63242");
  }

  ngOnInit() {
    this.Criteria = new CommonBLLEntities.BuildLogChainedQueryCriteriaCommon(new FrameworkEntityContracts.QueryNumberEqualsCriteria(false, null), new FrameworkEntityContracts.QueryNumberEqualsCriteria(false, null), new FrameworkEntityContracts.QueryNumberEqualsCriteria(false, null), new FrameworkEntityContracts.QueryNumberEqualsCriteria(false, null), new FrameworkEntityContracts.QueryNumberEqualsCriteria(false, null), new FrameworkEntityContracts.QuerySystemDateTimeRangeCriteria(false, false, null, false, null), new FrameworkEntityContracts.QuerySystemStringContainsCriteria(false, null));
    this.DoSearch(true);
  }

  public static EntityName_Static: string = "MSBuildExtensionPack.BuildLog";
  public get EntityName(): string {
    return BuildlogComponent.EntityName_Static;
  }
  public static ViewName_Static: string = "WPCommonOfBuildLogVM";
  public get ViewName(): string {
    return BuildlogComponent.ViewName_Static;
  }

  protected DoSearch(isToClearExistingResult: boolean): void {
    try {
      let request = new ViewModelData.WPCommonOfBuildLogVM();
      request.Criteria = this.Criteria;
      //private http: HttpClient
      //this.http.post<ViewModelData.WPCommonOfBuildLogVM>('/api/buildlog/WPCommonOfBuildLogVM', request).subscribe(data => {
      //  // Read the result field from the JSON response.
      //  this.EntityCollection = data.Result;
      //});
      //let response = this.WebApiClient.GetWPCommonOfBuildLogVMAsync(request);
      //this.EntityCollection = response.Result;
    }
    catch (e) {
      console.log(e);
    }
  }

    hero = 'Windstorm';
}
