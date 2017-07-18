import { NgModule } from '@angular/core';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { RoleService } from './role.service';

@NgModule({
    imports: [FormsModule, CommonModule, ReactiveFormsModule],
    providers: [RoleService]
})
export class RoleModule { } 