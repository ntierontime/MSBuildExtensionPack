import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
    export interface NameValuePair {
        Name: string;
        Value: string;
    }

    export class RssItem {

        constructor(title: string,
            description: string,
            author: string,
            comments: string,
            link: string,
            pubDate: Date,
            identifierInString: string,
            createdByUserName: string,
            createdByIdentifier: string, //System.Guid,
            dateCreated: Date,
            lastModifiedByUserName: string,
            lastModifiedByIdentifier: string, //System.Guid,
            dateLastModified: Date) {

            this.Title = title;
            this.Description = description;
            this.Author = author;
            this.Comments = comments;
            this.Link = link;
            this.PubDate = pubDate;
            this.IdentifierInString = identifierInString;
            this.CreatedByUserName = createdByUserName;
            this.CreatedByIdentifier = createdByIdentifier;
            this.DateCreated = dateCreated;
            this.LastModifiedByUserName = lastModifiedByUserName;
            this.LastModifiedByIdentifier = lastModifiedByIdentifier;
            this.DateLastModified = dateLastModified;
        }
        public Title: string;
        public Description: string;
        public Author: string;
        public Comments: string;
        public Link: string;
        public PubDate: Date;
        public IdentifierInString: string;
        public CreatedByUserName: string;
        public CreatedByIdentifier: string; //System.Guid;
        public DateCreated: Date;
        public LastModifiedByUserName: string;
        public LastModifiedByIdentifier: string; //System.Guid;
        public DateLastModified: Date;
    }


    export enum DataServiceTypes {
        DataSourceResult = 0,
        Csv = 1,
        Excel2010 = 2
    }

    export class DataStreamServiceResult {
        constructor(fileName: string, mimeType: string, contentLength: number) {
            let path = require('path')
            this.FileName = fileName;
            this.FileExtension = path.GetExtension(fileName);
            this.MIMEType = mimeType;
            this.ContentLength = contentLength;
            //this.Result = input;
            if (this.FileExtension.toLowerCase() == ".xlsx" || this.FileExtension.toLowerCase() == "xlsx") {
                this.DataServiceType = DataServiceTypes.Excel2010;
            }
            else if (this.FileExtension.toLowerCase() == ".csv" || this.FileExtension.toLowerCase() == "csv") {
                this.DataServiceType = DataServiceTypes.Csv;
            }
            else {
                this.DataServiceType = DataServiceTypes.Csv;
            }
        }
        public DataServiceType: DataServiceTypes;
        public ContentLength: number;
        public MIMEType: string;
        public FileName: string;
        public FileExtension: string;
        public TempFilePath: string;
        //public Result: Stream;
    }

    export class NavigationSetting {
        constructor(sourceTypeFullName: string,
            senderView: string,
            uIAction: UIAction,
            uIActionStatus: UIActionStatus,
            nextUIAction: UIAction,
            targetUrl: string,
            targetPageType: string) {
            this.SourceTypeFullName = sourceTypeFullName;
            this.SenderView = senderView;
            this.UIAction = uIAction;
            this.UIActionStatus = uIActionStatus;
            this.NextUIAction = nextUIAction;
            this.TargetUrl = targetUrl;
            this.TargetPageType = targetPageType;
        }
        public SourceTypeFullName: string;
        public SenderView: string;
        public UIAction: UIAction;
        public UIActionStatus: UIActionStatus;
        public NextUIAction: UIAction;
        public TargetUrl: string;
        public TargetPageType: string;
    }

    export enum LoggingOptions {
        Application_Started,
        Session_Started,
        Application_Ended,
        Session_Ended,
        BinaryResourceHandler_Request_Process_Started,
        BinaryResourceHandler_Request_Process_Ended,
        CreateUser_Succeeded,
        CreateUser_Failed,
        PasswordRecovery_AnswerLookupError,
        PasswordRecovery_SendMailError,
        PasswordRecovery_UserLookupError,
        LogIn_Success,
        LogIn_Failed,
        LogIn_Failed_3_Times,
        UI_Process_Started,
        UI_Process_Succeeded,
        UI_Process_Failed,
        UI_Process_Ended,
        Business_Logic_Layer_Process_Started,
        Business_Logic_Layer_Process_Succeeded,
        Business_Logic_Layer_Process_Failed,
        Business_Logic_Layer_Process_Ended,
        Data_Access_Layer_Process_Succeeded,
        Data_Access_Layer_Process_Failed,
        Data_Access_Layer_Process_Started,
        Data_Access_Layer_Process_Ended
    }

    export enum UIAction {
        Unknown,

        ViewDetails,

        Navigate,

        GoBack,

        GoForward,

        Create,

        Search,

        Delete,

        Update,

        Refresh,

        SelectionChanged,

        ClearResult,

        Copy,

        Result,

        Home
    }

    export enum UIActionStatus {
        Unknown,

        Launch,

        Starting,

        Success,

        Failed,

        Close
    }

    export class UIActionStatusMessage {
        constructor(sourceTypeFullName: string,
            senderView: string,
            uIAction: UIAction,
            uIActionStatus: UIActionStatus,
            errorMessage: string) {
            this.ErrorMessage = errorMessage;
            this.SourceTypeFullName = sourceTypeFullName;
            this.SenderView = senderView;
            this.UIAction = uIAction;
            this.UIActionStatus = uIActionStatus;
        }
        public SourceTypeFullName: string;
        public SenderView: string;
        public UIAction: UIAction;
        public UIActionStatus: UIActionStatus;
        public ErrorMessage: string;
    }

    export class UISelectedItemChangedMessage {
        constructor(sourceTypeFullName: string,
            sourcePropertyName: string,
            selectedItem: Object) {
            this.SourceTypeFullName = sourceTypeFullName;
            this.SourcePropertyName = sourcePropertyName;
            this.SelectedItem = selectedItem;
        }
        public SourceTypeFullName: string;
        public SourcePropertyName: string;
        public SelectedItem: Object;
    }
