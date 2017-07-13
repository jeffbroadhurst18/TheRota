import { Component, Input, } from '@angular/core';
//trigger, state, style, transition, animate 
import { gameanimation1 } from './game-animation';
import { GameRow } from './game-row';

@Component({
   // moduleId: module.id,
    selector: 'my-game',
    templateUrl: 'game.component.html',
    styleUrls: ['game.css'],
    providers: [],
    animations: [gameanimation1]
})

export class GameComponent {
    constructor() { }

    ngOnInit(): void {
        this.setUp();
        this.nextcolor = "green";
    }

    nextcolor: string;
    rows: Array<GameRow>;
    changed: boolean;
    selected: Array<number>;
    winnerName: string;
    haveAWinner : boolean;

    private setUp() {
        this.rows = new Array<GameRow>();
        this.selected = new Array<number>();
        this.winnerName = null;
        this.haveAWinner = false;

        for (var i = 0; i < 3; i++) {
            this.rows[i] = new GameRow();
        }
    }

    processClick(col: number, gameRow: GameRow) {
        if (this.haveAWinner){return;}
        if (col == 1) {
            this.changed = gameRow.toggleStateOne(this.nextcolor);
        }
        if (col == 2) {
            this.changed = gameRow.toggleStateTwo(this.nextcolor);
        }
        if (col == 3) {
            this.changed = gameRow.toggleStateThree(this.nextcolor);
        }
        this.checkResults(this.nextcolor);
        if (this.changed) {
            this.nextcolor = (this.nextcolor === 'green') ? 'red' : 'green';
        }
    }

    restart() {
        this.setUp();
    }

    checkResults(checkColor: string) {
        this.selected = new Array<number>();

        for (var i = 0; i < 3; i++) {
            if (this.rows[i].one == checkColor) { this.selected.push(1 + (3 * i)); }
            if (this.rows[i].two == checkColor) { this.selected.push(2 + (3 * i)); }
            if (this.rows[i].three == checkColor) { this.selected.push(3 + (3 * i)); }
        }

        if (this.isWinner([1, 2, 3])) { this.winnerName = checkColor; this.haveAWinner=true; return;}
        if (this.isWinner([4, 5, 6])) { this.winnerName = checkColor; this.haveAWinner=true; return;}
        if (this.isWinner([7, 8, 9])) { this.winnerName = checkColor; this.haveAWinner=true; return;}
        if (this.isWinner([1, 4, 7])) { this.winnerName = checkColor; this.haveAWinner=true; return;}
        if (this.isWinner([2, 5, 8])) { this.winnerName = checkColor; this.haveAWinner=true; return;}
        if (this.isWinner([3, 6, 9])) { this.winnerName = checkColor; this.haveAWinner=true; return;}
        if (this.isWinner([1, 5, 9])) { this.winnerName = checkColor; this.haveAWinner=true; return;}
        if (this.isWinner([3, 5, 7])) { this.winnerName = checkColor; this.haveAWinner=true; return;}
    }

    isWinner(winners: Array<number>): boolean {
        var counter: number;
        counter = 0;
        for (var k = 0; k < 3; k++) {
            if (this.selected.includes(winners[k])) { counter++; }
        }
        if (counter == 3) { return true; }
        return false;
    }
}