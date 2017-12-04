import { Injectable, Inject } from '@angular/core';
import { HttpClient, HttpHeaders, HttpResponse } from '@angular/common/http';
import { Observable } from 'rxjs/Observable';
import 'rxjs/add/operator/map';
import 'rxjs/add/operator/catch';
import 'rxjs/add/observable/throw';
import * as Framework from '../Framework';
import * as FrameworkEntityContracts from '../Framework.EntityContracts';

export class BuildEventCode {
    constructor() {
    }
    public Id: number;
    public EventCode: string;
    public Description: string;
}

export namespace BuildEventCode {
    export class KeyInformation {
        constructor() {
            this.Id = null;
            this.EventCode = null;
        }
        public Id: number;
        public EventCode: string;
    }
}

export class BuildEventCodeIdentifier {
    constructor(id: number) {
        this.Id = id;
    }
    public Id: number;
}
