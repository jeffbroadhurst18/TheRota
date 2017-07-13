import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { HttpModule } from '@angular/http';
import { CommonModule }       from '@angular/common';

import { WeatherComponent} from './weather.component';
import { WeatherService} from './weather.service';
import { WeatherRoutingModule} from './weather-routing.module';
import { TransformLocationPipe} from './weather.component.pipe';

@NgModule({
  imports:      [ FormsModule,CommonModule,WeatherRoutingModule ],
  declarations: [ WeatherComponent,TransformLocationPipe ],
  providers:    [ WeatherService ] 
})
export class WeatherModule { }