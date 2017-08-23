import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { FixtureComponent } from './fixture.component';

@NgModule({
  imports: [RouterModule.forChild([
    { path: 'fixture', component: FixtureComponent }
  ])],
  exports: [RouterModule]
})
export class FixtureRoutingModule {}