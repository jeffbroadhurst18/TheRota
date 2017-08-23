import { Injectable } from '@angular/core';
import { Http, Headers, Response, RequestOptions } from '@angular/http';
import { Observable } from "rxjs/Observable";
import { Role } from '../models/role';

@Injectable()
export class RoleService {

    baseUrl: string;

    constructor(private http: Http) {
        this.baseUrl = 'http://localhost:61643/api';
    }

    public getRoles(): Observable<Role[]> {
        let url: string = this.baseUrl + '/role/roles/';
        return this.http.get(url).map((res: Response) => res.json());
    }

    public getRolesForPerson(personId: number): Observable<Role[]> {
        let url: string = this.baseUrl + '/role/roles/' + personId.toString();
        return this.http.get(url).map((res: Response) => res.json());
    }
}