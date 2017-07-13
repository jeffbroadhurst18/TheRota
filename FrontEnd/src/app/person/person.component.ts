import { Component } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { PersonService } from './person.service';
import { Person } from '../models/person';
import { FormGroup, FormBuilder, Validators, FormControl } from '@angular/forms';

@Component({
    // moduleId: module.id,
    selector: 'my-person',
    templateUrl: 'person.component.html',
})

export class PersonComponent {

    persons: Array<Person>;
    notBusy: Boolean;
    newPersonForm: FormGroup;
    _fb: FormBuilder;
    _personService: PersonService;
    newPerson: Person;
    showValidation: boolean;

    constructor(fb: FormBuilder, personService: PersonService) {
        this.notBusy = true;

        this._fb = fb;
        this._personService = personService;
        this.newPerson = new Person();

    }

    ngOnInit(): void {
        this.createForm();
        this.notBusy = false;
        this.showValidation = false;
        this._personService.getPersons().subscribe(data => { this.processResult(data) })
        this.notBusy = true;
    };

    createForm() {
        this.newPersonForm = this._fb.group({
            // To add a validator, we must first convert the string value into an array. The first item in the array is the default value if any, then the next item in the array is the validator. Here we are adding a required validator meaning that the firstName attribute must have a value in it.
            'firstName': [this.newPerson.FirstName, Validators.compose([null, Validators.required, Validators.minLength(5)])],
            // We can use more than one validator per field. If we want to use more than one validator we have to wrap our array of validators with a Validators.compose function. Here we are using a required, minimum length and maximum length validator.
            'lastName': [this.newPerson.LastName, Validators.compose([null, Validators.required, Validators.minLength(5)])],
            'idNumber': [this.newPerson.IdNumber, Validators.required],
        })
    }

    processResult(data: Person[]): void {
        this.persons = data
    }

    addPerson(value:any) {
        this.showValidation = true;
        if (!this.newPersonForm.valid)
        {
            console.log('Exit as not valid');
            return;
        }
        
        this._personService.savePerson(value).subscribe(data => this.checkSaveSuccessful(data));
    }

    checkSaveSuccessful(data: any)
    {
        
        let added: Person = new Person();
        added.FirstName = this.newPerson.FirstName;
        added.LastName = this.newPerson.LastName;
        added.IdNumber = this.newPerson.IdNumber;
        added.DateCreated = this.newPerson.DateCreated;
        this.persons.push(added);
        this.newPersonForm.reset();
        this.showValidation = false;
    }
}
