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
@Injectable()
export class BuildlogComponent extends FrameworkViewModels.ViewModelBaseWithResultAndUIElement<CommonBLLEntities.BuildLogChainedQueryCriteriaCommon, DataSourceEntities.BuildLog.Default> implements OnInit {

  constructor(http: HttpClient) {
    super(http, 'http://localhost:63242/api/BuildLogApi/GetWPCommonOfBuildLogVM');
  }

  ngOnInit() {
    this.Criteria = new CommonBLLEntities.BuildLogChainedQueryCriteriaCommon(new FrameworkEntityContracts.QueryNumberEqualsCriteria(false, null), new FrameworkEntityContracts.QueryNumberEqualsCriteria(false, null), new FrameworkEntityContracts.QueryNumberEqualsCriteria(false, null), new FrameworkEntityContracts.QueryNumberEqualsCriteria(false, null), new FrameworkEntityContracts.QueryNumberEqualsCriteria(false, null), new FrameworkEntityContracts.QuerySystemDateTimeRangeCriteria(false, false, null, false, null), new FrameworkEntityContracts.QuerySystemStringContainsCriteria(false, null));
    this.EntityCollection = [];
    super.DoSearch(true);
  }

  public static EntityName_Static: string = "MSBuildExtensionPack.BuildLog";
  public get EntityName(): string {
    return BuildlogComponent.EntityName_Static;
  }
  public static ViewName_Static: string = "WPCommonOfBuildLogVM";
  public get ViewName(): string {
    return BuildlogComponent.ViewName_Static;
  }

  //protected DoSearch(isToClearExistingResult: boolean): void {
  //  var request = new ViewModelData.WPCommonOfBuildLogVM();
  //  request.criteria = this.Criteria;;
  //  request.queryPagingSetting = new FrameworkEntityContracts.QueryPagingSetting(1, 10);
  //  this.http.post<ViewModelData.WPCommonOfBuildLogVM>('http://localhost:63242/api/BuildLogApi/GetWPCommonOfBuildLogVM', request).subscribe(
  //    resp => {
  //      super.DoSearchCallBack(isToClearExistingResult, resp);
  //    },
  //    (err: HttpErrorResponse) => {
  //      console.log(err.message);
  //    }
  //  );
  //}

}