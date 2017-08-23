import { Component } from '@angular/core';
import { Observable } from 'rxjs/Observable';
import { FixtureService } from './fixture.service';
import { Fixture } from '../models/fixture';
import { FormGroup, FormBuilder, Validators, FormControl } from '@angular/forms';

@Component({
    // moduleId: module.id,
    selector: 'my-fixture',
    templateUrl: 'fixture.component.html',
})

export class FixtureComponent {

    fixtures: Array<Fixture>;
    notBusy: Boolean;
    newDateForm: FormGroup;
    _fb: FormBuilder;
    _fixtureService: FixtureService;
    newFixture: Fixture;
    showValidation: boolean; 

    constructor(fb: FormBuilder, fixtureService: FixtureService) {
        this.notBusy = true;

        this._fb = fb;
        this._fixtureService = fixtureService;
        this.newFixture = new Fixture();

    }

    ngOnInit(): void {
        this.createForm();
        this.notBusy = false;
        this.showValidation = false;
        this._fixtureService.getFixtures().subscribe(data => { this.processResult(data) })
        this.notBusy = true;
    };

    createForm() {
        this.newDateForm = this._fb.group({
            // To add a validator, we must first convert the string value into an array. The first item in the array is the default value if any, then the next item in the array is the validator. Here we are adding a required validator meaning that the firstName attribute must have a value in it.
            'fixtureDate': [this.newFixture.FixtureDate, Validators.compose([null, Validators.required, Validators.minLength(5)])],
            // We can use more than one validator per field. If we want to use more than one validator we have to wrap our array of validators with a Validators.compose function. Here we are using a required, minimum length and maximum length validator.
            'title': [this.newFixture.Title, Validators.compose([null, Validators.required, Validators.minLength(5)])],
        }) 
    }

    processResult(data: Fixture[]): void {
        //this.fixtures = data
        this.fixtures = null;
    }

    addFixture(value:any) {
        this.showValidation = true;
        if (!this.newDateForm.valid)
        {
            console.log('Exit as not valid');
            return;
        }
        
        this._fixtureService.saveFixture(value).subscribe(data => this.checkSaveSuccessful(data));
    }

    checkSaveSuccessful(data: any)
    {
        let added: Fixture = new Fixture();
        added.Id = this.newFixture.Id;
        added.FixtureDate = this.newFixture.FixtureDate;
        added.Title = this.newFixture.Title;
        this.fixtures.push(added);
        this.newDateForm.reset();
        this.showValidation = false;
    }

    
}
