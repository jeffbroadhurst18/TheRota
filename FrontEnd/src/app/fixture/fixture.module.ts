import { NgModule } from '@angular/core';
import { FormsModule,ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

import { FixtureComponent } from './fixture.component';
import { FixtureRoutingModule } from './fixture-routing.module';
import { FixtureService } from './fixture.service';

@NgModule({
    imports: [FormsModule, CommonModule, FixtureRoutingModule, ReactiveFormsModule],
    declarations: [FixtureComponent],
    providers: [FixtureService]
})
export class FixtureModule { }