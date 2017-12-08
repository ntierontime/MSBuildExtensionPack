import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse, HttpErrorResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import * as Framework from './Framework';
import * as FrameworkEntityContracts from './Framework.EntityContracts';
import * as FrameworkCommonBLLEntities from './Framework.CommonBLLEntities';

export class ViewModelBase<TSearchCriteria, TSearchResult>
{
    constructor() {
        this.statusOfResult = FrameworkCommonBLLEntities.BusinessLogicLayerResponseStatus.UIProcessReady;
        this.contentData = new FrameworkEntityContracts.ContentData();
    }
    public contentData: FrameworkEntityContracts.ContentData;
    public criteria: TSearchCriteria;
    public queryPagingSetting: FrameworkEntityContracts.QueryPagingSetting;
    public queryOrderBySettingCollecionInString: string;
    public originalQueryOrderBySettingCollecionInString: string;
    public listOfQueryOrderBySettingCollecionInString: Framework.NameValuePair[];
    public listOfDataExport: Framework.NameValuePair[];
    public queryOrderBySettingCollection: FrameworkEntityContracts.QueryOrderBySetting[];
    public statusOfResult: FrameworkCommonBLLEntities.BusinessLogicLayerResponseStatus;
    public statusMessageOfResult: string;
    public result: TSearchResult;
}

export class ViewModelBaseWithResultAndUIElement<TSearchCriteria, TSearchResultEntity>
{
  protected http: HttpClient;
  protected url: string;
  constructor(http: HttpClient, url: string) {
    this.http = http;
    this.url = url;
    this.QueryPagingSetting = this.GetDefaultQueryPagingSetting();
  }
  public EntityName: string;
  public ViewName: string;
  public Criteria: TSearchCriteria;
  public SearchStatus: FrameworkEntityContracts.SearchStatus;
  public StatusOfResult: FrameworkCommonBLLEntities.BusinessLogicLayerResponseStatus;
  public StatusMessageOfResult: string;
  public EntityCollection: TSearchResultEntity[];
  public QueryPagingSetting: FrameworkEntityContracts.QueryPagingSetting;
  public ContentData: FrameworkEntityContracts.ContentData;
  public OriginalQueryOrderBySettingCollecionInString: string;
  public ListOfQueryOrderBySettingCollecionInString: Framework.NameValuePair[];
  public QueryOrderBySettingCollection: FrameworkEntityContracts.QueryOrderBySetting[];
  public ListOfDataExport: Framework.NameValuePair[];
  protected m_QueryOrderBySettingCollecionInString: string;

  public get QueryOrderBySettingCollecionInString(): string {
    if (this.m_QueryOrderBySettingCollecionInString != null && this.m_QueryOrderBySettingCollecionInString != "" && this.ListOfQueryOrderBySettingCollecionInString != null) {
      this.m_QueryOrderBySettingCollecionInString = this.ListOfQueryOrderBySettingCollecionInString[0].Value;
    }
    return this.m_QueryOrderBySettingCollecionInString;
  }
  public set QueryOrderBySettingCollecionInString(value: string) {
    if (this.m_QueryOrderBySettingCollecionInString != value) {
      this.m_QueryOrderBySettingCollecionInString = value;
      if (this.m_QueryOrderBySettingCollecionInString != null && this.m_QueryOrderBySettingCollecionInString != "") {
        this.QueryOrderBySettingCollection = []; // TODO: new FrameworkEntityContracts.QueryOrderBySetting[](this.m_QueryOrderBySettingCollecionInString)
      }
    }
  }

  public GetDefaultQueryPagingSetting(): FrameworkEntityContracts.QueryPagingSetting {

    var queryPagingSetting: FrameworkEntityContracts.QueryPagingSetting = new FrameworkEntityContracts.QueryPagingSetting(-1, -1);
    if (queryPagingSetting.CountOfPages == 0 || queryPagingSetting.CountOfRecords == 0) {
      queryPagingSetting.CurrentPage = 0;
    }
    return queryPagingSetting;
  }
  protected GetQueryPagingSettingFromQueryPagingResult(queryPagingResult: FrameworkEntityContracts.QueryPagingResult): FrameworkEntityContracts.QueryPagingSetting {
    var queryPagingSetting: FrameworkEntityContracts.QueryPagingSetting = new FrameworkEntityContracts.QueryPagingSetting(-1, -1);
    queryPagingSetting.CountOfRecords = queryPagingResult.CountOfRecords;
    queryPagingSetting.PageSize = queryPagingResult.PageSize;
    queryPagingSetting.CurrentPage = queryPagingResult.CurrentIndexOfStartRecord / queryPagingResult.PageSize + 1;
    queryPagingSetting.RecordCountOfCurrentPage = queryPagingResult.RecordCountOfCurrentPage;
    return queryPagingSetting;
  }

