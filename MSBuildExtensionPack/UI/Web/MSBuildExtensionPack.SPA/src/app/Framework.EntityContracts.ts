import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import * as Framework from './Framework';
import * as Moment from "moment";
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';

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
        public PageSizeSelectionList: Framework.NameValuePair[] = [];
        public PageNumberSelectionList: Framework.NameValuePair[] = [];
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


    // QueryCriteriaBase

    export class QueryCriteriaBase<T> {
        public static Strings_NotToCompare: string = "(Not To Compare)";
        constructor(isToCompare: boolean) {
            this.IsToCompare = isToCompare;
        }
        public IsToCompare: boolean;
        //protected static GetListWithLocalizedResource<T>(resourcePrefix: string, type: Type): Framework.NameValueCollection {
        //    var format: string = "{0}_{2}";
        //    var results = new Framework.NameValueCollection();
        //    var prefix = string.IsNullOrWhiteSpace(resourcePrefix) ? type.Name : resourcePrefix;
        //    Enum.GetNames(type).forEach(function (name) {
        //        var resourceName: string = string.Format(format, prefix, null, name);
        //        var resourceString: string = Framework.Resx.UIStringResource.ResourceManager.GetString(resourceName);
        //        results.Add(name, resourceString);
        //    });
        //    return results;
        //}
    }


    // QueryEqualsCriteriaBaseNullable
    export class QueryEqualsCriteriaBase<T> extends QueryCriteriaBase<T>
    {
        public ValueToCompare: T;
        public NullableValueToCompare: T;
        constructor(isToCompare: boolean, valueToCompare: T) {
            super(isToCompare);
            this.ValueToCompare = valueToCompare;
        }
        //public ToString(): string {
        //    if (IsToCompare) {
        //        return string.Format("Value={0}", this.ValueToCompare);
        //    }
        //    else {
        //        return Strings_NotToCompare;
        //    }
        //} 
    }
    export class QueryEqualsCriteriaBaseNullable<T> extends QueryEqualsCriteriaBase<T>
    {
        constructor(isToCompare: boolean, valueToCompare: T) {
            super(isToCompare, valueToCompare);
            this.ValueToCompare = valueToCompare;
        }
        public get NullableValueToCompare(): T {
            return this.ValueToCompare;
        }
        public set NullableValueToCompare(value: T) {
            if (value != this.ValueToCompare) {
                this.ValueToCompare = value;
                this.IsToCompare = typeof value != 'undefined' && value != null;
            }
        }
    }
    export class QuerySystemBooleanEqualsCriteria extends QueryEqualsCriteriaBaseNullable<boolean>
    {
        constructor(isToCompare: boolean, valueToCompare: boolean) {
            super(isToCompare, valueToCompare);
            this.ValueToCompare = valueToCompare != null ? valueToCompare : false;
        }
        m_PredefinedBooleanSelectedValue: PredefinedBooleanSelectedValues;
        public get PredefinedBooleanSelectedValue(): PredefinedBooleanSelectedValues {
            return this.m_PredefinedBooleanSelectedValue;
        }
        public set PredefinedBooleanSelectedValue(value: PredefinedBooleanSelectedValues) {
            this.m_PredefinedBooleanSelectedValue = value;
            this.IsToCompare = this.m_PredefinedBooleanSelectedValue != PredefinedBooleanSelectedValues.All;
            this.ValueToCompare = this.m_PredefinedBooleanSelectedValue == PredefinedBooleanSelectedValues.True;
        }
        //public static GetList(resourcePrefix: string): NameValuePair[] {
        //    var type: Type = /*typeof*/Framework.EntityContracts.PredefinedBooleanSelectedValues;
        //    return GetListWithLocalizedResource(resourcePrefix, type);
        //}
    }
    export class QuerySystemByteEqualsCriteria extends QueryEqualsCriteriaBaseNullable<number>
    {
        constructor(isToCompare: boolean, valueToCompare: number) {
            super(isToCompare, valueToCompare);

        }
    }

    export class QuerySystemDateTimeEqualsCriteria extends QueryEqualsCriteriaBaseNullable<Date>
    {
        constructor(isToCompare: boolean, valueToCompare: Date) {
            super(isToCompare, valueToCompare);

        }
    }
    export class QuerySystemDateTimeOffsetEqualsCriteria extends QueryEqualsCriteriaBaseNullable<Date>
    {
        constructor(isToCompare: boolean, valueToCompare: Date) {
            super(isToCompare, valueToCompare);

        }
    }
    export class QuerySystemGuidEqualsCriteria extends QueryEqualsCriteriaBaseNullable<Framework.Guid>
    {
        constructor(isToCompare: boolean, valueToCompare: Framework.Guid) {
            super(isToCompare, valueToCompare);

        }
    }
    export class QuerySystemStringEqualsCriteria extends QueryEqualsCriteriaBase<string>
    {
        constructor(isToCompare: boolean, valueToCompare: string) {
            super(isToCompare, valueToCompare);

        }
        public get NullableValueToCompare(): string {
            return this.ValueToCompare;
        }
        public set NullableValueToCompare(value: string) {
            this.ValueToCompare = value;
            this.IsToCompare = typeof value != 'undefined' && value != null && value != '';
        }
    }

    // QueryRangeCriteriaBase
    export class QueryRangeCriteriaBase<T> extends QueryCriteriaBase<T>
    {
        public IsToCompareLowerBound: boolean;
        public IsToIncludeLowerBound: boolean;
        public LowerBound: T;
        public IsToCompareUpperBound: boolean;
        public IsToIncludeUpperBound: boolean;
        public UpperBound: T;
        public NullableLowerBound: T;
        public NullableUpperBound: T;
        constructor(isToCompare: boolean, isToCompareLowerBound: boolean, lowerBound: T, isToCompareUpperBound: boolean, upperBound: T) {
            super(isToCompare);
            this.IsToCompareLowerBound = isToCompareLowerBound;
            this.IsToCompareUpperBound = isToCompareUpperBound;
            this.LowerBound = lowerBound;
            this.UpperBound = upperBound;
            this.IsToIncludeLowerBound = true;
            this.IsToIncludeUpperBound = false;
        }
        //public ToString(): string {
        //    if (this.IsToCompare) {
        //        var _Format_Lower: string;
        //        if (this.IsToCompareLowerBound) {
        //            if (this.IsToIncludeLowerBound) {
        //                _Format_Lower = "{0}<=";
        //            }
        //            else {
        //                _Format_Lower = "{0}<";
        //            }
        //        }
        //        else {
        //            _Format_Lower = "";
        //        }
        //        var _Format_Upper: string;
        //        if (this.IsToCompareUpperBound) {
        //            if (this.IsToIncludeUpperBound) {
        //                _Format_Upper = "<={1}";
        //            }
        //            else {
        //                _Format_Upper = "<{1}";
        //            }
        //        }
        //        else {
        //            _Format_Upper = "";
        //        }
        //        var _Format: string = string.Format("{0}x{1}", _Format_Lower, _Format_Upper);
        //        return string.Format(_Format, this.LowerBound, this.UpperBound);
        //    }
        //    else {
        //        return Strings_NotToCompare;
        //    }
        //}
    }
    export class QueryRangeCriteriaBaseNullable<T> extends QueryRangeCriteriaBase<T>
    {
        constructor(isToCompare: boolean, isToCompareLowerBound: boolean, lowerBound: T, isToCompareUpperBound: boolean, upperBound: T) {
            super(isToCompare, isToCompareLowerBound, lowerBound, isToCompareUpperBound, upperBound);
            this.IsToCompareLowerBound = isToCompareLowerBound;
            this.IsToCompareUpperBound = isToCompareUpperBound;
            this.LowerBound = lowerBound;
            this.UpperBound = upperBound;
            this.IsToIncludeLowerBound = true;
            this.IsToIncludeUpperBound = false;
        }
        public get NullableLowerBound(): T {
            return this.LowerBound;
        }
        public set NullableLowerBound(value: T) {
            this.LowerBound = value;
            this.IsToCompareLowerBound = typeof value != 'undefined' && value != null;
            this.IsToCompare = this.IsToCompareLowerBound || this.IsToCompareUpperBound;
        }
        public get NullableUpperBound(): T {
            return this.UpperBound;
        }
        public set NullableUpperBound(value: T) {
            this.UpperBound = value;
            this.IsToCompareUpperBound = typeof value != 'undefined' && value != null;
            this.IsToCompare = this.IsToCompareLowerBound || this.IsToCompareUpperBound;
        }
    }
    export class QuerySystemByteRangeCriteria extends QueryRangeCriteriaBaseNullable<number>
    {
        constructor(isToCompare: boolean, isToCompareLowerBound: boolean, lowerBound: number, isToCompareUpperBound: boolean, upperBound: number) {
            super(isToCompare, isToCompare, lowerBound, isToCompare, upperBound);

        }
    }
    export class QuerySystemDateTimeRangeCriteria extends QueryRangeCriteriaBaseNullable<Date>
    {
        constructor(isToCompare: boolean, isToCompareLowerBound: boolean, lowerBound: Date, isToCompareUpperBound: boolean, upperBound: Date) {
            super(isToCompare, isToCompare, lowerBound, isToCompare, upperBound);
        }
        //constructor(lowerBoundNullable: Date, dateTimeUnitOfInterval: DateTimeUnit, interval: number) {
        //    var _CurrentCriteriaUpperBound: Date;
        //    if (typeof lowerBoundNullable != 'undefined' && lowerBoundNullable != null) {
        //        var lowerBound: Date = lowerBoundNullable;
        //        if (dateTimeUnitOfInterval == DateTimeUnit.Year) {
        //            _CurrentCriteriaUpperBound = lowerBound.AddYears(interval);
        //        }
        //        else if (dateTimeUnitOfInterval == Framework.EntityContracts.Queries.DateTimeUnit.Month) {
        //            _CurrentCriteriaUpperBound = lowerBound.AddMonths(interval);
        //        }
        //        else if (dateTimeUnitOfInterval == Framework.EntityContracts.Queries.DateTimeUnit.Week) {
        //            _CurrentCriteriaUpperBound = lowerBound.AddDays(interval * 7);
        //        }
        //        else if (dateTimeUnitOfInterval == Framework.EntityContracts.Queries.DateTimeUnit.Day) {
        //            _CurrentCriteriaUpperBound = lowerBound.AddDays(interval);
        //        }
        //        else if (dateTimeUnitOfInterval == Framework.EntityContracts.Queries.DateTimeUnit.Hour) {
        //            _CurrentCriteriaUpperBound = lowerBound.AddHours(interval);
        //        }
        //        else if (dateTimeUnitOfInterval == Framework.EntityContracts.Queries.DateTimeUnit.Minute) {
        //            _CurrentCriteriaUpperBound = lowerBound.AddMinutes(interval);
        //        }
        //        else if (dateTimeUnitOfInterval == Framework.EntityContracts.Queries.DateTimeUnit.Second) {
        //            _CurrentCriteriaUpperBound = lowerBound.AddSeconds(interval);
        //        }
        //        else if (dateTimeUnitOfInterval == Framework.EntityContracts.Queries.DateTimeUnit.MilliSecond) {
        //            _CurrentCriteriaUpperBound = lowerBound.AddMilliseconds(interval);
        //        }
        //        else if (dateTimeUnitOfInterval == Framework.EntityContracts.Queries.DateTimeUnit.Tick) {
        //            _CurrentCriteriaUpperBound = lowerBound.AddTicks(interval);
        //        }
        //        else {
        //            _CurrentCriteriaUpperBound = this.UpperBound;
        //        }
        //    }
        //    else {
        //        _CurrentCriteriaUpperBound = null;
        //    }
        //    this.UpperBound = _CurrentCriteriaUpperBound;
        //    this.LowerBound = lowerBoundNullable;
        //    this.IsToCompare = true;
        //    this.IsToCompareLowerBound = true;
        //    this.IsToCompareUpperBound = true;
        //    this.IsToIncludeLowerBound = true;
        //    this.IsToIncludeUpperBound = false;
        //}

        m_PreDefinedDateTimeRange: PreDefinedDateTimeRanges = PreDefinedDateTimeRanges.Today;
        public get PreDefinedDateTimeRange(): PreDefinedDateTimeRanges {
            return this.m_PreDefinedDateTimeRange;
        }
        public set PreDefinedDateTimeRange(value: PreDefinedDateTimeRanges) {
            this.m_PreDefinedDateTimeRange = value;
            //var calculated = QuerySystemDateTimeRangeCriteria.GetBounds(value);
            //this.LowerBound = calculated.LowerBound;
            //this.UpperBound = calculated.UpperBound;
            //this.IsToCompare = value != PreDefinedDateTimeRanges.Unknown;
            //this.IsToCompareLowerBound = true;
            //this.IsToCompareUpperBound = true;
            //this.IsCustomEditor = this.m_PreDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.Custom;
            //RaisePropertyChanged("PreDefinedDateTimeRange");
            //RaisePropertyChanged("IsCustomEditor");
            //RaisePropertyChanged("LowerBound");
            //RaisePropertyChanged("UpperBound");
        }
        public IsCustomEditor: boolean;
        //public static GetBounds(preDefinedDateTimeRange: Framework.EntityContracts.PreDefinedDateTimeRanges): QuerySystemDateTimeRangeCriteria {
        //    let moment = require('moment');
        //    if (preDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.Custom) {
        //        let lowerBound = moment// Date.now() as Date;
        //        let upperBound = Date.now() as Date;
        //        return new QuerySystemDateTimeRangeCriteria(true, true, lowerBound, true, upperBound);
        //    }
        //    //else if (preDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.LastTenYears) {
        //    //    var lowerBound = Date.now.AddYears(-10);
        //    //    lowerBound = new Date(lowerBound.Year, 1, 1);
        //    //    var upperBound = Date.now;
        //    //    return new QuerySystemDateTimeRangeCriteria(true, lowerBound, upperBound);
        //    //}
        //    //else if (preDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.LastFiveYears) {
        //    //    var lowerBound = Date.now.AddYears(-5);
        //    //    lowerBound = new Date(lowerBound.Year, 1, 1);
        //    //    var upperBound = Date.Now;
        //    //    return new QuerySystemDateTimeRangeCriteria(true, lowerBound, upperBound);
        //    //}
        //    //else if (preDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.LastYear) {
        //    //    var lowerBound = Date.now.AddYears(-1);
        //    //    lowerBound = new Date(lowerBound.Year, 1, 1);
        //    //    var upperBound = Date.Now;
        //    //    return new QuerySystemDateTimeRangeCriteria(true, lowerBound, upperBound);
        //    //}
        //    //else if (preDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.LastSixMonths) {
        //    //    var lowerBound = Date.now.AddMonths(-6);
        //    //    lowerBound = new Date(lowerBound.Year, lowerBound.Month, 1);
        //    //    var upperBound = Date.Now;
        //    //    return new QuerySystemDateTimeRangeCriteria(true, lowerBound, upperBound);
        //    //}
        //    //else if (preDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.LastThreeMonths) {
        //    //    var lowerBound = Date.now.AddMonths(-3);
        //    //    lowerBound = new Date(lowerBound.Year, lowerBound.Month, 1);
        //    //    var upperBound = Date.Now;
        //    //    return new QuerySystemDateTimeRangeCriteria(true, lowerBound, upperBound);
        //    //}
        //    //else if (preDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.LastMonth) {
        //    //    var lowerBound = Date.now.AddMonths(-1);
        //    //    lowerBound = new Date(lowerBound.Year, lowerBound.Month, 1);
        //    //    var upperBound = Date.Now;
        //    //    return new QuerySystemDateTimeRangeCriteria(true, lowerBound, upperBound);
        //    //}
        //    //else if (preDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.LastWeek) {
        //    //    var lowerBound = Date.now.AddDays(-7);
        //    //    lowerBound = lowerBound.AddDays(-<number>lowerBound.DayOfWeek);
        //    //    lowerBound = new Date(lowerBound.Year, lowerBound.Month, 1);
        //    //    var upperBound = lowerBound.AddDays(7);
        //    //    return new QuerySystemDateTimeRangeCriteria(true, lowerBound, upperBound);
        //    //}
        //    //else if (preDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.Yesterday) {
        //    //    var lowerBound = Date.now.AddDays(-1);
        //    //    lowerBound = new Date(lowerBound.Year, lowerBound.Month, lowerBound.Day, 0, 0, 0);
        //    //    var upperBound = lowerBound.AddDays(1);
        //    //    return new QuerySystemDateTimeRangeCriteria(true, lowerBound, upperBound);
        //    //}
        //    //else if (preDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.ThisYear) {
        //    //    var lowerBound = new Date(Date.now.Year, 1, 1);
        //    //    var upperBound = lowerBound.AddYears(1);
        //    //    return new QuerySystemDateTimeRangeCriteria(true, lowerBound, upperBound);
        //    //}
        //    //else if (preDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.ThisMonth) {
        //    //    var lowerBound = new Date(Date.now.Year, Date.now.Month, 1);
        //    //    var upperBound = lowerBound.AddMonths(1);
        //    //    return new QuerySystemDateTimeRangeCriteria(true, lowerBound, upperBound);
        //    //}
        //    //else if (preDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.ThisWeek) {
        //    //    var lowerBound = Date.now.AddDays(-<number>Date.now.DayOfWeek);
        //    //    var upperBound = lowerBound.AddDays(7);
        //    //    return new QuerySystemDateTimeRangeCriteria(true, lowerBound, upperBound);
        //    //}
        //    //else if (preDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.Today) {
        //    //    var lowerBound = new Date(Date.now.Year, Date.now.Month, Date.now.Day);
        //    //    var upperBound = lowerBound.AddDays(1);
        //    //    return new QuerySystemDateTimeRangeCriteria(true, lowerBound, upperBound);
        //    //}
        //    //else if (preDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.Tomorrow) {
        //    //    var lowerBound = new Date(Date.now.Year, Date.now.Month, Date.now.Day).AddDays(1);
        //    //    var upperBound = lowerBound.AddDays(1);
        //    //    return new QuerySystemDateTimeRangeCriteria(true, lowerBound, upperBound);
        //    //}
        //    //else if (preDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.NextWeek) {
        //    //    var lowerBound = Date.now.AddDays(-<number>Date.now.DayOfWeek).AddDays(7);
        //    //    var upperBound = lowerBound.AddDays(7);
        //    //    return new QuerySystemDateTimeRangeCriteria(true, lowerBound, upperBound);
        //    //}
        //    //else if (preDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.NextMonth) {
        //    //    var lowerBound = new Date(Date.now.Year, Date.now.Month, 1).AddMonths(1);
        //    //    var upperBound = lowerBound.AddMonths(1);
        //    //    return new QuerySystemDateTimeRangeCriteria(true, lowerBound, upperBound);
        //    //}
        //    //else if (preDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.NextThreeMonths) {
        //    //    var lowerBound = new Date(Date.now.Year, Date.now.Month, 1).AddMonths(1);
        //    //    var upperBound = lowerBound.AddMonths(3);
        //    //    return new QuerySystemDateTimeRangeCriteria(true, lowerBound, upperBound);
        //    //}
        //    //else if (preDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.NextSixMonths) {
        //    //    var lowerBound = new Date(Date.now.Year, Date.now.Month, 1).AddMonths(1);
        //    //    var upperBound = lowerBound.AddMonths(6);
        //    //    return new QuerySystemDateTimeRangeCriteria(true, lowerBound, upperBound);
        //    //}
        //    //else if (preDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.NextYear) {
        //    //    var lowerBound = new Date(Date.now.Year, 1, 1).AddYears(1);
        //    //    var upperBound = lowerBound.AddYears(1);
        //    //    return new QuerySystemDateTimeRangeCriteria(true, lowerBound, upperBound);
        //    //}
        //    //else if (preDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.NextFiveYears) {
        //    //    var lowerBound = new Date(Date.now.Year, 1, 1).AddYears(1);
        //    //    var upperBound = lowerBound.AddYears(5);
        //    //    return new QuerySystemDateTimeRangeCriteria(true, lowerBound, upperBound);
        //    //}
        //    //else if (preDefinedDateTimeRange == Framework.EntityContracts.PreDefinedDateTimeRanges.NextTenYears) {
        //    //    var lowerBound = new Date(Date.now.Year, 1, 1).AddYears(1);
        //    //    var upperBound = lowerBound.AddYears(10);
        //    //    return new QuerySystemDateTimeRangeCriteria(true, lowerBound, upperBound);
        //    //}
        //    return new QuerySystemDateTimeRangeCriteria(false, false, null, false, null);
        //}

        //public static GetYearRangeOf(dateTime: Date): QuerySystemDateTimeRangeCriteria {
        //    var _FirstDay: Date = new Date(dateTime.Year, 1, 1);
        //    var _retval: QuerySystemDateTimeRangeCriteria = new QuerySystemDateTimeRangeCriteria(true, _FirstDay, _FirstDay.AddYears(1));
        //    _retval.IsToIncludeUpperBound = false;
        //    return _retval;
        //}
        //public static GetQuarterOfYearRangeOf(dateTime: Date): QuerySystemDateTimeRangeCriteria {
        //    var _FirstMonthOfQuarterOfYear: number = (dateTime.Month - 1) / 3 + 1;
        //    var _FirstDay: Date = new Date(dateTime.Year, _FirstMonthOfQuarterOfYear, 1);
        //    var _retval: QuerySystemDateTimeRangeCriteria = new QuerySystemDateTimeRangeCriteria(true, _FirstDay, _FirstDay.AddMonths(3));
        //    _retval.IsToIncludeUpperBound = false;
        //    return _retval;
        //}
        //public static GetMonthRangeOf(dateTime: Date): QuerySystemDateTimeRangeCriteria {
        //    var _FirstDay: Date = new Date(dateTime.Year, dateTime.Month, 1);
        //    var _retval: QuerySystemDateTimeRangeCriteria = new QuerySystemDateTimeRangeCriteria(true, _FirstDay, _FirstDay.AddMonths(1));
        //    _retval.IsToIncludeUpperBound = false;
        //    return _retval;
        //}
        //public static GetSemiMonthRangeOf(dateTime: Date): QuerySystemDateTimeRangeCriteria {
        //    var _FirstDay: Date = new Date(dateTime.Year, dateTime.Month, 1);
        //    var _retval: QuerySystemDateTimeRangeCriteria;
        //    if (dateTime.Day <= 15) {
        //        _retval = new QuerySystemDateTimeRangeCriteria(true, _FirstDay, _FirstDay.AddDays(15));
        //    }
        //    else {
        //        _retval = new QuerySystemDateTimeRangeCriteria(true, _FirstDay.AddDays(15), _FirstDay.AddMonths(1));
        //    }
        //    _retval.IsToIncludeUpperBound = false;
        //    return _retval;
        //}
        //public static GetBiWeekRangeOf(dateTime: Date): QuerySystemDateTimeRangeCriteria {
        //    var _SunDay: Date = dateTime.AddDays(-<number>dateTime.DayOfWeek);
        //    var _FirstDay: Date = new Date(_SunDay.Year, _SunDay.Month, _SunDay.Day);
        //    var _retval: QuerySystemDateTimeRangeCriteria = new QuerySystemDateTimeRangeCriteria(true, _FirstDay, _FirstDay.AddDays(14));
        //    _retval.IsToIncludeUpperBound = false;
        //    return _retval;
        //}
        //public static GetWeekRangeOf(dateTime: Date): QuerySystemDateTimeRangeCriteria {
        //    var _SunDay: Date = dateTime.AddDays(-<number>dateTime.DayOfWeek);
        //    var _FirstDay: Date = new Date(_SunDay.Year, _SunDay.Month, _SunDay.Day);
        //    var _retval: QuerySystemDateTimeRangeCriteria = new QuerySystemDateTimeRangeCriteria(true, _FirstDay, _FirstDay.AddDays(7));
        //    _retval.IsToIncludeUpperBound = false;
        //    return _retval;
        //}
        //public static GetDayRangeOf(dateTime: Date): QuerySystemDateTimeRangeCriteria {
        //    var _FirstHour: Date = new Date(dateTime.Year, dateTime.Month, dateTime.Day, 0, 0, 0);
        //    var _retval: QuerySystemDateTimeRangeCriteria = new QuerySystemDateTimeRangeCriteria(true, _FirstHour, _FirstHour.AddDays(1));
        //    _retval.IsToIncludeUpperBound = false;
        //    return _retval;
        //}
        //public static GetHourRangeOf(dateTime: Date): QuerySystemDateTimeRangeCriteria {
        //    var _FirstMinute: Date = new Date(dateTime.Year, dateTime.Month, dateTime.Day, dateTime.Hour, 0, 0);
        //    var _retval: QuerySystemDateTimeRangeCriteria = new QuerySystemDateTimeRangeCriteria(true, _FirstMinute, _FirstMinute.AddHours(1));
        //    _retval.IsToIncludeUpperBound = false;
        //    return _retval;
        //}
        //public Predicate(input: Date): boolean {
        //    var _retval: boolean;
        //    if (this.IsToCompare == true) {
        //        if (this.IsToCompareLowerBound == true) {
        //            _retval = this.IsToIncludeLowerBound ? input >= this.LowerBound : input > this.LowerBound;
        //        }
        //        else {
        //            _retval = true;
        //        }
        //        if (_retval == true) {
        //            if (this.IsToCompareUpperBound == true) {
        //                _retval = this.IsToIncludeUpperBound ? input <= this.UpperBound : input < this.UpperBound;
        //            }
        //            else {
        //                _retval = true;
        //            }
        //        }
        //    }
        //    else {
        //        _retval = true;
        //    }
        //    return _retval;
        //}
        //public CalculateConsecutiveDistributionCriteria(dateTimeUnitOfInterval: Framework.EntityContracts.Queries.DateTimeUnit, interval: number): QuerySystemDateTimeRangeCriteria[] {
        //    var _retval: List<QuerySystemDateTimeRangeCriteria> = new List<QuerySystemDateTimeRangeCriteria>();
        //    var _CurrentCriteriaLowerBound: Date = this.LowerBound;
        //    while (_CurrentCriteriaLowerBound < this.UpperBound) {
        //        var _OneCriteria: QuerySystemDateTimeRangeCriteria = new QuerySystemDateTimeRangeCriteria(_CurrentCriteriaLowerBound, dateTimeUnitOfInterval, interval);
        //        _CurrentCriteriaLowerBound = _OneCriteria.UpperBound;
        //        _retval.Add(_OneCriteria);
        //    }
        //    return _retval.ToArray();
        //}
        //public static GetList(resourcePrefix: string): Framework.NameValueCollection {
        //    var type: Type = /*typeof*/Framework.EntityContracts.PreDefinedDateTimeRanges;
        //    return GetListWithLocalizedResource(resourcePrefix, type);
        //}
    }
    
    export class QuerySystemStringRangeCriteria extends QueryRangeCriteriaBase<string>
    {
        constructor(isToCompare: boolean, isToCompareLowerBound: boolean, lowerBound: string, isToCompareUpperBound: boolean, upperBound: string) {
            super(isToCompare, isToCompare, lowerBound, isToCompare, upperBound);

        }
        public get NullableLowerBound(): string {
            return this.LowerBound;
        }
        public set NullableLowerBound(value: string) {
            this.LowerBound = value;
            this.IsToCompareLowerBound = value != null && value != '';
            this.IsToCompare = this.IsToCompareLowerBound || this.IsToCompareUpperBound;
        }
        public get NullableUpperBound(): string {
            return this.UpperBound;
        }
        public set NullableUpperBound(value: string) {
            this.UpperBound = value;
            this.IsToCompareUpperBound = value != null && value != '';
            this.IsToCompare = this.IsToCompareLowerBound || this.IsToCompareUpperBound;
        }
    }

    // QueryInSelectedListCriteriaBase
    export class QueryInSelectedListCriteriaBase<T> extends QueryCriteriaBase<T>
    {
        public SelectedList: T[];
        constructor(isToCompare: boolean, selectedList: T[]) {
            super(isToCompare);
            this.SelectedList = selectedList;
        }
    }
    export class QuerySystemByteInSelectedListCriteria extends QueryInSelectedListCriteriaBase<number>
    {
        constructor(isToCompare: boolean, selectedList: number[]) {
            super(isToCompare, selectedList);
        }
    }
    export class QuerySystemDateTimeInSelectedListCriteria extends QueryInSelectedListCriteriaBase<Date>
    {

        constructor(isToCompare: boolean, selectedList: Date[]) {
            super(isToCompare, selectedList);

        }
    }
    export class QuerySystemGuidInSelectedListCriteria extends QueryInSelectedListCriteriaBase<Framework.Guid>
    {
        constructor(isToCompare: boolean, selectedList: Framework.Guid[]) {
            super(isToCompare, selectedList);
        }
    }
    export class QuerySystemStringInSelectedListCriteria extends QueryInSelectedListCriteriaBase<string>
    {
        constructor(isToCompare: boolean, selectedList: string[]) {
            super(isToCompare, selectedList);
        }
    }

    export class QueryContainsCriteriaBase<T> extends QueryCriteriaBase<T>
    {
        public ValueToBeContained: T;
        public NullableValueToBeContained: T;

        constructor(isToCompare: boolean, valueToBeContained: T) {
            super(isToCompare);
            this.ValueToBeContained = valueToBeContained;
        }
    }
    export class QuerySystemStringContainsCriteria extends QueryContainsCriteriaBase<string>
    {

        constructor(isToCompare: boolean, valueToBeContained: string) {
            super(isToCompare, valueToBeContained);
        }
        public get NullableValueToBeContained(): string {
            return this.ValueToBeContained;
        }
        public set NullableValueToBeContained(value: string) {
            this.ValueToBeContained = value;
            this.IsToCompare = value != null && value != '';
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
