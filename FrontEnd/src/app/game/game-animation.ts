import { trigger,state,style,transition,animate } from '@angular/core';

export const gameanimation1 = trigger('squareState', [
     state('inactive', style({background: '#eee'})),
     state('red', style({background: 'red'})),
     state('green', style({background: 'green'})),
     transition('inactive => red', animate('500ms ease-in')),
     transition('inactive => green', animate('500ms ease-out'))
 ]);