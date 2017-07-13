import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';

const routes: Routes = [
      {
            path: 'game',
            redirectTo: 'game',
            pathMatch: 'full'
      },
      {
            path: 'weather',
            redirectTo: 'weather',
            pathMatch: 'full'
      },
      {
            path: '',
            redirectTo: '/game',
            pathMatch: 'full'
      },
      {
            path: 'person',
            redirectTo: '/person',
            pathMatch: 'full'
      }
];

@NgModule({
      imports: [RouterModule.forRoot(routes)],
      exports: [RouterModule]
})
export class AppRoutingModule { }