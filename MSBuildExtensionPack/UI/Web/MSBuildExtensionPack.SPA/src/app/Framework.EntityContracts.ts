import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import { NameValuePair } from './Framework';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
export namespace Framework.EntityContracts {
    export enum KnownMathCalculations {
        Sum,
        Count,
        Average,
        Max,
        Min,
        Product,
        CountNumber,
        StdDev,
        StdDevp,
        Var,
        Varp
    }

    export class AlphabeticalOrderCategory {
        constructor(id: number, name: string) {
            this.ID = id;
            this.Name = name;
        }
        public ID: number;
        public Name: string;
    }

    // Queries
    export enum DateTimeUnit {
        Tick,
        Year,
        QuarterOfYear,
        Month,
        SemiMonth,
        BiWeek,
        Week,
        Day,
        Hour,
        Minute,
        Second,
        MilliSecond,
        Negate,
        None
    }

    export enum PredefinedBooleanSelectedValues {
        All,
        True,
        False
    }

    export enum PreDefinedDateTimeRanges {
        Unknown,
        Custom,
        LastTenYears,
        LastFiveYears,
        LastYear,
        LastSixMonths,
        LastThreeMonths,
        LastMonth,
        LastWeek,
        Yesterday,
        ThisYear,
        ThisMonth,
        ThisWeek,
        Today,
        Tomorrow,
        NextWeek,
        NextMonth,
        NextThreeMonths,
        NextSixMonths,
        NextYear,
        NextFiveYears,
        NextTenYears
    }

    export class QueryOrderBySetting {
        constructor(propertyName: string, direction: string) {
            this.PropertyName = propertyName;
            this.Direction = direction;
        }
        public PropertyName: string;
        public Direction: string;
    }

    export class QueryPagingResult {
        constructor() {

        }
        public CountOfRecords: number;
        public RecordCountOfCurrentPage: number;
        public CurrentIndexOfStartRecord: number;
        public PageSize: number;
        public Clone(): QueryPagingResult {
            var result = new QueryPagingResult();
            result.CountOfRecords = this.CountOfRecords;
            result.CurrentIndexOfStartRecord = this.CurrentIndexOfStartRecord;
            result.PageSize = this.PageSize;
            result.RecordCountOfCurrentPage = this.RecordCountOfCurrentPage;
            return result;
        }
    }

    export class QueryPagingSetting{
        constructor(currentPage: number, pageSize: number) {
            this.CurrentPage = currentPage;
            this.PageSize = this.OriginalPageSize = pageSize;
            //this.PageSizeSelectionList = new Framework.NameValueCollection();
            //this.PageSizeSelectionList.Add("10", "10");
            //this.PageSizeSelectionList.Add("20", "20");
            //this.PageSizeSelectionList.Add("50", "50");
            //this.PageSizeSelectionList.Add("100", "100");
        }
        public get IsEmptyResult(): boolean {
            return this.CountOfRecords == 0;
        }
        public get IsOnlyOnePage(): boolean {
            return this.CountOfPages == 1;
        }
        public get CanChangeCurrentPage(): boolean {
            return !(this.IsEmptyResult || this.IsOnlyOnePage);
        }
        public get IsMoreThanOnePage(): boolean {
            return this.CountOfPages > 1;
        }
        public get IsCurrentPageIsFirstPage(): boolean {
            return this.CurrentPage == 1;
        }
        public get IsCurrentPageIsLastPage(): boolean {
            return this.CurrentPage == this.CountOfPages;
        }
        m_CurrentPage: number;
        public get CurrentPage(): number {
            return this.m_CurrentPage;
        }
        public set CurrentPage(value: number) {
            if (this.m_CurrentPage != value) {
                this.m_CurrentPage = value;
                //RaisePropertyChanged("CurrentPage");
                //RaisePropertyChanged("IsEmptyResult");
                //RaisePropertyChanged("IsOnlyOnePage");
                //RaisePropertyChanged("CanChangeCurrentPage");
                //RaisePropertyChanged("IsMoreThanOnePage");
                //RaisePropertyChanged("IsCurrentPageIsFirstPage");
                //RaisePropertyChanged("IsCurrentPageIsLastPage");
                //RaisePropertyChanged("CurrentIndex");
                //RaisePropertyChanged("EndIndex");
                //RaisePropertyChanged("PageSizeChanged");
                //RaisePropertyChanged("CountOfPages");
                //RaisePropertyChanged("RecordCountOfCurrentPage");
                //RaisePropertyChanged("CanGoForeward");
                //RaisePropertyChanged("CanGoBackward");
            }
        }
        public get CurrentIndex(): number {
            return (this.CurrentPage - 1) * this.PageSize;
        }
        public get EndIndex(): number {
            return (this.CurrentPage - 1) * this.PageSize + this.RecordCountOfCurrentPage;
        }
        m_PageSize: number;
        public get PageSize(): number {
            return this.m_PageSize;
        }
        public set PageSize(value: number) {
            if (this.m_PageSize != value) {
                this.m_PageSize = value;
                //RaisePropertyChanged("PageSize");
            }
        }
        m_OriginalPageSize: number;
        public get OriginalPageSize(): number {
            return this.m_OriginalPageSize;
        }
        public set OriginalPageSize(value: number) {
            if (this.m_OriginalPageSize != value) {
                this.m_OriginalPageSize = value;
                //RaisePropertyChanged("OriginalPageSize");
            }
        }
        public get PageSizeChanged(): boolean {
            return this.PageSize != this.OriginalPageSize;
        }
        m_CountOfRecords: number;
        public get CountOfRecords(): number {
            return this.m_CountOfRecords;
        }
        public set CountOfRecords(value: number) {
            if (this.m_CountOfRecords != value) {
                this.m_CountOfRecords = value;
                //RaisePropertyChanged("CountOfRecords");
            }
        }
        public get CountOfPages(): number {
            return <number>Math.ceil(this.CountOfRecords * 1.0 / this.PageSize);
        }
        public RecordCountOfCurrentPage: number;
        public PageSizeSelectionList: NameValuePair[] = [];
        public PageNumberSelectionList: NameValuePair[] = [];
        //public GetPagingInformationString(): string {
        //    if (this.RecordCountOfCurrentPage == 0) {
        //        return string.Format(Framework.Resx.UIStringResource.Pagination_NoData);
        //    }
        //    else {
        //        return string.Format(Framework.Resx.UIStringResource.Pagination_PagingInformation, this.RecordCountOfCurrentPage, this.CurrentIndex + 1, this.EndIndex, this.CountOfRecords, this.CountOfPages, this.CurrentPage);
        //    }
        //}
        public get CanGoForeward(): boolean {
            return this.CountOfPages > 0 && !this.IsCurrentPageIsLastPage;
        }
        public get CanGoBackward(): boolean {
            return this.CountOfPages > 0 && !this.IsCurrentPageIsFirstPage;
        }
        //public ToString(): string {
        //    return this.GetPagingInformationString();
        //}
        public static GetDefault(): QueryPagingSetting {
            return new QueryPagingSetting(1, 10);
        }
    }

    //ViewModels
    export class ContentData {
        public Title: string;
        public Summary: string;
        public Description: string;
    }


    export enum SearchStatus {
        Unknown,
        Searching,
        SearchResultLoaded
    }
}
