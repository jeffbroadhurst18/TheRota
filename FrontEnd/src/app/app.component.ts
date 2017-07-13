import { Component, OnInit } from '@angular/core';


@Component({
    selector: 'my-app',
    templateUrl: 'app.component.html',
})
export class AppComponent {
    title = 'The Rota';
    showSidebar: Boolean;
    showAlternateColour: Boolean;

    ngOnInit(): void {
        this.showSidebar = true;
        this.showAlternateColour = false;
    }

    sidebarToggle() {
        this.showSidebar = !this.showSidebar;
    }

    colourToggle() {
        this.showAlternateColour = !this.showAlternateColour;
    }
}

