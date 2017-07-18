import { Component } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { PersonRoleService } from './personrole.service';
import { RoleService } from '../role/role.service'
import { PersonRole } from '../models/personrole';
import { Role } from '../models/role';
import { FormGroup, FormBuilder, Validators, FormControl } from '@angular/forms';
import { Router, ActivatedRoute, Params } from "@angular/router";

@Component({
    // moduleId: module.id,
    selector: 'my-personrole',
    templateUrl: 'personrole.component.html',
})

export class PersonRoleComponent {

    personroles: Array<PersonRole>;
    roles: Array<Role>;
    notBusy: Boolean;
    newPersonRoleForm: FormGroup;
    _fb: FormBuilder;
    _personRoleService: PersonRoleService;
    newPersonRole: PersonRole;
    showValidation: boolean;
    personName: string;
    roleName: string;

    constructor(fb: FormBuilder, personRoleService: PersonRoleService, private router: Router,
        private activatedRoute: ActivatedRoute,private roleService: RoleService) {
        this.notBusy = true;

        this._fb = fb;
        this._personRoleService = personRoleService;
        this.newPersonRole = new PersonRole();
    }

    ngOnInit() {
        let id: number = +this.activatedRoute.snapshot.params["id"];
        
        this.createForm();
        this.notBusy = false;
        this.showValidation = false;
        this._personRoleService.getPersonRoles(id).subscribe(data => { this.processResult(data) });
        this.notBusy = true;

    }

    createForm() {
        this.newPersonRoleForm = this._fb.group({
            // To add a validator, we must first convert the string value into an array. The first item in the array is the default value if any, then the next item in the array is the validator. Here we are adding a required validator meaning that the firstName attribute must have a value in it.
            'roleName': [this.newPersonRole.PersonName, Validators.compose([null, Validators.required])],
        })
    }

    processResult(data: any) {
        this.personroles = data;

        if (this.personroles.length == 0)
            {return;}

        this.personName = this.personroles[0].PersonName;
    }


    addPersonRole() {

    }

    getRoles() {
        this.roleService.getRoles().subscribe(data => this.roles = data)
    }
}
