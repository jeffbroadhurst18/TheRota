import { Component, ChangeDetectorRef } from '@angular/core';
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
    //personName: string;
    roleName: string;
    hidePersonId: boolean;

    constructor(fb: FormBuilder, personRoleService: PersonRoleService, private router: Router,
        private activatedRoute: ActivatedRoute, private roleService: RoleService,
        private ref: ChangeDetectorRef) {
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
        this.hidePersonId = true;

    }

    createForm() {
        this.newPersonRoleForm = this._fb.group({
            // To add a validator, we must first convert the string value into an array. The first item in the array is the default value if any, then the next item in the array is the validator. Here we are adding a required validator meaning that the firstName attribute must have a value in it.
            'roleId': [this.newPersonRole.RoleId, Validators.compose([null, Validators.required])],
            'personId': [this.newPersonRole.PersonId, Validators.compose([null, Validators.required])],
        })
    }

    processResult(data: any) {
        this.personroles = data;

        if (this.personroles.length == 0)
        { return; }

        this.newPersonRole.PersonName = this.personroles[0].PersonName;
        this.newPersonRole.PersonId = this.personroles[0].PersonId;
        this.getRoles(this.newPersonRole.PersonId);
        this.notBusy = true;
    }


    addPersonRole(value: any) {
        this.showValidation = true;
        if (!this.newPersonRoleForm.valid) {
            console.log('Exit as not valid');
            return;
        }

        this._personRoleService.savePersonRole(value).subscribe(data => this.checkSaveSuccessful(data));
    }

    getRoles(personId: number) {
        this.roleService.getRolesForPerson(personId).subscribe(data => this.roles = data)
    }

    checkSaveSuccessful(data: any) {

        let added: PersonRole = new PersonRole();
        added.PersonId = this.newPersonRole.PersonId;
        added.PersonName = this.newPersonRole.PersonName;
        added.RoleName = this.getRoleName(this.newPersonRole.RoleId)
        added.RoleId = this.newPersonRole.RoleId;

        this.personroles.push(added);
        this.removeSelectedRoles(added.RoleId);
        this.ref.detectChanges();
        this.newPersonRole.RoleId = null;
        this.showValidation = false;
    }

    onBack() {
        this.router.navigate(["person"]);
    }

    private removeSelectedRoles(roleId: number) {
        let newRoles: Role[] = new Array<Role>();
        let p: number = 0;
        for (p = 0; p < this.roles.length; p++) {
            if (this.roles[p].Id == roleId) {
                this.roles.splice(p, 1);
                return;
            }
        }
    }

    private getRoleName(id: number): string {

        let k: number = 0;
        for (k = 0; k < this.roles.length; k++) {
            if (this.roles[k].Id == id) {
                return this.roles[k].Name;
            }
        }
    }
}
