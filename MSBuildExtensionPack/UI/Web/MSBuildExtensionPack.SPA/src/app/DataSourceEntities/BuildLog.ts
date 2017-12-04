import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import * as Framework from '../Framework';
import * as FrameworkEntityContracts from '../Framework.EntityContracts';

export class BuildLog {
    constructor() {
    }
    public Id: number;
    public BuildId: number;
    public BuildEventCodeId: number;
    public Message: string;
    public EventTime: Date;
}


export namespace BuildLog {
    export class Default {
        constructor() {
        }
        public Build_1_Name: string;
        public Id: number;
        public Solution_1Id: number;
        public Solution_1_Name: string;
        public Organization_1_UniqueidentifierColumn: Framework.Guid;
        public Organization_1_UniqueIdentifier: Framework.Guid;
        public Organization_1Id: number;
        public Organization_1_Name: string;
        public Organization_2_UniqueidentifierColumn: Framework.Guid;
        public Organization_2Id: number;
        public Organization_2_UniqueIdentifier: Framework.Guid;
        public Organization_2_Name: string;
        public BuildEventCode_1_Name: string;
        public BuildId: number;
        public BuildEventCodeId: number;
        public Message: string;
        public EventTime: Date;
    }

    export class DefaultGroupedDataView {
        constructor() {
        }
        public BuildId: number;
        public BuildEventCodeId: number;
        public CountPerFK: number;
        public Name: string;
        public Solution_1Id: number;
        public Organization_1Id: number;
        public Organization_2Id: number;
    }

    export class KeyInformation {
        constructor() {
            this.Id = null;
            this.BuildEventCodeId = null;
        }
        public Id: number;
        public BuildEventCodeId: number;
    }
}
export class BuildLogIdentifier {
    constructor(id: number) {
        this.Id = id;
    }
    public Id: number;
}
