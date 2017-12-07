import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
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
        this.StatusOfResult = FrameworkCommonBLLEntities.BusinessLogicLayerResponseStatus.UIProcessReady;
        this.ContentData = new FrameworkEntityContracts.ContentData();
    }
    public ContentData: FrameworkEntityContracts.ContentData;
    public Criteria: TSearchCriteria;
    public QueryPagingSetting: FrameworkEntityContracts.QueryPagingSetting;
    public QueryOrderBySettingCollecionInString: string;
    public OriginalQueryOrderBySettingCollecionInString: string;
    public ListOfQueryOrderBySettingCollecionInString: Framework.NameValuePair[];
    public ListOfDataExport: Framework.NameValuePair[];
    public QueryOrderBySettingCollection: FrameworkEntityContracts.QueryOrderBySetting[];
    public StatusOfResult: FrameworkCommonBLLEntities.BusinessLogicLayerResponseStatus;
    public StatusMessageOfResult: string;
    public Result: TSearchResult;

    public GetPrimaryInformationEntity(): ViewModelBase<TSearchCriteria, TSearchResult> {
        var vm: ViewModelBase<TSearchCriteria, TSearchResult>;
        vm = new ViewModelBase<TSearchCriteria, TSearchResult>();
        vm.Criteria = this.Criteria;
        vm.ListOfQueryOrderBySettingCollecionInString = this.ListOfQueryOrderBySettingCollecionInString;
        vm.QueryOrderBySettingCollecionInString = this.QueryOrderBySettingCollecionInString;
        vm.OriginalQueryOrderBySettingCollecionInString = this.OriginalQueryOrderBySettingCollecionInString;
        vm.QueryPagingSetting = this.QueryPagingSetting;
        return vm;
    }
    public PopulateAllUIElements(vmFromTempData: ViewModelBase<TSearchCriteria, TSearchResult>, currentPage: number): void {
        if (this.Criteria == null) {
            if (vmFromTempData != null && vmFromTempData.Criteria != null) {
                this.Criteria = vmFromTempData.Criteria;
            }
            else {
                //this.Criteria = new TSearchCriteria();
            }
        }
        if (this.ListOfQueryOrderBySettingCollecionInString == null) {
            if (vmFromTempData != null && vmFromTempData.ListOfQueryOrderBySettingCollecionInString != null) {
                this.ListOfQueryOrderBySettingCollecionInString = vmFromTempData.ListOfQueryOrderBySettingCollecionInString;
            }
            else {
                this.ListOfQueryOrderBySettingCollecionInString = this.GetDefaultListOfQueryOrderBySettingCollecionInString();
            }
        }
        if (this.QueryPagingSetting == null) {
            if (vmFromTempData != null && vmFromTempData.QueryPagingSetting != null) {
                this.QueryPagingSetting = vmFromTempData.QueryPagingSetting;
                this.QueryPagingSetting.CurrentPage = currentPage;
            }
            else {
                this.QueryPagingSetting = this.GetDefaultQueryPagingSetting();
            }
        }
        else {
            if (this.QueryPagingSetting.PageSizeChanged) {
                this.QueryPagingSetting.CurrentPage = 1;
                this.QueryPagingSetting.OriginalPageSize = this.QueryPagingSetting.PageSize;
            }
            else if (this.OriginalQueryOrderBySettingCollecionInString != this.QueryOrderBySettingCollecionInString) {
                this.OriginalQueryOrderBySettingCollecionInString = this.QueryOrderBySettingCollecionInString;
                this.QueryPagingSetting.CurrentPage = 1;
            }
            else {
                this.QueryPagingSetting.CurrentPage = 1;
            }
        }
        if (this.QueryOrderBySettingCollecionInString != null && this.QueryOrderBySettingCollecionInString != '') {
            if (vmFromTempData != null && vmFromTempData.QueryOrderBySettingCollecionInString != null && vmFromTempData.QueryOrderBySettingCollecionInString != '') {
                this.QueryOrderBySettingCollecionInString = vmFromTempData.QueryOrderBySettingCollecionInString;
            }
        }
        //if (!string.IsNullOrWhiteSpace(this.QueryOrderBySettingCollecionInString)) {
        //    this.QueryOrderBySettingCollection = new FrameworkEntityContracts.QueryOrderBySettingCollection(this.QueryOrderBySettingCollecionInString);
        //}
        this.GetDefaultPerViewModel();
        if (this.ListOfDataExport == null) {
            if (vmFromTempData != null && vmFromTempData.ListOfDataExport != null) {
                this.ListOfDataExport = vmFromTempData.ListOfDataExport;
            }
            else {
                this.ListOfDataExport = [];
                let temp: Framework.NameValuePair;
                temp = new Framework.NameValuePair("Csv", "Csv");
                this.ListOfDataExport.push(temp);
                temp = new Framework.NameValuePair("Excel2010", "Excel2010");
                this.ListOfDataExport.push(temp);
            }
        }
    }
    public GetDefaultListOfQueryOrderBySettingCollecionInString(): Framework.NameValuePair[] {
        return null;
    }
    public GetDefaultQueryPagingSetting(): FrameworkEntityContracts.QueryPagingSetting {
        var queryPagingSetting: FrameworkEntityContracts.QueryPagingSetting = new FrameworkEntityContracts.QueryPagingSetting(-1, -1);
        return queryPagingSetting;
    }
    public GetDefaultPerViewModel(): void {

    }
}

export class ViewModelBaseWithResultAndUIElement<TSearchCriteria, TSearchResultEntity>
{
  constructor() {
    //this.Criteria = new TSearchCriteria();
    //PopulateAllUIElements(this, 1);
  }
  public EntityName: string;
  public ViewName: string;
  public EntityCollection: TSearchResultEntity;
  public SearchStatus: FrameworkEntityContracts.SearchStatus;
  public QueryPagingSetting: FrameworkEntityContracts.QueryPagingSetting;
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
  public OriginalQueryOrderBySettingCollecionInString: string;
  public ListOfQueryOrderBySettingCollecionInString: Framework.NameValuePair[];
  public QueryOrderBySettingCollection: FrameworkEntityContracts.QueryOrderBySetting[];
  public GetDefaultListOfQueryOrderBySettingCollecionInString(): Framework.NameValuePair[] {
    return null;
  }
  public ListOfDataExport: Framework.NameValuePair[];
  public GetPrimaryInformationEntity(): ViewModelBase<TSearchCriteria, TSearchResultEntity> {
    var vm: ViewModelBase<TSearchCriteria, TSearchResultEntity>;
    vm = new ViewModelBase<TSearchCriteria, TSearchResultEntity>();
    vm.Criteria = this.Criteria;
    vm.ListOfQueryOrderBySettingCollecionInString = this.ListOfQueryOrderBySettingCollecionInString;
    vm.QueryOrderBySettingCollecionInString = this.QueryOrderBySettingCollecionInString;
    vm.OriginalQueryOrderBySettingCollecionInString = this.OriginalQueryOrderBySettingCollecionInString;
    vm.QueryPagingSetting = this.QueryPagingSetting;
    return vm;
  }

  public GetDefaultPerViewModel(): void {

  }
  public Criteria: TSearchCriteria;
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
  protected DoSearch(isToClearExistingResult: boolean): void { throw new Error('not implemented'); }
  public ContentData: FrameworkEntityContracts.ContentData;
  public Cleanup(): void {
  }
  public StatusOfResult: FrameworkCommonBLLEntities.BusinessLogicLayerResponseStatus;
  public StatusMessageOfResult: string;
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