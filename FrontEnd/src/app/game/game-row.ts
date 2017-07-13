import { Injectable } from '@angular/core';

export class GameRow {
    one: string;
    two: string;
    three: string;

    constructor() {
        this.one = 'inactive';
        this.two = 'inactive';
        this.three = 'inactive';
    }

    toggleStateOne(color: string) {
        if (this.one == 'inactive') { this.one = color; return true; }
        return false;
    }

    toggleStateTwo(color: string) {
        if (this.two == 'inactive') { this.two = color; return true;}
        return false;
    }

    toggleStateThree(color: string) {
        if (this.three == 'inactive') { this.three = color; return true;}
        return false;
    }
}