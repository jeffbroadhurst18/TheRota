import { Injectable } from '@angular/core';
import { Http, Headers, Response, RequestOptions } from '@angular/http';
import { Observable } from "rxjs/Observable";
import { PersonRole } from '../models/personrole';

@Injectable()
export class PersonRoleService {

    baseUrl : string;

    constructor(private http: Http) {
            this.baseUrl = 'http://localhost:61643/api';
     }

    getPersonRoles(personId: number) : Observable<PersonRole[]> {
           let url: string = this.baseUrl + '/person/getpersonroles/' + personId.toString();
           return this.http.get(url).map((res: Response) => res.json());
    }

    public savePersonRole(personrole: PersonRole){
        let url: string = this.baseUrl + '/person/personrolesave';
        return this.http.post(url,JSON.stringify(personrole), this.getRequestOptions())
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