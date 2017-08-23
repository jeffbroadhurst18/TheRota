import { Injectable } from '@angular/core';
import { Http, Headers, Response, RequestOptions } from '@angular/http';
import { Observable } from "rxjs/Observable";
import { Fixture } from '../models/fixture';

@Injectable()
export class FixtureService {

    baseUrl : string;

    constructor(private http: Http) {
            this.baseUrl = 'http://localhost:61643/api';
     }

    getFixtures() : Observable<Fixture[]> {
           let url: string = this.baseUrl + '/fixture/fixtures';
           return this.http.get(url).map((res: Response) => res.json());
    }

    saveFixture(fixture: Fixture){
        let url: string = this.baseUrl + '/fixture/save';
        return this.http.post(url,JSON.stringify(fixture), this.getRequestOptions())
        .map((res: Response) => res.json());
    }

    private getRequestOptions() {
        return new RequestOptions({
            headers: new Headers({
                "Content-Type": "application/json"
            })
        });
    }
}