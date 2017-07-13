import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';

import { GameComponent } from './game.component';
import { GameRoutingModule } from './game-routing.module';

@NgModule({
    imports: [FormsModule, CommonModule, GameRoutingModule],
    declarations: [GameComponent],
    providers: []
})
export class GameModule { }