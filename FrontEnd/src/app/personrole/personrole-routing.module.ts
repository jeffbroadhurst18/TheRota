import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { PersonRoleComponent } from './personrole.component';

@NgModule({
  imports: [RouterModule.forChild([
    { path: 'personrole', component: PersonRoleComponent }
  ])],
  exports: [RouterModule]
})
export class PersonRoleRoutingModule {}