  public GetDefaultListOfQueryOrderBySettingCollecionInString(): Framework.NameValuePair[] {
    return null;
  }
  public GetPrimaryInformationEntity(): ViewModelBase<TSearchCriteria, TSearchResultEntity[]> {
    var vm: ViewModelBase<TSearchCriteria, TSearchResultEntity[]>;
    vm = new ViewModelBase<TSearchCriteria, TSearchResultEntity[]>();
    vm.criteria = this.Criteria;
    vm.listOfQueryOrderBySettingCollecionInString = this.ListOfQueryOrderBySettingCollecionInString;
    vm.queryOrderBySettingCollecionInString = this.QueryOrderBySettingCollecionInString;
    vm.originalQueryOrderBySettingCollecionInString = this.OriginalQueryOrderBySettingCollecionInString;
    vm.queryPagingSetting = this.QueryPagingSetting;
    return vm;
  }

  protected Search(): void {
    if (this.QueryPagingSetting != null && this.QueryPagingSetting.CurrentPage == 0) {
      this.QueryPagingSetting.CurrentPage = 1;
    }
    this.DoSearch(true);
  }

  protected CanSearch(): boolean {
    return true;
  }

  protected LoadMore(): void {
    if (this.QueryPagingSetting.CurrentPage == 0) {
      this.QueryPagingSetting.CurrentPage = 1;
      this.DoSearch(false);
    }
    else {
      this.QueryPagingSetting.CurrentPage += 1;
      this.DoSearch(false);
    }
  }

  protected CanLoadMore(): boolean {
    return true;
  }

  protected DoSearch(isToClearExistingResult: boolean): void {
    let request = this.GetPrimaryInformationEntity();
    this.http.post<ViewModelBase<TSearchCriteria, TSearchResultEntity[]>>(this.url, request).subscribe(
      resp => {
        this.DoSearchCallBack(isToClearExistingResult, resp);
      },
      (err: HttpErrorResponse) => {
        console.log(err.message);
      }
    );
  }

  public DoSearchCallBack(isToClearExistingResult: boolean, response: ViewModelBase<TSearchCriteria, TSearchResultEntity[]>): void {
    if (isToClearExistingResult || this.EntityCollection === undefined || this.EntityCollection === null)
      this.EntityCollection = [];
    this.EntityCollection = this.EntityCollection.concat(response.result);
    this.StatusMessageOfResult = response.statusMessageOfResult;
    this.StatusOfResult = response.statusOfResult;
    this.QueryPagingSetting = response.queryPagingSetting;
    this.SearchStatus = FrameworkEntityContracts.SearchStatus.SearchResultLoaded;
  }

  public Cleanup(): void {
  }
}

export class ViewModelEntityRelatedBase<TMasterEntity, TCriteriaOfMasterEntity>
{
    constructor(criteriaOfMasterEntity: TCriteriaOfMasterEntity) {
        this.CriteriaOfMasterEntity = criteriaOfMasterEntity;
        this.QueryPagingSetting = new FrameworkEntityContracts.QueryPagingSetting(1, 10);
        this.QueryPagingSettingOneRecord = new FrameworkEntityContracts.QueryPagingSetting(1, 1);
    }
    public MasterEntity: TMasterEntity;
    public CriteriaOfMasterEntity: TCriteriaOfMasterEntity;
    public StatusOfMasterEntity: FrameworkCommonBLLEntities.BusinessLogicLayerResponseStatus;
    public StatusMessageOfMasterEntity: string;
    public QueryPagingSetting: FrameworkEntityContracts.QueryPagingSetting;
    public QueryPagingSettingOneRecord: FrameworkEntityContracts.QueryPagingSetting;
}

export class ViewModelItemBase<TSearchCriteria, TItem>
{
    public static ViewName_Edit: string = "Edit";
    public static ViewName_Create: string = "Create";
    public static ViewName_Delete: string = "Delete";
    public static ViewName_Details: string = "Details";
    constructor() {
        this.SearchStatus = FrameworkEntityContracts.SearchStatus.Unknown;
        this.ContentData = new FrameworkEntityContracts.ContentData();
        this.StatusOfResult = FrameworkCommonBLLEntities.BusinessLogicLayerResponseStatus.UIProcessReady;
        //this.UIActionStatusMessage = new Framework.UIActionStatusMessage();
    }
    public ContentData: FrameworkEntityContracts.ContentData;
    public Criteria: TSearchCriteria;
    public Item: TItem;
    public SearchStatus: FrameworkEntityContracts.SearchStatus;
    public StatusOfResult: FrameworkCommonBLLEntities.BusinessLogicLayerResponseStatus;
    public StatusMessageOfResult: string;
    public UIActionStatusMessage: Framework.UIActionStatusMessage;
}

export class UISharedViewModel {
    public SelectListOfPageSize: Framework.NameValuePair[];
    public SelectListOfQueryOrderBySettingCollecionInString: Framework.NameValuePair[];
    public SelectListOfDataExport: Framework.NameValuePair[];
    public PreDefinedDateTimeRangeList: Framework.NameValuePair[];
    public PredefinedBooleanSelectionList: Framework.NameValuePair[];
}