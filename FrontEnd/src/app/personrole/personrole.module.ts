import { NgModule } from '@angular/core';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

import { PersonRoleComponent } from './personrole.component';
import { PersonRoleRoutingModule } from './personrole-routing.module';
import { PersonRoleService } from './personrole.service';

@NgModule({
    imports: [FormsModule, CommonModule, PersonRoleRoutingModule, ReactiveFormsModule],
    declarations: [PersonRoleComponent],
    providers: [PersonRoleService]
})
export class PersonRoleModule { }