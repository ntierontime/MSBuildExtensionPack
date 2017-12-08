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

    public GetPrimaryInformationEntity(): ViewModelBase<TSearchCriteria, TSearchResult> {
        var vm: ViewModelBase<TSearchCriteria, TSearchResult>;
        vm = new ViewModelBase<TSearchCriteria, TSearchResult>();
        vm.criteria = this.criteria;
        vm.listOfQueryOrderBySettingCollecionInString = this.listOfQueryOrderBySettingCollecionInString;
        vm.queryOrderBySettingCollecionInString = this.queryOrderBySettingCollecionInString;
        vm.originalQueryOrderBySettingCollecionInString = this.originalQueryOrderBySettingCollecionInString;
        vm.queryPagingSetting = this.queryPagingSetting;
        return vm;
    }
    public PopulateAllUIElements(vmFromTempData: ViewModelBase<TSearchCriteria, TSearchResult>, currentPage: number): void {
        if (this.criteria == null) {
            if (vmFromTempData != null && vmFromTempData.criteria != null) {
                this.criteria = vmFromTempData.criteria;
            }
            else {
                //this.Criteria = new TSearchCriteria();
            }
        }
        if (this.listOfQueryOrderBySettingCollecionInString == null) {
            if (vmFromTempData != null && vmFromTempData.listOfQueryOrderBySettingCollecionInString != null) {
                this.listOfQueryOrderBySettingCollecionInString = vmFromTempData.listOfQueryOrderBySettingCollecionInString;
            }
            else {
                this.listOfQueryOrderBySettingCollecionInString = this.GetDefaultListOfQueryOrderBySettingCollecionInString();
            }
        }
        if (this.queryPagingSetting == null) {
            if (vmFromTempData != null && vmFromTempData.queryPagingSetting != null) {
                this.queryPagingSetting = vmFromTempData.queryPagingSetting;
                this.queryPagingSetting.CurrentPage = currentPage;
            }
            else {
                this.queryPagingSetting = this.GetDefaultQueryPagingSetting();
            }
        }
        else {
            if (this.queryPagingSetting.PageSizeChanged) {
                this.queryPagingSetting.CurrentPage = 1;
                this.queryPagingSetting.OriginalPageSize = this.queryPagingSetting.PageSize;
            }
            else if (this.originalQueryOrderBySettingCollecionInString != this.queryOrderBySettingCollecionInString) {
                this.originalQueryOrderBySettingCollecionInString = this.queryOrderBySettingCollecionInString;
                this.queryPagingSetting.CurrentPage = 1;
            }
            else {
                this.queryPagingSetting.CurrentPage = 1;
            }
        }
        if (this.queryOrderBySettingCollecionInString != null && this.queryOrderBySettingCollecionInString != '') {
            if (vmFromTempData != null && vmFromTempData.queryOrderBySettingCollecionInString != null && vmFromTempData.queryOrderBySettingCollecionInString != '') {
                this.queryOrderBySettingCollecionInString = vmFromTempData.queryOrderBySettingCollecionInString;
            }
        }
        //if (!string.IsNullOrWhiteSpace(this.QueryOrderBySettingCollecionInString)) {
        //    this.QueryOrderBySettingCollection = new FrameworkEntityContracts.QueryOrderBySettingCollection(this.QueryOrderBySettingCollecionInString);
        //}
        this.GetDefaultPerViewModel();
        if (this.listOfDataExport == null) {
            if (vmFromTempData != null && vmFromTempData.listOfDataExport != null) {
                this.listOfDataExport = vmFromTempData.listOfDataExport;
            }
            else {
                this.listOfDataExport = [];
                let temp: Framework.NameValuePair;
                temp = new Framework.NameValuePair("Csv", "Csv");
                this.listOfDataExport.push(temp);
                temp = new Framework.NameValuePair("Excel2010", "Excel2010");
                this.listOfDataExport.push(temp);
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
    vm.criteria = this.Criteria;
    vm.listOfQueryOrderBySettingCollecionInString = this.ListOfQueryOrderBySettingCollecionInString;
    vm.queryOrderBySettingCollecionInString = this.QueryOrderBySettingCollecionInString;
    vm.originalQueryOrderBySettingCollecionInString = this.OriginalQueryOrderBySettingCollecionInString;
    vm.queryPagingSetting = this.QueryPagingSetting;
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