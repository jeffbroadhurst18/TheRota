import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { GameComponent } from './game.component';

@NgModule({
  imports: [RouterModule.forChild([
    { path: 'game', component: GameComponent }
  ])],
  exports: [RouterModule]
})
export class GameRoutingModule {}