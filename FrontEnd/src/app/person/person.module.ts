import { NgModule } from '@angular/core';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { WaitComponent } from '../wait.component';

import { PersonComponent } from './person.component';
import { PersonRoutingModule } from './person-routing.module';
import { PersonService } from './person.service';

@NgModule({
    imports: [FormsModule, CommonModule, PersonRoutingModule, ReactiveFormsModule],
    declarations: [PersonComponent,WaitComponent],
    providers: [PersonService]
})
export class PersonModule { }