import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import * as Framework from '../Framework';

export class BuildLog {
    constructor() {
    }
    public id: number;
    public buildId: number;
    public buildEventCodeId: number;
    public message: string;
    public eventTime: Date;
}

export namespace BuildLog {
    export class Default {
        constructor() {
        }
        public build_1_Name: string;
        public id: number;
        public solution_1Id: number;
        public solution_1_Name: string;
        public organization_1_UniqueidentifierColumn: Framework.Guid;
        public organization_1_UniqueIdentifier: Framework.Guid;
        public organization_1Id: number;
        public organization_1_Name: string;
        public organization_2_UniqueidentifierColumn: Framework.Guid;
        public organization_2Id: number;
        public organization_2_UniqueIdentifier: Framework.Guid;
        public organization_2_Name: string;
        public buildEventCode_1_Name: string;
        public buildId: number;
        public buildEventCodeId: number;
        public message: string;
        public eventTime: Date;
    }

    export class DefaultGroupedDataView {
        constructor() {
        }
        public buildId: number;
        public buildEventCodeId: number;
        public countPerFK: number;
        public name: string;
        public solution_1Id: number;
        public organization_1Id: number;
        public organization_2Id: number;
    }

    export class KeyInformation {
        constructor() {
          this.id = null;
            this.buildEventCodeId = null;
        }
      public id: number;
        public buildEventCodeId: number;
    }
}
export class BuildLogIdentifier {
    constructor(id: number) {
        this.id = id;
    }
    public id: number;
}
