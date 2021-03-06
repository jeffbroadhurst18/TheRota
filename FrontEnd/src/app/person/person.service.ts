import { Injectable } from '@angular/core';
import { Http, Headers, Response, RequestOptions } from '@angular/http';
import { Observable } from "rxjs/Observable";
import { Person } from '../models/person';

@Injectable()
export class PersonService {

    baseUrl : string;

    constructor(private http: Http) {
            this.baseUrl = 'http://localhost:61643/api';
     }

    getPersons() : Observable<Person[]> {
           let url: string = this.baseUrl + '/person/persons';
           return this.http.get(url).map((res: Response) => res.json());
    }

    savePerson(person: Person){
        let url: string = this.baseUrl + '/person/save';
        return this.http.post(url,JSON.stringify(person), this.getRequestOptions())
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