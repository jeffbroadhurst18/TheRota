import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { WeatherComponent } from './weather.component';

@NgModule({
  imports: [RouterModule.forChild([
    { path: 'weather', component: WeatherComponent }
  ])],
  exports: [RouterModule]
})
export class WeatherRoutingModule {}